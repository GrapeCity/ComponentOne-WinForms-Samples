using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using C1.C1Preview;
using C1.C1Preview.Serialization;

namespace WrapperDoc
{
    public class C1PrintDocumentWrapper : C1PrintDocument
    {
        private MeasureInfo _lastRenderedInfo;

        #region RenderXXX methods

        public new MeasureInfo RenderBlock(RenderObject ro)
        {
            base.RenderBlock(ro);
            _lastRenderedInfo = new MeasureInfo(ro);
            return _lastRenderedInfo;
        }

        public new MeasureInfo RenderDirect(Unit x, Unit y, RenderObject ro)
        {
            base.RenderDirect(x, y, ro);
            _lastRenderedInfo = new MeasureInfo(ro);
            return _lastRenderedInfo;
        }

        public MeasureInfo RenderDirect(Unit x, Unit y, RenderObject ro, Unit width, Unit height)
        {
            base.RenderDirect(x, y, ro, width, height);
            _lastRenderedInfo = new MeasureInfo(ro);
            return _lastRenderedInfo;
        }

        #endregion

        #region MeasureXXX methods

        /// <summary>
        /// Only Width, Height, WidthUnit and HeightUnit properties of MeasureInfo have valid
        /// values after MeasureObject call.
        /// </summary>
        /// <param name="ro">RenderObject to measure.</param>
        /// <returns>Returns the MeasureInfo object with sizes of object.</returns>
        public MeasureInfo MeasureObject(RenderObject ro, Unit width, Unit height)
        {
            bool wasAdded = ro.Document == null;
            if (ro.Document == null)
                this.Body.Children.Add(ro);

            SizeD sz = ro.CalcSize(width, height);
            UnitTypeEnum resolvedUnit = ro.Document.ResolvedUnit;

            if (wasAdded)
                this.Body.Children.Remove(ro);

            return new MeasureInfo(ro, sz, resolvedUnit);
        }

        #endregion

        #region Public properties

        public MeasureInfo LastRenderedInfo
        {
            get { return _lastRenderedInfo; }
        }

        #endregion
    }

    public class MeasureInfo
    {
        private UnitRectangle[] _renderedAreas;
        private bool _newPage;
        private bool _newColumn;

        #region Constructors

        public MeasureInfo(RenderObject renderObject)
        {
            if (!renderObject.HasFragments)
                throw new ArgumentException("RenderObject is not resolved.");

            C1Page priorPage = null;
            _renderedAreas = new UnitRectangle[renderObject.Fragments.Count];
            for (int i = 0; i < renderObject.Fragments.Count; i++)
            {
                _renderedAreas[i] = new UnitRectangle();
                _renderedAreas[i].X = new Unit(renderObject.Fragments[i].Bounds.X, renderObject.Document.ResolvedUnit);
                _renderedAreas[i].Y = new Unit(renderObject.Fragments[i].Bounds.Y, renderObject.Document.ResolvedUnit);
                _renderedAreas[i].Width = new Unit(renderObject.Fragments[i].Bounds.Width, renderObject.Document.ResolvedUnit);
                _renderedAreas[i].Height = new Unit(renderObject.Fragments[i].Bounds.Height, renderObject.Document.ResolvedUnit);

                if (priorPage != null)
                {
                    if (renderObject.Fragments[i].Page != priorPage)
                        _newPage = true;
                    else
                        _newColumn = true;
                }
                priorPage = renderObject.Fragments[i].Page;
            }
        }

        public MeasureInfo(RenderObject renderObject, SizeD size, UnitTypeEnum resolvedUnit)
        {
            _renderedAreas = new UnitRectangle[1];
            _renderedAreas[0].X = new Unit(0, resolvedUnit);
            _renderedAreas[0].Y = new Unit(0, resolvedUnit);
            _renderedAreas[0].Width = new Unit(size.Width, resolvedUnit);
            _renderedAreas[0].Height = new Unit(size.Height, resolvedUnit);
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Width of last rendered area in the RenderedAreas array in
        /// default document's units, defined by C1PrintDocument.ResolvedUnit property.
        /// </summary>
        public double Width
        {
            get { return WidthUnit.Value; }
        }

        /// <summary>
        /// Height of last rendered area in the RenderedAreas array in
        /// default document's units, defined by C1PrintDocument.ResolvedUnit property.
        /// </summary>
        public double Height
        {
            get { return HeightUnit.Value; }
        }

        /// <summary>
        /// Width of last rendered area in the RenderedAreas array.
        /// </summary>
        public Unit WidthUnit
        {
            get { return RenderedArea.Width; }
        }

        /// <summary>
        /// Height of last rendered area in the RenderedAreas array.
        /// </summary>
        public Unit HeightUnit
        {
            get { return RenderedArea.Height; }
        }

        /// <summary>
        /// Returns the latest area on the latest page occupied by the render object. 
        /// </summary>
        public UnitRectangle RenderedArea
        {
            get { return _renderedAreas[_renderedAreas.Length - 1]; }
        }

        /// <summary>
        /// Returns all areas occupied by the render object.
        /// </summary>
        public UnitRectangle[] RenderedAreas
        {
            get { return _renderedAreas; }
        }

        /// <summary>
        /// Indicates whether new page started as a result of rendering
        /// </summary>
        public bool NewPage
        {
            get { return _newPage; }
        }

        /// <summary>
        /// Indicates whether new column started as a result of rendering
        /// </summary>
        public bool NewColumn
        {
            get { return _newColumn; }
        }

        #endregion
    }

    public struct UnitRectangle
    {
        private Unit _x;
        private Unit _y;
        private Unit _width;
        private Unit _height;

        #region Public

        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Width = {2}; Height = {3}", _x, _y, _width, _height);
        }

        #endregion

        #region Public properties

        public Unit X
        {
            get { return _x; }
            set { _x = value; }
        }

        public Unit Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Unit Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Unit Height
        {
            get { return _height; }
            set { _height = value; }
        }

        #endregion
    }
}
