//----------------------------------------------------------------------------
// ZoomSliderScale.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FlexReportDesignerApp.Util
{
    /// <summary>
    /// A helper class that allows to use a slider control for a zoom factor value,
    /// placing zoom factor 1 (no zoom) in the middle of the slider control.
    /// </summary>
    /// <remarks>
    /// Consider a 2cm long slider used to set zoom values in the range from 0.1 to 10
    /// (i.e. from 10% to 1000%).
    /// Using <see cref="ZoomSliderScale"/>, the first centimeter of the slider
    /// will correspond to zoom values from 10% to 100%, and the second centimeter
    /// will correspond to zoom values from 100% to 1000%.
    /// On the other hand if a simple linear slider were used,
    /// all zoom values between 10% and 100% would have been squeezed into the
    /// first two millimeters of the slider, making it very hard to set those values.
    /// </remarks>
    public class ZoomSliderScale
    {
        private double _minZoom;
        private double _maxZoom;
        private int _minSlider;
        private int _maxSlider;
        private double _midSlider;
        // We use 2 linear but different equations for zoomFactor(sliderValue) function,
        // one for zoom values below 1, another for zoom values above 1:
        // zoom(slider): y - y1 = q * (x - x1)
        private double _qBelow1;
        private double _qAbove1;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoomSliderScale"/> class.
        /// </summary>
        /// <param name="minZoom">Minimum allowed zoom factor (must be less than 1; 1 means no zoom).</param>
        /// <param name="maxZoom">Maximum allowed zoom factor (must be greater than 1; 1 means no zoom).</param>
        /// <param name="minSlider">Minimum possible slider value.</param>
        /// <param name="maxSlider">Maximum possible slider value.</param>
        public ZoomSliderScale(double minZoom, double maxZoom, int minSlider, int maxSlider)
        {
            System.Diagnostics.Debug.Assert(minZoom < 1 && maxZoom > 1);
            System.Diagnostics.Debug.Assert(minSlider < maxSlider);
            _minZoom = minZoom;
            _maxZoom = maxZoom;
            _minSlider = minSlider;
            _maxSlider = maxSlider;
            _midSlider = minSlider + (maxSlider - minSlider) / 2.0;
            _qBelow1 = (1.0 - minZoom) / (_midSlider - minSlider);
            _qAbove1 = (maxZoom - 1.0) / (maxSlider - _midSlider);
        }

        /// <summary>
        /// Converts a zoom factor to the corresponding slider value.
        /// </summary>
        /// <param name="zoomFactor">The zoom factor to convert (1 means no zoom).</param>
        /// <returns>The slider value.</returns>
        public int SliderValue(double zoomFactor)
        {
            if (zoomFactor < 1)
                return _minSlider + (int)Math.Round((zoomFactor - _minZoom) / _qBelow1);
            else
                return _maxSlider + (int)Math.Round((zoomFactor - _maxZoom) / _qAbove1);
        }

        /// <summary>
        /// Converts a slider value to the corresponding zoom factor.
        /// </summary>
        /// <param name="sliderValue">The slider value to convert.</param>
        /// <returns>The zoom factor (1 means no zoom).</returns>
        public double ZoomFactor(int sliderValue)
        {
            if (sliderValue < _midSlider)
                return _minZoom + _qBelow1 * (sliderValue - _minSlider);
            else if (sliderValue > _midSlider)
                return _maxZoom + _qAbove1 * (sliderValue - _maxSlider);
            else
                return 1;
        }
    }
}
