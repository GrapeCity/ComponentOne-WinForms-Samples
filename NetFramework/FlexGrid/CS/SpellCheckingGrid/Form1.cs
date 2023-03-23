using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    using C1.Win.C1FlexGrid;
    using C1.Win.C1SpellChecker;
    using C1.Win.Drawing;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // add some typos
            this.c1FlexGrid1[1, 1] = "This is OK.";
            this.c1FlexGrid1[2, 1] = "Buut tihs is noot...";            
            this.c1FlexGrid1.AutoSizeCol(1);            
        }

        private void c1FlexGrid1_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
        {
            // draw cell as usual
            e.DrawCell();

            // spell check unless (we're just measuring)
            if (!e.Measuring)
            {
                var fg = sender as C1FlexGrid;
                var text = fg.GetDataDisplay(e.Row, e.Col);
                var errors = c1SpellChecker1.CheckText(text);

                // underline errors
                if (errors.Count > 0)
                {
                    var ranges = new CharacterRange[errors.Count];
                    for (int i = 0; i < errors.Count; i++)
                    {
                        ranges[i] = new CharacterRange(errors[i].Start, errors[i].Length);
                    }
                    var rc = e.Style.GetTextRectangle(e.Bounds, null);
                    Rectangle[] linesBounds;
                    if (c1FlexGrid1.UseCompatibleTextRendering)
                    {
                        linesBounds = StringRendererGDIPlus.MeasureSubstring(e.Graphics, e.Style.Font, e.Style.StringFormat, rc, e.Text, ranges);
                    }
                    else
                    {
                        linesBounds = StringRendererGDI.MeasureSubstring(e.Graphics, e.Style.Font, StringRendererGDI.GetTextFormatFlags(e.Style.StringFormat), rc, e.Text, ranges);
                    }
                    foreach (var bounds in linesBounds)
                    {
                        for (Point pt = new Point(bounds.X, bounds.Bottom); pt.X + 2 < bounds.Right; pt.X += 4)
                        {
                            e.Graphics.DrawLines(Pens.Red, new Point[]
                            {
                                new Point(pt.X, pt.Y),
                                new Point(pt.X + 2, pt.Y - 2),
                                new Point(pt.X + 4, pt.Y)
                            });
                        }
                    }
                }
            }
        }

        private void c1FlexGrid1_SetupEditor(object sender, RowColEventArgs e)
        {
            var tb = this.c1FlexGrid1.Editor as TextBox;
            if (tb != null)
            {
                this.c1SpellChecker1.SetActiveSpellChecking(tb, true);
            }
        }
    }
}
