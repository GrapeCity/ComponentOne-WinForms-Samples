//----------------------------------------------------------------------------
// C1\Win\C1Report\CustomFields\Gradient.cs
//
// Custom C1Report field: Gradient
//
// This class inherits from C1Report.Field and uses a LinearGradient brush
// to draw a gradient background. If the field contains text, that is also
// displayed.
//
// Object Model:
//
// public Color ColorFrom
//	Initial color for the gradient background
//
// public Color ColorTo
//	Final color for the gradient background
//
// public int Angle
//	Angle for the gradient pattern, in degrees
//
// public int BorderRadius
//  Radius for rounded rectangles, in twips
//
// Copyright (C) 2004 - 2005 ComponentOne LLC
//----------------------------------------------------------------------------
// Status   Date        By          Comments
// Created	June 2004	Bernardo	-
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace C1.C1Report.CustomFields
{
    using C1.C1Preview;
	using C1.C1Report;
	//using C1.Win.C1Report.Util;

	/// <summary>
	/// This class inherits from <see cref="Field"/> and uses a LinearGradient brush
	/// to draw a gradient background. If the field contains text, that is also displayed.
	/// </summary>
	[Description("Gradient Field")]
	public class Gradient : C1.C1Report.Field
	{
		// ** fields
		private Color			_clrFrom, _clrTo;	// gradient colors
		private int				_angle;				// gradient angle
		private SolidBrush		_brBack, _brFore;	// back/fore brushes
		private StringFormat	_fmt;				// to align strings
		private int				_radius;			// for rounded borders <<B178>>

		// ** ctor
		/// <summary>
		/// Initializes a new instance of the <see cref="Gradient"/> class.
		/// </summary>
		public Gradient()
		{
			// intialize instance
			ColorFrom    = Color.Blue;
			ColorTo      = Color.White;
			Angle        = 0;
			PictureAlign = PictureAlignEnum.Stretch;
		}

		// ** properties
		/// <summary>
		/// Initial color for the gradient background.
		/// </summary>
		[ Category("Gradient"), DefaultValue(typeof(Color), "Blue") ]
		public Color ColorFrom
		{
			get { return _clrFrom; }
			set
			{
				_clrFrom = value;
				OnPropertyChanged();
			}
		}
		/// <summary>
		/// Final color for the gradient background.
		/// </summary>
		[ Category("Gradient"), DefaultValue(typeof(Color), "White") ]
		public Color ColorTo
		{
			get { return _clrTo; }
			set 
			{
				_clrTo = value; 
				OnPropertyChanged();
			}
		}
		/// <summary>
		/// Angle for the gradient pattern, in degrees.
		/// </summary>
		[ Category("Gradient"), DefaultValue(0) ]
		public int Angle
		{
			get { return _angle; }
			set 
			{
				_angle = value; 
				OnPropertyChanged();
			}
		}
		/// <summary>
		/// This property allows you to specify a rounded radius for the field background in twips.
		/// </summary>
		/// <remarks>
		/// The rounded gradients are not exported correctly to pdf (they are rendered 
		/// as regular rectangles). If you specify a BorderRadius, LineWidth, and Color, then
		/// the field will render a rounded border as well. 
		/// The rounded border is exported to pdf correctly.
		/// </remarks>
		[ Category("Border"), DefaultValue(0) ]
		public int BorderRadius // <<B178>>
		{
			get { return _radius; }
			set 
			{
				_radius = value; 

				// prevent base class (Field) from drawing the border
				// if there's a positive radius (we will draw it ourselves)
				if (_radius > 0)
				{
					BorderStyle = BorderStyleEnum.Transparent;
				}
				OnPropertyChanged();
			}
		}

		// ** overrides
		/// <summary>
		/// Selects the text or image that will be rendered by the field.
		/// </summary>
		/// <param name="value">Field text.</param>
		/// <param name="img">Field image.</param>
		/// <param name="designTime">Whether we in design time or runtime.</param>
		override protected void GetRenderContent(ref string value, ref Image img, bool designTime)
		{
			// create image
			using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
			{
				// calculate field size in pixels 
				// (based on field size in twips and screen resolution)
				Size size = GetFieldSizePixels(g);
				Rectangle rc = new Rectangle(Point.Empty, size);

				// create metafile image (this is the return value)
				IntPtr hdc = g.GetHdc();
				img = new Metafile(hdc, rc, MetafileFrameUnit.Pixel);
				using (Graphics meta = Graphics.FromImage(img))
				{
					// some multiples of 90 degrees create spurious lines <<B168>>
					int angle = _angle;
					while (angle < 0) angle += 360;
					if (angle % 90 == 0) angle++;

					// calculate border radius in pixels
					int radius = (int)(_radius * 96f / 1440f);

					// draw background
					using (LinearGradientBrush br = new LinearGradientBrush(rc, _clrFrom, _clrTo, angle))
					{
						// fill background as usual
						if (BackColor != Utils.TransparentColor)
						{
							// update brush
							if (_brBack == null || _brBack.Color != Utils.FromWpfColor(BackColor))
								_brBack = new SolidBrush(Utils.FromWpfColor(BackColor));
							meta.FillRectangle(_brBack, rc);
						}

						// create pen if necessary
						Pen pen = null;
						if (BorderColor != Utils.TransparentColor && BorderStyle == BorderStyleEnum.Transparent && LineWidth > 0)
						{
							int lineWidth = Math.Max(1, (int)(LineWidth * 96f / 1440f));
							rc.Inflate(-lineWidth/2, -lineWidth/2);
							pen = new Pen(Utils.FromWpfColor(BorderColor), lineWidth);
						}
							
						// draw the background and border
						RoundRect(meta, br, pen, rc, radius, radius);

						// dispose of pen
						if (pen != null) pen.Dispose();
					}

					// draw string content
					if (value != null && value.Length > 0)
					{
						// update brush
						if (_brFore == null || _brFore.Color != Utils.FromWpfColor(ForeColor))
							_brFore = new SolidBrush(Utils.FromWpfColor(ForeColor));

						// draw string
						meta.DrawString(value, Font, _brFore, rc, GetStringFormat());
					}
				}

				// adjust image size for actual screen resolution
				// (as opposed to 'logical dpi')
				img = AdjustImageSize(hdc, img);

				// done with reference dc
				g.ReleaseHdc(hdc);
			}
		}

		// ** private
		private Size GetFieldSizePixels(Graphics g)
		{
			Size sz = new Size((int)(Width/1440f*g.DpiX), (int)(Height/1440f*g.DpiY));

			// can't be empty
			if (sz.Width  <= 0) sz.Width  = 1;
			if (sz.Height <= 0) sz.Height = 1;

			// return size
			return sz;
		}
		private Size GetFieldSizePixels()
		{
			using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
				return GetFieldSizePixels(g);
		}
		/// <summary>
		/// Adjust image size to account for difference between logical 
		/// and physical screen resolutions.
		/// </summary>
		private Image AdjustImageSize(IntPtr hdc, Image img)
		{
			// create new image with exact size
			RectangleF rc = new RectangleF(0, 0, (float)(Width/20f), (float)(Height/20f));
			if (rc.Width <= 0 || rc.Height <= 0) return null;
			Image imgFixed = new Metafile(hdc, rc, MetafileFrameUnit.Point);

			// stretch old image into new one
			rc.Width  = (int)(Width  / 1440 * img.HorizontalResolution + 0.5);
			rc.Height = (int)(Height / 1440 * img.VerticalResolution + 0.5);
			if (rc.Width <= 0 || rc.Height <= 0) return null;
			using (Graphics meta = Graphics.FromImage(imgFixed))
				meta.DrawImage(img, rc);

			// return new image
			return imgFixed;
		}
		/// <summary>
		/// Gets the StringFormat object used to draw the field text.
		/// </summary>
		private StringFormat GetStringFormat()
		{
			// create StringFormat on first use
			if (_fmt == null)
				_fmt = new StringFormat();

			// set horizontal alignment
			switch (Align)
			{
				case FieldAlignEnum.JustBottom:
				case FieldAlignEnum.JustMiddle:
				case FieldAlignEnum.JustTop:
				case FieldAlignEnum.LeftBottom:
				case FieldAlignEnum.LeftMiddle:
				case FieldAlignEnum.LeftTop:
				case FieldAlignEnum.General:
					_fmt.Alignment = StringAlignment.Near;
					break;
				case FieldAlignEnum.CenterBottom:
				case FieldAlignEnum.CenterMiddle:
				case FieldAlignEnum.CenterTop:
					_fmt.Alignment = StringAlignment.Center;
					break;
				case FieldAlignEnum.RightBottom:
				case FieldAlignEnum.RightMiddle:
				case FieldAlignEnum.RightTop:
					_fmt.Alignment = StringAlignment.Far;
					break;
			}

			// set vertical alignment
			switch (Align)
			{
				case FieldAlignEnum.LeftTop:
				case FieldAlignEnum.RightTop:
				case FieldAlignEnum.JustTop:
				case FieldAlignEnum.CenterTop:
				case FieldAlignEnum.General:
					_fmt.LineAlignment = StringAlignment.Near;
					break;
				case FieldAlignEnum.CenterBottom:
				case FieldAlignEnum.JustBottom:
				case FieldAlignEnum.LeftBottom:
				case FieldAlignEnum.RightBottom:
					_fmt.LineAlignment = StringAlignment.Far;
					break;
				case FieldAlignEnum.CenterMiddle:
				case FieldAlignEnum.JustMiddle:
				case FieldAlignEnum.LeftMiddle:
				case FieldAlignEnum.RightMiddle:
					_fmt.LineAlignment = StringAlignment.Center;
					break;
			}

			// done
			return _fmt;
		}
		/// <summary>
		/// Draw rounded rectangle.
		/// </summary>
		public void DrawRoundRect(Graphics g, Pen pen, Rectangle rc, int radiusX, int radiusY)
		{
			RoundRect(g, null, pen, rc, radiusX, radiusY);
		}
		/// <summary>
		/// Fill rounded rectangle.
		/// </summary>
		/// <param name="g"></param>
		/// <param name="brush"></param>
		/// <param name="rc"></param>
		/// <param name="radiusX"></param>
		/// <param name="radiusY"></param>
		public void FillRoundRect(Graphics g, Brush brush, Rectangle rc, int radiusX, int radiusY)
		{
			RoundRect(g, brush, null, rc, radiusX, radiusY);
		}
		/// <summary>
		/// Draw and fill rounded rectangle.
		/// </summary>
		/// <param name="g"></param>
		/// <param name="brush"></param>
		/// <param name="pen"></param>
		/// <param name="rc"></param>
		/// <param name="radiusX"></param>
		/// <param name="radiusY"></param>
		public void RoundRect(Graphics g, Brush brush, Pen pen, Rectangle rc, int radiusX, int radiusY)
		{
			// validate radii
			if (radiusX > rc.Width/2)  radiusX = rc.Width/2;
			if (radiusY > rc.Height/2) radiusY = rc.Height/2;

			// validate rect
			if (rc.Width < 0 || rc.Height < 0)
				return;

			// draw round rect
			if (radiusX > 0 && radiusY > 0)
			{
				try
				{
					using (GraphicsPath gp = new GraphicsPath())
					{
						// build graphics path
						gp.AddLine(rc.X+radiusX, rc.Y, rc.Right-radiusX, rc.Y);
						gp.AddArc(rc.Right-2*radiusX, rc.Y, 2*radiusX, 2*radiusY, 270, 90);
						gp.AddLine(rc.Right, rc.Y+radiusY, rc.Right, rc.Bottom-radiusY);
						gp.AddArc(rc.Right-2*radiusX, rc.Bottom-2*radiusY, 2*radiusX, 2*radiusY, 0, 90);
						gp.AddLine(rc.Right-radiusX, rc.Bottom, rc.X+radiusX, rc.Bottom);
						gp.AddArc(rc.X, rc.Bottom-2*radiusY, 2*radiusX, 2*radiusY, 90, 90);
						gp.AddLine(rc.X, rc.Bottom-radiusY, rc.X, rc.Y+radiusY);
						gp.AddArc(rc.X, rc.Y, 2*radiusX, 2*radiusY, 180, 90);

						// fill
						if (brush != null) 
							g.FillPath(brush, gp);

						// and/or draw
						if (pen != null)
							g.DrawPath(pen, gp);
					}

					// round rect drawn successfully
					return;
				}
				catch {}
			}

			// rectangle too small for corner size, draw straight rect
			if (brush != null) 
				g.FillRectangle(brush, rc);
			if (pen != null)
				g.DrawRectangle(pen, rc);
		}
	}
}
