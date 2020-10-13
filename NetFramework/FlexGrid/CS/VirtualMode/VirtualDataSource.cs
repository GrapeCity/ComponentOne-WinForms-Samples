using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace VirtualMode
{
    public class VirtualDataSource
    {
        //--------------------------------------------------------------------------------
        #region ** fields

        static int _rowsPerPage;
        DataConnector _dataConnector;
        DataPage[] _cachePages;

        #endregion

        //--------------------------------------------------------------------------------
        #region ** ctors

        public VirtualDataSource(string connectionString, string tableName, int rowsPerPage)
        {
            VirtualDataSource._rowsPerPage = rowsPerPage;
            _dataConnector = new DataConnector(connectionString, tableName);
            LoadFirstTwoPages();
        }

        #endregion

        //--------------------------------------------------------------------------------
        #region ** object model

        // Gets the value at the specified row and column indices
        public object GetValue(int rowIndex, int columnIndex)
        {
            // look for value in cache
            int page = GetCachePageIndex(rowIndex);
            if (page < 0)
            {
                // not found in cache, load it now
                LoadValueIntoCache(rowIndex, columnIndex);
                page = GetCachePageIndex(rowIndex);
                System.Diagnostics.Debug.Assert(page >= 0);
            }

            // get the value from the cache
            return _cachePages[page]._table.Rows[rowIndex % _rowsPerPage][columnIndex];
        }

        // Sets the value at the specified row and column indices
        public void SetValue(int rowIndex, int columnIndex, object value)
        {
            // look for value in cache
            int page = GetCachePageIndex(rowIndex);
            if (page < 0)
            {
                // not found in cache, load it now
                LoadValueIntoCache(rowIndex, columnIndex);
                page = GetCachePageIndex(rowIndex);
                System.Diagnostics.Debug.Assert(page >= 0);
            }

            // set the value in the cache
            var table = _cachePages[page]._table;
            table.Rows[rowIndex % _rowsPerPage][columnIndex] = value;

            // write changes back to the database
            _dataConnector.SaveChanges(table);
        }

        // get the collection of columns available in the data source
        public DataColumnCollection Columns
        {
            get { return _dataConnector.Columns; }
        }

        // gets the total number of rows available in the data source
        public int TotalRowCount
        {
            get { return _dataConnector.TotalRowCount; }
        }

        #endregion

        //--------------------------------------------------------------------------------
        #region ** implementation

        // Loads the first two pages of data
        void LoadFirstTwoPages()
        {
            _cachePages = new DataPage[]
            {
                new DataPage(_dataConnector.GetData(DataPage.MapToLowerBoundary(0), _rowsPerPage), 0), 
                new DataPage(_dataConnector.GetData(DataPage.MapToLowerBoundary(_rowsPerPage), _rowsPerPage), _rowsPerPage)
            };
        }

        // Gets the index of the cache page that contains a given row
        int GetCachePageIndex(int rowIndex)
        {
            for (var pageIndex = 0; pageIndex < _cachePages.Length; pageIndex++)
            {
                var page = _cachePages[pageIndex];
                if (rowIndex >= page.LowestIndex && 
                    rowIndex <= page.HighestIndex)
                {
                    return pageIndex;
                }
            }
            return -1;
        }

        // Loads data into the cache
        void LoadValueIntoCache(int rowIndex, int columnIndex)
        {
            // Retrieve a page worth of data containing the requested value.
            var table = _dataConnector.GetData(DataPage.MapToLowerBoundary(rowIndex), _rowsPerPage);

            // Replace the cached page furthest from the requested cell
            // with a new page containing the newly retrieved data.
            var page = GetIndexToUnusedPage(rowIndex);
            _cachePages[page] = new DataPage(table, rowIndex);
        }

        // Returns the index of the cached page most distant from the given index
        // and therefore least likely to be reused.
        int GetIndexToUnusedPage(int rowIndex)
        {
            if (rowIndex > _cachePages[0].HighestIndex && rowIndex > _cachePages[1].HighestIndex)
            {
                int offsetFromPage0 = rowIndex - _cachePages[0].HighestIndex;
                int offsetFromPage1 = rowIndex - _cachePages[1].HighestIndex;
                return offsetFromPage0 < offsetFromPage1 ? 1 : 0;
            }
            else
            {
                int offsetFromPage0 = _cachePages[0].LowestIndex - rowIndex;
                int offsetFromPage1 = _cachePages[1].LowestIndex - rowIndex;
                return offsetFromPage0 < offsetFromPage1 ? 1: 0;
            }

        }

        // Represents one page of data.  
        struct DataPage
        {
            public DataTable _table;
            int _lowestIndexValue;
            int _highestIndexValue;

            public DataPage(DataTable table, int rowIndex)
            {
                _table = table;
                _lowestIndexValue = MapToLowerBoundary(rowIndex);
                _highestIndexValue = MapToUpperBoundary(rowIndex);
                System.Diagnostics.Debug.Assert(_lowestIndexValue >= 0);
                System.Diagnostics.Debug.Assert(_highestIndexValue >= 0);
            }
            public int LowestIndex
            {
                get { return _lowestIndexValue; }
            }
            public int HighestIndex
            {
                get { return _highestIndexValue; }
            }

            // Gets the lowest index of a page containing the given index.
            public static int MapToLowerBoundary(int rowIndex)
            {
                return (rowIndex / _rowsPerPage) * _rowsPerPage;
            }

            // Gets the highest index of a page containing the given index.
            private static int MapToUpperBoundary(int rowIndex)
            {
                return MapToLowerBoundary(rowIndex) + _rowsPerPage - 1;
            }
        }

        #endregion
    }
}
