namespace ControlExplorer.TreeView
{
    partial class TodoList
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TreeView1
            // 
            this.c1TreeView1.CheckBoxes = true;
            c1TreeColumn1.DisplayFieldName = null;
            c1TreeColumn1.HeaderText = null;
            c1TreeColumn1.Name = null;
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.DataMember = null;
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.KeyField = null;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.ParentKeyField = null;
            this.c1TreeView1.ShowColumnHeaders = false;
            this.c1TreeView1.Size = new System.Drawing.Size(426, 402);
            this.c1TreeView1.TabIndex = 0;
            // 
            // TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.c1TreeView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TodoList";
            this.Text = "ToDoList";
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.TreeView.C1TreeView c1TreeView1;
    }
}