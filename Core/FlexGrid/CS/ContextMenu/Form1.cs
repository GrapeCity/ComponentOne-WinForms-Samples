namespace ContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            flexGridEx1.DataSource = DataSource.GetRows("Select * from Products");

            StartPosition = FormStartPosition.CenterScreen;

            flexGridEx1.Styles.Highlight.BackColor = Color.Gray;
            //styling the selected border color
            flexGridEx1.MarqueeStyle.BorderMode = C1.Win.FlexGrid.MarqueeBorderMode.CellRange;
            flexGridEx1.MarqueeStyle.Color = Color.FromArgb(0, 95, 184);
            flexGridEx1.MarqueeStyle.Width = 3;
        }
    }
}
