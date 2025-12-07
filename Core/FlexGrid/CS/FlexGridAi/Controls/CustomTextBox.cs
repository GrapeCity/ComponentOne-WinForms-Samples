using System.ComponentModel;

namespace FlexGridAi.Controls
{
    public partial class CustomTextBox : UserControl
    {
        const int HorizontalPadding = 40;
        const int MarginFromEdge = 20;
        const int AskButtonWidth = 101, AskButtonHeight = 35;
        const int SpaceReservedBelowTextBox = AskButtonHeight + MarginFromEdge * 2;

        string _placeholderText = "Ask something about the table...";
        Color _placeholderColor = Color.Gray;
        Color _textColor = Color.Black;

        public event EventHandler AskButtonClicked;

        [Category("Appearance")]
        [Description("Text displayed when the textbox is empty")]
        [DefaultValue("Ask something about the table...")]
        public string PlaceholderText
        {
            get { return _placeholderText; }
            set
            {
                _placeholderText = value;
                if (string.IsNullOrEmpty(textBox.Text))
                    textBox.Text = value;
            }
        }

        [Browsable(true)]
        [Description("The text entered by the user")]
        [DefaultValue("")]
        public string InputText
        {
            get { return IsPlaceholder ? string.Empty : textBox.Text; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    textBox.Text = _placeholderText;
                    textBox.ForeColor = _placeholderColor;
                }
                else
                {
                    textBox.Text = value;
                    textBox.ForeColor = _textColor;
                }
            }
        }

        [DefaultValue(true)]
        public bool AskButtonEnabled
        {
            get => askButton.Enabled;
            set => askButton.Enabled = value;
        }

        private bool IsPlaceholder => textBox.Text == _placeholderText && textBox.ForeColor == _placeholderColor;

        public CustomTextBox()
        {
            InitializeComponent();

            // Set textBox size
            textBox.Size = new Size(Width - HorizontalPadding, Height - SpaceReservedBelowTextBox);

            // Set askButton position
            askButton.Location = new Point(
                Width - AskButtonWidth - MarginFromEdge,
                Height - AskButtonHeight - MarginFromEdge
            );

            ApplyRoundedCorners(this, 10);

            textBox.Text = _placeholderText;
            textBox.ForeColor = _placeholderColor;

            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;
            textBox.KeyDown += TextBox_KeyDown;
            askButton.Click += AskButton_Click;
            Resize += (s, e) => ApplyRoundedCorners(this, 10);

            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (IsPlaceholder)
            {
                textBox.Text = "";
                textBox.ForeColor = _textColor;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = _placeholderText;
                textBox.ForeColor = _placeholderColor;
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AskButton_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ApplyRoundedCorners(Control ctrl, int radius)
        {
            ctrl.Region?.Dispose();
            using var path = ControlRegionHelper.GetRoundedPath(ctrl, radius);
            if (path != null)
                ctrl.Region = new Region(path);
        }

        [Browsable(true)]
        [Description("Ask Button Click Event")]
        private void AskButton_Click(object sender, EventArgs e)
        {
            AskButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
