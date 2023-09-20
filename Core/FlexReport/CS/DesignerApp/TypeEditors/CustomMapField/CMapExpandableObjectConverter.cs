//----------------------------------------------------------------------------
// CMapExpandableObjectConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FlexReportDesignerApp.TypeEditors.CustomMapField
{
    class CMapExpandableObjectConverter : ExpandableObjectModelConverter
    {
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            var props = base.GetProperties(context, value, attributes).OfType<PropertyDescriptor>();
            
            // The property window shows all properties,
            // I have not found the reason and the solution.
            // As a workaround, remove [Browsable(false)] proerties
            props = props.Where(p =>
            {
                var browsableAttr = p.Attributes.OfType<BrowsableAttribute>().FirstOrDefault();
                return (browsableAttr == null || browsableAttr.Browsable);
            });
            return new PropertyDescriptorCollection(props.ToArray());
        }
    }
}
