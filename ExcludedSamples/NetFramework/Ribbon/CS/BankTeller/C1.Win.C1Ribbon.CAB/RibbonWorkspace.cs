using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;

namespace C1.Win.C1Ribbon.CAB
{
    /// <summary>
    /// Implements a workspace showing a C1Ribbon control in the SmartPart.
    /// </summary>
    [Designer(typeof(RibbonWorkspace.RibbonWorkspaceDesigner), typeof(IDesigner))]
    [DesignerCategory("Code")]
    [ToolboxBitmap(typeof(RibbonWorkspace), "RibbonWorkspace")]
    public class RibbonWorkspace : Control, IComposableWorkspace<Control, SmartPartInfo>
    {
        #region fields

        WorkspaceComposer<Control, SmartPartInfo> composer;

        Control _smartPart;
        C1RibbonForm _ribbonForm;
        C1Ribbon _ribbon;
        bool _isDisposing;

        #endregion

        #region ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonWorkspace"/> class.
        /// </summary>
        public RibbonWorkspace()
        {
            composer = new WorkspaceComposer<Control, SmartPartInfo>(this);
            base.Dock = DockStyle.Top;
        }

        #endregion

        #region disposing

        protected override void Dispose(bool disposing)
        {
            _isDisposing = disposing;
            base.Dispose(disposing);
        }

        void ControlDisposed(object sender, EventArgs e)
        {
            if (!_isDisposing && _smartPart != null)
            {
                composer.ForceClose(_smartPart);
            }
        }

        #endregion

        #region public properties

        /// <summary>
        /// The user control that the workspace currently contains.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Control SmartPart
        {
            get { return _smartPart; }
        }

        /// <summary>
        /// Dependency injection setter property to get the <see cref="WorkItem"/> where the 
        /// object is contained.
        /// </summary>
        [ServiceDependency]
        public WorkItem WorkItem
        {
            set { composer.WorkItem = value; }
        }

        /// <summary>
        /// This property has no effect on C1Ribbon.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override DockStyle Dock
        {
            get { return base.Dock; }
            set { }
        }

        #endregion

        #region attaching to the parent C1RibbonForm

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                CheckParent();
            }
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            CheckParent();
        }

        void CheckParent()
        {
            C1RibbonForm f0 = _ribbonForm;
            C1RibbonForm f1 = null;
            if (Parent != null)
            {
                f1 = this.FindForm() as C1RibbonForm;
            }
            if (!object.ReferenceEquals(f0, f1))
            {
                if (_ribbon != null)
                {
                    if (f0 != null)
                    {
                        f0.DetachRibbon(_ribbon);
                    }
                    if (f1 != null)
                    {
                        f1.AttachRibbon(_ribbon);
                    }
                }
                _ribbonForm = f1;
            }
        }

        #endregion

        #region updating Workspace height

        void Ribbon_Resize(object sender, EventArgs e)
        {
            UpdateHeight();
        }

        void Ribbon_VisibleChanged(object sender, EventArgs e)
        {
            UpdateHeight();
        }

        void UpdateHeight()
        {
            if (_ribbon != null)
            {
                int h = 0;
                if (_ribbon.Visible)
                {
                    h = _ribbon.Height;
                }
                if (Height != h)
                {
                    Height = h;
                }
            }
        }

        #endregion

        #region updating SmartPart size

        // setting _smartPart.Dock = Fill causes an issue when
        // the form is maximized and the ribbon is minimized
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_smartPart != null)
            {
                _smartPart.SetBounds(0, 0, Width, Height);
            }
        }

        #endregion

        #region Workspace virtual methods

        /// <summary>
        /// Activates the smart part.
        /// </summary>
        protected virtual void OnActivate(Control smartPart)
        {
            if (object.ReferenceEquals(smartPart, _smartPart))
            {
                smartPart.Show();
                UpdateHeight();
            }
        }

        /// <summary>
        /// Closes the smart part.
        /// </summary>
        protected virtual void OnClose(Control smartPart)
        {
            if (object.ReferenceEquals(smartPart, _smartPart))
            {
                if (_ribbonForm != null)
                {
                    _ribbonForm.DetachRibbon(_ribbon);
                }
                _ribbon.Resize -= new EventHandler(Ribbon_Resize);
                _ribbon.VisibleChanged -= new EventHandler(Ribbon_VisibleChanged);
                smartPart.Disposed -= ControlDisposed;
                this.Controls.Remove(_smartPart);

                _ribbon = null;
                _smartPart = null;
                Height = 0;
            }
        }

        /// <summary>
        /// Hides the smart part.
        /// </summary>
        protected virtual void OnHide(Control smartPart)
        {
            if (object.ReferenceEquals(smartPart, _smartPart))
            {
                smartPart.Hide();
                Height = 0;
            }
        }

        /// <summary>
        /// Shows the smart part.
        /// </summary>
        protected virtual void OnShow(Control smartPart, SmartPartInfo smartPartInfo)
        {
            if (!object.ReferenceEquals(smartPart, _smartPart))
            {
                if (_smartPart != null)
                {
                    composer.ForceClose(_smartPart);
                }
                _ribbon = smartPart.Controls[0] as C1Ribbon;
                if (_ribbon == null)
                {
                    throw new ApplicationException("RibbonWorkspace expects a SmartPart with the C1Ribbon control inside of it.");
                }
                _smartPart = smartPart;
                this.Controls.Add(smartPart);

                smartPart.SetBounds(0, 0, Width, Height);
                _ribbon.Resize += new EventHandler(Ribbon_Resize);
                _ribbon.VisibleChanged += new EventHandler(Ribbon_VisibleChanged);
                smartPart.Disposed += ControlDisposed;
                if (_ribbonForm != null)
                {
                    _ribbonForm.AttachRibbon(_ribbon);
                }
            }
            Activate(smartPart);
        }

        /// <summary>
        /// Converts a smart part information to a compatible one for the workspace.
        /// </summary>
        protected virtual SmartPartInfo OnConvertFrom(ISmartPartInfo source)
        {
            return SmartPartInfo.ConvertTo<SmartPartInfo>(source);
        }

        #endregion

        #region IComposableWorkspace<Control, SmartPartInfo> members

        void IComposableWorkspace<Control, SmartPartInfo>.OnActivate(Control smartPart)
        {
            OnActivate(smartPart);
        }

        void IComposableWorkspace<Control, SmartPartInfo>.OnApplySmartPartInfo(Control smartPart, SmartPartInfo smartPartInfo)
        {
            //OnApplySmartPartInfo(smartPart, smartPartInfo);
        }

        void IComposableWorkspace<Control, SmartPartInfo>.OnClose(Control smartPart)
        {
            OnClose(smartPart);
        }

        void IComposableWorkspace<Control, SmartPartInfo>.OnHide(Control smartPart)
        {
            OnHide(smartPart);
        }

        void IComposableWorkspace<Control, SmartPartInfo>.OnShow(Control smartPart, SmartPartInfo smartPartInfo)
        {
            OnShow(smartPart, smartPartInfo);
        }

        void IComposableWorkspace<Control, SmartPartInfo>.RaiseSmartPartActivated(WorkspaceEventArgs e)
        {
            OnSmartPartActivated(e);
        }

        void IComposableWorkspace<Control, SmartPartInfo>.RaiseSmartPartClosing(WorkspaceCancelEventArgs e)
        {
            OnSmartPartClosing(e);
        }

        SmartPartInfo IComposableWorkspace<Control, SmartPartInfo>.ConvertFrom(ISmartPartInfo source)
        {
            return OnConvertFrom(source);
        }

        #endregion

        #region IWorkspace members

        /// <summary>
        /// See <see cref="IWorkspace.SmartPartClosing"/>.
        /// </summary>
        public event EventHandler<WorkspaceCancelEventArgs> SmartPartClosing;
        /// <summary>
        /// Raises the <see cref="SmartPartClosing"/> event.
        /// </summary>
        protected void OnSmartPartClosing(WorkspaceCancelEventArgs e)
        {
            if (SmartPartClosing != null)
            {
                SmartPartClosing(this, e);
            }
        }

        /// <summary>
        /// See <see cref="IWorkspace.SmartPartActivated"/>.
        /// </summary>
        public event EventHandler<WorkspaceEventArgs> SmartPartActivated;
        /// <summary>
        /// Raises the <see cref="SmartPartActivated"/> event.
        /// </summary>
        protected void OnSmartPartActivated(WorkspaceEventArgs e)
        {
            if (SmartPartActivated != null)
            {
                SmartPartActivated(this, e);
            }
        }

        /// <summary>
        /// See <see cref="IWorkspace.SmartParts"/>.
        /// </summary>
        ReadOnlyCollection<object> IWorkspace.SmartParts
        {
            get { return composer.SmartParts; }
        }

        /// <summary>
        /// See <see cref="IWorkspace.ActiveSmartPart"/>.
        /// </summary>
        object IWorkspace.ActiveSmartPart
        {
            get { return composer.ActiveSmartPart; }
        }

        /// <summary>
        /// Shows the smart part in a new tab with the given information.
        /// </summary>
        public void Show(object smartPart, ISmartPartInfo smartPartInfo)
        {
            composer.Show(smartPart, smartPartInfo);
        }

        /// <summary>
        /// Shows the smart part.
        /// </summary>
        public void Show(object smartPart)
        {
            composer.Show(smartPart);
        }

        /// <summary>
        /// Hides the smart part.
        /// </summary>
        public void Hide(object smartPart)
        {
            composer.Hide(smartPart);
        }

        /// <summary>
        /// Closes the smart part.
        /// </summary>
        public void Close(object smartPart)
        {
            composer.Close(smartPart);
        }

        /// <summary>
        /// Activates the smartPart on the workspace.
        /// </summary>
        public void Activate(object smartPart)
        {
            composer.Activate(smartPart);
        }

        /// <summary>
        /// Applies the SmartPartInfo to smartPart.
        /// </summary>
        public void ApplySmartPartInfo(object smartPart, ISmartPartInfo smartPartInfo)
        {
            composer.ApplySmartPartInfo(smartPart, smartPartInfo);
        }

        #endregion

        #region RibbonWorkspaceDesigner

        private class RibbonWorkspaceDesigner : ControlDesigner
        {
            protected override void OnPaintAdornments(PaintEventArgs pe)
            {
                Graphics gr = pe.Graphics;
                Rectangle r = Control.ClientRectangle;
                r.Height -= 1;
                r.Width -= 1;
                using (Pen pen = new Pen(Control.ForeColor))
                {
                    pen.DashStyle = DashStyle.Dash;
                    gr.DrawRectangle(pen, r);
                    pen.DashStyle = DashStyle.Solid;
                    r = new Rectangle(r.X + 10, r.Y + 10, r.Width - 20, r.Height - 20);
                    gr.DrawRectangle(pen, r);
                }
                TextFormatFlags tff = TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
                TextRenderer.DrawText(gr, Control.Name, Control.Font, r, Control.ForeColor, Control.BackColor, tff);
            }

            protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
            {
                base.OnGiveFeedback(new GiveFeedbackEventArgs(DragDropEffects.None, e.UseDefaultCursors));
            }

            protected override void OnDragDrop(DragEventArgs de)
            {
                // Do not allow drops.
            }
        }

        #endregion
    }
}
