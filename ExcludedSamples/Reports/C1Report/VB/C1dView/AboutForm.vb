Option Explicit On
Option Strict On

Imports System.Reflection
Imports System.Text

Public Class AboutForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' show C1Report version
        Dim a As Assembly = Assembly.GetAssembly(GetType(C1.C1Report.C1Report))
        Dim v As Version = a.GetName().Version
        Dim year As Integer = CInt(v.Build / 10)
        _lblCopyright.Text = String.Format(_lblCopyright.Text, year)

        '' show C1dView and all other loaded C1 assemblies:
        Dim getName As Func(Of AssemblyName, String) = Function(asmName) String.Format("{0}, Version {1}", asmName.Name, asmName.Version)
        ''
        Dim entryAssembly = Assembly.GetEntryAssembly()
        Dim entryName = entryAssembly.GetName()
        Dim sb = New StringBuilder()
        sb.AppendFormat("{0} Application ({1} bit mode):", entryName.Name, IntPtr.Size * 8)
        sb.AppendLine()
        sb.AppendLine(getName(entryName))
        '' get a sorted list of all C1 assemblies:
        Dim asms = AppDomain.CurrentDomain.GetAssemblies().ToList() _
            .Where(Function(asm_) asm_ <> entryAssembly) _
            .Select(Function(asm_) asm_.GetName()) _
            .Where(Function(asmName_) asmName_.Name.ToLower().StartsWith("c1"))

        Dim asmNames = asms.ToList()
        asmNames.Sort(Function(asm1_, asm2_) StringComparer.OrdinalIgnoreCase.Compare(asm1_.Name, asm2_.Name))
        asmNames.ForEach(Function(asmName) sb.AppendLine(getName(asmName)))
        ''
        _lblInstalledComponents.Text = sb.ToString()
        '' set up caption:
        Me.Text = String.Format("About {0}", entryName.Name)

    End Sub

    Private Sub _linkSubmitIncident_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _linkSubmitIncident.LinkClicked

    End Sub
End Class