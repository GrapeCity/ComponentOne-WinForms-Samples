using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CVForm
{
    public partial class CVForm : Form
    {
        public CVForm()
        {
            InitializeComponent();
            Load += CVForm_Load;
        }

        private void CVForm_Load(object sender, EventArgs e)
        {
            var languages = new List<string>()
            {
                "Arabic",
                "Bengali",
                "English",
                "French",
                "German",
                "Hindi",
                "Italian",
                "Japanese",
                "Mandarin Chinese",
                "Portuguese",
                "Russian",
                "Spanish"
            };

            lCheckList.BindingInfo.DataSource = languages;

            var skills = new List<string>()
            {
                "Project Management",
                "Web Development",
                "OOP",
                ".Net Framework",
                "WinAPI",
                "WinForms",
                "WPF",
                "XAML",
                "Cloud Computing",
                "C#",
                "VB",
                "Testing"
            };

            skillsCheckList.BindingInfo.DataSource = skills;
        }

    }
}
