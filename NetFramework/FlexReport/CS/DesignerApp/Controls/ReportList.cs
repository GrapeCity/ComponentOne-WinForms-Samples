//----------------------------------------------------------------------------
// ReportList.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

using C1.Win.FlexReport;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
	/// ReportList, ReportItem:
	/// helper classes used to store reports in ListView control
	/// </summary>
	internal class ReportList : ListView
	{
        private int _index = -1;
        // indices into image list
        internal const int _imgReport = 0;
        private const int _imgReportContainer = 1;

        #region Constructors
        public ReportList()
		{
            DoubleBuffered = true;
			HideSelection = false;
			FullRowSelect = true;
			HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			LabelEdit = true;
			MultiSelect = false;
			View = System.Windows.Forms.View.Details;
			Columns.Add(new ColumnHeader());
            // Columns[0].Width = Screen.PrimaryScreen.Bounds.Width;
            // Columns[0].Width = this.Width;
            // this.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        #endregion

        #region Protected
        protected override void OnAfterLabelEdit(LabelEditEventArgs e)
        {
            base.OnAfterLabelEdit(e);
            // ListView updates item text only after this is called, so we need to set text manually for the autosizing to work:
            if (e.Label != null)
            {
                ((ReportItem)this.Items[e.Item]).Text = e.Label;
                AdjustSize();
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyData == Keys.F2)
            {
                if (this.Focused && (this.SelectedItem is ReportItem))
                {
                    this.SelectedItem.BeginEdit();
                    e.Handled = true;
                }
            }
        }
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            _index = -1;

            // find item that is selected
            for (int i = 0; i < base.Items.Count && _index < 0; i++)
            {
                if (base.Items[i].Selected)
                    _index = i;
            }

            // nothing selected, find item that has the focus
            if (_index < 0)
            {
                for (int i = 0; i < base.Items.Count && _index < 0; i++)
                {
                    if (base.Items[i].Focused)
                        _index = i;
                }
            }

            // fire event
            if (_index > -1 || base.Items.Count == 0)
            {
                base.OnSelectedIndexChanged(e);
            }
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int SelectedIndex
		{
			get 
			{
				// sanity (in case list has been cleared)
				if (_index >= base.Items.Count)
					_index = -1;
				return _index; 
			}
			set
			{ 
                foreach (ListViewItem lvi in base.Items)
                {
                    lvi.Selected = (lvi.Index == value);
                    if (lvi.Selected)
                    {
                        lvi.EnsureVisible();
						if (base.Focused)
						{
							lvi.Focused = true;
						}
                    }
                }
				OnSelectedIndexChanged(EventArgs.Empty);
			}
		}
		[Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ReportItem SelectedItem
		{
			get
            {
                // sanity (item could have been deleted)
                if (_index < 0)
                    return null;
				if (_index >= this.Items.Count)
					OnSelectedIndexChanged(EventArgs.Empty);

                // return value
                return (_index < 0)? null : (ReportItem)base.Items[_index]; 
            }
        }
        #endregion

        #region Public
        /// <summary>
        /// Call this to resize the width of the column to accommodate all report names.
        /// </summary>
        public void AdjustSize()
        {
            this.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        public void UpdateIcons()
		{
			// scan all reports on the list
			foreach (ReportItem rpt in Items)
			{
				// scan fields looking for subreports
				int imgIndex = _imgReport;
				foreach (var f in rpt.Report.Fields)
				{
                    if (f is Field && ((Field)f).Subreport != null)
                    {
                        imgIndex = _imgReportContainer;
                        break;
                    }
                    else if (f is SubreportField && ((SubreportField)f).Subreport != null)
                    {
                        imgIndex = _imgReportContainer;
                        break;
                    }
				}
				// update image
				if (imgIndex != rpt.ImageIndex)
					rpt.ImageIndex = imgIndex;
			}
        }
        #endregion
    }

	/// <summary>
	/// ReportItem
	/// </summary>
	internal class ReportItem : ListViewItem
	{
        public ReportItem(C1FlexReport flexReport)
		{
            Report = flexReport;
            base.Text = flexReport.ReportName;
			base.ImageIndex = ReportList._imgReport;
        }

        public C1FlexReport Report { get; private set; }

        public override string ToString()
		{
            return Report.ReportName;
        }
    }
}
