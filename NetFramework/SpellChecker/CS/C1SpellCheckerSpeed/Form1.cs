using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.SpellChecker;

namespace C1SpellCheckerSpeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Benchmark(Properties.Resources.MobyDick);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Benchmark(Properties.Resources.DeclarationOfIndependence);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Benchmark(Properties.Resources.KingJamesBible);
        }
        void Benchmark(string text)
        {
            // check the text
            DateTime start = DateTime.Now;
            CharRangeList notFound = this.c1SpellChecker1.CheckText(text);
            TimeSpan elapsed = DateTime.Now.Subtract(start);

            // compute statistics
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double seconds = elapsed.TotalSeconds;
            Dictionary<string, bool> unique = new Dictionary<string, bool>();
            foreach (CharRange cr in notFound)
            {
                unique[cr.Text] = true;
            }

            // show the results
            _lblNotFound.Text = string.Format("Words not found: {0:n0} ({1:n0} unique)", notFound.Count, unique.Count);
            _lblTime.Text = string.Format("Time elapsed: {0:n0} milliseconds", elapsed.TotalMilliseconds);
            _lblWords.Text = string.Format("Words checked: {0:n0}", words.Length);
            _lblSpeed.Text = string.Format("Words checked per second: {0:n0}", words.Length / elapsed.TotalSeconds);
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            foreach (string word in unique.Keys)
            {
                listBox1.Items.Add(word);
            }
            listBox1.EndUpdate();
        }
    }
}