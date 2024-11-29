using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.Ribbon;

using HtmlList = C1.Win.C1Editor.List;

namespace RichTextEditor
{
    class HomeTab : ExtendedC1RibbonTab
    {
        //---------------------------------------------------------------------------
        #region ** constants

        const int INDENT = 50; // 50 pixels indent per click on indent buttons

        #endregion

        //---------------------------------------------------------------------------
        #region ** create tab

        public HomeTab()
        {
            this.ID = this.Text = "Home";
            Groups.Add(CreateClipboardGroup());
            Groups.Add(CreateFontGroup());
            Groups.Add(CreateParagraphGroup());
            Groups.Add(CreateEditingGroup());
        }
        
        RibbonGroup CreateClipboardGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Clipboard";

            // big paste
            g.Items.Add(CreateSplitButton("Paste",
                CreateButton("PasteText", "Paste"),
                CreateButton("PasteSpecial", "Paste")));
            g.Items.Add(CreateButton("Cut"));
            g.Items.Add(CreateButton("Copy"));

            return g;
        }
        
        RibbonGroup CreateFontGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Font";
            g.HasLauncherButton = true;

            RibbonToolBar tb = new RibbonToolBar();
            g.Items.Add(tb);
            RibbonComboBox cmb = new RibbonComboBox();
            SetItemProperties(cmb, "FontFace");
            cmb.TextAreaWidth = 120;
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                cmb.Items.Add(new RibbonButton(fontFamily.Name));
            }
            tb.Items.Add(cmb);

            cmb = new RibbonComboBox();
            SetItemProperties(cmb, "FontSize");
            cmb.TextAreaWidth = 30;
            foreach (int size in new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 })
            {
                cmb.Items.Add(new RibbonButton(size.ToString()));
            }
            tb.Items.Add(cmb);

            tb.Items.Add(new RibbonSeparator());
            tb.Items.Add(CreateToggleButton("IncreaseFontSize"));
            tb.Items.Add(CreateToggleButton("DecreaseFontSize"));

            tb.Items.Add(new RibbonSeparator());
            tb.Items.Add(CreateButton("ClearFormatting"));

            tb = new RibbonToolBar();
            g.Items.Add(tb);
            tb.Items.Add(CreateToggleButton("Bold"));
            tb.Items.Add(CreateToggleButton("Italic"));
            tb.Items.Add(CreateToggleButton("Underline"));
            tb.Items.Add(CreateToggleButton("Strikethrough"));
            tb.Items.Add(CreateToggleButton("Subscript"));
            tb.Items.Add(CreateToggleButton("Superscript"));
            tb.Items.Add(CreateMenu("ChangeCase",
                CreateButton("LowerCase"),
                CreateButton("UpperCase"),
                CreateButton("CapitalizeCase")));

            tb.Items.Add(new RibbonSeparator());

            RibbonColorPicker cp = new RibbonColorPicker();
            SetItemProperties(cp, "HighlightColor");
            cp.Color = System.Drawing.Color.Yellow;
            tb.Items.Add(cp);

            cp = new RibbonColorPicker();
            SetItemProperties(cp, "FontColor");
            cp.Color = System.Drawing.Color.Red;
            tb.Items.Add(cp);

            return g;
        }
        
        RibbonGroup CreateParagraphGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Paragraph";
            g.HasLauncherButton = true;

            RibbonToolBar tb = new RibbonToolBar();
            g.Items.Add(tb);

            RibbonToggleGroup tg = new RibbonToggleGroup();
            tg.Items.Add(CreateToggleButton("Bullets"));
            tg.Items.Add(CreateToggleButton("Numbering"));
            tb.Items.Add(tg);

            tb.Items.Add(new RibbonSeparator());
            tb.Items.Add(CreateButton("DecreaseIndent"));
            tb.Items.Add(CreateButton("IncreaseIndent"));

            tb.Items.Add(new RibbonSeparator());
            tb.Items.Add(CreateMenu("LineSpacing",
                "1.0", "1.15", "1.5", "2.0", "2.5", "3.0"));

            tb = new RibbonToolBar();
            g.Items.Add(tb);

            tg = new RibbonToggleGroup();
            tg.Items.Add(CreateToggleButton("AlignLeft"));
            tg.Items.Add(CreateToggleButton("Center"));
            tg.Items.Add(CreateToggleButton("AlignRight"));
            tg.Items.Add(CreateToggleButton("Justify"));
            tb.Items.Add(tg);

            tb.Items.Add(new RibbonSeparator());
            RibbonColorPicker cp = new RibbonColorPicker();
            SetItemProperties(cp, "BackgroundColor");
            cp.Color = System.Drawing.Color.Yellow;
            tb.Items.Add(cp);

            return g;
        }
        
        RibbonGroup CreateStylesGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Styles";
            g.HasLauncherButton = true;
            return g;
        }
        
        RibbonGroup CreateEditingGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Editing";
            g.Items.Add(CreateSplitButton("Find",
                CreateButton("FindText", "Find")));
            g.Items.Add(CreateButton("Replace"));
            g.Items.Add(CreateMenu("Select",
                "SelectAll"));

            return g;
        }

        #endregion

        //---------------------------------------------------------------------------
        #region ** update UI

        protected override void OnSelect(EventArgs e)
        {
            base.OnSelect(e);
            UpdateUI();
        }

        internal override void UpdateUI()
        {
            if (Editor == null)
                return;
            // clipboard
            GetItemByID("Cut").Enabled = Editor.CanCut;
            GetItemByID("Copy").Enabled = Editor.CanCopy;
            GetItemByID("Paste").Enabled = Editor.CanPaste;
            GetItemByID("PasteText").Enabled = Editor.CanPasteAsText;

            // font
            RibbonToggleButton bb = (RibbonToggleButton)GetItemByID("Bold");
            RibbonToggleButton bi = (RibbonToggleButton)GetItemByID("Italic");
            RibbonToggleButton bu = (RibbonToggleButton)GetItemByID("Underline");
            RibbonToggleButton bs = (RibbonToggleButton)GetItemByID("Strikethrough");
            RibbonComboBox ff = (RibbonComboBox)GetItemByID("FontFace");
            RibbonComboBox fs = (RibbonComboBox)GetItemByID("FontSize");
            RibbonToggleButton big = (RibbonToggleButton)GetItemByID("IncreaseFontSize");
            RibbonToggleButton small = (RibbonToggleButton)GetItemByID("DecreaseFontSize");
            bb.Pressed = Editor.SelectionFontBold;
            bi.Pressed = Editor.SelectionFontItalic;
            bu.Pressed = Editor.SelectionFontUnderline;
            bs.Pressed = Editor.SelectionFontStrikethrough;
            big.Pressed = Editor.SelectionFontBig;
            small.Pressed = Editor.SelectionFontSmall;
            ff.Text = Editor.SelectionFontName;
            fs.Text = Editor.SelectionFontSize;
            
            ((RibbonToggleButton)GetItemByID("Subscript")).Pressed = Editor.SelectionSubscript;
            ((RibbonToggleButton)GetItemByID("Superscript")).Pressed = Editor.SelectionSuperscript;

            RibbonColorPicker cp = (RibbonColorPicker)GetItemByID("FontColor");
            if (Editor.SelectionColor != System.Drawing.Color.Empty)
                cp.Color = Editor.SelectionColor;
            cp = (RibbonColorPicker)GetItemByID("HighlightColor");
            if (Editor.SelectionBackColor != System.Drawing.Color.Empty)
                cp.Color = Editor.SelectionBackColor;
            cp = (RibbonColorPicker)GetItemByID("BackgroundColor");
            if (Editor.SelectionParagraphColor != System.Drawing.Color.Empty)
                cp.Color = Editor.SelectionParagraphColor;

            // paragraph
            ((RibbonToggleButton)GetItemByID("AlignLeft")).Pressed = false;
            ((RibbonToggleButton)GetItemByID("Center")).Pressed = false;
            ((RibbonToggleButton)GetItemByID("AlignRight")).Pressed = false;
            ((RibbonToggleButton)GetItemByID("Justify")).Pressed = false;
            switch (Editor.SelectionAlignment)
            {
                case TextAlignment.Left:
                    ((RibbonToggleButton)GetItemByID("AlignLeft")).Pressed = true;
                    break;
                case TextAlignment.Center:
                    ((RibbonToggleButton)GetItemByID("Center")).Pressed = true;
                    break;
                case TextAlignment.Right:
                    ((RibbonToggleButton)GetItemByID("AlignRight")).Pressed = true;
                    break;
                case TextAlignment.Justify:
                    ((RibbonToggleButton)GetItemByID("Justify")).Pressed = true;
                    break;
            }

            HtmlList list = Editor.Editor.Selection.List;
            bool isSelectionInsideList = Editor.IsSelectionInsideList();
            GetItemByID("IncreaseIndent").Enabled = !isSelectionInsideList || list.CanExecute(HtmlList.Action.IncreaseLevel);
            GetItemByID("DecreaseIndent").Enabled = !isSelectionInsideList || list.CanExecute(HtmlList.Action.DecreaseLevel);
            (GetItemByID("Bullets") as RibbonToggleButton).Pressed = list.Type == HtmlList.ListType.Bulleted;
            (GetItemByID("Numbering") as RibbonToggleButton).Pressed = list.Type == HtmlList.ListType.Numbered;
        }

        #endregion

        //---------------------------------------------------------------------------
        #region ** handle commands

        internal override void HandleItemEvent(RibbonEventArgs e)
        {
            C1EditorFunctionaliy ed = Editor;
            HtmlList list = null;
            RibbonItem item = (RibbonItem)e.Item;
            if (e.EventType == RibbonEventType.Click)
            {
                switch (item.ID)
                {
                    // find/replace
                    case "Find":
                        ed.Find();
                        break;
                    case "Replace":
                        ed.FindAndReplace();
                        break;

                    // clibpboard
                    case "Cut":
                        ed.Cut();
                        break;
                    case "Copy":
                        ed.Copy();
                        break;
                    case "Paste":
                        ed.Paste(false);
                        break;
                    case "PasteText":
                        ed.Paste(true);
                        break;
                    case "PasteSpecial":
                        ed.Paste(true);
                        break;

                    // font
                    case "Bold":
                        ed.SelectionFontBold = ((RibbonToggleButton)item).Pressed;
                        break;
                    case "Italic":
                        ed.SelectionFontItalic = ((RibbonToggleButton)item).Pressed;
                        break;
                    case "Underline":
                        ed.SelectionFontUnderline = ((RibbonToggleButton)item).Pressed;
                        break;
                    case "Strikethrough":
                        ed.SelectionFontStrikethrough = ((RibbonToggleButton)item).Pressed;
                        break;
                    case "IncreaseFontSize":
                        ed.SelectionFontBig = ((RibbonToggleButton)item).Pressed;
                        break;
                    case "DecreaseFontSize":
                        ed.SelectionFontSmall = ((RibbonToggleButton)item).Pressed;
                        break;
                    case "Subscript":
                        Editor.SelectionSubscript = ((RibbonToggleButton)item).Pressed;
                        UpdateUI();
                        break;
                    case "Superscript":
                        Editor.SelectionSuperscript = ((RibbonToggleButton)item).Pressed;
                        UpdateUI();
                        break;

                    //color
                    case "FontColor":
                        Editor.SelectionColor = ((RibbonColorPicker)item).Color;
                        break;
                    case "HighlightColor":
                        Editor.SelectionBackColor = ((RibbonColorPicker)item).Color;
                        break;
                    case "BackgroundColor":
                        Editor.SelectionParagraphColor = ((RibbonColorPicker)item).Color;
                        break;

                    // paragraph
                    case "AlignLeft":
                        ed.SelectionAlignment = TextAlignment.Left;
                        break;
                    case "Center":
                        ed.SelectionAlignment = TextAlignment.Center;
                        break;
                    case "AlignRight":
                        ed.SelectionAlignment = TextAlignment.Right;
                        break;
                    case "Justify":
                        ed.SelectionAlignment = TextAlignment.Justify;
                        break;
                    case "Bullets":
                        list = ed.Editor.Selection.List;
                        list.Type = ((RibbonToggleButton)item).Pressed ? HtmlList.ListType.Bulleted : HtmlList.ListType.None;
                        break;
                    case "Numbering":
                    case "MultiLevel":
                        list = ed.Editor.Selection.List;
                        list.Type = ((RibbonToggleButton)item).Pressed ? HtmlList.ListType.Numbered : HtmlList.ListType.None;
                        break;
                    case "DecreaseIndent":
                        if (ed.IsSelectionInsideList())
                        {
                            list = ed.Editor.Selection.List;
                            list.Execute(HtmlList.Action.DecreaseLevel);
                        }
                        else
                        {
                            ed.DecreaseIndent();
                        }
                        break;
                    case "IncreaseIndent":
                        if (ed.IsSelectionInsideList())
                        {
                            list = ed.Editor.Selection.List;
                            list.Execute(HtmlList.Action.IncreaseLevel);
                        }
                        else
                        {
                            ed.IncreaseIndent();
                        }
                        break;

                    // clear formatting
                    case "ClearFormatting":
                        ed.ClearFontFormatting();
                        ed.SelectionColor = System.Drawing.Color.Empty;
                        ed.SelectionBackColor = System.Drawing.Color.Empty;
                        ed.SelectionParagraphColor = System.Drawing.Color.Empty;
                        UpdateUI();
                        break;
                    case "SelectAll":
                        ed.Select(0, int.MaxValue);
                        UpdateUI();
                        break;

                    // character casing
                    case "LowerCase":
                        ed.SelectionChangeCase(CharCasing.LowerCase);
                        break;
                    case "UpperCase":
                        ed.SelectionChangeCase(CharCasing.UpperCase);
                        break;
                    case "CapitalizeCase":
                        ed.SelectionChangeCase(CharCasing.CapitalizeWords);
                        break;

                    default:
                        if (item.Parent.Equals(GetItemByID("LineSpacing")))
                        {
                            float spacing;
                            string text = ((RibbonButton)item).Text;
                            text = text.Replace(".", System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);
                            if (float.TryParse(text, out spacing))
                            {
                                ed.SelectionLineSpacing = spacing;
                            }
                        }
                        else if (item.Parent.Equals(GetItemByID("FontColor")))
                        {
                            ed.SelectionColor = ((RibbonColorPicker)item.Parent).Color;
                        }
                        else if (item.Parent.Equals(GetItemByID("HighlightColor")))
                        {
                            ed.SelectionBackColor = ((RibbonColorPicker)item.Parent).Color;
                        }
                        else if (item.Parent.Equals(GetItemByID("BackgroundColor")))
                        {
                            ed.SelectionParagraphColor = ((RibbonColorPicker)item.Parent).Color;
                        }
                        break;
                }
            }
            else if (e.EventType == RibbonEventType.ChangeCommitted)
            {
                switch (item.ID)
                {
                    // font
                    case "FontFace":
                        ed.SelectionFontName = (((RibbonComboBox)item).Text);
                        break;
                    case "FontSize":
                        ed.SelectionFontSize = (((RibbonComboBox)item).Text); 
                        break;
                }
            }
        }

        #endregion
    }
}
