using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StockChart
{
    public class AutoCompleteTextbox : TextBox
    {
        #region Fields

        private ListBox listBox;
        private string oldText;
        private Panel panel;

        #endregion Fields

        #region Constructors
        
        public AutoCompleteTextbox()
            : base()
        {
            this.MinTypedCharacters = 2;
            this.CaseSensitive = false;
            this.AutoCompleteList = new List<string>();

            this.listBox = new ListBox();
            this.listBox.BackColor = System.Drawing.Color.FromArgb(255,66,66,66);
            this.listBox.ForeColor = System.Drawing.Color.White;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.listBox.Name = "SuggestionListBox";
            this.listBox.Font = this.Font;
            this.listBox.Visible = true;

            this.listBox.DrawMode = DrawMode.OwnerDrawVariable;
            var itemHeight = 0;

            this.listBox.MeasureItem += (o, e) =>
            {
                itemHeight = e.ItemHeight + 10;
                e.ItemHeight = itemHeight;
                panel.Height = Math.Min(450, (this.listBox.Items.Count + 1) * e.ItemHeight);
            };
            this.listBox.DrawItem += (o, e) =>
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                var text = (string)this.listBox.Items[e.Index];
                var textSize = e.Graphics.MeasureString(text, e.Font, int.MaxValue);
                e.Graphics.DrawString(
                     text,
                     e.Font,
                     new SolidBrush(e.ForeColor), 
                     e.Bounds.Location.X, e.Bounds.Location.Y + (itemHeight - textSize.Height) / 2
                     );
                
            };
            
            this.panel = new Panel();
            this.panel.Visible = false;
            this.panel.Font = this.Font;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.ClientSize = new System.Drawing.Size(1, 1);
            this.panel.Name = "SuggestionPanel";
            this.panel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel.BackColor = Color.FromArgb(255, 80, 80, 80);
            this.panel.ForeColor = Color.Transparent;
            this.panel.Text = "";
            this.panel.PerformLayout();
            if (!panel.Controls.Contains(listBox))
            {
                this.panel.Controls.Add(listBox);
            }
            
            this.listBox.Dock = DockStyle.Fill;
            this.listBox.SelectionMode = SelectionMode.One;
            this.listBox.KeyDown += new KeyEventHandler(listBox_KeyDown);
            this.listBox.MouseClick += new MouseEventHandler(listBox_MouseClick);
            this.listBox.MouseDoubleClick += new MouseEventHandler(listBox_MouseDoubleClick);

            #region Excursus: ArrayList vs. List<string>
            #endregion Excursus: ArrayList vs. List<string>
            this.CurrentAutoCompleteList = new List<string>();

            #region Excursus: DataSource vs. AddRange
            #endregion Excursus: DataSource vs. AddRange
            listBox.DataSource = CurrentAutoCompleteList;
            
            oldText = this.Text;
            
        }

        #endregion Constructors

        #region Properties
        
        public List<string> AutoCompleteList
        {
            get;
            set;
        }
        
        public bool CaseSensitive
        {
            get;
            set;
        }
        public int MinTypedCharacters
        {
            get;
            set;
        }
        
        public int SelectedIndex
        {
            get
            {
                return listBox.SelectedIndex;
            }
            set
            {
                if (listBox.Items.Count != 0)
                { listBox.SelectedIndex = value; }
            }
        }
        
        private List<string> CurrentAutoCompleteList
        {
            set;
            get;
        }


        private Form _parentForm;
        private Form ParentForm
        {
            get
            {
                if (_parentForm == null)
                {
                    _parentForm = this.Parent.FindForm();

                    _parentForm.SizeChanged += (o, e) =>
                    {
                        if (!panel.ContainsFocus)
                        {
                            this.HideSuggestionListBox();
                        }
                    };
                }
                return _parentForm;
            }
        }

        #endregion Properties

        #region Methods

        public void HideSuggestionListBox()
        {
            if ((ParentForm != null))
            {
                panel.Hide();
                if (this.ParentForm.Controls.Contains(panel))
                {
                    this.ParentForm.Controls.Remove(panel);
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs args)
        {
            if ((args.KeyCode == Keys.Up))
            {
                MoveSelectionInListBox((SelectedIndex - 1));
                args.Handled = true;
            }
            else if ((args.KeyCode == Keys.Down))
            {
                MoveSelectionInListBox((SelectedIndex + 1));
                args.Handled = true;
            }
            else if ((args.KeyCode == Keys.PageUp))
            {
                MoveSelectionInListBox((SelectedIndex - 10));
                args.Handled = true;
            }
            else if ((args.KeyCode == Keys.PageDown))
            {
                MoveSelectionInListBox((SelectedIndex + 10));
                args.Handled = true;
            }
            else if ((args.KeyCode == Keys.Enter))
            {
                SelectItem();
                args.Handled = true;
            }
            else
            {
                base.OnKeyDown(args);
            }
        }
        
        protected override void OnLostFocus(System.EventArgs e)
        {
            if (!panel.ContainsFocus)
            {
                base.OnLostFocus(e);
                this.HideSuggestionListBox();
            }
        }
        
        protected override void OnTextChanged(EventArgs args)
        {
            if (!this.DesignMode)
                ShowSuggests();
            base.OnTextChanged(args);
            oldText = this.Text;
        }
        
        private void listBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectItem();
                e.Handled = true;
            }
        }
        
        private void listBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SelectItem();
        }
        
        private void listBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SelectItem();
        }

        private void MoveSelectionInListBox(int Index)
        {
            if (Index <= -1)
            {
                this.SelectedIndex = 0;
            }
            else if (Index > (listBox.Items.Count - 1))
            {
                SelectedIndex = (listBox.Items.Count - 1);
            }
            else
            { SelectedIndex = Index; }
        }
        
        
        private bool SelectItem()
        {
            if (((this.listBox.Items.Count > 0) && (this.SelectedIndex > -1)))
            {
                this.Text = this.listBox.SelectedItem.ToString();
                this.HideSuggestionListBox();
            }
            return true;
        }
        
        private void ShowSuggests()
        {
            if (this.Text.Length >= MinTypedCharacters)
            {
                panel.SuspendLayout();
                if ((this.Text.Length > 0) && (this.oldText == this.Text.Substring(0, this.Text.Length - 1)))
                {
                    UpdateCurrentAutoCompleteList();
                }
                else if ((this.oldText.Length > 0) && (this.Text == this.oldText.Substring(0, this.oldText.Length - 1)))
                {
                    UpdateCurrentAutoCompleteList();
                }
                else
                {
                    UpdateCurrentAutoCompleteList();
                }

                if (((CurrentAutoCompleteList != null) && CurrentAutoCompleteList.Count > 0))
                {
                    panel.Show();
                    panel.BringToFront();
                    this.Focus();
                }
                else
                {
                    this.HideSuggestionListBox();
                }
                panel.ResumeLayout(true);
            }
            else
            {
                this.HideSuggestionListBox();
            }
        }
        
        private void UpdateCurrentAutoCompleteList()
        {
            CurrentAutoCompleteList.Clear();
            foreach (string Str in AutoCompleteList)
            {
                if (CaseSensitive)
                {
                    if ((Str.IndexOf(this.Text) > -1))
                    { CurrentAutoCompleteList.Add(Str); }
                }
                else
                {
                    if ((Str.ToLower().IndexOf(this.Text.ToLower()) > -1))
                    { CurrentAutoCompleteList.Add(Str); }
                }
            }
            #region Excursus: Performance measuring of Linq queries
            // This is a simple example of speedmeasurement for Linq querries
            /*
            CurrentAutoCompleteList.Clear();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            // using Linq query seems to be slower (twice as slow)
            var query =
                from expression in this.AutoCompleteList
                where expression.ToLower().Contains(this.Text.ToLower())
                select expression;
            foreach (string searchTerm in query)
            {
                CurrentAutoCompleteList.Add(searchTerm);
            }
            stopWatch.Stop();
            // method (see below) for printing the performance values to console
            PrintStopwatch(stopWatch, "Linq - Contains");
            */
            #endregion Excursus: Performance measuring of Linq queries

            // countinue to update the ListBox - the visual part
            UpdateListBoxItems();
        }
        
        private void UpdateListBoxItems()
        {
            if ((ParentForm != null))
            {
                panel.Width = 230;
                Size parentBisSize = new Size(this.ParentForm.PointToScreen(new Point()).X, this.ParentForm.PointToScreen(new Point()).Y);
                panel.Location = this.PointToScreen(this.Location) - parentBisSize + new Size(0, this.Height) + new Size(-10, 0);
                if (!this.ParentForm.Controls.Contains(panel))
                {
                    this.ParentForm.Controls.Add(panel);
                }
                ((CurrencyManager)listBox.BindingContext[CurrentAutoCompleteList]).Refresh();
            }
        }

        #endregion Methods
    }
}
