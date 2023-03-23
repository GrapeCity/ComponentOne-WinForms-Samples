Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents lklMergeCells As System.Windows.Forms.LinkLabel
    Friend WithEvents lklStyles As System.Windows.Forms.LinkLabel
    Friend WithEvents lklSubTotals As System.Windows.Forms.LinkLabel
    Friend WithEvents lklBalanceSheet As System.Windows.Forms.LinkLabel
    Friend WithEvents lklDatabinding As System.Windows.Forms.LinkLabel
    Friend WithEvents lklEditing As System.Windows.Forms.LinkLabel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lklMergeCells = New System.Windows.Forms.LinkLabel
        Me.lklStyles = New System.Windows.Forms.LinkLabel
        Me.lklSubTotals = New System.Windows.Forms.LinkLabel
        Me.lklBalanceSheet = New System.Windows.Forms.LinkLabel
        Me.lklDatabinding = New System.Windows.Forms.LinkLabel
        Me.lklEditing = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'lklMergeCells
        '
        Me.lklMergeCells.AutoSize = True
        Me.lklMergeCells.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklMergeCells.Location = New System.Drawing.Point(12, 9)
        Me.lklMergeCells.Name = "lklMergeCells"
        Me.lklMergeCells.Size = New System.Drawing.Size(73, 15)
        Me.lklMergeCells.TabIndex = 6
        Me.lklMergeCells.TabStop = True
        Me.lklMergeCells.Text = "Merge Cells"
        '
        'lklStyles
        '
        Me.lklStyles.AutoSize = True
        Me.lklStyles.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklStyles.Location = New System.Drawing.Point(12, 37)
        Me.lklStyles.Name = "lklStyles"
        Me.lklStyles.Size = New System.Drawing.Size(40, 15)
        Me.lklStyles.TabIndex = 7
        Me.lklStyles.TabStop = True
        Me.lklStyles.Text = "Styles"
        '
        'lklSubTotals
        '
        Me.lklSubTotals.AutoSize = True
        Me.lklSubTotals.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklSubTotals.Location = New System.Drawing.Point(12, 69)
        Me.lklSubTotals.Name = "lklSubTotals"
        Me.lklSubTotals.Size = New System.Drawing.Size(63, 15)
        Me.lklSubTotals.TabIndex = 8
        Me.lklSubTotals.TabStop = True
        Me.lklSubTotals.Text = "SubTotals"
        '
        'lklBalanceSheet
        '
        Me.lklBalanceSheet.AutoSize = True
        Me.lklBalanceSheet.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklBalanceSheet.Location = New System.Drawing.Point(126, 69)
        Me.lklBalanceSheet.Name = "lklBalanceSheet"
        Me.lklBalanceSheet.Size = New System.Drawing.Size(87, 15)
        Me.lklBalanceSheet.TabIndex = 9
        Me.lklBalanceSheet.TabStop = True
        Me.lklBalanceSheet.Text = "Balance Sheet"
        '
        'lklDatabinding
        '
        Me.lklDatabinding.AutoSize = True
        Me.lklDatabinding.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklDatabinding.Location = New System.Drawing.Point(126, 9)
        Me.lklDatabinding.Name = "lklDatabinding"
        Me.lklDatabinding.Size = New System.Drawing.Size(78, 15)
        Me.lklDatabinding.TabIndex = 10
        Me.lklDatabinding.TabStop = True
        Me.lklDatabinding.Text = "Data Binding"
        '
        'lklEditing
        '
        Me.lklEditing.AutoSize = True
        Me.lklEditing.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklEditing.Location = New System.Drawing.Point(126, 37)
        Me.lklEditing.Name = "lklEditing"
        Me.lklEditing.Size = New System.Drawing.Size(45, 15)
        Me.lklEditing.TabIndex = 11
        Me.lklEditing.TabStop = True
        Me.lklEditing.Text = "Editing"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(230, 105)
        Me.Controls.Add(Me.lklEditing)
        Me.Controls.Add(Me.lklDatabinding)
        Me.Controls.Add(Me.lklBalanceSheet)
        Me.Controls.Add(Me.lklSubTotals)
        Me.Controls.Add(Me.lklStyles)
        Me.Controls.Add(Me.lklMergeCells)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid printing Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub MenuLink_Clicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklMergeCells.LinkClicked, lklStyles.LinkClicked, lklSubTotals.LinkClicked, lklBalanceSheet.LinkClicked, lklDatabinding.LinkClicked, lklEditing.LinkClicked

        ' Point to the control that was selected
        Dim btnMenu As Control = sender

        btnMenu.Cursor = Cursors.WaitCursor

        Select Case btnMenu.Text
            ' Show the selected sample.
            Case "SubTotals"
                Dim pfrmTotals As New frmSubtotals()
                pfrmTotals.ShowDialog()

            Case "Styles"
                Dim pfrmStyles As New frmStyles()
                pfrmStyles.ShowDialog()

            Case "Merge Cells"
                Dim pfrmMerge As New frmMerge()
                pfrmMerge.ShowDialog()

            Case "Balance Sheet"
                Dim pfrmSheet As New frmSheet()
                pfrmSheet.ShowDialog()

            Case "Data Binding"
                Dim pfrmData As New frmData()
                pfrmData.ShowDialog()

            Case "Editing"
                Dim pfrmEdit As New frmEdit()
                pfrmEdit.ShowDialog()

            Case Else
                MsgBox("Sorry, this demo is not available at this time.", MsgBoxStyle.Exclamation, "ComponentOne Studio")

        End Select

        btnMenu.Cursor = Cursors.Default

    End Sub

End Class
