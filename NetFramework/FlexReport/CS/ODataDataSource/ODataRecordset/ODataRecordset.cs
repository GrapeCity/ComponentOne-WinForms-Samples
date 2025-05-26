using System;
using System.Data;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Data.OData;
using Microsoft.Data.Edm;
using System.Data.Services.Client;

using C1.Report;

namespace ODataRecordset
{
    public class ODataRecordset : IC1FlexReportExternalRecordset
    {
        private static Dictionary<string, Type> s_PrimitiveTypes = new Dictionary<string, Type>();
        private Uri _serviceUri;
        private string _entitySetName;

        private IEdmModel _model;

        static ODataRecordset()
        {
            s_PrimitiveTypes.Add("Edm.Boolean", typeof(bool));
            s_PrimitiveTypes.Add("Edm.Byte", typeof(byte));
            s_PrimitiveTypes.Add("Edm.DateTime", typeof(DateTime));
            s_PrimitiveTypes.Add("Edm.Decimal", typeof(decimal));
            s_PrimitiveTypes.Add("Edm.Double", typeof(double));
            s_PrimitiveTypes.Add("Edm.Single", typeof(Single));
            s_PrimitiveTypes.Add("Edm.Guid", typeof(Guid));
            s_PrimitiveTypes.Add("Edm.Int16", typeof(Int16));
            s_PrimitiveTypes.Add("Edm.Int32", typeof(Int32));
            s_PrimitiveTypes.Add("Edm.Int64", typeof(Int64));
            s_PrimitiveTypes.Add("Edm.SByte", typeof(SByte));
            s_PrimitiveTypes.Add("Edm.String", typeof(String));
        }

        #region Public properties
        /// <summary>
        /// Gets or sets URI to the OData service.
        /// </summary>
        public Uri ServiceUri
        {
            get { return _serviceUri; }
            set
            {
                if (_serviceUri == value)
                    return;
                _serviceUri = value;
                _model = null;
            }
        }

        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        public string EntitySetName
        {
            get { return _entitySetName; }
            set { _entitySetName = value; }
        }

        public string Caption
        {
            get { return "OData Connection"; }
        }

        public string Params
        {
            get
            {
                return _serviceUri == null ? string.Empty : _serviceUri.ToString() + "\n" + _entitySetName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    ServiceUri = null;
                    EntitySetName = string.Empty;
                }
                else
                {
                    int p = value.IndexOf("\n");
                    if (p <= 0)
                    {
                        ServiceUri = null;
                        EntitySetName = string.Empty;
                    }
                    else
                    {
                        Uri.TryCreate(value.Substring(0, p), UriKind.Absolute, out _serviceUri);
                        EntitySetName = value.Substring(p + 1);
                    }
                }
            }
        }
        #endregion

        #region Public
        /// <summary>
        /// Returns service metadata.
        /// </summary>
        /// <returns></returns>
        public IEdmModel GetModel()
        {
            if (_model != null)
                return _model;

            Uri metadataUri = new Uri(_serviceUri, "$metadata");
            WebRequest request = WebRequest.Create(metadataUri);
            using (WebResponse response = request.GetResponse())
            {
                HttpWebResponseMessage message = new HttpWebResponseMessage((HttpWebResponse)response);
                using (ODataMessageReader odataReader = new ODataMessageReader(message))
                {
                    return odataReader.ReadMetadataDocument();
                }
            }
        }

        /// <summary>
        /// Returns list of the entity sets defined for the OData service.
        /// </summary>
        /// <returns></returns>
        public List<IEdmEntitySet> GetEntitySets()
        {
            IEdmModel model = GetModel();
            List<IEdmEntitySet> result = new List<IEdmEntitySet>();
            var containers = model.SchemaElements.OfType<IEdmEntityContainer>();
            foreach (var container in containers)
            {
                result.AddRange(container.Elements.OfType<IEdmEntitySet>());
            }
            return result;
        }

        /// <summary>
        /// Returns the enity set data.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable GetEntitySetData()
        {
            var entitySets = GetEntitySets();
            var entitySet = entitySets.FirstOrDefault((item_) => { return string.Compare(item_.Name, _entitySetName, true) == 0; });
            if (entitySet == null)
                throw new ArgumentException();

            //
            Uri entitySetUri = new Uri(_serviceUri, _entitySetName);
            WebRequest request = WebRequest.Create(entitySetUri);
            using (WebResponse response = request.GetResponse())
            {
                HttpWebResponseMessage message = new HttpWebResponseMessage((HttpWebResponse)response);
                using (ODataMessageReader reader = new ODataMessageReader(message))
                {
                    var feedReader = reader.CreateODataFeedReader();

                    // initialize DataTable
                    DataTable result = new DataTable();
                    foreach (var property in entitySet.ElementType.Properties())
                    {
                        if (property.Type.Definition.TypeKind != EdmTypeKind.Primitive)
                            continue;

                        Type type;
                        if (!s_PrimitiveTypes.TryGetValue(property.Type.Definition.ToString(), out type))
                            type = typeof(string);
                        result.Columns.Add(property.Name, type);
                    }

                    // go over reader and add rows to the DataTable
                    object[] values = new object[result.Columns.Count];
                    result.BeginLoadData();
                    while (feedReader.Read())
                    {
                        switch (feedReader.State)
                        {
                            case ODataReaderState.EntryEnd:
                                ODataEntry entry = (ODataEntry)feedReader.Item;
                                foreach (var property in entry.Properties)
                                {
                                    int columnIndex = result.Columns.IndexOf(property.Name);
                                    if (columnIndex >= 0)
                                        values[columnIndex] = property.Value;
                                }
                                result.Rows.Add(values);
                                break;
                        }
                    }
                    result.EndLoadData();
                    return result;
                }
            }
        }

        public void EditParams()
        {
            using (ODataRecordsetForm f = new ODataRecordsetForm())
                f.Edit(this);
        }

        public IC1FlexReportRecordset GetRecordset()
        {
            return new EntitySet(GetEntitySetData());
        }
        #endregion

        #region Nested types
        private class EntitySet : IC1FlexReportRecordset
        {
            private int _recNo;
            private DataTable _dataTable;

            public EntitySet(DataTable dataTable)
            {
                _dataTable = dataTable;
            }

            public int Count
            {
                get { return _dataTable.Rows.Count; }
            }

            public bool BOF()
            {
                throw new NotImplementedException();
            }

            public bool EOF()
            {
                return _recNo >= _dataTable.Rows.Count;
            }

            public int GetBookmark()
            {
                return _recNo;
            }

            public string[] GetFieldNames()
            {
                string[] result = new string[_dataTable.Columns.Count];
                for (int i = 0; i < result.Length; i++)
                    result[i] = _dataTable.Columns[i].ColumnName;
                return result;
            }

            public Type[] GetFieldTypes()
            {
                Type[] result = new Type[_dataTable.Columns.Count];
                for (int i = 0; i < result.Length; i++)
                    result[i] = _dataTable.Columns[i].DataType;
                return result;
            }

            public object GetFieldValue(int fieldIndex)
            {
                if (_recNo < 0 || _recNo >= _dataTable.Rows.Count || fieldIndex >= _dataTable.Columns.Count || fieldIndex < 0)
                    return null;
                return _dataTable.Rows[_recNo][fieldIndex];
            }

            public void MoveFirst()
            {
                _recNo = 0;
            }

            public void MoveLast()
            {
                _recNo = _dataTable.Rows.Count - 1;
            }

            public void MoveNext()
            {
                _recNo++;
            }

            public void MovePrevious()
            {
                _recNo--;
            }

            public void SetBookmark(int bkmk)
            {
                _recNo = bkmk;
            }
        }
        #endregion
    }
}