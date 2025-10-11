//----------------------------------------------------------------------------
// DataTree.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using C1.Report;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp.Controls
{
    public partial class DataTree : UserControl
    {
        #region Kill flicker
        // somewhat -- http://stackoverflow.com/questions/10362988/treeview-flickering
        // completely -- http://stackoverflow.com/questions/13936659/treeview-flickering-without-any-events
        protected override void OnHandleCreated(EventArgs e)
        {
            SendMessage(this.Handle, TVM_SETEXTENDEDSTYLE, (IntPtr)TVS_EX_DOUBLEBUFFER, (IntPtr)TVS_EX_DOUBLEBUFFER);
            base.OnHandleCreated(e);
        }
        // Pinvoke:
        private const int TVM_SETEXTENDEDSTYLE = 0x1100 + 44;
        private const int TVM_GETEXTENDEDSTYLE = 0x1100 + 45;
        private const int TVS_EX_DOUBLEBUFFER = 0x0004;

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_COMPOSITE = 0x02000000;
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        [DllImport("user32")]
        internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32")]
        internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        #endregion

        private C1FlexReportDesigner _designer = null;
        private DataSourcesNode _dataSourcesNode;
        private ParametersNode _parametersNode;
        private ITooltipService _tooltipService = null;

        // Static node names:
        private readonly static string nParameters = Strings.DataTree.Parameters;
        private readonly static string nDataSources = Strings.DataTree.DataSources;
        private readonly static string nCalculatedFields = Strings.DataTree.CalculatedFields;
        private readonly static string nSortDefinitions = Strings.DataTree.SortDefinitions;
        private readonly static string nEmptySortDefinition = Strings.DataTree.None;

        // Collection keys (for nested objects, keys are built like file pathes)
        private const string kDataSources = "/DataSources";
        private const string kParameters = "/Parameters";
        private const string kDataFields = "DataFields";
        private const string kCalculatedFields = "CalculatedFields";
        private const string kSortDefinitions = "SortDefinitions";

        // Image keys:
        private const string ikNone = "None";
        private const string ikParams = "Params";
        private const string ikParam = "Param";
        private const string ikDataSources = "DataSources";
        private const string ikDataSource = "DataSource";
        private const string ikDataSourceErr = "DataSourceErr";
        private const string ikDataSourceWait = "DataSourceWait";
        private const string ikDataField = "DbField";
        private const string ikCalcFields = "CalcFields";
        private const string ikCalcField = "CalcField";
        private const string ikSortDefinitions = "Sort";
        private const string ikSortAscending = "SortAsc";
        private const string ikSortDescending = "SortDesc";
        private const string ikSortDirectionExpression = "SortDirectionExpression";

        public DataTree()
        {
            // Kill flicker (works):
            int style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            style |= WS_EX_COMPOSITE;
            SetWindowLong(this.Handle, GWL_EXSTYLE, style);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            //
            InitializeComponent();
            //
            this._imageList.Images.Clear();
            _imageList.Images.Add("None", global::FlexReportDesignerApp.Img_DataTree.None_16);
            _imageList.Images.Add("Params", global::FlexReportDesignerApp.Img_DataTree.Params1_16);
            _imageList.Images.Add("Param", global::FlexReportDesignerApp.Img_DataTree.Param1_16);
            _imageList.Images.Add("DataSources", global::FlexReportDesignerApp.Img_DataTree.DataSources_16);
            _imageList.Images.Add("DataSource", global::FlexReportDesignerApp.Img_DataTree.DataSource_16);
            _imageList.Images.Add("DataSourceWait", global::FlexReportDesignerApp.Img_DataTree.DataSourceWait_16);
            _imageList.Images.Add("DataSourceErr", global::FlexReportDesignerApp.Img_DataTree.DataSourceErr_16);
            _imageList.Images.Add("CalcFields", global::FlexReportDesignerApp.Img_DataTree.CalcFields_16);
            _imageList.Images.Add("Sort", global::FlexReportDesignerApp.Img_DataTree.Sort_16);
            _imageList.Images.Add("SortAsc", global::FlexReportDesignerApp.Img_DataTree.SortAsc_16);
            _imageList.Images.Add("SortDesc", global::FlexReportDesignerApp.Img_DataTree.SortDesc_16);
            _imageList.Images.Add("CalcField", global::FlexReportDesignerApp.Img_DataTree.CalcField_16);
            _imageList.Images.Add("DbField", global::FlexReportDesignerApp.Img_DataTree.DbField_16);
            //
            _dataSourcesNode = new DataSourcesNode(this);
            _parametersNode = new ParametersNode(this);
            //
            _treeView.BeginUpdate();
            // To avoid unwanted "edits", we disable LabelEdit by default, and only enable it when needed for a specific node:
            _treeView.LabelEdit = false;
            _treeView.Nodes.Add(_parametersNode);
            _treeView.Nodes.Add(_dataSourcesNode);
            _treeView.EndUpdate();
            //
            _treeView.AfterSelect += _treeView_AfterSelect;
            _treeView.BeforeLabelEdit += _treeView_BeforeLabelEdit;
            _treeView.AfterLabelEdit += _treeView_AfterLabelEdit;
            _treeView.NodeMouseDoubleClick += _treeView_NodeMouseDoubleClick;
            _treeView.MouseMove += _treeView_MouseMove;
            _treeView.MouseDown += _treeView_MouseDown;
            _treeView.GotFocus += _treeView_GotFocus;
            _treeView.NodeMouseHover += _treeView_NodeMouseHover;
        }

        void _treeView_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            if (_tooltipService == null)
                return;
            var node = e.Node as DataTreeNode;
            if (node != null)
                _tooltipService.SetToolTip(_treeView, node.Tooltip);
            else
                _tooltipService.ClearToolTip(_treeView);
        }

        void _treeView_GotFocus(object sender, EventArgs e)
        {
            // Refresh property grid/field picker as another object may have been selected elsewhere:
            OnSelectedDataObjectChanged();
        }

        void _treeView_MouseDown(object sender, MouseEventArgs e)
        {
            // Ensure we go to node under mouse when mouse is down. This ensures that:
            // - we select correct node for context menu;
            // - we select correct node before dragging onto designer pane.
            var ht = _treeView.HitTest(e.Location);
            var node = ht.Node as DataTreeNode;
            if (node != null)
            {
                if (node != _treeView.SelectedNode)
                {
                    _treeView.SelectedNode = node;
                    _treeView.LabelEdit = false;
                }
                else
                    _treeView.LabelEdit = node.CanInplaceEdit;
            }
            else
                _treeView.LabelEdit = false;
        }

        void _treeView_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var n = SelectedNode;
                if (n == null)
                    return;

                var o = n.DragDropObject;
                if (o != null)
                    _treeView.DoDragDrop(o, DragDropEffects.Copy);
            }
        }

        void _treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // We only fire this for sort definitions for now.
            SortDefinitionNode sen = e.Node as SortDefinitionNode;
            if (sen == null)
                return;

            if (DataObjectDoubleClick != null)
            {
                DataObjectDoubleClick(this, new DataTreeDoubleClickEventArgs(sen.DataObject));
                sen.Update(sen.Parent);
            }
        }


        //[DllImport("USER32", EntryPoint = "SendMessage", CharSet = CharSet.Auto, SetLastError = true)]
        //public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [DllImport("USER32", EntryPoint = "SendMessage", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        public const int TVM_GETEDITCONTROL = 0x110F;
        public const int WM_SETTEXT = 0xC;

        void _treeView_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            DataTreeNode n = e.Node as DataTreeNode;
            if (n == null)
            {
                e.CancelEdit = true;
                return;
            }
            if (InplaceEditBegin != null)
            {
                //
                IntPtr editHandle = SendMessage(_treeView.Handle, TVM_GETEDITCONTROL, IntPtr.Zero, IntPtr.Zero);
                SendMessage(editHandle, WM_SETTEXT, IntPtr.Zero, n.InPlaceText);
                //
                DataTreeInplaceEditEventArgs ee = new DataTreeInplaceEditEventArgs(n.DataObject, n.InPlaceText);
                InplaceEditBegin(this, ee);
            }
        }

        void _treeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            DataTreeNode n = e.Node as DataTreeNode;
            if (n == null)
            {
                e.CancelEdit = true;
                return;
            }
            if (InplaceEditEnd != null)
            {
                // AfterLabelEdit fires with e.Label == null if user presses Escape:
                string text = e.Label == null ? n.InPlaceText : e.Label;
                DataTreeInplaceEditEventArgs ee = new DataTreeInplaceEditEventArgs(n.DataObject, text);
                if (e.Label == null || n.InPlaceText == text)
                    ee.Cancel = true;
                try
                {
                    n.InPlaceText = ee.Text;
                }
                catch (Exception ex)
                {
                    MessageForm.Error(ex.Message);
                    e.CancelEdit = true;
                    ee.Cancel = true;
                }
                InplaceEditEnd(this, ee);
            }
        }

        private void _treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            OnSelectedDataObjectChanged();
#if skip_dima // see note at the top
            var n = SelectedNode;
            _treeView.LabelEdit = n != null && n.CanInplaceEdit;
#endif
            _treeView.LabelEdit = false;
        }

        public override bool Focused
        {
            get
            {
                if (_treeView.Focused)
                    return true;
                return base.Focused;
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            _treeView.Focus();
        }

        private DataTreeNode SelectedNode
        {
            get
            {
                if (_designer == null || _designer.Report == null)
                    return null;
                return _treeView.SelectedNode as DataTreeNode;
            }
        }

        #region Public interface
        public EventHandler SelectedDataObjectChanged;
        public DataTreeInplaceEditEventHandler InplaceEditBegin;
        public DataTreeInplaceEditEventHandler InplaceEditEnd;
        public DataTreeDoubleClickEventHandler DataObjectDoubleClick;

        private void OnSelectedDataObjectChanged()
        {
            if (SelectedDataObjectChanged != null)
                SelectedDataObjectChanged(this, EventArgs.Empty);
        }

        public object SelectedDataObject
        {
            get
            {
                var n = SelectedNode;
                return n == null ? null : n.DataObject;
            }
        }

        public static bool IsDataObject(object o)
        {
            if (o == null)
                return false;
            
            if (o is ReportParameterCollection ||
                o is ReportParameter ||
                o is DataSourceCollection ||
                o is DataSource ||
                o is FieldInfo ||
                o is CalculatedFieldCollection ||
                o is CalculatedField ||
                o is SortDefinitionCollection ||
                o is SortDefinition
                )
                return true;
            //
            return false;
        }

        public void StartInplaceEdit()
        {
            var n = SelectedNode;
            if (n == null || !n.CanInplaceEdit)
                return;
            if (!n.IsEditing)
            {
                _treeView.LabelEdit = true;
                n.BeginEdit();
            }
        }

        public void EndInPlaceEdit(bool cancel = false)
        {
            var n = SelectedNode;
            if (n == null)
                return;
            if (n.IsEditing)
                n.EndEdit(cancel);
            _treeView.LabelEdit = false;
        }

        public void MoveNodeUp()
        {
            var n = SelectedNode;
            if (n != null)
            {
                n.MoveUp();
                _treeView.SelectedNode = n;
            }
        }

        public void MoveNodeDown()
        {
            var n = SelectedNode;
            if (n != null)
            {
                n.MoveDown();
                _treeView.SelectedNode = n;
            }
        }

        #region UI command state
        public bool CanAddDataSource
        {
            get
            {
                return _designer.Report != null;
            }
        }
        public bool CanAddParameter
        {
            get
            {
                return _designer.Report != null;
            }
        }
        public bool CanAddCalculatedField
        {
            get
            {
                return GetCurrentDataSource() != null;
            }
        }
        public bool CanAddSort
        {
            get
            {
                return GetCurrentDataSource() != null;
            }
        }
        public bool CanDelete
        {
            get
            {
                var n = SelectedNode;
                return n == null ? false : n.CanBeDeleted;
            }
        }
        public bool CanInsert
        {
            get
            {
                var n = SelectedNode;
                return n == null ? false : (n.CanAddChild || n.CanAddSibling);
            }
        }
        public bool CanInplaceEdit
        {
            get
            {
                var n = SelectedNode;
                return n == null ? false : n.CanInplaceEdit;
            }
        }
        public bool CanChangeSortOrder
        {
            get
            {
                var n = SelectedNode;
                return n is SortDefinitionNode;
            }
        }
        public bool CanEdit
        {
            get
            {
                var n = SelectedNode;
                return n == null ? false : n.CanEditObject;
            }
        }
        public bool CanMoveUp
        {
            get
            {
                var n = SelectedNode;
                return n == null ? false : n.CanMoveUp;
            }
        }
        public bool CanMoveDown
        {
            get
            {
                var n = SelectedNode;
                return n == null ? false : n.CanMoveDown;
            }
        }
        public bool CanRefresh
        {
            get
            {
                var n = SelectedNode;
                return n == null ? false : n.CanRefresh;
            }
        }
        #endregion

        public void SetServices(FlexDesignerHostServices services)
        {
            _tooltipService = services.GetTooltipService();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public C1FlexReportDesigner FlexDesigner
        {
            get { return _designer; }
            set
            {
                Clear();
                _designer = value;
            }
        }

        public void Clear()
        {
            _treeView.BeginUpdate();
            _dataSourcesNode.Nodes.Clear();
            _parametersNode.Nodes.Clear();
            _parametersNode.Parameters = null;
            _dataSourcesNode.DataSources = null;
            _treeView.EndUpdate();
        }

        public void UpdateFromReport()
        {
            var report = _designer.Report;
            if (report == null)
            {
                Clear();
                return;
            }

            _treeView.BeginUpdate();
            //
            // Try to save current state:
            string currentKey = SelectedNode != null ? SelectedNode.Name : null;
            List<string> expandedNodes = new List<string>();
            Action<TreeNodeCollection> collectExpandedNodes = null;
            collectExpandedNodes = (tnc_) =>
                {
                    foreach (TreeNode n_ in tnc_)
                        if (n_.IsExpanded)
                        {
                            expandedNodes.Add(n_.Name);
                            collectExpandedNodes(n_.Nodes);
                        }
                };
            collectExpandedNodes(_treeView.Nodes);
            //
            Clear();
            //
            _parametersNode.Parameters = report.Parameters;
            _dataSourcesNode.DataSources = report.DataSources;
            //
            string mainDataSourceKey = null;
            string mainDataSourceName = report.DataSourceName;
            _parametersNode.AddParameters(report);
            foreach (DataSource ds in report.DataSources)
            {
                var dsKey = _dataSourcesNode.AddDataSource(ds);
                if (ds.Name == mainDataSourceName)
                    mainDataSourceKey = dsKey;
            }
            _treeView.EndUpdate();
            // restore expanded state:
            foreach (string key in expandedNodes)
            {
                var ns = _treeView.Nodes.Find(key, true);
                foreach (var n in ns)
                    n.Expand();
            }
            // expand params and main data source if everything is collapsed:
            if (!expandedNodes.Any())
            {
                if (!string.IsNullOrEmpty(mainDataSourceKey))
                {
                    var nodes = _dataSourcesNode.Nodes.Find(mainDataSourceKey, false);
                    if (nodes.Length == 1)
                        nodes[0].ExpandAll();
                    _dataSourcesNode.Expand();
                    _parametersNode.Expand();
                }
            }
            if (currentKey != null)
                GoToNode(null, currentKey, true);
            OnSelectedDataObjectChanged();
        }

        public ReportParameterCollection GetCurrentParameters()
        {
            var n = SelectedNode;
            if (n is ParametersNode || n is ParameterNode)
                return _parametersNode.Parameters;
            return null;
        }

        public DataSourceCollection GetCurrentDataSources()
        {
            var n = SelectedNode;
            if (n is DataSourcesNode || n is DataSourceNode)
                return _dataSourcesNode.DataSources;
            return null;
        }

        public CalculatedFieldCollection GetCurrentCalculatedFields()
        {
            var n = SelectedNode;
            var cfsNode = FindParentNode<CalculatedFieldsNode>(n);
            return cfsNode != null ? cfsNode.CalculatedFields : null;
        }

        public SortDefinitionCollection GetCurrentSortDefinitions()
        {
            var n = SelectedNode;
            var sesNode = FindParentNode<SortDefinitionsNode>(n);
            return sesNode != null ? sesNode.SortDefinitions : null;
        }

        public SortDefinition GetCurrentSortDefinition()
        {
            var n = SelectedNode as SortDefinitionNode;
            return n != null ? n.Sort : null;
        }

        public DataSource GetCurrentDataSource()
        {
            var n = SelectedNode;
            if (n == null)
                return null;

            var dsNode = FindParentNode<DataSourceNode>(n);
            return dsNode != null ? dsNode.DataSource : null;
        }

        public bool GoToParameter(ReportParameter par)
        {
            var key = KeyMaker(_parametersNode.Name, par.Name);
            return GoToNode(_parametersNode, key, false);
        }

        public bool GoToDataSource(DataSource ds)
        {
            var dsNode = FindDataSource(ds);
            if (dsNode != null)
            {
                _treeView.SelectedNode = dsNode;
                return true;
            }
            return false;
        }

        public bool GoToCalculatedField(CalculatedField cf)
        {
            var dsNode = FindDataSource(cf.DataSource);
            if (dsNode == null)
                return false;

            var cfsn = dsNode.CalcFieldsNode;
            var key = KeyMaker(cfsn.Name, cf.Name);
            return GoToNode(cfsn, key, false);
        }

        public bool GoToSortDefinition(DataSource ds, SortDefinition sd)
        {
            var dsNode = FindDataSource(ds);
            if (dsNode == null)
                return false;

            var sorts = dsNode.SortDefinitionsNode;
            foreach (SortDefinitionNode sen in sorts.Nodes)
                if (sen.Sort == sd)
                {
                    _treeView.SelectedNode = sen;
                    return true;
                }
            return false;
        }

        /// <summary>
        /// This method returns the tree node which should become the selected one if/when
        /// the currently selected node is deleted.
        /// </summary>
        /// <returns></returns>
        public string GetNextBossKey()
        {
            var n = _treeView.SelectedNode;
            if (n == null)
                return null;
            else if (n.PrevVisibleNode != null)
                return n.PrevVisibleNode.Name;
            else
                return n.Parent.Name;
        }

        /// <summary>
        /// Selects a node among a node's children (possibly grand-children too).
        /// </summary>
        /// <param name="parentNode">Parent node to search, or null to search the whole tree.</param>
        /// <param name="key">Target node key (name).</param>
        /// <param name="recurse">True to recurse down below immediate children.</param>
        public bool GoToNode(TreeNode parentNode, string key, bool recurse)
        {
            var nodes = parentNode == null ? _treeView.Nodes : parentNode.Nodes;
            var ns = nodes.Find(key, recurse);
            if (ns.Length > 0)
            {
                _treeView.SelectedNode = ns[0];
                return true;
            }
            return false;
        }
        #endregion

        [System.Diagnostics.Conditional("DEBUG")]
        private static void DebugKeys(TreeNode node)
        {
            // node.Text = node.Name;
        }

        private static string KeyMaker(string path, string key)
        {
            return path + "." + key;
        }

        private T FindParentNode<T>(TreeNode node) where T : TreeNode
        {
            while (node != null && node.GetType() != typeof(T))
                node = node.Parent;
            return node as T;
        }

        private DataSourceNode FindDataSource(DataSource ds)
        {
            var key = KeyMaker(_dataSourcesNode.Name, ds.Name);
            var ns = _dataSourcesNode.Nodes.Find(key, false);
            if (ns.Length > 0)
                return (DataSourceNode)ns[0];
            return null;
        }

        #region Data tree nodes
        private abstract class DataTreeNode : TreeNode
        {
            public abstract object DataObject { get; }
            public abstract object DragDropObject { get; }
            public abstract bool CanBeDeleted { get; }
            public abstract bool CanInplaceEdit { get; }
            public abstract bool CanAddChild { get; }
            public abstract bool CanAddSibling { get; }
            public abstract bool CanEditObject { get; }
            public abstract bool CanMoveUp { get; }
            public abstract bool CanMoveDown { get; }
            public virtual bool CanRefresh { get { return false; } }
            public virtual string Tooltip { get { return null; } }
            public virtual string InPlaceText { get { return null; } set { } }
            public virtual void MoveUp()
            {
                var coll = Parent.Nodes;
                int idx = coll.IndexOf(this);
                coll.RemoveAt(idx);
                coll.Insert(idx - 1, this);
            }
            public virtual void MoveDown()
            {
                var coll = Parent.Nodes;
                int idx = coll.IndexOf(this);
                coll.RemoveAt(idx);
                coll.Insert(idx + 1, this);
            }
        }

        private class ParametersNode : DataTreeNode
        {
            DataTree _owner;
            public ReportParameterCollection Parameters { get; set; }
            public ParametersNode(DataTree owner)
            {
                _owner = owner;
                this.Name = kParameters;
                this.Text = nParameters;
                this.ImageKey = this.SelectedImageKey = ikParams;
                DebugKeys(this);
            }
            public void AddParameters(C1FlexReport report)
            {
                foreach (ReportParameter p in Parameters)
                    this.Nodes.Add(new ParameterNode(this, p));
            }
            #region overrrides
            public override object DataObject { get { return null; } }
            public override object DragDropObject { get { return null; } }
            public override bool CanBeDeleted { get { return false; } }
            public override bool CanInplaceEdit { get { return false; } }
            public override bool CanAddChild { get { return true; } }
            public override bool CanAddSibling { get { return false; } }
            public override bool CanEditObject { get { return false; } }
            public override bool CanMoveUp { get { return false; } }
            public override bool CanMoveDown { get { return false; } }
            #endregion
        }

        private class DataSourcesNode : DataTreeNode
        {
            DataTree _owner;
            public DataSourceCollection DataSources { get; set; }
            public DataSourcesNode(DataTree owner)
            {
                _owner = owner;
                this.Name = kDataSources;
                this.Text = nDataSources;
                this.ImageKey = this.SelectedImageKey = ikDataSources;
                DebugKeys(this);
            }
            public string AddDataSource(DataSource ds)
            {
                var dsn = new DataSourceNode(this, ds);
                this.Nodes.Add(dsn);
                return dsn.Name;
            }
            public Font BaseFont { get { return _owner.Font; } }
            #region overrrides
            public override object DataObject { get { return null; } }
            public override object DragDropObject { get { return null; } }
            public override bool CanBeDeleted { get { return false; } }
            public override bool CanInplaceEdit { get { return false; } }
            public override bool CanAddChild { get { return true; } }
            public override bool CanAddSibling { get { return false; } }
            public override bool CanEditObject { get { return false; } }
            public override bool CanMoveUp { get { return false; } }
            public override bool CanMoveDown { get { return false; } }
            #endregion
        }

        private class ParameterNode : DataTreeNode
        {
            public ReportParameter Parameter { get; private set; }

            public ParameterNode(ParametersNode parent, ReportParameter p)
            {
                Parameter = p;
                this.Name = KeyMaker(kParameters, p.Name);
                this.Text = p.Name;
                this.ImageKey = this.SelectedImageKey = ikParam;
                DebugKeys(this);
            }
            #region overrrides
            public override object DataObject { get { return Parameter; } }
            public override object DragDropObject { get { return Parameter; } }
            public override bool CanBeDeleted { get { return true; } }
            public override bool CanInplaceEdit { get { return true; } }
            public override bool CanAddChild { get { return false; } }
            public override bool CanAddSibling { get { return true; } }
            public override bool CanEditObject { get { return false; } }
            public override bool CanMoveUp { get { return Parameter.Owner.IndexOf(Parameter) > 0; } }
            public override bool CanMoveDown { get { return Parameter.Owner.IndexOf(Parameter) < Parameter.Owner.Count - 1; } }
            public override string InPlaceText
            {
                get { return Parameter.Name; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception(Strings.Common.EmptyName);
                    var t = Parameter.Owner.FindByName(value);
                    if (t != null && t != Parameter)
                        throw new Exception(Strings.Common.DuplicateName);
                    Parameter.Name = this.Text = value;
                }
            }
            public override void MoveUp()
            {
                if (!CanMoveUp)
                    return;
                var coll = Parameter.Owner;
                int idx = coll.IndexOf(Parameter);
                coll.RemoveAt(idx);
                coll.Insert(idx - 1, Parameter);
                base.MoveUp();
            }
            public override void MoveDown()
            {
                if (!CanMoveDown)
                    return;
                var coll = Parameter.Owner;
                int idx = coll.IndexOf(Parameter);
                coll.RemoveAt(idx);
                coll.Insert(idx + 1, Parameter);
                base.MoveDown();
            }
            #endregion
        }

        private class DataSourceNode : DataTreeNode
        {
            private bool _isInfoFetched;

            public DataSource DataSource { get; private set; }
            public CalculatedFieldsNode CalcFieldsNode { get; private set; }
            public SortDefinitionsNode SortDefinitionsNode { get; private set; }

            public DataSourceNode(DataSourcesNode parent, DataSource ds)
            {
                DataSource = ds;
                this.Name = KeyMaker(kDataSources, ds.Name);
                SetText(parent, ds.ParentReport != null && ds.ParentReport.DataSourceName == ds.Name);
                _isInfoFetched = ds.IsDataSourceInfoFetched;
                if (_isInfoFetched)
                {
                    var info = ds.DataSourceInfo;
                    if (info.Error != null)
                        this.ImageKey = this.SelectedImageKey = ikDataSourceErr;
                    else
                        this.ImageKey = this.SelectedImageKey = ikDataSource;
#if NO_DataFieldsNode
                    this.Nodes.Add(new DataFieldsNode(this, ds));
#else
                    info.Fields.ForEach(fi_ => this.Nodes.Add(new DataFieldNode(this, fi_)));
#endif
                }
                else
                    this.ImageKey = this.SelectedImageKey = ikDataSourceWait;

                CalcFieldsNode = new CalculatedFieldsNode(this, ds);
                this.Nodes.Add(CalcFieldsNode);
                //
                SortDefinitionsNode = new SortDefinitionsNode(this, ds);
                this.Nodes.Add(SortDefinitionsNode);
                //
                DebugKeys(this);
            }
            private void SetText(DataSourcesNode parent, bool isMain)
            {
                this.Text = DataSource.Name;
                if (isMain)
                    this.NodeFont = new Font(parent.BaseFont, FontStyle.Bold);
                else
                    this.NodeFont = parent.BaseFont;
            }
            #region overrrides
            public override object DataObject { get { return DataSource; } }
            public override object DragDropObject { get { return null; } }
            public override bool CanBeDeleted { get { return _isInfoFetched; } }
            public override bool CanInplaceEdit { get { return _isInfoFetched; } }
            public override bool CanAddChild { get { return false; } }
            public override bool CanAddSibling { get { return true; } }
            public override bool CanEditObject { get { return _isInfoFetched; } }
            public override bool CanMoveUp { get { return DataSource.ParentReport != null && DataSource.ParentReport.DataSources.IndexOf(DataSource) > 0; } }
            public override bool CanMoveDown { get { return DataSource.ParentReport != null && (DataSource.ParentReport.DataSources.IndexOf(DataSource) < DataSource.ParentReport.DataSources.Count - 1); } }
            public override bool CanRefresh { get { return _isInfoFetched; } }
            public override string Tooltip
            {
                get
                {
                    if (!_isInfoFetched)
                        return Strings.Common.FetchingDataSourceInfoTooltip;
                    var info = DataSource.DataSourceInfo;
                    if (info.Error == null)
                        return null;
                    return info.Error.Message;
                }
            }
            public override string InPlaceText
            {
                get { return DataSource.Name; }
                set
                {
                    if (!_isInfoFetched)
                        throw new Exception(Strings.Common.DataSourceInfoNotFetched);
                    if (string.IsNullOrEmpty(value))
                        throw new Exception(Strings.Common.EmptyName);
                    if (DataSource.ParentReport == null)
                        throw new Exception(Strings.Common.UnexpectedError);

                    var t = DataSource.ParentReport.DataSources.FindByName(value);
                    if (t != null && t != DataSource)
                        throw new Exception(Strings.Common.DuplicateName);
                    bool isMain = DataSource.ParentReport.DataSourceName == DataSource.Name;
                    DataSource.Name = value;
                    if (isMain)
                        DataSource.ParentReport.DataSourceName = DataSource.Name;
                    SetText((DataSourcesNode)this.Parent, isMain);
                }
            }
            public override void MoveUp()
            {
                if (!CanMoveUp)
                    return;
                var coll = DataSource.ParentReport.DataSources;
                int idx = coll.IndexOf(DataSource);
                coll.Move(idx, idx - 1);
                base.MoveUp();
            }
            public override void MoveDown()
            {
                if (!CanMoveDown)
                    return;
                var coll = DataSource.ParentReport.DataSources;
                int idx = coll.IndexOf(DataSource);
                coll.Move(idx, idx + 1);
                base.MoveDown();
            }
            #endregion
        }

#if NO_DataFieldsNode
        private class DataFieldsNode : TreeNode
        {
            public DataFieldsNode(DataSourceNode parent, DataSource ds)
            {
                this.Name = KeyMaker(parent.Name, kDataFields);
                this.Text = "Data Fields";
                foreach (FieldInfo fi in ds.DataSourceInfo.Fields)
                    this.Nodes.Add(new DataFieldNode(this, fi));
                DebugKeys(this);
            }
        }
#endif

        private class DataFieldNode : DataTreeNode
        {
            public FieldInfo FieldInfo { get; private set; }

            public DataFieldNode(TreeNode parent, FieldInfo fi)
            {
                FieldInfo = fi;
                this.Name = KeyMaker(parent.Name, fi.Name);
                this.Text = fi.Name;
                this.ImageKey = this.SelectedImageKey = ikDataField;
                DebugKeys(this);
            }
            #region overrrides
            public override object DataObject { get { return FieldInfo; } }
            public override object DragDropObject { get { return FieldInfo; } }
            public override bool CanBeDeleted { get { return false; } }
            public override bool CanInplaceEdit { get { return false; } }
            public override bool CanAddChild { get { return false; } }
            public override bool CanAddSibling { get { return false; } }
            public override bool CanEditObject { get { return false; } }
            public override bool CanMoveUp { get { return false; } }
            public override bool CanMoveDown { get { return false; } }
            #endregion
        }

        private class CalculatedFieldsNode : DataTreeNode
        {
            public CalculatedFieldCollection CalculatedFields { get; private set; }
            public CalculatedFieldsNode(DataSourceNode parent, DataSource ds)
            {
                CalculatedFields = ds.CalculatedFields;
                this.Name = KeyMaker(parent.Name, kCalculatedFields);
                this.Text = nCalculatedFields;
                this.ImageKey = this.SelectedImageKey = ikCalcFields;
                foreach (CalculatedField cf in CalculatedFields)
                    this.Nodes.Add(new CalculatedFieldNode(this, cf));
                DebugKeys(this);
            }
            #region overrrides
            public override object DataObject { get { return null; } }
            public override object DragDropObject { get { return null; } }
            public override bool CanBeDeleted { get { return false; } }
            public override bool CanInplaceEdit { get { return false; } }
            public override bool CanAddChild { get { return true; } }
            public override bool CanAddSibling { get { return false; } }
            public override bool CanEditObject { get { return true; } }
            public override bool CanMoveUp { get { return false; } }
            public override bool CanMoveDown { get { return false; } }
            #endregion
        }

        private class CalculatedFieldNode : DataTreeNode
        {
            public CalculatedField Field { get; private set; }

            public CalculatedFieldNode(CalculatedFieldsNode parent, CalculatedField cf)
            {
                Field = cf;
                this.Name = KeyMaker(parent.Name, cf.Name);
                this.Text = cf.Name;
                this.ImageKey = this.SelectedImageKey = ikCalcField;
                DebugKeys(this);
            }
            #region overrrides
            public override object DataObject { get { return Field; } }
            public override object DragDropObject { get { return Field; } }
            public override bool CanBeDeleted { get { return true; } }
            public override bool CanInplaceEdit { get { return true; } }
            public override bool CanAddChild { get { return false; } }
            public override bool CanAddSibling { get { return true; } }
            public override bool CanEditObject { get { return true; } }
            public override bool CanMoveUp { get { return Field.Owner.IndexOf(Field) > 0; } }
            public override bool CanMoveDown { get { return Field.Owner.IndexOf(Field) < Field.Owner.Count - 1; } }
            public override string InPlaceText
            {
                get { return Field.Name; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception(Strings.Common.EmptyName);
                    var t = Field.Owner.FindByName(value);
                    if (t != null && t != Field)
                        throw new Exception(Strings.Common.DuplicateName);
                    Field.Name = value;
                }
            }
            public override void MoveUp()
            {
                if (!CanMoveUp)
                    return;
                var coll = Field.Owner;
                int idx = coll.IndexOf(Field);
                coll.RemoveAt(idx);
                coll.Insert(idx - 1, Field);
                base.MoveUp();
            }
            public override void MoveDown()
            {
                if (!CanMoveDown)
                    return;
                var coll = Field.Owner;
                int idx = coll.IndexOf(Field);
                coll.RemoveAt(idx);
                coll.Insert(idx + 1, Field);
                base.MoveDown();
            }
            #endregion
        }

        private class SortDefinitionsNode : DataTreeNode
        {
            public SortDefinitionCollection SortDefinitions { get; private set; }

            public SortDefinitionsNode(DataSourceNode parent, DataSource ds)
            {
                SortDefinitions = ds.SortDefinitions;
                this.Name = KeyMaker(parent.Name, kSortDefinitions);
                this.Text = nSortDefinitions;
                this.ImageKey = this.SelectedImageKey = ikSortDefinitions;
                foreach (SortDefinition sd in ds.SortDefinitions)
                    this.Nodes.Add(new SortDefinitionNode(this, sd));
                DebugKeys(this);
            }
            #region overrrides
            public override object DataObject { get { return null; } }
            public override object DragDropObject { get { return null; } }
            public override bool CanBeDeleted { get { return false; } }
            public override bool CanInplaceEdit { get { return false; } }
            public override bool CanAddChild { get { return true; } }
            public override bool CanAddSibling { get { return false; } }
            public override bool CanEditObject { get { return false; } }
            public override bool CanMoveUp { get { return false; } }
            public override bool CanMoveDown { get { return false; } }
            #endregion
        }

        private class SortDefinitionNode : DataTreeNode
        {
            public SortDefinition Sort { get; private set; }

            public SortDefinitionNode(SortDefinitionsNode parent, SortDefinition sd)
            {
                Sort = sd;
                var name = parent.SortDefinitions.IndexOf(sd).ToString(); // using index as name
                this.Name = KeyMaker(parent.Name, name);
                Update(parent);
                DebugKeys(this);
            }

            public void Update(TreeNode parent)
            {
                if (string.IsNullOrWhiteSpace(Sort.Expression))
                {
                    this.ForeColor = SystemColors.GrayText;
                    this.Text = nEmptySortDefinition;
                }
                else
                {
                    this.ForeColor = parent.ForeColor;
                    this.Text = Sort.Expression;
                }
                if (Sort.Direction.IsExpression)
                    this.ImageKey = ikSortDirectionExpression;
                else
                    this.ImageKey = this.SelectedImageKey = Sort.Direction.Value == SortDirection.Ascending ? ikSortAscending : ikSortDescending;
            }
            #region overrrides
            public override object DataObject { get { return Sort; } }
            public override object DragDropObject { get { return null; } }
            public override bool CanBeDeleted { get { return true; } }
            public override bool CanInplaceEdit { get { return true; } }
            public override bool CanAddChild { get { return false; } }
            public override bool CanAddSibling { get { return true; } }
            public override bool CanEditObject { get { return true; } }
            public override bool CanMoveUp { get { return Sort.Owner.IndexOf(Sort) > 0; } }
            public override bool CanMoveDown { get { return Sort.Owner.IndexOf(Sort) < Sort.Owner.Count - 1; } }
            public override string InPlaceText
            {
                get { return Sort.Expression; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception(Strings.Common.EmptyExpression);
                    Sort.Expression = value;
                    Update(Parent);
                }
            }
            public override void MoveUp()
            {
                if (!CanMoveUp)
                    return;
                var coll = Sort.Owner;
                int idx = coll.IndexOf(Sort);
                coll.RemoveAt(idx);
                coll.Insert(idx - 1, Sort);
                base.MoveUp();
            }
            public override void MoveDown()
            {
                if (!CanMoveDown)
                    return;
                var coll = Sort.Owner;
                int idx = coll.IndexOf(Sort);
                coll.RemoveAt(idx);
                coll.Insert(idx + 1, Sort);
                base.MoveDown();
            }
            #endregion
        }

#if skip_dima // not yet
        private class FilterNode : DataTreeNode
        {
            public string Filter { get; private set; }

            public FilterNode(DataSourceNode parent)
            {
                Filter = parent.DataSource.Filter;
                this.Name = KeyMaker(parent.Name, "Filter");
                Update(parent);
                DebugKeys(this);
            }
            #region overrrides
            public override object DataObject { get { return Sort; } }
            public override object DragDropObject { get { return null; } }
            public override bool CanBeDeleted { get { return true; } }
            public override bool CanInplaceEdit { get { return true; } }
            public override bool CanAddChild { get { return false; } }
            public override bool CanAddSibling { get { return true; } }
            public override bool CanEditObject { get { return true; } }
            public override bool CanMoveUp { get { return Sort.Owner.IndexOf(Sort) > 0; } }
            public override bool CanMoveDown { get { return Sort.Owner.IndexOf(Sort) < Sort.Owner.Count - 1; } }
            public override string InPlaceText
            {
                get { return Sort.Expression; }
                set
                {
                    Sort.Expression = value;
                    Update(Parent);
                }
            }
            public override void MoveUp()
            {
                if (!CanMoveUp)
                    return;
                var coll = Sort.Owner;
                int idx = coll.IndexOf(Sort);
                coll.RemoveAt(idx);
                coll.Insert(idx - 1, Sort);
                base.MoveUp();
            }
            public override void MoveDown()
            {
                if (!CanMoveDown)
                    return;
                var coll = Sort.Owner;
                int idx = coll.IndexOf(Sort);
                coll.RemoveAt(idx);
                coll.Insert(idx + 1, Sort);
                base.MoveDown();
            }
            #endregion
        }
#endif
        #endregion
    }

    public delegate void DataTreeDoubleClickEventHandler(object sender, DataTreeDoubleClickEventArgs e);
    public class DataTreeDoubleClickEventArgs : EventArgs
    {
        public object DataObject { get; private set; }
        public DataTreeDoubleClickEventArgs(object dataObject)
            : base()
        {
            DataObject = dataObject;
        }
    }

    public delegate void DataTreeInplaceEditEventHandler(object sender, DataTreeInplaceEditEventArgs e);
    public class DataTreeInplaceEditEventArgs : CancelEventArgs
    {
        public object DataObject { get; private set; }
        public string Text { get; set; }
        public DataTreeInplaceEditEventArgs(object dataObject, string text)
            : base()
        {
            DataObject = dataObject;
            Text = text;
        }
    }
}
