Imports System.Windows.Forms.VisualStyles

Public Class ImageEditor

    Public Sub New(imgList__1 As ImageList)
        InitializeComponent()
        ImgList = imgList__1
        lvImages.StateImageList = New ImageList()
        FillCombobox(cmbImageTypes)
        cmbImageTypes.SelectedIndex = 0
        FillImages()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ofd = New OpenFileDialog()
        ofd.CheckFileExists = True
        ofd.Multiselect = False
        ofd.Filter = "All image files (*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico)|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico"
        If ofd.ShowDialog() = DialogResult.OK Then
            AddItem(Image.FromFile(ofd.FileName), cmbImageTypes.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lvImages.SelectedItems.Count > 0 Then
            RemoveItem(lvImages.SelectedItems(0).Name)
        End If
    End Sub

    Private Sub FillImages()
        For Each key As String In ImgList.Images.Keys
            AddItem(ImgList.Images(key), key)
        Next
    End Sub

    Protected Sub AddItem(image As Image, name As String)
        RemoveItem(name)

        lvImages.StateImageList.Images.Add(name, image)

        Dim item = New ListViewItem()
        item.StateImageIndex = lvImages.StateImageList.Images.IndexOfKey(name)
        item.Name = name
        item.Text = name
        lvImages.Items.Add(item)
    End Sub

    Private Sub RemoveItem(name As String)
        If lvImages.StateImageList.Images.ContainsKey(name) Then
            lvImages.StateImageList.Images.RemoveByKey(name)
        End If

        If lvImages.Items.ContainsKey(name) Then
            lvImages.Items.RemoveByKey(name)
        End If

        For Each item As ListViewItem In lvImages.Items
            item.StateImageIndex = lvImages.StateImageList.Images.IndexOfKey(item.Name)
        Next
    End Sub

    Protected Overridable Sub FillCombobox(cmb As ComboBox)

    End Sub

    Protected Property ImgList() As ImageList
        Get
            Return m_ImgList
        End Get
        Set
            m_ImgList = Value
        End Set
    End Property

    Private m_ImgList As ImageList

    Public Sub FillImageList()
        ImgList.Images.Clear()
        For Each item As ListViewItem In lvImages.Items
            ImgList.Images.Add(item.Name, lvImages.StateImageList.Images(item.StateImageIndex))
        Next
    End Sub

End Class

Public Class CheckStateImageEditor
    Inherits ImageEditor
    Public Sub New(imgList As ImageList)

        MyBase.New(imgList)
    End Sub

    Protected Overrides Sub FillCombobox(cmb As ComboBox)
        For Each key As String In [Enum].GetNames(GetType(CheckBoxState))
            If ImgList.Images.ContainsKey(key) Then
                AddItem(ImgList.Images(key), key)
            End If
            cmb.Items.Add(key)
        Next
    End Sub
End Class

Public Class ButtonStateImageEditor
    Inherits ImageEditor
    Public Sub New(imgList As ImageList)

        MyBase.New(imgList)
    End Sub

    Protected Overrides Sub FillCombobox(cmb As ComboBox)
        AddCmbItem(cmb, "CollapsedNormal")
        AddCmbItem(cmb, "CollapsedHot")
        AddCmbItem(cmb, "CollapsedPressed")
        AddCmbItem(cmb, "CollapsedDisabled")
        AddCmbItem(cmb, "ExpandedNormal")
        AddCmbItem(cmb, "ExpandedHot")
        AddCmbItem(cmb, "ExpandedPressed")
        AddCmbItem(cmb, "ExpandedDisabled")
    End Sub

    Private Sub AddCmbItem(cmb As ComboBox, key As String)
        If ImgList.Images.ContainsKey(key) Then
            AddItem(ImgList.Images(key), key)
        End If
        cmb.Items.Add(key)
    End Sub
End Class