using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;

namespace C1.Win.C1Editor.Import
{
	/// <summary>
	/// Exposes a <see cref="LoadWord(C1Editor, string)"/> method to load a Word document-compatible file in <see cref="C1Editor"/>
	/// </summary>
	public static class WordImport
	{
		/// <summary>
		/// Loads a Word-compatible document in the <see cref="C1Editor"/>
		/// </summary>
		/// <remarks>This method saves the file from MSWord to a temporary file, then loads it to C1Editor.</remarks>
		/// <param name="editor">Editor to </param>
		/// <param name="fileName">File name.</param>
		public static void LoadWord(this C1Editor editor, string fileName)
		{
			var app = new ApplicationClass();
			app.DisplayAlerts = WdAlertLevel.wdAlertsNone;
			object nullobj = Missing.Value;
			object makeFalse = false;
			object tempFileName = Path.GetTempFileName();
			try
			{
				object fileFormt = WdSaveFormat.wdFormatFilteredHTML;
				app.Visible = false;
				var doc = app.Documents.Open(Path.GetFullPath(fileName));
				doc.WebOptions.Encoding = MsoEncoding.msoEncodingUTF8;
				foreach (InlineShape s in doc.InlineShapes)
				{
					if (s.Type == WdInlineShapeType.wdInlineShapeLinkedPicture)
						if (s.LinkFormat?.SourcePath != null)
							if (s.LinkFormat.SourcePath.ToLower().Contains("ourimagesdirectory"))
								s.LinkFormat.SavePictureWithDocument = true;
					s.LinkFormat?.Update();
				}

				doc.SaveAs(ref tempFileName, ref fileFormt,
					ref makeFalse, ref nullobj, ref makeFalse,
					ref nullobj, ref nullobj, ref nullobj, ref makeFalse, ref nullobj, ref nullobj,
					ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj);


				doc.Close(ref nullobj, ref nullobj, ref nullobj);
			}
			finally
			{
				app.Quit(ref nullobj, ref nullobj, ref nullobj);
			}

			string html = File.ReadAllText((string)tempFileName);
			File.Delete((string)tempFileName);
			editor.Xml = html;
		}

		/// <summary>
		/// Loads a Word-compatible document in the <see cref="C1Editor"/>
		/// </summary>
		/// <remarks>This method uses clipboard copy-from-MSWord paste-to-C1Editor approach.</remarks>
		/// <param name="editor">Editor to </param>
		/// <param name="fileName">File name.</param>
		public static void LoadWordClipboard(this C1Editor editor, string fileName)
		{
			if (!File.Exists(fileName)) throw new FileNotFoundException("File not found", fileName);

			//save clipboard for further restoring
			IDataObject dataObject = BackupClipboard();

			object nullobj = Missing.Value;
			var app = new ApplicationClass();
			try
			{
				app.Visible = false;
				var doc = app.Documents.Open(Path.GetFullPath(fileName));


				doc.ActiveWindow.Selection.WholeStory();
				doc.ActiveWindow.Selection.Copy();

				editor.SelectAll();
				editor.Paste();

				doc.Close(ref nullobj, ref nullobj, ref nullobj);
			}
			finally
			{
				app.Quit(ref nullobj, ref nullobj, ref nullobj);
				RestoreClipboard(dataObject);
			}
		}

		/// <summary>
		/// Restores clipboard.
		/// </summary>
		/// <param name="dataObject">Data to restore.</param>
		static void RestoreClipboard(IDataObject dataObject)
		{
			try
			{
				UIPermission clipBoard = new UIPermission(PermissionState.None);
				clipBoard.Clipboard = UIPermissionClipboard.AllClipboard;
				Clipboard.SetDataObject(dataObject, true, 3, 100);
			}
			catch (ExternalException e)
			{
				Debug.WriteLine($"Could not restore clipboard. {e.Message}");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>Data, saved from clipboard</returns>
		static IDataObject BackupClipboard()
		{
			DataObject data = new DataObject();
			var clipboardData = Clipboard.GetDataObject();
			if (clipboardData != null)
				foreach (var format in clipboardData.GetFormats())
					data.SetData(format, clipboardData.GetData(format));
			return data;
		}
	}
}