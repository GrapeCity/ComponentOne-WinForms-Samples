using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C1Report2Rpx
{
    public partial class ArPreviewForm : BaseForm
    {
        public ArPreviewForm()
        {
            InitializeComponent();
        }

        #region Public
        public void View(
            IWin32Window owner,
            ReportItem reportItem)
        {
            try
            {
                reportItem.RpxData.Seek(0, System.IO.SeekOrigin.Begin);
                avwMain.LoadDocument(reportItem.RpxData, GrapeCity.Viewer.Common.DocumentFormat.Rpx);
            }
            catch (Exception ex)
            {
                Util.MError(owner, Strings.ArPreviewForm.CanNotLoadReport, ex.Message);
                return;
            }

            ShowDialog(owner);
        }
        #endregion

        #region Public static
        public static void DoView(
            IWin32Window owner,
            ReportItem reportItem)
        {
            using (ArPreviewForm f = new ArPreviewForm())
                f.View(owner, reportItem);
        }
        #endregion
    }
}
