using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SamplesData
{
    [Serializable()]
    public class TypedList<T> : BindingList<T>, ITypedList
    {
        [NonSerialized()]
        private PropertyDescriptorCollection properties;

        public TypedList() : base()
        {
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(
                typeof(T),
                new Attribute[] { new BrowsableAttribute(true) });

            properties = pdc;
        }

        #region ITypedList Implementation

        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            PropertyDescriptorCollection pdc;

            if (listAccessors != null && listAccessors.Length > 0)
            {
                pdc = ListBindingHelper.GetListItemProperties(listAccessors[0].PropertyType);
            }
            else
            {
                pdc = properties;
            }

            return pdc;
        }

        public string GetListName(PropertyDescriptor[] listAccessors)
        {
            return typeof(T).Name;
        }

        #endregion
    }
}
