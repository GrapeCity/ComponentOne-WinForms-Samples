using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CollapsedMultiRowHeaders
{
    public partial class Form1 : Form
    {

        #region ** fields

        List<object[]> dataRows = new List<object[]>();

        #endregion

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGrid(c1FlexGrid1);
            GenerateData();
            PopulateGrid(c1FlexGrid1);
            c1FlexGrid1.CollapsedMultiRowHeaders = true;
        }

        void SetupGrid(C1FlexGrid grid)
        {
            grid.Rows.Count = 1;
            grid.Rows.Fixed = 1;
            grid.Cols.Count = 4;
            grid.Cols.Fixed = 3;

            grid.Cols[0].DataType = typeof (string);
            grid.Cols[0].Caption = "Company";
            grid.Cols[0].Name = "Company";

            grid.Cols[1].DataType = typeof (string);
            grid.Cols[1].Caption = "Product";
            grid.Cols[1].Name = "Product";

            grid.Cols[2].DataType = typeof(string);
            grid.Cols[2].Caption = "Country";
            grid.Cols[2].Name = "Country";

            grid.Cols[3].DataType = typeof (short);
            grid.Cols[3].Caption = "Quantity";
            grid.Cols[3].Name = "Quantity";
        }

        void GenerateData()
        {
            if (dataRows.Count == 0)
            {
                Random random = new Random();
                foreach (KeyValuePair<string, string[]> company in Consts.companiesAndProducts)
                {
                    for (int i = 0; i < company.Value.Length; i++)
                    {
                        for (int j = 0; j < Consts.countries.Length; j++)
                        {
                            bool existsInCurrentCiuntry = random.Next(0, 2) == 1;

                            if (existsInCurrentCiuntry)
                            {
                                object[] dataRow = new object[4];

                                dataRow[0] = company.Key;
                                dataRow[1] = company.Value[i];

                                dataRow[2] = Consts.countries[j];

                                // generate quantity
                                dataRow[3] = Convert.ToInt16(random.Next(0, 1000));

                                dataRows.Add(dataRow);
                            }
                        }
                    }
                }
            }
        }

        void PopulateGrid(C1FlexGrid grid)
        {
            for (int i = 0; i < dataRows.Count; i++)
                grid.AddItem(dataRows[i]);
        }
    }
}
