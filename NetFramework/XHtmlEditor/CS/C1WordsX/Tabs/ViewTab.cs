using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.C1Ribbon;

using EditorMode = C1.Win.C1Editor.EditorMode;

namespace C1WordsX
{
    class ViewTab : C1TextEditorRibbonTab
    {
        #region declarations

        private RibbonToggleButton _modeDesign;
        private RibbonToggleButton _modeSource;
        private RibbonToggleButton _modePreview;
        private RibbonButton _fixErrors;
        private RibbonButton _validateDocument;
        private bool _isFixing;

        #endregion

        #region ctors

        public ViewTab()
        {
            this.ID = this.Text = "View";
            Groups.Add(CreateDocumentViewsGroup());
            Groups.Add(CreateSourceGroup());
            _isFixing = false;
        }

        #endregion

        #region overrides

        internal override void InitTab()
        {
            Ribbon.EditorTextChanged += EditorTextChangedHandler;
            base.InitTab();
        }

        protected override void OnSelect(EventArgs e)
        {
            base.OnSelect(e);
            UpdateEditorModeButtons();
        }

        internal override void HandleItemEvent(RibbonEventArgs e)
        {
            RibbonItem item = (RibbonItem)e.Item;
            if (e.EventType == RibbonEventType.Click)
            {
                if (item == _modeDesign)
                    SetEditorMode(EditorMode.Design);
                else if (item == _modeSource)
                    SetEditorMode(EditorMode.Source);
                else if (item == _modePreview)
                    SetEditorMode(EditorMode.Preview);
                else if (item == _fixErrors)
                {
                    _isFixing = true;
                    try
                    {
                        Editor.FixSource();
                    }
                    finally
                    {
                        _isFixing = false;
                    }
                    _fixErrors.Enabled = false;
                    _validateDocument.Enabled = false;
                }
                else if (item == _validateDocument)
                {
                    bool errorsFixed = (Editor as C1RibbonEditorXhtml).ValidateSource();
                    _fixErrors.Enabled = !errorsFixed;
                    _validateDocument.Enabled = false;
                }
            }
        }

        #endregion

        #region implementation

        private void UpdateEditorModeButtons()
        {
            C1RibbonEditorXhtml ed = Editor as C1RibbonEditorXhtml;

            _modeDesign.Visible = ed != null;
            _modeSource.Visible = ed != null;
            _modePreview.Visible = ed != null;
            if (ed != null)
            {
                _modeDesign.Pressed = ed.Mode == EditorMode.Design;
                _modeSource.Pressed = ed.Mode == EditorMode.Source;
                _modePreview.Pressed = ed.Mode == EditorMode.Preview;
                Groups["Validation"].Visible = ed.Mode == EditorMode.Source;
            }
        }

        private void UpdateRibbonState(EditorMode mode)
        {
            RibbonTab home = Ribbon.Tabs["Home"];
            home.Groups["Clipboard"].Enabled = mode != EditorMode.Preview;
            home.Groups["Font"].Enabled = mode == EditorMode.Design;
            home.Groups["Paragraph"].Enabled = mode == EditorMode.Design;
            home.Groups["Editing"].Enabled = mode != EditorMode.Preview;
            RibbonTab insert = Ribbon.Tabs["Insert"];
            insert.Groups["Tables"].Enabled = mode == EditorMode.Design;
            insert.Groups["Illustrations"].Enabled = mode == EditorMode.Design;
            insert.Groups["Links"].Enabled = mode == EditorMode.Design;
            insert.Groups["Text"].Enabled = mode == EditorMode.Design;
            RibbonTab review = Ribbon.Tabs["Review"];
            review.Groups["Proofing"].Enabled = mode == EditorMode.Design;            
        }

        private RibbonGroup CreateDocumentViewsGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Document Views";

            g.Items.Add(_modeDesign = CreateToggleButton("EditorDesignMode"));
            g.Items.Add(_modeSource = CreateToggleButton("EditorSourceMode"));
            g.Items.Add(_modePreview = CreateToggleButton("EditorPreviewMode"));

            return g;
        }

        private RibbonGroup CreateSourceGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Validation";

            g.Items.Add(_fixErrors = CreateButton("FixErrors"));
            g.Items.Add(_validateDocument = CreateButton("ValidateDocument"));

            return g;
        }

        private void SetEditorMode(EditorMode mode)
        {
            C1RibbonEditorXhtml ed = Editor as C1RibbonEditorXhtml;
            ed.Mode = mode;
            _fixErrors.Enabled = false;
            _validateDocument.Enabled = false;
            UpdateEditorModeButtons();
            if (ed.Mode == mode)
                UpdateRibbonState(mode);
            if (ed.Mode != mode && ed.Mode == EditorMode.Source)
            {
                _fixErrors.Enabled = true;
                _validateDocument.Enabled = false;
            }
        }

        private void EditorTextChangedHandler(object sender, EventArgs e)
        {
            C1RibbonEditorXhtml ed = Editor as C1RibbonEditorXhtml;
            if (ed != null && ed.Mode == EditorMode.Source && !_isFixing)
            {
                _validateDocument.Enabled = true;
            }
        }

        #endregion
    }
}
