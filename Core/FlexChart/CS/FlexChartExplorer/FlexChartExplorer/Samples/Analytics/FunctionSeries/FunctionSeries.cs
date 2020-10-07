using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    public class FunctionSeries:Series
    {
        private double _min, _max;
        private double[] _xVals, _yVals;
        private int _sampleCount;
        /// <summary>
        /// Initializes a new instance of the FunctionSeries class.
        /// </summary>
        public FunctionSeries()
        {
            this._min = 0;
            this._max = 1;
            this.ChartType = C1.Chart.ChartType.Line;
        }
        /// <summary>
        /// Gets or sets the minimum value of the parameter for calculating a function. 
        /// </summary>
        public double Min
        {
            get { return _min; }
            set { _min = value; this.Invalidate(); }
        }
        /// <summary>
        /// Gets or sets the maximum value of the parameter for calculating a function. 
        /// </summary>
        public double Max
        {
            get { return _max; }
            set { _max = value; this.Invalidate(); }
        }
        /// <summary>
        /// Gets or sets the sample count for function calculation.
        /// </summary>
        public int SampleCount
        {
            get { return _sampleCount; }
            set { _sampleCount = value; }
        }
        /// <summary>
        /// Gets the data values.
        /// </summary>
        /// <param name="dim"></param>
        /// <returns></returns>
        public override double[] GetValues(int dim)
        {

            if (_xVals == null || _yVals == null)
            {
                this.CalculateValues();
            }
            if (dim == 0)
            {
                return _yVals;
            }
            if (dim == 1)
            {
                return _xVals;
            }
            return null;
        }
        private void CalculateValues()
        {
            double[] x = new double[_sampleCount];
            double[] y = new double[_sampleCount];
            double delta = (this.Max - this.Min) / (_sampleCount - 1);
            double t;

            for (int i = 0; i < _sampleCount; i++)
            {
                t = i == _sampleCount ? this.Max : this.Min + delta * i;
                x[i] = this.CalculateX(t);
                y[i] = this.CalculateY(t);
            }
            _xVals = x;
            _yVals = y;
        }
        internal virtual double CalculateX(double t)
        {
            return 0;
        }
        internal virtual double CalculateY(double t)
        {
            return 0;
        }
    }
    /// <summary>
    /// Represents a Y function series 
    /// The YFunctionSeries plots a function defined by formulas of type y=f(x), specified using the function property.
    /// </summary>
    public class YFunctionSeries : FunctionSeries
    {
        private Func<double, double> _function;
        /// <summary>
        /// Gets or Sets the function to obtain Y-value.
        /// </summary>
        public Func<double, double> Function
        {
            get { return _function; }
            set { _function = value; this.Invalidate(); }
        }
        internal override double CalculateX(double t)
        {
            return t;
        }
        internal override double CalculateY(double t)
        {
            if (Function != null)
                return this.Function.Invoke(t);
            return base.CalculateY(t);
        }
    }
    public class ParametricFunctionSeries : FunctionSeries
    {
        private Func<double, double> _xFunction;
        private Func<double, double> _yFunction;
        /// <summary>
        /// Gets or Sets the function used to calculate X-value.
        /// </summary>
        public Func<double, double> XFunction
        {
            get { return _xFunction; }
            set { _xFunction = value; }
        }
        /// <summary>
        /// Gets or Sets the function used to calculate Y-value.
        /// </summary>
        public Func<double, double> YFunction
        {
            get { return _yFunction; }
            set { _yFunction = value; }
        }
        internal override double CalculateX(double t)
        {
            if (this.XFunction != null)
                return this.XFunction.Invoke(t);
            return base.CalculateX(t);
        }
        internal override double CalculateY(double t)
        {
            if (this.YFunction != null)
                return this.YFunction.Invoke(t);
            return base.CalculateY(t);
        }
    }
}
