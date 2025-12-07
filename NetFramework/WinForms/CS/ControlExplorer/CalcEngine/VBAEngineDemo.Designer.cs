namespace ControlExplorer.CalcEngine
{
    partial class VBAEngineDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VBAEngineDemo));
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.formula3 = new ControlExplorer.CalcEngine.Formula();
            this.formula2 = new ControlExplorer.CalcEngine.Formula();
            this.formula1 = new ControlExplorer.CalcEngine.Formula();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.BackColor = System.Drawing.Color.White;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 90);
            this.c1FlexGrid1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.Cell;
            this.c1FlexGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.c1FlexGrid1.Size = new System.Drawing.Size(967, 477);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 14;
            this.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.c1FlexGrid1.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.formula3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.formula2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.formula1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 90);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // formula3
            // 
            this.formula3.DefaultExpression = "= Sum([Qnt] * [Price])";
            this.formula3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formula3.EngineType = ControlExplorer.CalcEngine.EngineType.VBA;
            this.formula3.Expression = "= Sum([Qnt] * [Price])";
            this.formula3.Location = new System.Drawing.Point(3, 63);
            this.formula3.Name = "formula3";
            this.formula3.Result = "";
            this.formula3.Size = new System.Drawing.Size(961, 24);
            this.formula3.TabIndex = 33;
            this.formula3.Evaluate += new System.EventHandler(this.formula3_Evaluate);
            // 
            // formula2
            // 
            this.formula2.DefaultExpression = "= [Qnt] * [Price]";
            this.formula2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formula2.EngineType = ControlExplorer.CalcEngine.EngineType.VBA;
            this.formula2.Expression = "= [Qnt] * [Price]";
            this.formula2.Location = new System.Drawing.Point(3, 33);
            this.formula2.Name = "formula2";
            this.formula2.Result = "";
            this.formula2.Size = new System.Drawing.Size(961, 24);
            this.formula2.TabIndex = 32;
            this.formula2.Evaluate += new System.EventHandler(this.formula2_Evaluate);
            // 
            // formula1
            // 
            this.formula1.DefaultExpression = "= [Product]";
            this.formula1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formula1.EngineType = ControlExplorer.CalcEngine.EngineType.VBA;
            this.formula1.Expression = "= [Product]";
            this.formula1.Location = new System.Drawing.Point(3, 3);
            this.formula1.Name = "formula1";
            this.formula1.Result = "";
            this.formula1.Size = new System.Drawing.Size(961, 24);
            this.formula1.TabIndex = 31;
            this.formula1.Evaluate += new System.EventHandler(this.formula1_Evaluate);
            // 
            // VBAEngineDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 567);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VBAEngineDemo";
            this.Text = "VBAEngine Sample";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Formula formula3;
        private Formula formula2;
        private Formula formula1;
    }
}

