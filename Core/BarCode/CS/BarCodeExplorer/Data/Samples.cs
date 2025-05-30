﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace BarCodeExplorer.Samples
{
    /// <summary>
    /// The sample description
    /// </summary>
    public class SampleItem
    {
        #region ** fields

        private Type _sampleType;

        #endregion

        #region ** ctor
        public SampleItem() { }

        /// <summary>
        /// Sample item contructor
        /// </summary>
        /// <param name="name">The name of control</param>
        /// <param name="title">The title of control</param>
        /// <param name="desc">The description of control</param>
        /// <param name="sampleType">Type</param>
        public SampleItem(string name, string title, string desc, Type sampleType)
        {
            if (sampleType == null)
                throw new ArgumentException("sampleType can't be null");
            Name = name;
            Title = title;
            Description = desc;

            _sampleType = sampleType;
        }

        #endregion

        #region ** public fields
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Type SampleType { get => _sampleType; set => _sampleType = value; }
        public Control Sample
        {
            get
            {
                var control = Activator.CreateInstance(_sampleType) as Control;
                return control;
            }
        }

        #endregion
    }

    /// <summary>
    /// The data source of controls
    /// </summary>
    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems;

        static SampleDataSource()
        {
            _allItems = new List<SampleItem>()
            {
                new SampleItem()
                {
                    Name = "Overview",
                    Description = "This view shows all controls included into C1.Win.BarCode assembly",
                    Title = "Overview",
                    SampleType = typeof(Overview)
                },
                new SampleItem()
                {
                    Name = "DataBinding",
                    Description = "This view shows Data Binding with BarCode controls.",
                    Title = "DataBinding",
                    SampleType = typeof(DataBinding)
                },
                new SampleItem()
                {
                    Name ="Dividing",
                    Description = "This view demonstrates how to generate multipart QR code for long text which doesn't fit into the single qr code",
                    Title = "Multipart QR code",
                    SampleType = typeof(DividingQrCode)
                }
            };
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
