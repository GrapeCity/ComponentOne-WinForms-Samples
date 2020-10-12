using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Text;
using System.Xml;

using C1.Win.C1Ribbon;

namespace ControlHostLib
{
    /// <summary>
    /// The Ribbon element that contains a CheckedListBox.
    /// </summary>
    public class CheckedListBoxHost : RibbonControlHost
    {
        public const string XmlNodeName = "checkedListBoxHost";

        //===========================================================================
        #region ** ctor

        /// <summary>
        /// Creates the CheckedListBox control and its host element.
        /// </summary>
        public CheckedListBoxHost()
            : base(new CheckedListBox())
        {
            CheckedListBox.BorderStyle = BorderStyle.None;
            CheckedListBox.CheckOnClick = true;
        }

        #endregion

        //===========================================================================
        #region ** properties

        /// <inheritdoc />
        public override string ControlHostNodeName
        {
            get { return XmlNodeName; }
        }

        /// <summary>
        /// Gets the hosted CheckedListBox control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CheckedListBox CheckedListBox
        {
            get { return (CheckedListBox)Control; }
        }

        /// <summary>
        /// Gets the collection of items in this CheckedListBox.
        /// </summary>
        [Category("Data")]
        [Description("Gets the collection of items in this CheckedListBox.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design", typeof(UITypeEditor))]
        public CheckedListBox.ObjectCollection Items
        {
            get { return CheckedListBox.Items; }
        }

        /// <inheritdoc />
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get { return string.Empty; }
            set { }
        }

        #endregion

        //===========================================================================
        #region ** events

        /// <summary>
        /// Occurs when the checked state of an item changes.
        /// </summary>
        [Category("Behavior")]
        [Description("Occurs when the checked state of an item changes.")]
        public event ItemCheckEventHandler ItemCheck;
        /// <summary>
        /// Raises the <see cref="ItemCheck"/> event.
        /// </summary>
        protected virtual void OnItemCheck(ItemCheckEventArgs e)
        {
            if (ItemCheck != null)
                ItemCheck(this, e);
        }

        #endregion

        //===========================================================================
        #region ** methods

        /// <summary>
        /// Returns a value indicating whether the specified item is checked.
        /// </summary>
        public bool GetItemChecked(int index)
        {
            return CheckedListBox.GetItemChecked(index);
        }
        /// <summary>
        /// Sets the checked state for the item at the specified index.
        /// </summary>
        public void SetItemChecked(int index, bool value)
        {
            CheckedListBox.SetItemChecked(index, value);
        }

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            ((CheckedListBox)control).ItemCheck += new ItemCheckEventHandler(HandleItemCheck);
        }
        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            ((CheckedListBox)control).ItemCheck -= new ItemCheckEventHandler(HandleItemCheck);
        }
        private void HandleItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.OnItemCheck(e);
        }

        protected override void LoadControlHostProperties(XmlNode node)
        {
            base.LoadControlHostProperties(node);

            string s = Read(node, "items", string.Empty);
            if (s.Length > 0)
            {
                string[] arr = s.Split(';');
                for (int i = 0; i < arr.Length; i++)
                {
                    string a = arr[i];
                    Items.Add(a.Substring(1), a.StartsWith("1"));
                }
            }
        }

        protected override void SaveControlHostProperties(XmlWriter writer)
        {
            base.SaveControlHostProperties(writer);

            int count = Items.Count;
            if (count > 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    if (i > 0)
                        sb.Append(';');
                    sb.Append(GetItemChecked(i) ? '1' : '0');
                    sb.Append(Items[i].ToString());
                }
                writer.WriteAttributeString("items", sb.ToString());
            }
        }

        static string Read(XmlNode node, string attName, string defVal)
        {
            XmlAttribute att = node.Attributes[attName];
            if (att != null)
            {
                return att.Value;
            }
            return defVal;
        }

        #endregion
    }
}

