using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C1.FlexMap;
using C1.Win.Interop;

namespace MapSample.Layers
{
    internal abstract class MapProjection : IMapProjection
    {
        public const double RadsInDegree = Math.PI / 180.0;
        public const double DegreesInRad = 180.0 / Math.PI;
        public const double LongitudeRads = 2 * Math.PI;
        public const double LatitudeRads = 2 * Math.PI;

        /// <summary>
        /// Indicates whether the parallel lines are curved.
        /// </summary>
        /// <remarks>
        /// true if the parallel lines are curved; otherwise, false.
        /// </remarks>
        public virtual bool IsParallelCurved()
        {
            return false;
        }

        /// <summary>
        /// Indicates whether the meridian lines are curved.
        /// </summary>
        /// <returns>
        /// true if the meridian lines are curved; otherwise, false.
        /// </returns>
        public virtual bool IsMeridianCurved()
        {
            return false;
        }

        /// <summary>
        /// Projects a geographic coordinate to logical coordinate.
        /// </summary>
        /// <param name="longLat">The geographic coordinate to project.</param>
        /// <returns>The logical coordinate corresponding to the geographic coordinate.</returns>
        public virtual Point Project(Point longLat)
        {
            var longitude = longLat.X;
            var latigude = longLat.Y;

            var λ = longitude * RadsInDegree;
            var φ = latigude * RadsInDegree;

            var p = Project(λ, φ);
            var x = p.X / LongitudeRads + 0.5;
            var y = -p.Y / LatitudeRads + 0.5;

            return new Point(x, y);
        }

        /// <summary>
        /// Inverse of <see cref="Project"/>. Unprojects a logical coordinate to a geographic coordinate.
        /// </summary>
        /// <param name="point">The logical coordinate to apply the inverse projection.</param>
        /// <returns>The geographic coordinate corresponding to the logical coordinate.</returns>
        public virtual Point Unproject(Point point)
        {
            var x = (point.X - 0.5) * LongitudeRads;
            var y = -(point.Y - 0.5) * LatitudeRads;
            var p = Unproject(x, y);
            var λ = p.X;
            var φ = p.Y;
            return new Point(λ * DegreesInRad, φ * DegreesInRad);
        }

        /// <summary>
        /// Projects a geographic coordinate.
        /// </summary>
        /// <param name="λ">The longitude in degree.</param>
        /// <param name="φ">The latitude in degree.</param>
        /// <returns>The projected coordinate in degree.</returns>
        protected abstract Point Project(double λ, double φ);

        /// <summary>
        /// Unprojects a geographic coordinate.
        /// </summary>
        /// <param name="x">The longitude in degree.</param>
        /// <param name="y">The latitude in degree.</param>
        /// <returns>The unprojected coordinate in degree.</returns>
        protected abstract Point Unproject(double x, double y);
    }

    // refer https://en.wikipedia.org/wiki/Gall%E2%80%93Peters_projection
    internal class GallPetersProjection : MapProjection
    {
        protected override Point Project(double λ, double φ)
        {
            var x = λ;
            var sy = Math.Sin(φ);
            var y = sy * Math.PI;
            return new Point(x, y);
        }

        protected override Point Unproject(double x, double y)
        {
            var λ = x;
            var sy = y / Math.PI;
            sy = Math.Max(-1, Math.Min(1, sy));
            var φ = Math.Asin(sy);
            return new Point(λ, φ);
        }
    }

    // refer https://en.wikipedia.org/wiki/Sinusoidal_projection
    internal class SinusoidalProjection : MapProjection
    {
        public override bool IsMeridianCurved()
        {
            return true;
        }

        protected override Point Project(double λ, double φ)
        {
            var x = λ * Math.Cos(φ);
            var y = φ;
            return new Point(x, y);
        }

        protected override Point Unproject(double x, double y)
        {
            var φ = y;
            var λ = x / Math.Cos(φ);
            return new Point(λ, φ);
        }
    }

    // refer https://en.wikipedia.org/wiki/Bonne_projection
    internal class BonneProjection : MapProjection
    {
        private readonly double _projectionCenterX;
        private readonly double _projectionCenterY;

        /// <summary>
        /// Standard parallel in radians
        /// </summary>
        private readonly double _φ0;

        /// <summary>
        /// The pre-calculated value of fi0 cotangent
        /// </summary>
        private readonly double _ctgφ0;

        public BonneProjection(double projectionCenterX, double projectionCenterY)
        {
            _projectionCenterX = projectionCenterX;
            _projectionCenterY = projectionCenterY;

            //Standard parallel of the projection. On standard parallel shapes are not distorted
            _φ0 = projectionCenterY * RadsInDegree;
            if (!(Math.Abs(_φ0) > double.Epsilon))
                return;

            _ctgφ0 = Math.Abs(_φ0) - Math.PI / 2 > double.Epsilon
                ? 0
                : 1 / Math.Tan(_φ0);
        }

        public double CenterX
        {
            get { return _projectionCenterX; }
        }

        public double CenterY
        {
            get { return _projectionCenterY; }
        }

        public override bool IsParallelCurved()
        {
            return true;
        }

        public override bool IsMeridianCurved()
        {
            return true;
        }

        protected override Point Project(double λ, double φ)
        {
            λ -= _projectionCenterX * RadsInDegree;
            λ = LimitValue(-Math.PI, Math.PI, λ);

            if (Math.Abs(_φ0) < double.Epsilon)
                return Sinusoidal(λ, φ);

            var ρ = _ctgφ0 + _φ0 - φ;
            var e = Math.Abs(ρ) > double.Epsilon
                ? λ * Math.Cos(φ) / ρ
                : ρ;

            var x = ρ * Math.Sin(e);
            var y = _ctgφ0 - ρ * Math.Cos(e);

            return new Point(x, y);
        }

        protected override Point Unproject(double x, double y)
        {
            if (Math.Abs(_φ0) < double.Epsilon)
            {
                var p = UnSinusoidal(x, y);
                p.X += _projectionCenterX * RadsInDegree;
                p.X = LimitValue(-Math.PI, Math.PI, p.X);
                return p;
            }

            var ρ = Math.Sqrt(x * x + Math.Pow((_ctgφ0 - y), 2));
            if (_φ0 < 0) ρ = -ρ;

            var φ = _ctgφ0 + _φ0 - ρ;
            var λ = (ρ / Math.Cos(φ)) * Math.Atan(x / (_ctgφ0 - y));

            λ += _projectionCenterX * RadsInDegree;
            λ = LimitValue(-Math.PI, Math.PI, λ);

            return new Point(λ, φ);
        }

        private Point Sinusoidal(double λ, double φ)
        {
            var x = λ * Math.Cos(φ);
            var y = φ;
            return new Point(x, y);
        }

        private Point UnSinusoidal(double x, double y)
        {
            var φ = y;
            var λ = x / Math.Cos(φ);
            return new Point(λ, φ);
        }

        private double LimitValue(double min, double max, double value)
        {
            return Math.Max(min, Math.Min(max, value));
        }
    }
}
