using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.AppUtils.Options;

namespace C1.AppUtils
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        #region Protected
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                if (Site == null || !Site.DesignMode)
                {
                    // we set form position here because if we do it in OnLoad form will "blink"
                    // (but for sizable forms only):
                    bool positionSet = false;
                    if (this.FormBorderStyle == FormBorderStyle.Sizable || this.FormBorderStyle == FormBorderStyle.SizableToolWindow)
                    {
                        if (Options != null)
                        {
                            FormParams fp = Options.GetFormParams(GetFormParamsKey());
                            if (fp != null)
                            {
                                FormResolutionParams frp = fp.GetCurrentResolutionParams();
                                if (frp != null && frp.WindowState == FormWindowState.Normal)
                                {
                                    this.StartPosition = FormStartPosition.Manual;
                                    cp.X = frp.X;
                                    cp.Y = frp.Y;
                                    cp.Width = frp.Width;
                                    cp.Height = frp.Height;
                                    positionSet = true;
                                }
                            }
                        }
                    }
                    // last known position is better than CenterParent, but CenterParent is better that default manual:
                    if (!positionSet && this.Parent != null && this.StartPosition == FormStartPosition.Manual)
                        this.StartPosition = FormStartPosition.CenterParent;
                }

                return cp;
            }
        }
        protected virtual string GetFormParamsKey()
        {
            return this.GetType().Name;
        }

        protected virtual FormParams CreateFormParams()
        {
            return new FormParams();
        }

        protected virtual FormResolutionParams CreateFormResolutionParams()
        {
            return new FormResolutionParams();
        }

        protected virtual void LoadFormParams(FormParams fp)
        {
            FormResolutionParams frp = fp.GetCurrentResolutionParams();
            if (frp != null)
                LoadFormResolutionParams(frp);
        }

        protected virtual void LoadFormResolutionParams(FormResolutionParams frp)
        {
            if (this.StartPosition == FormStartPosition.Manual)
            {
                WindowState = frp.WindowState;
            }
        }

        protected virtual void SaveFormParams(FormParams fp)
        {
            FormResolutionParams frp = fp.GetCurrentResolutionParams();
            if (frp == null)
            {
                frp = CreateFormResolutionParams();
                fp.ResolutionParams.Add(frp); 
            }
            SaveFormResolutionParams(frp);
        }

        protected virtual void SaveFormResolutionParams(FormResolutionParams frp)
        {
            frp.WindowState = this.WindowState;
            frp.X = this.Location.X;
            frp.Y = this.Location.Y;
            frp.Width = this.Width;
            frp.Height = this.Height;
        }

        protected override void OnLoad(EventArgs e)
        {
            if (Site == null || !Site.DesignMode)
            {
                if (Options != null)
                {
                    FormParams fp = Options.GetFormParams(GetFormParamsKey());
                    if (fp != null)
                        LoadFormParams(fp);
                }
            }
            base.OnLoad(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (Site == null || !Site.DesignMode)
            {
                if (!e.Cancel)
                {
                    if (Options != null)
                    {
                        FormParams fp = Options.GetFormParams(GetFormParamsKey());
                        if (fp == null)
                        {
                            fp = CreateFormParams();
                            fp.FormKey = GetFormParamsKey();
                            Options.Forms.Add(fp);
                        }
                        SaveFormParams(fp);
                        Options.Save();
                    }
                }
            }
        }
        #endregion

        #region Protected properties
        protected virtual WindowsApplicationOptions Options
        {
            get { return null; }
        }
        #endregion
    }
}