using System.ComponentModel;

namespace FlexGridExplorer.Samples
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // === Settings you can tweak from the Designer if you like ===
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RelativePath { get; set; } = Path.Combine("Resources", "home.rtf");
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AutoLoadOnHandleCreated { get; set; } = true;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowErrors { get; set; } = true;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (AutoLoadOnHandleCreated)
                LoadContent();
        }

        /// <summary>
        /// Loads the RTF from bin\...\Resources\home.rtf (RelativePath).
        /// </summary>
        public void LoadContent()
        {
            try
            {
                var baseDir = AppContext.BaseDirectory;
                var fullPath = Path.Combine(baseDir, RelativePath);

                if (!File.Exists(fullPath))
                    throw new FileNotFoundException("RTF file not found.", fullPath);

                rtb.LoadFile(fullPath, RichTextBoxStreamType.RichText);
            }
            catch (Exception ex)
            {
                if (ShowErrors)
                    MessageBox.Show(ex.Message, "RTF Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Optional helpers if you ever need them:
        public void LoadFromRtfString(string rtf)
        {
            try { rtb.Rtf = rtf; }
            catch (ArgumentException) { rtb.Text = rtf ?? string.Empty; }
        }

    }
}
