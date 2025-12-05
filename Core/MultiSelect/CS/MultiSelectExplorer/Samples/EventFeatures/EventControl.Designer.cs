// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace MultiSelectExplorer.Samples.Event
{
    partial class EventControl
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            pnlEventCards = new System.Windows.Forms.Panel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            _multiSelect = new C1.Win.Input.C1MultiSelect();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            pnlSelectionMadeEvent = new System.Windows.Forms.Panel();
            lblSelectionMadeEventCount = new C1.Win.Input.C1Label();
            lblSelectionMadeEventName = new C1.Win.Input.C1Label();
            pnlTextChangedEvent = new System.Windows.Forms.Panel();
            lblTextChangedEventName = new C1.Win.Input.C1Label();
            lblTextChangedEventCount = new C1.Win.Input.C1Label();
            pnlDropDownOpeningEvent = new System.Windows.Forms.Panel();
            lblDropDownOpeningEventCount = new C1.Win.Input.C1Label();
            lblDropDownOpeningEventName = new C1.Win.Input.C1Label();
            pnlDropDownClosedEvent = new System.Windows.Forms.Panel();
            lblDropdownClosedEventName = new C1.Win.Input.C1Label();
            lblDropdownClosedEventCount = new C1.Win.Input.C1Label();
            pnlDropDownOpenedEvent = new System.Windows.Forms.Panel();
            lblDropDownOpenedEventName = new C1.Win.Input.C1Label();
            lblDropDownOpenedEventCount = new C1.Win.Input.C1Label();
            pnlDropDownBtnClickEvent = new System.Windows.Forms.Panel();
            lblDropDownBtnClickEventName = new C1.Win.Input.C1Label();
            lblDropDownBtnClickEventCount = new C1.Win.Input.C1Label();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            pnlEventLogTitle = new System.Windows.Forms.Panel();
            lblEventLogTitle = new C1.Win.Input.C1Label();
            btnClearEventLog = new C1.Win.Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlEventCards.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_multiSelect).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            pnlSelectionMadeEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblSelectionMadeEventCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblSelectionMadeEventName).BeginInit();
            pnlTextChangedEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblTextChangedEventName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTextChangedEventCount).BeginInit();
            pnlDropDownOpeningEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblDropDownOpeningEventCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDropDownOpeningEventName).BeginInit();
            pnlDropDownClosedEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblDropdownClosedEventName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDropdownClosedEventCount).BeginInit();
            pnlDropDownOpenedEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblDropDownOpenedEventName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDropDownOpenedEventCount).BeginInit();
            pnlDropDownBtnClickEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblDropDownBtnClickEventName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDropDownBtnClickEventCount).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            pnlEventLogTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblEventLogTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClearEventLog).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel4);
            splitContainer1.Size = new System.Drawing.Size(1273, 758);
            splitContainer1.SplitterDistance = 871;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            tableLayoutPanel1.Controls.Add(pnlEventCards, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 568F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(867, 754);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlEventCards
            // 
            pnlEventCards.Controls.Add(tableLayoutPanel2);
            pnlEventCards.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlEventCards.Location = new System.Drawing.Point(20, 20);
            pnlEventCards.Margin = new System.Windows.Forms.Padding(10);
            pnlEventCards.Name = "pnlEventCards";
            pnlEventCards.Padding = new System.Windows.Forms.Padding(20);
            pnlEventCards.Size = new System.Drawing.Size(827, 548);
            pnlEventCards.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(_multiSelect, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(20, 20);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(787, 508);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // _multiSelect
            // 
            _multiSelect.AutoSize = false;
            _multiSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            _multiSelect.Location = new System.Drawing.Point(13, 3);
            _multiSelect.Name = "_multiSelect";
            _multiSelect.Size = new System.Drawing.Size(761, 44);
            _multiSelect.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pnlSelectionMadeEvent, 1, 2);
            tableLayoutPanel3.Controls.Add(pnlTextChangedEvent, 0, 2);
            tableLayoutPanel3.Controls.Add(pnlDropDownOpeningEvent, 1, 1);
            tableLayoutPanel3.Controls.Add(pnlDropDownClosedEvent, 0, 1);
            tableLayoutPanel3.Controls.Add(pnlDropDownOpenedEvent, 1, 0);
            tableLayoutPanel3.Controls.Add(pnlDropDownBtnClickEvent, 0, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(13, 53);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            tableLayoutPanel3.Size = new System.Drawing.Size(761, 452);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // pnlSelectionMadeEvent
            // 
            pnlSelectionMadeEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            pnlSelectionMadeEvent.Controls.Add(lblSelectionMadeEventCount);
            pnlSelectionMadeEvent.Controls.Add(lblSelectionMadeEventName);
            pnlSelectionMadeEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSelectionMadeEvent.Location = new System.Drawing.Point(395, 315);
            pnlSelectionMadeEvent.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            pnlSelectionMadeEvent.Name = "pnlSelectionMadeEvent";
            pnlSelectionMadeEvent.Size = new System.Drawing.Size(366, 122);
            pnlSelectionMadeEvent.TabIndex = 5;
            // 
            // lblSelectionMadeEventCount
            // 
            lblSelectionMadeEventCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblSelectionMadeEventCount.AutoSize = true;
            lblSelectionMadeEventCount.Font = new System.Drawing.Font("Segoe UI", 15F);
            lblSelectionMadeEventCount.Location = new System.Drawing.Point(156, 11);
            lblSelectionMadeEventCount.Name = "lblSelectionMadeEventCount";
            lblSelectionMadeEventCount.Size = new System.Drawing.Size(42, 49);
            lblSelectionMadeEventCount.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblSelectionMadeEventCount.TabIndex = 3;
            lblSelectionMadeEventCount.Text = "0";
            // 
            // lblSelectionMadeEventName
            // 
            lblSelectionMadeEventName.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblSelectionMadeEventName.AutoSize = true;
            lblSelectionMadeEventName.Location = new System.Drawing.Point(93, 67);
            lblSelectionMadeEventName.Name = "lblSelectionMadeEventName";
            lblSelectionMadeEventName.Size = new System.Drawing.Size(89, 33);
            lblSelectionMadeEventName.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblSelectionMadeEventName.TabIndex = 4;
            lblSelectionMadeEventName.Text = "c1Label7";
            // 
            // pnlTextChangedEvent
            // 
            pnlTextChangedEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            pnlTextChangedEvent.Controls.Add(lblTextChangedEventName);
            pnlTextChangedEvent.Controls.Add(lblTextChangedEventCount);
            pnlTextChangedEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlTextChangedEvent.Location = new System.Drawing.Point(0, 315);
            pnlTextChangedEvent.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            pnlTextChangedEvent.Name = "pnlTextChangedEvent";
            pnlTextChangedEvent.Size = new System.Drawing.Size(365, 122);
            pnlTextChangedEvent.TabIndex = 4;
            // 
            // lblTextChangedEventName
            // 
            lblTextChangedEventName.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblTextChangedEventName.AutoSize = true;
            lblTextChangedEventName.Location = new System.Drawing.Point(109, 67);
            lblTextChangedEventName.Name = "lblTextChangedEventName";
            lblTextChangedEventName.Size = new System.Drawing.Size(89, 33);
            lblTextChangedEventName.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblTextChangedEventName.TabIndex = 4;
            lblTextChangedEventName.Text = "c1Label6";
            // 
            // lblTextChangedEventCount
            // 
            lblTextChangedEventCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblTextChangedEventCount.AutoSize = true;
            lblTextChangedEventCount.Font = new System.Drawing.Font("Segoe UI", 15F);
            lblTextChangedEventCount.Location = new System.Drawing.Point(155, 11);
            lblTextChangedEventCount.Name = "lblTextChangedEventCount";
            lblTextChangedEventCount.Size = new System.Drawing.Size(42, 49);
            lblTextChangedEventCount.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblTextChangedEventCount.TabIndex = 3;
            lblTextChangedEventCount.Text = "0";
            // 
            // pnlDropDownOpeningEvent
            // 
            pnlDropDownOpeningEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            pnlDropDownOpeningEvent.Controls.Add(lblDropDownOpeningEventCount);
            pnlDropDownOpeningEvent.Controls.Add(lblDropDownOpeningEventName);
            pnlDropDownOpeningEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDropDownOpeningEvent.Location = new System.Drawing.Point(395, 165);
            pnlDropDownOpeningEvent.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            pnlDropDownOpeningEvent.Name = "pnlDropDownOpeningEvent";
            pnlDropDownOpeningEvent.Size = new System.Drawing.Size(366, 120);
            pnlDropDownOpeningEvent.TabIndex = 3;
            // 
            // lblDropDownOpeningEventCount
            // 
            lblDropDownOpeningEventCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblDropDownOpeningEventCount.AutoSize = true;
            lblDropDownOpeningEventCount.Font = new System.Drawing.Font("Segoe UI", 15F);
            lblDropDownOpeningEventCount.Location = new System.Drawing.Point(156, 8);
            lblDropDownOpeningEventCount.Name = "lblDropDownOpeningEventCount";
            lblDropDownOpeningEventCount.Size = new System.Drawing.Size(42, 49);
            lblDropDownOpeningEventCount.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblDropDownOpeningEventCount.TabIndex = 3;
            lblDropDownOpeningEventCount.Text = "0";
            // 
            // lblDropDownOpeningEventName
            // 
            lblDropDownOpeningEventName.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblDropDownOpeningEventName.AutoSize = true;
            lblDropDownOpeningEventName.Location = new System.Drawing.Point(93, 64);
            lblDropDownOpeningEventName.Name = "lblDropDownOpeningEventName";
            lblDropDownOpeningEventName.Size = new System.Drawing.Size(89, 33);
            lblDropDownOpeningEventName.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblDropDownOpeningEventName.TabIndex = 4;
            lblDropDownOpeningEventName.Text = "c1Label5";
            // 
            // pnlDropDownClosedEvent
            // 
            pnlDropDownClosedEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            pnlDropDownClosedEvent.Controls.Add(lblDropdownClosedEventName);
            pnlDropDownClosedEvent.Controls.Add(lblDropdownClosedEventCount);
            pnlDropDownClosedEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDropDownClosedEvent.Location = new System.Drawing.Point(0, 165);
            pnlDropDownClosedEvent.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            pnlDropDownClosedEvent.Name = "pnlDropDownClosedEvent";
            pnlDropDownClosedEvent.Size = new System.Drawing.Size(365, 120);
            pnlDropDownClosedEvent.TabIndex = 2;
            // 
            // lblDropdownClosedEventName
            // 
            lblDropdownClosedEventName.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblDropdownClosedEventName.AutoSize = true;
            lblDropdownClosedEventName.Location = new System.Drawing.Point(86, 64);
            lblDropdownClosedEventName.Name = "lblDropdownClosedEventName";
            lblDropdownClosedEventName.Size = new System.Drawing.Size(89, 33);
            lblDropdownClosedEventName.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblDropdownClosedEventName.TabIndex = 3;
            lblDropdownClosedEventName.Text = "c1Label4";
            // 
            // lblDropdownClosedEventCount
            // 
            lblDropdownClosedEventCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblDropdownClosedEventCount.AutoSize = true;
            lblDropdownClosedEventCount.Font = new System.Drawing.Font("Segoe UI", 15F);
            lblDropdownClosedEventCount.Location = new System.Drawing.Point(155, 8);
            lblDropdownClosedEventCount.Name = "lblDropdownClosedEventCount";
            lblDropdownClosedEventCount.Size = new System.Drawing.Size(42, 49);
            lblDropdownClosedEventCount.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblDropdownClosedEventCount.TabIndex = 2;
            lblDropdownClosedEventCount.Text = "0";
            // 
            // pnlDropDownOpenedEvent
            // 
            pnlDropDownOpenedEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            pnlDropDownOpenedEvent.Controls.Add(lblDropDownOpenedEventName);
            pnlDropDownOpenedEvent.Controls.Add(lblDropDownOpenedEventCount);
            pnlDropDownOpenedEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDropDownOpenedEvent.Location = new System.Drawing.Point(395, 20);
            pnlDropDownOpenedEvent.Margin = new System.Windows.Forms.Padding(15, 20, 0, 15);
            pnlDropDownOpenedEvent.Name = "pnlDropDownOpenedEvent";
            pnlDropDownOpenedEvent.Size = new System.Drawing.Size(366, 115);
            pnlDropDownOpenedEvent.TabIndex = 1;
            // 
            // lblDropDownOpenedEventName
            // 
            lblDropDownOpenedEventName.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblDropDownOpenedEventName.AutoSize = true;
            lblDropDownOpenedEventName.Location = new System.Drawing.Point(93, 66);
            lblDropDownOpenedEventName.Name = "lblDropDownOpenedEventName";
            lblDropDownOpenedEventName.Size = new System.Drawing.Size(89, 33);
            lblDropDownOpenedEventName.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblDropDownOpenedEventName.TabIndex = 2;
            lblDropDownOpenedEventName.Text = "c1Label3";
            // 
            // lblDropDownOpenedEventCount
            // 
            lblDropDownOpenedEventCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblDropDownOpenedEventCount.AutoSize = true;
            lblDropDownOpenedEventCount.Font = new System.Drawing.Font("Segoe UI", 15F);
            lblDropDownOpenedEventCount.Location = new System.Drawing.Point(156, 10);
            lblDropDownOpenedEventCount.Name = "lblDropDownOpenedEventCount";
            lblDropDownOpenedEventCount.Size = new System.Drawing.Size(42, 49);
            lblDropDownOpenedEventCount.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblDropDownOpenedEventCount.TabIndex = 1;
            lblDropDownOpenedEventCount.Text = "0";
            // 
            // pnlDropDownBtnClickEvent
            // 
            pnlDropDownBtnClickEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            pnlDropDownBtnClickEvent.Controls.Add(lblDropDownBtnClickEventName);
            pnlDropDownBtnClickEvent.Controls.Add(lblDropDownBtnClickEventCount);
            pnlDropDownBtnClickEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDropDownBtnClickEvent.Location = new System.Drawing.Point(0, 20);
            pnlDropDownBtnClickEvent.Margin = new System.Windows.Forms.Padding(0, 20, 15, 15);
            pnlDropDownBtnClickEvent.Name = "pnlDropDownBtnClickEvent";
            pnlDropDownBtnClickEvent.Size = new System.Drawing.Size(365, 115);
            pnlDropDownBtnClickEvent.TabIndex = 0;
            // 
            // lblDropDownBtnClickEventName
            // 
            lblDropDownBtnClickEventName.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblDropDownBtnClickEventName.AutoSize = true;
            lblDropDownBtnClickEventName.Location = new System.Drawing.Point(69, 66);
            lblDropDownBtnClickEventName.Name = "lblDropDownBtnClickEventName";
            lblDropDownBtnClickEventName.Size = new System.Drawing.Size(89, 33);
            lblDropDownBtnClickEventName.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblDropDownBtnClickEventName.TabIndex = 1;
            lblDropDownBtnClickEventName.Text = "c1Label2";
            // 
            // lblDropDownBtnClickEventCount
            // 
            lblDropDownBtnClickEventCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblDropDownBtnClickEventCount.AutoSize = true;
            lblDropDownBtnClickEventCount.Font = new System.Drawing.Font("Segoe UI", 15F);
            lblDropDownBtnClickEventCount.Location = new System.Drawing.Point(155, 10);
            lblDropDownBtnClickEventCount.Name = "lblDropDownBtnClickEventCount";
            lblDropDownBtnClickEventCount.Size = new System.Drawing.Size(42, 49);
            lblDropDownBtnClickEventCount.Styles.Default.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblDropDownBtnClickEventCount.TabIndex = 0;
            lblDropDownBtnClickEventCount.Text = "0";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel4.Controls.Add(pnlEventLogTitle, 0, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(394, 754);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 92);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(388, 659);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // pnlEventLogTitle
            // 
            pnlEventLogTitle.Controls.Add(lblEventLogTitle);
            pnlEventLogTitle.Controls.Add(btnClearEventLog);
            pnlEventLogTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlEventLogTitle.Location = new System.Drawing.Point(3, 3);
            pnlEventLogTitle.Name = "pnlEventLogTitle";
            pnlEventLogTitle.Size = new System.Drawing.Size(388, 83);
            pnlEventLogTitle.TabIndex = 1;
            // 
            // lblEventLogTitle
            // 
            lblEventLogTitle.AutoSize = true;
            lblEventLogTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblEventLogTitle.Location = new System.Drawing.Point(0, 23);
            lblEventLogTitle.Name = "lblEventLogTitle";
            lblEventLogTitle.Size = new System.Drawing.Size(97, 36);
            lblEventLogTitle.TabIndex = 1;
            lblEventLogTitle.Text = "c1Label1";
            // 
            // btnClearEventLog
            // 
            btnClearEventLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClearEventLog.Location = new System.Drawing.Point(251, 17);
            btnClearEventLog.Name = "btnClearEventLog";
            btnClearEventLog.Size = new System.Drawing.Size(112, 44);
            btnClearEventLog.Styles.Corners = new C1.Framework.Corners(1, 1, 1, 1);
            btnClearEventLog.Styles.Default.BackColor = System.Drawing.SystemColors.Highlight;
            btnClearEventLog.Styles.Default.BorderColor = System.Drawing.SystemColors.Highlight;
            btnClearEventLog.Styles.Default.ForeColor = System.Drawing.Color.White;
            btnClearEventLog.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(30, 144, 235);
            btnClearEventLog.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(30, 144, 235);
            btnClearEventLog.Styles.HotPressed.BorderColor = System.Drawing.SystemColors.Highlight;
            btnClearEventLog.TabIndex = 0;
            btnClearEventLog.Text = "c1Button1";
            // 
            // EventControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "EventControl";
            Size = new System.Drawing.Size(1273, 758);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlEventCards.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_multiSelect).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            pnlSelectionMadeEvent.ResumeLayout(false);
            pnlSelectionMadeEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblSelectionMadeEventCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblSelectionMadeEventName).EndInit();
            pnlTextChangedEvent.ResumeLayout(false);
            pnlTextChangedEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblTextChangedEventName).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTextChangedEventCount).EndInit();
            pnlDropDownOpeningEvent.ResumeLayout(false);
            pnlDropDownOpeningEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblDropDownOpeningEventCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDropDownOpeningEventName).EndInit();
            pnlDropDownClosedEvent.ResumeLayout(false);
            pnlDropDownClosedEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblDropdownClosedEventName).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDropdownClosedEventCount).EndInit();
            pnlDropDownOpenedEvent.ResumeLayout(false);
            pnlDropDownOpenedEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblDropDownOpenedEventName).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDropDownOpenedEventCount).EndInit();
            pnlDropDownBtnClickEvent.ResumeLayout(false);
            pnlDropDownBtnClickEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblDropDownBtnClickEventName).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDropDownBtnClickEventCount).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            pnlEventLogTitle.ResumeLayout(false);
            pnlEventLogTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblEventLogTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClearEventLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlEventCards;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel pnlDropDownOpeningEvent;
        private System.Windows.Forms.Panel pnlDropDownClosedEvent;
        private System.Windows.Forms.Panel pnlDropDownOpenedEvent;
        private System.Windows.Forms.Panel pnlDropDownBtnClickEvent;
        private C1.Win.Input.C1MultiSelect _multiSelect;
        private C1.Win.Input.C1Label lblSelectionMadeEventName;
        private C1.Win.Input.C1Label lblSelectionMadeEventCount;
        private C1.Win.Input.C1Label lblDropdownClosedEventName;
        private C1.Win.Input.C1Label lblDropdownClosedEventCount;
        private C1.Win.Input.C1Label lblDropDownOpenedEventName;
        private C1.Win.Input.C1Label lblDropDownOpenedEventCount;
        private C1.Win.Input.C1Label lblDropDownBtnClickEventName;
        private C1.Win.Input.C1Label lblDropDownBtnClickEventCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlEventLogTitle;
        private C1.Win.Input.C1Label lblEventLogTitle;
        private C1.Win.Input.C1Button btnClearEventLog;
        private System.Windows.Forms.Panel pnlSelectionMadeEvent;
        private C1.Win.Input.C1Label lblDropDownOpeningEventName;
        private C1.Win.Input.C1Label lblDropDownOpeningEventCount;
        private System.Windows.Forms.Panel pnlTextChangedEvent;
        private C1.Win.Input.C1Label lblTextChangedEventName;
        private C1.Win.Input.C1Label lblTextChangedEventCount;
    }
}
