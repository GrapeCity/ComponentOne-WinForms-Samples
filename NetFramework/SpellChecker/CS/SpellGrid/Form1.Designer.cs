namespace SpellGrid
{
    partial class FlexGridForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlexGridForm));
            this.button1 = new System.Windows.Forms.Button();
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._spell = new C1.Win.C1SpellChecker.C1SpellChecker(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._spell)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Spell-check grid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:23;}\t";
            this._flex.Cursor = System.Windows.Forms.Cursors.Default;
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._flex.Location = new System.Drawing.Point(0, 40);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 20;
            this._flex.Size = new System.Drawing.Size(513, 266);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 2;
            this._flex.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this._flex_StartEdit);
            // 
            // FlexGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._flex);
            this.Name = "FlexGridForm";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spell-checking a C1FlexGrid";
            this.Load += new System.EventHandler(this.FlexGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._spell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
        private C1.Win.C1SpellChecker.C1SpellChecker _spell;

    }
}

