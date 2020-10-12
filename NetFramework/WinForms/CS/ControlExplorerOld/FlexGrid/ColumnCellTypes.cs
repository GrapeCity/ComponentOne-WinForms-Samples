using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class ColumnCellTypes : C1DemoForm
    {
        public ColumnCellTypes()
        {
            InitializeComponent();
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
        
        //Total column count
        private int _colCount = 13;  

        //The FlexGrid in this demo is completely unbound. All of the column properties and data are added manually below
        private void ColumnCellTypes_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.Cols.Count = _colCount;

            //Image column
            Column imageCol = c1FlexGrid1.Cols[_imageCol];
            imageCol.Caption = "Images";
            imageCol.DataType = typeof(Image);
            imageCol.ImageAlign = ImageAlignEnum.CenterCenter;
            //imageCol.Editor = new ImagePicker();
            imageCol.Width = 75;

            //Text column
            Column textCol = c1FlexGrid1.Cols[_textCol];
            textCol.Caption = "Text";

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

            //Combo column
            Column comboCol = c1FlexGrid1.Cols[_comboCol];
            comboCol.ComboList = "|Republic|Federal Republic|Constitutional Monarchy|Parliamentary Monarchy";
            comboCol.Caption = "Editable Combobox";
            comboCol.Width = 150;

            //Date column
            Column dateCol = c1FlexGrid1.Cols[_dateCol];
            dateCol.DataType = typeof(DateTime);
            dateCol.Caption = "Date";

            //Input mask column
            Column editMaskCol = c1FlexGrid1.Cols[_editMaskCol];
            editMaskCol.EditMask = "GMT#0:00";
            editMaskCol.Caption = "Input Mask";

            //Checkbox List column
            Column checkListCol = c1FlexGrid1.Cols[_checkListCol];
            CheckListEditor checkListEditor = new CheckListEditor(new string[] { "Danish", "Dutch", "English", "Finnish", "French", "German", "Italian", "Norwegian", "Polish", "Portuguese", "Spanish", "Swedish" });
            checkListCol.Caption = "Checkbox List";
            checkListCol.Editor = new UITypeEditorControl(checkListEditor, false);
            checkListCol.Width = 150;

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
            c1Combo1.DropDownWidth = 202;
            c1Combo1.Splits[0].DisplayColumns[0].Width = 50;
            c1Combo1.Splits[0].DisplayColumns[1].Width = 30;
            Column multiComboCol = c1FlexGrid1.Cols[_multiComboCol];
            multiComboCol.Caption = "Multi-Column Combo";
            multiComboCol.Editor = c1Combo1;
            multiComboCol.Width = 130;     
            
            //Hyperlink column
            Column hyperlinkCol = c1FlexGrid1.Cols[_hyperlinkCol];
            hyperlinkCol.Caption = "Hyperlink";
            hyperlinkCol.AllowEditing = true;
            hyperlinkCol.Width = 160;
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
          
            //Load data
            LoadData();

            //Display Add new Row
            c1FlexGrid1.AllowAddNew = true;  
        
            //Add Demo Properties
            AddProperty("AllowAddNew", c1FlexGrid1);
            AddProperty("KeyActionTab", c1FlexGrid1);
            AddProperty("ShowButtons", c1FlexGrid1);
            
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

            //Load progressbar column
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
            {
                c1FlexGrid1[i, _progressBarCol] = rnd.Next(0, 100);
            }
        } 

        private void c1FlexGrid1_CellButtonClick(object sender, RowColEventArgs e)
        {
            //Fires when user clicks any cell button. Use e.Row/e.Col to determine which button was clicked.
        }

        Bitmap _bmp;
        CellStyle csCellStyle;
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

    }

    #region ** UITypeEditorControl (base class for all of the controls below)

    /// <summary>
    /// UITypeEditorControl
    /// </summary>
    public class UITypeEditorControl :
        ComboBox,
        IServiceProvider,
        IWindowsFormsEditorService
    {
        //===========================================================================
        #region ** fields
        private UITypeEditor _editor;	// UITypeEditor responsible for editing the values
        private Form _form;		// form used to show the drop down
        private Rectangle _bounds;	// cell bounds (used to position control and form)
        private object _value;		// current editor value 
        private bool _dropped;	// whether the drop down was displayed
        private bool _allowTyping;	// whether to allow user to edit the string representation of the value
        #endregion

        //===========================================================================
        #region ** ctor

        public UITypeEditorControl(UITypeEditor editor, bool allowTyping)
        {
            // save ctor parameters
            _editor = editor;
            _allowTyping = allowTyping;

            // initialize combo
            DropDownStyle = ComboBoxStyle.DropDown;
            DrawMode = DrawMode.OwnerDrawFixed;

            // initialize drop down editor
            _form = new Form();
            _form.StartPosition = FormStartPosition.Manual;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.ShowInTaskbar = false;
            _form.TopLevel = true;
            _form.Deactivate += new EventHandler(_form_Deactivate);
        }
        #endregion

        //===========================================================================
        #region ** IC1EmbeddedEditor

        public void C1EditorInitialize(object value, IDictionary attributes)
        {
            // initialize editor value
            _value = value;
            if (value != null)
            {
                TypeConverter tc = TypeDescriptor.GetConverter(value.GetType());
                try
                {
                    Text = (string)tc.ConvertToString(value);
                }
                catch
                {
                    Text = string.Empty;
                }
            }

            // initialize editor style
            Font = (Font)attributes["Font"];
            BackColor = (Color)attributes["BackColor"];
            ForeColor = (Color)attributes["ForeColor"];

            // we haven't dropped the editor yet
            _dropped = false;
        }
        public object C1EditorGetValue()
        {
            // return value from drop down or from edit area
            return (_dropped) ? _value : Text;
        }
        public UITypeEditorEditStyle C1EditorGetStyle()
        {
            return _editor.GetEditStyle();
        }
        public void C1EditorUpdateBounds(Rectangle rc)
        {
            // store bounds, will apply when showing the form
            _bounds = Parent.RectangleToScreen(rc);

            // if the user can type, position the combo
            if (_allowTyping)
            {
                rc.Inflate(2, 2);
                ItemHeight = Math.Max(3, rc.Height - 6);
                Bounds = rc;
            }
            else // can't type, so hide the control
            {
                Bounds = Rectangle.Empty;
            }
        }

        #endregion

        //===========================================================================
        #region ** overrides

        // if the user can't type, show drop down right away
        override protected void OnEnter(EventArgs e)
        {
            if (!_allowTyping)
                DoDropDown();
        }

        // if the user can type, show drop down when requested
        override protected void OnDropDown(EventArgs e)
        {
            if (_allowTyping)
                DoDropDown();
        }

        // suppress OnLeave event until we're done editing
        override protected void OnLeave(EventArgs e)
        {
            // if we dropped down, wait until we're done editing
            if (_dropped)
                return;

            // we didn't drop down, allow default processing
            base.OnLeave(e);
        }

        // this is done only to avoid annoying beeps from the ComboBox
        override public bool PreProcessMessage(ref Message msg)
        {
            switch (msg.Msg)
            {
                case 0x100: // WM_KEYDOWN:

                    // digest key that was pressed
                    KeyEventArgs e = new KeyEventArgs((Keys)(int)msg.WParam);

                    // if it was a tab or enter, handle internally but don't pass
                    // to stupid base class to avoid annoying beeps.
                    switch (e.KeyCode)
                    {
                        case Keys.Tab:
                        case Keys.Enter:
                        case Keys.Escape:
                            OnKeyDown(e);
                            return true;
                    }
                    break;
            }

            // allow regular processing
            return false;
        }
        #endregion

        //===========================================================================
        #region ** private members

        private void DoDropDown()
        {
            // fire event as usual
            base.OnDropDown(EventArgs.Empty);

            // if this is a popup, hide editing area
            if (_editor.GetEditStyle() == UITypeEditorEditStyle.Modal)
                Bounds = Rectangle.Empty;

            // show editor and get the new value
            _dropped = true;
            _value = _editor.EditValue((IServiceProvider)this, _value);

            // force the drop down to close
            DrawMode = DrawMode.Normal;
            DrawMode = DrawMode.OwnerDrawFixed;
            DroppedDown = false;
            Capture = false;

            // fire OnLeave so grid knows we're done
            base.OnLeave(EventArgs.Empty);
        }

        #endregion

        //===========================================================================
        #region ** event handlers

        // close drop down when form deactivated
        private void _form_Deactivate(object sender, EventArgs e)
        {
            ((IWindowsFormsEditorService)this).CloseDropDown();
        }

        #endregion

        //===========================================================================
        #region ** IServiceProvider interface

        object IServiceProvider.GetService(Type serviceType)
        {
            if (serviceType == typeof(IWindowsFormsEditorService))
                return (IWindowsFormsEditorService)this;
            return null;
        }

        #endregion

        //===========================================================================
        #region ** IWindowsFormsEditorService interface

        void IWindowsFormsEditorService.DropDownControl(Control control)
        {
            // size form
            _form.ClientSize = control.Size;

            // calculate form location to avoid being off the screen
            Point pt = new Point(_bounds.Right - control.Width, _bounds.Bottom);
            Rectangle rc = Screen.GetWorkingArea(this);
            if (_bounds.Bottom + control.Height > rc.Bottom)	// check bottom
                pt.Y = _bounds.Top - _form.Height;
            if (pt.Y < 0) pt.Y = 0;					// check top
            if (_bounds.X + control.Width > rc.Right)		// check right
                pt.X = rc.Right - _form.Width;
            if (pt.X < 0) pt.X = 0;					// check left

            // position form
            _form.Location = pt;

            // add control to form and show it
            _form.Controls.Add(control);
            _form.Show();

            // readjust form size (seems redundant, but isn't...)
            _form.ClientSize = control.Size;

            // wait until user makes a selection
            while (control.Visible)
            {
                Application.DoEvents();
                MsgWaitForMultipleObjects(1, IntPtr.Zero, 0, 5, 255);
            }

            // done
            _form.Hide();
            _form.Controls.Clear();
        }
        void IWindowsFormsEditorService.CloseDropDown()
        {
            _form.Hide();
        }
        DialogResult IWindowsFormsEditorService.ShowDialog(Form dialog)
        {
            // support modal editors
            return dialog.ShowDialog();
        }

        #endregion

        //===========================================================================
        #region ** dll imports

        [System.Runtime.InteropServices.DllImport("User32")]
        private static extern int MsgWaitForMultipleObjects(
            int nCount, IntPtr pHandles, short bWaitAll, int dwMilliseconds, int dwWakeMask);

        #endregion
    }
    #endregion

    #region ** CheckListEditor
    //
    // CheckListEditor
    // UITypeEditor that can be used to edit items in CheckedListBox control.
    // Users can check any combination.
    // 
    public class CheckListEditor : UITypeEditor
    {
        // ** fields
        private IWindowsFormsEditorService _edSvc;
        private CheckedListBox _list;
        private string[] _items;
        private bool _cancel;

        // ** ctor
        public CheckListEditor(string[] items)
        {
            // store reference to items being edited
            _items = items;

            // build selector list
            _list = new CheckedListBox();
            _list.BorderStyle = BorderStyle.Fixed3D;
            _list.CheckOnClick = true;
            _list.ThreeDCheckBoxes = false;
            _list.KeyPress += new KeyPressEventHandler(_list_KeyPress);
        }

        // ** overrides
        override public UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext ctx)
        {
            return UITypeEditorEditStyle.DropDown;
        }
        override public object EditValue(ITypeDescriptorContext ctx, IServiceProvider provider, object value)
        {
            // initialize editor service
            _edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (_edSvc == null)
                return value;

            // null means no flags are checked
            if (value == null)
                value = 0;

            // populate the list
            _list.Items.Clear();
            string items = value.ToString();
            foreach (string item in _items)
            {
                // add this item with the proper check state
                CheckState check = items.Contains(item) ? CheckState.Checked : CheckState.Unchecked;
                _list.Items.Add(item, check);
            }
            _list.Height = Math.Min(300, (_list.Items.Count + 1) * _list.Font.Height);
            _list.Width = 150;

            // show the list
            _cancel = false;
            _edSvc.DropDownControl(_list);

            // build return value from checked items on the list
            if (!_cancel)
            {
                // build a comma-delimited string with the checked items
                StringBuilder sb = new StringBuilder();
                foreach (object item in _list.CheckedItems)
                {
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append(item.ToString());
                }

                // convert empty string
                return (sb.Length > 0) ? sb.ToString() : "None/Other";
            }

            // done
            return value;
        }

        // ** event handlers

        // close editor if the user presses enter or escape
        private void _list_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)27:
                    _cancel = true;
                    _edSvc.CloseDropDown();
                    break;
                case (char)13:
                    _edSvc.CloseDropDown();
                    break;
            }
        }
    }
    #endregion

    #region ** ImagePicker

    /// <summary>
    /// ImagePicker
    /// Uses the Image UITypeEditor to show a form where users can pick images
    /// </summary>
    //public class ImagePicker : UITypeEditorControl
    //{
    //    public ImagePicker() : base(new Control(), false) { }
    //}
    #endregion

    #region ** ColorPicker

    /// <summary>
    /// ColorPicker
    /// Uses the Color UITypeEditor to show a form where users can pick colors
    /// </summary>
    //public class ColorPicker : UITypeEditorControl
    //{
    //    //public ColorPicker() : base(new ColorEditor(), true) { }
    //}
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
            return Process.Start(_link);
        }
        override public string ToString()
        {
            return _text;
        }
    }

#endregion

}
