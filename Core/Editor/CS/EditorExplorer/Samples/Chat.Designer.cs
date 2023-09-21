using C1.Win.Editor;

namespace EditorExplorer.Samples
{
    partial class Chat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            C1.Framework.C1FontIcon c1FontIcon1 = new C1.Framework.C1FontIcon();
            C1.Framework.C1FontIcon c1FontIcon2 = new C1.Framework.C1FontIcon();
            C1.Framework.C1FontIcon c1FontIcon3 = new C1.Framework.C1FontIcon();
            C1.Framework.C1CompositeIcon c1CompositeIcon1 = new C1.Framework.C1CompositeIcon();
            C1.Framework.C1PathIcon c1PathIcon1 = new C1.Framework.C1PathIcon();
            C1.Framework.C1CompositeIcon c1CompositeIcon2 = new C1.Framework.C1CompositeIcon();
            C1.Framework.C1PathIcon c1PathIcon2 = new C1.Framework.C1PathIcon();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            c1EditorInput = new C1Editor();
            button1 = new RoundButton();
            button2 = new RoundButton();
            c1EditorRibbon1 = new C1EditorRibbon();
            ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            newDocumentButton1 = new C1.Win.Editor.Ribbon.NewDocumentButton();
            openDocumentButton1 = new C1.Win.Editor.Ribbon.OpenDocumentButton();
            saveDocumentButton1 = new C1.Win.Editor.Ribbon.SaveDocumentButton();
            homeTab1 = new C1.Win.Editor.Ribbon.HomeTab();
            fontGroup1 = new C1.Win.Editor.Ribbon.FontGroup();
            ribbonToolBar2 = new C1.Win.Ribbon.RibbonToolBar();
            boldFontStyleButton1 = new C1.Win.Editor.Ribbon.BoldFontStyleButton();
            italicFontStyleButton1 = new C1.Win.Editor.Ribbon.ItalicFontStyleButton();
            underlineFontStyleButton1 = new C1.Win.Editor.Ribbon.UnderlineFontStyleButton();
            strikethroughFontStyleButton1 = new C1.Win.Editor.Ribbon.StrikethroughFontStyleButton();
            ribbonSeparator3 = new C1.Win.Ribbon.RibbonSeparator();
            textHighlightButton1 = new C1.Win.Editor.Ribbon.TextHighlightButton();
            fontColorButton1 = new C1.Win.Editor.Ribbon.FontColorButton();
            ribbonSeparator4 = new C1.Win.Ribbon.RibbonSeparator();
            clearFormattingButton1 = new C1.Win.Editor.Ribbon.ClearFormattingButton();
            paragraphGroup1 = new C1.Win.Editor.Ribbon.ParagraphGroup();
            ribbonToolBar3 = new C1.Win.Ribbon.RibbonToolBar();
            unorderedListGallery1 = new C1.Win.Editor.Ribbon.UnorderedListGallery();
            orderedListGallery1 = new C1.Win.Editor.Ribbon.OrderedListGallery();
            insertGroup1 = new C1.Win.Editor.Ribbon.InsertGroup();
            ribbonButton1 = new C1.Win.Ribbon.RibbonButton();
            insertImageButton1 = new C1.Win.Editor.Ribbon.InsertImageButton();
            insertHyperlinkButton1 = new C1.Win.Editor.Ribbon.InsertHyperlinkButton();
            ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            splitter1 = new System.Windows.Forms.Splitter();
            c1EditorView = new C1Editor();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1EditorInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1EditorRibbon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1EditorView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 363);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(998, 125);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(c1EditorInput, 1, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Controls.Add(button2, 2, 2);
            tableLayoutPanel1.Controls.Add(c1EditorRibbon1, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(998, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // c1EditorInput
            // 
            c1EditorInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            c1EditorInput.Dock = System.Windows.Forms.DockStyle.Fill;
            c1EditorInput.Location = new System.Drawing.Point(47, 7);
            c1EditorInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            c1EditorInput.Name = "c1EditorInput";
            tableLayoutPanel1.SetRowSpan(c1EditorInput, 2);
            c1EditorInput.Size = new System.Drawing.Size(904, 114);
            c1EditorInput.TabIndex = 0;
            c1EditorInput.UserDataFolder = Util.UserDataFolder;
            c1EditorInput.C1EditorReady += c1EditorInput_C1EditorReady;
            c1EditorInput.SizeChanged += c1EditorInput_SizeChanged;
            c1EditorInput.KeyDown += c1EditorInput_KeyDown;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button1.Corners = 5;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Image = Properties.Resources.Edit;
            button1.Location = new System.Drawing.Point(3, 84);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(38, 38);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button2.Corners = 5;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Image = Properties.Resources.Send;
            button2.Location = new System.Drawing.Point(957, 84);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(38, 38);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // c1EditorRibbon1
            // 
            c1EditorRibbon1.ApplicationMenuHolder = ribbonApplicationMenu1;
            c1EditorRibbon1.BottomToolBarHolder = ribbonBottomToolBar1;
            c1EditorRibbon1.ConfigToolBarHolder = ribbonConfigToolBar1;
            c1EditorRibbon1.Editor = c1EditorInput;
            c1EditorRibbon1.HideTabHeaderRow = true;
            c1EditorRibbon1.Location = new System.Drawing.Point(47, 3);
            c1EditorRibbon1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            c1EditorRibbon1.Minimized = true;
            c1EditorRibbon1.Name = "c1EditorRibbon1";
            c1EditorRibbon1.QatHolder = ribbonQat1;
            c1EditorRibbon1.QatItemsHolder.Add(newDocumentButton1);
            c1EditorRibbon1.QatItemsHolder.Add(openDocumentButton1);
            c1EditorRibbon1.QatItemsHolder.Add(saveDocumentButton1);
            c1EditorRibbon1.Size = new System.Drawing.Size(904, 0);
            c1EditorRibbon1.Tabs.Add(homeTab1);
            c1EditorRibbon1.TopToolBarHolder = ribbonTopToolBar1;
            c1EditorRibbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified;
            // 
            // ribbonApplicationMenu1
            // 
            ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            ribbonApplicationMenu1.Visible = false;
            // 
            // ribbonBottomToolBar1
            // 
            ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            ribbonBottomToolBar1.Visible = false;
            // 
            // ribbonConfigToolBar1
            // 
            ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            ribbonConfigToolBar1.Visible = false;
            // 
            // ribbonQat1
            // 
            ribbonQat1.HotItemLinks.Add(newDocumentButton1);
            ribbonQat1.HotItemLinks.Add(openDocumentButton1);
            ribbonQat1.HotItemLinks.Add(saveDocumentButton1);
            ribbonQat1.ItemLinks.Add(newDocumentButton1);
            ribbonQat1.ItemLinks.Add(openDocumentButton1);
            ribbonQat1.ItemLinks.Add(saveDocumentButton1);
            ribbonQat1.Name = "ribbonQat1";
            ribbonQat1.Visible = false;
            // 
            // newDocumentButton1
            // 
            newDocumentButton1.IconSet.Add(new C1.Framework.C1BitmapIcon("New", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 265));
            newDocumentButton1.Name = "newDocumentButton1";
            // 
            // openDocumentButton1
            // 
            openDocumentButton1.IconSet.Add(new C1.Framework.C1PathIcon("Folder", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, resources.GetString("openDocumentButton1.IconSet")));
            openDocumentButton1.Name = "openDocumentButton1";
            // 
            // saveDocumentButton1
            // 
            saveDocumentButton1.IconSet.Add(new C1.Framework.C1PathIcon("Save", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, resources.GetString("saveDocumentButton1.IconSet")));
            saveDocumentButton1.Name = "saveDocumentButton1";
            // 
            // homeTab1
            // 
            homeTab1.Groups.Add(fontGroup1);
            homeTab1.Groups.Add(paragraphGroup1);
            homeTab1.Groups.Add(insertGroup1);
            homeTab1.Name = "homeTab1";
            // 
            // fontGroup1
            // 
            fontGroup1.HasLauncherButton = true;
            fontGroup1.IconSet.Add(new C1.Framework.C1BitmapIcon("Styles", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", -1));
            fontGroup1.IconSet.Add(new C1.Framework.C1BitmapIcon("FontColor", new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, "Preset_MediumImages", -1));
            fontGroup1.IconSet.Add(new C1.Framework.C1BitmapIcon("FontColor", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", -1));
            fontGroup1.Items.Add(ribbonToolBar2);
            fontGroup1.Name = "fontGroup1";
            // 
            // ribbonToolBar2
            // 
            ribbonToolBar2.Items.Add(boldFontStyleButton1);
            ribbonToolBar2.Items.Add(italicFontStyleButton1);
            ribbonToolBar2.Items.Add(underlineFontStyleButton1);
            ribbonToolBar2.Items.Add(strikethroughFontStyleButton1);
            ribbonToolBar2.Items.Add(ribbonSeparator3);
            ribbonToolBar2.Items.Add(textHighlightButton1);
            ribbonToolBar2.Items.Add(fontColorButton1);
            ribbonToolBar2.Items.Add(ribbonSeparator4);
            ribbonToolBar2.Items.Add(clearFormattingButton1);
            ribbonToolBar2.Name = "ribbonToolBar2";
            // 
            // boldFontStyleButton1
            // 
            c1FontIcon1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            c1FontIcon1.Padding = new C1.Framework.Thickness(2, 0, 0, 0);
            c1FontIcon1.Size = new System.Drawing.Size(16, 16);
            c1FontIcon1.Text = "B";
            boldFontStyleButton1.IconSet.Add(c1FontIcon1);
            boldFontStyleButton1.Name = "boldFontStyleButton1";
            // 
            // italicFontStyleButton1
            // 
            c1FontIcon2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            c1FontIcon2.Padding = new C1.Framework.Thickness(2, 0, 0, 0);
            c1FontIcon2.Size = new System.Drawing.Size(16, 16);
            c1FontIcon2.Text = "I";
            italicFontStyleButton1.IconSet.Add(c1FontIcon2);
            italicFontStyleButton1.Name = "italicFontStyleButton1";
            // 
            // underlineFontStyleButton1
            // 
            c1FontIcon3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            c1FontIcon3.Padding = new C1.Framework.Thickness(2, 0, 0, 0);
            c1FontIcon3.Size = new System.Drawing.Size(16, 16);
            c1FontIcon3.Text = "U";
            underlineFontStyleButton1.IconSet.Add(c1FontIcon3);
            underlineFontStyleButton1.Name = "underlineFontStyleButton1";
            // 
            // strikethroughFontStyleButton1
            // 
            strikethroughFontStyleButton1.IconSet.Add(new C1.Framework.C1FontIcon(null, new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, "abc", new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point)));
            strikethroughFontStyleButton1.IconSet.Add(new C1.Framework.C1FontIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "abc", new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point)));
            strikethroughFontStyleButton1.Name = "strikethroughFontStyleButton1";
            // 
            // ribbonSeparator3
            // 
            ribbonSeparator3.Name = "ribbonSeparator3";
            // 
            // textHighlightButton1
            // 
            c1PathIcon1.Color = System.Drawing.Color.Yellow;
            c1PathIcon1.Data = "M-2.7755575615628892e-17,18.89795939167988 h24 v5.142857098579968 h-24 z";
            c1PathIcon1.Size = new System.Drawing.Size(16, 16);
            c1PathIcon1.Stroke = System.Drawing.Color.Empty;
            c1PathIcon1.ViewBox = new System.Drawing.Rectangle(0, 0, 24, 24);
            c1CompositeIcon1.Icons.Add(c1PathIcon1);
            c1CompositeIcon1.Icons.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, (System.Drawing.Image)resources.GetObject("c1CompositeIcon1.Icons")));
            c1CompositeIcon1.Size = new System.Drawing.Size(16, 16);
            textHighlightButton1.IconSet.Add(c1CompositeIcon1);
            textHighlightButton1.Name = "textHighlightButton1";
            // 
            // fontColorButton1
            // 
            c1PathIcon2.Color = System.Drawing.Color.Red;
            c1PathIcon2.Data = "M-2.7755575615628892e-17,18.89795939167988 h24 v5.142857098579968 h-24 z";
            c1PathIcon2.Size = new System.Drawing.Size(16, 16);
            c1PathIcon2.Stroke = System.Drawing.Color.Empty;
            c1PathIcon2.ViewBox = new System.Drawing.Rectangle(0, 0, 24, 24);
            c1CompositeIcon2.Icons.Add(c1PathIcon2);
            c1CompositeIcon2.Icons.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, (System.Drawing.Image)resources.GetObject("c1CompositeIcon2.Icons")));
            c1CompositeIcon2.Size = new System.Drawing.Size(16, 16);
            fontColorButton1.IconSet.Add(c1CompositeIcon2);
            fontColorButton1.Name = "fontColorButton1";
            // 
            // ribbonSeparator4
            // 
            ribbonSeparator4.Name = "ribbonSeparator4";
            // 
            // clearFormattingButton1
            // 
            clearFormattingButton1.IconSet.Add(new C1.Framework.C1PathIcon("Erase", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, resources.GetString("clearFormattingButton1.IconSet")));
            clearFormattingButton1.Name = "clearFormattingButton1";
            // 
            // paragraphGroup1
            // 
            paragraphGroup1.IconSet.Add(new C1.Framework.C1PathIcon("Justify", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "M0,9.987 L16,9.987 16,10.987 0,10.987 z M0,6.684 L16,6.684 16,7.684 0,7.684 z M0,3.342 L16,3.342 16,4.342 0,4.342 z M0,0 L16,0 16,1 0,1 z"));
            paragraphGroup1.IconSet.Add(new C1.Framework.C1PathIcon("Justify", new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, "M0,9.987 L16,9.987 16,10.987 0,10.987 z M0,6.684 L16,6.684 16,7.684 0,7.684 z M0,3.342 L16,3.342 16,4.342 0,4.342 z M0,0 L16,0 16,1 0,1 z"));
            paragraphGroup1.IconSet.Add(new C1.Framework.C1PathIcon("Justify", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "M0,9.987 L16,9.987 16,10.987 0,10.987 z M0,6.684 L16,6.684 16,7.684 0,7.684 z M0,3.342 L16,3.342 16,4.342 0,4.342 z M0,0 L16,0 16,1 0,1 z"));
            paragraphGroup1.Items.Add(ribbonToolBar3);
            paragraphGroup1.Name = "paragraphGroup1";
            // 
            // ribbonToolBar3
            // 
            ribbonToolBar3.Items.Add(unorderedListGallery1);
            ribbonToolBar3.Items.Add(orderedListGallery1);
            ribbonToolBar3.Name = "ribbonToolBar3";
            // 
            // unorderedListGallery1
            // 
            unorderedListGallery1.Expanded = false;
            unorderedListGallery1.GripHandleVisible = false;
            unorderedListGallery1.IconSet.Add(new C1.Framework.C1PathIcon("Bullet List", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, resources.GetString("unorderedListGallery1.IconSet")));
            unorderedListGallery1.IconSet.Add(new C1.Framework.C1PathIcon("Bullet List", new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, resources.GetString("unorderedListGallery1.IconSet1")));
            unorderedListGallery1.IconSet.Add(new C1.Framework.C1PathIcon("Bullet List", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, resources.GetString("unorderedListGallery1.IconSet2")));
            unorderedListGallery1.ItemSize = new System.Drawing.Size(40, 40);
            unorderedListGallery1.Name = "unorderedListGallery1";
            unorderedListGallery1.VisibleItems = 5;
            // 
            // orderedListGallery1
            // 
            orderedListGallery1.Expanded = false;
            orderedListGallery1.GripHandleVisible = false;
            orderedListGallery1.IconSet.Add(new C1.Framework.C1PathIcon("Numbered List", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, resources.GetString("orderedListGallery1.IconSet")));
            orderedListGallery1.IconSet.Add(new C1.Framework.C1PathIcon("Numbered List", new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, resources.GetString("orderedListGallery1.IconSet1")));
            orderedListGallery1.IconSet.Add(new C1.Framework.C1PathIcon("Numbered List", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, resources.GetString("orderedListGallery1.IconSet2")));
            orderedListGallery1.ItemSize = new System.Drawing.Size(66, 66);
            orderedListGallery1.Name = "orderedListGallery1";
            orderedListGallery1.VisibleItems = 5;
            // 
            // insertGroup1
            // 
            insertGroup1.IconSet.Add(new C1.Framework.C1BitmapIcon("Table", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", -1));
            insertGroup1.IconSet.Add(new C1.Framework.C1BitmapIcon("Table", new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, "Preset_MediumImages", -1));
            insertGroup1.IconSet.Add(new C1.Framework.C1BitmapIcon("Table", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", -1));
            insertGroup1.Items.Add(ribbonButton1);
            insertGroup1.Items.Add(insertImageButton1);
            insertGroup1.Items.Add(insertHyperlinkButton1);
            insertGroup1.Name = "insertGroup1";
            // 
            // ribbonButton1
            // 
            ribbonButton1.IconSet.Add(new C1.Framework.C1BitmapIcon("", new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, Properties.Resources.Smile));
            ribbonButton1.Name = "ribbonButton1";
            ribbonButton1.Click += ribbonButton1_Click;
            // 
            // insertImageButton1
            // 
            insertImageButton1.IconSet.Add(new C1.Framework.C1BitmapIcon("Image", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", -1));
            insertImageButton1.IconSet.Add(new C1.Framework.C1BitmapIcon("Image", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", -1));
            insertImageButton1.Name = "insertImageButton1";
            // 
            // insertHyperlinkButton1
            // 
            insertHyperlinkButton1.IconSet.Add(new C1.Framework.C1PathIcon("Link", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, resources.GetString("insertHyperlinkButton1.IconSet")));
            insertHyperlinkButton1.IconSet.Add(new C1.Framework.C1PathIcon("Link", new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, resources.GetString("insertHyperlinkButton1.IconSet1")));
            insertHyperlinkButton1.IconSet.Add(new C1.Framework.C1PathIcon("Link", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, resources.GetString("insertHyperlinkButton1.IconSet2")));
            insertHyperlinkButton1.Name = "insertHyperlinkButton1";
            // 
            // ribbonTopToolBar1
            // 
            ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            ribbonTopToolBar1.Visible = false;
            // 
            // splitter1
            // 
            splitter1.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            splitter1.Location = new System.Drawing.Point(0, 353);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(998, 10);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // c1EditorView
            // 
            c1EditorView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            c1EditorView.DesignEdit = false;
            c1EditorView.Dock = System.Windows.Forms.DockStyle.Fill;
            c1EditorView.Location = new System.Drawing.Point(0, 0);
            c1EditorView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            c1EditorView.Name = "c1EditorView";
            c1EditorView.Size = new System.Drawing.Size(998, 353);
            c1EditorView.UserDataFolder = Util.UserDataFolder;
            c1EditorView.TabIndex = 2;
            c1EditorView.C1EditorReady += c1EditorView_C1EditorReady;
            // 
            // Chat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(c1EditorView);
            Controls.Add(splitter1);
            Controls.Add(panel1);
            Name = "Chat";
            Size = new System.Drawing.Size(998, 488);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1EditorInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1EditorRibbon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1EditorView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private C1.Win.Editor.C1Editor c1EditorView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1Editor c1EditorInput;
        private RoundButton button1;
        private RoundButton button2;
        private C1EditorRibbon c1EditorRibbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Editor.Ribbon.NewDocumentButton newDocumentButton1;
        private C1.Win.Editor.Ribbon.OpenDocumentButton openDocumentButton1;
        private C1.Win.Editor.Ribbon.SaveDocumentButton saveDocumentButton1;
        private C1.Win.Editor.Ribbon.HomeTab homeTab1;
        private C1.Win.Editor.Ribbon.FontGroup fontGroup1;
        private C1.Win.Editor.Ribbon.ClearFormattingButton clearFormattingButton1;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar2;
        private C1.Win.Editor.Ribbon.BoldFontStyleButton boldFontStyleButton1;
        private C1.Win.Editor.Ribbon.ItalicFontStyleButton italicFontStyleButton1;
        private C1.Win.Editor.Ribbon.UnderlineFontStyleButton underlineFontStyleButton1;
        private C1.Win.Editor.Ribbon.StrikethroughFontStyleButton strikethroughFontStyleButton1;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator3;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator4;
        private C1.Win.Editor.Ribbon.TextHighlightButton textHighlightButton1;
        private C1.Win.Editor.Ribbon.FontColorButton fontColorButton1;
        private C1.Win.Editor.Ribbon.ParagraphGroup paragraphGroup1;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar3;
        private C1.Win.Editor.Ribbon.UnorderedListGallery unorderedListGallery1;
        private C1.Win.Editor.Ribbon.OrderedListGallery orderedListGallery1;
        private C1.Win.Editor.Ribbon.InsertGroup insertGroup1;
        private C1.Win.Editor.Ribbon.InsertImageButton insertImageButton1;
        private C1.Win.Editor.Ribbon.InsertHyperlinkButton insertHyperlinkButton1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonButton ribbonButton1;
    }
}
