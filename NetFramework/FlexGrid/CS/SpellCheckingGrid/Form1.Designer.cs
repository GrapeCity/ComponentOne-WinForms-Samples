namespace WindowsFormsApplication2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1SpellChecker1 = new C1.Win.SpellChecker.C1SpellChecker(this.components);
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,120,Columns:0{Width:32;}\t";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 24;
            this.c1FlexGrid1.Size = new System.Drawing.Size(519, 257);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            this.c1FlexGrid1.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this.c1FlexGrid1_OwnerDrawCell);
            this.c1FlexGrid1.SetupEditor += new C1.Win.FlexGrid.RowColEventHandler(this.c1FlexGrid1_SetupEditor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 257);
            this.Controls.Add(this.c1FlexGrid1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spell Checking Grid";
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.SpellChecker.C1SpellChecker c1SpellChecker1;
    }
}

