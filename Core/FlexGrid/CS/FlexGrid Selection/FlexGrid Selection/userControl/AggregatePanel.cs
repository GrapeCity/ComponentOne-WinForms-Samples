using C1.Framework;
using C1.Win.Input;

namespace FlexGrid_Selection.userControl
{
    public partial class AggregatePanel : UserControl
    {
        public event EventHandler CloseButtonClicked;
        public AggregatePanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        /// <summary>
        /// Updates the control with the given aggregate sections.
        /// Each key is a sub-header (e.g., "Source FlexGrid Aggregates:"), and its value is a list of aggregate strings.
        /// </summary>
        public void UpdateAggregates(Dictionary<string, IEnumerable<string>> aggregateSections)
        {
            this.SuspendLayout();
            this.Controls.Clear();

            // Create and add the header label and close button.
            var headerLabel = CreateHeaderLabel();
            this.Controls.Add(headerLabel);
            this.Controls.Add(CreateCloseButton());

            int yPosition = 60; 

            // For each section, create a sub-header and add aggregate result labels.
            foreach (var section in aggregateSections)
            {
                var subHeader = CreateSubHeaderLabel(section.Key, new Point(10, yPosition));
                this.Controls.Add(subHeader);
                yPosition = subHeader.Bottom + 5;

                foreach (var agg in section.Value)
                {
                    var resultLabel = new Label
                    {
                        Text = agg,
                        AutoSize = true,
                        Font = new Font("Segoe UI", 12F),
                        Location = new Point(10, yPosition)
                    };
                    this.Controls.Add(resultLabel);
                    yPosition += resultLabel.Height + 5;
                }
                yPosition += 10;
            }
            this.ResumeLayout(true);
            this.Update();
        }

        /// <summary>
        /// Clears all controls from the display.
        /// </summary>
        public void ClearDisplay()
        {
            this.SuspendLayout();
            this.Controls.Clear();
            this.ResumeLayout(true);
        }

        /// <summary>
        /// Creates the header label.
        /// </summary>
        private C1Label CreateHeaderLabel()
        {
            return new C1Label
            {
                Text = "Aggregate Detail",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                Location = new Point(60, 8),
                Size = new Size(230, 50)
            };
        }

        /// <summary>
        /// Creates a close button that hides the control when clicked.
        /// </summary>
        private C1Button CreateCloseButton()
        {
            var closeBtn = new C1Button
            {
                Icon = new C1BitmapIcon("CloseIcon", new Size(32, 32), Color.Transparent, Properties.Resources.ChromeClose),
                Location = new Point(this.Width - 60, 8),
                Size = new Size(42, 42),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                ButtonType = C1.Win.Input.ButtonType.Default,
            };

            closeBtn.Styles.Border = new C1.Framework.Thickness(0);
            closeBtn.Styles.Hot.BackColor = SystemColors.Control;
            closeBtn.Click += (s, e) =>
            {
                this.Visible = false;
                CloseButtonClicked?.Invoke(this, EventArgs.Empty);
            };
            return closeBtn;
        }

        /// <summary>
        /// Creates a sub-header label for a section.
        /// </summary>
        private Label CreateSubHeaderLabel(string text, Point location)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = location
            };
        }
    }
}
