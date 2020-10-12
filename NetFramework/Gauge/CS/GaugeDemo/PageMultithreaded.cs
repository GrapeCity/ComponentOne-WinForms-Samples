using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using C1.Win.C1Gauge;

namespace GaugeDemo
{
    public partial class PageMultithreaded : BaseGaugePage
    {
        private Thread _workingThread;
        private Thread _minThread;
        private Thread _maxThread;
        private bool _workingThreadRunning;
        private bool _minThreadRunning;
        private bool _maxThreadRunning;

        private const string _startText = "Start Thread {0}";
        private const string _stopText = "Stop Thread {0}";

        public PageMultithreaded()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            _workingThreadRunning = false;
            _minThreadRunning = false;
            _maxThreadRunning = false;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string text = "1 (value)";
            if (!_workingThreadRunning)
            {
                button1.Text = string.Format(_stopText, text);
                _workingThread = new Thread(new ThreadStart(DoWorkThreadFunc));
                _workingThreadRunning = true;
                _workingThread.Start();
            }
            else
            {
                button1.Text = string.Format(_startText, text);
                _workingThreadRunning = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string text = "2 (min)";
            if (!_minThreadRunning)
            {
                button2.Text = string.Format(_stopText, text);
                _minThread = new Thread(new ThreadStart(UpdateMinThreadFunc));
                _minThreadRunning = true;
                _minThread.Start();
            }
            else
            {
                button2.Text = string.Format(_startText, text);
                _minThreadRunning = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string text = "3 (max)";
            if (!_maxThreadRunning)
            {
                button3.Text = string.Format(_stopText, text);
                _maxThread = new Thread(new ThreadStart(UpdateMaxThreadFunc));
                _maxThreadRunning = true;
                _maxThread.Start();
            }
            else
            {
                button3.Text = string.Format(_startText, text);
                _maxThreadRunning = false;
            }
        }

        private void DoWorkThreadFunc()
        {
            Random random = new Random();
            C1GaugePointer pointer = c1LinearGauge1.Pointer;
            while (_workingThreadRunning)
            {
                pointer.Value = random.Next(0, 101);
                Thread.Sleep(1000);
            }
        }

        private void UpdateMinThreadFunc()
        {
            Random random = new Random();
            C1GaugePointer pointer = c1LinearGauge1.MorePointers["min"];
            while (_minThreadRunning)
            {
                pointer.Value = random.Next(0, 50);
                Thread.Sleep(1000);
            }
        }

        private void UpdateMaxThreadFunc()
        {
            Random random = new Random();
            C1GaugePointer pointer = c1LinearGauge1.MorePointers["max"];
            while (_maxThreadRunning)
            {
                pointer.Value = random.Next(51, 101);
                Thread.Sleep(1000);
            }
        }
    }
}
