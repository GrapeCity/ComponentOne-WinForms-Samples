//----------------------------------------------------------------------------
// MainForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using System.Globalization;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Linq;

using C1.Win.Ribbon;
using FlexReportDesignerApp.Util;
using C1.Win.Command;
using C1.Win.Localization;
using C1.Win.Themes;
using C1.Util.Licensing;

using C1.Win.FlexReport;
using Doc = C1.Win.Document;
using Flex = C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp
{
    public partial class MainForm : C1RibbonForm,
        ISite,
        IScriptEditorService, IPictureHolderEditorService, ISettingsPersisterService, IGetReportsService,
        ISubreportDesignService, ITooltipService, IScriptValueListService, IThemeService, IDirtyStateService
    {
        #region Private data members
        internal const string DefatulTheme = "builtin:VS2013Light";
        internal const string DefaultFileExt = "flxr";
        private const int cMaxRecentFilesCount = 9;
        private const int DRAG_THRESHOLD = 3;
        private const double cDropFieldWidth = 1440 * 2; // 2 inch
        private const double cDropFieldHeight = 1440 / 3; // 1/3 inch
        private const int cMaxHistoryMenuSize = 10;

        // min/max zoom factors: (1000% is too much for the slider, so we use a narrower interval 10-500):
        private const double cMinZoom = 0.1;
        private const double cMaxZoom = 5;

        // strings:
#if CLR50
        internal const string _regKey = @"Software\ComponentOne\C1FlexReportDesigner.5";
#elif CLR45
        internal const string _regKey = @"Software\ComponentOne\C1FlexReportDesigner.4.5";
#elif CLR40
        internal const string _regKey = @"Software\ComponentOne\C1FlexReportDesigner.4";
#else
#error CLR40 or CLR45 must be defined.
#endif
        //
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

        private static Image s_CustomFieldImage;
        private static readonly float[] cFontSizes = new float[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        public static Font DefaultAppFont;

        private bool _borland = false;
        private bool _dirty = false;
        private bool _lastRenderCancelled = false; // true if user stopped generation of the preview; used to re-generate the report when previewing again
        private string _fileName = string.Empty;
        private bool _fileNameChanged = false; // if true, user will be prompted when saving the file
        private DateTime _fileTimeStamp = DateTime.MinValue;
        private string _createInfo;

        // for use when invoked by C1Report at design time,
        // indicates we're editing a component, not a stand-alone XML file:
        private bool _noFile = false;
        // data schema available to component - passed from VS designer to StartFromDesigner():
        private Hashtable _dataSchema = null;

        // user preferences - TODO!!! move into a separate class!
        private string _theme = string.Empty;
        private C1Theme _cachedTheme = null;
        internal AppConfig _appConfig;
        internal bool _autoSave = false;
        internal bool _loadOnStartUp = true;
        internal bool _restoreEditorSettings = true;
        internal bool _embedImages = true;
        internal bool _insertLegacyField = false;
        internal bool _insertLegacyChart = false;
        internal string _defaultStyleName = string.Empty;
        internal bool _useFieldWrappers = false;
        internal bool _syntaxCheck = true;
        internal bool _syntaxColoring = true;
        internal Font _scriptEditorFont = new Font("Courier New", 9);
        internal Color _scriptEditorBackColor = Color.White;
        internal Color _scriptEditorForeColor = Color.Black;
        internal bool _scriptEditorAutoSave = false;
        internal bool _scriptEditorDataSourceFilterWarning = true;
        internal int _scriptEditorSplitWindowDistance = 0;
        internal string _scriptEditorLastItemKey0 = string.Empty;
        internal string _scriptEditorLastItemKey1 = string.Empty;
        internal bool _openExportedFile = true;
        internal IsolationLevel _isolationLevel = DataSource.c_DefIsolationLevel;
        internal string _optionsStartTabName = string.Empty;

        // drag reports
        private int _downIndex;
        private Point _downPoint;
        private bool _dragSource = false;
        //
        private DataFormats.Format _cfReport = DataFormats.GetFormat("cfC1FlexReport"); // was "cfC1Report"
        //
        private bool _clearOnImport = false;
        private List<C1FlexReport> _importList;
        //
        private bool _reportDesignMode = true;
        private Actions _actions = new Actions();
        //
        private ArrayList _recentFiles;
        //
        private C1DockingTabPage _lastDesignPage;
        //
        private RibbonTab _lastDesignTab;
        // last docking layout in design mode
        private Stream _lastDesignLayout = null;
        // provides zoom scale with 100% in the middle:
        private ZoomSliderScale _zoomSliderScale;
        // "generation" for UpdateDbFieldsDesignerUI (so that it does not update with stale fields):
        private int _fieldsUpdaterGeneration = 0;
        //
        private FlexDesignerHostServices _services;
        /// <summary>
        /// This is used to provide undo when editing property grid.
        /// The state is created when _propGrid is entered, and pushed in _propGrid_PropertyValueChanged,
        /// or discarded in _propGrid's Leave. But because ribbon events do not "leave" active control,
        /// it is also discarded in ribbon event handler.
        /// </summary>
        private object _pendingUndoState = null;
        // flag to handle form close while rendering report:
        private bool _closeRequestedWhileRendering = false;

        // custom fields constants
        private static readonly List<string> CustomFieldsAssemblyAliases = new List<string> {
            "c1.win.flexreport.customfields.4",
            "c1.win.flexreport.customfields.4.5",
            "c1.win.flexreport.customfields.5",
        };

        private static readonly string CustomFieldsAssembly = "C1.Win.FlexReport.CustomFields.5";
        private static readonly string[] CustomFieldsClasses = new string[]
            {
                "C1.Win.FlexReport.CustomFields.SuperLabel",
                "C1.Win.FlexReport.CustomFields.Map",
            };

        private static bool? _customFieldsAssemblyAvailable;

#if MAP
        C1.Win.Ribbon.RibbonToggleButton rbtnFieldMap;
#endif

        public static MainForm TheMainForm { get; private set; }
        #endregion

        #region ctors
        static MainForm()
        {
            s_CustomFieldImage = AppUtils.LoadResourceImage("CustomField.png");
        }

        public MainForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                // this could happen if a dll is missing:
                MessageForm.Show(this, MessageForm.Caption.Fatal, ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Exit(Program.ExitCodes.FatalError);
            }

            TheMainForm = this;

            // FlexDesigner events:
            _flexDesigner.ReportChanged += _flexDesigner_ReportChanged;
            _flexDesigner.ValuesChanged += _flexDesigner_ValuesChanged;
            _flexDesigner.SelectionChanged += _flexDesigner_SelectionChanged;
            _flexDesigner.ZoomFactorChanged += _flexDesigner_ZoomFactorChanged;
            _flexDesigner.CreateField += _flexDesigner_CreateField;
            _flexDesigner.DragDrop += _flexDesigner_DragDrop;
            _flexDesigner.DragOver += _flexDesigner_DragOver;
            _flexDesigner.DoubleClick += _flexDesigner_DoubleClick;
            _flexDesigner.KeyDown += _flexDesigner_KeyDown;
            _flexDesigner.GotFocus += _flexDesigner_GotFocus;
            _flexDesigner.ParagraphEditorLostFocus += _flexDesigner_ParagraphEditorUnfocused;
            _flexDesigner.InplaceEditingChanged += _flexDesigner_InplaceEditingChanged;

            // designer context menu:
            _cmDesigner.Popup += _cmDesigner_Popup;
            _cmDesigner.Closed += _cmDesigner_Closed;

            // Property grid events:
            _propGrid.GotFocus += _propGrid_GotFocus;
            _propGrid.LostFocus += _propGrid_LostFocus;
            _propGrid.Enter += _propGrid_Enter;
            _propGrid.Leave += _propGrid_Leave;
            _propGrid.PropertyValueChanged += _propGrid_PropertyValueChanged;

            // Provide host services to the designer control:
            _services = new FlexDesignerHostServices();
            _services.AddService(typeof(IGetReportsService), this);
            _services.AddService(typeof(IScriptEditorService), this);
            _services.AddService(typeof(ISettingsPersisterService), this);
            _services.AddService(typeof(ISubreportDesignService), this);
            _services.AddService(typeof(ITooltipService), this);
            _services.AddService(typeof(IScriptValueListService), this);
            _services.AddService(typeof(IThemeService), this);
            _services.AddService(typeof(IPictureHolderEditorService), this);
            _services.AddService(typeof(IDirtyStateService), this);
            _flexDesigner.HostServices = _services;
            //
            EditorsHelper.SetServicesOwner(_services);

            // Set up data tree/wire up its events:
            _dataTree.FlexDesigner = _flexDesigner;
            _dataTree.SetServices(_services);
            _dataTree.SelectedDataObjectChanged += _dataTree_SelectedDataObjectChanged;
            _dataTree.InplaceEditBegin += _dataTree_InplaceEditBegin;
            _dataTree.InplaceEditEnd += _dataTree_InplaceEditEnd;
            _dataTree.DataObjectDoubleClick += _dataTree_DataObjectDoubleClick;
            UpdateDataTreeUI();

            _errorList.SetServices(_services);
            _errorList.SelectionChanged += (s_, e_) => UpdatedErrorListUI();

            _flexDesigner.MouseDown += _flexDesigner_MouseDown;


            this.ramMain.Text = Strings.MainForm.RibbonApplicationButton;

            // Prepare C1FlexReport instance used by the preview:
            InitializeReportRender();

            rbtnCheckForUpdates.Visible = false;
            // set up reasonable initial size/position (will be overwritten if saved state exists):
            Screen scrn = System.Windows.Forms.Screen.FromPoint(Point.Empty);
            this.Location = Point.Empty;
            this.Location = new Point((int)(scrn.Bounds.Width * 0.1), (int)(scrn.Bounds.Height * 0.1));
            this.Size = new Size((int)(scrn.Bounds.Width * 0.8), (int)(scrn.Bounds.Height * 0.8));
            this.MinimumSize = new Size(400, 300);
            // zoom slider:
            Debug.Assert(cMinZoom >= Math.Round(Math.Max(_flexDesigner.MinZoomFactor, _flexViewer.MinZoomFactor)));
            Debug.Assert(cMaxZoom <= Math.Round(Math.Min(_flexDesigner.MaxZoomFactor, _flexViewer.MaxZoomFactor)));
            _zoomSliderScale = new ZoomSliderScale(cMinZoom, cMaxZoom, rtbZoom.Minimum, rtbZoom.Maximum);
            //
            DefaultAppFont = SystemInformation.MenuFont;
            AutoScaleMode = AutoScaleMode.None;
            Font = DefaultAppFont;
            // activate dtpPages tab by default
            _lastDesignPage = dtpReports;
            _lastDesignPage.Show();
            //
            _lastDesignTab = rtDesign;
            // fill rcbFontSize
            for (int i = 0; i < cFontSizes.Length; i++)
                rcbFontSize.Items.Add(new RibbonButton(cFontSizes[i].ToString()));
            //
            BorderWidthSetup();
            // 
            InitActions();
            //
            UpdateFormCaption();
        }

        /// <summary>
        /// Resets the design mode tabs layout to the default one:
        /// </summary>
        internal void ResetDesignerLayout()
        {
            if (!ReportDesignMode)
                return; // we don't want to screw up preview layout

            // This was copied from DockPanelsState in the .settings file after running w/out one:
            const string dps =
                // "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4NCjxBbGxEb2NraW5nVGFicyB4bWxuczp4c2k9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hLWluc3RhbmNlIiB4bWxuczp4c2Q9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hIj4NCiAgPENvbW1hbmREb2Nrcz4NCiAgICA8QzFDb21tYW5kRG9ja1JlZmxlY3Rvcj4NCiAgICAgIDxJZD4xPC9JZD4NCiAgICAgIDxOYW1lPmMxQ29tbWFuZERvY2sxPC9OYW1lPg0KICAgICAgPFNpemU+DQogICAgICAgIDxXaWR0aD4yNzQ8L1dpZHRoPg0KICAgICAgICA8SGVpZ2h0Pjk4NDwvSGVpZ2h0Pg0KICAgICAgPC9TaXplPg0KICAgICAgPEJhY2tDb2xvcj4tMTExODQ3ODwvQmFja0NvbG9yPg0KICAgICAgPERvY2tpbmdUYWJzPg0KICAgICAgICA8QzFEb2NraW5nVGFiUmVmbGVjdG9yPg0KICAgICAgICAgIDxEb2NraW5nVGFiUGFnZXM+DQogICAgICAgICAgICA8QzFEb2NraW5nVGFiUGFnZVJlZmxlY3Rvcj4NCiAgICAgICAgICAgICAgPE5hbWU+ZHRwUHJvcGVydGllczwvTmFtZT4NCiAgICAgICAgICAgICAgPFRhYlZpc2libGU+dHJ1ZTwvVGFiVmlzaWJsZT4NCiAgICAgICAgICAgICAgPENoaWxkSW5kZXg+MDwvQ2hpbGRJbmRleD4NCiAgICAgICAgICAgIDwvQzFEb2NraW5nVGFiUGFnZVJlZmxlY3Rvcj4NCiAgICAgICAgICA8L0RvY2tpbmdUYWJQYWdlcz4NCiAgICAgICAgICA8TmFtZT5jMURvY2tpbmdUYWIyPC9OYW1lPg0KICAgICAgICAgIDxDcmVhdG9yRG9ja2luZ1RhYiAvPg0KICAgICAgICAgIDxTaXplPg0KICAgICAgICAgICAgPFdpZHRoPjI3NDwvV2lkdGg+DQogICAgICAgICAgICA8SGVpZ2h0PjUxMDwvSGVpZ2h0Pg0KICAgICAgICAgIDwvU2l6ZT4NCiAgICAgICAgICA8U2xpZGVTaXplPjIwMDwvU2xpZGVTaXplPg0KICAgICAgICAgIDxPbGRCb3VuZHM+DQogICAgICAgICAgICA8TG9jYXRpb24+DQogICAgICAgICAgICAgIDxYPjA8L1g+DQogICAgICAgICAgICAgIDxZPjA8L1k+DQogICAgICAgICAgICA8L0xvY2F0aW9uPg0KICAgICAgICAgICAgPFNpemU+DQogICAgICAgICAgICAgIDxXaWR0aD4wPC9XaWR0aD4NCiAgICAgICAgICAgICAgPEhlaWdodD4wPC9IZWlnaHQ+DQogICAgICAgICAgICA8L1NpemU+DQogICAgICAgICAgICA8WD4wPC9YPg0KICAgICAgICAgICAgPFk+MDwvWT4NCiAgICAgICAgICAgIDxXaWR0aD4wPC9XaWR0aD4NCiAgICAgICAgICAgIDxIZWlnaHQ+MDwvSGVpZ2h0Pg0KICAgICAgICAgIDwvT2xkQm91bmRzPg0KICAgICAgICAgIDxMb2NhdGlvbj4NCiAgICAgICAgICAgIDxYPjA8L1g+DQogICAgICAgICAgICA8WT40NzU8L1k+DQogICAgICAgICAgPC9Mb2NhdGlvbj4NCiAgICAgICAgICA8UGFyZW50TG9jYXRpb24+DQogICAgICAgICAgICA8WD4wPC9YPg0KICAgICAgICAgICAgPFk+MTQ2PC9ZPg0KICAgICAgICAgIDwvUGFyZW50TG9jYXRpb24+DQogICAgICAgICAgPEF1dG9IaWRpbmc+ZmFsc2U8L0F1dG9IaWRpbmc+DQogICAgICAgICAgPEZsb2F0aW5nPmZhbHNlPC9GbG9hdGluZz4NCiAgICAgICAgICA8U2VsZWN0ZWRJbmRleD4wPC9TZWxlY3RlZEluZGV4Pg0KICAgICAgICA8L0MxRG9ja2luZ1RhYlJlZmxlY3Rvcj4NCiAgICAgICAgPEMxRG9ja2luZ1RhYlJlZmxlY3Rvcj4NCiAgICAgICAgICA8RG9ja2luZ1RhYlBhZ2VzPg0KICAgICAgICAgICAgPEMxRG9ja2luZ1RhYlBhZ2VSZWZsZWN0b3I+DQogICAgICAgICAgICAgIDxOYW1lPmR0cFJlcG9ydHM8L05hbWU+DQogICAgICAgICAgICAgIDxUYWJWaXNpYmxlPnRydWU8L1RhYlZpc2libGU+DQogICAgICAgICAgICAgIDxDaGlsZEluZGV4PjA8L0NoaWxkSW5kZXg+DQogICAgICAgICAgICA8L0MxRG9ja2luZ1RhYlBhZ2VSZWZsZWN0b3I+DQogICAgICAgICAgICA8QzFEb2NraW5nVGFiUGFnZVJlZmxlY3Rvcj4NCiAgICAgICAgICAgICAgPE5hbWU+ZHRwRGF0YTwvTmFtZT4NCiAgICAgICAgICAgICAgPFRhYlZpc2libGU+dHJ1ZTwvVGFiVmlzaWJsZT4NCiAgICAgICAgICAgICAgPENoaWxkSW5kZXg+MTwvQ2hpbGRJbmRleD4NCiAgICAgICAgICAgIDwvQzFEb2NraW5nVGFiUGFnZVJlZmxlY3Rvcj4NCiAgICAgICAgICA8L0RvY2tpbmdUYWJQYWdlcz4NCiAgICAgICAgICA8TmFtZT5jMURvY2tpbmdUYWIxPC9OYW1lPg0KICAgICAgICAgIDxDcmVhdG9yRG9ja2luZ1RhYiAvPg0KICAgICAgICAgIDxTaXplPg0KICAgICAgICAgICAgPFdpZHRoPjI3NDwvV2lkdGg+DQogICAgICAgICAgICA8SGVpZ2h0PjQ3NTwvSGVpZ2h0Pg0KICAgICAgICAgIDwvU2l6ZT4NCiAgICAgICAgICA8U2xpZGVTaXplPjIwMDwvU2xpZGVTaXplPg0KICAgICAgICAgIDxPbGRCb3VuZHM+DQogICAgICAgICAgICA8TG9jYXRpb24+DQogICAgICAgICAgICAgIDxYPjA8L1g+DQogICAgICAgICAgICAgIDxZPjA8L1k+DQogICAgICAgICAgICA8L0xvY2F0aW9uPg0KICAgICAgICAgICAgPFNpemU+DQogICAgICAgICAgICAgIDxXaWR0aD4wPC9XaWR0aD4NCiAgICAgICAgICAgICAgPEhlaWdodD4wPC9IZWlnaHQ+DQogICAgICAgICAgICA8L1NpemU+DQogICAgICAgICAgICA8WD4wPC9YPg0KICAgICAgICAgICAgPFk+MDwvWT4NCiAgICAgICAgICAgIDxXaWR0aD4wPC9XaWR0aD4NCiAgICAgICAgICAgIDxIZWlnaHQ+MDwvSGVpZ2h0Pg0KICAgICAgICAgIDwvT2xkQm91bmRzPg0KICAgICAgICAgIDxMb2NhdGlvbj4NCiAgICAgICAgICAgIDxYPjA8L1g+DQogICAgICAgICAgICA8WT4wPC9ZPg0KICAgICAgICAgIDwvTG9jYXRpb24+DQogICAgICAgICAgPFBhcmVudExvY2F0aW9uPg0KICAgICAgICAgICAgPFg+MDwvWD4NCiAgICAgICAgICAgIDxZPjE0NjwvWT4NCiAgICAgICAgICA8L1BhcmVudExvY2F0aW9uPg0KICAgICAgICAgIDxBdXRvSGlkaW5nPmZhbHNlPC9BdXRvSGlkaW5nPg0KICAgICAgICAgIDxGbG9hdGluZz5mYWxzZTwvRmxvYXRpbmc+DQogICAgICAgICAgPFNlbGVjdGVkSW5kZXg+MDwvU2VsZWN0ZWRJbmRleD4NCiAgICAgICAgPC9DMURvY2tpbmdUYWJSZWZsZWN0b3I+DQogICAgICA8L0RvY2tpbmdUYWJzPg0KICAgIDwvQzFDb21tYW5kRG9ja1JlZmxlY3Rvcj4NCiAgPC9Db21tYW5kRG9ja3M+DQo8L0FsbERvY2tpbmdUYWJzPg==";
                "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4NCjxBbGxEb2NraW5nVGFicyB4bWxuczp4c2k9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hLWluc3RhbmNlIiB4bWxuczp4c2Q9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hIj4NCiAgPENvbW1hbmREb2Nrcz4NCiAgICA8QzFDb21tYW5kRG9ja1JlZmxlY3Rvcj4NCiAgICAgIDxJZD4tNzwvSWQ+DQogICAgICA8TmFtZSAvPg0KICAgICAgPFNpemU+DQogICAgICAgIDxXaWR0aD4xNDA2PC9XaWR0aD4NCiAgICAgICAgPEhlaWdodD4yMzA8L0hlaWdodD4NCiAgICAgIDwvU2l6ZT4NCiAgICAgIDxCYWNrQ29sb3I+LTExMTg0Nzg8L0JhY2tDb2xvcj4NCiAgICAgIDxEb2NraW5nVGFicz4NCiAgICAgICAgPEMxRG9ja2luZ1RhYlJlZmxlY3Rvcj4NCiAgICAgICAgICA8RG9ja2luZ1RhYlBhZ2VzPg0KICAgICAgICAgICAgPEMxRG9ja2luZ1RhYlBhZ2VSZWZsZWN0b3I+DQogICAgICAgICAgICAgIDxOYW1lPmR0cEVycm9yczwvTmFtZT4NCiAgICAgICAgICAgICAgPFRhYlZpc2libGU+dHJ1ZTwvVGFiVmlzaWJsZT4NCiAgICAgICAgICAgICAgPENoaWxkSW5kZXg+MDwvQ2hpbGRJbmRleD4NCiAgICAgICAgICAgIDwvQzFEb2NraW5nVGFiUGFnZVJlZmxlY3Rvcj4NCiAgICAgICAgICA8L0RvY2tpbmdUYWJQYWdlcz4NCiAgICAgICAgICA8TmFtZT5EdW1teV8xODY0PC9OYW1lPg0KICAgICAgICAgIDxDcmVhdG9yRG9ja2luZ1RhYj5jMURvY2tpbmdUYWIxPC9DcmVhdG9yRG9ja2luZ1RhYj4NCiAgICAgICAgICA8U2l6ZT4NCiAgICAgICAgICAgIDxXaWR0aD4xNDA2PC9XaWR0aD4NCiAgICAgICAgICAgIDxIZWlnaHQ+MjMwPC9IZWlnaHQ+DQogICAgICAgICAgPC9TaXplPg0KICAgICAgICAgIDxTbGlkZVNpemU+MjAwPC9TbGlkZVNpemU+DQogICAgICAgICAgPE9sZEJvdW5kcz4NCiAgICAgICAgICAgIDxMb2NhdGlvbj4NCiAgICAgICAgICAgICAgPFg+MDwvWD4NCiAgICAgICAgICAgICAgPFk+MDwvWT4NCiAgICAgICAgICAgIDwvTG9jYXRpb24+DQogICAgICAgICAgICA8U2l6ZT4NCiAgICAgICAgICAgICAgPFdpZHRoPjA8L1dpZHRoPg0KICAgICAgICAgICAgICA8SGVpZ2h0PjA8L0hlaWdodD4NCiAgICAgICAgICAgIDwvU2l6ZT4NCiAgICAgICAgICAgIDxYPjA8L1g+DQogICAgICAgICAgICA8WT4wPC9ZPg0KICAgICAgICAgICAgPFdpZHRoPjA8L1dpZHRoPg0KICAgICAgICAgICAgPEhlaWdodD4wPC9IZWlnaHQ+DQogICAgICAgICAgPC9PbGRCb3VuZHM+DQogICAgICAgICAgPExvY2F0aW9uPg0KICAgICAgICAgICAgPFg+MDwvWD4NCiAgICAgICAgICAgIDxZPjA8L1k+DQogICAgICAgICAgPC9Mb2NhdGlvbj4NCiAgICAgICAgICA8UGFyZW50TG9jYXRpb24+DQogICAgICAgICAgICA8WD4zMzU8L1g+DQogICAgICAgICAgICA8WT45ODI8L1k+DQogICAgICAgICAgPC9QYXJlbnRMb2NhdGlvbj4NCiAgICAgICAgICA8QXV0b0hpZGluZz5mYWxzZTwvQXV0b0hpZGluZz4NCiAgICAgICAgICA8RmxvYXRpbmc+ZmFsc2U8L0Zsb2F0aW5nPg0KICAgICAgICAgIDxTZWxlY3RlZEluZGV4PjA8L1NlbGVjdGVkSW5kZXg+DQogICAgICAgIDwvQzFEb2NraW5nVGFiUmVmbGVjdG9yPg0KICAgICAgPC9Eb2NraW5nVGFicz4NCiAgICA8L0MxQ29tbWFuZERvY2tSZWZsZWN0b3I+DQogICAgPEMxQ29tbWFuZERvY2tSZWZsZWN0b3I+DQogICAgICA8SWQ+MTwvSWQ+DQogICAgICA8TmFtZT5jMUNvbW1hbmREb2NrMTwvTmFtZT4NCiAgICAgIDxTaXplPg0KICAgICAgICA8V2lkdGg+MzM1PC9XaWR0aD4NCiAgICAgICAgPEhlaWdodD4xMDY2PC9IZWlnaHQ+DQogICAgICA8L1NpemU+DQogICAgICA8QmFja0NvbG9yPi0xMTE4NDc4PC9CYWNrQ29sb3I+DQogICAgICA8RG9ja2luZ1RhYnM+DQogICAgICAgIDxDMURvY2tpbmdUYWJSZWZsZWN0b3I+DQogICAgICAgICAgPERvY2tpbmdUYWJQYWdlcz4NCiAgICAgICAgICAgIDxDMURvY2tpbmdUYWJQYWdlUmVmbGVjdG9yPg0KICAgICAgICAgICAgICA8TmFtZT5kdHBQcm9wZXJ0aWVzPC9OYW1lPg0KICAgICAgICAgICAgICA8VGFiVmlzaWJsZT50cnVlPC9UYWJWaXNpYmxlPg0KICAgICAgICAgICAgICA8Q2hpbGRJbmRleD4wPC9DaGlsZEluZGV4Pg0KICAgICAgICAgICAgPC9DMURvY2tpbmdUYWJQYWdlUmVmbGVjdG9yPg0KICAgICAgICAgIDwvRG9ja2luZ1RhYlBhZ2VzPg0KICAgICAgICAgIDxOYW1lPmMxRG9ja2luZ1RhYjI8L05hbWU+DQogICAgICAgICAgPENyZWF0b3JEb2NraW5nVGFiIC8+DQogICAgICAgICAgPFNpemU+DQogICAgICAgICAgICA8V2lkdGg+MzM1PC9XaWR0aD4NCiAgICAgICAgICAgIDxIZWlnaHQ+NjA0PC9IZWlnaHQ+DQogICAgICAgICAgPC9TaXplPg0KICAgICAgICAgIDxTbGlkZVNpemU+MjAwPC9TbGlkZVNpemU+DQogICAgICAgICAgPE9sZEJvdW5kcz4NCiAgICAgICAgICAgIDxMb2NhdGlvbj4NCiAgICAgICAgICAgICAgPFg+MDwvWD4NCiAgICAgICAgICAgICAgPFk+MDwvWT4NCiAgICAgICAgICAgIDwvTG9jYXRpb24+DQogICAgICAgICAgICA8U2l6ZT4NCiAgICAgICAgICAgICAgPFdpZHRoPjA8L1dpZHRoPg0KICAgICAgICAgICAgICA8SGVpZ2h0PjA8L0hlaWdodD4NCiAgICAgICAgICAgIDwvU2l6ZT4NCiAgICAgICAgICAgIDxYPjA8L1g+DQogICAgICAgICAgICA8WT4wPC9ZPg0KICAgICAgICAgICAgPFdpZHRoPjA8L1dpZHRoPg0KICAgICAgICAgICAgPEhlaWdodD4wPC9IZWlnaHQ+DQogICAgICAgICAgPC9PbGRCb3VuZHM+DQogICAgICAgICAgPExvY2F0aW9uPg0KICAgICAgICAgICAgPFg+MDwvWD4NCiAgICAgICAgICAgIDxZPjQ2MzwvWT4NCiAgICAgICAgICA8L0xvY2F0aW9uPg0KICAgICAgICAgIDxQYXJlbnRMb2NhdGlvbj4NCiAgICAgICAgICAgIDxYPjA8L1g+DQogICAgICAgICAgICA8WT4xNDY8L1k+DQogICAgICAgICAgPC9QYXJlbnRMb2NhdGlvbj4NCiAgICAgICAgICA8QXV0b0hpZGluZz5mYWxzZTwvQXV0b0hpZGluZz4NCiAgICAgICAgICA8RmxvYXRpbmc+ZmFsc2U8L0Zsb2F0aW5nPg0KICAgICAgICAgIDxTZWxlY3RlZEluZGV4PjA8L1NlbGVjdGVkSW5kZXg+DQogICAgICAgIDwvQzFEb2NraW5nVGFiUmVmbGVjdG9yPg0KICAgICAgICA8QzFEb2NraW5nVGFiUmVmbGVjdG9yPg0KICAgICAgICAgIDxEb2NraW5nVGFiUGFnZXM+DQogICAgICAgICAgICA8QzFEb2NraW5nVGFiUGFnZVJlZmxlY3Rvcj4NCiAgICAgICAgICAgICAgPE5hbWU+ZHRwUmVwb3J0czwvTmFtZT4NCiAgICAgICAgICAgICAgPFRhYlZpc2libGU+dHJ1ZTwvVGFiVmlzaWJsZT4NCiAgICAgICAgICAgICAgPENoaWxkSW5kZXg+MDwvQ2hpbGRJbmRleD4NCiAgICAgICAgICAgIDwvQzFEb2NraW5nVGFiUGFnZVJlZmxlY3Rvcj4NCiAgICAgICAgICAgIDxDMURvY2tpbmdUYWJQYWdlUmVmbGVjdG9yPg0KICAgICAgICAgICAgICA8TmFtZT5kdHBEYXRhPC9OYW1lPg0KICAgICAgICAgICAgICA8VGFiVmlzaWJsZT50cnVlPC9UYWJWaXNpYmxlPg0KICAgICAgICAgICAgICA8Q2hpbGRJbmRleD4xPC9DaGlsZEluZGV4Pg0KICAgICAgICAgICAgPC9DMURvY2tpbmdUYWJQYWdlUmVmbGVjdG9yPg0KICAgICAgICAgIDwvRG9ja2luZ1RhYlBhZ2VzPg0KICAgICAgICAgIDxOYW1lPmMxRG9ja2luZ1RhYjE8L05hbWU+DQogICAgICAgICAgPENyZWF0b3JEb2NraW5nVGFiIC8+DQogICAgICAgICAgPFNpemU+DQogICAgICAgICAgICA8V2lkdGg+MzM1PC9XaWR0aD4NCiAgICAgICAgICAgIDxIZWlnaHQ+NDYzPC9IZWlnaHQ+DQogICAgICAgICAgPC9TaXplPg0KICAgICAgICAgIDxTbGlkZVNpemU+MjAwPC9TbGlkZVNpemU+DQogICAgICAgICAgPE9sZEJvdW5kcz4NCiAgICAgICAgICAgIDxMb2NhdGlvbj4NCiAgICAgICAgICAgICAgPFg+MDwvWD4NCiAgICAgICAgICAgICAgPFk+MDwvWT4NCiAgICAgICAgICAgIDwvTG9jYXRpb24+DQogICAgICAgICAgICA8U2l6ZT4NCiAgICAgICAgICAgICAgPFdpZHRoPjA8L1dpZHRoPg0KICAgICAgICAgICAgICA8SGVpZ2h0PjA8L0hlaWdodD4NCiAgICAgICAgICAgIDwvU2l6ZT4NCiAgICAgICAgICAgIDxYPjA8L1g+DQogICAgICAgICAgICA8WT4wPC9ZPg0KICAgICAgICAgICAgPFdpZHRoPjA8L1dpZHRoPg0KICAgICAgICAgICAgPEhlaWdodD4wPC9IZWlnaHQ+DQogICAgICAgICAgPC9PbGRCb3VuZHM+DQogICAgICAgICAgPExvY2F0aW9uPg0KICAgICAgICAgICAgPFg+MDwvWD4NCiAgICAgICAgICAgIDxZPjA8L1k+DQogICAgICAgICAgPC9Mb2NhdGlvbj4NCiAgICAgICAgICA8UGFyZW50TG9jYXRpb24+DQogICAgICAgICAgICA8WD4wPC9YPg0KICAgICAgICAgICAgPFk+MTQ2PC9ZPg0KICAgICAgICAgIDwvUGFyZW50TG9jYXRpb24+DQogICAgICAgICAgPEF1dG9IaWRpbmc+ZmFsc2U8L0F1dG9IaWRpbmc+DQogICAgICAgICAgPEZsb2F0aW5nPmZhbHNlPC9GbG9hdGluZz4NCiAgICAgICAgICA8U2VsZWN0ZWRJbmRleD4wPC9TZWxlY3RlZEluZGV4Pg0KICAgICAgICA8L0MxRG9ja2luZ1RhYlJlZmxlY3Rvcj4NCiAgICAgIDwvRG9ja2luZ1RhYnM+DQogICAgPC9DMUNvbW1hbmREb2NrUmVmbGVjdG9yPg0KICA8L0NvbW1hbmREb2Nrcz4NCjwvQWxsRG9ja2luZ1RhYnM+";

            // seems like sometimes once is not enough while twice does it:
            Action restore = () =>
               {
                   using (MemoryStream ms = new MemoryStream())
                   {
                       byte[] data = System.Convert.FromBase64String(dps);
                       ms.Write(data, 0, data.Length);
                       ms.Seek(0, SeekOrigin.Begin);
                       C1.Win.Command.C1DockingTab.RestoreLayout(this, ms);
                   }
               };
            restore();
            restore();
            _errorList.ResetSettings();
        }

        internal string ErrorListSettings
        {
            get { return _errorList.Settings; }
            set { _errorList.Settings = value; }
        }

        /// <summary>
        /// Tracks changes in the currently active control.
        /// http://www.codeproject.com/Tips/552519/Detect-Change-In-ActiveControl
        /// </summary>
        protected override void UpdateDefaultButton()
        {
            base.UpdateDefaultButton();
            // System.Diagnostics.Debug.WriteLine("=============UpdateDefaultButton, active: " + this.ActiveControl == null ? "NULL" : this.ActiveControl.ToString());
            if (_flexDesigner.IsInplaceParagraphEditing)
            {
                if (EndParagraphEditing(ActiveControl))
                    _flexDesigner.EndInplaceParagraphEditing(false);
            }
        }

        void _flexDesigner_ParagraphEditorUnfocused(object sender, CancelEventArgs e)
        {
            // If we are not active, close inplace anyway:
            if (AppUtils.ApplicationIsActive())
                e.Cancel = !EndParagraphEditing(ActiveControl);
        }
        /// <summary>
        /// Called when active control changes while paragraph editing is going on.
        /// Returns true if paragraph editing must stop.
        /// Returns false when the new active control is prop grid, ribbon or the para editor itself.
        /// </summary>
        /// <param name="newActiveControl"></param>
        /// <returns></returns>
        private bool EndParagraphEditing(Control newActiveControl)
        {
            if (newActiveControl == null)
                return true;
            if (newActiveControl == _flexDesigner.ActiveInplaceEditor)
                return false;
            if (newActiveControl == _propGrid)
                return false;
            if (newActiveControl.GetType().AssemblyQualifiedName.ToLower().StartsWith("c1.win.ribbon"))
                return false;
            return true;
        }
        #endregion

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                MainForm_Load();
            }
            catch (Exception ex)
            {
                string msg;
                if (ex.InnerException != null)
                    msg = string.Format(CultureInfo.InvariantCulture,
                        Strings.MainForm.FatalExcInnerFmt,
                        ex.Message,
                        ex.InnerException);
                else
                    msg = string.Format(CultureInfo.InvariantCulture,
                        Strings.MainForm.FatalExcFmt,
                        ex.Message);
                MessageForm.Fatal(msg);
            }
            base.OnLoad(e);
        }

        private void MainForm_Load()
        {
            // load recent connections from registry if the
            // configuration file is empty (easier upgrade)
            ArrayList list = AppSettings.LoadList("recentconnections", MessageForm.Warn);
            if (list.Count == 0)
            {
                string subKey = _regKey + @"\Recent Connection List";
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(subKey))
                {
                    if (key != null)
                    {
                        string connList = key.GetValue("MRU", string.Empty) as string;
                        foreach (string conn in connList.Split('\t'))
                            if (conn.Length > 0 && !list.Contains(conn))
                                list.Add(conn);
                        AppSettings.SaveList("recentconnections", list, true, MessageForm.Warn);
                    }
                }
            }

            // Initialize and load saved (if any) application state:
            //
            // I could not arrange the error list properly in VS designer,
            // this loads a good layout created/saved at runtime:
            ResetDesignerLayout();

            // but we hide the error window initially:
            dtpErrors.TabVisible = false;

            // Finally, load the saved application state - if there was a previously saved layout,
            // it will overwrite the default just loaded:
            _appConfig = new AppConfig(this);
            _appConfig.LoadAppState();

            // Hide (hopefully) legacy fields:
            rbtnFieldLegacy.Visible = _insertLegacyField;
            rbtnFieldChart.Visible = _insertLegacyChart;

#if MAP
            rbtnFieldMap = new C1.Win.Ribbon.RibbonToggleButton();
            rbtnFieldMap.KeyTip = "M";
            rbtnFieldMap.Name = "rbtnMap";
            rbtnFieldMap.Text = "Map Field";
            rbtnFieldMap.ToolTip = "Map Field";
            this.rgFields.Items.Add(rbtnFieldMap);
#endif

            // default theme:
            if (string.IsNullOrEmpty(Theme))
                Theme = DefatulTheme;

            if (this.dtpReports.Parent == null)
                this.c1DockingTab1.Controls.Add(this.dtpReports);
            if (this.dtpData.Parent == null)
                this.c1DockingTab1.Controls.Add(this.dtpData);
            if (this.dtpProperties.Parent == null)
                this.c1DockingTab2.Controls.Add(this.dtpProperties);
            this.c1DockingTab1.Visible = true;

            // start in design mode
            SetDesignMode(true);

            // Insert 'mode' group (design/preview) into all tabs:
            rtInsert.Groups.Insert(0, rgMode);
            rtArrange.Groups.Insert(0, rgMode);
            rtPageSetup.Groups.Insert(0, rgMode);
            rtPreview.Groups.Insert(0, rgMode);

            // initialize main menu
            InitRecentFiles();

            // initialize custom fields
            LoadCustomFields();

            // initialize UI
            UpdateUI(true);

            // activate designer
            _flexDesigner.Select();

            // starting from designer: load info from temp files, configure designer
            if (StartFromDesigner())
                return;

            // load file specified in command line
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1 && File.Exists(args[1]))
                OpenFile(args[1]);
            else
            {
                // reload last file (quietly)
                if (_loadOnStartUp)
                {
                    var fileName = AppSettings.LoadValue(AppSettings.c_lastLoadedFile);
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        try
                        {
                            OpenFileInternal(fileName, true);
                            // load editor's transient state (scroll pos etc):
                            if (_restoreEditorSettings)
                            {
                                AppSettings.LoadObject(AppConfig.c_nodeEditorTransState, _flexDesigner.TransientState);
                                _flexDesigner.TransientState.Apply();
                            }
                        }
                        catch
                        {
                            // eat errors, remove from recent list:
                            DeleteRecentFile(fileName);
                        }
                    }
                }
            }

        }

        protected override void OnShown(EventArgs e)
        {
            HideSpash();
            // Warn if we're running in 64 bit mode (with the 'dont show this again' option):
            if (IntPtr.Size == 8)
                MessageForm.Show(this, MessageForm.Caption.Message, Strings.MainForm.AppIn64bitModeWarning, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageForm.MessageKey.WarnAppIn64bitMode);
            base.OnShown(e);
        }

        private bool _inOnActivated = false;
        protected override void OnActivated(EventArgs e)
        {
            if (_inOnActivated)
                return;
            _inOnActivated = true;
            try
            {
                base.OnActivated(e);
                if (!string.IsNullOrEmpty(_fileName) && !_fileNameChanged && _fileTimeStamp != File.GetLastWriteTimeUtc(_fileName))
                {
                    string msg;
                    if (_dirty)
                        msg = string.Format(Strings.MainForm.OutsideChangedFileModFmt, _fileName);
                    else
                        msg = string.Format(Strings.MainForm.OutsideFileModFmt, _fileName);
                    if (MessageForm.Ask(msg, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        OpenFileInternal(_fileName, true);
                    else
                        _fileNameChanged = true;
                }
            }
            catch (Exception ex)
            {
                MessageForm.Warn(string.Format(Strings.MainForm.ErrCannotLoadReportFmt, _fileName, ex.Message));
                _dirty = true;
                _fileNameChanged = true;
                UpdateUI(false);
            }
            finally
            {
                _inOnActivated = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // if form is closed while rendering, raise the flag and bail out;
            // close will be re-posted by the timer:
            if (IsPreviewRendering)
            {
                DoPreviewStop();
                _closeRequestedWhileRendering = true;
                e.Cancel = true;
                return;
            }

            // when editing temp file, save changes and quit
            if (_noFile)
            {
                // confirm discarding changes
                if (_dirty)
                {
                    // prompt user
                    switch (MessageForm.Ask(Strings.MainForm.SaveChangesTempFileQ, MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.No:
                            AppUtils.DeleteFile(_fileName);
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            return;
                        default:
                            // default behavior, save and exit
                            SaveFile(false);
                            break;
                    }
                }
            }
            else
            {
                // make sure we won't lose our changes
                if (!DiscardChangesOK())
                {
                    e.Cancel = true;
                    return;
                }
            }
            //
            _timer.Stop();
            _timerUpdateNeeded = false;
            // save app state for next time
            _appConfig.SaveAppState();
            // allow the designer control to shut down its render loop w/out exceptions (patch):
            _flexDesigner.ShuttingDown();
            //
            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // dispose resources
            if (_lastDesignLayout != null)
                _lastDesignLayout.Dispose();
            //
            base.OnFormClosed(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.None)
            {
                _flexDesigner.Scroll(0, e.Delta * 0.2f);
            }
            if (Control.ModifierKeys == Keys.Control)
            {
                var zf = _flexDesigner.ZoomFactor;
                zf += e.Delta * 0.001f;
                _flexDesigner.ZoomFactor = zf;
            }
            //
            base.OnMouseWheel(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode | e.Modifiers)
            {
                case Keys.Escape:
                    if (!rbnMain.KeyTipsVisible)
                    {
                        if (ReportDesignMode)
                        {
                            _flexDesigner.CreateFieldInfo = null;
                            _createInfo = null;
                            if (!_flexDesigner.ContainsFocus)
                            {
                                var inplaceEditor = _flexDesigner.ActiveInplaceEditor;
                                if (inplaceEditor != null)
                                    inplaceEditor.Focus();
                                else
                                    _flexDesigner.Focus();
                            }
                            else
                            {
                                UpdateCreateFieldButtons(rbtnFieldArrow);
                                _flexDesigner.DoEscape();
                            }
                        }
                        else if (IsPreviewRendering && _reportRender.IsBusy)
                        {
                            DoPreviewStop();
                            e.Handled = true;
                        }
                    }
                    break;
                case Keys.F2:
                    if (_dataTree.Focused)
                    {
                        // if (_dataTree.CanInplaceEdit) - let data tree handle this
                        _dataTree.StartInplaceEdit();
                        e.Handled = true;
                    }
                    break;
                // Delete
                case Keys.Delete:
                    if (_reportList.Focused)
                    {
                        if (_actions[ActionTypeEnum.DeleteReport].Enabled)
                        {
                            DoDeleteReport();
                            e.Handled = true;
                        }
                    }
                    else if (_dataTree.Focused)
                    {
                        DoDataTreeDelete();
                        e.Handled = true;
                    }
                    break;
                case Keys.Insert:
                    if (_dataTree.Focused)
                    {
                        DoDataTreeInsert();
                        e.Handled = true;
                    }
                    break;
                // Cut
                case Keys.Delete | Keys.Shift:
                case Keys.X | Keys.Control:
                    if (_reportList.Focused && _actions[ActionTypeEnum.CutReport].Enabled)
                    {
                        DoCutReport();
                        e.Handled = true;
                    }
                    break;
                // Copy
                case Keys.C | Keys.Control:
                case Keys.Insert | Keys.Control:
                    if (_reportList.Focused && _actions[ActionTypeEnum.CopyReport].Enabled)
                    {
                        DoCopyReport();
                        e.Handled = true;
                    }
                    else if (!ReportDesignMode && _actions[ActionTypeEnum.Copy].Enabled)
                    {
                        cPreviewCopy.PerformClick();
                    }
                    break;
                // Paste
                case Keys.Insert | Keys.Shift:
                case Keys.V | Keys.Control:
                    if (_reportList.Focused && _actions[ActionTypeEnum.PasteReport].Enabled)
                    {
                        DoPasteReport();
                        e.Handled = true;
                    }
                    break;
                // New
                case Keys.N | Keys.Control:
                    if (ReportDesignMode && _flexDesigner.IsInplaceEditing)
                        break; // patch - we have KeyPreview = true, hence get keys first...
                    if (_actions[ActionTypeEnum.New].Enabled)
                    {
                        DoNew();
                        e.Handled = true;
                    }
                    break;
                // New report
                case Keys.N | Keys.Control | Keys.Shift:
                    if (_actions[ActionTypeEnum.NewReportWizard].Enabled)
                    {
                        AddWizardReport();
                        e.Handled = true;
                    }
                    break;
                // Open
                case Keys.O | Keys.Control:
                    if (_actions[ActionTypeEnum.Open].Enabled)
                    {
                        DoOpen();
                        e.Handled = true;
                    }
                    break;
                // Save
                case Keys.S | Keys.Control:
                    if (_actions[ActionTypeEnum.Save].Enabled)
                    {
                        DoSave();
                        e.Handled = true;
                    }
                    break;
                // Print
                case Keys.P | Keys.Control:
                    if (_actions[ActionTypeEnum.PreviewPrint].Enabled)
                    {
                        DoPreviewPrint();
                        e.Handled = true;
                    }
                    break;
                // Preview
                case Keys.F5:
                    if (_actions[ActionTypeEnum.ModePreview].Enabled)
                    {
                        DoPreview();
                        e.Handled = true;
                    }
                    break;
                // Design
                case Keys.F5 | Keys.Shift:
                    if (_actions[ActionTypeEnum.ModeDesign].Enabled)
                    {
                        DoDesign();
                        e.Handled = true;
                    }
                    break;
                // Undo
                case Keys.Z | Keys.Control:
                    if (_actions[ActionTypeEnum.Undo].Enabled)
                    {
                        bool skip = false;
                        bool propGridContainsFocus = _propGrid.ContainsFocus;
                        if (propGridContainsFocus)
                        {
                            var tb = _propGrid.ActiveControl as TextBox;
                            if (tb != null && tb.CanUndo)
                                skip = true;
                        }
                        if (!skip)
                        {
                            DiscardPendingUndoState();
                            DoUndo();
                            e.Handled = true;
                            e.SuppressKeyPress = true; // suppress the beep
                            if (propGridContainsFocus)
                                CreatePendingUndoState();
                        }
                    }
                    break;
                // Redo
                case Keys.Y | Keys.Control:
                    if (_actions[ActionTypeEnum.Redo].Enabled)
                    {
                        bool propGridContainsFocus = _propGrid.ContainsFocus;
                        DiscardPendingUndoState();
                        DoRedo();
                        e.Handled = true;
                        e.SuppressKeyPress = true; // suppress the beep
                        if (propGridContainsFocus)
                            CreatePendingUndoState();
                    }
                    break;
                // FontBold
                case Keys.B | Keys.Control:
                    if (_actions[ActionTypeEnum.FontBold].Enabled)
                    {
                        DoFontStyle(rbtnFontBold, !rbtnFontBold.Pressed);
                        e.Handled = true;
                    }
                    break;
                // FontItalic
                case Keys.I | Keys.Control:
                    if (_actions[ActionTypeEnum.FontItalic].Enabled)
                    {
                        DoFontStyle(rbtnFontItalic, !rbtnFontItalic.Pressed);
                        e.Handled = true;
                    }
                    break;
                // FontUnderline
                case Keys.U | Keys.Control:
                    if (_actions[ActionTypeEnum.FontUnderline].Enabled)
                    {
                        DoFontStyle(rbtnFontUnderline, !rbtnFontUnderline.Pressed);
                        e.Handled = true;
                    }
                    break;
                // ShowGrid
                case Keys.G | Keys.Control:
                    if (_actions[ActionTypeEnum.ShowGrid].Enabled)
                    {
                        DoShowHideGrid();
                        e.Handled = true;
                    }
                    break;
                // HistoryBack
                case Keys.BrowserBack:
                case Keys.Alt | Keys.Left:
                    if (_actions[ActionTypeEnum.PreviousView].Enabled)
                    {
                        DoNavigation(rbtnPreviousView);
                        e.Handled = true;
                    }
                    break;
                // HistoryNext
                case Keys.BrowserForward:
                case Keys.Alt | Keys.Right:
                    if (_actions[ActionTypeEnum.NextView].Enabled)
                    {
                        DoNavigation(rbtnNextView);
                        e.Handled = true;
                    }
                    break;
                case Keys.F4:
                case Keys.Alt | Keys.Enter:
                    if (_actions[ActionTypeEnum.ShowPropertyGrid].Enabled)
                    {
                        DoShowPropertyGrid();
                        e.Handled = true;
                        e.SuppressKeyPress = true; // For Alt+Enter, this suppresses the beep
                    }
                    break;
                case Keys.Shift | Keys.F4:
                    if (_actions[ActionTypeEnum.ShowDataTree].Enabled)
                    {
                        DoShowDataTree();
                        e.Handled = true;
                    }
                    break;
                // NOTE: Ctrl-+/- cannot be set to C1Command.Shortcut, hence this:
                case Keys.Add | Keys.Control:
                    if (ReportDesignMode)
                        _flexDesigner.ZoomFactor *= 1.01f;
                    else
                        _flexViewer.ZoomFactor *= 1.01f;
                    e.Handled = true;
                    break;
                case Keys.Subtract | Keys.Control:
                    if (ReportDesignMode)
                        _flexDesigner.ZoomFactor *= 0.99f;
                    else
                        _flexViewer.ZoomFactor *= 0.99f;
                    e.Handled = true;
                    break;
            }
            //
            base.OnKeyDown(e);
        }

        #region Public properties
        public C1FlexReportDesigner FlexDesigner
        {
            get { return _flexDesigner; }
        }

        public FlexDesignerHostServices DesignerHostServices
        {
            get { return _services; }
        }

        public bool CategorizeProperties
        {
            get { return _propGrid.PropertySort == PropertySort.CategorizedAlphabetical; }
            set { _propGrid.PropertySort = (value) ? PropertySort.CategorizedAlphabetical : PropertySort.Alphabetical; }
        }

        public bool UseFieldWrappers
        {
            get { return _useFieldWrappers; }
            set { _useFieldWrappers = value; }
        }

        public bool SortReportList
        {
            get { return _reportList.Sorting != SortOrder.None; }
            set { _reportList.Sorting = value ? SortOrder.Ascending : SortOrder.None; }
        }

        /// <summary>
        /// Gets or sets the current theme name, prefixed by:
        /// - "builtin:" - the theme is one of the built-in themes;
        /// - "custom:" - the theme is loaded from a file in the "Themes" sub-folder.
        /// </summary>
        public string Theme
        {
            get { return _theme; }
            set
            {
                if (_theme != value)
                {
                    _theme = value;
                    var tl = new C1ThemeLocator(_theme);
                    _cachedTheme = tl.GetTheme();
                    if (_cachedTheme != null)
                    {
                        C1ThemeController.ApplyThemeToControlTree(this, _cachedTheme);
                        C1ThemeController.ApplyThemeToObject(_cmDesigner, _cachedTheme);
                        C1ThemeController.ApplyThemeToObject(cmReport, _cachedTheme);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the currently applied theme.
        /// </summary>
        public C1Theme CachedTheme { get { return _cachedTheme; } }
        #endregion

        #region Private
        /// <summary>
        /// Call this to indicate that metadata has been changed and the loaded report definition file is now dirty.
        /// (E.g. a report definition's position in the reports' list has been changed.)
        /// </summary>
        private void MetadataChanged()
        {
            _dirty = true;
            UpdateUI(true);
        }

        private void SetDesignMode(bool designMode)
        {
            // cancel current report, if any
            if (designMode && IsPreviewRendering)
            {
                DoPreviewStop();
                while (IsPreviewRendering)
                    Application.DoEvents();
            }

            //
            _reportDesignMode = designMode;
            UpdateUI(true);

            // update form
            if (_flexDesigner.Visible)
            {
                if (dtpReports.Visible)
                    _lastDesignPage = dtpReports;
                else if (dtpProperties.Visible)
                    _lastDesignPage = dtpProperties;
                else if (dtpData.Visible)
                    _lastDesignPage = dtpData;

                _lastDesignTab = rbnMain.SelectedTab;
            }

            this.SuspendLayout();
            rbnMain.BeginUpdate();

            // In preview mode, the zoom factor dropdown is in the "zoom" group;
            // in design mode, we move it to "tools" group (seems to be the best place for it):
            RibbonMenu zoomMenu = this.rbtnZoom;
            if (designMode)
            {
                this.rgZoom.Items.Remove(this.rbtnZoom);
                this.rgTools.Items.Add(this.rbtnZoom);
            }
            else
            {
                this.rgTools.Items.Remove(this.rbtnZoom);
                this.rgZoom.Items.Add(this.rbtnZoom);
            }

            // Show/hide major controls:
            if (designMode)
            {
                _flexViewer.Visible = false;
                _flexDesigner.Visible = true;
            }
            else
            {
                _flexDesigner.Visible = false;
                _flexViewer.Visible = true;
            }

            // tab pages:
            SwitchTabsMode(designMode);

            // ribbon groups:
            rtDesign.Visible = designMode;
            rtInsert.Visible = designMode;
            rtArrange.Visible = designMode;
            rtPageSetup.Visible = designMode;
            rtPreview.Visible = !designMode;

            rbnMain.EndUpdate();
            this.ResumeLayout();

            if (designMode)
            {
                // _suspendTooltipService = false;
                c1DockingTab1.Visible = true;
                C1DockingTabPage dtp = _lastDesignPage == null ? dtpReports : _lastDesignPage;
                ShowTabPage(dtp);
                _flexViewer.DocumentSource = null;
                if (_lastDesignTab != null)
                    rbnMain.SelectedTab = _lastDesignTab;
                // this updates prop grid and UpdateUI():
                // _flexDesigner_SelectionChanged(this, EventArgs.Empty);
                OnFlexDesignerSelectionChanged(false);
            }
            else
            {
                // _suspendTooltipService = true;
                ((ITooltipService)this).ClearToolTip(_flexDesigner);
                // c1DockingTab1.Visible = false;
                _flexViewer.DocumentSource = null;
                if (_flexDesigner.Report != null)
                    RenderPreview(true, false);
            }

            ShowStatus();
            Update();
        }

        private void SwitchTabsMode(bool designMode)
        {
            if (designMode)
            {
                dtpData.TabVisible = true;
                dtpProperties.TabVisible = true;
                dtpReports.TabVisible = true;
                // restore layout
                if (_lastDesignLayout != null)
                {
                    _lastDesignLayout.Seek(0, SeekOrigin.Begin);
                    C1DockingTab.RestoreLayout(this, _lastDesignLayout);
                }
                if (!_errorList.IsEmpty)
                    dtpErrors.TabVisible = true;
            }
            else // preview
            {
                // save layout
                if (_lastDesignLayout != null)
                    _lastDesignLayout.Dispose();
                _lastDesignLayout = new MemoryStream();
                C1DockingTab.SaveLayout(this, _lastDesignLayout);
                dtpReports.TabVisible = false;
                dtpProperties.TabVisible = false;
                dtpData.TabVisible = false;
            }
        }

        private void UpdateFormCaption()
        {
            var appName = string.Format(Strings.MainForm.AppNameModeFmt, IntPtr.Size * 8);
            var caption = string.Format(
                Strings.MainForm.AppCaptionFmt,
                appName,
                (_noFile ? Strings.MainForm.Component : (string.IsNullOrEmpty(_fileName) ? string.Empty : _fileName)),
                (_dirty ? " *" : string.Empty));
            Text = caption;
        }

        private void LoadCustomFields()
        {
            foreach (string fieldInfo in AppSettings.LoadList("customfields", MessageForm.Warn))
            {
                // get assembly, class name
                string[] arr = fieldInfo.Split(';');
                if (arr.Length < 2) continue;
                string asmName = arr[0];
                string clsName = arr[1];
                if (IsBuiltInCustomField(asmName, clsName))
                    continue;
                LoadCustomField(asmName, clsName);
            }

            LoadBuiltInCustomFields();

            // show "custom fields" group only if there are any custom fields:
            rgCustomFields.Visible = rgCustomFields.Items.Count > 0;
        }

        private bool IsBuiltInCustomField(string asmName, string clsName)
        {
            if (!CustomFieldsAssemblyAliases.Contains(asmName.ToLowerInvariant()))
                return false;

            foreach (string fieldName in CustomFieldsClasses)
            {
                if (string.Equals(fieldName, clsName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }

            return false;
        }

        private void LoadCustomField(string asmName, string clsName)
        {
            // this could fail...
            try
            {
                // load assembly, create custom field instance
#pragma warning disable 618
                Assembly asm = Assembly.LoadWithPartialName(asmName);
#pragma warning restore 618
                if (asm == null)
                {
                    string msg = string.Format(Strings.MainForm.ErrCannotFindCustomFldAsmFmt, asmName);
                    throw new ApplicationException(msg);
                }
                object customField = asm.CreateInstance(clsName, true);
                if (customField == null)
                {
                    string msg = string.Format(Strings.MainForm.ErrCannotInstCustomFldFmt, clsName);
                    throw new ApplicationException(msg);
                }

                // check that the class derives from C1Report.Field
                if (!customField.GetType().IsSubclassOf(typeof(Field)))
                {
                    string msg = string.Format(Strings.MainForm.ErrCustomFldIsNotFieldFmt, clsName);
                    throw new ApplicationException(msg);
                }

                // get custom field description (for tooltip)
                Type type = customField.GetType();
                string desc;
                object[] attDesc = type.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attDesc.Length > 0)
                    desc = ((DescriptionAttribute)attDesc[0]).Description;
                else
                    desc = string.Format(Strings.MainForm.CustomFldDescriptionFmt, type.Name);

                // get custom field image (for toolbar)
                Image img = AppUtils.LoadResourceImage(asm, type.Name + ".bmp");
                if (img == null)
                {
                    img = AppUtils.LoadResourceImage(asm, type.Name + ".png");
                    if (img == null)
                        img = s_CustomFieldImage;
                }
                else
                {
                    if (img is Bitmap)
                        ((Bitmap)img).MakeTransparent(Color.Red);
                }

                // add custom field to toolbar
                RibbonToggleButton btn = new RibbonToggleButton();
                btn.Tag = customField; // tag is clonable field
                // tooltip header (the bold part at the top):
                string ttHeader = string.Format(Strings.MainForm.CustomFldToolTipHeaderFmt, desc);
                // tooltip body:
                btn.ToolTip = string.Format(Strings.MainForm.CustomFldToolTipTemplateFmt,
                    ttHeader, string.Format(Strings.MainForm.CustomFldToolTipFmt, clsName, asmName));
                //
                btn.SmallImage = img;
                btn.LargeImage = img;
                btn.Text = desc;
                if (rgCustomFields.Items.Count < 9)
                    btn.KeyTip = (rgCustomFields.Items.Count + 1).ToString();
                rgCustomFields.Items.Add(btn);
            }
            catch (Exception x)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("failed to load custom field '{0};{1}':\r\n{2}", asmName, clsName, x.Message));
            }
        }

        private void LoadBuiltInCustomFields()
        {
            foreach (string clsName in CustomFieldsClasses)
            {
                LoadCustomField(CustomFieldsAssembly, clsName);
            }
        }

        private void ClearRenderError()
        {
            rbtnRenderError.Visible = false;
            rsepRenderError.Visible = false;
            rbtnRenderError.ToolTip = string.Empty;
            _errorList.Clear();
            _actions[ActionTypeEnum.ErrorListCopy].Enabled = false;
        }

        private void SetRenderError(string errorMessage)
        {
#if skip_dima // not needed because we now have error list; remove altogether when dust settles
            rbtnRenderError.Visible = true;
            rsepRenderError.Visible = true;
            rbtnRenderError.ToolTip = errorMessage;
#endif
        }

        // configure based on command-line arguments passed by 
        // C1Report's ControlDesigner class
        private bool StartFromDesigner()
        {
            // check command-line arguments
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length < 2 || !args[1].StartsWith("-design:"))
                return false;

            // configure application
            _noFile = true;
            _dirty = false;
            rbtnExit.Visible = false;
            rbtnCancelAndExit.Visible = true;
            rbtnSaveAndExit.Visible = true;

            // load data schema from file
            _dataSchema = null;
            if (args.Length > 2 && args[2].StartsWith("-schema:"))
            {
                string schemaFileName = args[2].Substring(8);
                if (File.Exists(schemaFileName))
                {
                    try
                    {
                        // load schema into hash table (for use with DataPicker)
                        using (FileStream fs = new FileStream(schemaFileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            BinaryFormatter bf = new BinaryFormatter();
                            _dataSchema = (Hashtable)bf.Deserialize(fs);
                        }
                    }
                    catch
                    {
                    }
                }
            }

            // load report from temp file
            string reportFileName = args[1].Substring(8);
            OpenFileInternal(reportFileName, true);

            // show current state
            Activate();
            UpdateUI(true);

            // if there's no report (control was empty), invoke wizard and create a new report
            if (_reportList.Items.Count == 0)
                AddWizardReport();

            // still no report? user probably canceled the wizard, so bail out.
            if (_reportList.Items.Count == 0)
            {
                Visible = false;
                AppUtils.DeleteFile(_fileName);
                Application.Exit();
            }

            // if the report contains connstring and recordsource, wire them up
            Flex.C1FlexReport report = _flexDesigner.Report;
            var ds = report.DataSource;
            if (ds != null)
            {
                string conn = ds.ConnectionString;
                if (conn != null && conn.Length > 0 && _dataSchema != null && _dataSchema.Contains(conn))
                {
                    DataSet dset = (DataSet)_dataSchema[conn];
                    string rs = ds.RecordSource;
                    if (rs != null && rs.Length > 0 && dset.Tables.Contains(rs))
                        ds.Recordset = dset.Tables[rs];
                }
            }

            // if the report contains no fields, invoke wizard
            if (report.Fields.Count == 0)
            {
                _reportList.Items.Clear();
                _flexDesigner.Report = null;
                AddWizardReport();
            }

            // ready to work
            return true;
        }

        /// <summary>
        /// Edits a script.
        /// The result is saved via reflection to the specified property on the specified object.
        /// </summary>
        /// <param name="report">The host report.</param>
        /// <param name="dataSourceName">The name of the data source for dbfields used by the editor.</param>
        /// <param name="typeDescriptorContext">Type descriptor context (may be null).</param>
        /// <param name="script">The script to edit (may be null or empty for new scripts).</param>
        /// <param name="isExpression">true if the script is an expression (returns value), false otherwise.</param>
        /// <returns>true if the user saved changes, false if cancelled.</returns>
        internal bool EditScriptInternal(
            C1FlexReport report,
            string contextName,
            ITypeDescriptorContext typeDescriptorContext,
            object propertyOwner,
            string propertyName,
            string displayName,
            bool isExpression,
            out object result)
        {
            rbtnScriptEditor.Pressed = true;
            try
            {
                using (var dlg = new Forms.ScriptEditorFormEx(this, report, contextName, typeDescriptorContext, propertyOwner, propertyName, displayName, !isExpression))
                {
                    // ScriptEditorFormEx returns OK if *any* script has been written back while it was active, not only the one it was called to edit.
                    // So we raise the dirty flag if OK, but result may still be null.
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        result = dlg.GetValue();
                        OnValuesChanged(true, false);
                        return result != null; ;
                    }
                    else
                    {
                        result = null;
                        return false;
                    }
                }
            }
            finally
            {
                rbtnScriptEditor.Pressed = false;
            }
        }

        bool IScriptEditorService.EditScript(
            C1FlexReport report,
            string dataSourceName,
            ScriptEditorContextKind contextKind,
            object propertyOwner,
            string propertyName,
            string displayName,
            bool isExpression,
            out object result)
        {
            var contextName = EditorScriptContextBase.MakeContextName(dataSourceName, contextKind);
            return EditScriptInternal(report, contextName, null, propertyOwner, propertyName, displayName, isExpression, out result);
        }
        bool IScriptEditorService.EditScript(
            C1FlexReport report,
            string dataSourceName,
            ScriptEditorContextKind contextKind,
            ITypeDescriptorContext typeDescriptorContext,
            string displayName,
            bool isExpression,
            out object result)
        {
            var contextName = EditorScriptContextBase.MakeContextName(dataSourceName, contextKind);
            return EditScriptInternal(report, contextName, typeDescriptorContext, null, null, displayName, isExpression, out result);
        }

        bool IPictureHolderEditorService.EditPictureHolder(object propOwner, string propName, object value, bool allowExpressions, out object result)
        {
            using (var form = new Forms.PictureHolderEditorForm())
            {
                form.Init(_services, propOwner, propName, value, allowExpressions);
                if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    result = form.Value;
                    return true;
                }
            }
            result = null;
            return false;
        }

        private object[] ObjectsToModels(object[] objects)
        {
            if (objects == null)
                return null;

            for (int i = 0; i < objects.Length; ++i)
                objects[i] = EditorsHelper.CreateInstanceModel(objects[i], this._services);
            return objects;
        }

        private void UpdatePropertyGrid(object[] selectedObjects = null, bool clear = false)
        {
            if (selectedObjects == null || selectedObjects.Length == 0 || selectedObjects[0] == null)
            {
                if (clear)
                    // clear the grid
                    _propGrid.SelectedObject = null;
                else
                    // refresh existing selection
                    _propGrid.Refresh();
            }
            else
            {
                // new (?) selection - try to not update if possible
                bool newSelection = false;
                if (_propGrid.SelectedObjects.Length == selectedObjects.Length)
                {
                    for (int i = 0; i < selectedObjects.Length; ++i)
                    {
                        var m = _propGrid.SelectedObjects[i] as EditableModel;
                        if (m == null || m.Instance != selectedObjects[i])
                        {
                            newSelection = true;
                            break;
                        }
                    }
                }
                else
                    newSelection = true;
                if (newSelection)
                    _propGrid.SelectedObjects = ObjectsToModels(selectedObjects);
            }
        }

        private bool EnsureUniqueName(Flex.C1FlexReport rpt)
        {
            // already unique? no work
            if (IsUniqueName(rpt))
                return false;

            // make sure we have some kind of name
            string name = rpt.ReportName;
            if (string.IsNullOrEmpty(name))
                name = Strings.MainForm.FallbackReportName;

            // strip trailing digits
            string baseName = Regex.Replace(name, "(.+) [0-9]+$", "$1");

            // and append counter until unique
            for (int i = 1; ; i++)
            {
                string newName = string.Format("{0} {1}", baseName, i);
                if (IsUniqueName(rpt, newName))
                {
                    rpt.ReportName = newName;
                    return true;
                }
            }
        }

        // check whether a report name is valid (non empty, no duplicate)
        private bool IsUniqueName(Flex.C1FlexReport rpt)
        {
            return IsUniqueName(rpt, rpt.ReportName);
        }

        private bool IsUniqueName(Flex.C1FlexReport rpt, string name)
        {
            // don't allow empty names
            if (string.IsNullOrEmpty(name))
                return false;

            // look for duplicates
            foreach (ReportItem item in this._reportList.Items)
            {
                if (item.Report.Equals(rpt))
                    continue;
                if (string.Compare(name, item.Report.ReportName, true) == 0)
                    return false;
            }

            // name is unique
            return true;
        }

        // start a new report definition file
        private bool NewFile()
        {
            _flexDesigner.EndInplaceEditing(false);

            // make sure changes aren't lost
            if (!DiscardChangesOK())
                return false;

            // re-initialize everything
            _dataTree.Clear();
            _reportList.Items.Clear();
            _flexDesigner.Report = null;
            _fileName = string.Empty;
            _fileNameChanged = false;
            _dirty = false;
            _flexViewer.DocumentSource = null;
            // Start in design mode.
            ReportDesignMode = true;
            ShowStatus(Strings.MainForm.Ready);
            UpdateUI(true);
            // update last loaded file:
            AppSettings.SaveValue(AppSettings.c_lastLoadedFile, string.Empty);
            AppSettings.SaveValue(AppSettings.c_lastLoadedReport, string.Empty);
            // done
            return true;
        }

        private void RecentFileClick(object sender, EventArgs e)
        {
            string fileName = (string)((RibbonListItem)sender).Tag;
            if (!OpenFile(fileName))
                MessageForm.Warn(string.Format(Strings.MainForm.ErrCannotOpenRecentFmt, fileName));
        }

        /// <summary>
        /// Adds a file to the top of the recent file list.
        /// If a file is already in the list, it is pushed to the top.
        /// If a file is not in the list, it is added to the top ONLY if it exists.
        /// </summary>
        /// <param name="fileName"></param>
        private void AddRecentFile(string fileName)
        {
            int i = _recentFiles.IndexOf(fileName);
            bool addLast;
            if (i != -1)
            {
                object v = _recentFiles[0];
                _recentFiles[0] = _recentFiles[i];
                _recentFiles[i] = v;
                addLast = true;
            }
            else if (File.Exists(fileName))
            {
                if (_recentFiles.Count > cMaxRecentFilesCount)
                    _recentFiles.RemoveAt(_recentFiles.Count - 1);
                _recentFiles.Insert(0, fileName);
                addLast = true;
            }
            else
                addLast = false;

            UpdateRecentFiles();
            AppSettings.SaveList(AppSettings.c_recentFiles, _recentFiles, false, MessageForm.Warn);
            if (addLast && _reportList != null && _reportList.SelectedItem != null)
            {
                AppSettings.SaveValue(AppSettings.c_lastLoadedFile, fileName);
                AppSettings.SaveValue(AppSettings.c_lastLoadedReport, _reportList.SelectedItem.Text);
            }
        }

        private void DeleteRecentFile(string fileName)
        {
            _recentFiles.Remove(fileName);
            UpdateRecentFiles();

            AppSettings.SaveList(AppSettings.c_recentFiles, _recentFiles, false, MessageForm.Warn);
        }

        private void UpdateRecentFiles()
        {
            for (int i = ramMain.RightPaneItems.Count - 1; i > 1; i--)
            {
                RibbonItem ri = ramMain.RightPaneItems[i];
                ramMain.RightPaneItems.RemoveAt(i);
                ri.Dispose();
            }

            for (int i = 0; i < _recentFiles.Count; i++)
            {
                string fn = (string)_recentFiles[i];

                RibbonListItem rli = new RibbonListItem();
                rli.Click += RecentFileClick;
                rli.Tag = fn;
                RibbonButton rb = new RibbonButton();
                if (i < 10)
                    rb.Text = string.Format(Strings.MainForm.NumberedRecentFileMenuFmt, i + 1, Path.GetFileName(fn));
                else
                    rb.Text = string.Format(Strings.MainForm.RecentFileMenuFmt, Path.GetFileName(fn));
                rb.ToolTip = Path.GetFullPath(fn);

                rli.Items.Add(rb);
                ramMain.RightPaneItems.Add(rli);
            }
        }

        private void InitRecentFiles()
        {
            _recentFiles = AppSettings.LoadList(AppSettings.c_recentFiles, MessageForm.Warn);
            UpdateRecentFiles();
        }

        // open report definition file
        private bool OpenFile()
        {
            _flexDesigner.EndInplaceEditing(false);

            // make sure changes aren't lost
            if (!DiscardChangesOK())
                return true; // << not an error

            // get file name
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.DereferenceLinks = true;
                dlg.Title = Strings.MainForm.OpenFileDlgTitle;
                dlg.DefaultExt = DefaultFileExt;
                dlg.FileName = "*." + DefaultFileExt;
                dlg.Filter = Strings.MainForm.FileOpenFilter;
                dlg.FilterIndex = 0;
                if (dlg.ShowDialog() != DialogResult.OK)
                    return false;

                // open the file, update MRU list
                bool ok = true;
                Cursor = Cursors.WaitCursor;
                try
                {
                    OpenFileInternal(dlg.FileName);
                }
                catch (Exception e)
                {
                    MessageForm.Warn(string.Format(Strings.MainForm.ErrCannotLoadReportFmt, dlg.FileName, e.Message));
                    DeleteRecentFile(dlg.FileName);
                    ok = false;
                }
                Cursor = Cursors.Default;
                return ok;
            }
        }

        private bool OpenFile(string fileName)
        {
            _flexDesigner.EndInplaceEditing(false);

            // make sure changes aren't lost
            if (!DiscardChangesOK())
                return true; // << not an error

            // go ahead and load the file
            bool ok = true;
            Cursor = Cursors.WaitCursor;
            try
            {
                OpenFileInternal(fileName);
            }
            catch
            {
                DeleteRecentFile(fileName);
                ok = false;
            }
            Cursor = Cursors.Default;
            return ok;
        }

        /// <summary>
        /// Loads a file AND updates the recent file list. If 'quiet' is true, it does not show any dialogs,
        /// and also does not update the recent file list.
        /// </summary>
        /// <param name="fileName">The file name to open.</param>
        /// <param name="quiet">Quiet means no dialogs, and also no updating the recent file list.</param>
        private void OpenFileInternal(string fileName, bool quiet = false)
        {
            // load XML document
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load(fileName);

            // get names from XmlDocument
            string[] reports = C1FlexReport.GetReportList(doc);
            if (reports == null)
            {
                if (!quiet)
                    MessageForm.Warn(string.Format(Strings.MainForm.ErrCannotFindAnyReportsFmt, fileName));
                return;
            }

            _reportList.Items.Clear();
            _reportList.SelectedIndex = -1;
            _reportList.Refresh();
            UpdateUI(true);

            _reportList.BeginUpdate();
            bool converted = false;
            int cnt = reports.Length;
            for (int i = 0; i < cnt; ++i)
            {
                ShowStatus(string.Format(Strings.MainForm.LoadingReportOfReportsFmt, i + 1, cnt, reports[i]));
                Flex.C1FlexReport flexReport = new Flex.C1FlexReport();
                try
                {
                    bool converted1;
                    flexReport.Load(doc, reports[i], out converted1);
                    if (converted1 && !converted && !quiet)
                    {
                        MessageForm.Info(Strings.MainForm.RenameToFLXRWarning);
                        converted = true;
                    }
                    _reportList.Items.Add(new ReportItem(flexReport));
                }
                catch (Exception x)
                {
                    MessageForm.Warn(string.Format(Strings.MainForm.ErrCannotLoadReportFmt, reports[i], x.Message));
                }
            }
            _reportList.EndUpdate();
            _reportList.AdjustSize();
            // reset selected report, otherwise a report from the old file may remain loaded:
            _reportList.SelectedIndex = -1;

            // done loading, update report list and UI
            FinishLoading();
            //
            if (converted && !quiet)
            {
                _dirty = true;
                _fileName = Path.ChangeExtension(fileName, DefaultFileExt);
                _fileNameChanged = true;
                _fileTimeStamp = DateTime.MinValue;
            }
            else
            {
                _dirty = false;
                _fileName = fileName;
                _fileNameChanged = false;
                _fileTimeStamp = File.GetLastWriteTimeUtc(_fileName);
            }
            UpdateUI(true);

            //
            ShowStatus(Strings.MainForm.Ready);

            // try loading last edited report (setting SelectedIndex will also set _flexDesigner.Report);
            if (_fileName == AppSettings.LoadValue(AppSettings.c_lastLoadedFile))
            {
                string lastReport = AppSettings.LoadValue(AppSettings.c_lastLoadedReport);
                if (!string.IsNullOrEmpty(lastReport))
                {
                    for (int i = 0; i < _reportList.Items.Count; ++i)
                    {
                        ReportItem ri = _reportList.Items[i] as ReportItem;
                        if (ri != null && ri.Text == lastReport)
                        {
                            _reportList.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            // make sure we select some report:
            if (_reportList.SelectedIndex == -1 && _reportList.Items.Count > 0)
                _reportList.SelectedIndex = 0;

            if (!quiet)
                AddRecentFile(_fileName);
        }

        // Fix subreport references: replace subreports loaded into subreport 
        // fields with references to actual reports in the list.
        private void FinishLoading()
        {
            for (int i = 0; i < _reportList.Items.Count; i++)
            {
                // scan this report looking for fields with subreports
                ReportItem ri = _reportList.Items[i] as ReportItem;
                foreach (FieldBase f in ri.Report.Fields)
                {
                    var subReport = C1FlexReportDesigner.MetaGetSubreport(f);
                    if (subReport == null)
                        continue;

                    // found subreport: replace embedded report with reference to report on the list
                    bool found = false;
                    string reportName = subReport.ReportName;
                    foreach (ReportItem riSub in _reportList.Items)
                    {
                        if (String.Compare(riSub.Report.ReportName, reportName, true) != 0)
                            continue;
                        // f.Subreport = riSub.Report;
                        C1FlexReportDesigner.MetaSetSubreport(f, riSub.Report);
                        found = true;
                        break;
                    }

                    // subreport not found: add it to the list and loop again
                    if (!found)
                    {
                        _reportList.Items.Add(new ReportItem(subReport));
                        _reportList.AdjustSize();
                        i = -1; // << restart from the top
                        break;
                    }
                }
            }

            // update report list (to feed subreport TypeConverter)
            UpdateReportList();

            // select the first report (if any)
            ReportDesignMode = true;
        }

        // update report list (to feed subreport TypeConverter)
        private void UpdateReportList()
        {
            // update icons
            _reportList.UpdateIcons();

            // very stupid fix, overwise listview looks wrong(it has empty first row)
            // in following scenarion:
            // - run report designer
            // - set reports tab to floating
            // - load report
            // - open reports tab, see that the list view has empty first row, it is a bug
            _reportList.View = View.LargeIcon;
            _reportList.View = View.Details;
            //
            _reportList.AdjustSize();
        }

        // import Access and Crystal reports
        private bool ImportFile()
        {
            // get file name
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.DereferenceLinks = true;
                dlg.Title = Strings.MainForm.ImportReportDlgTitle;
                dlg.DefaultExt = "mdb";
                if (_borland)
                    dlg.Filter = Strings.MainForm.ImportFilterBorland;
                else
                    dlg.Filter = Strings.MainForm.ImportFilter;

                if (dlg.ShowDialog() != DialogResult.OK)
                    return false;

                // let user know we're working...
                ShowStatus(string.Format(Strings.MainForm.ImportingFromFmt, dlg.FileName));
                Cursor = Cursors.WaitCursor;

                // open the file, update MRU list
                IC1ReportImportFilter filter = null;
                try
                {
                    // build import filter class
                    string fileName = dlg.FileName.ToLower();
                    filter = (fileName.EndsWith(".rpt") && !_borland)
                        ? (IC1ReportImportFilter)new CrystalFilter()
                        : (IC1ReportImportFilter)new AccessFilter(this);

                    // import reports
                    _importList = new List<C1FlexReport>();
                    filter.Loading += new EventHandler(_loading);
                    _clearOnImport = filter.Import(dlg.FileName, _importList);
                }
                catch (Exception e)
                {
                    MessageForm.Warn(string.Format(Strings.MainForm.ErrCannotImportReportFmt, dlg.FileName, e.Message));
                }
            }

            try
            {
                _reportList.BeginUpdate();

                // update list
                if (_importList == null || _importList.Count <= 0)
                    return false;

                // clear existing list
                if (_clearOnImport)
                {
                    if (!NewFile())
                        return false;
                }

                // sort the imported list
                _importList.Sort((r1_, r2_) => string.Compare(r1_.ReportName, r2_.ReportName, true));

                // add reports to list
                foreach (C1FlexReport rpt in _importList)
                {
                    EnsureUniqueName(rpt);
                    _reportList.Items.Add(new ReportItem(rpt));
                }

                // update subreport references
                FinishLoading();
                _dirty = true;

                // select first new report
                if (_importList.Count > 0)
                {
                    foreach (ReportItem ri in _reportList.Items)
                    {
                        if (ri.Report == _importList[0])
                        {
                            ri.Selected = true;
                            break;
                        }
                    }
                }

                // done
                return true;
            }
            finally
            {
                _reportList.EndUpdate();
                _reportList.AdjustSize();
                _importList = null;
                UpdateUI(true);
                Cursor = Cursors.Default;
                ShowStatus(Strings.MainForm.Ready);
            }
        }

        private void _loading(object sender, System.EventArgs e)
        {
            var rpt = (C1FlexReport)_importList[_importList.Count - 1];
            ShowStatus(string.Format(Strings.MainForm.ImportingReportFmt, rpt.ReportName));
        }

        // save report definition file
        /// <summary>
        /// Save the current file, or if <paramref name="saveAs"/> show the 'save as...' dialog.
        /// </summary>
        /// <param name="saveAs"></param>
        /// <returns>True if the file was successfully saved, false otherwise.</returns>
        private bool SaveFile(bool saveAs)
        {
            _flexDesigner.EndInplaceEditing(false);

            // save as should change last file name

            // save current filename
            string fileName = _fileName;

            // save as usual
            bool retval = SaveFileInternal(saveAs);

            // if we're editing a component, restore temp filename
            if (_noFile)
                _fileName = fileName;

            if (retval)
            {
                DeleteRecentFile(fileName);
                AddRecentFile(_fileName);
            }

            // return
            return retval;
        }

        private bool SaveFileInternal(bool saveAs)
        {
            // get file name
            if (saveAs || string.IsNullOrEmpty(_fileName) || _fileNameChanged)
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.DereferenceLinks = true;
                    dlg.Title = Strings.MainForm.SaveReportDlgTitle;
                    if (string.IsNullOrEmpty(_fileName))
                        dlg.FileName = "*." + DefaultFileExt;
                    else if (!_fileNameChanged)
                        dlg.FileName = Path.ChangeExtension(_fileName, DefaultFileExt);
                    else
                        dlg.FileName = _fileName;
                    dlg.DefaultExt = DefaultFileExt;
                    dlg.Filter = Strings.MainForm.FileSaveFilter;
                    dlg.FilterIndex = 0;
                    if (dlg.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(dlg.FileName))
                        return false;
                    _fileName = dlg.FileName;
                    _fileNameChanged = false;
                }
            }

            // start long operation
            Cursor = Cursors.WaitCursor;

            try
            {
                // Using memory stream and writing it afterwards to file prevents errors while creating xml content from corrupting the file.
                using (MemoryStream ms = new MemoryStream())
                using (XmlTextWriter w = new XmlTextWriter(ms, null)) // (null encoding uses utf-8 and suppresses it from xml header)
                {
                    w.Formatting = Formatting.Indented;
                    w.Indentation = 2;
                    w.WriteStartDocument();
                    // write all reports to it
                    w.WriteStartElement("Reports");
                    w.WriteStartElement("FormatVersion");
                    w.WriteString(C1FlexReport.FormatVersion.ToString());
                    w.WriteEndElement();
                    int cnt = _reportList.Items.Count;
                    for (int i = 0; i < cnt; i++)
                    {
                        ReportItem ri = (ReportItem)_reportList.Items[i];
                        ShowStatus(string.Format(Strings.MainForm.SavingFmt, i + 1, cnt, ri.ToString()));
                        ri.Report.Save(w, _embedImages, false);
                    }
                    w.WriteEndElement();
                    w.Flush();
                    // Copy content from memory stream to physical file:
                    using (FileStream fs = new FileStream(_fileName, FileMode.Create))
                    {
                        ms.Seek(0, SeekOrigin.Begin);
                        ms.WriteTo(fs);
                        fs.Flush();
                        fs.Close();
                    }
                    w.Close();
                    ms.Close();
                }
                // saved successfully, no longer dirty
                _dirty = false;
                _fileTimeStamp = File.GetLastWriteTimeUtc(_fileName);
                UpdateUI(true);
            }
            catch (Exception x)
            {
                MessageForm.Error(string.Format(Strings.MainForm.ErrorSavingFileFmt, _fileName, x.Message));
                return false;
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            // and be done
            return true;
        }

        // check whether user wants to save or discard current changes before loading a file
        internal bool DiscardChangesOK()
        {
            // If user is in inplace editing - end saving their work:
            _flexDesigner.EndInplaceEditing(false);

            // no changes? we're OK then
            if (!_dirty)
                return true;

            // prompt user
            DialogResult dr = MessageForm.Ask(Strings.MainForm.SaveChangesQ, MessageBoxButtons.YesNoCancel);
            switch (dr)
            {
                case DialogResult.Yes:
                    return SaveFile(false);
                case DialogResult.No:
                    return true;
                case DialogResult.Cancel:
                    return false;
            }

            // should never get here
            return false;
        }

        private void ShowStatusOfObject(object o)
        {
            string msg = string.Empty;
            if (o != null)
            {
                if (o is EditableModel)
                    o = ((EditableModel)o).Instance;
                var vro = o as VisualReportObject;
                if (vro != null)
                {
                    var name = vro.Name;
                    var type = vro.GetType().Name;
                    var desc = _flexDesigner.GetReportObjectDescription(vro);
                    if (string.IsNullOrEmpty(name))
                    {
                        if (string.IsNullOrEmpty(desc))
                            msg = type;
                        else
                            msg = string.Format("{0}, {1}", type, desc);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(desc))
                            msg = string.Format("{0}: {1}.", name, type);
                        else
                            msg = string.Format("{0}: {1}, {2}", name, type, desc);
                    }
                }
            }
            ShowStatus(msg);
        }

        // update status bar text
        private void ShowStatus()
        {
            ShowStatus(null);
        }

        private void ShowStatus(string msg)
        {
            sbMain.BeginUpdate();
            if (ReportDesignMode)
            {
                UpdateSearchVisible(false);
                foreach (RibbonItem ri in sbMain.RightPaneItems)
                {
                    if (ri.Name == "rlblZoom" ||
                        ri.Name == "rtbZoom" ||
                        ri.Name == "rlblSelectedReport" ||
                        ri.Name == "ribbonSeparator17")
                        continue;
                    ri.Visible = false;
                }
                if (msg != null)
                    rlblStatusBarText.Text = msg;
                // In design mode, show zoom factor label, hide zoom factor button (see below).
                rbtnStatusZoom.Visible = false;
                rlblZoom.Visible = true;
            }
            else
            {
                foreach (RibbonItem ri in sbMain.RightPaneItems)
                {
                    if (ri == rbtnRenderError || ri == rsepRenderError)
                        ri.Visible = !string.IsNullOrEmpty(rbtnRenderError.ToolTip);
                    else
                        ri.Visible = true;
                }

                if (msg != null)
                    rlblStatusBarText.Text = msg;
                UpdateUIPreviewStatusBar(true);
                // Note: this is the only place where we swap a label and button, and set button's text.
                // Hence it is done right here in a "non-regular" way.
                rbtnStatusZoom.Visible = true;
                rlblZoom.Visible = false;
            }
            sbMain.EndUpdate();
            sbMain.Refresh();
        }

        // create a name for a new field
        internal string GetUniqueFieldName()
        {
            var fields = _flexDesigner.Report.Fields;
            for (int i = 1; ; i++)
            {
                var name = string.Format(Strings.MainForm.NewFieldNameFmt, i);
                if (!fields.Contains(name))
                    return name;
            }
            // never gets here
        }

        #region Clipboard

        private bool GetReportDataPresent(IDataObject data)
        {
            return (data != null) ? data.GetDataPresent(_cfReport.Name) : false;
        }

        private IDataObject BuildDataObject()
        {
            ReportItem ri = _reportList.SelectedItem;
            if (ri == null)
                return null;
            return new DataObject(_cfReport.Name, ri.Report.ReportDefinition);
        }

        private bool PasteDataObject(IDataObject obj)
        {
            string strDef = obj.GetData(_cfReport.Name) as string;
            if (strDef == null)
                return false;

            // create new report from definition
            C1FlexReport rpt = new C1FlexReport();
            rpt.ReportDefinition = strDef;

            // create new report item
            if (!_dragSource)
                EnsureUniqueName(rpt);

            ReportItem ri = new ReportItem(rpt);

            // add new report to list and select it
            if (_reportList.Sorting == SortOrder.None)
            {
                Point pt = _reportList.PointToClient(Control.MousePosition);
                ListViewItem item = _reportList.GetItemAt(pt.X, pt.Y);
                int index = item == null ? _reportList.Items.Count : item.Index;
                _reportList.Items.Insert(index, ri);
            }
            else
            {
                _reportList.Items.Add(ri);
                _reportList.AdjustSize();
            }

            _reportList.SelectedIndex = ri.Index;

            // done
            MetadataChanged();
            UpdateReportList();
            return true;
        }

        #endregion

        #endregion

        #region Internal
        // show wizard to create new report
        internal bool AddWizardReport()
        {
            HideSpash();

            // get parameters for report wizard
            Flex.DataProvider dataProvider = Flex.DataProvider.OLEDB;
            string conn = null, rs = null;
            if (_flexDesigner.Report != null && _flexDesigner.Report.DataSource != null)
            {
                conn = _flexDesigner.Report.DataSource.ConnectionString;
                rs = _flexDesigner.Report.DataSource.RecordSource;
                dataProvider = _flexDesigner.Report.DataSource.DataProvider;
            }

            // show report wizard
            using (ReportWizard wizard = new ReportWizard(this))
            {
                // center on screen if the main form is not visible yet
                if (!Visible)
                {
                    wizard.StartPosition = FormStartPosition.CenterScreen;
                }

                // show the wizard
                ReportWizardResult result = wizard.ShowDialog(dataProvider, conn, rs, _dataSchema);

                // add report to list, preview or design it
                switch (result)
                {
                    // preview or design the new repot
                    case ReportWizardResult.Preview:
                    case ReportWizardResult.Design:

                        // rename the report if necessary
                        var rpt = wizard.Report;
                        EnsureUniqueName(rpt);

                        // set report metadata
                        rpt.ReportInfo.Author = Environment.UserName;

                        // add the report to the list and select it
                        ListViewItem lvi = _reportList.Items.Add(new ReportItem(rpt));
                        _reportList.AdjustSize();
                        _reportList.SelectedIndex = lvi.Index;

                        // set preview or design based on user choice
                        ReportDesignMode = (result == ReportWizardResult.Design);

                        // done
                        _dirty = true;
                        UpdateUI(true);
                        break;

                    // cancel...
                    default:
                        return false;
                }
            }

            // done...
            UpdateReportList();
            return true;
        }

        internal bool AddEmptyReport()
        {
            HideSpash();

            // rename the report if necessary
            var rpt = new C1FlexReport();
            EnsureUniqueName(rpt);

            // Make sections visible:
            foreach (var s in C1FlexReportDesigner.GetSectionsInDesignerOrder(rpt))
                s.Visible = true;

            // Set 1in height for the most commonly used sections:
            rpt.Sections[SectionTypeEnum.Header].Height = 1440;
            rpt.Sections[SectionTypeEnum.Detail].Height = 1440;

            // if we have a current report, copy its data source:
            if (_flexDesigner.Report != null)
            {
                var ds = _flexDesigner.Report.DataSource;
                if (ds != null)
                    rpt.DataSource.AssignFrom(ds);
            }

            // set report metadata
            rpt.ReportInfo.Author = Environment.UserName;

            // add the report to the list and select it
            ListViewItem lvi = _reportList.Items.Add(new ReportItem(rpt));
            _reportList.AdjustSize();
            _reportList.SelectedIndex = lvi.Index;

            // set preview or design based on user choice
            ReportDesignMode = true;

            // done
            _dirty = true;
            UpdateUI(true);

            // done...
            UpdateReportList();
            return true;
        }

        // delete current report (after user confirmation)
        internal bool DeleteReport()
        {
            return DeleteReport(false);
        }

        internal bool DeleteReport(bool quiet)
        {
            return DeleteReport(_reportList.SelectedItem, quiet);
        }

        internal bool DeleteReport(ReportItem ri, bool quiet)
        {
            // make sure we have an item to delete
            if (ri == null)
                return false;

            // warn user, this is not undoable
            if (!quiet)
            {
                DialogResult dr = MessageForm.Ask(string.Format(Strings.MainForm.ConfirmDeleteReportFmt, ri.ToString()), MessageBoxButtons.YesNo);
                if (dr != DialogResult.Yes)
                    return false;
            }

            // remove report from list
            int index = _reportList.SelectedIndex;
            _reportList.Items.Remove(ri);

            // update selection
            int count = _reportList.Items.Count;
            _reportList.SelectedIndex = (index < count) ? index : count - 1;

            // update report list (to feed subreport TypeConverter)
            MetadataChanged();
            UpdateReportList();
            return true;
        }

        /// <summary>
        /// Opens a specified URL in an external browser.
        /// Shows error message if there is an error.
        /// </summary>
        /// <param name="url">The URL to open.</param>
        internal static void OpenURL(string url)
        {
            try
            {
                // Process.Start doesn't work for .Net Core without UseShellExecute = true
                System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageForm.Warn(string.Format(Strings.MainForm.HelpUrlErrorFmt, ex.Message));
            }
        }

        /// <summary>
        /// True if the current mode is design, false if preview.
        /// </summary>
        internal bool ReportDesignMode
        {
            get { return _reportDesignMode; }
            set
            {
                // no work?
                if (value == _reportDesignMode)
                    return;
                SetDesignMode(value);
            }
        }

        /// <summary>
        /// True if the built-in CustomField assembly is available.
        /// </summary>
        internal static bool CustomFieldsAssemblyAvailable
        {
            get
            {
                if (!_customFieldsAssemblyAvailable.HasValue)
                {
                    try
                    {
                        // disable warnings about Assembly.LoadWithPartialName:
#pragma warning disable CS0618
                        var asm = Assembly.LoadWithPartialName(CustomFieldsAssembly);
#pragma warning restore CS0618
                        _customFieldsAssemblyAvailable = asm != null;
                    }
                    catch (Exception)
                    {
                        _customFieldsAssemblyAvailable = false;
                    }
                }

                return _customFieldsAssemblyAvailable.Value;
            }
        }

        #endregion

        #region ISite implementation

        IComponent ISite.Component
        {
            get { return this; }
        }

        IContainer ISite.Container
        {
            get { return this.components; }
        }

        bool ISite.DesignMode
        {
            get { return false; }
        }

        string ISite.Name
        {
            get { return string.Empty; }
            set { }
        }

        object IServiceProvider.GetService(Type serviceType)
        {
            return null;
        }

        #endregion

        private void _flexDesigner_MouseDown(object sender, MouseEventArgs e)
        {
            // Inform ribbon that a mouse key was pressed so it won't try to show keytips:
            //rbnMain.NoTipsOnAltUp();

            // Make sure context menu is relevant:
            // Selection prior to showing the context menu:
            // - if selection exists, but field under the mouse exists and is not selected - we select just it.
            // - otherwise, we keep whatever is selected.
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                // get field under the mouse
                Point pt = e.Location;
                Section section;
                SubSection subSection;
                FieldBase field;
                double x, y;
                if (_flexDesigner.HitTest(pt.X, pt.Y, out section, out subSection, out field, out x, out y))
                {
                    if (field != null)
                    {
                        // if field is not selected, select just it:
                        if (!_flexDesigner.SelectedFields.Contains(field))
                            _flexDesigner.SelectField(field, true, true);
                    }
                    else if (subSection != null)
                    {
                        if (!_flexDesigner.SelectedSubSections.Contains(subSection) && !_flexDesigner.SelectedSections.Contains(section))
                            _flexDesigner.SelectSubSection(subSection, true, true);
                    }
                    else if (section != null)
                    {
                        if (!_flexDesigner.SelectedSections.Contains(section))
                            _flexDesigner.SelectSection(section, true, true);
                    }
                }
            }
        }

        /// <summary>
        /// Handle key down when the designer control has focus.
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        private bool DesignerHandleKeyDown(Keys keyData)
        {
            const int d = 1;
            const int D = 15;
            switch (keyData)
            {
                case Keys.Tab:
                    _flexDesigner.SelectNext(true);
                    break;
                case Keys.Tab | Keys.Shift:
                    _flexDesigner.SelectNext(false);
                    break;

                // Scroll:
                case Keys.Down | Keys.Control:
                    _flexDesigner.ScrollVSmall(true);
                    break;
                case Keys.Up | Keys.Control:
                    _flexDesigner.ScrollVSmall(false);
                    return true;
                case Keys.Right | Keys.Control:
                    _flexDesigner.ScrollHSmall(true);
                    return true;
                case Keys.Left | Keys.Control:
                    _flexDesigner.ScrollHSmall(false);
                    return true;
                case Keys.Home | Keys.Control:
                    _flexDesigner.Scroll(0, int.MaxValue);
                    return true;
                case Keys.Home:
                    _flexDesigner.SelectFirst();
                    return true;
                case Keys.End:
                    _flexDesigner.SelectLast();
                    return true;
                case Keys.End | Keys.Control:
                    _flexDesigner.Scroll(0, int.MinValue);
                    _flexDesigner.ScrollVPage(false);
                    return true;
                case Keys.PageUp:
                    _flexDesigner.ScrollVPage(false);
                    return true;
                case Keys.PageDown:
                    _flexDesigner.ScrollVPage(true);
                    return true;
                case Keys.Add:
                    _flexDesigner.ExpandSelected(false);
                    return true;
                case Keys.Subtract:
                    _flexDesigner.ExpandSelected(true);
                    return true;
                //
                case Keys.A | Keys.Control:
                    _flexDesigner.SelectAll();
                    return true;
                // Cut/delete/copy/paste:
                case Keys.Delete | Keys.Shift:
                case Keys.X | Keys.Control:
                    Designer_DoCut();
                    return true;
                case Keys.Delete:
                    Designer_DoDelete();
                    return true;
                case Keys.C | Keys.Control:
                case Keys.Insert | Keys.Control:
                    Designer_DoCopy();
                    return true;
                case Keys.Insert | Keys.Shift:
                case Keys.V | Keys.Control:
                    Designer_DoPaste();
                    return true;
                // Big moves:
                case Keys.Right:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.MoveSelection(D, 0);
                    return true;
                case Keys.Left:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.MoveSelection(-D, 0);
                    return true;
                case Keys.Down:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.MoveSelection(0, D);
                    return true;
                case Keys.Up:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.MoveSelection(0, -D);
                    return true;
                // Small moves:
                case Keys.Alt | Keys.Right:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.MoveSelection(d, 0);
                    return true;
                case Keys.Alt | Keys.Left:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.MoveSelection(-d, 0);
                    return true;
                case Keys.Alt | Keys.Down:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.MoveSelection(0, d);
                    return true;
                case Keys.Alt | Keys.Up:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.MoveSelection(0, -d);
                    return true;
                // Big resize:
                case Keys.Shift | Keys.Right:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.ResizeSelection(D, 0);
                    return true;
                case Keys.Shift | Keys.Left:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.ResizeSelection(-D, 0);
                    return true;
                case Keys.Shift | Keys.Down:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.ResizeSelection(0, D);
                    return true;
                case Keys.Shift | Keys.Up:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.ResizeSelection(0, -D);
                    return true;
                // Small resize:
                case Keys.Alt | Keys.Shift | Keys.Right:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.ResizeSelection(d, 0);
                    return true;
                case Keys.Alt | Keys.Shift | Keys.Left:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.ResizeSelection(-d, 0);
                    return true;
                case Keys.Alt | Keys.Shift | Keys.Down:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.ResizeSelection(0, d);
                    return true;
                case Keys.Alt | Keys.Shift | Keys.Up:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.ResizeSelection(0, -d);
                    return true;
#if todo // maybe?
                // new field
                case Keys.Control | Keys.N:
                    _flexDesigner.UndoSaveState();
                    _flexDesigner.CreateFieldWithMouse("new field text");
                    return true;
#endif
            }
            return false;
        }


        private void _reportList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // show design view
            _flexDesigner.CreateFieldInfo = null;
            ReportDesignMode = true;

            // get selected report
            C1FlexReport rpt = _reportList.SelectedItem != null ? _reportList.SelectedItem.Report : null;

            // unhook old report from designer
            if (_flexDesigner.Report != null)
                _flexDesigner.Report.Site = null;

            // hook up custom editors and site (used to initialize editors)
            if (rpt != null)
                rpt.Site = (ISite)this;

            _flexDesigner.Report = rpt;

            // save the name of last edited report:
            if (_reportList.SelectedItem != null)
            {
                AppSettings.SaveValue(AppSettings.c_lastLoadedFile, _fileName);
                AppSettings.SaveValue(AppSettings.c_lastLoadedReport, _reportList.SelectedItem.Text);
            }
        }

        private void _reportList_DoubleClick(object sender, EventArgs e)
        {
            DoPreview();
        }

        private void _reportList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // get new name
            // ** note that newName is empty when you close the editor without changing anything,
            //    seems like a bug in the ListView control
            string newName = (e.Label == null) ? string.Empty : e.Label.Trim();

            // make sure new name is Valid (not empty and unique)
            ReportItem item = _reportList.Items[e.Item] as ReportItem;
            if (!IsUniqueName(item.Report, newName))
            {
                if (newName.Length > 0)
                {
                    MessageForm.Warn(Strings.MainForm.ReportNameMustBeUnique);
                }
                e.CancelEdit = true;
                return;
            }

            // save new report name
            ReportItem ri = _reportList.Items[e.Item] as ReportItem;
            ri.Report.ReportName = newName;

            // refresh property grid to show new report name
            _propGrid.Refresh();

            // update report list (to feed subreport TypeConverter)
            _dirty = true;
            UpdateUI(true);
            UpdateReportList();
        }

        private void _reportList_MouseDown(object sender, MouseEventArgs e)
        {
            // keep info to start dragging on mouse move
            if (e.Button == MouseButtons.Left)
            {
                _downIndex = _reportList.SelectedIndex;
                _downPoint = new Point(e.X, e.Y);
            }
        }

        private void _reportList_MouseMove(object sender, MouseEventArgs e)
        {
            // start dragging if...
            if ((Control.MouseButtons & MouseButtons.Left) != 0 &&	// left button is down, and
                _downIndex > -1 &&									// a report was selected, and
                _downIndex == _reportList.SelectedIndex &&			// still is, and
                (Math.Abs(_downPoint.X - e.X) > DRAG_THRESHOLD ||				// the mouse has moved at least
                Math.Abs(_downPoint.Y - e.Y) > DRAG_THRESHOLD))					// 3 pixels
            {
                // get report to drag
                ReportItem ri = _reportList.SelectedItem;

                // start dragging the report
                _dragSource = true;
                DragDropEffects effect = _reportList.DoDragDrop(BuildDataObject(), DragDropEffects.Copy | DragDropEffects.Move);
                _dragSource = false;
                System.Diagnostics.Debug.WriteLine(string.Format("DoDragDrop returned {0}", effect));

                // if it was a move, delete the report...
                if (effect == DragDropEffects.Move)
                    DeleteReport(ri, true);
            }
        }

        private void _reportList_DragOver(object sender, DragEventArgs e)
        {
            // dragging report definition files
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                string[] fn = e.Data.GetData("FileDrop") as string[];
                if (fn != null && fn.Length == 1 && Path.GetExtension(fn[0]).ToLower().IndexOf('x') > -1)
                {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }

            // dragging reports
            if (GetReportDataPresent(e.Data))
            {
                // default behavior: copy with ctrl key
                e.Effect = ((Control.ModifierKeys & Keys.Control) != 0) ? DragDropEffects.Copy : DragDropEffects.Move;

                // only copy is allowed when source == target and the list is sorted
                if (_dragSource && SortReportList)
                {
                    e.Effect = DragDropEffects.Copy;
                }

                return;
            }
        }

        private void _reportList_DragDrop(object sender, DragEventArgs e)
        {
            // dropping report definition files
            if (e.Effect == DragDropEffects.Copy)
            {
                string[] fn = e.Data.GetData("FileDrop") as string[];
                if (fn != null && fn.Length > 0)
                {
                    OpenFile(fn[0]);
                    return;
                }
            }

            // dropping reports
            if (GetReportDataPresent(e.Data))
            {
                PasteDataObject(e.Data);
            }
        }

        private void _dataTree_SelectedDataObjectChanged(object sender, EventArgs e)
        {
            UpdateDataTreeUI();
        }

        private void UpdateDataTreeUI()
        {
            cAddDataSource.Enabled = _dataTree.CanAddDataSource;
            cAddParameter.Enabled = _dataTree.CanAddParameter;
            cAddCalculatedField.Enabled = _dataTree.CanAddCalculatedField;
            cAddSort.Enabled = _dataTree.CanAddSort;
            cDataTreeDelete.Enabled = _dataTree.CanDelete;
            cDataTreeInsert.Enabled = _dataTree.CanInsert;
            cDataTreeInplaceEdit.Enabled = _dataTree.CanInplaceEdit;
            cDataTreeChangeSortOrder.Enabled = _dataTree.CanChangeSortOrder;
            cDataTreeEdit.Enabled = _dataTree.CanEdit;
            cDataTreeMoveUp.Enabled = _dataTree.CanMoveUp;
            cDataTreeMoveDown.Enabled = _dataTree.CanMoveDown;
            cDataSourceRefresh.Enabled = _dataTree.CanRefresh;
            //
            if (_dataTree.ContainsFocus || FlexReportDesignerApp.Controls.DataTree.IsDataObject(EditableModel.GetInstance(_propGrid.SelectedObject)))
            {
                UpdatePropertyGrid(new object[] { _dataTree.SelectedDataObject }, true);
                _fieldPicker.SelectOneOffItem(_dataTree.SelectedDataObject);
            }
        }

        private void UpdatedErrorListUI()
        {
            // cErrorListHide
            cErrorListClear.Enabled = !_errorList.IsEmpty;
            cErrorListCopy.Enabled = _actions[ActionTypeEnum.ErrorListCopy].Enabled = _errorList.CanCopy;
        }

        #region FlexReportDesigner event handlers
        private void _flexDesigner_SelectionChanged(object sender, EventArgs e)
        {
            if (_flexDesigner.ContainsFocus)
                OnFlexDesignerSelectionChanged(false);
        }
        private void OnFlexDesignerSelectionChanged(bool dataToo)
        {
            // NOTE: this is a temp (cause I'm afraid to change much now) clutch. we need to unify all 'selected objects' and handle them in a uniform way
            if (_flexDesigner.IsInplaceParagraphEditing)
            {
                UpdatePropertyGrid(new object[] { _flexDesigner.SelectedInplaceObject }, true);
                UpdateUI(dataToo);
                ShowStatus();
            }
            else
            {
                var selection = _flexDesigner.SelectedObjects;
                UpdatePropertyGrid(selection.ToArray(), true);
                UpdateUI(dataToo);
                ShowStatusOfObject(selection.Count == 1 ? selection[0] : null);
            }
        }
        private void _flexDesigner_InplaceEditingChanged(object sender, EventArgs e)
        {
            OnFlexDesignerSelectionChanged(true);
        }
        private void _flexDesigner_ReportChanged(object sender, EventArgs e)
        {
            _flexDesigner.UndoClear();
            _errorList.Clear();
            UpdatePropertyGrid(new object[] { _flexDesigner.Report }, true);
            UpdateUI(true);
            UpdateDataTreeUI();
        }
        // Note: this event fires on ANY change to the report definition loaded into the designer.
        // Only other places where we need to raise the dirty flag are "meta" changes such as
        // changing the position of this report in the list etc.
        private void _flexDesigner_ValuesChanged(object sender, ValuesChangedEventArgs e)
        {
            System.Diagnostics.Debug.Assert(_updatesCounter >= 0);
            if (IsUpdating)
                return;
            //System.Diagnostics.Debug.WriteLine("=============== _flexDesigner_ValuesChanged");
            if (e.Cause == ValuesChangedEventArgs.ChangeCause.Undo || e.Cause == ValuesChangedEventArgs.ChangeCause.Redo)
            {
                // Undo/redo recreate the whole report, so we must drop any old objects we might be showing:
                OnFlexDesignerSelectionChanged(true);
                _dirty = e.Dirty;
                OnValuesChanged(_dirty, true);
            }
            else
                OnValuesChanged(true, false);
        }
        /// <summary>
        /// Counter used by BeginUpdates/EndUpdates methods. Used to avoid multiple refreshes when the report is changed by the designer.
        /// See also Being/EndRibbonUpdates().
        /// </summary>
        private int _updatesCounter = 0;
        /// <summary>
        /// Counter used when programmatically changing the ribbon, to prevent reacting to ribbon events as if they have been caused by the user.
        /// </summary>
        private int _suppressRibbonEventActions = 0;
        private void OnValuesChanged(bool dirty, bool updateData)
        {
            _flexDesigner.CreateFieldInfo = null;
            if (dirty)
                _dirty = true;
            UpdateUI(updateData);
            UpdatePropertyGrid();
        }
        /// <summary>
        /// Marks the beginning of multiple updates either to the designer UI,
        /// to the report definition being designed, or both.
        /// This method suppresses UI updates AND ALSO marking the report dirty via 
        /// ValuesChanged handler. You MUST call EndUpdates() when the updates are done.
        /// </summary>
        private void BeginUpdates()
        {
            ++_updatesCounter;
        }
        /// <summary>
        /// Ends multiple updates to the report or UI.
        /// If the dirty parameter is true, marks the report as dirty.
        /// NOTE that passing false does NOT change the _dirty flag.
        /// </summary>
        /// <param name="dirty"></param>
        private void EndUpdates(bool dirty)
        {
            if (--_updatesCounter == 0)
                OnValuesChanged(dirty, false);
        }
        private bool IsUpdating
        {
            get { return _updatesCounter > 0; }
        }
        private void _flexDesigner_ZoomFactorChanged(object sender, EventArgs e)
        {
            UpdateUIZoom(true);
        }
        private void _flexDesigner_DragOver(object sender, DragEventArgs e)
        {
            var dbField = e.Data.GetData(typeof(Flex.FieldInfo));
            var calcField = e.Data.GetData(typeof(Flex.CalculatedField));
            var parameter = e.Data.GetData(typeof(Flex.ReportParameter));
            if (dbField != null || calcField != null || parameter != null)
            {
                Point pt = _flexDesigner.PointToClient(new Point(e.X, e.Y));
                SubSection subSection = _flexDesigner.GetSubSectionAtPoint(pt.X, pt.Y);
                if (subSection == null)
                    return;

                e.Effect = DragDropEffects.Copy;
            }
        }
        private void _flexDesigner_DragDrop(object sender, DragEventArgs e)
        {
            var dbField = e.Data.GetData(typeof(Flex.FieldInfo)) as Flex.FieldInfo;
            var calcField = e.Data.GetData(typeof(Flex.CalculatedField)) as Flex.CalculatedField;
            var parameter = e.Data.GetData(typeof(Flex.ReportParameter)) as Flex.ReportParameter;
            if (dbField == null && calcField == null && parameter == null)
                return;

            Section section;
            SubSection subSection;
            FieldBase dummyField;
            double x, y;
            Point pt = _flexDesigner.PointToClient(new Point(e.X, e.Y));
            if (!_flexDesigner.HitTest(pt.X, pt.Y, out section, out subSection, out dummyField, out x, out y))
                return;

            if (dummyField != null)
                return; // trying to drop onto an existing field - not good?

            // Add new field:
            _flexDesigner.UndoSaveState();
            BeginUpdates();
            // create field - text or picture
            string name = "newField";
            string text = null;
            string picture = null;
            if (dbField != null)
            {
                name = "fld" + dbField.Name;
                if (DataLinkBase.IsImageField(dbField.DataType))
                    picture = dbField.Name;
                else
                    text = "=" + dbField.Name;
            }
            else if (calcField != null)
            {
                name = "calc" + calcField.Name;
                if (DataLinkBase.IsImageField(calcField.Type))
                    picture = calcField.Name;
                else
                    text = "=" + calcField.Name;
            }
            else if (parameter != null)
            {
                name = "par" + parameter.Name;
                text = "=" + parameter.Name + ".DisplayText";
            }
            //
            FieldBase field = null;
            if (picture != null)
            {
                field = new ImageField();
                ((ImageField)field).Picture = picture;
            }
            else
            {
                field = new TextField();
                ((TextField)field).Text = text;
            }
            //
            name = DesignerUtil.MakeUniqueFieldName(_flexDesigner.Report, name, false);
            //
            field.Name = name;
            // Geometry:
            field.Left = x;
            field.Top = y;
            field.Width = cDropFieldWidth;
            field.Height = cDropFieldHeight;
            subSection.Fields.Add(field);
            // Done:
            _flexDesigner.UpdateFromReport();
            EndUpdates(true);
            _flexDesigner.Focus();
            _flexDesigner.SelectField(field, true, true);
        }
        private void _flexDesigner_DoubleClick(object sender, EventArgs e)
        {
            _flexDesigner.DoDoubleClick();
        }
        private void _flexDesigner_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = DesignerHandleKeyDown(e.KeyData);
        }
        void _flexDesigner_GotFocus(object sender, EventArgs e)
        {
            _flexDesigner_SelectionChanged(sender, e);
        }
        #endregion

        private void _designer_KeyDown(object sender, KeyEventArgs e)
        {
            /*// switch focus to grid when user starts typing text
            if (!e.Alt && !e.Control && char.IsLetterOrDigit((char)e.KeyValue))
            {
                _propGrid.Focus();
            }

            // ignore delete key (we're handling it on the main form)
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }*/
        }

        private void CreatePendingUndoState()
        {
            System.Diagnostics.Debug.Assert(_pendingUndoState == null);
            if (_pendingUndoState == null && _flexDesigner.Report != null)
                _pendingUndoState = _flexDesigner.Undo_CreateSavedState(false);
        }

        private void DiscardPendingUndoState()
        {
            if (_pendingUndoState != null)
            {
                _flexDesigner.Undo_DiscardSavedState(_pendingUndoState, false);
                _pendingUndoState = null;
            }
        }

        internal void PushPendingUndoState()
        {
            if (_pendingUndoState != null)
            {
                _flexDesigner.Undo_PushSavedState(_pendingUndoState, false);
                _pendingUndoState = null;
            }
        }

        void _propGrid_Enter(object sender, EventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine("==========>>> ENTER _propGrid");
            System.Diagnostics.Debug.Assert(_pendingUndoState == null);
            CreatePendingUndoState();
        }

        void _propGrid_Leave(object sender, EventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine("==========>>> LEAVE _propGrid");
            DiscardPendingUndoState();
        }

        void _propGrid_GotFocus(object sender, EventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine("==========>>> _propGrid_GotFocus");
        }

        void _propGrid_LostFocus(object sender, EventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine("==========>>> _propGrid_LostFocus");
        }

        private void _propGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine("==========>>> _propGrid_PropertyValueChanged");

            PushPendingUndoState();
            if (_propGrid.ContainsFocus)
            {
                // System.Diagnostics.Debug.WriteLine("==========>>> _propGrid_PropertyValueChanged - creating undo state");
                CreatePendingUndoState();
            }

            // apply changes to designer and, for some properties, to other elements:
            var propName = e.ChangedItem.PropertyDescriptor.Name;
            switch (propName)
            {
                case "Name":
                    // update field picker when the user changes field/section names
                    _fieldPicker.Refresh();
                    _flexDesigner.Refresh();
                    _flexDesigner.UpdateFromReport();
                    break;
                case "ReportName":
                    // update list to ensure unique names and to update report list
                    ReportItem item = _reportList.SelectedItem as ReportItem;
                    if (EnsureUniqueName(item.Report))
                        _propGrid.Invalidate();
                    item.Text = item.Report.ReportName;
                    UpdateReportList();
                    _flexDesigner.Refresh();
                    break;
                case "Subreport":
                    // update icons to show reports that contain subreports
                    _reportList.UpdateIcons();
                    _flexDesigner.Refresh();
                    break;
                case "ColumnLayout":
                case "Left":
                case "Top":
                case "Right":
                case "Bottom":
                case "Width":
                case "Height":
                case "X":
                case "Y":
                    // For geometry related properties, we need to update the designer.
                    // For everything else, just refresh the grid as the designer does not cache
                    // sections/sub/fields' properties:
                    BeginUpdates();
                    _flexDesigner.ValidateReportGeometry();
                    EndUpdates(false);
                    _flexDesigner.UpdateFromReport();
                    DiscardPendingUndoState();
                    CreatePendingUndoState();
                    break;
                case "ZOrder":
                    _flexDesigner.Report.SortFields();
                    _flexDesigner.UpdateFromReport();
                    DiscardPendingUndoState();
                    CreatePendingUndoState();
                    break;
                default:
                    _flexDesigner.Refresh();
                    break;
            }

            // remember whether we're dirty
            _dirty = true;
            // changing parameters may change data sources:
            foreach (object o in _propGrid.SelectedObjects)
                if (EditableModel.GetInstance(o) is ReportParameter)
                {
                    var report = _flexDesigner.Report;
                    if (report != null)
                        foreach (var ds in report.DataSources)
                            ds.ResetDataSourceInfo();
                    break;
                }
            // Update UI including data (async):
            UpdateUI(true, true);
            // Update data tree if needed:
            foreach (object o in _propGrid.SelectedObjects)
                if (FlexReportDesignerApp.Controls.DataTree.IsDataObject(EditableModel.GetInstance(o)))
                {
                    _dataTree.UpdateFromReport();
                    break;
                }
            //
            ShowStatusOfObject(_propGrid.SelectedObject);
        }

        private void rbnMain_RibbonEvent(object sender, RibbonEventArgs e)
        {
            if (IsUpdating || _suppressRibbonEventActions > 0)
                return;

            //
            switch (e.EventType)
            {
                case RibbonEventType.Click:
                    RibbonClick(e.Item as RibbonItem);
                    break;
                case RibbonEventType.SelectedColorChanged:
                    RibbonColorChanged(e.Item as RibbonColorPicker);
                    break;
                case RibbonEventType.ChangeCommitted:
                    RibbonChangeCommitted(e.Item as RibbonItem);
                    break;
                case RibbonEventType.ChangeCanceled:
                    RibbonChangeCanceled(e.Item as RibbonItem);
                    break;
                case RibbonEventType.DropDown:
                    RibbonDropDown(e.Item as RibbonItem);
                    break;
            }
        }

        private void chMain_CommandClick(object sender, CommandClickEventArgs e)
        {
            if (e.Command == cmNewReport || e.Command == cNewReportWizard)
                AddWizardReport();
            else if (e.Command == cNewReportEmpty)
                AddEmptyReport();
            else if (e.Command == cPasteReport)
                DoPasteReport();
            else if (e.Command == cCutReport)
                DoCutReport();
            else if (e.Command == cCopyReport)
                DoCopyReport();
            else if (e.Command == cDeleteReport)
                DoDeleteReport();
            else if (e.Command == cMoveReportUp)
                DoMoveReportUp();
            else if (e.Command == cMoveReportDown)
                DoMoveReportDown();
            else if (e.Command == cmProperties)
                DoShowPropertyGrid();
            else if (e.Command == cPropertiesAlphabetical)
                DoPropertiesAlphabetical();
            else if (e.Command == cPropertiesCategorized)
                DoPropertiesCategorized();
            else if (e.Command == cmSelectAll)
                DoSelectAll();
            else if (e.Command == cmCutField)
                Designer_DoCut();
            else if (e.Command == cmCopyField)
                Designer_DoCopy();
            else if (e.Command == cmPasteField)
                Designer_DoPaste();
            else if (e.Command == cmDeleteField)
                Designer_DoDelete();
            else if (e.Command == cmBringToFront)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.BringToFront);
            else if (e.Command == cmSendToBack)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.SendToBack);
            else if (e.Command == cLockFields)
                DoLockFields();
            else if (e.Command == cScriptEditor)
                DoScriptEditor();
            // DataTree / DataSources commands:
            else if (e.Command == cAddDataSource)
                DoDataSourcesAction((Func<DataSource>)DataSources_AddDataSource, null);
            else if (e.Command == cAddParameter)
                DoAddParameter();
            else if (e.Command == cAddCalculatedField)
                DoAddCalculatedField();
            else if (e.Command == cAddSort)
                DoAddSortDefinition();
            else if (e.Command == cDataTreeDelete)
                DoDataTreeDelete();
            else if (e.Command == cDataTreeInplaceEdit)
                _dataTree.StartInplaceEdit();
            else if (e.Command == cDataTreeChangeSortOrder)
                DoDataTreeChangeSortOrder();
            else if (e.Command == cDataTreeEdit)
                DoDataTreeEdit();
            else if (e.Command == cDataTreeMoveUp)
                DoDataTreeMoveUp();
            else if (e.Command == cDataTreeMoveDown)
                DoDataTreeMoveDown();
            else if (e.Command == cDataSourceRefresh)
                DoDataSourceRefresh();
            // ErrorList:
            else if (e.Command == cErrorListHide)
                dtpErrors.TabVisible = false;
            else if (e.Command == cErrorListClear)
            {
                _errorList.Clear();
                UpdateUI(false);
            }
            else if (e.Command == cErrorListCopy)
                _errorList.Copy();
        }

        private void rbtnCloseSearch_Click(object sender, EventArgs e)
        {
            DoCloseSearch();
        }

        private void rebSearchText_TextChanged(object sender, EventArgs e)
        {
            DoSetSearchText();
        }

        private void rbtnSearchNext_Click(object sender, EventArgs e)
        {
            DoSearchNext();
        }

        private void rbtnSearchPrev_Click(object sender, EventArgs e)
        {
            DoSearchPrev();
        }

        private void rbtnMatchCase_Click(object sender, EventArgs e)
        {
            DoMatchCase();
        }

        private void rbtnMatchWholeWord_Click(object sender, EventArgs e)
        {
            DoWholeWord();
        }

        private void rbtnViewSinglePage_Click(object sender, EventArgs e)
        {
            DoPageLayout(sender as RibbonItem);
        }

        private void rbtnRotateViewCW_Click(object sender, EventArgs e)
        {
            DoRotateView(true);
        }

        private void rbtnRotateViewCCW_Click(object sender, EventArgs e)
        {
            DoRotateView(false);
        }

        private int ZoomFactorToZoomSlider(int zoomFactor)
        {
            return _zoomSliderScale == null ? rtbZoom.Value : _zoomSliderScale.SliderValue(zoomFactor / 100f);
        }

        private float ZoomSliderToZoomFactor(int zoomSlider)
        {
            return _zoomSliderScale == null ? 1 : (float)_zoomSliderScale.ZoomFactor(zoomSlider);
        }

        private void rtbZoom_Scroll(object sender, EventArgs e)
        {
            if (IsUpdating)
                return;
            float zoom = ZoomSliderToZoomFactor(rtbZoom.Value);
            if (ReportDesignMode)
                _flexDesigner.ZoomFactor = zoom;
            else
                _flexViewer.ZoomFactor = zoom;
        }

        private void rbtnRenderError_Click(object sender, EventArgs e)
        {
            DoErrorToClipboard();
        }

        private void rcmbBorderWidth_ChangeCommitted(object sender, EventArgs e)
        {
            DoBorderWidth();
        }

        #region Splash
        private static AppAboutForm s_appAboutForm = null;

        private static AppAboutForm NewAppAboutForm()
        {
            return new AppAboutForm(Strings.MainForm.NameInAboutBox);
        }

        public static void ShowSpash()
        {
            s_appAboutForm = NewAppAboutForm();
            s_appAboutForm.TopMost = true;
            s_appAboutForm.ShowInTaskbar = false;
            s_appAboutForm.ButtonOK.Visible = false;
            s_appAboutForm.TextBoxInfo.ScrollBars = ScrollBars.None;

            //
            s_appAboutForm.Show();
            Application.DoEvents();
        }

        public static void HideSpash()
        {
            if (s_appAboutForm != null)
            {
                s_appAboutForm.Hide();
                s_appAboutForm.Dispose();
                s_appAboutForm = null;
            }
        }
        #endregion

        private void _flexDesigner_CreateField(object sender, CreateFieldEventArgs e)
        {
            // Redirect the call because VS WinForms desiger adds event handler here (in MainForm.cs).
            flexDesigner_CreateField(sender, e);
        }

        private const string c_SettingsPersisterServiceNamePrefix = "pvo_";
        void ISettingsPersisterService.SaveObject(string name, object obj)
        {
            AppSettings.SaveObject(c_SettingsPersisterServiceNamePrefix + name, obj);
        }

        void ISettingsPersisterService.LoadObject(string name, object obj)
        {
            AppSettings.LoadObject(c_SettingsPersisterServiceNamePrefix + name, obj);
        }

        void ISettingsPersisterService.SaveValue(string name, string value)
        {
            AppSettings.SaveValue(c_SettingsPersisterServiceNamePrefix + name, value);
        }
        string ISettingsPersisterService.LoadValue(string name)
        {
            return AppSettings.LoadValue(c_SettingsPersisterServiceNamePrefix + name);
        }

        private void rbtnStatusZoom_Click(object sender, EventArgs e)
        {
            if (!ReportDesignMode)
                _flexViewer.ShowZoomDialog();
        }

        C1FlexReport IGetReportsService.Report
        {
            get { return _flexDesigner.Report; }
        }

        /// <summary>
        /// Gets the list of report objects in the currently loaded XML report def file.
        /// </summary>
        IEnumerable<C1FlexReport> IGetReportsService.GetReportList()
        {
            List<C1FlexReport> list = new List<C1FlexReport>();
            foreach (ReportItem item in _reportList.Items)
                list.Add(item.Report);
            return list;
        }

        #region ISubreportDesignService
        private void DoLinkSubreport(FieldBase field)
        {
            var state = _flexDesigner.Undo_CreateSavedState();

            using (LinkSubreportForm dlg = new LinkSubreportForm(_flexDesigner))
            {
                if (dlg.Init(field))
                {
                    DialogResult dr = dlg.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        _flexDesigner.Undo_PushSavedState(state);
                    }
                    else
                    {
                        // _flexDesigner.Undo_RestoreSavedState(state);
                        _flexDesigner.Undo_DiscardSavedState(state);
                    }
                }
            }
        }

        // start editing currently selected subreport
        private void GoToSubreport(C1FlexReport subReport)
        {
            if (subReport == null)
                return;

            for (int i = 0; i < _reportList.Items.Count; i++)
            {
                ReportItem ri = _reportList.Items[i] as ReportItem;
                if (ri != null && ri.Report.ReportName == subReport.ReportName)
                {
                    _reportList.SelectedIndex = i;
                    break;
                }
            }
        }

        void ISubreportDesignService.LinkSubreport(SubreportField masterField)
        {
            DoLinkSubreport(masterField);
        }

        void ISubreportDesignService.LinkSubreport(Field masterField)
        {
            DoLinkSubreport(masterField);
        }

        void ISubreportDesignService.GoToSubreport(C1FlexReport subReport)
        {
            GoToSubreport(subReport);
        }
        #endregion

        #region ITooltipService
        private bool _suspendTooltipService = false;
        void ITooltipService.SetToolTip(Control control, string text)
        {
            if (!_suspendTooltipService)
                rbnMain.SetToolTip(control, text);
        }
        string ITooltipService.GetToolTip(Control control)
        {
            return rbnMain.GetToolTip(control);
        }
        void ITooltipService.ClearToolTip(Control control)
        {
            rbnMain.SetToolTip(control, null);
        }
        #endregion

        #region IScriptValueListService
        void IScriptValueListService.FillListWithFields(IList list, C1FlexReport report, DataSource ds, ScriptEditorContextKind contextKind, bool imageFieldsToo)
        {
            ScriptValueList.FillListWithFields(list, report, ds, contextKind, imageFieldsToo);
        }

        void IScriptValueListService.FillListWithSortDirections(IList list)
        {
            ScriptValueList.FillListWithSortDirections(list);
        }
        #endregion

        #region IDirtyStateService
        bool IDirtyStateService.IsDirty
        {
            get { return _dirty; }
        }
    }
    #endregion
}