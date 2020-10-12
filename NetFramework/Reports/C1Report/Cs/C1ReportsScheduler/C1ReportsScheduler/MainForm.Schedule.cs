using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace C1ReportsScheduler
{
    public partial class MainForm
    {
        private void UpdateSchedule(TaskBase task)
        {
            this.dtpScheduleDate.DataBindings.Clear();
            this.dtpScheduleDate.DataBindings.Add("Value", task.Schedule, "StartTime");
            this.dtpScheduleTime.DataBindings.Clear();
            this.dtpScheduleTime.DataBindings.Add("Value", task.Schedule, "StartTime");

            this.rbtScheduleOnce.DataBindings.Clear();
            this.rbtScheduleOnce.DataBindings.Add("Checked", task.Schedule, "FrequencyOnce");
            this.rbtScheduleDaily.DataBindings.Clear();
            this.rbtScheduleDaily.DataBindings.Add("Checked", task.Schedule, "FrequencyDaily");
            this.rbtScheduleWeekly.DataBindings.Clear();
            this.rbtScheduleWeekly.DataBindings.Add("Checked", task.Schedule, "FrequencyWeekly");
            this.rbtScheduleMonthly.DataBindings.Clear();
            this.rbtScheduleMonthly.DataBindings.Add("Checked", task.Schedule, "FrequencyMonthly");

            this.numScheduleDays.DataBindings.Clear();
            // NOTE: when Value of a numeric updown is bound, typing a value does not update data:
            // this.numScheduleDays.DataBindings.Add("Value", task.Schedule, "RecurEveryDays");
            this.numScheduleDays.DataBindings.Add("Text", task.Schedule, "RecurEveryDays");

            this.numScheduleWeeks.DataBindings.Clear();
            // this.numScheduleWeeks.DataBindings.Add("Value", task.Schedule, "RecurEveryWeeks");
            this.numScheduleWeeks.DataBindings.Add("Text", task.Schedule, "RecurEveryWeeks");

            this.chkScheduleSunday.DataBindings.Clear();
            this.chkScheduleSunday.DataBindings.Add("Checked", task.Schedule, "Sunday");
            this.chkScheduleMonday.DataBindings.Clear();
            this.chkScheduleMonday.DataBindings.Add("Checked", task.Schedule, "Monday");
            this.chkScheduleTuesday.DataBindings.Clear();
            this.chkScheduleTuesday.DataBindings.Add("Checked", task.Schedule, "Tuesday");
            this.chkScheduleWednesday.DataBindings.Clear();
            this.chkScheduleWednesday.DataBindings.Add("Checked", task.Schedule, "Wednesday");
            this.chkScheduleThursday.DataBindings.Clear();
            this.chkScheduleThursday.DataBindings.Add("Checked", task.Schedule, "Thursday");
            this.chkScheduleFriday.DataBindings.Clear();
            this.chkScheduleFriday.DataBindings.Add("Checked", task.Schedule, "Friday");
            this.chkScheduleSaturday.DataBindings.Clear();
            this.chkScheduleSaturday.DataBindings.Add("Checked", task.Schedule, "Saturday");

            this.chkScheduleJan.DataBindings.Clear();
            this.chkScheduleJan.DataBindings.Add("Checked", task.Schedule, "January");
            this.chkScheduleFeb.DataBindings.Clear();
            this.chkScheduleFeb.DataBindings.Add("Checked", task.Schedule, "February");
            this.chkScheduleMar.DataBindings.Clear();
            this.chkScheduleMar.DataBindings.Add("Checked", task.Schedule, "March");
            this.chkScheduleApr.DataBindings.Clear();
            this.chkScheduleApr.DataBindings.Add("Checked", task.Schedule, "April");
            this.chkScheduleMay.DataBindings.Clear();
            this.chkScheduleMay.DataBindings.Add("Checked", task.Schedule, "May");
            this.chkScheduleJun.DataBindings.Clear();
            this.chkScheduleJun.DataBindings.Add("Checked", task.Schedule, "June");
            this.chkScheduleJul.DataBindings.Clear();
            this.chkScheduleJul.DataBindings.Add("Checked", task.Schedule, "July");
            this.chkScheduleAug.DataBindings.Clear();
            this.chkScheduleAug.DataBindings.Add("Checked", task.Schedule, "August");
            this.chkScheduleSep.DataBindings.Clear();
            this.chkScheduleSep.DataBindings.Add("Checked", task.Schedule, "September");
            this.chkScheduleOct.DataBindings.Clear();
            this.chkScheduleOct.DataBindings.Add("Checked", task.Schedule, "October");
            this.chkScheduleNov.DataBindings.Clear();
            this.chkScheduleNov.DataBindings.Add("Checked", task.Schedule, "November");
            this.chkScheduleDec.DataBindings.Clear();
            this.chkScheduleDec.DataBindings.Add("Checked", task.Schedule, "December");

            this.chkScheduleDay1.DataBindings.Clear();
            this.chkScheduleDay1.DataBindings.Add("Checked", task.Schedule, "Day1");
            this.chkScheduleDay2.DataBindings.Clear();
            this.chkScheduleDay2.DataBindings.Add("Checked", task.Schedule, "Day2");
            this.chkScheduleDay3.DataBindings.Clear();
            this.chkScheduleDay3.DataBindings.Add("Checked", task.Schedule, "Day3");
            this.chkScheduleDay4.DataBindings.Clear();
            this.chkScheduleDay4.DataBindings.Add("Checked", task.Schedule, "Day4");
            this.chkScheduleDay5.DataBindings.Clear();
            this.chkScheduleDay5.DataBindings.Add("Checked", task.Schedule, "Day5");
            this.chkScheduleDay6.DataBindings.Clear();
            this.chkScheduleDay6.DataBindings.Add("Checked", task.Schedule, "Day6");
            this.chkScheduleDay7.DataBindings.Clear();
            this.chkScheduleDay7.DataBindings.Add("Checked", task.Schedule, "Day7");
            this.chkScheduleDay8.DataBindings.Clear();
            this.chkScheduleDay8.DataBindings.Add("Checked", task.Schedule, "Day8");
            this.chkScheduleDay9.DataBindings.Clear();
            this.chkScheduleDay9.DataBindings.Add("Checked", task.Schedule, "Day9");
            this.chkScheduleDay10.DataBindings.Clear();
            this.chkScheduleDay10.DataBindings.Add("Checked", task.Schedule, "Day10");

            this.chkScheduleDay11.DataBindings.Clear();
            this.chkScheduleDay11.DataBindings.Add("Checked", task.Schedule, "Day11");
            this.chkScheduleDay12.DataBindings.Clear();
            this.chkScheduleDay12.DataBindings.Add("Checked", task.Schedule, "Day12");
            this.chkScheduleDay13.DataBindings.Clear();
            this.chkScheduleDay13.DataBindings.Add("Checked", task.Schedule, "Day13");
            this.chkScheduleDay14.DataBindings.Clear();
            this.chkScheduleDay14.DataBindings.Add("Checked", task.Schedule, "Day14");
            this.chkScheduleDay15.DataBindings.Clear();
            this.chkScheduleDay15.DataBindings.Add("Checked", task.Schedule, "Day15");
            this.chkScheduleDay16.DataBindings.Clear();
            this.chkScheduleDay16.DataBindings.Add("Checked", task.Schedule, "Day16");
            this.chkScheduleDay17.DataBindings.Clear();
            this.chkScheduleDay17.DataBindings.Add("Checked", task.Schedule, "Day17");
            this.chkScheduleDay18.DataBindings.Clear();
            this.chkScheduleDay18.DataBindings.Add("Checked", task.Schedule, "Day18");
            this.chkScheduleDay19.DataBindings.Clear();
            this.chkScheduleDay19.DataBindings.Add("Checked", task.Schedule, "Day19");
            this.chkScheduleDay20.DataBindings.Clear();
            this.chkScheduleDay20.DataBindings.Add("Checked", task.Schedule, "Day20");

            this.chkScheduleDay21.DataBindings.Clear();
            this.chkScheduleDay21.DataBindings.Add("Checked", task.Schedule, "Day21");
            this.chkScheduleDay22.DataBindings.Clear();
            this.chkScheduleDay22.DataBindings.Add("Checked", task.Schedule, "Day22");
            this.chkScheduleDay23.DataBindings.Clear();
            this.chkScheduleDay23.DataBindings.Add("Checked", task.Schedule, "Day23");
            this.chkScheduleDay24.DataBindings.Clear();
            this.chkScheduleDay24.DataBindings.Add("Checked", task.Schedule, "Day24");
            this.chkScheduleDay25.DataBindings.Clear();
            this.chkScheduleDay25.DataBindings.Add("Checked", task.Schedule, "Day25");
            this.chkScheduleDay26.DataBindings.Clear();
            this.chkScheduleDay26.DataBindings.Add("Checked", task.Schedule, "Day26");
            this.chkScheduleDay27.DataBindings.Clear();
            this.chkScheduleDay27.DataBindings.Add("Checked", task.Schedule, "Day27");
            this.chkScheduleDay28.DataBindings.Clear();
            this.chkScheduleDay28.DataBindings.Add("Checked", task.Schedule, "Day28");
            this.chkScheduleDay29.DataBindings.Clear();
            this.chkScheduleDay29.DataBindings.Add("Checked", task.Schedule, "Day29");
            this.chkScheduleDay30.DataBindings.Clear();
            this.chkScheduleDay30.DataBindings.Add("Checked", task.Schedule, "Day30");

            this.chkScheduleDay31.DataBindings.Clear();
            this.chkScheduleDay31.DataBindings.Add("Checked", task.Schedule, "Day31");
            this.chkScheduleDayLast.DataBindings.Clear();
            this.chkScheduleDayLast.DataBindings.Add("Checked", task.Schedule, "DayLast");

            this.chkScheduleRepeat.DataBindings.Clear();
            this.chkScheduleRepeat.DataBindings.Add("Checked", task.Schedule, "Repeat");
            this.numScheduleRepeatFreq.DataBindings.Clear();
            // this.numScheduleRepeatFreq.DataBindings.Add("Value", task.Schedule, "RepeatFrequency");
            this.numScheduleRepeatFreq.DataBindings.Add("Text", task.Schedule, "RepeatFrequency");
            this.cmbScheduleRepeatUnit.DataSource = Enum.GetValues(typeof(ScheduleRepeatUnit));
            this.cmbScheduleRepeatUnit.DataBindings.Clear();
            this.cmbScheduleRepeatUnit.DataBindings.Add("SelectedItem", task.Schedule, "RepeatUnit");
        }

        private void _currSchedule_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            System.Diagnostics.Debug.Assert(!this.InvokeRequired, "Invokes should be handled by ScheduleBase itself");
            if (e.PropertyName == "Enabled" || e.PropertyName == "Paused")
            {
                UpdateCurrentTaskUi();
                UpdateCurrentActionUi();
            }
            UpdateScheduleUi();
        }

        private void rbtScheduleFreq_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentTask == null)
                return;
            ScheduleFrequency newFreq = ScheduleFrequency.Once;
            if (rbtScheduleOnce.Checked)
                newFreq = ScheduleFrequency.Once;
            else if (rbtScheduleDaily.Checked)
                newFreq = ScheduleFrequency.Daily;
            else if (rbtScheduleWeekly.Checked)
                newFreq = ScheduleFrequency.Weekly;
            else if (rbtScheduleMonthly.Checked)
                newFreq = ScheduleFrequency.Monthly;
            else
                return;

            if (_currentTask.Schedule.Frequency != newFreq)
                _currentTask.Schedule.Frequency = newFreq;
        }

        private void chkScheduleRepeat_CheckedChanged(object sender, EventArgs e)
        {
            numScheduleRepeatFreq.Enabled = chkScheduleRepeat.Checked;
            cmbScheduleRepeatUnit.Enabled = chkScheduleRepeat.Checked;
        }

        private void UpdateScheduleUiNoTask()
        {
            // This is called via Invoke() and we may get here
            // after the current task has been set, so check again:
            if (CurrentTask != null)
                return;
            flwScheduleFrequency.Enabled = false;
            dtpScheduleDate.Enabled = false;
            dtpScheduleTime.Enabled = false;
            grpSchedule.Visible = false;
            btnScheduleStart.Enabled = false;
            btnSchedulePause.Enabled = false;
            lblScheduleNextDueTime.Text = "";
        }

        private void UpdateScheduleUi()
        {
            try
            {
                TaskBase task = CurrentTask;
                if (task == null)
                {
                    // Note: disabling buttons may result in .net trying to move focus to the task grid,
                    // and if that grid is empty that may cause SetCurrentCellAddressCore exception,
                    // hence this (TFS~~14180):
                    BeginInvoke((Action)(() => UpdateScheduleUiNoTask()));
                }
                else
                {
                    flwScheduleFrequency.Enabled = true;
                    dtpScheduleDate.Enabled = dtpScheduleTime.Enabled = task.State == TaskState.Ready;
                    grpSchedule.Visible = true;
                    flwScheduleOnce.Visible = task.Schedule.FrequencyOnce;
                    flwScheduleDaily.Visible = task.Schedule.FrequencyDaily;
                    pnlScheduleWeek.Visible = task.Schedule.FrequencyWeekly;
                    pnlScheduleMonth.Visible = task.Schedule.FrequencyMonthly;
                    pnlScheduleMonthDays.Visible = task.Schedule.FrequencyMonthly;
                    numScheduleRepeatFreq.Enabled = chkScheduleRepeat.Checked;
                    cmbScheduleRepeatUnit.Enabled = chkScheduleRepeat.Checked;
                    btnScheduleStart.Enabled = true;
                    if (task.Schedule.Enabled)
                    {
                        btnScheduleStart.Text = "Stop";
                        btnScheduleStart.Image = global::C1ReportsScheduler.Properties.Resources.Stop;
                        btnSchedulePause.Enabled = true;
                    }
                    else
                    {
                        btnScheduleStart.Text = "Start";
                        btnScheduleStart.Image = global::C1ReportsScheduler.Properties.Resources.Start;
                        btnSchedulePause.Enabled = false;
                    }
                    if (task.Schedule.Paused)
                    {
                        btnSchedulePause.Text = "Resume";
                        btnSchedulePause.Image = global::C1ReportsScheduler.Properties.Resources.Resume;
                    }
                    else
                    {
                        btnSchedulePause.Text = "Pause";
                        btnSchedulePause.Image = global::C1ReportsScheduler.Properties.Resources.Pause;
                    }
                    // in client mode, if service is paused, disable both start and stop:
                    if (ClientMode)
                    {
                        bool serviceRunning;
                        using (ServiceController sc = new ServiceController(C1ReportsSchedulerService.Constants.Name))
                        {
                            try
                            {
                                serviceRunning = sc.Status == ServiceControllerStatus.Running;
                            }
                            catch
                            {
                                serviceRunning = false;
                            }
                            finally
                            {
                                sc.Close();
                            }
                        }
                        if (!serviceRunning)
                        {
                            btnScheduleStart.Enabled = false;
                            btnSchedulePause.Enabled = false;
                        }
                    }
                    DateTime nextDueTime = task.Schedule.NextDueTime;
                    if (nextDueTime == ScheduleBase.c_DateTimeNever)
                        lblScheduleNextDueTime.Text = "Never";
                    else
                        lblScheduleNextDueTime.Text = nextDueTime.ToString();
                }
            }
            catch
            {
            }
        }
    }
}
