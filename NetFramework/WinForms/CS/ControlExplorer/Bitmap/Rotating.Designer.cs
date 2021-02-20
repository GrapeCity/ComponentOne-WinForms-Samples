
namespace ControlExplorer.BitmapDemo
{
    partial class Rotating
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLeftRotate = new C1.Win.C1Input.C1Button();
            this.buttonRightRotate = new C1.Win.C1Input.C1Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRightRotate);
            this.panel1.Controls.Add(this.buttonLeftRotate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 32);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 299);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonLeftRotate
            // 
            this.buttonLeftRotate.Location = new System.Drawing.Point(5, 5);
            this.buttonLeftRotate.Name = "buttonLeftRotate";
            this.buttonLeftRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftRotate.TabIndex = 0;
            this.buttonLeftRotate.Text = "Left";
            this.buttonLeftRotate.UseVisualStyleBackColor = true;
            this.buttonLeftRotate.Click += BtnLeft_Click;
            // 
            // buttonRightRotate
            // 
            this.buttonRightRotate.Location = new System.Drawing.Point(87, 5);
            this.buttonRightRotate.Name = "buttonRightRotate";
            this.buttonRightRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonRightRotate.TabIndex = 1;
            this.buttonRightRotate.Text = "Right";
            this.buttonRightRotate.UseVisualStyleBackColor = true;
            this.buttonRightRotate.Click += BtnRght_Click;
            // 
            // Rotating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Rotating";
            this.Size = new System.Drawing.Size(364, 331);
            this.Load += new System.EventHandler(this.Rotating_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1Button buttonRightRotate;
        private C1.Win.C1Input.C1Button buttonLeftRotate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
