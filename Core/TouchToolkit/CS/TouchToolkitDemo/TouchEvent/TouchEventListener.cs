using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchToolkitDemo.TouchEvent
{
    public partial class TouchEventListener : DemoBase
    {
        #region Fileds
        private string[] eventNames = new string[]{
            "ManipulationStarting",
            "ManipulationStarted",
            "ManipulationDelta",
            "ManipulationInertiaStarting",
            "ManipulationCompleted",

            "Tapped",
            "DoubleTapped",
            "Holding",
            "RightTapped",

            "PointerCanceled",
            "PointerCaptureLost",
            "PointerEntered",
            "PointerExited",
            "PointerMoved",
            "PointerPressed",
            "PointerReleased",
        };

        private string[] parameters = new string[]{
            "ManipulationStartingEventArgs",
            "ManipulationStartedEventArgs",
            "ManipulationDeltaEventArgs",
            "ManipulationInertiaStartingEventArgs",
            "ManipulationCompletedEventArgs",

            "TappedEventArgs",
            "DoubleTappedEventArgs",
            "HoldingEventArgs",
            "RightTappedEventArgs",

            "PointerEventArgs",
            "PointerEventArgs",
            "PointerEventArgs",
            "PointerEventArgs",
            "PointerEventArgs",
            "PointerEventArgs",
            "PointerEventArgs",
        };

        #endregion

        #region Init

        public TouchEventListener()
        {
            InitializeComponent();

            this.Title = "Touch Event Listener";
            this.Description = @"In this page you can listen all(or individual) events of C1TouchEventProvider.
  - Touch in the specified rectangle, selected event logs will be listed.";

            dataGridView1.RowCount = 16;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Height = 30;
                dataGridView1[0, i].Value = i < 5;
                dataGridView1[1, i].Value = eventNames[i];
                dataGridView1[2, i].Value = parameters[i];
            }
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;

            C1TouchEventProvider1.DoubleTapped += C1TouchEventProvider1_DoubleTapped;
            C1TouchEventProvider1.Holding += C1TouchEventProvider1_Holding;
            C1TouchEventProvider1.PointerCanceled += C1TouchEventProvider1_PointerCanceled;
            C1TouchEventProvider1.PointerCaptureLost += C1TouchEventProvider1_PointerCaptureLost;
            C1TouchEventProvider1.PointerEntered += C1TouchEventProvider1_PointerEntered;
            C1TouchEventProvider1.PointerExited += C1TouchEventProvider1_PointerExited;
            C1TouchEventProvider1.PointerMoved += C1TouchEventProvider1_PointerMoved;
            C1TouchEventProvider1.PointerPressed += C1TouchEventProvider1_PointerPressed;
            C1TouchEventProvider1.PointerReleased += C1TouchEventProvider1_PointerReleased;
            C1TouchEventProvider1.RightTapped += C1TouchEventProvider1_RightTapped;
            C1TouchEventProvider1.Tapped += C1TouchEventProvider1_Tapped;
            C1TouchEventProvider1.ManipulationStarting += C1TouchEventProvider1_ManipulationStarting;
            C1TouchEventProvider1.ManipulationStarted += C1TouchEventProvider1_ManipulationStarted;
            C1TouchEventProvider1.ManipulationDelta += C1TouchEventProvider1_ManipulationDelta;
            C1TouchEventProvider1.ManipulationInertiaStarting += C1TouchEventProvider1_ManipulationInertiaStarting;
            C1TouchEventProvider1.ManipulationCompleted += C1TouchEventProvider1_ManipulationCompleted;

            selectAllButton.Click+=selectAllButton_Click;
            manipulationButton.Click+=manipulationButton_Click;
            pointerButton.Click += pointerButton_Click;
            tapButton.Click += tapButton_Click;

            clearButton.Click += clearButton_Click;
        }

        #endregion

        #region Print and clear event information

        private int id = 1;

        void clearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            id = 1;
        }

        void C1TouchEventProvider1_ManipulationCompleted(object sender, C1.Win.TouchToolKit.ManipulationCompletedEventArgs e)
        {
            if ((bool)dataGridView1[0, 4].Value)
            {
                listBox1.Items.Add(id.ToString() + ":ManipulationCompleted");
                id++;
            }
        }

        void C1TouchEventProvider1_ManipulationInertiaStarting(object sender, C1.Win.TouchToolKit.ManipulationInertiaStartingEventArgs e)
        {
            if ((bool)dataGridView1[0, 3].Value)
            {
                listBox1.Items.Add(id.ToString() + ":ManipulationInertiaStarting");
                id++;
            }
        }

        void C1TouchEventProvider1_ManipulationDelta(object sender, C1.Win.TouchToolKit.ManipulationDeltaEventArgs e)
        {
            if ((bool)dataGridView1[0, 2].Value)
            {
                listBox1.Items.Add(id.ToString() + ":ManipulationDelta");
                id++;
            }
        }

        void C1TouchEventProvider1_ManipulationStarted(object sender, C1.Win.TouchToolKit.ManipulationStartedEventArgs e)
        {
            if ((bool)dataGridView1[0, 1].Value)
            {
                listBox1.Items.Add(id.ToString() + ":ManipulationStarted");
                id++;
            }
        }

        void C1TouchEventProvider1_ManipulationStarting(object sender, C1.Win.TouchToolKit.ManipulationStartingEventArgs e)
        {
            if ((bool)dataGridView1[0, 0].Value)
            {
                listBox1.Items.Add(id.ToString() + ":ManipulationStarting");
                id++;
            }
        }

        void C1TouchEventProvider1_PointerReleased(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            if ((bool)dataGridView1[0, 15].Value)
            {
                listBox1.Items.Add(id.ToString() + ":PointerReleased");
                id++;
            }
        }

        void C1TouchEventProvider1_PointerPressed(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            if ((bool)dataGridView1[0, 14].Value)
            {
                listBox1.Items.Add(id.ToString() + ":PointerPressed");
                id++;
            }
        }

        void C1TouchEventProvider1_PointerMoved(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            if ((bool)dataGridView1[0, 13].Value)
            {
                listBox1.Items.Add(id.ToString() + ":PointerMoved");
                id++;
            }
        }

        void C1TouchEventProvider1_PointerExited(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            if ((bool)dataGridView1[0, 12].Value)
            {
                listBox1.Items.Add(id.ToString() + ":PointerExited");
                id++;
            }
        }

        void C1TouchEventProvider1_PointerEntered(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            if ((bool)dataGridView1[0, 11].Value)
            {
                listBox1.Items.Add(id.ToString() + ":PointerEntered");
                id++;
            }
        }

        void C1TouchEventProvider1_PointerCaptureLost(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            if ((bool)dataGridView1[0, 10].Value)
            {
                listBox1.Items.Add(id.ToString() + ":PointerCaptureLost");
                id++;
            }
        }

        void C1TouchEventProvider1_PointerCanceled(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            if ((bool)dataGridView1[0, 9].Value)
            {
                listBox1.Items.Add(id.ToString() + ":PointerCanceled");
                id++;
            }
        }

        void C1TouchEventProvider1_RightTapped(object sender, C1.Win.TouchToolKit.RightTappedEventArgs e)
        {
            if ((bool)dataGridView1[0, 8].Value)
            {
                listBox1.Items.Add(id.ToString() + ":RightTapped");
                id++;
            }
        }

        void C1TouchEventProvider1_Holding(object sender, C1.Win.TouchToolKit.HoldingEventArgs e)
        {
            if ((bool)dataGridView1[0, 7].Value)
            {
                listBox1.Items.Add(id.ToString() + ":Holding");
                id++;
            }
        }

        void C1TouchEventProvider1_DoubleTapped(object sender, C1.Win.TouchToolKit.DoubleTappedEventArgs e)
        {
            if ((bool)dataGridView1[0, 6].Value)
            {
                listBox1.Items.Add(id.ToString() + ":DoubleTapped");
                id++;
            }
        }

        void C1TouchEventProvider1_Tapped(object sender, C1.Win.TouchToolKit.TappedEventArgs e)
        {
            if ((bool)dataGridView1[0, 5].Value)
            {
                listBox1.Items.Add(id.ToString() + ":Tapped");
                id++;
            }
        }

        #endregion

        #region select events

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            bool allIsChecked = true;
            for (int i = 0; i < 16; i++)
            {
                if ((bool)dataGridView1[0, i].Value == false)
                {
                    allIsChecked = false;
                    break;
                }
            }
            if (allIsChecked)
            {
                for (int i = 0; i < 16; i++)
                {
                    dataGridView1[0, i].Value = false;
                }
            }
            else
            {
                for (int i = 0; i < 16; i++)
                {
                    dataGridView1[0, i].Value = true;
                }
            }
        }

        private void manipulationButton_Click(object sender, EventArgs e)
        {
            bool manipulationIsChecked = true;
            for (int i = 0; i < 5; i++)
            {
                if ((bool)dataGridView1[0, i].Value == false)
                {
                    manipulationIsChecked = false;
                    break;
                }
            }
            if (manipulationIsChecked)
            {
                for (int i = 0; i < 5; i++)
                {
                    dataGridView1[0, i].Value = false;
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    dataGridView1[0, i].Value = true;
                }
            }
        }

        private void pointerButton_Click(object sender, EventArgs e)
        {
            bool pointerIsChecked = true;
            for (int i = 9; i < 16; i++)
            {
                if ((bool)dataGridView1[0, i].Value == false)
                {
                    pointerIsChecked = false;
                    break;
                }
            }
            if (pointerIsChecked)
            {
                for (int i = 9; i < 16; i++)
                {
                    dataGridView1[0, i].Value = false;
                }
            }
            else
            {
                for (int i = 9; i < 16; i++)
                {
                    dataGridView1[0, i].Value = true;
                }
            }
        }

        private void tapButton_Click(object sender, EventArgs e)
        {
            bool tapIsChecked = true;
            for (int i = 5; i < 9; i++)
            {
                if ((bool)dataGridView1[0, i].Value == false)
                {
                    tapIsChecked = false;
                    break;
                }
            }
            if (tapIsChecked)
            {
                for (int i = 5; i < 9; i++)
                {
                    dataGridView1[0, i].Value = false;
                }
            }
            else
            {
                for (int i = 5; i < 9; i++)
                {
                    dataGridView1[0, i].Value = true;
                }
            }
        }

        #endregion
    }
}
