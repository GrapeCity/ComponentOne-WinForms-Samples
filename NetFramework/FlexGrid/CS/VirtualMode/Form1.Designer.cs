namespace VirtualMode
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        System.ComponentModel.IContainer components = null;

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
        
        void InitializeComponent()
        {
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this._flex.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 19;
            this._flex.Size = new System.Drawing.Size(698, 262);
            this._flex.TabIndex = 0;
            this._flex.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            this._flex.GetUnboundValue += new C1.Win.C1FlexGrid.UnboundValueEventHandler(this._flex_GetUnboundValue);
            this._flex.SetUnboundValue += new C1.Win.C1FlexGrid.UnboundValueEventHandler(this._flex_SetUnboundValue);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 262);
            this.Controls.Add(this._flex);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Virtual Mode read/write demo";
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid _flex;



    }
}

