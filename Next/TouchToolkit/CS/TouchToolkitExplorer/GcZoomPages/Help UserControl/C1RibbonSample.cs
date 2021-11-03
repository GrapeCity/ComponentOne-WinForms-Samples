using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using C1.C1Preview;

namespace ClickOnceDemo.GcZoomPages
{
    public partial class C1RibbonSample : UserControl
    {
        RenderTable rtMain;
        RenderTable rtSub;
        RenderTable rtBorder;
        public C1RibbonSample()
        {
            InitializeComponent();
            radioButtonHost1.RadioButton.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButtonHost2.RadioButton.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            checkedListBoxHost1.CheckedListBox.MouseUp += checkedListBox1_MouseUp;
            pictureBoxHost1.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        
        private void CustomEditors_Load(object sender, EventArgs e)
        {
            //Create business-card sized page settings
            C1.C1Preview.PageLayout pl = new C1.C1Preview.PageLayout();
            pl.PageSettings = new C1.C1Preview.C1PageSettings();
            pl.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            pl.PageSettings.Width = new Unit(3.5, UnitTypeEnum.Inch);
            pl.PageSettings.Height = new Unit(2, UnitTypeEnum.Inch);
            pl.PageSettings.TopMargin = new Unit(3, UnitTypeEnum.Mm);
            pl.PageSettings.RightMargin = new Unit(3, UnitTypeEnum.Mm);
            pl.PageSettings.LeftMargin = new Unit(3, UnitTypeEnum.Mm);
            pl.PageSettings.BottomMargin = new Unit(3, UnitTypeEnum.Mm);
            c1PrintDocument1.PageLayouts.Default = pl;
               
            //Create watermark
            RenderImage ri = new RenderImage();
            ri.Image = Properties.Resources.Referesh;
            c1PrintDocument1.PageLayout.Watermark = ri;
            c1PrintDocument1.PageLayout.Watermark.X = new Unit(1.75, UnitTypeEnum.Inch);
            
            //Create data table with border
            rtMain = new RenderTable(3, 2);
            rtSub = new RenderTable(3, 1);
            rtBorder = new RenderTable(1, 1);
            rtBorder.Width = 3.26;
            rtBorder.Height = 1.76;
            rtBorder.Style.Borders.All = new C1.C1Preview.LineDef("2pt", Color.Gray);
            rtBorder.Style.Padding.Left = new Unit(1, UnitTypeEnum.Mm);
            rtMain.Style.Padding.Top = new Unit(1, UnitTypeEnum.Mm);
            rtMain.Cells[1, 1].Area.Children.Add(rtSub);
            rtBorder.Cells[0, 0].Area.Children.Add(rtMain);
            rtMain.Cols[0].Width = 1;
            rtMain.Cells[0, 0].Text = "ComponentOne Dev-Tools License";
            rtMain.Cells[0, 0].Style.TextAlignHorz = AlignHorzEnum.Center;
            rtMain.Rows[0].Style.FontBold = true;
            rtMain.Cells[0, 0].SpanCols = 2;
            rtSub.Cells[0, 0].Text = "Name: ";
            rtSub.Cells[1, 0].Text = "Age: ";
            rtSub.Cells[2, 0].Text = "Gender: ";
            rtMain.Cells[2, 0].Text = "Expertise: ";
            rtMain.Cells[2, 0].SpanCols = 2;
            c1PrintDocument1.Body.Children.Add(rtBorder);
            c1PrintDocument1.Style.Borders.All = new C1.C1Preview.LineDef("2pt", Color.Red);

            loadImage();
            c1PreviewPane1.Document = c1PrintDocument1;

            textBoxHost1.TextBox.BorderStyle = BorderStyle.None;
        }
        
        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            //Refresh document
            refreshDocument();
        }
        
        private void refreshDocument()
        {
            c1PrintDocument1.Generate();
        }
        
        private void pictureBoxHost1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxHost1.Image = Image.FromFile(ofd.FileName);
                loadImage();
            }
        }

        private void loadImage()
        {
            Bitmap bm = new Bitmap(pictureBoxHost1.Image, new Size(79, 79));
            rtMain.Cells[1, 0].Area.Children.Clear();
            rtMain.Cells[1, 0].Area.Children.Add(new RenderImage(bm));
            refreshDocument();
        }

        private void textBoxHost1_TextChanged(object sender, EventArgs e)
        {
            rtSub.Cells[0, 0].Text = "Name: " + textBoxHost1.Text;
            refreshDocument();
        }

        private void numericUpDownHost1_ValueChanged(object sender, EventArgs e)
        {
            rtSub.Cells[1, 0].Text = "Age: " + numericUpDownHost1.Text;
            refreshDocument();
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHost1.RadioButton.Checked)
                rtSub.Cells[2, 0].Text = "Gender: Male";
            else
                rtSub.Cells[2, 0].Text = "Gender: Female";
            refreshDocument();
        }

        private void checkedListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            rtMain.Cells[2, 0].Text = "Expertise: ";
            if (checkedListBoxHost1.CheckedListBox.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBoxHost1.CheckedListBox.CheckedItems.Count; i++)
                {
                    rtMain.Cells[2, 0].Text = rtMain.Cells[2, 0].Text + checkedListBoxHost1.CheckedListBox.CheckedItems[i] + " ";
                }
            }
            refreshDocument();
        }
        
        private void backColorEditor_SelectedColorChanged(object sender, EventArgs e)
        {
            rtBorder.Style.Borders.All = new C1.C1Preview.LineDef("2pt", backColorEditor.SelectedColor);
            refreshDocument();
        }

        private void foreColorEditor_SelectedColorChanged(object sender, EventArgs e)
        {
            c1PrintDocument1.Style.TextColor = foreColorEditor.SelectedColor;
            refreshDocument();
        }

        private void fontEditorHost1_SelectedFontChanged(object sender, EventArgs e)
        {
            c1PrintDocument1.Style.Font = fontEditorHost1.SelectedFont;
            refreshDocument();
        }

    }
}

