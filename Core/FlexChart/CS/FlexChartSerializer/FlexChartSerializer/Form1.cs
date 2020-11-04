using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;

using C1.Win.Chart;
using C1.Chart.Serialization;

namespace FlexChartSerializer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FlexChartBase SelectedChart
        {
            get
            {
                FlexChartBase chart = null;

                switch (tabControl2.SelectedTab.Text)
                {
                    case "FlexChart":
                        chart = flexChart1;
                        break;

                    case "FlexPie":
                        chart = flexPie1;
                        break;
                }

                return chart;
            }
        }
        private string SelectedFormat
        {
            get { return tabControl1.SelectedTab.Text; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPageFlexChart;

            flexChart1.BeginUpdate();

            flexChart1.Header.Content = "2010";

            flexChart1.Series.Clear();

            // Add data series
            var s1 = new Series();
            s1.Style.FillColor = Color.Red;
            s1.Binding = s1.Name = "Sales";
            flexChart1.Series.Add(s1);

            var s2 = new Series();
            s2.Style.FillColor = Color.Blue;
            s2.Binding = s2.Name = "Expenses";
            flexChart1.Series.Add(s2);

            flexChart1.BackColor = Color.White;
            flexChart1.ForeColor = Color.DarkBlue;

            // Set x-binding and add data to the chart
            flexChart1.BindingX = "Country";
            flexChart1.DataSource = new[]{
                new { Country = "UK", Sales = 5, Expenses = 4},
                new { Country = "USA", Sales = 7, Expenses = 3},
                new { Country = "Germany", Sales = 8, Expenses = 5},
                new { Country = "Japan", Sales = 12, Expenses = 8},
            };

            flexChart1.EndUpdate();
        }

        #region Formatting Support Routines
        string BinaryBytesToHexString(byte[] bytes, int bytesPerLine)
        {
            StringBuilder sb = new StringBuilder(bytes[0].ToString("X2") + " ");
            for (int b = 1; b < bytes.Length; b++)
                sb.Append(bytes[b].ToString("X2") + ((((b + 1) % bytesPerLine) == 0) ? "\r\n" : " "));

            if ((bytes.Length % bytesPerLine) != 0)
            {
                sb.Length -= 1;
                sb.AppendLine();
            }
            return sb.ToString();
        }

        byte[] HexToBinaryBytes(string hexString)
        {
            byte[] result = null;

            string hs = hexString.Replace(" ", "").Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace("\t", "").ToUpper();
            if ((hs.Length & 1) == 0)        // must be even number
            {
                byte[] res = new byte[hs.Length / 2];
                for (int b = 0; b < res.Length; b++)
                {
                    char c0 = hs[2 * b + 0];
                    char c1 = hs[2 * b + 1];

                    int bval = ((((c0 >= '0' && c0 <= '9') ? (c0 - '0') : (c0 - 'A' + 10))) << 4) +
                        ((c1 >= '0' && c1 <= '9') ? (c1 - '0') : (c1 - 'A' + 10));

                    res[b] = (byte)bval;
                }
                result = res;
            }
            return result;
        }

        #endregion

        #region Button Events
        private void btnSerialize_Click(object sender, EventArgs e)
        {
            byte[] chartBytes = null;

            FlexChartBase chartBase = SelectedChart;

            if(chartBase != null)
            {
                txtXml.Text = Serializer.SerializeChartToXml(chartBase);
                txtJson.Text = Serializer.SerializeChartToJson(chartBase);
                chartBytes = Serializer.SerializeChartToBytes(chartBase);
            }
            else
            {
                txtXml.Text = null;
                txtJson.Text = null;
                txtBinary.Text = null;
                txtBase64.Text = null;
            }

            if (chartBytes != null)
            {
                // Display the byte[] data in nice hex format.
                txtBinary.Text = BinaryBytesToHexString(chartBytes, 20);

                // Also display the byte[] data in a nice base64 string format.
                txtBase64.Text = Convert.ToBase64String(chartBytes, Base64FormattingOptions.InsertLineBreaks);
            }
        }

        private void btnDeserializeTab_Click(object sender, EventArgs e)
        {
            FlexChartBase chartBase = SelectedChart;
            bool isSerialized = false;
            try
            {
                switch (SelectedFormat)
                {
                    case "Xml": // xml
                        isSerialized = !string.IsNullOrEmpty(txtXml.Text);
                        if (isSerialized)
                            Serializer.DeserializeChartFromXml(chartBase, txtXml.Text);
                        break;

                    case "Json": // json
                        isSerialized = !string.IsNullOrEmpty(txtJson.Text);
                        if (isSerialized)
                            Serializer.DeserializeChartFromJson(chartBase, txtJson.Text);
                        break;

                    case "Binary": // binary (hex format)
                        isSerialized = !string.IsNullOrEmpty(txtBinary.Text);
                        if (isSerialized)
                            Serializer.DeserializeChartFromBytes(chartBase, HexToBinaryBytes(txtBinary.Text));
                        break;

                    case "Base64": // binary (base64 format)
                        isSerialized = !string.IsNullOrEmpty(txtBase64.Text);
                        if (isSerialized)
                            Serializer.DeserializeChartFromBytes(chartBase, Convert.FromBase64String(txtBase64.Text));
                        break;
                }
            }
            catch { isSerialized = false; }

            if (!isSerialized)
            {
                MessageBox.Show("The tab does not contain valid serialized data.");
            }
        }

        private void btnSaveTabToFile_Click(object sender, EventArgs e)
        {
            string filter = null;
            string stringForFile = null;
            byte[] bytesForFile = null;

            switch (SelectedFormat)
            {
                case "Xml": // xml
                    stringForFile = txtXml.Text;
                    filter = "XML File (*.xml)|*.xml|All Files (*.*)|*.*";
                    break;

                case "Json": // json
                    stringForFile = txtJson.Text;
                    filter = "JSON File (*.json)|*.json|All Files (*.*)|*.*";
                    break;

                case "Binary": // binary (hex format)
                    bytesForFile = HexToBinaryBytes(txtBinary.Text);
                    filter = "Binary File (*.bin)|*.bin|All Files (*.*)|*.*";
                    break;

                case "Base64": // binary (base64 format)
                    bytesForFile = Convert.FromBase64String(txtBase64.Text);
                    filter = "Base64 File (*.base64)|*.base64|All Files (*.*)|*.*";
                    break;
            }

            if (string.IsNullOrEmpty(stringForFile) && (bytesForFile == null || bytesForFile.Length == 0))
            {
                MessageBox.Show("The tab does not contain serialized data.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.OverwritePrompt = true;
            sfd.Filter = filter;
            sfd.FilterIndex = 0;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (stringForFile != null)
                    File.WriteAllText(sfd.FileName, stringForFile);

                if (bytesForFile != null)
                    File.WriteAllBytes(sfd.FileName, bytesForFile);
            }
        }

        private void btnSerializeToFile_Click(object sender, EventArgs e)
        {
            string filter = null;
            string format = null;

            switch (SelectedFormat)
            {
                case "Xml": // xml
                    format = "xml";
                    filter = "XML File (*.xml)|*.xml|All Files (*.*)|*.*";
                    break;

                case "Json": // json
                    format = "json";
                    filter = "JSON File (*.json)|*.json|All Files (*.*)|*.*";
                    break;

                case "Binary": // binary (hex format)
                    format = "binary";
                    filter = "Binary File (*.bin)|*.bin|All Files (*.*)|*.*";
                    break;

                case "Base64": // binary (base64 format)
                    format = "base64";
                    filter = "Base64 File (*.base64)|*.base64|All Files (*.*)|*.*";
                    break;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.OverwritePrompt = true;
            sfd.Filter = filter;
            sfd.FilterIndex = 0;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Serializer.SerializeChartToFile(sfd.FileName, SelectedChart, format);
            }
        }

        private void btnDeserializeFromFile_Click(object sender, EventArgs e)
        {
            string filter = null;
            string format = null;

            switch (SelectedFormat)
            {
                case "Xml": // xml
                    format = "xml";
                    filter = "XML File (*.xml)|*.xml|All Files (*.*)|*.*";
                    break;

                case "Json": // json
                    format = "json";
                    filter = "JSON File (*.json)|*.json|All Files (*.*)|*.*";
                    break;

                case "Binary": // binary (hex format)
                    format = "binary";
                    filter = "Binary File (*.bin)|*.bin|All Files (*.*)|*.*";
                    break;

                case "Base64": // binary (base64 format)
                    format = "base64";
                    filter = "Base64 File (*.base64)|*.base64|All Files (*.*)|*.*";
                    break;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Filter = filter;
            ofd.FilterIndex = 0;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bool success = true;
                try
                {
                    Serializer.DeserializeChartFromFile(ofd.FileName, SelectedChart, format);
                }
                catch
                {
                    success = false;
                }

                if (!success)
                    MessageBox.Show("The file does not contain properly serialized data.");
            }
        }
        #endregion
    }
}

