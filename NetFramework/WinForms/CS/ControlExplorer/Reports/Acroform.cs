using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using C1.C1Preview;
using C1.C1Preview.DataBinding;
using C1.C1Preview.Export;

namespace ControlExplorer.Reports
{
    public partial class Acroform : C1DemoForm
    { 
        private Style _captionStyle;
        private Style _fieldCaptionStyle;
        private Style _requiredCharStyle;
        private Style _passwordInfoStyle;
        private Style _textFieldStyle;
        string answers = "";

        public Acroform()
        {
            InitializeComponent();    
        }

        private void comboDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDocs.SelectedItem.ToString().Equals("Acroform"))
            {
                createAcroform();
            }
            else if (comboDocs.SelectedItem.ToString().Equals("Brain Quiz"))
            {
                createQuizForm();
            }
        }

        // This method creates a C1PrintDocument Acroform using the doc.Generate approach.
        // When using doc.Generate the content is added to the Body.children collection.
        private void createAcroform()
        {
            doc.Clear();
            RenderTable ph = new RenderTable(doc);
            RenderInputButton rbPrior = new RenderInputButton(doc, "<<");
            rbPrior.InputActions.Add(
                UserActionEnum.Click,
                new ActionHandlerLink(new C1LinkTargetPage(PageJumpTypeEnum.Previous)));
            RenderInputButton rbNext = new RenderInputButton(doc, ">>");
            rbNext.X = "parent.Width - width";
            rbNext.InputActions.Add(
                UserActionEnum.Click,
                new ActionHandlerLink(new C1LinkTargetPage(PageJumpTypeEnum.Next)));
            ph.Cells[0, 0].Area.Children.Add(rbPrior);
            ph.Cells[0, 1].Area.Children.Add(rbNext);
            ph.Style.Borders.Bottom = new LineDef("1pt", Color.Black);
            ph.Style.Spacing.Bottom = "5mm";

            doc.PageLayout.PageHeader = ph;

            doc.PageLayout.PageFooter = new RenderText(doc, "Page [PageNo] of [PageCount]", AlignHorzEnum.Right);

            //  create styles
            _captionStyle = doc.Style.Children.Add();
            _captionStyle.Font = new Font("Tahoma", 16, FontStyle.Bold);
            _captionStyle.BackColor = Color.FromArgb(208, 237, 253);
            _captionStyle.Spacing.Bottom = "5mm";

            _fieldCaptionStyle = doc.Style.Children.Add();
            _fieldCaptionStyle.Font = new Font("Tahoma", 13);

            _requiredCharStyle = doc.Style.Children.Add();
            _requiredCharStyle.Parents = _fieldCaptionStyle;
            _requiredCharStyle.TextColor = Color.Red;

            _passwordInfoStyle = doc.Style.Children.Add();
            _passwordInfoStyle.Parents = _fieldCaptionStyle;
            _passwordInfoStyle.TextPosition = TextPositionEnum.Subscript;

            _textFieldStyle = doc.Style.Children.Add();
            _textFieldStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);

            //  Personal information
            doc.Body.Children.Add(new RenderText(doc, "Personal information", _captionStyle, _captionStyle));
            //  create RenderTable containing the form's fields
            RenderTable rt = new RenderTable(doc);
            rt.CellStyle.Padding.All = "0.5mm";
            rt.Cells[0, 0].RenderObject = CreateFieldCaption(doc, "First name:", true, false);
            rt.Cells[1, 0].RenderObject = CreateTextField(doc, "FirstName", Color.Black, false);

            rt.Cells[0, 1].RenderObject = CreateFieldCaption(doc, "Last name:", true, false);
            rt.Cells[1, 1].RenderObject = CreateTextField(doc, "LastName", Color.Black, false);

            rt.Cells[2, 0].RenderObject = CreateFieldCaption(doc, "Email Address:", true, false);
            rt.Cells[3, 0].RenderObject = CreateTextField(doc, "EmailAddress", Color.Blue, false);

            rt.Cells[2, 1].RenderObject = CreateFieldCaption(doc, "Retype Email Address:", true, false);
            rt.Cells[3, 1].RenderObject = CreateTextField(doc, "RetypeEmailAddress", Color.Blue, false);

            rt.Cells[4, 0].RenderObject = CreateFieldCaption(doc, "Password:", true, true);
            rt.Cells[5, 0].RenderObject = CreateTextField(doc, "Password", Color.Black, true);

            rt.Cells[4, 1].RenderObject = CreateFieldCaption(doc, "Retype Password:", true, false);
            rt.Cells[5, 1].RenderObject = CreateTextField(doc, "RetypePassword", Color.Black, true);

            rt.Cells[6, 0].RenderObject = CreateFieldCaption(doc, "City:", false, false);
            rt.Cells[7, 0].RenderObject = CreateTextField(doc, "City", Color.Black, false);

            rt.Cells[6, 1].RenderObject = CreateFieldCaption(doc, "State:", false, false);
            rt.Cells[7, 1].RenderObject = CreateTextField(doc, "State", Color.Black, false);

            //  add the "Select" button
            RenderArea ra = new RenderArea(doc);
            RenderInputButton rb = new RenderInputButton(doc, "Select...");
            rb.Name = "Select";
            rb.X = "parent.Width - width";
            ra.Children.Add(rb);
            rt.Cells[8, 1].RenderObject = ra;

            //  Work status field
            rt.Cells[9, 0].RenderObject = CreateFieldCaption(doc, "Work status:", true, false);
            rt.Cells[9, 0].SpanCols = 2;

            rt.Cells[10, 0].RenderObject = new RenderInputRadioButton(doc, "StatusCitizen", "I am a citizen");
            ((RenderInputRadioButton)rt.Cells[10, 0].RenderObject).Checked = true;
            rt.Cells[10, 1].RenderObject = new RenderInputRadioButton(doc, "StatusAny", "I am authorized to work for any employer");
            rt.Cells[11, 0].RenderObject = new RenderInputRadioButton(doc, "StatusCurrent", "I am authorized to work for my current employer");
            rt.Cells[11, 1].RenderObject = new RenderInputRadioButton(doc, "StatusSeeking", "I am seeking authorization");
            rt.Style.Spacing.Bottom = "5mm";
            doc.Body.Children.Add(rt);

            // 
            doc.Body.Children.Add(new RenderText(doc, "Interests", _captionStyle, _captionStyle));

            rt = new RenderTable(doc);
            rt.Cells[0, 0].RenderObject = new RenderInputCheckBox(doc, "Accounting");
            rt.Cells[0, 1].RenderObject = new RenderInputCheckBox(doc, "General Business");
            rt.Cells[0, 2].RenderObject = new RenderInputCheckBox(doc, "Pharmaceutical");
            rt.Cells[1, 0].RenderObject = new RenderInputCheckBox(doc, "Admin & Clerical");
            rt.Cells[1, 1].RenderObject = new RenderInputCheckBox(doc, "General Labor");
            rt.Cells[1, 2].RenderObject = new RenderInputCheckBox(doc, "Professional Services");
            rt.Cells[2, 0].RenderObject = new RenderInputCheckBox(doc, "Automotive");
            rt.Cells[2, 1].RenderObject = new RenderInputCheckBox(doc, "Government");
            rt.Cells[2, 2].RenderObject = new RenderInputCheckBox(doc, "QA - Quality Control");
            rt.Cells[2, 0].RenderObject = new RenderInputCheckBox(doc, "Biotech");
            rt.Cells[2, 1].RenderObject = new RenderInputCheckBox(doc, "Information Technology");
            rt.Cells[2, 2].RenderObject = new RenderInputCheckBox(doc, "Warehouse");
            rt.BreakAfter = BreakEnum.Page;
            doc.Body.Children.Add(rt);


            doc.Body.Children.Add(new RenderText(doc, "Desired Position", _captionStyle, _captionStyle));
            doc.Body.Children.Add(new RenderText(doc, "Describe your desired position by completing as many of the following questions as possible.\n\nPlease indicate the wage you are seeking."));

            rt = new RenderTable(doc);
            rt.Cells[0, 0].RenderObject = new RenderInputCheckBox(doc, "Full-time");
            rt.Cells[0, 1].RenderObject = new RenderInputCheckBox(doc, "Part-time");
            rt.Cells[0, 2].RenderObject = new RenderInputCheckBox(doc, "Intern");
            rt.Cells[1, 0].RenderObject = new RenderInputCheckBox(doc, "Seasonal");
            rt.Cells[1, 1].RenderObject = new RenderInputCheckBox(doc, "Temporary");
            rt.Style.Spacing.Bottom = "5mm";
            doc.Body.Children.Add(rt);

            doc.Body.Children.Add(new RenderText(doc, "How many miles are you willing to commute to work?"));
            RenderInputComboBox rc = new RenderInputComboBox(
                doc,
                "-- Select Distance --",
                "1 mile",
                "5 miles",
                "10 miles",
                "25 miles",
                "50 miles",
                "100 miles");
            rc.Text = rc.Items[0].Text;
            rc.Style.Parents = _textFieldStyle;
            rc.Style.Spacing.Bottom = "5mm";
            doc.Body.Children.Add(rc);

            doc.Body.Children.Add(new RenderText(doc, "How often are you willing to travel for work?"));
            rc = new RenderInputComboBox(
                doc,
                "Negligible",
                "Up to 25%",
                "Up to 50%",
                "Road Warrior");
            rc.DropDownStyle = ComboBoxStyle.DropDownList;
            rc.Text = rc.Items[0].Text;
            doc.Body.Children.Add(rc);

            //  Save button
            rb = new RenderInputButton(doc, "Save...");
            rb.AcceptButton = true;
            rb.InputActions.Add(
                UserActionEnum.Click,
                new ActionHandlerFileSave());
            doc.Body.Children.Add(rb);

            rb = new RenderInputButton(doc, "Save as PDF...");
            rb.InputActions.Add(
                UserActionEnum.Click,
                new ActionHandlerFileSave(null, ExportProviders.PdfExportProvider));
            doc.Body.Children.Add(rb);

            // Generate Doc
            doc.Generate();

            // Hide custom button (used only for Quiz form)
            btnCheckAnswers.Visible = false;
        }


        private RenderObject CreateCaption(C1PrintDocument doc, string text)
        {
            return null;
        }

        // Used internally in createAcroform to add field captions
        private RenderObject CreateFieldCaption(
            C1PrintDocument doc,
            string caption,
            bool required,
            bool password)
        {
            ParagraphText pt;
            RenderParagraph result = new RenderParagraph(doc);
            if (required)
            {
                pt = new ParagraphText("*");
                pt.Style.Parents = _requiredCharStyle;
                result.Content.Add(pt);

                pt = new ParagraphText(" ");
                pt.Style.Parents = _fieldCaptionStyle;
                result.Content.Add(pt);
            }

            pt = new ParagraphText(caption);
            pt.Style.Parents = _fieldCaptionStyle;
            result.Content.Add(pt);

            if (password)
            {
                pt = new ParagraphText("(Must be at least 5 characters)");
                pt.Style.Parents = _passwordInfoStyle;
                result.Content.Add(pt);
            }

            return result;
        }

        // Used internally in createAcroform to add textfield input objects
        private RenderInputBase CreateTextField(
            C1PrintDocument doc,
            string name,
            Color textColor,
            bool passwordField)
        {
            RenderInputText result = new RenderInputText(doc);
            result.Name = name;
            result.Style.Parents = _textFieldStyle;
            result.Style.TextColor = textColor;
            result.StatusText = name;
            result.ToolTip = name;
            if (passwordField)
                result.PasswordChar = (char)0x25CF;
            return result;
        }

        // This method creates a C1PrintDocument acroform using the StartDoc/EndDoc approach.
        // When using StartDoc/EndDoc the content is created using the Render methods.
        private void createQuizForm()
        {
            doc.Clear();
            doc.PageLayouts.Default.PageSettings = new C1.C1Preview.C1PageSettings(false, System.Drawing.Printing.PaperKind.Letter, false, "1in", "1in", "1in", "1in");
            doc.AllowNonReflowableDocs = true;
            doc.Style.Font = new Font("Comic Sans MS", 12);
            doc.StartDoc();
            doc.RenderBlockRichText(@"{\fonttbl{\f0\froman\fprq2\fcharset2 Webdings;}{\f1\fscript\fprq2\fcharset0 Comic Sans MS;}{\f2\fswiss\fcharset0 Arial;}}{\*\generator Msftedit 5.41.21.2507;}\viewkind4\uc1\pard\f0\fs96 [\f1\fs28  \fs72 Brain Quiz\f2\fs20\par}");
            doc.RenderBlockText("Instructions: Answer the following questions to the best of your ability.  Click the 'Check Answers' button to see your score.");

            // Read in quiz questions from text file
            try
            {
                StreamReader sr = new StreamReader(File.Open(AppDomain.CurrentDomain.BaseDirectory + "Reports\\Files\\quiz1.txt", FileMode.Open));
                string question, choice;
                int count = 1, numOfChoices = 3;
                while (!sr.EndOfStream)
                {
                    // Read in Question    
                    question = sr.ReadLine();
                    doc.RenderBlockText(" ");
                    doc.RenderBlockText(count.ToString() + ") " + question);
                    RenderTable rtChoices = new RenderTable(1, numOfChoices);
                    for (int i = 0; i < numOfChoices; i++)
                    {
                        // Read in each choice
                        choice = sr.ReadLine();
                        rtChoices.Cells[0, i].Area.Children.Add(new RenderInputRadioButton("rad" + count.ToString() + i.ToString(), (char)(65 + i) + ") " + choice, count));
                        rtChoices.Name = "rtChoices" + count.ToString();
                    }
                    doc.RenderBlock(rtChoices);
                    answers = answers + sr.ReadLine(); // store correct answer
                    count += 1;
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Sorry, unable to read quiz file :(");
            }

            doc.EndDoc();

            // Add a custom ToolBar button for checking answers
            btnCheckAnswers.Visible = true;

        }

        private void btnCheckAnswers_Click(object sender, EventArgs e)
        {
            if (c1PrintPreviewControl1.Document != doc)
            {
                MessageBox.Show("You should view the quiz first.");
                return;
            }
            string guesses = "";
            int leftBlank;
            // Cycle through each render table containing each set of radio buttons
            foreach (RenderObject ro in doc.Body.Children)
            {
                if (ro.GetType() == typeof(C1.C1Preview.RenderTable))
                {
                    RenderTable rt = (RenderTable)ro;
                    leftBlank = guesses.Length;
                    for (int i = 0; i < 3; i++)
                    {
                        RenderInputRadioButton rib = (RenderInputRadioButton)rt.Cells[0, i].Area.Children[0];
                        // Mark the selected choice
                        if (rib.Checked)
                            guesses = guesses + (char)(65 + i);
                    }
                    if (guesses.Length == leftBlank) // Mark questions left blank with X
                        guesses = guesses + "X";
                }

            }
            int num_correct = 0;
            for (int i = 0; i < guesses.Length; i++)
            {
                if (answers.Length >= guesses.Length && guesses[i] == answers[i])
                    num_correct += 1;
            }
            MessageBox.Show("You got " + num_correct.ToString() + " out of 10 correct!");
        }

        private void Acroform_Load(object sender, EventArgs e)
        {
            c1PrintPreviewControl1.Document = doc;
            comboDocs.SelectedIndex = 0;

            //  add demo properties
            AddProperty("ImageSet", c1PrintPreviewControl1);
            AddProperty("NavigationPanelVisible", c1PrintPreviewControl1);
            AddProperty("PageLayout", c1PrintPreviewControl1.PreviewPane);
            AddProperty("ShowRulers", c1PrintPreviewControl1.PreviewPane);
            AddProperty("StatusBarVisible", c1PrintPreviewControl1);
            AddProperty("TextSearchPanelVisible", c1PrintPreviewControl1);
            AddProperty("ZoomMode", c1PrintPreviewControl1.PreviewPane);
        }
    }
}
