﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1InputPanel;

namespace RowDetails
{
    public partial class DerivedRowDetail : C1InputPanelRowDetail
    {
        public DerivedRowDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used to setup control before showing of it.
        /// </summary>
        /// <param name="parentGrid">FlexGrid which displays detail control.</param>
        /// <param name="rowIndex">Index of parent detail row.</param>
        public override void Setup(C1FlexGrid parentGrid, int rowIndex)
        {
            base.Setup(parentGrid, rowIndex);

            var items = C1InputPanel.Items;

            // remove "EmployeeID" label and input component
            items.RemoveAt(0);
            items.RemoveAt(0);

            // remove "TitleOfCourtesy" label and input component
            items.RemoveAt(6);
            items.RemoveAt(6);

            // remove "Photo" label and input component
            items.RemoveAt(24);
            items.RemoveAt(24);

            // remove "Notes" label and input component
            items.RemoveAt(24);
            items.RemoveAt(24);

            // remove "ReportsTo" label and input component
            items.RemoveAt(24);
            items.RemoveAt(24);

            // add new InputImage item and place it at the zero index
            var photoInputImage = new InputImage();
            photoInputImage.DataField = "Photo";
            photoInputImage.DataSource = C1InputPanel.DataSource;
            photoInputImage.Width = 150;
            photoInputImage.Height = 150;
            photoInputImage.Break = BreakType.Column;
            items.Insert(0, photoInputImage);
        }
    }
}
