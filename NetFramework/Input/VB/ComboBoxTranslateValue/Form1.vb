Imports C1.Win.Themes

Public Class Form1
    ''' <summary>
    ''' Occurs when Form1 loaded.
    ''' </summary>
    ''' <param name="sender">Form1 object. </param>
    ''' <param name="e">Event data.</param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common")
        'TODO: This line of code loads data into the 'C1NWindDataSet.Customer_demo' table. You can move, or remove it, as needed.
        Me.Customer_demoTableAdapter.Fill(Me.C1NWindDataSet.Customer_demo)
        'TODO: This line of code loads data into the 'C1NWindDataSet.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.C1NWindDataSet.Order)
        LoadThemes()
    End Sub
    ''' <summary>
    ''' Loads themes list from xml-file And set as data source for the themesBindingSource.
    ''' </summary>
    ''' <remarks>
    ''' Linq2xml query Is used as a data source for a BindingSource which Is used as a DataSource for the themes ComboBox.
    ''' </remarks>
    Private Sub LoadThemes()
        Dim themes = C1ThemeController.GetThemes()
        For Each theme In themes
            _themes.Items.Add(theme)
        Next
        _themes.SelectedIndex = _themes.Items.IndexOf("Office365White")
    End Sub
    ''' <summary>
    ''' Occurs when selected item changed. Changes current theme of the application.
    ''' </summary>
    ''' <param name="sender">C1ComboBox object.</param>
    ''' <param name="e">Event data.</param>
    Private Sub _themes_SelectedItemChanged(sender As Object, e As EventArgs) Handles _themes.SelectedItemChanged
        C1ThemeController1.Theme = _themes.SelectedItem.ToString()
    End Sub
    ''' <summary>
    ''' Occurs when Add button clicked. Adds New empty row to grid.
    ''' </summary>
    ''' <param name="sender">C1Button object.</param>
    ''' <param name="e">Event data.</param>
    Private Sub _addBtn_Click(sender As Object, e As EventArgs) Handles _addBtn.Click
        orderBindingSource.AddNew()
        _customerEdit.Clear()
    End Sub
End Class
