using C1.Win.FlexGrid;
using C1.Win.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class ColumnEditor : UserControl
    {
        public ColumnEditor()
        {
            InitializeComponent();
            PopulateToolStripCombosWithEnums();
        }

        //Store column indexes for easy rearrangement
        private int _imageCol = 1;
        private int _textCol = 2;
        private int _checkboxCol = 3;
        private int _numericCol = 4;
        private int _comboCol = 5;
        private int _checkListCol = 6;
        private int _multiComboCol = 7;
        private int _dateCol = 8;
        private int _editMaskCol = 9;
        private int _largeTextCol = 10;
        private int _progressBarCol = 11;
        private int _hyperlinkCol = 12;
        private int _CountryIDCol = 13;

        //Total column count
        private int _colCount = 14;

        private void PopulateToolStripCombosWithEnums()
        {
            // Clear previous items
            showBtnsCb.Items.Clear();
            keyActionCb.Items.Clear();

            // Populate showBtnsCb with ShowButtonsEnum values
            foreach (ShowButtonsEnum value in Enum.GetValues(typeof(ShowButtonsEnum)))
            {
                showBtnsCb.Items.Add(value.ToString());
            }
            showBtnsCb.SelectedIndex = 0;

            foreach (KeyActionEnum action in Enum.GetValues(typeof(KeyActionEnum)))
            {
                keyActionCb.Items.Add(action.ToString());
            }
            keyActionCb.SelectedIndex = 0;
        }

        //The FlexGrid in this demo is completely unbound. All of the column properties and data are added manually below
        private void ColumnEditor_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.Cols.Count = _colCount;

            //Image column
            Column imageCol = c1FlexGrid1.Cols[_imageCol];
            imageCol.Caption = "Images";
            imageCol.DataType = typeof(Image);
            imageCol.ImageAlign = ImageAlignEnum.CenterCenter;
            imageCol.Width = 75;

            //Text column
            Column textCol = c1FlexGrid1.Cols[_textCol];
            textCol.Caption = "Text";
            textCol.Width = 100;

            //Checkbox column
            Column checkboxCol = c1FlexGrid1.Cols[_checkboxCol];
            checkboxCol.DataType = typeof(Boolean);
            checkboxCol.Caption = "Checkbox";
            checkboxCol.Width = 75;

            //Numeric column
            Column numericCol = c1FlexGrid1.Cols[_numericCol];
            numericCol.Caption = "Numeric";
            numericCol.DataType = typeof(double);
            numericCol.Editor = c1NumericEdit1;
            numericCol.Format = "c";
            numericCol.Width = 100;

            //Combo column
            Column comboCol = c1FlexGrid1.Cols[_comboCol];
            comboCol.ComboList = "|Republic|Federal Republic|Constitutional Monarchy|Parliamentary Monarchy";
            comboCol.Caption = "Editable Combobox";
            comboCol.Width = 150;

            //Date column
            Column dateCol = c1FlexGrid1.Cols[_dateCol];
            dateCol.DataType = typeof(DateTime);
            dateCol.Caption = "Date";
            dateCol.Width = 100;

            //Input mask column
            Column editMaskCol = c1FlexGrid1.Cols[_editMaskCol];
            editMaskCol.EditMask = "GMT#0:00";
            editMaskCol.Caption = "Input Mask";
            editMaskCol.Width = 100;

            //Checkbox List column
            Column checkListCol = c1FlexGrid1.Cols[_checkListCol];
            checkListCol.Editor = new CheckListComboBox(new string[] { "Danish", "Dutch", "English", "Finnish", "French", "German", "Italian", "Norwegian", "Polish", "Portuguese", "Spanish", "Swedish" });
            checkListCol.Caption = "Checkbox List";
            checkListCol.Width = 150;
            checkListCol.ShowButtons = ShowButtonsEnum.WithFocus;

            //Multi-column combo
            c1Combo1.AddItemTitles("Symbol;Code;Description");
            c1Combo1.AddItem("$;ARS;Argentinean Peso");
            c1Combo1.AddItem("R$;BRL;Brazilian Reais");
            c1Combo1.AddItem("$;CAD;Canadian Dollar");
            c1Combo1.AddItem("kr;DKK;Danish Krone");
            c1Combo1.AddItem((char)8364 + ";EUR;Euro");
            c1Combo1.AddItem((char)163 + ";GBP;Great Britain Pound");
            c1Combo1.AddItem("$;MXN;Mexican Peso");
            c1Combo1.AddItem("kr;NOK;Norwegian Krone");
            c1Combo1.AddItem("z" + (char)322 + ";PLK;Poland Zlotych");
            c1Combo1.AddItem("kr;SEK;Swedish Krone");
            c1Combo1.AddItem("CHF;CHF;Swiss Franc");
            c1Combo1.AddItem("$;USD;US Dollar");
            c1Combo1.DisplayMember = "Code";
            c1Combo1.ValueMember = "Code";
            c1Combo1.DropDownWidth = 230;
            c1Combo1.Splits[0].DisplayColumns[0].Width = 50;
            c1Combo1.Splits[0].DisplayColumns[1].Width = 50;
            c1Combo1.Height = 100;
            Column multiComboCol = c1FlexGrid1.Cols[_multiComboCol];
            multiComboCol.Caption = "Multi-Column Combo";
            multiComboCol.Editor = c1Combo1;
            multiComboCol.Width = 100;

            //Hyperlink column
            Column hyperlinkCol = c1FlexGrid1.Cols[_hyperlinkCol];
            hyperlinkCol.Caption = "Hyperlink";
            hyperlinkCol.AllowEditing = true;
            hyperlinkCol.Width = 250;
            hyperlinkCol.ComboList = "...";
            CellStyle cs = c1FlexGrid1.Styles.Add("NewLink");
            cs.Font = new Font(c1FlexGrid1.Font, FontStyle.Underline);
            cs.ForeColor = Color.Blue;
            cs = c1FlexGrid1.Styles.Add("OldLink");
            cs.Font = new Font(c1FlexGrid1.Font, FontStyle.Underline);
            cs.ForeColor = Color.Purple;

            //Large text column
            Column largeTextCol = c1FlexGrid1.Cols[_largeTextCol];
            largeTextCol.Caption = "Large Text";
            cs = c1FlexGrid1.Styles.Add("LargeText");
            cs.Trimming = StringTrimming.EllipsisWord;
            largeTextCol.Style = cs;
            largeTextCol.Width = 120;
            largeTextCol.Editor = flexTextBox1;

            //Progress bar column
            Column progressBarCol = c1FlexGrid1.Cols[_progressBarCol];
            progressBarCol.Caption = "ProgressBar";
            progressBarCol.DataType = typeof(int);
            pb = new ProgressBar();
            progressBarCol.Width = 110;

            //CountryID Column
            Column countryIDCol = c1FlexGrid1.Cols[_CountryIDCol];
            countryIDCol.Caption = "CountryID";
            countryIDCol.Width = 150;

            //Load data
            LoadData();

            //Display Add new Row
            c1FlexGrid1.AllowAddNew = true;

        }

        private void LoadData()
        {
            c1FlexGrid1.Rows.Count = 21;
            Random rnd = new Random();

            string countries = "Argentina|Austria|Belgium|Brazil|Canada|Denmark|Finland|France|Germany|Ireland|Italy|Mexico|Norway|Poland|Portugal|Spain|Sweden|Switzerland|UK|USA";
            string currencies = "ARS|EUR|EUR|BRL|CAD|DKK|EUR|EUR|EUR|EUR|EUR|MXN|NOK|PLK|EUR|EUR|SEK|CHF|EUR|USD";
            string govs = "Republic|Federal Republic|Other|Federal Republic|Other|Constitutional Monarchy|Republic|Republic|Federal Republic|Republic|Republic|Federal Republic|Constitutional Monarchy|Republic|Republic|Parliamentary Monarchy|Constitutional Monarchy|Other|Constitutional Monarchy|Federal Republic";
            string times = "GMT-3:00|GMT+2:00|GMT+2:00|GMT-3:00|GMT-3:30|GMT+2:00|GMT+3:00|GMT+2:00|GMT+1:00|GMT+1:00|GMT+1:00|GMT-6:00|GMT+1:00|GMT+1:00|GMT+1:00|GMT+1:00|GMT+1:00|GMT+1:00|GMT+0:00|GMT-6:00";
            string languages = "Spanish|German|Dutch, French, German|Portuguese|English, French|Danish|Finnish, Swedish|French|German|English|Italian|Spanish|Finnish, Norwegian|Polish|Portuguese|Spanish|Swedish|French, German, Italian|English|English";

            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
            {
                //Load image data
                c1FlexGrid1[i, _imageCol] = imageList1.Images[i - 1];
                //Load text data
                c1FlexGrid1[i, _textCol] = countries.Split('|')[i - 1];
                //Load combos data
                c1FlexGrid1[i, _multiComboCol] = currencies.Split('|')[i - 1];
                //Load multi-column combos data
                c1FlexGrid1[i, _comboCol] = govs.Split('|')[i - 1];
                //Load input mask data
                c1FlexGrid1[i, _editMaskCol] = times.Split('|')[i - 1];
                //Load checkbox list data
                c1FlexGrid1[i, _checkListCol] = languages.Split('|')[i - 1];
            }

            //Load Dates column
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
            {
                c1FlexGrid1[i, _dateCol] = DateTime.Now.AddDays(rnd.Next(1, 100));
            }

            //Load Checkbox column
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
            {
                c1FlexGrid1[i, _checkboxCol] = countries.Split('|')[i - 1].Length % 2;
            }

            //Load numeric column
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
            {
                c1FlexGrid1[i, _numericCol] = rnd.Next(1, 1500);
            }

            //Load hyperlink column
            c1FlexGrid1[1, _hyperlinkCol] = new FlexHyperlink("Secretariat of Tourism", "http://www.turismo.gov.ar/eng/menu.htm");
            c1FlexGrid1[2, _hyperlinkCol] = new FlexHyperlink("Embassy of Austria", "http://www.austria.org/");
            c1FlexGrid1[3, _hyperlinkCol] = new FlexHyperlink("Visit Belgium", "http://www.visitbelgium.com/");
            c1FlexGrid1[4, _hyperlinkCol] = new FlexHyperlink("Brazil - Wikipedia", "http://en.wikipedia.org/wiki/Brazil");
            c1FlexGrid1[5, _hyperlinkCol] = new FlexHyperlink("Canada.com", "http://www.canada.com/");
            c1FlexGrid1[6, _hyperlinkCol] = new FlexHyperlink("Official website of Denmark", "http://www.denmark.dk/");
            c1FlexGrid1[7, _hyperlinkCol] = new FlexHyperlink("Breaking News from Finland", "http://finland.fi/");
            c1FlexGrid1[8, _hyperlinkCol] = new FlexHyperlink("France Guide.com", "http://www.franceguide.com/");
            c1FlexGrid1[9, _hyperlinkCol] = new FlexHyperlink("Germany.info", "http://www.germany.info/");
            c1FlexGrid1[10, _hyperlinkCol] = new FlexHyperlink("Discover Ireland", "http://www.discoverireland.ie/");
            c1FlexGrid1[11, _hyperlinkCol] = new FlexHyperlink("Facts About Italy", "http://www.state.gov/r/pa/ei/bgn/4033.htm");
            c1FlexGrid1[12, _hyperlinkCol] = new FlexHyperlink("Visit Mexico", "http://www.visitmexico.com/");
            c1FlexGrid1[13, _hyperlinkCol] = new FlexHyperlink("Official Norwegian website", "http://www.norway.org/");
            c1FlexGrid1[14, _hyperlinkCol] = new FlexHyperlink("Poland.pl", "http://www.poland.pl/");
            c1FlexGrid1[15, _hyperlinkCol] = new FlexHyperlink("Portugal Maps", "http://www.portugal-info.net/maps/");
            c1FlexGrid1[16, _hyperlinkCol] = new FlexHyperlink("Spain Tourism", "http://www.spain.info/");
            c1FlexGrid1[17, _hyperlinkCol] = new FlexHyperlink("Visit Sweden", "http://www.visitsweden.com/");
            c1FlexGrid1[18, _hyperlinkCol] = new FlexHyperlink("Info About Switzerland", "http://www.about.ch/");
            c1FlexGrid1[19, _hyperlinkCol] = new FlexHyperlink("Google UK", "http://www.google.co.uk/");
            c1FlexGrid1[20, _hyperlinkCol] = new FlexHyperlink("The United States - Wikipedia", "http://en.wikipedia.org/wiki/United_States");

            //Load large text column
            c1FlexGrid1[1, _largeTextCol] = "Argentina is the eighth largest country in the world by land area and the largest among Spanish-speaking nations, though Mexico, Colombia and Spain are more populous.";
            c1FlexGrid1[2, _largeTextCol] = "The origins of Austria date back to the time of the Roman Empire when a Celtic kingdom was conquered by the Romans in approximately 15 BC, and later became Noricum, a Roman province, in the mid 1st century AD—an area which mostly encloses today's Austria.";
            c1FlexGrid1[3, _largeTextCol] = "Straddling the cultural boundary between Germanic and Latin Europe, Belgium is home to two main linguistic groups, the Flemish and the French-speakers, mostly Walloons, plus a small group of German-speakers.";
            c1FlexGrid1[4, _largeTextCol] = "Brazil is the world's tenth largest economy at market exchange rates and the ninth largest by purchasing power parity.";
            c1FlexGrid1[9, _largeTextCol] = "The territory of Germany covers 357,021 square kilometers (137,847 sq mi) and is influenced by a temperate seasonal climate. With 82 million inhabitants, it accounts for the largest population among the member states of the European Union and is home to the third-largest number of international migrants worldwide.";
            c1FlexGrid1[10, _largeTextCol] = "Traditionally, the island of Ireland is subdivided into four provinces: Connacht, Leinster, Munster and Ulster; and, in a system developed between the 13th and 17th centuries, thirty-two counties.";
            c1FlexGrid1[12, _largeTextCol] = "Mexico is crossed from north to south by two mountain ranges known as Sierra Madre Oriental and Sierra Madre Occidental, which are the extension of the Rocky Mountains from northern North America.";
            c1FlexGrid1[16, _largeTextCol] = "Because of its location, the territory of Spain was subject to many external influences, often simultaneously, since prehistoric times and through the dawn of the new era.";
            c1FlexGrid1[17, _largeTextCol] = "Sweden emerged as an independent and unified country during the Middle Ages. In the 17th century the country expanded its territories to form the Swedish empire.";
            c1FlexGrid1[18, _largeTextCol] = "Switzerland is a landlocked country whose territory is geographically divided between the Jura, the Central Plateau and the Alps; adding together an area of 41,285 km².";
            c1FlexGrid1[19, _largeTextCol] = "The UK is a developed country, with the world's sixth largest economy by nominal GDP and the seventh largest by purchasing power parity.";
            c1FlexGrid1[20, _largeTextCol] = "The country is situated mostly in central North America, where its 48 contiguous states and Washington, D.C., the capital district, lie between the Pacific and Atlantic Oceans, bordered by Canada to the north and Mexico to the south.";

            // Load progressbar column
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
            {
                c1FlexGrid1[i, _progressBarCol] = rnd.Next(0, 100);
            }

            // Create Dictionary for DataMap
            var countryDict = new Dictionary<int, string>();

            DataTable dt = Data.DataSource.GetRows("SELECT CountryID, CountryName FROM Countries");

            // Populate Dictionary (CountryID -> CountryName)
            foreach (DataRow dr in dt.Rows)
            {
                int countryId = Convert.ToInt32(dr["CountryID"]);
                string countryName = dr["CountryName"].ToString();

                if (!countryDict.ContainsKey(countryId)) // Avoid duplicates
                {
                    countryDict.Add(countryId, countryName);
                }
            }

            // Assign DataMap Before Assigning Data
            var countryColumn = c1FlexGrid1.Cols[_CountryIDCol];
            countryColumn.DataMap = countryDict;

            // Assign Data to the FlexGrid
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
            {
                c1FlexGrid1[i, _CountryIDCol] = Convert.ToInt32(dt.Rows[i - 1]["CountryID"]); // Ensure correct type
            }

        }

        Bitmap _bmp;
        ProgressBar pb;

        private void c1FlexGrid1_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            if (e.Row <= 0) return;

            //Handle Hyperlinks
            if (e.Col == _hyperlinkCol)
            {
                FlexHyperlink link = c1FlexGrid1[e.Row, e.Col] as FlexHyperlink;
                if (link != null)
                    e.Style = c1FlexGrid1.Styles[link.Visited ? "OldLink" : "NewLink"];

            }

            //Handle Progress Bars
            else if (e.Col == _progressBarCol && e.Row > 0 && e.Row < c1FlexGrid1.Rows.Count - 1)
            {
                //Get underlying value
                int value = 0;
                if (c1FlexGrid1[e.Row, e.Col] == null)
                {
                    c1FlexGrid1[e.Row, e.Col] = value;
                }
                else
                {
                    value = (int)c1FlexGrid1[e.Row, e.Col];
                }
                if (value < 0) value = 0;
                if (value > 100) value = 100;

                // draw background
                //e.Style = c1FlexGrid1.Styles.Highlight;
                e.DrawCell(DrawCellFlags.Background);

                // draw progress bar background from actual ProgressBar control
                Rectangle rc = e.Bounds;
                rc.Inflate(-2, -2);
                _bmp = new Bitmap(e.Bounds.Size.Width, e.Bounds.Size.Height);
                pb.Size = e.Bounds.Size;
                pb.DrawToBitmap(_bmp, new Rectangle(new Point(0, 0), e.Bounds.Size));
                e.Graphics.DrawImage(_bmp, rc);

                //Draw Green Progress image over top of background
                rc.Width = rc.Width * value / 100;
                rc.Inflate(-1, -1);
                e.Graphics.DrawImage(imageList1.Images["progress.png"], rc);

                // draw text
                e.Text = value.ToString() + "%";
                e.DrawCell(DrawCellFlags.Content);
                e.Handled = true;
            }

        }

        private void c1FlexGrid1_MouseMove(object sender, MouseEventArgs e)
        {
            //Handle Hyperlink cursor
            HitTestInfo ht = c1FlexGrid1.HitTest(e.X, e.Y);
            if (ht.Column == _hyperlinkCol)
            {
                bool hand = false;
                if (ht.Type == HitTestTypeEnum.Cell)
                {
                    FlexHyperlink link = c1FlexGrid1[ht.Row, ht.Column] as FlexHyperlink;
                    if (link != null)
                    {
                        using (Graphics g = c1FlexGrid1.CreateGraphics())
                        {
                            Rectangle rc = c1FlexGrid1.GetCellRect(ht.Row, ht.Column, false);
                            int width = (int)g.MeasureString(link.ToString(), c1FlexGrid1.Font).Width;
                            if (e.X - rc.Left <= width)
                                hand = true;
                        }
                        //set Tooltip
                        c1SuperTooltip1.SetToolTip(c1FlexGrid1, link.Url);
                    }
                }
                Cursor = (hand) ? Cursors.Hand : Cursors.Default;
            }
            else
            {
                if (Cursor == Cursors.Hand)
                {
                    Cursor = Cursors.Default;
                    c1SuperTooltip1.RemoveAll();
                }
            }
        }

        private void c1FlexGrid1_MouseDown(object sender, MouseEventArgs e)
        {
            //Handle Hyperlink click
            if (Cursor == Cursors.Hand)
            {
                HitTestInfo ht = c1FlexGrid1.HitTest(e.X, e.Y);
                if (ht.Type == HitTestTypeEnum.Cell)
                {
                    FlexHyperlink link = c1FlexGrid1[ht.Row, ht.Column] as FlexHyperlink;
                    if (link != null)
                        link.Activate();
                }
            }
        }

        private void c1FlexGrid1_SetupEditor(object sender, RowColEventArgs e)
        {
            if (e.Col == _largeTextCol)
            {
                //Set size of large text box editor
                c1FlexGrid1.Cols[e.Col].Editor.Size = new Size(250, 100);
            }
        }

        private void ShowBtnsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showBtnsCb.SelectedItem != null)
            {
                // Convert the selected string back to ShowButtonsEnum
                c1FlexGrid1.ShowButtons = (ShowButtonsEnum)Enum.Parse(
                    typeof(ShowButtonsEnum), showBtnsCb.SelectedItem.ToString()
                );
            }
        }

        private void KeyActionCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (keyActionCb.SelectedItem != null)
            {
                c1FlexGrid1.KeyActionTab = (KeyActionEnum)Enum.Parse(
                    typeof(KeyActionEnum), keyActionCb.SelectedItem.ToString()
                );
            }

            // Set focus to the FlexGrid
            c1FlexGrid1.Focus();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            // Toggle AllowAddNew
            c1FlexGrid1.AllowAddNew = !c1FlexGrid1.AllowAddNew;

            // Set the button image based on the new state
            string imageKey = c1FlexGrid1.AllowAddNew ? "checked" : "unchecked";
            addNewBtn.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageKey);
        }

    }

    #region ** CheckListEditor
    //
    // CheckListEditor
    // 
    public class CheckListComboBox : C1ComboBox
    {
        private ChecklistPopupForm _popupForm;
        private string[] _items;

        public CheckListComboBox(string[] items)
        {
            _items = items;
            this.DropDownStyle = DropDownStyle.DropDownList;
            this.Text = "Select...";

            this.MouseDown += (s, e) =>
            {
                ShowChecklistForm();
            };
        }

        private void ShowChecklistForm()
        {
            _popupForm = new ChecklistPopupForm(_items, GetSelectedItems());
            _popupForm.StartPosition = FormStartPosition.Manual;
            var screenPos = this.PointToScreen(new Point(0, this.Height));
            _popupForm.Location = screenPos;
            _popupForm.Width = this.Width;
            _popupForm.FormClosed += (s, e) =>
            {
                SetSelectedItems(_popupForm.GetCheckedItems());
            };
            _popupForm.Show();
        }

        private void SetSelectedItems(List<string> selectedItems)
        {
            this.Text = string.Join(", ", selectedItems);
        }

        private List<string> GetSelectedItems()
        {
            return this.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }

    public class ChecklistPopupForm : Form
    {
        private CheckedListBox _checkedListBox;

        public ChecklistPopupForm(string[] items, List<string> preSelected)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Deactivate += (s, e) => this.Close();

            _checkedListBox = new CheckedListBox
            {
                Dock = DockStyle.Fill,
                CheckOnClick = true
            };
            _checkedListBox.Items.AddRange(items);

            for (int i = 0; i < _checkedListBox.Items.Count; i++)
            {
                if (preSelected.Contains(_checkedListBox.Items[i].ToString()))
                {
                    _checkedListBox.SetItemChecked(i, true);
                }
            }

            this.Controls.Add(_checkedListBox);
            this.Height = 200;
        }

        public List<string> GetCheckedItems()
        {
            return _checkedListBox.CheckedItems.Cast<string>().ToList();
        }
    }
    #endregion

    #region ** FlexHyperlink class

    public class FlexHyperlink
    {
        string _text;
        string _link;
        bool _visited;

        public FlexHyperlink(string text, string link)
        {
            _text = text;
            _link = link;
            _visited = false;
        }
        public bool Visited
        {
            get { return _visited; }
        }
        public string Url
        {
            get { return _link; }
        }
        public Process Activate()
        {
            _visited = true;
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = _link,
                    UseShellExecute = true
                };
                return Process.Start(psi);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // Handle the exception as needed
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        override public string ToString()
        {
            return _text;
        }
    }

    #endregion
}
