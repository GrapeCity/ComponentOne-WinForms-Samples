using System.Windows.Forms;
using C1.Win.C1Ribbon;
using System.ComponentModel;
using System;
using System.Drawing.Design;

namespace RibbonControls
{
	/// <summary>
	/// The <see cref="ComboBoxHost"/> control wraps standard ComboBox control 
	/// so that it can be used in the <see cref="C1Ribbon"/> control.
	/// </summary>
	[System.ComponentModel.DefaultBindingProperty("SelectedValue")]
	public class ComboBoxHost : RibbonControlHost, IBindableComponent
	{
		#region ** ctor
		public ComboBoxHost()
			: this(new ComboBox())
		{
		}
		public ComboBoxHost(ComboBox box) 
			: base (box)
		{
		}
		#endregion

		#region ** ComboBox & ComboBox interface wrappers
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ComboBox ComboBox
		{
			get
			{
				return (ComboBox)base.Control;
			}
		}

		[Category("Data"), Browsable(false), Bindable(true),
		DefaultValue(null),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public object SelectedValue
		{
			get
			{
				return ComboBox.SelectedValue;
			}
			set
			{
				ComboBox.SelectedValue = value;
			}
		}

		[Category("Data"), Browsable(false), Bindable(true),
		DefaultValue(null),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public object SelectedItem
		{
			get
			{
				return ComboBox.SelectedItem;
			}
			set
			{
				ComboBox.SelectedItem = value;
			}
		}

		[Category("Data"), Description("Indicates the list that this control will use to get its items."),
		AttributeProvider("System.ComponentModel.IListSource"),
		DefaultValue(null),
		RefreshProperties(RefreshProperties.Repaint)]
		public object DataSource
		{
			get
			{
				return ComboBox.DataSource;
			}
			set
			{
				ComboBox.DataSource = value;
			}
		}
		[Category("Data"), Description("Indicates the property to display for the items in the control."),
		Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor"),
		TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design"),
		DefaultValue("")]
		public string DisplayMember
		{
			get
			{
				return ComboBox.DisplayMember;
			}

			set
			{
				ComboBox.DisplayMember = value;
			}
		}

		[Category("Data"), Description("Indicates the property to use as the actual value for the items in the control."),
		Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor"),
		TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design"),
		DefaultValue("")]
		public string ValueMember
		{
			get
			{
				return ComboBox.ValueMember;
			}
			set
			{
				ComboBox.ValueMember = value;
			}
		}
		[Category("Data"), Description("Gets the collection of items in this ComboBox.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design", typeof(UITypeEditor))]
		public ComboBox.ObjectCollection Items
		{
			get
			{
				return ComboBox.Items;
			}
		}

		[Category("Behavior"), Description("Indicates whether the code or the operating system will handle drawing of elements in the list.")]
		[DefaultValue(DrawMode.Normal)]
		public DrawMode DrawMode
		{
			get
			{
				return ComboBox.DrawMode;
			}
			set
			{
				ComboBox.DrawMode = value;
			}
		}

		[Category("Appearance"), Description("Controls the appearance and functionality of the ComboBox.")]
		[DefaultValue(ComboBoxStyle.DropDown)]
		public ComboBoxStyle DropDownStyle
		{
			get
			{
				return ComboBox.DropDownStyle;
			}
			set
			{
				ComboBox.DropDownStyle = value;
			}
		}

		/// <summary>
		/// Raises the <see cref="DrawItem"/> event.
		/// </summary>
		[Category("Appearance"), Description("Occurs when a visual aspect of an owner-drawn ComboBox changes.")]
		public event System.Windows.Forms.DrawItemEventHandler DrawItem; 
		protected virtual void OnDrawItem(System.Windows.Forms.DrawItemEventArgs e)
		{
			if (DrawItem != null)
			{
				DrawItem(ComboBox, e);
			}
		}
		[Category("Property Changed")]
		public event EventHandler SelectedValueChanged;
		protected virtual void OnSelectedValueChanged(EventArgs e)
		{
			if (SelectedValueChanged != null)
			{
				SelectedValueChanged(ComboBox, e);
			}
		}

		protected override void OnSubscribeControlEvents(Control control)
		{
			base.OnSubscribeControlEvents(control);
			ComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(ComboBox_DrawItem);
			ComboBox.SelectedValueChanged += new EventHandler(ComboBox_SelectedValueChanged);
		}

		protected override void OnUnsubscribeControlEvents(Control control)
		{
			base.OnUnsubscribeControlEvents(control);
			ComboBox.DrawItem -= new System.Windows.Forms.DrawItemEventHandler(ComboBox_DrawItem);
			ComboBox.SelectedValueChanged -= new EventHandler(ComboBox_SelectedValueChanged);
		}

		void ComboBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
		{
			OnDrawItem(e);
		}
		void ComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			OnSelectedValueChanged(e);
		}

		#endregion

		#region ** IBindableComponent Members
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public BindingContext BindingContext
		{
			get
			{
				return ComboBox.BindingContext;
			}
			set
			{
				ComboBox.BindingContext = value;
			}
		}

		[Category("Data")]
		public ControlBindingsCollection DataBindings
		{
			get { return ComboBox.DataBindings; }
		}
		#endregion


	}
}