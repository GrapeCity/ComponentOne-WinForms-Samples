using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C1.Win.FlexChart.Designer.Data
{
    class DataEngine
    {
        IEnumerable _originalDataSource;
        IList<object> _dataSource = new List<object>();
        List<Category> _categories = new List<Category>();
        List<Measure> _measures = new List<Measure>();

        public List<Measure> Measures
        {
            get { return _measures; }
        }

        public List<Category> Categories
        {
            get { return _categories; }
        }

        public IList<object> DataSource
        {
            get { return _dataSource; }
        }

        public Field GetField(string name)
        {
            foreach (var f in Categories)
            {
                if (f.Name == name)
                    return f;
            }

            foreach (var f in Measures)
            {
                if (f.Name == name)
                    return f;
            }

            return null;
        }

        void Clear()
        {
            _categories.Clear();
            _measures.Clear();
            _dataSource.Clear();
        }

        public void Load(IEnumerable dataSource)
        {
            Clear();
            _originalDataSource = dataSource;

            foreach (var item in dataSource)
            {
                if (item != null)
                {
/*                    if (item is JObject)
                    {
                        var jobj = (JObject)item;
                        var props = jobj.Properties();
                        var obj = new ExpandoObject() as IDictionary<String, Object>;

                        foreach (var prop in props)
                        {
                            var val = prop.Value as JValue;
                            if (val != null)
                            {
                                var type = val.Value.GetType();

                                if (IsNumeric(type))
                                {
                                    Measures.Add(new Measure() { Name = prop.Name, Type = MeasureType.Number });
                                    obj.Add(prop.Name, Convert.ToDouble(val));
                                }
                                else if (IsDateTime(type))
                                {
                                    Measures.Add(new Measure() { Name = prop.Name, Type = MeasureType.Date });
                                    obj.Add(prop.Name, Convert.ToDateTime(val));
                                }
                                else if (IsCategory(type))
                                {
                                    Categories.Add(new Category() { Name = prop.Name });
                                    obj.Add(prop.Name, val != null ? val.ToString() : null);
                                }
                            }
                        }
                    }
                    else*/ if (item is ExpandoObject)
                    {
                        var dict = (IDictionary<String, Object>)item;
                        foreach (var key in dict.Keys)
                            AddField(key, dict[key].GetType());
                    }
                    else
                    {
                        var props = item.GetType().GetProperties();
                        foreach (var prop in props)
                            AddField(prop.Name, prop.PropertyType);
                    }

                    break;
                }
            }

            foreach (var item in dataSource)
            {
                if (item != null)
                {
                    /*if (item is JObject)
                    {
                        var jobj = (JObject)item;
                        var props = jobj.Properties();
                        var obj = new ExpandoObject() as IDictionary<String, Object>;

                        foreach (var prop in props)
                        {
                            var val = prop.Value as JValue;
                            if (val != null)
                            {
                                var type = val.Value.GetType();

                                if (IsNumeric(type))
                                    obj.Add(prop.Name, Convert.ToDouble(val));
                                else if (IsDateTime(type))
                                    obj.Add(prop.Name, Convert.ToDateTime(val));
                                else if (IsCategory(type))
                                    obj.Add(prop.Name, val != null ? val.ToString() : null);
                            }
                        }
                        _dataSource.Add(obj);
                    }
                    else*/ //if (item is ExpandoObject)
                    {
                        _dataSource.Add(item);
                    }
/*                    else
                    {
                        var obj = new ExpandoObject() as IDictionary<String, Object>;
                        var props = item.GetType().GetProperties();
                        foreach (var prop in props)
                        {
                            var type = prop.PropertyType;
                            var val = prop.GetValue(item);
                            if (IsNumeric(type))
                                obj.Add(prop.Name, Convert.ToDouble(val));
                            else if (IsDateTime(type))
                                obj.Add(prop.Name, Convert.ToDateTime(val));
                            else if (IsCategory(type))
                                obj.Add(prop.Name, val != null ? val.ToString() : null);
                        }
                        _dataSource.Add(obj);
                    }*/
                }
            }
        }

        void AddField(string name, Type type)
        {
            if (IsNumeric(type))
                Measures.Add(new Measure() { Name = name, Type = MeasureType.Number });
            else if (IsDateTime(type))
                Measures.Add(new Measure() { Name = name, Type = MeasureType.Date });
            else if (IsCategory(type))
                Categories.Add(new Category() { Name = name });
        }

        bool IsNumeric(Type type)
        {
            return type == typeof(double) || type == typeof(float) || type == typeof(int) || type == typeof(Int64) || type == typeof(Int16) || type == typeof(byte);
        }

        bool IsDateTime(Type type)
        {
            return type == typeof(DateTime);
        }

        bool IsCategory(Type type)
        {
            return type == typeof(string);
        }
    }
}
