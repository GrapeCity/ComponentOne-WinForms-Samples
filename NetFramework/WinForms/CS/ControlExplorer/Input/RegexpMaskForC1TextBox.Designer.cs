﻿
using System;

namespace ControlExplorer.Input
{
    partial class RegexpMaskForC1TextBox
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

        private void c1ComboBox1_SelectedItemChanged(object sender, EventArgs e)
        {
            c1TextBox1.MaskInfo.RegexpEditMask = c1ComboBox1.SelectedItem.ToString();
            c1Label2.Value = c1TextBox1.MaskInfo.RegexpEditMask;
        }

        private void c1ComboBox2_SelectedItemChanged(object sender, EventArgs e)
        {
            c1TextBox2.MaskInfo.RegexpEditMask = c1ComboBox2.SelectedItem.ToString();
            c1Label7.Value = c1TextBox2.MaskInfo.RegexpEditMask;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://developer.mescius.com/componentone/docs/win/online-input/MaskedInputUsingRegularExpressions.html");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Unable to open link https://developer.mescius.com/componentone/docs/win/online-input/MaskedInputUsingRegularExpressions.html.");
            }
        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegexpMaskForC1TextBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1Label14 = new C1.Win.C1Input.C1Label();
            this.c1Label13 = new C1.Win.C1Input.C1Label();
            this.c1Label12 = new C1.Win.C1Input.C1Label();
            this.c1Label11 = new C1.Win.C1Input.C1Label();
            this.c1ComboBox2 = new C1.Win.C1Input.C1ComboBox();
            this.c1Label10 = new C1.Win.C1Input.C1Label();
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            this.c1Button2 = new C1.Win.C1Input.C1Button();
            this.c1Label8 = new C1.Win.C1Input.C1Label();
            this.c1Label7 = new C1.Win.C1Input.C1Label();
            this.c1Label6 = new C1.Win.C1Input.C1Label();
            this.c1Label5 = new C1.Win.C1Input.C1Label();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.c1Label4 = new C1.Win.C1Input.C1Label();
            this.c1Label3 = new C1.Win.C1Input.C1Label();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1TextBox4 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox3 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.c1Label14);
            this.panel1.Controls.Add(this.c1Label13);
            this.panel1.Controls.Add(this.c1Label12);
            this.panel1.Controls.Add(this.c1Label11);
            this.panel1.Controls.Add(this.c1ComboBox2);
            this.panel1.Controls.Add(this.c1Label10);
            this.panel1.Controls.Add(this.c1ComboBox1);
            this.panel1.Controls.Add(this.c1Button2);
            this.panel1.Controls.Add(this.c1Label8);
            this.panel1.Controls.Add(this.c1Label7);
            this.panel1.Controls.Add(this.c1Label6);
            this.panel1.Controls.Add(this.c1Label5);
            this.panel1.Controls.Add(this.c1Button1);
            this.panel1.Controls.Add(this.c1Label4);
            this.panel1.Controls.Add(this.c1Label3);
            this.panel1.Controls.Add(this.c1Label2);
            this.panel1.Controls.Add(this.c1Label1);
            this.panel1.Controls.Add(this.c1TextBox4);
            this.panel1.Controls.Add(this.c1TextBox3);
            this.panel1.Controls.Add(this.c1TextBox2);
            this.panel1.Controls.Add(this.c1TextBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2177, 1174);
            this.panel1.TabIndex = 0;
            // 
            // c1Label14
            // 
            this.c1Label14.AutoSize = true;
            this.c1Label14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1Label14.Location = new System.Drawing.Point(36, 80);
            this.c1Label14.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label14.Name = "c1Label14";
            this.c1Label14.Size = new System.Drawing.Size(507, 220);
            this.c1Label14.TabIndex = 46;
            this.c1Label14.Tag = null;
            this.c1Label14.Text = resources.GetString("c1Label14.Text");
            this.c1Label14.TextDetached = true;
            this.c1Label14.Value = "Specifics of the RegexpMask: ";
            // 
            // c1Label13
            // 
            this.c1Label13.AutoSize = true;
            this.c1Label13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1Label13.Location = new System.Drawing.Point(637, 80);
            this.c1Label13.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label13.Name = "c1Label13";
            this.c1Label13.Size = new System.Drawing.Size(459, 180);
            this.c1Label13.TabIndex = 45;
            this.c1Label13.Tag = null;
            this.c1Label13.Text = resources.GetString("c1Label13.Text");
            this.c1Label13.TextDetached = true;
            this.c1Label13.Value = "Specifics of the C1RegexpEditMask:";
            // 
            // c1Label12
            // 
            this.c1Label12.AutoSize = true;
            this.c1Label12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1Label12.Location = new System.Drawing.Point(36, 23);
            this.c1Label12.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label12.Name = "c1Label12";
            this.c1Label12.Size = new System.Drawing.Size(886, 40);
            this.c1Label12.TabIndex = 44;
            this.c1Label12.Tag = null;
            this.c1Label12.Text = resources.GetString("c1Label12.Text");
            this.c1Label12.TextDetached = true;
            this.c1Label12.Value = "Select one of the sample masks or set new mask with your own pattern. ";
            // 
            // c1Label11
            // 
            this.c1Label11.AutoSize = true;
            this.c1Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label11.Location = new System.Drawing.Point(644, 474);
            this.c1Label11.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label11.Name = "c1Label11";
            this.c1Label11.Size = new System.Drawing.Size(124, 20);
            this.c1Label11.TabIndex = 43;
            this.c1Label11.Tag = null;
            this.c1Label11.Text = "Sample masks:";
            this.c1Label11.TextDetached = true;
            this.c1Label11.Value = "Sample masks:";
            // 
            // c1ComboBox2
            // 
            this.c1ComboBox2.AllowSpinLoop = false;
            this.c1ComboBox2.AutoSize = false;
            this.c1ComboBox2.DropDownWidth = -1;
            this.c1ComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1ComboBox2.GapHeight = 0;
            this.c1ComboBox2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox2.Items.Add("[a-z]*-[0-9]?");
            this.c1ComboBox2.Items.Add("\\K{3,5}");
            this.c1ComboBox2.Items.Add("\\+\\Ｄ-\\(\\Ｄ{3}\\)-\\Ｄ{3}-\\Ｄ{2}-\\Ｄ{2}");
            this.c1ComboBox2.Items.Add("([\\D]-[A-Z]{3})?");
            this.c1ComboBox2.Items.Add("[^a-z\\W]{3,}");
            this.c1ComboBox2.Items.Add("\\D\\A+");
            this.c1ComboBox2.Items.Add("\\Ｊ|\\Ｔ");
            this.c1ComboBox2.Items.Add("[a-z]{5}-[0-9]{3}");
            this.c1ComboBox2.Location = new System.Drawing.Point(842, 461);
            this.c1ComboBox2.Margin = new System.Windows.Forms.Padding(0);
            this.c1ComboBox2.Name = "c1ComboBox2";
            this.c1ComboBox2.Size = new System.Drawing.Size(361, 35);
            this.c1ComboBox2.TabIndex = 33;
            this.c1ComboBox2.Tag = null;
            // 
            // c1Label10
            // 
            this.c1Label10.AutoSize = true;
            this.c1Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label10.Location = new System.Drawing.Point(47, 474);
            this.c1Label10.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label10.Name = "c1Label10";
            this.c1Label10.Size = new System.Drawing.Size(124, 20);
            this.c1Label10.TabIndex = 42;
            this.c1Label10.Tag = null;
            this.c1Label10.Text = "Sample masks:";
            this.c1Label10.TextDetached = true;
            this.c1Label10.Value = "Sample masks:";
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.AutoSize = false;
            this.c1ComboBox1.DropDownWidth = -1;
            this.c1ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.Items.Add("[a-z]*-[0-9]?");
            this.c1ComboBox1.Items.Add("\\K{3,5}");
            this.c1ComboBox1.Items.Add("\\+\\Ｄ-\\(\\Ｄ{3}\\)-\\Ｄ{3}-\\Ｄ{2}-\\Ｄ{2}");
            this.c1ComboBox1.Items.Add("([\\D]-[A-Z]{3})?");
            this.c1ComboBox1.Items.Add("[^a-z\\W]{3,}");
            this.c1ComboBox1.Items.Add("\\D\\A+");
            this.c1ComboBox1.Items.Add("\\Ｊ|\\Ｔ");
            this.c1ComboBox1.Items.Add("^[a-zA-Z0-9]{8,10}$");
            this.c1ComboBox1.Items.Add("\\p{Lu}+");
            this.c1ComboBox1.Items.Add("\\p{IsKatakana}{3,5}");
            this.c1ComboBox1.Items.Add("^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$");
            this.c1ComboBox1.Location = new System.Drawing.Point(235, 464);
            this.c1ComboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(361, 35);
            this.c1ComboBox1.TabIndex = 27;
            this.c1ComboBox1.Tag = null;
            // 
            // c1Button2
            // 
            this.c1Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Button2.Location = new System.Drawing.Point(842, 576);
            this.c1Button2.Margin = new System.Windows.Forms.Padding(0);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(361, 35);
            this.c1Button2.TabIndex = 37;
            this.c1Button2.Text = "Apply new mask";
            this.c1Button2.UseVisualStyleBackColor = true;
            this.c1Button2.UseVisualStyleForeColor = true;
            // 
            // c1Label8
            // 
            this.c1Label8.AutoSize = true;
            this.c1Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label8.Location = new System.Drawing.Point(644, 525);
            this.c1Label8.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label8.Name = "c1Label8";
            this.c1Label8.Size = new System.Drawing.Size(92, 20);
            this.c1Label8.TabIndex = 41;
            this.c1Label8.Tag = null;
            this.c1Label8.Text = "New mask:";
            this.c1Label8.TextDetached = true;
            this.c1Label8.Value = "New mask:";
            // 
            // c1Label7
            // 
            this.c1Label7.AutoSize = true;
            this.c1Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label7.Location = new System.Drawing.Point(1110, 371);
            this.c1Label7.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label7.Name = "c1Label7";
            this.c1Label7.Size = new System.Drawing.Size(77, 20);
            this.c1Label7.TabIndex = 40;
            this.c1Label7.Tag = null;
            this.c1Label7.Value = "[0-9]{3}-[0-9]{3}";
            // 
            // c1Label6
            // 
            this.c1Label6.AutoSize = true;
            this.c1Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label6.Location = new System.Drawing.Point(970, 371);
            this.c1Label6.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label6.Name = "c1Label6";
            this.c1Label6.Size = new System.Drawing.Size(115, 20);
            this.c1Label6.TabIndex = 39;
            this.c1Label6.Tag = null;
            this.c1Label6.Text = "Current mask:";
            this.c1Label6.TextDetached = true;
            this.c1Label6.Value = "Current mask:";
            // 
            // c1Label5
            // 
            this.c1Label5.AutoSize = true;
            this.c1Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label5.Location = new System.Drawing.Point(644, 371);
            this.c1Label5.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label5.Name = "c1Label5";
            this.c1Label5.Size = new System.Drawing.Size(308, 20);
            this.c1Label5.TabIndex = 38;
            this.c1Label5.Tag = null;
            this.c1Label5.Text = "C1TextBox with C1RegexpEditMask";
            this.c1Label5.TextDetached = true;
            this.c1Label5.Value = "C1TextBox with C1RegexpEditMask";
            // 
            // c1Button1
            // 
            this.c1Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Button1.Location = new System.Drawing.Point(235, 576);
            this.c1Button1.Margin = new System.Windows.Forms.Padding(0);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(361, 35);
            this.c1Button1.TabIndex = 29;
            this.c1Button1.Text = "Apply new mask";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.UseVisualStyleForeColor = true;
            // 
            // c1Label4
            // 
            this.c1Label4.AutoSize = true;
            this.c1Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label4.Location = new System.Drawing.Point(47, 525);
            this.c1Label4.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label4.Name = "c1Label4";
            this.c1Label4.Size = new System.Drawing.Size(92, 20);
            this.c1Label4.TabIndex = 36;
            this.c1Label4.Tag = null;
            this.c1Label4.Text = "New mask:";
            this.c1Label4.TextDetached = true;
            this.c1Label4.Value = "New mask:";
            // 
            // c1Label3
            // 
            this.c1Label3.AutoSize = true;
            this.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label3.Location = new System.Drawing.Point(311, 371);
            this.c1Label3.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(115, 20);
            this.c1Label3.TabIndex = 34;
            this.c1Label3.Tag = null;
            this.c1Label3.Text = "Current mask:";
            this.c1Label3.TextDetached = true;
            this.c1Label3.Value = "Current mask:";
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label2.Location = new System.Drawing.Point(447, 371);
            this.c1Label2.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(77, 20);
            this.c1Label2.TabIndex = 32;
            this.c1Label2.Tag = null;
            this.c1Label2.Value = "[0-9]{3}-[0-9]{3}";
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label1.Location = new System.Drawing.Point(42, 371);
            this.c1Label1.Margin = new System.Windows.Forms.Padding(0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(252, 20);
            this.c1Label1.TabIndex = 30;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "C1TextBox with RegexpMask";
            this.c1Label1.TextDetached = true;
            this.c1Label1.Value = "C1TextBox with RegexpMask";
            // 
            // c1TextBox4
            // 
            this.c1TextBox4.AutoSize = false;
            this.c1TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1TextBox4.Location = new System.Drawing.Point(842, 521);
            this.c1TextBox4.Margin = new System.Windows.Forms.Padding(0);
            this.c1TextBox4.Name = "c1TextBox4";
            this.c1TextBox4.Size = new System.Drawing.Size(361, 35);
            this.c1TextBox4.TabIndex = 35;
            this.c1TextBox4.Tag = null;
            // 
            // c1TextBox3
            // 
            this.c1TextBox3.AutoSize = false;
            this.c1TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1TextBox3.Location = new System.Drawing.Point(235, 521);
            this.c1TextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.c1TextBox3.Name = "c1TextBox3";
            this.c1TextBox3.Size = new System.Drawing.Size(361, 35);
            this.c1TextBox3.TabIndex = 28;
            this.c1TextBox3.Tag = null;
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.AutoSize = false;
            this.c1TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1TextBox2.Location = new System.Drawing.Point(644, 413);
            this.c1TextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.Size = new System.Drawing.Size(558, 35);
            this.c1TextBox2.TabIndex = 31;
            this.c1TextBox2.Tag = null;
            this.c1TextBox2.Value = "";
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.AutoSize = false;
            this.c1TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1TextBox1.Location = new System.Drawing.Point(47, 413);
            this.c1TextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(549, 35);
            this.c1TextBox1.TabIndex = 26;
            this.c1TextBox1.Tag = null;
            this.c1TextBox1.Value = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(36, 324);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(473, 20);
            this.linkLabel1.TabIndex = 47;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Custom keywords in regular expressions and their description.";
            // 
            // RegexpMaskForC1TextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(2177, 1174);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.Name = "RegexpMaskForC1TextBox";
            this.Load += new System.EventHandler(this.RegexpMaskForC1TextBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1Label c1Label14;
        private C1.Win.C1Input.C1Label c1Label13;
        private C1.Win.C1Input.C1Label c1Label12;
        private C1.Win.C1Input.C1Label c1Label11;
        private C1.Win.C1Input.C1ComboBox c1ComboBox2;
        private C1.Win.C1Input.C1Label c1Label10;
        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private C1.Win.C1Input.C1Button c1Button2;
        private C1.Win.C1Input.C1Label c1Label8;
        private C1.Win.C1Input.C1Label c1Label7;
        private C1.Win.C1Input.C1Label c1Label6;
        private C1.Win.C1Input.C1Label c1Label5;
        private C1.Win.C1Input.C1Button c1Button1;
        private C1.Win.C1Input.C1Label c1Label4;
        private C1.Win.C1Input.C1Label c1Label3;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1TextBox c1TextBox4;
        private C1.Win.C1Input.C1TextBox c1TextBox3;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
