namespace MailMessageForm
{
    partial class NewMessageForm
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
            this.editor = new System.Windows.Forms.RichTextBox();
            this.tagsLabel = new C1.Win.C1Input.C1Label();
            this.subjectTextBox = new C1.Win.C1Input.C1TextBox();
            this.ccMultiSelect = new C1.Win.Input.C1MultiSelect();
            this.subjectLabel = new C1.Win.C1Input.C1Label();
            this.ccLabel = new C1.Win.C1Input.C1Label();
            this.toLabel = new C1.Win.C1Input.C1Label();
            this.tagEditor = new C1.Win.Input.C1TagEditor();
            this.toMultiSelect = new C1.Win.Input.C1MultiSelect();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sendButton = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.tagsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).BeginInit();
            this.SuspendLayout();
            // 
            // editor
            // 
            this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.Location = new System.Drawing.Point(12, 129);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(960, 520);
            this.editor.TabIndex = 9;
            this.editor.Text = "";
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagsLabel.Location = new System.Drawing.Point(118, 104);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(53, 13);
            this.tagsLabel.TabIndex = 8;
            this.tagsLabel.Tag = null;
            this.tagsLabel.Value = "Tags...";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.AutoSize = false;
            this.subjectTextBox.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.subjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectTextBox.Location = new System.Drawing.Point(175, 71);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(797, 23);
            this.subjectTextBox.TabIndex = 7;
            this.subjectTextBox.Tag = null;
            // 
            // ccMultiSelect
            // 
            this.ccMultiSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccMultiSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ccMultiSelect.Location = new System.Drawing.Point(175, 42);
            this.ccMultiSelect.Name = "ccMultiSelect";
            this.ccMultiSelect.Size = new System.Drawing.Size(797, 23);
            this.ccMultiSelect.TabIndex = 6;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectLabel.Location = new System.Drawing.Point(118, 75);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(67, 13);
            this.subjectLabel.TabIndex = 5;
            this.subjectLabel.Tag = null;
            this.subjectLabel.Value = "Subject";
            // 
            // ccLabel
            // 
            this.ccLabel.AutoSize = true;
            this.ccLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ccLabel.Location = new System.Drawing.Point(118, 47);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(45, 13);
            this.ccLabel.TabIndex = 4;
            this.ccLabel.Tag = null;
            this.ccLabel.Value = "Cc...";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toLabel.Location = new System.Drawing.Point(118, 18);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(42, 13);
            this.toLabel.TabIndex = 3;
            this.toLabel.Tag = null;
            this.toLabel.Value = "To...";
            // 
            // tagEditor
            // 
            this.tagEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagEditor.Location = new System.Drawing.Point(175, 100);
            this.tagEditor.Name = "tagEditor";
            this.tagEditor.Placeholder = "Add...";
            this.tagEditor.Size = new System.Drawing.Size(797, 23);
            this.tagEditor.TabIndex = 2;
            // 
            // toMultiSelect
            // 
            this.toMultiSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toMultiSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toMultiSelect.Location = new System.Drawing.Point(175, 13);
            this.toMultiSelect.Name = "toMultiSelect";
            this.toMultiSelect.Size = new System.Drawing.Size(797, 23);
            this.toMultiSelect.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.White;
            this.sendButton.Image = global::MailMessageForm.Properties.Resources.send;
            this.sendButton.Location = new System.Drawing.Point(12, 15);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(100, 100);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "\r\n\r\n\r\n\r\nSend";
            this.sendButton.UseVisualStyleBackColor = false;
            // 
            // NewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.tagsLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.ccMultiSelect);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.ccLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.tagEditor);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.toMultiSelect);
            this.Name = "NewMessageForm";
            this.Text = "New message";
            ((System.ComponentModel.ISupportInitialize)(this.tagsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1Button sendButton;
        private C1.Win.Input.C1MultiSelect toMultiSelect;
        private C1.Win.Input.C1MultiSelect ccMultiSelect;
        private C1.Win.C1Input.C1TextBox subjectTextBox;
        private C1.Win.Input.C1TagEditor tagEditor;
        private C1.Win.C1Input.C1Label toLabel;
        private C1.Win.C1Input.C1Label ccLabel;
        private C1.Win.C1Input.C1Label subjectLabel;
        private C1.Win.C1Input.C1Label tagsLabel;
        private System.Windows.Forms.RichTextBox editor;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

