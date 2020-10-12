using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Chart;

namespace RotatedLabels
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			radioCompass.Checked = false;
			radioCompass.Checked = true;

			c1Chart1.ChartLabels[0].Text = "Rotating\r\nLabel";
		}

		private void picSelect_Paint(object sender, PaintEventArgs e)
		{
			PictureBox pic = sender as PictureBox;
			if (pic != null)
			{
				Graphics g = e.Graphics;
				Font f = this.Font;
				int fs = (int)(f.SizeInPoints * e.Graphics.DpiY / 72);

				Rectangle rect = Rectangle.Inflate(pic.DisplayRectangle, -(12+fs), -(12+fs));
				Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);

				if (pic.Tag == null)
				{
					pic.Tag = rect;
				}

				double radiusi = rect.Width / 2;
				double radiuso = radiusi + 5;
				double radiuss = radiuso + 5 + fs / 2;

				string[] cps = new string[] { "E", "SE", "S", "SW", "W", "NW", "N", "NE" };
				int inc = 360/cps.Length;

				LabelCompassEnum lce = c1Chart1.ChartLabels[0].Compass;

				for (int s = 0; s < cps.Length; s++)
				{
					int i = s * inc;

					Brush brush = ((i & 1) == 0) ? Brushes.CornflowerBlue : Brushes.Cornsilk;

					if (radioCompass.Checked && lce == getLabelCompassFromAngle((i > 180) ? i - 360 : i))
					{
						brush = Brushes.DarkRed;
						g.FillPie(brush, rect, i - inc / 2, inc);
						g.DrawPie(Pens.DarkBlue, rect, i - inc / 2, inc);
					}
					else
						g.FillPie(brush, rect, i - inc / 2, inc);

					double angle = i * Math.PI/180;
					double cos = Math.Cos(angle);
					double sin = Math.Sin(angle);

					string str = radioCompass.Checked ? cps[s] : i.ToString();
					SizeF sz = g.MeasureString(str, f);

					Point tick = new Point( (int)(center.X + radiusi * cos), (int)(center.Y + radiusi * sin));
					Point tickr = new Point((int)(center.X + radiuso * cos), (int)(center.Y + radiuso * sin));
					Point sloc = new Point((int)(center.X + radiuss * cos - sz.Width/2), (int)(center.Y + radiuss * sin - sz.Height/2));

					g.DrawLine(Pens.Black, tick, tickr);
					g.DrawString(str, this.Font, Brushes.Black, sloc);
				}

				if (radioRotation.Checked)
				{
					double angle = c1Chart1.ChartLabels[0].RotationOverride * Math.PI / 180;
					double cos = Math.Cos(angle);
					double sin = Math.Sin(angle);

					Point tick = new Point((int)(center.X + radiusi * cos), (int)(center.Y + radiusi * sin));
					g.DrawLine(Pens.DarkRed, center, tick);
				}

				g.DrawEllipse(Pens.Black, rect);
			}
		}

		private void radioCheckedChanged(object sender, EventArgs e)
		{
			RadioButton radio = sender as RadioButton;
			if (radio != null && radio.Checked)
			{
				picSelect.Refresh();
				GroupBox gb = radio.Parent as GroupBox;
				if (gb != null)
				{
					gb.Text = "Click image to select a " + radio.Text;
				}
			}
		}

		private void picSelect_MouseDown(object sender, MouseEventArgs e)
		{
			if (picSelect.Tag is Rectangle)
			{
				Rectangle r = (Rectangle)picSelect.Tag;
				Point center = new Point(r.X + r.Width / 2, r.Y + r.Height / 2);

				int dist = (int)(Math.Round(Math.Sqrt((e.X - center.X) * (e.X - center.X) + (e.Y - center.Y) * (e.Y - center.Y))));
				if (dist <= r.Width / 2)
				{
					double angle = Math.Atan2(e.Y - center.Y, e.X - center.X) * 180 / Math.PI;
					if (radioCompass.Checked)
						setLabelCompassFromAngle(angle);
					else if(radioRotation.Checked)
						setLabelRotationOverride(angle);
				}
			}
		}

		private LabelCompassEnum getLabelCompassFromAngle(double angle)
		{
			LabelCompassEnum lce = LabelCompassEnum.East;

			if (angle >= -22.5 && angle < 22.5)
				lce = LabelCompassEnum.East;
			else if (angle >= 22.5 && angle < 67.5)
				lce = LabelCompassEnum.SouthEast;
			else if (angle >= 67.5 && angle < 112.5)
				lce = LabelCompassEnum.South;
			else if (angle >= 112.5 && angle < 157.5)
				lce = LabelCompassEnum.SouthWest;
			else if (angle >= 157.5 || angle <= -157.5)
				lce = LabelCompassEnum.West;
			else if (angle <= -112.5 && angle > -157.5)
				lce = LabelCompassEnum.NorthWest;
			else if (angle <= -67.5 && angle > -112.5)
				lce = LabelCompassEnum.North;
			else if (angle <= -22.5 && angle > -67.5)
				lce = LabelCompassEnum.NorthEast;

			return lce;
		}

		private void setLabelCompassFromAngle(double angle)
		{
			c1Chart1.ChartLabels[0].Compass = getLabelCompassFromAngle(angle);
			picSelect.Refresh();
		}

		private void setLabelRotationOverride(double angle)
		{
			if(c1Chart1.ChartLabels.LabelsCollection.Count > 0)
			{
				C1.Win.C1Chart.Label lab = c1Chart1.ChartLabels[0];
				lab.RotationOverride = (int)angle;
				picSelect.Refresh();
			}
		}

		private void c1Chart1_DoubleClick(object sender, EventArgs e)
		{
			Form frm = new Form();
			PropertyGrid pg = new PropertyGrid();
			pg.SelectedObject = c1Chart1.ChartLabels[0];
			pg.Dock = DockStyle.Fill;
			frm.Controls.Add(pg);
			frm.ShowDialog();
		}
	}
}
