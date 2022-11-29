
namespace TileExplorer.Samples
{
    partial class Overview
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
            C1.Win.Tile.PanelElement panelElement1 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.ImageElement imageElement1 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.TextElement textElement1 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.PanelElement panelElement2 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.TextElement textElement2 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.ImageElement imageElement2 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.ImageElement imageElement3 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.Slide slide1 = new C1.Win.Tile.Slide();
            C1.Win.Tile.ImageElement imageElement4 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.Slide slide2 = new C1.Win.Tile.Slide();
            C1.Win.Tile.ImageElement imageElement5 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.Slide slide3 = new C1.Win.Tile.Slide();
            C1.Win.Tile.ImageElement imageElement6 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.Slide slide4 = new C1.Win.Tile.Slide();
            C1.Win.Tile.ImageElement imageElement7 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.Slide slide5 = new C1.Win.Tile.Slide();
            C1.Win.Tile.ImageElement imageElement8 = new C1.Win.Tile.ImageElement();
            this.c1TileControl1 = new C1.Win.Tile.C1TileControl();
            this.group1 = new C1.Win.Tile.Group();
            this.tile1 = new C1.Win.Tile.Tile();
            this.tile2 = new C1.Win.Tile.Tile();
            this.tile3 = new C1.Win.Tile.Tile();
            this.group2 = new C1.Win.Tile.Group();
            this.tile4 = new C1.Win.Tile.Tile();
            this.template2 = new C1.Win.Tile.Template();
            this.tile5 = new C1.Win.Tile.Tile();
            this.group3 = new C1.Win.Tile.Group();
            this.tile6 = new C1.Win.Tile.Tile();
            this.template3 = new C1.Win.Tile.Template();
            this.template1 = new C1.Win.Tile.Template();
            this.SuspendLayout();
            // 
            // c1TileControl1
            // 
            this.c1TileControl1.AllowChecking = true;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.c1TileControl1.DefaultTemplate.Elements.Add(panelElement1);
            this.c1TileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TileControl1.Groups.Add(this.group1);
            this.c1TileControl1.Groups.Add(this.group2);
            this.c1TileControl1.Groups.Add(this.group3);
            this.c1TileControl1.Location = new System.Drawing.Point(0, 0);
            this.c1TileControl1.Name = "c1TileControl1";
            this.c1TileControl1.Size = new System.Drawing.Size(641, 459);
            this.c1TileControl1.TabIndex = 0;
            this.c1TileControl1.Templates.Add(this.template1);
            this.c1TileControl1.Templates.Add(this.template2);
            this.c1TileControl1.Templates.Add(this.template3);
            this.c1TileControl1.Text = "c1TileControl1";
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Text = "Default";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.LightCoral;
            this.tile1.Image = global::TileExplorer.Properties.Resources.folder;
            this.tile1.Name = "tile1";
            this.tile1.Text = "Tile 1";
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.Teal;
            this.tile2.Image = global::TileExplorer.Properties.Resources.delete;
            this.tile2.Name = "tile2";
            this.tile2.Text = "Tile 2";
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.SteelBlue;
            this.tile3.Image = global::TileExplorer.Properties.Resources.file;
            this.tile3.Name = "tile3";
            this.tile3.Text = "Tile 3";
            // 
            // group2
            // 
            this.group2.Name = "group2";
            this.group2.Text = "Layout";
            this.group2.Tiles.Add(this.tile4);
            this.group2.Tiles.Add(this.tile5);
            // 
            // tile4
            // 
            this.tile4.Image = global::TileExplorer.Properties.Resources.drives;
            this.tile4.Name = "tile4";
            this.tile4.Template = this.template2;
            this.tile4.Text = "Tile 4";
            // 
            // template2
            // 
            this.template2.Description = "Template 2";
            panelElement2.Children.Add(textElement2);
            panelElement2.Children.Add(imageElement2);
            panelElement2.Orientation = C1.Win.Tile.LayoutOrientation.Vertical;
            this.template2.Elements.Add(panelElement2);
            this.template2.Name = "template2";
            // 
            // tile5
            // 
            this.tile5.Image = global::TileExplorer.Properties.Resources.folder;
            this.tile5.Name = "tile5";
            this.tile5.Template = this.template2;
            this.tile5.Text = "Tile 5";
            // 
            // group3
            // 
            this.group3.Name = "group3";
            this.group3.Text = "Slides";
            this.group3.Tiles.Add(this.tile6);
            // 
            // tile6
            // 
            this.tile6.Image = global::TileExplorer.Properties.Resources.m01;
            this.tile6.Image1 = global::TileExplorer.Properties.Resources.m02;
            this.tile6.Image2 = global::TileExplorer.Properties.Resources.m03;
            this.tile6.Image3 = global::TileExplorer.Properties.Resources.m04;
            this.tile6.Image4 = global::TileExplorer.Properties.Resources.m05;
            this.tile6.Image5 = global::TileExplorer.Properties.Resources.m06;
            this.tile6.Name = "tile6";
            this.tile6.Template = this.template3;
            // 
            // template3
            // 
            this.template3.Description = "Template 3";
            this.template3.Elements.Add(imageElement3);
            this.template3.Name = "template3";
            imageElement4.ImageSelector = C1.Win.Tile.ImageSelector.Image1;
            slide1.Elements.Add(imageElement4);
            imageElement5.ImageSelector = C1.Win.Tile.ImageSelector.Image2;
            slide2.Elements.Add(imageElement5);
            imageElement6.ImageSelector = C1.Win.Tile.ImageSelector.Image3;
            slide3.Elements.Add(imageElement6);
            imageElement7.ImageSelector = C1.Win.Tile.ImageSelector.Image4;
            slide4.Elements.Add(imageElement7);
            imageElement8.ImageSelector = C1.Win.Tile.ImageSelector.Image5;
            slide5.Elements.Add(imageElement8);
            this.template3.Slides.Add(slide1);
            this.template3.Slides.Add(slide2);
            this.template3.Slides.Add(slide3);
            this.template3.Slides.Add(slide4);
            this.template3.Slides.Add(slide5);
            // 
            // template1
            // 
            this.template1.Description = "Template 1";
            this.template1.Name = "template1";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1TileControl1);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(641, 459);
            this.ResumeLayout(false);

        }


        #endregion

        private C1.Win.Tile.C1TileControl c1TileControl1;
        private C1.Win.Tile.Group group1;
        private C1.Win.Tile.Tile tile1;
        private C1.Win.Tile.Tile tile2;
        private C1.Win.Tile.Tile tile3;
        private C1.Win.Tile.Group group2;
        private C1.Win.Tile.Tile tile4;
        private C1.Win.Tile.Tile tile5;
        private C1.Win.Tile.Group group3;
        private C1.Win.Tile.Tile tile6;
        private C1.Win.Tile.Template template1;
        private C1.Win.Tile.Template template2;
        private C1.Win.Tile.Template template3;
    }
}
