using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace GridRenderer
{
    [
    ToolboxItem(true),
    ToolboxBitmap(typeof(GridRenderer), "GridRenderer.png"),
    ProvideProperty("Renderer", typeof(C1FlexGridBase)),
    Designer(typeof(GridRendererDesigner))
    ]
    public partial class GridRenderer : 
        Component,
        IExtenderProvider
    {
        //----------------------------------------------------------------------
        #region ** fields

        RendererEditor _editor = new RendererEditor();
        Dictionary<C1FlexGridBase, bool> _grids = new Dictionary<C1FlexGridBase,bool>();

        #endregion

        //----------------------------------------------------------------------
        #region ** ctors

        /// <summary>
        /// Initializes a new instance of a <see cref="GridRenderer"/>.
        /// </summary>
        /// <param name="container"><see cref="IContainer"/> that will host the component.</param>
        public GridRenderer(IContainer container)
        {
            if (container != null)
            {
                container.Add(this);
            }

            InitializeComponent();
        }
        /// <summary>
        /// Initializes a new instance of a <see cref="GridRenderer"/>.
        /// </summary>
        public GridRenderer()
            : this(null)
        {
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** IExtenderProvider

        // provide the extender GridRenderer property to all FlexGrid controls on the form.
        bool IExtenderProvider.CanExtend(object extendee)
        {
            return extendee is C1FlexGridBase;
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** object model

        /// <summary>
        /// Connects or disconnects this <see cref="GridRenderer"/> to a given 
        /// <see cref="C1FlexGrid"/>.
        /// </summary>
        public void SetRenderer(C1FlexGridBase grid, bool value)
        {
            if (value != GetRenderer(grid))
            {
                if (value)
                {
                    _grids[grid] = true;
                    grid.Renderer = _editor.Renderer;
                }
                else
                {
                    _grids.Remove(grid);
                    grid.Renderer = null;
                }
            }
        }
        /// <summary>
        /// Gets a value the determines whether this <see cref="GridRenderer"/> 
        /// is connected to a given <see cref="C1FlexGrid"/>.
        /// </summary>
        [
        Description("Use the selected GridRenderer to control the appearance of the grid."),
        DefaultValue(false)
        ]
        public bool GetRenderer(C1FlexGridBase grid)
        {
            return _grids.ContainsKey(grid);
        }
        /// <summary>
        /// Shows the renderer editor to modify, save, and load renderers.
        /// </summary>
        public bool EditRenderer()
        {
            // show the editor
            if (_editor.ShowDialog() != DialogResult.OK)
            {
                return false; // canceled
            }

            // apply the new renderer to all registered grids
            foreach (var grid in _grids.Keys)
            {
                grid.Renderer = _editor.Renderer;
            }

            // done editing the renderer
            return true;
        }
        /// <summary>
        /// Gets the <see cref="C1FlexGridRenderer"/> hosted by this component. 
        /// </summary>
        [Browsable(false)]
        public C1FlexGridRenderer Renderer
        {
            get { return _editor.Renderer; }
        }
        /// <summary>
        /// Property used to persist the palette as a string.
        /// </summary>
        [
        Browsable(false),
        EditorBrowsable(EditorBrowsableState.Never),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)
        ]
        public string Palette
        {
            get
            {
                // persist current palette as text
                var sb = new StringBuilder();
                _editor.SavePalette(sb, string.Empty);
                return sb.ToString();
            }
            set
            {
                // load palette into editor
                _editor.LoadPaletteXml(value);

                // apply the new renderer to all registered grids
                foreach (var grid in _grids.Keys)
                {
                    grid.Renderer = _editor.Renderer;
                }
            }
        }
        #endregion
    }

    /// <summary>
    /// Designer that provides access to the GridRenderer editor.
    /// </summary>
    class GridRendererDesigner : System.ComponentModel.Design.ComponentDesigner
    {
        // initialize verb
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            Verbs.Add(new System.ComponentModel.Design.DesignerVerb(
                "Edit Renderer...", 
                new EventHandler(EditRenderer)));
        }
        void EditRenderer(object sender, EventArgs e)
        {
            var rp = Component as GridRenderer;
            rp.EditRenderer();
        }
    }
}
