using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using C1.Win.C1Editor;

namespace C1EditorQuickStart.ToolStrips
{
    abstract class ToolStripBase : System.Windows.Forms.ToolStrip
    {
        // editor connected to this toolstrip
        C1Editor _editor;

        // ctor
        public ToolStripBase()
        {
            OnInitialize();
        }

        // notify of changes to the editor content
        public C1.Win.C1Editor.C1Editor Editor
        {
            get { return _editor; }
            set 
            {
                if (Editor != null)
                {
                    Editor.SelectionChanged -= Editor_SelectionChanged;
                    Editor.DocumentChanged -= Editor_DocumentChanged;
                    Editor.ModeChanged -= Editor_ModeChanged;
                    Editor.KeyDown -= Editor_KeyDown;
                }

                _editor = value;

                if (Editor != null)
                {
                    Editor.SelectionChanged += Editor_SelectionChanged;
                    Editor.DocumentChanged += Editor_DocumentChanged;
                    Editor.ModeChanged += Editor_ModeChanged;
                    Editor.KeyDown += Editor_KeyDown;
                }
            }
        }
        void Editor_DocumentChanged(object sender, EventArgs e)
        {
            OnDocumentChanged(e);
        }
        
        void Editor_SelectionChanged(object sender, EventArgs e)
        {
            OnSelectionChanged(e);
        }

        void Editor_ModeChanged(object sender, EventArgs e)
        {
            OnModeChanged(e);
        }

        void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            OnEditorKeyDownHandler(e);
        }

        protected virtual void OnDocumentChanged(EventArgs e)
        {
        }
        
        protected virtual void OnSelectionChanged(EventArgs e)
        {
        }

        protected virtual void OnModeChanged(EventArgs e)
        {
        }

        protected virtual void OnEditorKeyDownHandler(KeyEventArgs e)
        {
        }

        // initialize toolstrip
        protected virtual void OnInitialize()
        {
        }

        // enable/disable toolbar buttons
        public virtual void UpdateState()
        {
        }

        // helper for populating the toolstrip
        protected ToolStripButton AddButton(string text, Image image, EventHandler handler)
        {
            ToolStripButton btn = new ToolStripButton(text, image);
            btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn.Click += handler;
            Items.Add(btn);
            return btn;
        }
    }
}
