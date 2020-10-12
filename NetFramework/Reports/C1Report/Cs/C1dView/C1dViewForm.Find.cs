/*
 * This file is part of C1Report's C1dView sample.
 * 
 * This file contains a helper class code implementing the text search functionality,
 * and code used to wire up that class with the preview form.
 * 
 * Copyright GrapeCity, Inc.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Drawing;
using C1.C1Preview;
using C1.Win.C1Preview;
using C1.Win.C1Command;

namespace C1dView
{
    public partial class C1dViewForm
    {
        /// <summary>
        /// Instance of the helper class providing text search functionality.
        /// </summary>
        protected FindHelper FindHelper { get; set; }

        /// <summary>
        /// Initializes text search functionality.
        /// </summary>
        protected void InitFind()
        {
            this.FindHelper = new C1dView.FindHelper(PreviewPane);
            // wire up 'find' command:
            this.cmdFind.Click += new ClickEventHandler(cmdFind_Click);
            this.cmdFind.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy && PreviewPane.Pages.Count > 0;
            this.cmdFind.EnabledChanged += (s, e) => this.rbtnFind.Enabled = this.cmdFind.Enabled;
            // wire up 'find next' command:
            this.cmdFindNext.Click += (s, e) => FindNext(false);
            this.cmdFindNext.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy && PreviewPane.Pages.Count > 0 && !string.IsNullOrEmpty(rtbFindText.Text);
            this.cmdFindNext.EnabledChanged += (s, e) => this.rbtnFindAgain.Enabled = this.cmdFind.Enabled;
            // wire up find text bar's controls:
            this.rbtnFindClose.Click += new EventHandler(rbtnFindClose_Click);
            this.rtbFindText.TextChanged += new EventHandler(rtbFindText_TextChanged);
            this.rtbFindText.KeyPress += new KeyPressEventHandler(rtbFindText_KeyPress);
            this.rbtnFindMatchCase.PressedChanged += new EventHandler(rtbFindText_TextChanged);
            this.rbtnFindNext.Click += (s, e) => FindNext(false);
            this.rbtnFindPrev.Click += (s, e) => FindNext(true);
            // ensure consistent initial state:
            FindSetButtonsState(false, false);
        }

        /// <summary>
        /// Finds the next occurrence of the search text in the specified direction.
        /// </summary>
        /// <param name="up">Direction: true to search up, false to search down.</param>
        private void FindNext(bool up)
        {
            FindAdjustDisplay(FindHelper.FindNext(this.rtbFindText.Text, this.rbtnFindMatchCase.Pressed, up));
        }

        /// <summary>
        /// Adjusts the visual cues and state of the controls associated with the find text functionality
        /// depending on whether a search was successful or not.
        /// </summary>
        /// <param name="success">True for successful search, false otherwise.</param>
        private void FindAdjustDisplay(bool success)
        {
            if (success)
            {
                this.rtbFindText.ForeColorTextBox = SystemColors.ControlText;
            }
            else
            {
                this.rtbFindText.ForeColorTextBox = Color.Red;
                PreviewPane.SelectionClear();
            }
            FindSetButtonsState(true, success);
        }

        /// <summary>
        /// Sets the visibility and enable state of the find text bar's controls.
        /// </summary>
        /// <param name="show">True to show find text bar, false to hide it.</param>
        /// <param name="enable">True to enable find text controls, false to disable them.</param>
        private void FindSetButtonsState(bool show, bool enable)
        {
            this.rbtnFindClose.Visible =
                rtbFindText.Visible =
                rbtnFindMatchCase.Visible =
                rbtnFindNext.Visible =
                rbtnFindPrev.Visible = show;
            //
            rbtnFindNext.Enabled = enable && FindHelper.HasNext;
            rbtnFindPrev.Enabled = enable && FindHelper.HasPrev;
            //
            this.rlblStatusText.Visible = !show;
        }

        /// <summary>
        /// Handles key presses for the find text textbox:
        /// Performs search on Enter, hides the find text bar on Escape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbFindText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                FindNext(false);
            else if (e.KeyChar == 27)
                FindSetButtonsState(false, true);
        }

        /// <summary>
        /// Handles the TextChanged event for the find text textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbFindText_TextChanged(object sender, EventArgs e)
        {
            FindAdjustDisplay(FindHelper.Find(this.rtbFindText.Text, this.rbtnFindMatchCase.Pressed));
        }

        /// <summary>
        /// Handles the Click event for the find text bar's close button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnFindClose_Click(object sender, EventArgs e)
        {
            FindAdjustDisplay(false);
            FindSetButtonsState(false, true);
        }

        /// <summary>
        /// Handles the Click event for the 'find' command:
        /// shows and activates the find text bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdFind_Click(object sender, ClickEventArgs e)
        {
            FindAdjustDisplay(FindHelper.Find(this.rtbFindText.Text, this.rbtnFindMatchCase.Pressed));
            Application.DoEvents();
            this.rtbFindText.TextBox.Focus();
        }
    }
}
