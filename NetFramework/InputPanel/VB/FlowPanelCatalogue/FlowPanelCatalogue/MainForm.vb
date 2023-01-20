Imports C1.Win.C1InputPanel
Imports C1.Win.C1Themes
Imports C1.Win.Ribbon
Imports FlowPanelCatalogue.FlowPanelCatalogue
Imports Microsoft.Data.Sqlite
Imports System.IO

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCatalogueData()
        InitThemes()
    End Sub

    Private Sub GetCatalogueData()

        Dim catalogueItems As List(Of CatalogueItem) = New List(Of CatalogueItem)()
        Dim dbPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\\ComponentOne Samples\\Common\\C1NWind.db"
        Dim connString As String = "Data Source=" & dbPath & ";Version=3;"

        If File.Exists(dbPath) Then

            Using conn As SqliteConnection = New SqliteConnection(connString)
                conn.Open()
                Dim command As SqliteCommand = New SqliteCommand()
                command.Connection = conn
                command.CommandText = "Select Brand, Model, Category, Description, Hyperlink, Picture, Price from Cars limit 15"
                Using reader As SqliteDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim stream As MemoryStream = New MemoryStream(Convert.FromBase64String(reader.GetValue(5).ToString().TrimStart().TrimEnd()))
                            Dim bitmap As Bitmap = New Bitmap(stream)
                            catalogueItems.Add(New CatalogueItem(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), bitmap, reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), Convert.ToInt32(reader.GetValue(6))))
                        End While
                    End If
                End Using

                conn.Close()
            End Using
        Else
            catalogueItems.Add(New FlowPanelCatalogue.CatalogueItem("Rolls-Royce", "Wraith", (CType((My.Resources.Resource1.rolls_roys_Wraith), System.Drawing.Bitmap)), "SALOON", "Antilock brakes, traction control and automatic ride control are standard.Side - impact airbags are not available.", "<a href=""http://www.rollsroyce.com"">http://www.rollsroyce.com</a>", 370485))
            catalogueItems.Add(New FlowPanelCatalogue.CatalogueItem("Jaguar", "F-TYPE I", (CType((My.Resources.Resource1.Jaguar_F_type1), System.Drawing.Bitmap)), "SPORTS", "ENGINE & DRIVETRAIN", "<a href=""http://www.jaguarusa.com"">http://www.jaguarusa.com</a>", 73000))
            catalogueItems.Add(New FlowPanelCatalogue.CatalogueItem("Ford", "Ranger VI", (CType((My.Resources.Resource1.Ford_Ranger), System.Drawing.Bitmap)), "TRUCK", "Ford's compact Ranger pickup earned a freshened front end last year and comes with several new option groups this year. The most notable new offering is the FX-4 offroad package for the four-door SuperCab chassis, which combines off-the-pavement functionality with an appealing Styleside-box appearance. Powered by a 4.0-liter V-6 engine, the FX-4 group includes Bilstein shocks, heavy-duty springs, three skid plates, tow hooks and forged-aluminum wheels.", " <a href=""http://www.ford.com"">http://www.ford.com</a>", 12565))
            catalogueItems.Add(New FlowPanelCatalogue.CatalogueItem("Lexus", "ES VI Sedan", (CType((My.Resources.Resource1.lexus_ES_VI_Sedan), System.Drawing.Bitmap)), "SALOON", "Redesigned for 2001 with more aerodynamic styling and a bigger V-8 engine than the previous LS 400, the full-size, rear-drive flagship sedan from Toyota's luxury division gets only a single new color, Platinum Blue Pearl, for 2002. The 4.3-liter V-8 makes 290 horsepower and teams with a five-speed-automatic transmission.", "<a href=""http://www.lexus.com"">http://www.lexus.com</a>", 54900))
            catalogueItems.Add(New FlowPanelCatalogue.CatalogueItem("Mercedes-Benz", "SLK R172 Cabriolet", (CType((My.Resources.Resource1.Mercedes_Benz_SLK_250), System.Drawing.Bitmap)), "SPORTS", "Engine 4,966-cc SOHC 24-valve 90° V-8. High-pressure die-cast alloy cylinder block, alloy heads. Fuel and ignition system ME 2.8 engine management. Integrated sequential multipoint fuel injection and phased twin-spark ignition includes individual cylinder control of fuel spray, spark timing/phase and antiknock. Two high-energy ignition coils and two spark plugs per cylinder, with 100,000-mile spark plug intervals. Electronic throttle control.", "<a href=""http://www.mercedes.com"">http://www.mercedes.com</a>", 83800))
        End If

        For Each item As FlowPanelCatalogue.CatalogueItem In catalogueItems
            Me.inputFlowPanel1.Items.Add(GenerateItemCard(item))
        Next
    End Sub

    Private Function GenerateItemCard(ByVal item As FlowPanelCatalogue.CatalogueItem) As InputGridPanel
        Dim inputGridPanel1 As InputGridPanel = New InputGridPanel()
        Dim itemImage As InputImage = New InputImage()
        Dim itemBrand As InputLabel = New InputLabel()
        Dim inputLabel2 As InputLabel = New InputLabel()
        Dim inputLabel3 As InputLabel = New InputLabel()
        Dim itemLink As InputHtmlLabel = New InputHtmlLabel()
        Dim inputLabel4 As InputLabel = New InputLabel()
        Dim itemDescription As InputLabel = New InputLabel()
        Dim itemCost As InputLabel = New InputLabel()
        Dim itemModel As InputLabel = New InputLabel()
        Dim inputLabel1 As InputLabel = New InputLabel()
        Dim itemCategory As InputLabel = New InputLabel()
        inputGridPanel1.ColumnDefinitions.Add(New ColumnDefinition())
        inputGridPanel1.ColumnDefinitions.Add(3)
        inputGridPanel1.ColumnDefinitions(0).Width = 150
        inputGridPanel1.ColumnDefinitions(0).SizeType = SizeType.Absolute
        inputGridPanel1.ColumnDefinitions(1).Width = 70
        inputGridPanel1.ColumnDefinitions(1).SizeType = SizeType.Absolute
        inputGridPanel1.RowDefinitions.Add(5)
        inputGridPanel1.Break = BreakType.None
        inputGridPanel1.Items.Add(itemBrand)
        inputGridPanel1.Items.Add(itemModel)
        inputGridPanel1.Items.Add(itemImage)
        inputGridPanel1.Items.Add(inputLabel1)
        inputGridPanel1.Items.Add(itemCategory)
        inputGridPanel1.Items.Add(inputLabel2)
        inputGridPanel1.Items.Add(itemDescription)
        inputGridPanel1.Items.Add(inputLabel3)
        inputGridPanel1.Items.Add(itemLink)
        inputGridPanel1.Items.Add(inputLabel4)
        inputGridPanel1.Items.Add(itemCost)
        inputGridPanel1.Name = "inputGridPanel1"
        inputGridPanel1.Padding = New System.Windows.Forms.Padding(10)
        inputGridPanel1.Width = 400
        itemBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
        itemBrand.HorizontalAlign = InputContentAlignment.Near
        itemBrand.Text = item.Brand
        itemBrand.VerticalAlign = InputContentAlignment.Center
        itemModel.ColumnIndex = 1
        itemModel.ColumnSpan = 2
        itemModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0F, (CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic)), System.Drawing.FontStyle)), System.Drawing.GraphicsUnit.Point, (CByte((204))))
        itemModel.Name = "itemModel"
        itemModel.Text = item.Model
        itemModel.VerticalAlign = InputContentAlignment.Center

        itemImage.ImageAlign = InputImageAlignment.MiddleCenter
        itemImage.Image = item.ItemImage
        itemImage.RowIndex = 1
        itemImage.RowSpan = 4
        itemImage.VerticalAlign = InputContentAlignment.Near
        itemImage.Width = 142
        itemImage.ImageScaling = InputImageScaling.Scale
        inputLabel1.ColumnIndex = 1
        inputLabel1.HorizontalAlign = InputContentAlignment.Near
        inputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
        inputLabel1.Padding = New System.Windows.Forms.Padding(2)
        inputLabel1.RowIndex = 1
        inputLabel1.Text = "Category:"
        inputLabel1.VerticalAlign = InputContentAlignment.Center
        itemCategory.ColumnIndex = 2
        itemCategory.HorizontalAlign = InputContentAlignment.Near
        itemCategory.Padding = New System.Windows.Forms.Padding(2)
        itemCategory.RowIndex = 1
        itemCategory.Text = item.Category
        itemCategory.VerticalAlign = InputContentAlignment.Center
        inputLabel2.ColumnIndex = 1
        inputLabel2.HorizontalAlign = InputContentAlignment.Near
        inputLabel2.Padding = New System.Windows.Forms.Padding(2)
        inputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
        inputLabel2.RowIndex = 4
        inputLabel2.Text = "Description:"
        inputLabel2.VerticalAlign = InputContentAlignment.Near
        itemDescription.ColumnIndex = 2
        itemDescription.Height = -1
        itemDescription.Text = item.Description
        itemDescription.WordWrap = True
        itemDescription.RowIndex = 4
        itemDescription.HorizontalAlign = InputContentAlignment.Spread
        itemDescription.VerticalAlign = InputContentAlignment.Near
        inputLabel3.ColumnIndex = 1
        inputLabel3.HorizontalAlign = InputContentAlignment.Near
        inputLabel3.Padding = New System.Windows.Forms.Padding(2)
        inputLabel3.RowIndex = 3
        inputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
        inputLabel3.Text = "Details:"
        inputLabel3.VerticalAlign = InputContentAlignment.Center
        itemLink.ColumnIndex = 2
        itemLink.HorizontalAlign = InputContentAlignment.Near
        itemLink.Padding = New System.Windows.Forms.Padding(2)
        itemLink.RowIndex = 3
        itemLink.Text = item.Details
        itemLink.VerticalAlign = InputContentAlignment.Center
        inputLabel4.ColumnIndex = 1
        inputLabel4.HorizontalAlign = InputContentAlignment.Near
        inputLabel4.Padding = New System.Windows.Forms.Padding(2)
        inputLabel4.RowIndex = 2
        inputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
        inputLabel4.Text = "Cost:"
        inputLabel4.VerticalAlign = InputContentAlignment.Center
        itemCost.ColumnIndex = 2
        itemCost.Padding = New System.Windows.Forms.Padding(2)
        itemCost.RowIndex = 2
        itemCost.Text = item.Cost
        itemCost.VerticalAlign = InputContentAlignment.Center
        Return inputGridPanel1
    End Function

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        C1ThemeController1.Theme = cmbThemes.SelectedItem.Text
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office2016"))

        For Each theme In themes
            cmbThemes.Items.Add(theme)
        Next
    End Sub

#End Region

End Class
