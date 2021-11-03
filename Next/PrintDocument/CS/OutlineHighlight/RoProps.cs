using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectCoordinates
{
    public partial class RoProps : Form
    {
        public PropertyGrid PropertyGrid
        {
            get { return propertyGrid1; }
        }

        public RoProps()
        {
            InitializeComponent();
        }
    }
}