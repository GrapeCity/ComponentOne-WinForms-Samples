using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotations
{
    /*
     * NOTES: 
     * 
     * 1) To use the FlexGrid's DataAnnotation features, the project must use .NET 4.0
     *    and it must have a reference to the System.ComponentModel.DataAnnotations.dll 
     *    assembly.
     *    
     * 2) The System.ComponentModel.DataAnnotations.dll used must be version 4.0.0.0 or higher
     *    this is the same version used by WPF, Silverlight, and ASP.NET.
     */
    class Data
    {
        static string[] _firstNames = new string[]
        {
            "Arnold",
            "Dave",
            "Sunny",
            "Gary",
            "Todd",
            "Kevin",
            "Gomez",
            "Chris",
            "Paul",
            "George",
            "John",
            "James",
            "Robert",
            "Jimmy",
            "Ronnie",
            "Tyler"
        };

        static string[] _lastNames = new string[]
        {
            "Smith",
            "Anderson",
            "Acker",
            "Fox",
            "Dooley",
            "Chen",
            "Andrews",
            "Garrett",
            "Hill",
            "Parker",
            "Osborne",
            "Stone",
            "Marlow"
        };

        // auto-generated CustomerName column header will show "Customer".
        // (even though the property name is "CustomerName")
        // This column also requires non-empty string with minimal length at least 2 symbols.
        [Display(Name = "Customer")]
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 2)]
        public string CustomerName { get; set; }

        // auto-generated CustomerID column will be invisible.
        [Display(AutoGenerateField = false)]
        public int CustomerID { get; set; }

        // auto-generated "Frequency" column will show values formatted as percentages
        // and will not allow editing.
        [DisplayFormat(DataFormatString = "0%")]
        [Editable(false)]
        public double Frequency { get; set; }

        // auto-generated "Age" column will allow values in the predefined
        // range.
        [Required]
        [Range(10, 90)]
        public int Age { get; set; }

        // create some sample data
        public static BindingList<Data> GetSampleData(int cnt)
        {
            var list = new BindingList<Data>();
            var rnd = new Random();
            for (int i = 0; i < cnt; i++)
            {
                var item = new Data();
                item.CustomerName = _firstNames[rnd.Next(0, _firstNames.Length)] + " " + _lastNames[rnd.Next(0, _lastNames.Length)];
                item.CustomerID = i;
                item.Frequency = rnd.NextDouble();
                item.Age = rnd.Next(10, 91);
                list.Add(item);
            }
            return list;
        }
    }
}
