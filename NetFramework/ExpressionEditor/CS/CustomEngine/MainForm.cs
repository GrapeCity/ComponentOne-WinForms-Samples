using C1.Win.C1Ribbon;
using C1.Win.C1Themes;
using C1.Win.TreeView;
using ExpressionEditorCustomEngine;
using SamplesData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomEngine
{
    public partial class MainForm : C1RibbonForm
    {
        #region ctor
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            c1Ribbon1.SelectedTabIndex = 1;

            var themes = C1ThemeController.GetThemes();
            foreach (var theme in themes)
                ribbonCmbThemes.Items.Add(theme);
            ribbonCmbThemes.SelectedIndex = Array.IndexOf(themes, "Office365White");

            // init TreeView
            c1TreeView1.Columns.Clear();
            c1TreeView1.DataSource = null;

            c1TreeView1.DataMember = "\\ProductsGroups\\Products";
            var column = new C1TreeColumn
            {
                HeaderText = "Name"
            };
            c1TreeView1.Columns.Add(column);

            column = new C1TreeColumn
            {
                DisplayFieldName = "\\\\Count",
                HeaderText = "Count",
                Width = 100
            };
            c1TreeView1.Columns.Add(column);

            column = new C1TreeColumn
            {
                DisplayFieldName = "\\\\Price",
                HeaderText = "Price",
                Width = 200
            };
            c1TreeView1.Columns.Add(column);

            c1TreeView1.DataSource = StoreCollection.GetData();
            c1TreeView1.ExpandAll();
            // init ExpressionEditor
            c1ExpressionEditor1.IntelliAutoCompletionEnabled = false;
            var ce = new ExpressionEditorCustomEngine.CustomEngine();
            var cl = new CustomLexer();
            c1ExpressionEditor1.SetCustomEngine(ce, cl);
            c1ExpressionEditor1.DataSource = c1TreeView1.DataSource;
            c1ExpressionEditor1.Expression = "[ProductsGroups].Where(x => x.Name == \"Notebooks\").Sum(x => x.Products.Sum(p => p.Count))";

            var p = new CustomPresenter();
            CustomPresenter.Editor = c1ExpressionEditor1;
            c1TreeView1.Columns[1].CustomContentPresenter = p;

            ThemeName = ribbonCmbThemes.SelectedItem.Text;
            ApplyTheme(this);
        }
        #endregion

        #region themes
        private void ribbonCmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeName = ribbonCmbThemes.SelectedItem.Text;
            ApplyTheme(this);
        }
        private string ThemeName
        {
            get;
            set;
        }
        private void ApplyTheme(Control control)
        {
            if (!string.IsNullOrEmpty(ThemeName))
            {
                var theme = C1ThemeController.GetThemeByName(ThemeName, false);
                if (theme != null)
                    C1ThemeController.ApplyThemeToControlTree(control, theme);
            }
        }


        #endregion

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            var sc = (StoreCollection)c1TreeView1.BindingInfo.DataSource;            
            foreach (var store in sc)
            {
                c1ExpressionEditor1.ItemContext = store;
                var res = c1ExpressionEditor1.Evaluate();
                if (c1ExpressionEditor1.IsValid)
                    lbResult.Items.Add(string.Format("{0}: {1}", store.Name, res));
                else
                    foreach (var error in c1ExpressionEditor1.GetErrors())
                        lbResult.Items.Add(error.Message);
                sc.ResetItem(sc.IndexOf(store));
            }
            c1TreeView1.ExpandAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbResult.Items.Clear();
        }
    }
}
