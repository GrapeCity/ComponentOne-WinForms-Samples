using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial19
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button button1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
        private C1.Win.List.C1Combo c1Combo1;
        private DataSet1 dataSet11;
        private DataGrid dataGrid1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.c1Combo1 = new C1.Win.List.C1Combo();
            this.dataSet11 = new Tutorial19.DataSet1();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Update To DataBase";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT     Company, Contacted, CustType, UserCode, LastName, FirstName, Phone\r\nFR" +
    "OM         Customer";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=C:\\Users\\magen_000\\Documents\\Compone" +
    "ntOne Samples\\Common\\c1nwind.mdb;";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Customer` (`Company`, `Contacted`, `CustType`, `UserCode`, `LastName" +
    "`, `FirstName`, `Phone`) VALUES (?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("p1", System.Data.OleDb.OleDbType.VarWChar, 0, "Company"),
            new System.Data.OleDb.OleDbParameter("p2", System.Data.OleDb.OleDbType.Date, 0, "Contacted"),
            new System.Data.OleDb.OleDbParameter("p3", System.Data.OleDb.OleDbType.SmallInt, 0, "CustType"),
            new System.Data.OleDb.OleDbParameter("p4", System.Data.OleDb.OleDbType.VarWChar, 0, "UserCode"),
            new System.Data.OleDb.OleDbParameter("p5", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("p6", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("p7", System.Data.OleDb.OleDbType.Double, 0, "Phone")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("p1", System.Data.OleDb.OleDbType.VarWChar, 0, "Company"),
            new System.Data.OleDb.OleDbParameter("p2", System.Data.OleDb.OleDbType.Date, 0, "Contacted"),
            new System.Data.OleDb.OleDbParameter("p3", System.Data.OleDb.OleDbType.SmallInt, 0, "CustType"),
            new System.Data.OleDb.OleDbParameter("p4", System.Data.OleDb.OleDbType.VarWChar, 0, "UserCode"),
            new System.Data.OleDb.OleDbParameter("p5", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("p6", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("p7", System.Data.OleDb.OleDbType.Double, 0, "Phone"),
            new System.Data.OleDb.OleDbParameter("p8", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Company", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p9", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Company", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p10", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contacted", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p11", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contacted", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p12", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CustType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p13", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustType", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p14", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UserCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p15", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p16", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p17", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p18", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p19", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("p1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Company", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p2", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Company", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p3", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contacted", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p4", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contacted", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p5", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CustType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p6", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustType", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p7", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UserCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p8", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p9", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p10", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p11", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p12", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p13", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Company", "Company"),
                        new System.Data.Common.DataColumnMapping("Contacted", "Contacted"),
                        new System.Data.Common.DataColumnMapping("CustType", "CustType"),
                        new System.Data.Common.DataColumnMapping("UserCode", "UserCode"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT     CustType.*\r\nFROM         CustType";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `CustType` (`TypeId`, `TypeDesc`) VALUES (?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("p1", System.Data.OleDb.OleDbType.VarWChar, 0, "TypeId"),
            new System.Data.OleDb.OleDbParameter("p2", System.Data.OleDb.OleDbType.VarWChar, 0, "TypeDesc")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = "UPDATE `CustType` SET `TypeId` = ?, `TypeDesc` = ? WHERE ((`TypeId` = ?) AND ((? " +
    "= 1 AND `TypeDesc` IS NULL) OR (`TypeDesc` = ?)))";
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("p1", System.Data.OleDb.OleDbType.VarWChar, 0, "TypeId"),
            new System.Data.OleDb.OleDbParameter("p2", System.Data.OleDb.OleDbType.VarWChar, 0, "TypeDesc"),
            new System.Data.OleDb.OleDbParameter("p3", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TypeId", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p4", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p5", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = "DELETE FROM `CustType` WHERE ((`TypeId` = ?) AND ((? = 1 AND `TypeDesc` IS NULL) " +
    "OR (`TypeDesc` = ?)))";
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("p1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TypeId", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("p2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("p3", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CustType", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("TypeId", "TypeId"),
                        new System.Data.Common.DataColumnMapping("TypeDesc", "TypeDesc")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.Caption = "";
            this.c1Combo1.CaptionHeight = 17;
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.ColumnCaptionHeight = 17;
            this.c1Combo1.ColumnFooterHeight = 17;
            this.c1Combo1.ColumnWidth = 100;
            this.c1Combo1.DataMember = "CustType";
            this.c1Combo1.DataSource = this.dataSet11;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.DisplayMember = "CustType.TypeDesc";
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(48, 323);
            this.c1Combo1.MatchEntryTimeout = ((long)(100));
            this.c1Combo1.MaxDropDownItems = ((short)(5));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(240, 24);
            this.c1Combo1.TabIndex = 1;
            this.c1Combo1.Text = "c1Combo1";
            this.c1Combo1.ValueMember = "CustType.TypeId";
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "Customer";
            this.dataGrid1.DataSource = this.dataSet11;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(48, 18);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(538, 268);
            this.dataGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(615, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c1Combo1);
            this.Controls.Add(this.dataGrid1);
            this.Name = "Form1";
            this.Text = "C1List .Net Tutorial19";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //fill the dataset
            this.oleDbConnection1.ConnectionString = AdjustConnectionString();
            this.oleDbDataAdapter1.Fill(this.dataSet11);
            this.oleDbDataAdapter2.Fill(this.dataSet11);

            //Add a relation
            DataColumn parentCol, childCol;
            DataRelation relCustType;
            parentCol = this.dataSet11.Tables["CustType"].Columns["TypeId"];
            childCol = this.dataSet11.Tables["Customer"].Columns["CustType"];
            relCustType = new DataRelation("CustomerType", parentCol, childCol);
            this.dataSet11.Relations.Add(relCustType);

            //Bind the SelectedValue property
            this.c1Combo1.DataBindings.Add("SelectedValue", this.dataSet11, "Customer.CustType");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.oleDbConnection1.Open();
            DataSet ds;
            ds = this.dataSet11.GetChanges(DataRowState.Modified);

            if (ds != null)
            {
                try
                {
                    this.oleDbDataAdapter1.Update(ds);
                    this.oleDbDataAdapter2.Update(ds);
                }
                catch (Exception eU)
                {
                    MessageBox.Show(eU.Message);
                }
            }
            this.oleDbConnection1.Close();
        }

        private string AdjustConnectionString()
        {
            return string.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
        }
    }
}
