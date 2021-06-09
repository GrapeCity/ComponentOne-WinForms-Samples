using C1.C1Preview;
using C1.C1Preview.DataBinding;
using C1.Win.Ribbon;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimpleReports
{
    public partial class MainForm : Form
    {
        #region ** fields

        private RibbonComboBox _reportsCombo;

        private readonly string[] _reportsList = new string[]
        {
            "Alphabetical List of Products",
            "Customer Labels",
            "Employees",
            "Product Catalog",
            "Products By Category",
            "Sales by Category",
            "Data bound RenderTable with grouping and aggregates"
        };

        #endregion ** fields

        public MainForm()
        {
            InitializeComponent();

            BuildAppMenu();
        }

        private void BuildAppMenu()
        {
            _reportsCombo = new RibbonComboBox();
            _reportsCombo.GripHandleVisible = true;
            _reportsCombo.Label = "Select report: ";
            _reportsCombo.TextAreaWidth = 350;
            _reportsCombo.MaxDropDownItems = 7;
            _reportsCombo.DropDownStyle = RibbonComboBoxStyle.DropDownList;
            _reportsCombo.SelectedIndexChanged += _reportsCombo_SelectedIndexChanged;

            var ti = _ribbonPreview.Ribbon.TopToolBar.Items;
            ti.Insert(ti.Count - 2, _reportsCombo);
            _ribbonPreview.Ribbon.Qat.Visible = false;

            for (int i = 0; i < _reportsList.Length; i++)
            {
                _reportsCombo.Items.Add(new RibbonButton(_reportsList[i]));
            }

            // 
            _reportsCombo.SelectedIndex = 4;
        }

        #region ** event handlers

        private void _reportsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_reportsCombo.SelectedIndex < 0)
            {
                return;
            }

            switch (_reportsCombo.SelectedIndex)
            {
                case 0: // Alphabetical List of Products
                    AlphabeticalListOfProducts();
                    break;

                case 1: // Customer Labels
                    CustomerLabels();
                    break;

                case 2: // Employees
                    Employees();
                    break;

                case 3: // Data bound RenderTable with grouping and aggregates
                    ProductCatalog();
                    break;

                case 4: // Products By Category
                    ProductsByCategory();
                    break;

                case 5: // Sales by Category
                default:
                    SalesByCategory();
                    break;

                case 6: // Data bound RenderTable with grouping and aggregates

                    DataBoundTable();
                    break;
            }
        }

        private void _printDocument_LongOperation(object sender, C1.Win.LongOperationEventArgs e)
        {
            C1PrintDocument document = (C1PrintDocument)sender;
            ProgressWindow progressWindow = document.Body.Children[0].UserData as ProgressWindow;

            if (progressWindow != null)
            {
                if (!document.IsGenerating)
                {
                    document.Body.Children[0].UserData = null;
                    progressWindow.Close();
                }
                else
                {
                    var progress = Convert.ToInt32(e.Complete * 100);
                    progressWindow.progressBar1.Value = progress;
                    progressWindow.label1.Text = string.Format("Generating document: {0} %", progress);
                }
            }

            Application.DoEvents();
        }

        private void _printDocument_DocumentEnded(object sender, EventArgs e)
        {
            C1PrintDocument document = (C1PrintDocument)sender;
            ProgressWindow progressWindow = document.Body.Children[0].UserData as ProgressWindow;

            if (progressWindow != null)
            {
                document.Body.Children[0].UserData = null;
                progressWindow.Close();
            }
            _printDocument.LongOperation -= _printDocument_LongOperation;
            _printDocument.DocumentEnded -= _printDocument_DocumentEnded;
        }

        #endregion ** event handlers

        private void AlphabeticalListOfProducts()
        {
            this.Cursor = Cursors.WaitCursor;

            _printDocument.Clear();

            // set default style
            _printDocument.Style.FontName = "Verdana";
            _printDocument.Style.FontSize = 10;

            // set group header style
            C1.C1Preview.Style headerLetterStyle = _printDocument.Style.Children.Add();
            headerLetterStyle.FontSize = 11;
            headerLetterStyle.FontBold = true;
            headerLetterStyle.GridLines.Top = new LineDef("0.5pt", Color.Black);

            // set group subheader style
            C1.C1Preview.Style headerNameStyle = _printDocument.Style.Children.Add();
            headerNameStyle.FontSize = 9;
            headerNameStyle.FontBold = true;

            // set group subheader style (right aligned)
            C1.C1Preview.Style headerNameStyleRight = _printDocument.Style.Children.Add();
            headerNameStyleRight.FontSize = 9;
            headerNameStyleRight.FontBold = true;
            headerNameStyleRight.TextAlignHorz = AlignHorzEnum.Right;

            // set data style
            C1.C1Preview.Style dataStyle = _printDocument.Style.Children.Add();
            dataStyle.FontSize = 8;
            dataStyle.TextAlignHorz = AlignHorzEnum.Left;

            // set data style (right aligned)
            C1.C1Preview.Style dataStyleRight = _printDocument.Style.Children.Add();
            dataStyleRight.FontSize = 8;
            dataStyleRight.TextAlignHorz = AlignHorzEnum.Right;

            // set document caption
            var rtCaption = new RenderText();
            rtCaption.Text = "Alphabetical List of Products";
            rtCaption.Style.FontName = "Tahoma";
            rtCaption.Style.FontSize = 16;
            rtCaption.Style.Padding.Bottom = "2mm";

            _printDocument.Body.Children.Add(rtCaption);

            // set current date (short format)
            var rtCurrentDate = new RenderText();
            rtCurrentDate.Text = DateTime.Now.ToShortDateString();
            rtCurrentDate.Style.Padding.Bottom = "2mm";

            _printDocument.Body.Children.Add(rtCurrentDate);

            // define data schema
            DataSource ds = CreateDemoDataSource();

            DataSet dsProducts = new DataSet(ds,
                "SELECT Left(p.ProductName, 1) AS FirstLetter, p.ProductName, p.QuantityPerUnit, p.UnitsInStock, c.CategoryName " +
                "FROM Categories c, Products p " +
                "WHERE c.CategoryID = p.CategoryID " +
                "ORDER BY p.ProductName");

            // add data source and data set to the document: this will preserve the data binding if the document is saved as c1d/c1dx
            _printDocument.DataSchema.DataSources.Add(ds);
            _printDocument.DataSchema.DataSets.Add(dsProducts);

            RenderTable rt = new RenderTable();

            TableVectorGroup tvg = rt.RowGroups[0, 5];
            tvg.DataBinding.DataSource = dsProducts;

            // group by first letter of product name
            tvg.DataBinding.Grouping.Expressions.Add("Fields!FirstLetter.Value");

            // set cell padding
            rt.CellStyle.Padding.All = "1mm";

            // make table and table columns auto-sized
            rt.Width = Unit.Auto;
            rt.ColumnSizingMode = TableSizingModeEnum.Auto;

            // set header row
            rt.Cells[0, 0].Text = "[Fields!FirstLetter.Value]";
            rt.Cells[0, 0].Style.Parents = headerLetterStyle;
            rt.Cells[0, 1].SpanCols = 4;
            rt.Cells[0, 1].Style.Parents = headerLetterStyle;

            // set subheader row
            rt.Cells[1, 1].Text = "Product Name:";
            rt.Cells[1, 1].Style.Parents = headerNameStyle;

            rt.Cells[1, 2].Text = "Category Name:";
            rt.Cells[1, 2].Style.Parents = headerNameStyle;

            rt.Cells[1, 3].Text = "Quantity Per Unit:";
            rt.Cells[1, 3].Style.Parents = headerNameStyle;

            rt.Cells[1, 4].Text = "Units In Stock:";
            rt.Cells[1, 4].Style.Parents = headerNameStyleRight;

            // set data row
            rt.Cells[2, 1].Text = "[Fields!ProductName.Value]";
            rt.Cells[2, 1].Style.Parents = dataStyle;

            rt.Cells[2, 2].Text = "[Fields!CategoryName.Value]";
            rt.Cells[2, 2].Style.Parents = dataStyle;

            rt.Cells[2, 3].Text = "[Fields!QuantityPerUnit.Value]";
            rt.Cells[2, 3].Style.Parents = dataStyle;

            rt.Cells[2, 4].Text = "[Fields!UnitsInStock.Value]";
            rt.Cells[2, 4].Style.Parents = dataStyleRight;

            // create row group
            tvg = rt.RowGroups[2, 1];
            tvg.DataBinding.DataSource = dsProducts;

            // add table to the document
            _printDocument.Body.Children.Add(rt);

            // generate document
            _printDocument.Generate();

            // reset cursor
            this.Cursor = Cursors.Default;
        }

        private void CustomerLabels()
        {
            this.Cursor = Cursors.WaitCursor;

            _printDocument.Clear();

            // set landscape page orientation
            _printDocument.PageLayout.PageSettings.Landscape = true;

            // set margins
            _printDocument.PageLayout.PageSettings.LeftMargin = "12mm";
            _printDocument.PageLayout.PageSettings.RightMargin = "12mm";
            _printDocument.PageLayout.PageSettings.TopMargin = "12mm";
            _printDocument.PageLayout.PageSettings.BottomMargin = "12mm";

            // set page style
            _printDocument.Style.FontName = "Verdana";
            _printDocument.Style.FontSize = 7;

            // create render area containing areas with data
            RenderArea raContainer = new RenderArea();
            raContainer.Stacking = StackingRulesEnum.InlineLeftToRight;

            _printDocument.Body.Children.Add(raContainer);

            // define data schema
            DataSource ds = CreateDemoDataSource();

            DataSet dsCustomers = new DataSet(ds,
                "SELECT CompanyName, Address, City, PostalCode, Country " +
                "FROM Customers " +
                "ORDER BY CompanyName");

            // add data source and data set to the document: this will preserve the data binding if the document is saved as c1d/c1dx
            _printDocument.DataSchema.DataSources.Add(ds);
            _printDocument.DataSchema.DataSets.Add(dsCustomers);

            // create render area contains data
            RenderArea raItem = new RenderArea();

            // set borders
            raItem.Style.Borders.Right = new LineDef("0.1pt", Color.LightGray, System.Drawing.Drawing2D.DashStyle.Dot);
            raItem.Style.Borders.Bottom = new LineDef("0.1pt", Color.LightGray, System.Drawing.Drawing2D.DashStyle.Dot);

            // set size
            raItem.Width = "40mm";
            raItem.Height = "20mm";

            // do not split the area into different pages
            raItem.SplitVertBehavior = SplitBehaviorEnum.Never;

            // set the data source
            raItem.DataBinding.DataSource = dsCustomers;

            // group by first letter of product name
            raItem.DataBinding.Grouping.Expressions.Add("Fields!CompanyName.Value");

            raContainer.Children.Add(raItem);

            // add text
            RenderText rt = new RenderText();
            rt.Text = "[Fields!CompanyName.Value]\r\n[Fields!Address.Value]\r\n[Fields!City.Value] [Fields!PostalCode.Value]\r\n[Fields!Country.Value]";
            rt.Style.Padding.All = "1mm";

            // set the text's data source to the data source of the containing RenderArea,
            // it`s indicates that the render object is bound to the current group in the specified object
            rt.DataBinding.DataSource = raContainer.DataBinding.DataSource;

            // Add the text to the area
            raItem.Children.Add(rt);

            // generate document
            _printDocument.Generate();

            // reset cursor
            this.Cursor = Cursors.Default;
        }

        private void Employees()
        {
            this.Cursor = Cursors.WaitCursor;

            _printDocument.Clear();

            // set default style
            _printDocument.Style.FontName = "Verdana";
            _printDocument.Style.FontSize = 10;

            // set margins
            _printDocument.PageLayout.PageSettings.LeftMargin = "12mm";
            _printDocument.PageLayout.PageSettings.RightMargin = "12mm";
            _printDocument.PageLayout.PageSettings.TopMargin = "12mm";
            _printDocument.PageLayout.PageSettings.BottomMargin = "12mm";

            // set group header style
            C1.C1Preview.Style headerStyle = _printDocument.Style.Children.Add();
            headerStyle.FontSize = 9;
            headerStyle.FontBold = true;
            headerStyle.GridLines.Bottom = new LineDef("1pt", Color.Black);

            // set country header style
            C1.C1Preview.Style countryStyle = _printDocument.Style.Children.Add();
            countryStyle.FontSize = 11;
            countryStyle.FontBold = true;

            // set city header style
            C1.C1Preview.Style cityStyle = _printDocument.Style.Children.Add();
            cityStyle.FontSize = 10;
            cityStyle.FontUnderline = true;

            // set data name
            C1.C1Preview.Style dataNameStyle = _printDocument.Style.Children.Add();
            dataNameStyle.FontSize = 8;
            dataNameStyle.FontBold = true;
            dataNameStyle.TextAlignHorz = AlignHorzEnum.Center;

            // set data style
            C1.C1Preview.Style dataStyle = _printDocument.Style.Children.Add();
            dataStyle.FontSize = 8;

            // set document caption
            var rtCaption = new RenderText();
            rtCaption.Text = "Employees";
            rtCaption.Style.FontName = "Tahoma";
            rtCaption.Style.FontSize = 16;
            rtCaption.Style.Padding.All = "2mm";
            rtCaption.Style.BackColor = Color.LightGray;

            _printDocument.Body.Children.Add(rtCaption);

            // define data schema
            DataSource ds = CreateDemoDataSource();

            DataSet dsEmployers = new DataSet(ds,
                "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo, Photo " +
                "FROM Employees " +
                "ORDER BY Country, City, FirstName, LastName");

            // add data source and data set to the document: this will preserve the data binding if the document is saved as c1d/c1dx
            _printDocument.DataSchema.DataSources.Add(ds);
            _printDocument.DataSchema.DataSets.Add(dsEmployers);

            // create table
            RenderTable rt = new RenderTable();

            // set cell padding
            rt.CellStyle.Padding.All = "1mm";

            // set header row
            rt.Cells[0, 0].Text = "Country";
            rt.Cells[0, 0].Style.Spacing.Top = "2mm";
            rt.Cells[0, 0].Style.Parents = headerStyle;

            rt.Cells[0, 1].Text = "City";
            rt.Cells[0, 1].Style.Parents = headerStyle;

            rt.Cells[0, 2].Text = "Address";
            rt.Cells[0, 2].Style.Parents = headerStyle;

            rt.Cells[0, 3].Text = "Home Phone";
            rt.Cells[0, 3].Style.Parents = headerStyle;

            // set country row
            rt.Cells[1, 0].Text = "[Fields!Country.Value]";
            rt.Cells[1, 0].Style.Parents = countryStyle;

            // set city row
            rt.Cells[2, 1].Text = "[Fields!City.Value]";
            rt.Cells[2, 1].Style.Parents = cityStyle;

            // set data rows
            rt.Cells[3, 0].Text = "[Fields!FirstName.Value] [Fields!LastName.Value]";
            rt.Cells[3, 0].Style.Parents = dataNameStyle;
            rt.Cells[3, 0].SpanCols = 2;

            rt.Cells[3, 2].Text = "[Fields!Address.Value]";
            rt.Cells[3, 2].Style.Parents = dataStyle;

            rt.Cells[3, 3].Text = "[Fields!HomePhone.Value]";
            rt.Cells[3, 3].Style.Parents = dataStyle;

            RenderImage ri = new RenderImage(_printDocument);

            _printDocument.ThrowExceptionOnError = true;
            _printDocument.AddWarningsWhenErrorInScript = true;

            ri.FormatDataBindingInstanceScript = @"
                Dim ri as RenderImage = DirectCast(RenderObject, RenderImage)
                Dim picData as Byte() = DirectCast(RenderObject.Original.DataBinding.Parent.Fields!Photo.Value, Byte())
                Const bmData As Integer = 78
                Dim ms as IO.MemoryStream = New IO.MemoryStream(picData, bmData, picData.Length - bmData)
                ri.Image = Image.FromStream(ms)
                ";

            // set image parameters
            ri.Width = "30mm";
            ri.Height = "30mm";
            ri.Style.ImageAlign.AlignHorz = ImageAlignHorzEnum.Center;
            ri.Style.ImageAlign.AlignVert = ImageAlignVertEnum.Center;

            rt.Cells[4, 0].RenderObject = ri;
            rt.Cells[4, 0].SpanCols = 2;
            rt.Cells[4, 0].SpanRows = 2;

            rt.Cells[4, 2].Text = "[Fields!Title.Value]";
            rt.Cells[4, 2].Style.Parents = dataStyle;

            rt.Cells[4, 3].Text = "[FormatDateTime(Fields!BirthDate.Value, DateFormat.ShortDate)]    [FormatDateTime(Fields!HireDate.Value, DateFormat.ShortDate)]";
            rt.Cells[4, 3].Style.Parents = dataStyle;

            // add area for notes
            RenderArea raNotes = new RenderArea();
            raNotes.Style.Spacing.Right = "20mm";

            var rtNoteTitle = new RenderText();
            rtNoteTitle.Text = "[Fields!FirstName.Value]`s notes:";
            rtNoteTitle.Style.FontSize = 7;

            // add note text
            var rtNote = new RenderText();
            rtNote.Text = "[Fields!Notes.Value]";
            rtNote.Style.Borders.All = new LineDef("1pt", Color.LightGray);
            rtNote.Style.Padding.All = "2mm";
            rtNote.Style.FontSize = 6;
            rtNote.Style.FontItalic = true;

            // do not split the area into different pages
            raNotes.SplitVertBehavior = SplitBehaviorEnum.Never;

            raNotes.Children.Add(rtNoteTitle);
            raNotes.Children.Add(rtNote);

            rt.Cells[5, 2].RenderObject = raNotes;
            rt.Cells[5, 2].SpanCols = 2;

            // auto-size columns, spread the rest columns
            rt.Cols[0].SizingMode = TableSizingModeEnum.Auto;
            rt.Cols[1].SizingMode = TableSizingModeEnum.Auto;

            // create group by city
            TableVectorGroup tvg = rt.RowGroups[2, 6];
            tvg.DataBinding.DataSource = dsEmployers;
            tvg.DataBinding.Grouping.Expressions.Add("Fields!City.Value");

            // create group by country
            tvg = rt.RowGroups[0, 8];
            tvg.DataBinding.DataSource = dsEmployers;
            tvg.DataBinding.Grouping.Expressions.Add("Fields!Country.Value");

            // add data rows
            tvg = rt.RowGroups[3, 5];
            tvg.DataBinding.DataSource = dsEmployers;
            tvg.SplitBehavior = SplitBehaviorEnum.Never;

            // add table to the document
            _printDocument.Body.Children.Add(rt);

            // define a cell group style
            rt.UserCellGroups.Add(new UserCellGroup(new Rectangle(0, 3, 4, 3)));
            rt.UserCellGroups[0].Style.Borders.All = new LineDef("0.5pt", Color.Black);

            // generate document
            _printDocument.Generate();

            // reset cursor
            this.Cursor = Cursors.Default;
        }

        private void ProductCatalog()
        {
            this.Cursor = Cursors.WaitCursor;

            _printDocument.Clear();

            // set default style
            _printDocument.Style.FontName = "Tahoma";
            _printDocument.Style.FontSize = 10;

            // set margins
            _printDocument.PageLayout.PageSettings.LeftMargin = "12mm";
            _printDocument.PageLayout.PageSettings.RightMargin = "12mm";
            _printDocument.PageLayout.PageSettings.TopMargin = "12mm";
            _printDocument.PageLayout.PageSettings.BottomMargin = "12mm";

            // set category header style
            C1.C1Preview.Style categoryNameStyle = _printDocument.Style.Children.Add();
            categoryNameStyle.FontSize = 15;
            categoryNameStyle.FontBold = true;
            categoryNameStyle.TextAlignVert = AlignVertEnum.Bottom;

            // set description style
            C1.C1Preview.Style descriptionStyle = _printDocument.Style.Children.Add();
            descriptionStyle.FontSize = 7;
            descriptionStyle.FontItalic = true;

            // set header style
            C1.C1Preview.Style headerStyle = _printDocument.Style.Children.Add();
            headerStyle.FontSize = 10;
            headerStyle.FontBold = true;
            headerStyle.FontItalic = true;
            headerStyle.BackColor = Color.LightGray;

            // normal data style
            C1.C1Preview.Style normalDataStyle = _printDocument.Style.Children.Add();
            normalDataStyle.FontSize = 9;

            // center aligned data style
            C1.C1Preview.Style centerAlignedDataStyle = _printDocument.Style.Children.Add();
            centerAlignedDataStyle.FontSize = 9;
            centerAlignedDataStyle.TextAlignHorz = AlignHorzEnum.Center;

            // bold data style
            C1.C1Preview.Style boldDataStyle = _printDocument.Style.Children.Add();
            boldDataStyle.FontSize = 9;
            boldDataStyle.FontBold = true;

            // right aligned data style
            C1.C1Preview.Style rightAlignedDataStyle = _printDocument.Style.Children.Add();
            rightAlignedDataStyle.FontSize = 9;
            rightAlignedDataStyle.TextAlignHorz = AlignHorzEnum.Right;

            // add document caption
            var rtCaption = new RenderText();
            rtCaption.Style.FontSize = 16;
            rtCaption.Style.TextAlignHorz = AlignHorzEnum.Center;
            rtCaption.Text = "Northwind Traders";

            _printDocument.Body.Children.Add(rtCaption);

            // add second document caption
            var rtCaption2 = new RenderText();
            rtCaption2.Style.FontSize = 10;
            rtCaption2.Style.TextColor = Color.DarkRed;
            rtCaption2.Style.TextAlignHorz = AlignHorzEnum.Center;
            rtCaption2.Text = "Fall Catalog";

            _printDocument.Body.Children.Add(rtCaption2);

            // add empty space
            _printDocument.Body.Children.Add(new RenderEmpty("38mm"));

            // add text block
            var raBlock = new RenderArea();
            raBlock.Style.Borders.All = new LineDef("0.5pt", Color.Black);
            raBlock.Style.Padding.All = "3mm";
            raBlock.Style.TextColor = Color.DarkRed;
            raBlock.Style.TextAlignHorz = AlignHorzEnum.Center;
            raBlock.SplitVertBehavior = SplitBehaviorEnum.Never;
            raBlock.Width = "60%";

            // block is horizontally centered
            raBlock.X = "parent.x + (parent.width - width)/2";

            // add caption to block
            var rtBlockCaption = new RenderText();
            rtBlockCaption.Style.FontSize = 11;
            rtBlockCaption.Style.Padding.Bottom = "1mm";
            rtBlockCaption.Text = "Commitment to Quality";

            // add text to block
            var rtBlocktext = new RenderText();
            rtBlocktext.Style.FontSize = 8;
            rtBlocktext.Text = "Northwind Traders is committed to bringing you products of the highest quality from all over the world. " +
                "If at any time you are not completely satisfied with any of our products, " +
                "you may return them to us for a full refund.";

            raBlock.Children.Add(rtBlockCaption);
            raBlock.Children.Add(rtBlocktext);

            _printDocument.Body.Children.Add(raBlock);

            // add empty space
            _printDocument.Body.Children.Add(new RenderEmpty("70mm"));

            // add text
            var raText = new RenderArea();
            raText.Style.FontItalic = true;
            raText.Style.TextColor = Color.DarkBlue;
            raText.Style.TextAlignHorz = AlignHorzEnum.Center;
            raText.SplitVertBehavior = SplitBehaviorEnum.Never;
            raText.Width = "80%";

            // text is horizontally centered
            raText.X = "parent.x + (parent.width - width)/2";

            AddTextBlocks(raText, "Tour the Gastronomic World with Northwind Traders!");
            
            AddTextBlocks(raText, "When Northwind Traders buyers set out to search for the Wonders of the Gastronomic World they found a lot more than seven of them. " +
                "And here they are--tastefully presented in our Fall Catalog.");
            
            AddTextBlocks(raText, "The beverages and confections we're featuring this fall are sure to please even the most discerning palates. For thirst quenchers, " +
                "try exotic Chang, hearty Laughing Lumberjack Lager, robust Rhonbrau Klosterbier, and refreshing Lakkalikoori.");
            
            AddTextBlocks(raText, "And for a taste of something sweet, try Pavlova, the intriguing meringue dessert from Australia; " +
                "Teatime Chocolate Biscuits from England, tasty Maxilaku from Finland; and the Berlin specialty, NuNuCa Nus-Nougat-Creme.");
            
            AddTextBlocks(raText, "Our sales representatives are ready to take your orders now. " +
                "For your convenience, we've included details on ordering on the last page of this catalog.");

            _printDocument.Body.Children.Add(raText);

            // add empty space
            _printDocument.Body.Children.Add(new RenderEmpty("60mm"));

            // define data schema
            var dataSource = CreateDemoDataSource();

            var dsProducts = new DataSet(dataSource,
                "SELECT c.CategoryName, c.Description, p.ProductID, p.ProductName, p.QuantityPerUnit, p.UnitPrice " +
                "FROM Products p, Categories c " +
                "WHERE p.CategoryID = c.CategoryID " +
                "ORDER BY c.CategoryName, p.ProductName");

            // add data source and data set to the document: this will preserve the data binding if the document is saved as c1d/c1dx
            _printDocument.DataSchema.DataSources.Add(dataSource);
            _printDocument.DataSchema.DataSets.Add(dsProducts);

            // create table
            var rt = new RenderTable();

            // set cell padding
            rt.CellStyle.Padding.All = "1mm";

            // category name
            rt.Cells[0, 0].Text = "[Fields!CategoryName.Value]";
            rt.Cells[0, 0].SpanCols = 4;
            rt.Cells[0, 0].Style.Parents = categoryNameStyle;
            rt.Rows[0].Height = "15mm";

            rt.Cells[1, 0].Text = "[Fields!Description.Value]";
            rt.Cells[1, 0].SpanCols = 4;
            rt.Cells[1, 0].Style.Parents = descriptionStyle;

            // header
            rt.Cells[2, 0].Text = "Product Name:";
            rt.Cells[2, 0].Style.Parents = headerStyle;

            rt.Cells[2, 1].Text = "Product ID:";
            rt.Cells[2, 1].Style.Parents = headerStyle;

            rt.Cells[2, 2].Text = "Quantity Per Unit:";
            rt.Cells[2, 2].Style.Parents = headerStyle;

            rt.Cells[2, 3].Text = "Unit Price:";
            rt.Cells[2, 3].Style.Parents = headerStyle;

            // data row
            rt.Cells[3, 0].Text = "[Fields!ProductName.Value]";
            rt.Cells[3, 0].Style.Parents = boldDataStyle;

            rt.Cells[3, 1].Text = "[Fields!ProductID.Value]";
            rt.Cells[3, 1].Style.Parents = normalDataStyle;
            rt.Cells[3, 1].CellStyle.Spacing.Right = "30mm";

            rt.Cells[3, 2].Text = "[Fields!QuantityPerUnit.Value]";
            rt.Cells[3, 2].Style.Parents = normalDataStyle;
            rt.Cells[3, 2].CellStyle.Spacing.Right = "20mm";

            rt.Cells[3, 3].Text = "$[Fields!UnitPrice.Value]";
            rt.Cells[3, 3].Style.Parents = rightAlignedDataStyle;

            // auto-size columns
            rt.Cols[1].SizingMode = TableSizingModeEnum.Auto;
            rt.Cols[2].SizingMode = TableSizingModeEnum.Auto;
            rt.Cols[3].SizingMode = TableSizingModeEnum.Auto;

            // create group by category name
            TableVectorGroup tvg = rt.RowGroups[0, 4];
            tvg.DataBinding.DataSource = dsProducts;
            tvg.DataBinding.Grouping.Expressions.Add("Fields!CategoryName.Value");

            // create group by description
            tvg = rt.RowGroups[0, 4];
            tvg.DataBinding.DataSource = dsProducts;
            tvg.DataBinding.Grouping.Expressions.Add("Fields!Description.Value");

            // add data rows
            tvg = rt.RowGroups[3, 1];
            tvg.DataBinding.DataSource = dsProducts;
            tvg.SplitBehavior = SplitBehaviorEnum.Never;

            // add table to the document
            _printDocument.Body.Children.Add(rt);

            // generate document
            _printDocument.Generate();

            // reset cursor
            this.Cursor = Cursors.Default;
        }

        private void ProductsByCategory()
        {
            this.Cursor = Cursors.WaitCursor;

            _printDocument.Clear();

            // add tag for products count
            var tag = new Tag("ProductCounter", 0, typeof(int));
            _printDocument.Tags.Add(tag);

            // set default style
            _printDocument.Style.FontName = "Tahoma";
            _printDocument.Style.FontSize = 8;

            // set margins
            _printDocument.PageLayout.PageSettings.LeftMargin = "12mm";
            _printDocument.PageLayout.PageSettings.RightMargin = "12mm";
            _printDocument.PageLayout.PageSettings.TopMargin = "12mm";
            _printDocument.PageLayout.PageSettings.BottomMargin = "12mm";

            // set category header style
            C1.C1Preview.Style categoryStyle = _printDocument.Style.Children.Add();
            categoryStyle.FontSize = 12;
            categoryStyle.TextAlignVert = AlignVertEnum.Bottom;

            // define data schema
            var dataSource = CreateDemoDataSource();

            var dsCategories = new DataSet(dataSource,
                "SELECT c.CategoryName, c.Description, p.ProductID, p.ProductName, p.QuantityPerUnit, p.UnitPrice " +
                "FROM Products p, Categories c " +
                "WHERE p.CategoryID = c.CategoryID " +
                "ORDER BY c.CategoryName, p.ProductName");

            // add data source and data set to the document: this will preserve the data binding if the document is saved as c1d/c1dx
            _printDocument.DataSchema.DataSources.Add(dataSource);
            _printDocument.DataSchema.DataSets.Add(dsCategories);

            // add caption
            var raCaption = new RenderArea();
            raCaption.Style.BackColor = Color.LightGray;
            raCaption.Style.Padding.All = "2mm";
            raCaption.Style.FontSize = 14;

            var header1 = new RenderText();
            header1.Text = "Products By Category";
            header1.Style.Spacing.Bottom = "2mm";

            var header2 = new RenderText();
            header2.Text = DateTime.Now.ToShortDateString();
            header2.Style.FontSize = 6;
            header2.Style.FontItalic = true;

            raCaption.Children.Add(header1);
            raCaption.Children.Add(header2);

            _printDocument.Body.Children.Add(raCaption);

            // create table
            var rt = new RenderTable();

            // set cell padding
            rt.CellStyle.Padding.All = "1mm";

            // set header
            rt.Cells[0, 0].Text = "[Fields!CategoryName.Value]";
            rt.Cells[0, 0].Style.Parents = categoryStyle;
            
            rt.Rows[0].Height = "15mm";

             // show all exceptions and warnings for script debug
            _printDocument.ThrowExceptionOnError = true;
            _printDocument.AddWarningsWhenErrorInScript = true;

            var raProducts = new RenderArea();
            raProducts.Stacking = StackingRulesEnum.InlineLeftToRight;

            _printDocument.ThrowExceptionOnError = true;
            _printDocument.AddWarningsWhenErrorInScript = true;

            var rtt = new RenderText("[RenderObject.DataBinding.RowNumber]) [Fields!ProductName.Value]");
            rtt.DataBinding.DataSource = dsCategories;
            rtt.Width = "30%";
            raProducts.Children.Add(rtt);

            rt.Cells[1, 0].RenderObject = raProducts;

            // create group by category
            TableVectorGroup tvg = rt.RowGroups[0, 2];
            tvg.DataBinding.DataSource = dsCategories;
            tvg.DataBinding.Grouping.Expressions.Add("Fields!CategoryName.Value");
            // add aggregate for products
            _printDocument.DataSchema.Aggregates.Add(new Aggregate("ProductCount", "Fields!ProductID.Value", tvg.DataBinding, RunningEnum.Group, AggregateFuncEnum.Count));


            // add table to the document
            _printDocument.Body.Children.Add(rt);

             // generate document
            _printDocument.Generate();

            // reset cursor
            this.Cursor = Cursors.Default;
        }

        private void SalesByCategory()
        {
            this.Cursor = Cursors.WaitCursor;

            _printDocument.Clear();

            // set default style
            _printDocument.Style.FontName = "Tahoma";
            _printDocument.Style.FontSize = 8;

            // set margins
            _printDocument.PageLayout.PageSettings.LeftMargin = "12mm";
            _printDocument.PageLayout.PageSettings.RightMargin = "12mm";
            _printDocument.PageLayout.PageSettings.TopMargin = "12mm";
            _printDocument.PageLayout.PageSettings.BottomMargin = "12mm";

            // set category header style
            C1.C1Preview.Style categoryStyle = _printDocument.Style.Children.Add();
            categoryStyle.FontSize = 10;
            categoryStyle.TextAlignVert = AlignVertEnum.Bottom;
            categoryStyle.Borders.Bottom = new LineDef("0.5pt", Color.Black);

            // define data schema
            var dataSource = CreateDemoDataSource();

            var dsCategories = new DataSet(dataSource,
                "SELECT c.CategoryName, p.ProductName, p.UnitPrice, p.UnitsInStock " +
                "FROM Products p, Categories c " +
                "WHERE p.CategoryID = c.CategoryID " +
                "ORDER BY c.CategoryName, p.ProductName");

            // add data source and data set to the document: this will preserve the data binding if the document is saved as c1d/c1dx
            _printDocument.DataSchema.DataSources.Add(dataSource);
            _printDocument.DataSchema.DataSets.Add(dsCategories);

            // add caption
            var raContainer = new RenderArea();
            raContainer.Width = "50%";

            var rtHeader = new RenderText();
            rtHeader.Text = "Sales by Category";
            rtHeader.Style.FontSize = 14;
            rtHeader.Style.TextAlignHorz = AlignHorzEnum.Center;

            raContainer.Children.Add(rtHeader);

            // create table
            var rt = new RenderTable();

            // set cell padding
            rt.CellStyle.Padding.All = "1mm";

            // set header
            rt.Cells[0, 0].Text = "Product:";
            rt.Cells[0, 0].Style.Parents = categoryStyle;

            rt.Cells[0, 1].Text = "Sales:";
            rt.Cells[0, 1].Style.TextAlignHorz = AlignHorzEnum.Right;
            rt.Cells[0, 1].Style.Parents = categoryStyle;

            rt.Rows[0].Height = "11mm";

            rt.Cells[1, 0].Text = "[Fields!ProductName.Value]";
            //rt.Cells[1, 0].Style.Parents = categoryStyle;

            rt.Cells[1, 1].Text = "[string.Format(\"{0:C}\",Fields!UnitPrice.Value * Fields!UnitsInStock.Value)]";
            rt.Cells[1, 1].Style.TextAlignHorz = AlignHorzEnum.Right;
            //rt.Cells[1, 1].Style.Parents = categoryStyle;

            raContainer.Children.Add(rt);

            // create group by category name
            TableVectorGroup tvg = rt.RowGroups[0, 2];
            tvg.DataBinding.DataSource = dsCategories;
            tvg.DataBinding.Grouping.Expressions.Add("Fields!CategoryName.Value");

            // add data rows
            tvg = rt.RowGroups[1, 1];
            tvg.DataBinding.DataSource = dsCategories;
            //tvg.SplitBehavior = SplitBehaviorEnum.Never;

            // add table to the document
            _printDocument.Body.Children.Add(raContainer);

            // generate document
            _printDocument.Generate();

            // reset cursor
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Builds a document with a data bound table, with two levels of master-detail relations.
        /// </summary>
        private void DataBoundTable()
        {
            this.Cursor = Cursors.WaitCursor;

            _printDocument.Clear();

            // Set styles
            _printDocument.Style.FontName = "Verdana";
            _printDocument.Style.FontSize = 10;

            C1.C1Preview.Style boldFontStyle = _printDocument.Style.Children.Add();
            boldFontStyle.FontName = "Verdana";
            boldFontStyle.FontSize = 10;
            boldFontStyle.FontBold = true;

            C1.C1Preview.Style smallFontStyle = _printDocument.Style.Children.Add();
            smallFontStyle.FontName = "Verdana";
            smallFontStyle.FontSize = 7;

            C1.C1Preview.Style detailCaptionStyle = _printDocument.Style.Children.Add();
            detailCaptionStyle.TextAlignHorz = AlignHorzEnum.Center;
            detailCaptionStyle.TextAlignVert = AlignVertEnum.Center;
            detailCaptionStyle.FontName = "Verdana";
            detailCaptionStyle.FontSize = 8;
            detailCaptionStyle.FontUnderline = true;

            C1.C1Preview.Style detailStyle = _printDocument.Style.Children.Add();
            detailStyle.FontName = "Verdana";
            detailStyle.FontSize = 11;

            C1.C1Preview.Style dateStyle = detailStyle.Children.Add();
            dateStyle.TextAlignHorz = AlignHorzEnum.Center;

            C1.C1Preview.Style descriptionStyle = detailStyle.Children.Add();
            descriptionStyle.TextAlignHorz = AlignHorzEnum.Left;

            C1.C1Preview.Style currencyStyle = detailStyle.Children.Add();
            currencyStyle.TextAlignHorz = AlignHorzEnum.Right;

            C1.C1Preview.Style quantityStyle = detailStyle.Children.Add();
            quantityStyle.TextAlignHorz = AlignHorzEnum.Right;

            // define data schema: orders sorted by customer sorted by customer country
            DataSource ds = CreateDemoDataSource();

            DataSet dsCities = new DataSet(ds,
                "select o.*, c.Country, c.CompanyName, p.ProductName, od.* from orders o, customers c, products p, `order details` od " +
                "where o.CustomerID = c.CustomerID and o.OrderID = od.OrderID and od.ProductID = p.ProductID " +
                "order by c.Country, c.CompanyName, o.OrderDate");

            // add data source and data set to the document - this will preserve the data binding
            // if the document is saved as c1d/c1dx
            _printDocument.DataSchema.DataSources.Add(ds);
            _printDocument.DataSchema.DataSets.Add(dsCities);

            // set document caption
            RenderText txt = new RenderText();
            txt.Text = "List of orders grouped by country and customer";
            txt.Style.FontName = "Tahoma";
            txt.Style.FontSize = 16;
            txt.Style.FontBold = true;
            _printDocument.Body.Children.Add(txt);

            // main body of the document is a data bound table, with 3 nested data bound row groups
            RenderTable rt = new RenderTable();

            // the following two lines make table and table columns auto-sized
            rt.Width = Unit.Auto;
            rt.ColumnSizingMode = TableSizingModeEnum.Auto;

            // spread out data a bit
            rt.CellStyle.Padding.All = "0.5mm";

            // turn lines on for structure clarity
            rt.Style.GridLines.All = new LineDef("0.5pt", Color.Silver);

            // top level master: country
            rt.Cells[0, 0].Text = "Country:";
            rt.Cells[0, 1].SpanCols = 2;
            rt.Cells[0, 1].Text = "[Fields!Country.Value]";
            rt.Cells[0, 1].Style.Parents = boldFontStyle;

            // top level master: orders count for country
            rt.Cells[0, 3].RenderObject = CreateAggregate("Total orders:", "CountryOrderCount", smallFontStyle, boldFontStyle, false);

            // top level master: orders total for country
            rt.Cells[0, 4].RenderObject = CreateAggregate("Country total:", "CountryTotal", smallFontStyle, boldFontStyle, true);

            // country header back color
            rt.Rows[0].Style.BackColor = Color.LightGoldenrodYellow;

            // second level master: company
            rt.Cells[1, 0].Text = "Company:";
            rt.Cells[1, 1].Text = "[Fields!CompanyName.Value]";
            rt.Cells[1, 1].Style.Parents = boldFontStyle;
            rt.Cells[1, 1].SpanCols = 2;

            // second level master: orders count for company
            rt.Cells[1, 3].RenderObject = CreateAggregate("Total orders:", "CompanyOrderCount", smallFontStyle, boldFontStyle, false);

            // second level master: orders total for company
            rt.Cells[1, 4].RenderObject = CreateAggregate("Company total:", "CompanyTotal", smallFontStyle, boldFontStyle, true);

            // company header back color
            rt.Rows[1].Style.BackColor = Color.Lavender;

            // detail: column captions
            rt.Cells[2, 0].Text = "Date";
            rt.Cells[2, 0].Style.Parents = detailCaptionStyle;
            rt.Cells[2, 1].Text = "Product";
            rt.Cells[2, 1].Style.Parents = detailCaptionStyle;
            rt.Cells[2, 2].Text = "Unit Price";
            rt.Cells[2, 2].Style.Parents = detailCaptionStyle;
            rt.Cells[2, 3].Text = "Quantity";
            rt.Cells[2, 3].Style.Parents = detailCaptionStyle;
            rt.Cells[2, 4].Text = "Total";
            rt.Cells[2, 4].Style.Parents = detailCaptionStyle;

            // 1) detail: order date
            rt.Cells[3, 0].Text = "[FormatDateTime(Fields!OrderDate.Value, DateFormat.ShortDate)]";
            rt.Cells[3, 0].Style.Parents = dateStyle;

            // 2) detail: product name
            rt.Cells[3, 1].Text = "[Fields!ProductName.Value]";
            rt.Cells[3, 1].Style.Parents = descriptionStyle;

            // 3) detail: unit price
            rt.Cells[3, 2].Text = "[string.Format(\"{0:C}\",Fields!UnitPrice.Value)]";
            rt.Cells[3, 2].Style.Parents = currencyStyle;

            // 4) detail: quantity
            rt.Cells[3, 3].Text = "[Fields!Quantity.Value]";
            rt.Cells[3, 3].Style.Parents = quantityStyle;

            // 5) detail: order total
            rt.Cells[3, 4].Text = "[string.Format(\"{0:C}\",Fields!UnitPrice.Value * Fields!Quantity.Value)]";
            rt.Cells[3, 4].Style.Parents = currencyStyle;

            // New in 2009 v3 release of C1Report - style expressions
            // Use it to highlight orders worth $1000 or more
            rt.Cells[3, 4].Style.TextColorExpr = "iif(Fields!UnitPrice.Value * Fields!Quantity.Value >= 1000, Colors.Blue, Colors.Black)";

            // top-level master footer: country total (duplicated in cell (0,4))
            rt.Cells[5, 0].SpanCols = 3;
            rt.Cells[5, 0].Text = "Total of all orders for [Fields!Country.Value]:";
            rt.Cells[5, 0].Style.TextAlignHorz = AlignHorzEnum.Right;
            rt.Cells[5, 3].SpanCols = 2;
            rt.Cells[5, 3].Style.Parents = currencyStyle;
            rt.Cells[5, 3].Text = "[string.Format(\"{0:C}\", Aggregates!CountryTotal.Value)]";

            // Rows 6-8 create a visual break in the table after each country.
            // The 2 extra rows (6 & 8) are needed to make sure no extra grid lines
            // appear if this break is immediately followed by a page break.
            rt.Cells[6, 0].SpanCols = 5;
            rt.Cells[6, 0].RenderObject = new RenderEmpty("1pt");
            rt.Cells[6, 0].Style.Borders.Left = rt.Cells[6, 0].Style.Borders.Right = LineDef.Empty;
            rt.Cells[6, 0].Style.Borders.Bottom = LineDef.Empty;
            rt.RowGroups[6, 1].MinVectorsBefore = 1;
            //
            rt.Cells[7, 0].SpanCols = 5;
            rt.Cells[7, 0].RenderObject = new RenderEmpty("3mm");
            rt.Cells[7, 0].Style.Borders.All = LineDef.Empty;
            //
            rt.Cells[8, 0].SpanCols = 5;
            rt.Cells[8, 0].RenderObject = new RenderEmpty("1pt");
            rt.Cells[8, 0].Style.Borders.Left = rt.Cells[8, 0].Style.Borders.Right = LineDef.Empty;
            rt.Cells[8, 0].Style.Borders.Top = LineDef.Empty;
            rt.RowGroups[8, 1].MinVectorsAfter = 1;

            // grand total for all countries
            rt.Cells[9, 0].SpanCols = 2;
            rt.Cells[9, 0].Text = "Grand Total:";
            rt.Cells[9, 0].Style.TextAlignHorz = AlignHorzEnum.Right;
            rt.Cells[9, 2].SpanCols = 3;
            rt.Cells[9, 2].Text = "[string.Format(\"{0:C}\", Aggregates!GrandTotal.Value)]";
            rt.Cells[9, 2].Style.Parents = currencyStyle;

            // define databinding within table: top level master row group - country - includes all defined rows (0-9)
            TableVectorGroup g = rt.RowGroups[0, 9];
            g.DataBinding.DataSource = dsCities;

            // group by country
            g.DataBinding.Grouping.Expressions.Add("Fields!Country.Value");

            // add outline group header for each contry
            g.DataBinding.OutlineText = "[Fields!Country.Value]";
            g.SplitBehavior = SplitBehaviorEnum.SplitIfNeeded;

            // make sure country header is followed by company and at least one detail row
            rt.RowGroups[0, 1].MinVectorsAfter = 3;

            // add country level aggregates (attached to top level master DataBinding)
            // (because there are several OrderID fields in the 'select' we must qualify it)
            _printDocument.DataSchema.Aggregates.Add(new Aggregate("CountryOrderCount", "Fields(\"o.OrderID\").Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Count));
            _printDocument.DataSchema.Aggregates.Add(new Aggregate("CountryTotal", "Fields!UnitPrice.Value * Fields!Quantity.Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Sum));

            // document level aggregate for the grand total
            _printDocument.DataSchema.Aggregates.Add(new Aggregate("GrandTotal", "Fields!UnitPrice.Value * Fields!Quantity.Value", g.DataBinding, RunningEnum.Document, AggregateFuncEnum.Sum));

            // second level master row group - company - includes rows 1-4
            g = rt.RowGroups[1, 4];
            g.DataBinding.DataSource = dsCities;

            // group by company
            g.DataBinding.Grouping.Expressions.Add("Fields!CompanyName.Value");

            // add outline group header for each company
            g.DataBinding.OutlineText = "[Fields!CompanyName.Value]";
            g.SplitBehavior = SplitBehaviorEnum.SplitIfNeeded;

            // ensure company header is followed by at least one detail row
            rt.RowGroups[1, 2].MinVectorsAfter = 1;
            rt.RowGroups[1, 2].SplitBehavior = SplitBehaviorEnum.SplitIfLarge;

            // add company level aggregates (attached to second level master DataBinding)
            _printDocument.DataSchema.Aggregates.Add(new Aggregate("CompanyTotal", "Fields!UnitPrice.Value * Fields!Quantity.Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Sum));

            // see note about OrderID above; but really, because we are just counting, any field would do here - e.g. CustomerID
            _printDocument.DataSchema.Aggregates.Add(new Aggregate("CompanyOrderCount", "Fields(\"o.OrderID\").Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Count));

            // finally, detail level data binding (just one row)
            g = rt.RowGroups[3, 1];
            g.DataBinding.DataSource = dsCities;

            // add outline entry for each product name
            g.DataBinding.OutlineText = "[Fields!ProductName.Value]";

            // add table to the document
            _printDocument.Body.Children.Add(rt);

            // set up a progress window
            ProgressWindow progressWindow = new ProgressWindow();
            progressWindow.Owner = this;
            _printDocument.Body.Children[0].UserData = progressWindow;
            progressWindow.Show();

            _printDocument.LongOperation += _printDocument_LongOperation;
            _printDocument.DocumentEnded += _printDocument_DocumentEnded;

            // generate document
            _printDocument.Generate();

            // we're done; reset cursor
            this.Cursor = Cursors.Default;
        }

        #region ** helper methods

        /// <summary>
        /// Creates the demo data source using "c1nwind.mdb" database located in user's home dir, such as:
        /// C:\Users\dima\Documents\ComponentOne Samples\Common\c1nwind.mdb 
        /// </summary>
        private DataSource CreateDemoDataSource()
        {
            DataSource result = new DataSource();
            result.ConnectionProperties.DataProvider = DataProviderEnum.OLEDB;
            result.ConnectionProperties.ConnectString = GetConnectionString();
            return result;
        }

        /// <summary>
        /// Get connection string for c1nwind.mdb.
        /// </summary>
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        /// <summary>
        /// Creates a RenderParagraph containing a caption (label) and an expression
        /// referencing an aggregate with the specified name, delimited by a newline.
        /// The aggregate must be added to the document's DataSchema.Aggregates separately.
        /// </summary>
        /// <param name="caption">The caption text</param>
        /// <param name="aggregateName">The aggregate name.</param>
        /// <param name="captionStyle">Style for the caption text.</param>
        /// <param name="aggregateStyle">Style for the aggregate value.</param>
        /// <param name="currency">If true, value is formatted as currency.</param>
        /// <returns>The created RenderParagraph object.</returns>
        private RenderObject CreateAggregate(string caption, string aggregateName, C1.C1Preview.Style captionStyle, C1.C1Preview.Style aggregateStyle, bool currency)
        {
            RenderParagraph result = new RenderParagraph();
            ParagraphText pt = new ParagraphText(caption + "\r");
            pt.Style.Parents = captionStyle;
            result.Content.Add(pt);

            if (currency)
            {
                pt = new ParagraphText("[string.Format(\"{0:C}\",Aggregates!" + aggregateName + ".Value)]");
            }
            else
            {
                pt = new ParagraphText("[Aggregates!" + aggregateName + ".Value]");
            }

            pt.Style.Parents = aggregateStyle;
            result.Content.Add(pt);
            return result;
        }

        /// <summary>
        /// Add RenderText to RenderArea
        /// </summary>
        /// <param name="renderArea">The RenderArea container.</param>
        /// <param name="text">The text for added RenderText.</param>
        /// <returns></returns>
        private RenderArea AddTextBlocks(RenderArea renderArea, string text)
        {
            var renderText = new RenderText();
            renderText.Text = text;

            renderArea.Children.Add(renderText);

            // add empty space
            renderArea.Children.Add(new RenderEmpty("1mm"));
            
            return renderArea;
        }

        #endregion ** helper methods

        #region ** data element

        public class Customer
        {
            private int _id;
            private string _name;
            private int _orderId = -1;

            public Customer(int id, string name)
            {
                _id = id;
                _name = name;
            }

            public Customer(int id, string name, int orderId)
            {
                _id = id;
                _name = name;
                _orderId = orderId;
            }

            public int Id { get { return _id; } }

            public string Name { get { return _name; } }

            public int OrderId { get { return _orderId; } }
        }

        #endregion ** data element
    }
}
