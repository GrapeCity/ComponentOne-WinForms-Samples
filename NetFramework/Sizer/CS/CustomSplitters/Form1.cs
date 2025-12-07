using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.Sizer;

namespace CustomSplitters
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.Sizer.C1Sizer c1Sizer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private C1.Win.Sizer.C1Sizer c1Sizer2;
        private System.Windows.Forms.PictureBox pictureBox10;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.c1Sizer1 = new C1.Win.Sizer.C1Sizer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.c1Sizer2 = new C1.Win.Sizer.C1Sizer();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).BeginInit();
            this.c1Sizer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Padding = new Padding(1);
            this.c1Sizer1.Controls.Add(this.pictureBox1);
            this.c1Sizer1.Controls.Add(this.pictureBox2);
            this.c1Sizer1.Controls.Add(this.pictureBox3);
            this.c1Sizer1.Controls.Add(this.pictureBox4);
            this.c1Sizer1.Controls.Add(this.pictureBox8);
            this.c1Sizer1.Controls.Add(this.pictureBox9);
            this.c1Sizer1.GridDefinition = "0:False:True;16.6666666666667:True:False;16.6666666666667:True:False;16.447368421" +
                "0526:True:False;16.6666666666667:True:False;16.6666666666667:True:False;\t99:Fals" +
                "e:False;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(4, 4);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(200, 456);
            this.c1Sizer1.SplitterWidth = 15;
            this.c1Sizer1.TabIndex = 0;
            this.c1Sizer1.TabStop = false;
            this.c1Sizer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Sizer1_MouseMove);
            this.c1Sizer1.Paint += new System.Windows.Forms.PaintEventHandler(this.c1Sizer1_Paint);
            this.c1Sizer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.c1Sizer1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Location = new System.Drawing.Point(1, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox2.Location = new System.Drawing.Point(1, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 76);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox3.Location = new System.Drawing.Point(1, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 76);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LemonChiffon;
            this.pictureBox4.Location = new System.Drawing.Point(1, 198);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(198, 75);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pictureBox8.Location = new System.Drawing.Point(1, 288);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(198, 76);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox9.Location = new System.Drawing.Point(1, 379);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(198, 76);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(360, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(14, 14);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(407, 21);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(380, 21);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // c1Sizer2
            // 
            this.c1Sizer2.AllowDrop = true;
            this.c1Sizer2.Controls.Add(this.pictureBox10);
            this.c1Sizer2.Controls.Add(this.c1Sizer1);
            this.c1Sizer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer2.GridDefinition = "98.2758620689655:False:False;\t29.7619047619048:True:True;68.4523809523809:False:F" +
                "alse;";
            this.c1Sizer2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer2.Location = new System.Drawing.Point(0, 0);
            this.c1Sizer2.Name = "c1Sizer2";
            this.c1Sizer2.Size = new System.Drawing.Size(672, 464);
            this.c1Sizer2.TabIndex = 2;
            this.c1Sizer2.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox10.Location = new System.Drawing.Point(208, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(460, 456);
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(672, 464);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.c1Sizer2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Sizer: Custom Splitters";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).EndInit();
            this.c1Sizer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{                    
			Application.Run(new Form1());
		}

        Bitmap   _imgGrip;
        Bitmap   _imgOpen;
        Bitmap   _imgClose;
        Font     _font;

        // initialize images
        private void Form1_Load(object sender, System.EventArgs e)
        {
            _font     = new Font("Tahoma", 8, FontStyle.Bold);
            _imgGrip  = (Bitmap)pictureBox5.Image;
            _imgOpen  = (Bitmap)pictureBox6.Image; 
            _imgClose = (Bitmap)pictureBox7.Image; 
            _imgOpen.MakeTransparent(Color.Red);
            _imgClose.MakeTransparent(Color.Red);
        }

        // custom painting for splitters
        private void c1Sizer1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            for (int i = 0; i < c1Sizer1.Grid.Rows.Count-1; i++)
            {
                Row r = c1Sizer1.Grid.Rows[i];
                //if (r.IsSplitter)
                {
                    // draw grip area
                    Rectangle rc = c1Sizer1.Grid.Rows[i].Bounds;
                    rc.Y = rc.Bottom;
                    rc.Height = c1Sizer1.Grid.Rows[i+1].Bounds.Y - rc.Y;
                    e.Graphics.DrawImage(_imgGrip, rc);

                    // draw some text in the splitter
                    Rectangle rct = rc;
                    rct.X += rc.Height + 10;
                    rct.Width -= rc.Height + 10;
                    e.Graphics.DrawString("Splitter " + i.ToString(), _font, Brushes.Black, rct);

                    // draw collapse/expand icon
                    Image img = (c1Sizer1.Grid.Rows[i+1].Bounds.Height > 0)? _imgClose: _imgOpen;
                    rc.Width = rc.Height;
                    e.Graphics.DrawImage(img, rc);
                }
            }
        }     
        
        // use default cursor when moving over collapse/expand button
        private void c1Sizer1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.c1Sizer1.Cursor != Cursors.Default)
            {
                Row r = HitTestSplitterRow(e.X, e.Y);
                if (r != null)
                {
                    this.c1Sizer1.Cursor = Cursors.Default;
                }
            }
        }

        // expand/collapse panes when button is clicked
        private void c1Sizer1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Row r = HitTestSplitterRow(e.X, e.Y);
            if (r != null)
            {
                int index = r.Index;
                if (r.Size > 0)
                {
                    index = (index > 1)? index-1: index+1;
                }

                int[] sz = new int[c1Sizer1.Grid.Rows.Count];
                sz[index] = 1000;
                c1Sizer1.Grid.Rows.SetSizes(sz);
                c1Sizer1.Invalidate();
            }
        }

        // get splitter pane that corresponds to a point
        C1.Win.Sizer.Row HitTestSplitterRow(int x, int y)
        {
            for (int i = 0; i < c1Sizer1.Grid.Rows.Count-1; i++)
            {
                Row r = c1Sizer1.Grid.Rows[i];
                //if (r.IsSplitter)
                {
                    // get grip area
                    Rectangle rc = c1Sizer1.Grid.Rows[i].Bounds;
                    rc.Y = rc.Bottom;
                    rc.Height = c1Sizer1.Grid.Rows[i+1].Bounds.Y - rc.Y;

                    // get icon area
                    rc.Width = rc.Height;

                    // check if the point is in the icon area
                    if (rc.Contains(x, y))
                        return c1Sizer1.Grid.Rows[i+1];
                }
            }
            return null;
        }
	}
}
