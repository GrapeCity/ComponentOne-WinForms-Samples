using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1InputPanel;

namespace ControlExplorer.InputPanel.ControlHosts
{
    class ComboBoxHost : InputControlHost
    {
        public ComboBoxHost()
            : base(new ComboBox())
        {
        }

        /// <summary>
        /// Gets the hosted ComboBox control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ComboBox ComboBox
        {
            get { return (ComboBox)Control; }
        }
    }
}
