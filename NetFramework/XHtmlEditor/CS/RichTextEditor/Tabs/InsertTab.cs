using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.C1Ribbon;

namespace RichTextEditor
{
    class InsertTab : C1TextEditorRibbonTab
    {
        //---------------------------------------------------------------------------
        #region ** fields

        InsertSymbol _symbolDlg = new InsertSymbol();

        #endregion

        //---------------------------------------------------------------------------
        #region **ctors

        public InsertTab()
        {
            this.ID = this.Text = "Insert";
            Groups.Add(CreateTablesGroup());
            Groups.Add(CreateIllustrationsGroup());
            Groups.Add(CreateLinksGroup());
            Groups.Add(CreateTextGroup());
        }

        #endregion

        //---------------------------------------------------------------------------
        #region ** create tab

        RibbonGroup CreatePagesGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Pages";
            g.Items.Add(CreateButton("CoverPage"));
            g.Items.Add(CreateButton("BlankPage"));
            g.Items.Add(CreateButton("PageBreak"));
            return g;
        }

        RibbonGroup CreateTablesGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Tables";
            g.Items.Add(CreateButton("InsertTable", "Table"));
            g.Items.Add(CreateSplitButton("InsertTableItems",
                CreateButton("InsertRowAbove"),
                CreateButton("InsertRowBelow"),
                CreateButton("InsertColumnBefore"),
                CreateButton("InsertColumnAfter")));
            g.Items.Add(CreateSplitButton("DeleteTableItems",
                CreateButton("DeleteTable"),
                CreateButton("DeleteRows"),
                CreateButton("DeleteColumns")));
            g.Items.Add(CreateSplitButton("TableItemsProperties",
                CreateButton("TableProperties"),
                CreateButton("TableRowProperties"),
                CreateButton("TableColumnProperties"),
                CreateButton("TableCellProperties")));
            return g;
        }

        RibbonGroup CreateIllustrationsGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Illustrations";
            g.Items.Add(CreateButton("Picture"));
            g.Items.Add(CreateButton("FlashMovie"));
            return g;
        }

        RibbonGroup CreateLinksGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Links";
            g.Items.Add(CreateButton("Hyperlink"));
            g.Items.Add(CreateButton("Bookmark"));
            return g;
        }

        RibbonGroup CreateHeaderFooterGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Header && Footer";
            g.Items.Add(CreateButton("Header"));
            g.Items.Add(CreateButton("Footer"));
            g.Items.Add(CreateButton("PageNumber"));
            return g;
        }

        RibbonGroup CreateTextGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Text";
            g.Items.Add(CreateButton("DateAndTime"));
            g.Items.Add(CreateButton("Symbol"));
            return g;
        }

        #endregion

        //---------------------------------------------------------------------------
        #region ** handle commands

        protected override void OnSelect(EventArgs e)
        {
            base.OnSelect(e);
            UpdateUI();
        }

        internal override void UpdateUI()
        {
            GetItemByID("InsertTableItems").Enabled = Editor.InsertTableRowEnabled || Editor.InsertTableColumnEnabled;
            GetItemByID("DeleteTableItems").Enabled = Editor.DeleteTableEnabled;
            GetItemByID("TableItemsProperties").Enabled = Editor.TablePropertiesEnabled;

            GetItemByID("InsertTable").Enabled = Editor.InsertTableEnabled;
            GetItemByID("InsertRowAbove").Enabled = Editor.InsertTableRowEnabled;
            GetItemByID("InsertRowBelow").Enabled = Editor.InsertTableRowEnabled;
            GetItemByID("InsertColumnBefore").Enabled = Editor.InsertTableColumnEnabled;
            GetItemByID("InsertColumnAfter").Enabled = Editor.InsertTableColumnEnabled;
            GetItemByID("DeleteTable").Enabled = Editor.DeleteTableEnabled;
            GetItemByID("DeleteRows").Enabled = Editor.DeleteTableRowsEnabled;
            GetItemByID("DeleteColumns").Enabled = Editor.InsertTableColumnEnabled;            
            GetItemByID("TableProperties").Enabled = Editor.TablePropertiesEnabled;
            GetItemByID("TableRowProperties").Enabled = Editor.TableRowPropertiesEnabled;
            GetItemByID("TableColumnProperties").Enabled = Editor.TableColumnPropertiesEnabled;
            GetItemByID("TableCellProperties").Enabled = Editor.TableCellPropertiesEnabled;

            GetItemByID("Picture").Enabled = Editor.InsertPictureEnabled;
            GetItemByID("FlashMovie").Enabled = Editor.InsertFlashMovieEnabled;

            GetItemByID("Hyperlink").Enabled = Editor.InsertHyperlinkEnabled;
            GetItemByID("Bookmark").Enabled = Editor.InsertBookmarkEnabled;
        }

        internal override void HandleItemEvent(RibbonEventArgs e)
        {
            RibbonItem item = (RibbonItem)e.Item;
            if (e.EventType == RibbonEventType.Click)
            {
                switch (item.ID)
                {
                    case "DateAndTime":
                        using (InsertDateTime dlg = new InsertDateTime())
                        {
                            dlg.ShowDialog(Editor);
                        }
                        break;
                    case "Symbol":
                        _symbolDlg.ShowDialog(Editor);
                        break;
                    case "PageBreak":
                        Editor.InsertPageBreak();
                        break;
                    case "Picture":
                        Editor.InsertPicture();
                        break;
                    case "FlashMovie":
                        Editor.InsertFlashMovie();
                        break;
                    case "Hyperlink":
                        Editor.InsertHyperlink();
                        break;
                    case "Bookmark":
                        Editor.InsertBookmark();
                        break;
                    case "InsertTable":
                        Editor.InsertTable();
                        break;
                    case "InsertRowAbove":
                        Editor.InsertTableRowAbove();
                        break;
                    case "InsertRowBelow":
                        Editor.InsertTableRowBelow();
                        break;
                    case "InsertColumnBefore":
                        Editor.InsertTableColumnBefore();
                        break;
                    case "InsertColumnAfter":
                        Editor.InsertTableColumnAfter();
                        break;
                    case "DeleteTable":
                        Editor.DeleteTable();
                        break;
                    case "DeleteRows":
                        Editor.DeleteTableRows();
                        break;
                    case "DeleteColumns":
                        Editor.DeleteTableColumns();
                        break;
                    case "TableProperties":
                        Editor.TableProperties();
                        break;
                    case "TableRowProperties":
                        Editor.TableRowProperties();
                        break;
                    case "TableColumnProperties":
                        Editor.TableColumnProperties();
                        break;
                    case "TableCellProperties":
                        Editor.TableCellProperties();
                        break;
                }
            }

            base.HandleItemEvent(e);
        }

        #endregion
    }
}
