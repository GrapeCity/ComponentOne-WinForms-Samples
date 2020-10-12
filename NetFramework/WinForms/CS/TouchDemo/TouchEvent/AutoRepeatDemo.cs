using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchToolKitDemo.TouchEvent
{
    public partial class AutoRepeatDemo : DemoBase
    {
        int number1 = 99;
        int number2 = 99;
        Timer timer;
        int timerInterval;
        Control _targetButton = null;

        public AutoRepeatDemo()
        {
            InitializeComponent();
            InitializeDemo();
        }

        private void InitializeDemo()
        {
            this.Title = "AutoRepeat";
            this.Description = "Provide your own spin buttons by using Buttons with C1TouchEventProvider's EnablePressAndHold.\n    -Try to press and hold on the spin button to increase and decrease the number.";
            
            textBox1.Text = number1.ToString();
            textBox2.Text = number2.ToString();
        }

        private void InputTextBox_Validated(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox != null)
            {
                try
                {
                    if (textbox == textBox1)
                    {
                        number1 = Convert.ToInt32(textbox.Text);
                    }
                    else if (textbox == textBox2)
                    {
                        number2 = Convert.ToInt32(textbox.Text);
                    }
                }
                catch (FormatException)
                {
                    if (textbox == textBox1)
                    {
                        textbox.Text = number1.ToString();
                    }
                    else if (textbox == textBox2)
                    {
                        textbox.Text = number2.ToString();
                    }
                }
            }
        }

        private void upButton2_Click(object sender, EventArgs e)
        {
            number2++;
            textBox2.Text = number2.ToString();
        }

        private void downButton2_Click(object sender, EventArgs e)
        {
            number2--;
            textBox2.Text = number2.ToString();
        }

        private void C1TouchEventProvider1_Tapped(object sender, C1.Win.TouchToolKit.TappedEventArgs e)
        {
            _targetButton = e.TargetControl;
            UpdateValueBySpinButon();
        }

        private void UpdateValueBySpinButon()
        {
            if (_targetButton == upButton1)
            {
                number1++;
                textBox1.Text = number1.ToString();
            }
            else if (_targetButton == downButton1)
            {
                number1--;
                textBox1.Text = number1.ToString();
            }
        }

        private void C1TouchEventProvider1_PointerPressed(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            _targetButton = e.TargetControl;
            StartTimer();
        }

        private void C1TouchEventProvider1_PointerReleased(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            _targetButton = null;
            StopTimer();
        }

        private void StartTimer()
        {
            if (timer == null)
            {
                timer = new Timer();
                timer.Tick += timer_Tick;
            }
            timerInterval = 500;
            timer.Interval = timerInterval;
            timer.Start();
        }

        private void StopTimer()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateValueBySpinButon();

            timerInterval *= 7;
            timerInterval /= 10;
            if (timerInterval < 1)
            {
                timerInterval = 1;
            }
            timer.Interval = timerInterval;
        }
    }
}
