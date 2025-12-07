using C1.Win.FlexGrid;
using System.Drawing;

namespace MaterialDesign.Controls
{
    public class DemoFlexGrid : C1FlexGrid, IDemo, IThemeable
    {
        private bool _initialized;

        public void Init()
        {
            DataSource = SampleHelper.Instance.GetSourceTable("Employees", Properties.Resources.Employees);
            this.FocusRect = FocusRectEnum.None;

            SelectionMode = SelectionModeEnum.Row;


            // init colls
            Cols[0].Visible = false;

            Cols["Dept"].Visible = true;
            Cols["Dept"].ImageAlign = ImageAlignEnum.Scale;
            Cols["Dept"].Width = 96;

            Cols["Employee"].Width = 176;
            Cols["Title"].Width = 246;
            Cols["Phone"].Width = 176;

            _initialized = true;
        }

        void IThemeable.ThemeChanged()
        {
            // Adjust style
            ExtendLastCol = true;

            Styles.Normal.Margins.Top = Styles.Normal.Margins.Bottom = 5;
            Styles.Normal.Margins.Left = 56;

            Styles.Focus.BackColor = Styles.Highlight.BackColor;
            Styles.Focus.ForeColor = Styles.Highlight.ForeColor;
            Styles.Focus.Border.Style = BorderStyleEnum.None;
            BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;

            Rows.DefaultSize = 40;
        }

        protected override void OnOwnerDrawCell(OwnerDrawCellEventArgs e)
        {
            base.OnOwnerDrawCell(e);
            if (_initialized)
            {
                if (e.Row >= Rows.Fixed)
                {
                    if (Cols[e.Col].Name == "Dept")
                    {
                        string title = Rows[e.Row]["Title"] as string;
                        switch (title)
                        {
                            case "( Inside Sales Coordinator )":
                            case "( Sales Manager )":
                                e.Image = Properties.Resources.Manager;
                                break;
                            case "( Vice President, Sales )":
                                e.Image = Properties.Resources.President;
                                break;
                            default:
                                e.Image = Properties.Resources.User;
                                break;
                        }

                        if (e.Image != null)
                            e.Text = null;
                    }
                }
            }
        }

    }
}
