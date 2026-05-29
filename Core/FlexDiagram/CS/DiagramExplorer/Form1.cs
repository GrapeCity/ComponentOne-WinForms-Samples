using C1.Chart;
using C1.Diagram;
using C1.Win.Diagram;
using DiagramExplorer.Controls;
using System.Windows.Forms;

namespace DiagramExplorer
{
#pragma warning disable CS8618 
    public partial class Form1 : Form
    {
        private Panel leftPanel;
        private Panel rightPanel;
        private TreeView navigationTree;
        private TableLayoutPanel contentPanel;
        private ToolStripButton themeToggleButton;
        private Label contentLabel;
        private bool isDarkTheme = false;
        private FlowLayoutPanel controlPanel;
        private ToolStrip toolStrip;

        // diagram controls
        private DirectionMenu directionMenu;
        private PaletteMenu paletteMenu;
        private EnumMenu<EdgeRouting> edgeRoutingMenu;
        private ToolStripButton sketchButton;

        // Theme colors
        private readonly Color lightBackground = Color.FromArgb(240, 240, 240);
        private readonly Color lightPanel = Color.White;
        private readonly Color lightText = Color.FromArgb(33, 33, 33);
        private readonly Color lightBorder = Color.FromArgb(200, 200, 200);
        private readonly Color lightAccent = Color.FromArgb(0, 120, 212);

        private readonly Color darkBackground = Color.FromArgb(32, 32, 32);
        private readonly Color darkPanel = Color.FromArgb(45, 45, 45);
        private readonly Color darkText = Color.FromArgb(240, 240, 240);
        private readonly Color darkBorder = Color.FromArgb(60, 60, 60);
        private readonly Color darkAccent = Color.FromArgb(0, 153, 255);

        public Form1()
        {
            InitializeComponent();
            InitializeComponents();
            SetupNavigation();
            ApplyTheme();
        }

        private void InitializeComponents()
        {
            SuspendLayout();

            Text = "FlexDiagram Explorer";
            Size = new Size(1200, 700);
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(800, 500);

            // Left Panel (Navigation)
            leftPanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 250,
                Padding = new Padding(10)
            };

            // Navigation TreeView
            navigationTree = new TreeView
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular),
                ItemHeight = 40,
                ShowLines = false,
                ShowPlusMinus = true,
                ShowRootLines = false,
                FullRowSelect = true,
                HideSelection = false
            };
            navigationTree.AfterSelect += NavigationTree_AfterSelect;

            // Right Panel (Content)
            rightPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            // Content Panel
            contentPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(0),
                RowCount = 3
            };
            contentPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            contentPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            contentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            contentLabel = new Label
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                AutoSize = true,
                TextAlign = System.Drawing.ContentAlignment.TopLeft,
                Padding = new Padding(0, 8, 0, 16),
            };

            controlPanel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill, BorderStyle = BorderStyle.FixedSingle,
                Height = 32,
            };

            toolStrip = new ToolStrip
            {
                Dock = DockStyle.Top,
                GripStyle = ToolStripGripStyle.Hidden,
                RenderMode = ToolStripRenderMode.Professional,
                Font = new Font("Segoe UI Emoji", 12),
                BackColor = lightBackground
            };
            
            directionMenu = new DirectionMenu();
            directionMenu.SelectionChanged += (ob, ar) =>
            {
                var d = Diagram;
                if(d != null)
                    d.Direction = (DiagramDirection)directionMenu.SelectedIndex;
            };

            paletteMenu = new PaletteMenu();
            paletteMenu.SelectionChanged += (ob, ar) =>
            {
                var d = Diagram;
                if (d != null)
                    d.Palette = (Palette)paletteMenu.SelectedIndex;
            };

            edgeRoutingMenu = new EnumMenu<EdgeRouting>("EdgeRouting");
            edgeRoutingMenu.SelectionChanged += (ob, ar) =>
            {
                var d = Diagram;
                if (d != null)
                    d.EdgeRouting = (EdgeRouting)edgeRoutingMenu.SelectedIndex;
            };

            sketchButton = new ToolStripButton("⬜ Sketch") { CheckOnClick = true };
            sketchButton.Click += (o, e) =>
            {
                sketchButton.Text = sketchButton.Checked ? "☑️ Sketch" : " ⬜ Sketch";
                var d = Diagram;
                if (d != null)
                    d.SketchMode = sketchButton.Checked;
            };

            toolStrip.Items.Add(directionMenu);
            toolStrip.Items.Add(paletteMenu);
            toolStrip.Items.Add(edgeRoutingMenu);
            toolStrip.Items.Add(sketchButton);

            themeToggleButton = new ToolStripButton("🌙") { Alignment = ToolStripItemAlignment.Right };
            themeToggleButton.Click += (s, e) => ThemeToggleButton_Click(themeToggleButton, EventArgs.Empty);
            toolStrip.Items.Add(themeToggleButton);

            contentPanel.Controls.Add(contentLabel);
            contentPanel.Controls.Add(toolStrip, 0, 1);

            rightPanel.Controls.Add(contentPanel);

            leftPanel.Controls.Add(navigationTree);

            Controls.Add(rightPanel);
            Controls.Add(leftPanel);

            ResumeLayout(false);
        }

        private void SetupNavigation()
        {
            var samples = SampleInfo.Samples;
            foreach (var sample in samples)
            {
                var node = new TreeNode(sample.Name) { Tag = sample };
                navigationTree.Nodes.Add(node);

                foreach(var child in sample.Childs)
                {
                    var childNode = new TreeNode(child.Name) { Tag = child };
                    node.Nodes.Add(childNode);
                }
            }

            navigationTree.ExpandAll();

            navigationTree.SelectedNode = navigationTree.Nodes[0].FirstNode;
        }

        FlexDiagram? Diagram
        {
            get 
            {
                var cnt = contentPanel.Controls.Count;
                return cnt > 0 ? contentPanel.Controls[cnt - 1] as FlexDiagram : null;
            }
        }

        private void NavigationTree_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag == null)
                return;

            string selectedPage = e.Node.Text;

            contentLabel.Text = $"{selectedPage}\n\n" +
                               $"{((SampleInfo)e.Node.Tag).Info}";

            UpdateSample(e.Node);
        }

        void UpdateSample(TreeNode? node,bool themeChanged = false)
        {
            var d = Diagram;
            if (d != null)
                contentPanel.Controls.Remove(d);

            var sample = node?.Tag as SampleInfo;
            if (sample?.Sample != null)
            {
                var control = sample.Sample(isDarkTheme ? darkText : lightText, isDarkTheme ? darkPanel : lightPanel);
                control.Dock = DockStyle.Fill;
                control.Margin = new Padding(2);

                if (control is FlexDiagram diagram)
                {
                    if (themeChanged)
                    {
                        diagram.Direction = (DiagramDirection)directionMenu.SelectedIndex;
                        diagram.Palette = (Palette)paletteMenu.SelectedIndex;
                        diagram.EdgeRouting = (EdgeRouting)edgeRoutingMenu.SelectedIndex;
                        diagram.SketchMode = sketchButton.Checked;
                    }
                    else
                    {
                        directionMenu.SelectedIndex = (int)diagram.Direction;
                        paletteMenu.SelectedIndex = (int)diagram.Palette;
                        edgeRoutingMenu.SelectedIndex = (int)diagram.EdgeRouting;
                        sketchButton.Checked = diagram.SketchMode;
                    }
                }

                contentPanel.Controls.Add(control, 0, 2);
                UpdateControls(sample.Controls);

                toolStrip.Visible = true;
            }
            else
            {
                toolStrip.Visible = false;
            }
        }

        void UpdateControls(string controls)
        {
            var list = controls.Split(',');
            directionMenu.Visible = list.Contains("Direction");
            paletteMenu.Visible = list.Contains("Palette");
            edgeRoutingMenu.Visible = list.Contains("EdgeRouting");
            sketchButton.Visible = list.Contains("SketchMode");
        }

        private void ThemeToggleButton_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;
            ApplyTheme();

            UpdateSample(navigationTree.SelectedNode, true);
        }

        private void ApplyTheme()
        {
            if (isDarkTheme)
            {
                // Dark Theme
                BackColor = darkBackground;
                leftPanel.BackColor = darkPanel;
                rightPanel.BackColor = darkBackground;
                contentPanel.BackColor = darkPanel;

                navigationTree.BackColor = darkPanel;
                navigationTree.ForeColor = darkText;

                contentLabel.ForeColor = darkText;

                themeToggleButton.Text = "☀️";
                themeToggleButton.ToolTipText = "Light Mode";

                toolStrip.Renderer = new DarkToolStripRenderer();
                toolStrip.BackColor = darkBackground;
            }
            else
            {
                // Light Theme
                BackColor = lightBackground;
                leftPanel.BackColor = lightPanel;
                rightPanel.BackColor = lightBackground;
                contentPanel.BackColor = lightPanel;

                navigationTree.BackColor = lightPanel;
                navigationTree.ForeColor = lightText;

                contentLabel.ForeColor = lightText;

                themeToggleButton.Text = "🌙";
                themeToggleButton.ToolTipText = "Dark Mode";

                toolStrip.Renderer = new ToolStripProfessionalRenderer();
                toolStrip.BackColor = lightBackground;
            }
        }
    }
}
