using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace C1ReportsScheduler
{
    public partial class LogControl : UserControl
    {
        private EventLog _eventLog = null;
        private const int c_backLog = 120;
        private readonly TimeSpan c_backLogT = new TimeSpan(0, 1, 0); // 1 minute

        public LogControl()
        {
            InitializeComponent();
            TryInitEventLog();
        }

        private void TryInitEventLog()
        {
            if (_eventLog != null)
                return;

            try
            {
                _eventLog = new EventLog();
                _eventLog.Source = C1ReportsSchedulerService.Constants.EventLogSourceName;

                // log recent events, up to c_backLog, not older than c_backLogT:
                DateTime fromT = DateTime.Now.Subtract(c_backLogT);
                int from = Math.Max(0, _eventLog.Entries.Count - c_backLog);
                for (int i = from; i < _eventLog.Entries.Count; ++i)
                    if (_eventLog.Entries[i].TimeGenerated.CompareTo(fromT) >= 0)
                        OnEntryWritten(new EntryWrittenEventArgs(_eventLog.Entries[i]));

                // NOTE: event unsubscribed in Dispose(bool):
                _eventLog.EntryWritten += new EntryWrittenEventHandler(_eventLog_EntryWritten);
                _eventLog.EnableRaisingEvents = true;
                tsbResume.Enabled = false;
                tsbStop.Enabled = true;

            }
            catch (Exception ex)
            {
                _eventLog = null;
                _textBox.AppendText(string.Format("LOG READING ERROR: {0}", ex.Message));
                _textBox.AppendText("\r\n");
                tsbStop.Enabled = false;
                tsbResume.Enabled = true;
            }
        }

        private void OnEntryWritten(EntryWrittenEventArgs e)
        {
            try
            {
                _textBox.AppendText(string.Format("{0} {1}:  ", e.Entry.TimeGenerated.ToShortDateString(), e.Entry.TimeGenerated.ToLongTimeString()));
                _textBox.AppendText(e.Entry.Message);
                _textBox.AppendText("\r\n");
            }
            catch (Exception ex)
            {
                AltUtil.ShowError(ex.Message);
            }
        }

        delegate void EntryWrittenDelegate(EntryWrittenEventArgs e);

        void _eventLog_EntryWritten(object sender, EntryWrittenEventArgs e)
        {
            if (this.InvokeRequired)
                this.Invoke(new EntryWrittenDelegate(OnEntryWritten), new object[] { e });
            else
                OnEntryWritten(e);
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            try
            {
                _textBox.Clear();
            }
            catch (Exception ex)
            {
                AltUtil.ShowError(ex.Message);
            }
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            TryInitEventLog();
            if (_eventLog != null)
            {
                _eventLog.EnableRaisingEvents = false;
                tsbStop.Enabled = false;
                tsbResume.Enabled = true;
            }
        }

        private void tsbResume_Click(object sender, EventArgs e)
        {
            TryInitEventLog();
            if (_eventLog != null)
            {
                _eventLog.EnableRaisingEvents = true;
                tsbStop.Enabled = true;
                tsbResume.Enabled = false;
            }
        }

        private void tsbEventViewer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("eventvwr");
        }
    }
}
