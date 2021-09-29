using C1.C1Preview;
using C1.C1Preview.DataBinding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // build sample list of customers
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 100; i++)
            {
                customers.Add(new Customer() { Id = i + 1, Name = "Customer " + (i + 1).ToString() });
            }

            doc.Clear();

            doc.Style.Font = new Font("Verdana", 16);

            // generate document
            doc.Body.Children.Add(new RenderText("List of Customer objects"));
            doc.Body.Children.Add(new RenderEmpty("5mm")); // empty space after title

            // this object will be repeated for each element in the customers list
            RenderText rt = new RenderText();
            rt.Text = "Id: [Fields!Id.Value]\rName: [Fields!Name.Value]";
            rt.Style.Borders.All = LineDef.DefaultBold;
            rt.SplitVertBehavior = SplitBehaviorEnum.Never;

            // bind object with customers list
            rt.DataBinding.DataSource = customers;
            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(null, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Verdana", 20);
            doc.Body.Children.Add(new RenderText("The following RenderText object is bound to an empty list so it is not displayed.", AlignHorzEnum.Center));
            doc.Body.Children.Add(new RenderEmpty("5mm"));

            RenderText rt = new RenderText("This RenderText object has data binding with empty recordset");

            // bind object with empty list
            rt.DataBinding.DataSource = new int[0];
            rt.Style.Borders.All = new LineDef("1mm", Color.Blue);
            rt.Style.BackColor = Color.YellowGreen;

            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        internal DataSource CreateDemoDataSource()
        {
            DataSource result = new DataSource();
            result.ConnectionProperties.DataProvider = DataProviderEnum.OLEDB;
            result.ConnectionProperties.ConnectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ComponentOne Samples\Common\C1Nwind.mdb";
            return result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Verdana", 16);

            // define data schema
            DataSource ds = CreateDemoDataSource();
            DataSet dsCities = new DataSet(ds, "SELECT * FROM Cities");
            doc.DataSchema.DataSources.Add(ds);
            doc.DataSchema.DataSets.Add(dsCities);

            // title of document
            RenderText rt = new RenderText();
            rt.Text = string.Format("ConnectString = {0}\rCommandText={1}", ds.ConnectionProperties.ConnectString, dsCities.Query.CommandText);
            rt.Style.BackColor = Color.LightBlue;
            rt.Style.Borders.All = new LineDef("1mm", Color.Blue);
            rt.Style.Spacing.Bottom = "1cm";
            doc.Body.Children.Add(rt);

            rt = new RenderText();
            rt.DataBinding.DataSource = dsCities;
            rt.Text = "Id = [Fields!ID.Value]  Name = [Fields!City.Value]";
            rt.Style.Borders.Bottom = LineDef.Default;
            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        private RenderObject CreateAggregate1(string caption, string aggregateName, Style captionStyle, Style aggregateStyle)
        {
            RenderParagraph result = new RenderParagraph();
            ParagraphText pt = new ParagraphText(caption + "\r");
            pt.Style.Parents = captionStyle;
            result.Content.Add(pt);

            pt = new ParagraphText("[Aggregates!" + aggregateName + ".Value]");
            pt.Style.Parents = aggregateStyle;
            result.Content.Add(pt);

            return result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doc.Clear();

            // initialize styles
            doc.Style.Font = new Font("Verdana", 12);

            Style boldFontStyle = doc.Style.Children.Add();
            boldFontStyle.Font = new Font("Verdana", 12, FontStyle.Bold);

            Style smallFontStyle = doc.Style.Children.Add();
            smallFontStyle.Font = new Font("Verdana", 7);

            Style detailCaptionStyle = doc.Style.Children.Add();
            detailCaptionStyle.TextAlignHorz = AlignHorzEnum.Center;
            detailCaptionStyle.TextAlignVert = AlignVertEnum.Center;
            detailCaptionStyle.Font = new Font("Verdana", 12, FontStyle.Underline);

            Style detailStyle = doc.Style.Children.Add();
            detailStyle.Font = new Font("Verdana", 11);

            Style dateStyle = detailStyle.Children.Add();
            dateStyle.TextAlignHorz = AlignHorzEnum.Center;

            Style timeStyle = detailStyle.Children.Add();
            timeStyle.TextAlignHorz = AlignHorzEnum.Center;

            Style paymentAmountStyle = detailStyle.Children.Add();
            paymentAmountStyle.TextAlignHorz = AlignHorzEnum.Right;

            Style quantityStyle = detailStyle.Children.Add();
            quantityStyle.TextAlignHorz = AlignHorzEnum.Right;

            Style descriptionStyle = detailStyle.Children.Add();
            descriptionStyle.TextAlignHorz = AlignHorzEnum.Left;

            // define data schema
            DataSource ds = CreateDemoDataSource();
            DataSet dsCities = new DataSet(ds, @"
                SELECT Customer_demo.Company, [Order].* 
                FROM (Customer_demo INNER JOIN[Order] ON Customer_demo.ID = [Order].CustomerID) 
                ORDER BY Customer_demo.Company, [Order].PaymentType");

            doc.DataSchema.DataSources.Add(ds);
            doc.DataSchema.DataSets.Add(dsCities);

            RenderText txt = new RenderText();
            txt.Text = "List of orders grouped by customers and payment type";
            txt.Style.Font = new Font("Tahoma", 16, FontStyle.Bold);
            doc.Body.Children.Add(txt);

            RenderTable rt = new RenderTable();
            rt.Style.GridLines.All = LineDef.Default;

            // info about Company
            rt.Cells[0, 0].Text = "Company:";

            rt.Cells[0, 1].SpanCols = 3;
            rt.Cells[0, 1].Text = "[Fields!Company.Value]";
            rt.Cells[0, 1].Style.Parents = boldFontStyle;
            rt.Cells[0, 1].Style.BackColor = Color.LightCyan;

            rt.Cells[0, 4].RenderObject = CreateAggregate1("Sum:", "CompanySum", smallFontStyle, boldFontStyle); ;
            rt.Cells[0, 4].Style.BackColor = Color.LightGray;

            // info about PaymentType
            rt.Cells[1, 0].Text = "Payment type:";

            rt.Cells[1, 1].Text = "[Fields!PaymentType.Value]";
            rt.Cells[1, 1].Style.Parents = boldFontStyle;

            rt.Cells[1, 2].RenderObject = CreateAggregate1("Sum amount:", "PaymentTypeSum", smallFontStyle, boldFontStyle);
            rt.Cells[1, 2].Style.BackColor = Color.LightGray;

            rt.Cells[1, 3].RenderObject = CreateAggregate1("Sum quantity:", "PaymentTypeQuantity", smallFontStyle, boldFontStyle);
            rt.Cells[1, 3].Style.BackColor = Color.LightGray;

            rt.Cells[1, 4].RenderObject = CreateAggregate1("Item count:", "PaymentTypeCount", smallFontStyle, boldFontStyle);
            rt.Cells[1, 4].Style.BackColor = Color.LightGray;

            // captions of details
            rt.Cells[2, 0].Text = "Date";
            rt.Cells[2, 0].Style.Parents = detailCaptionStyle;
            rt.Cells[2, 1].Text = "Time";
            rt.Cells[2, 1].Style.Parents = detailCaptionStyle;
            rt.Cells[2, 2].Text = "Amount";
            rt.Cells[2, 2].Style.Parents = detailCaptionStyle;
            rt.Cells[2, 3].Text = "Quantity";
            rt.Cells[2, 3].Style.Parents = detailCaptionStyle;
            rt.Cells[2, 4].Text = "Description";
            rt.Cells[2, 4].Style.Parents = detailCaptionStyle;

            // details
            rt.Cells[3, 0].RenderObject = new RenderText(string.Format(@"[System.Convert.ToDateTime(Fields!PurchaseDate.Value).ToShortDateString()]"));
            rt.Cells[3, 0].Style.Parents = dateStyle;

            rt.Cells[3, 1].RenderObject = new RenderText(string.Format(@"[System.Convert.ToDateTime(Fields!Time.Value).ToShortTimeString()]"));
            rt.Cells[3, 1].Style.Parents = timeStyle;

            rt.Cells[3, 2].Text = "[Fields!PaymentAmount.Value]";
            rt.Cells[3, 2].Style.Parents = paymentAmountStyle;

            rt.Cells[3, 3].Text = "[Fields!Quantity.Value]";
            rt.Cells[3, 3].Style.Parents = quantityStyle;

            rt.Cells[3, 4].Text = "[Fields!Description.Value]";
            rt.Cells[3, 4].Style.Parents = descriptionStyle;

            // summary by Payment type
            rt.Cells[4, 0].SpanCols = 2;
            rt.Cells[4, 2].Text = "[Aggregates!PaymentTypeSum.Value]";
            rt.Cells[4, 3].SpanCols = 2;

            // summary by Company
            rt.Cells[5, 0].SpanCols = 4;
            rt.Cells[5, 0].Text = "Sum for company [Fields!Company.Value]:";
            rt.Cells[5, 0].Style.TextAlignHorz = AlignHorzEnum.Right;
            rt.Cells[5, 4].Text = "[Aggregates!CompanySum.Value]";

            // itogo
            rt.Cells[6, 0].SpanCols = 4;
            rt.Cells[6, 0].Text = "Summary:";
            rt.Cells[6, 0].Style.TextAlignHorz = AlignHorzEnum.Right;
            rt.Cells[6, 4].Text = "[Aggregates!Sum.Value]";

            // define databinding within table
            TableVectorGroup g = rt.RowGroups[0, 6];
            g.DataBinding.DataSource = dsCities;
            g.DataBinding.Grouping.Expressions.Add("Fields!Company.Value");
            doc.DataSchema.Aggregates.Add(new Aggregate("CompanySum", "Fields!PaymentAmount.Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Sum));
            doc.DataSchema.Aggregates.Add(new Aggregate("Sum", "Fields!PaymentAmount.Value", g.DataBinding, RunningEnum.Document, AggregateFuncEnum.Sum));

            g = rt.RowGroups[1, 4];
            g.DataBinding.DataSource = dsCities;
            g.DataBinding.Grouping.Expressions.Add("Fields!PaymentType.Value");

            // create aggregates
            doc.DataSchema.Aggregates.Add(new Aggregate("PaymentTypeCount", "Fields!PaymentAmount.Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Count));
            doc.DataSchema.Aggregates.Add(new Aggregate("PaymentTypeSum", "Fields!PaymentAmount.Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Sum));
            doc.DataSchema.Aggregates.Add(new Aggregate("PaymentTypeQuantity", "Fields!Quantity.Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Sum));

            g = rt.RowGroups[3, 1];
            g.DataBinding.DataSource = dsCities;

            doc.Body.Children.Add(rt);

            doc.Generate();
        }
    }
}
