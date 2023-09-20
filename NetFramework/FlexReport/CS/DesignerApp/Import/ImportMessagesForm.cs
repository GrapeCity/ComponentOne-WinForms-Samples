//----------------------------------------------------------------------------
// ImportMessagesForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.Localization;
using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp.Util
{
    internal partial class ImportMessagesForm : Form
    {
        private ImportMessages _messages;

        public ImportMessagesForm()
        {
            InitializeComponent();

        }

        #region Public
        public void ShowMessages(
            ImportMessages messages,
            string caption,
            string descripion)
        {
            _messages = messages;
            Text = caption;
            lblDescription.Text = descripion;
            dgvMessages.Rows.Add(_messages.Count);
            ShowDialog();
        }
        #endregion

        #region Public static
        public static void DoShowMessages(
            ImportMessages messages,
            string caption,
            string descripion)
        {
            using (ImportMessagesForm f = new ImportMessagesForm())
                f.ShowMessages(messages, caption, descripion);
        }
        #endregion

        private void dgvMessages_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    e.Value = ilMain.Images[(int)_messages[e.RowIndex].Type];
                    break;
                case 1:
                    e.Value = _messages[e.RowIndex].Text;
                    break;
            }
        }
    }
}
