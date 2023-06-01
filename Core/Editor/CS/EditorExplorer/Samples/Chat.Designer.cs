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
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            c1EditorInput = new C1Editor();
            button1 = new RoundButton();
            button2 = new RoundButton();
            splitter1 = new System.Windows.Forms.Splitter();
            c1EditorView = new C1Editor();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1EditorInput).BeginInit();
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
            tableLayoutPanel1.Controls.Add(c1EditorInput, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 2, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(998, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // c1EditorInput
            // 
            c1EditorInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            c1EditorInput.Dock = System.Windows.Forms.DockStyle.Fill;
            c1EditorInput.Location = new System.Drawing.Point(47, 4);
            c1EditorInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            c1EditorInput.Name = "c1EditorInput";
            tableLayoutPanel1.SetRowSpan(c1EditorInput, 2);
            c1EditorInput.Size = new System.Drawing.Size(904, 117);
            c1EditorInput.TabIndex = 0;
            c1EditorInput.C1EditorReady += c1EditorInput_C1EditorReady;
            c1EditorInput.SizeChanged += c1EditorInput_SizeChanged;
            c1EditorInput.KeyDown += c1EditorInput_KeyDown;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button1.Corners = 18;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Image = Properties.Resources.Smile;
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
    }
}
