﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DashboardLayoutDemo.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DashboardLayoutDemo.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Customers.
        /// </summary>
        internal static string Customers {
            get {
                return ResourceManager.GetString("Customers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT DISTINCT 
        ///    Round( ([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount) , 2) AS [Sales],
        ///    Orders.OrderDate AS [OrderDate],
        ///    Products.ProductName AS [Product],
        ///    Customers.CompanyName AS [Customer],
        ///    Customers.Country AS [Country],
        ///    Employees.FirstName + &apos; &apos; + Employees.LastName AS [Employee],
        ///    Categories.CategoryName AS [Category]
        ///FROM 
        ///    (Employees INNER JOIN
        ///    (Customers INNER JOIN
        ///    (Orders INNER JOIN
        ///    ([Order Details] INNER JOIN
        ///    (Pro [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Sales {
            get {
                return ResourceManager.GetString("Sales", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT DISTINCT 
        ///    Round( Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS [Sales],
        ///    Customers.Country AS [Country]
        ///FROM 
        ///    (Employees INNER JOIN
        ///    (Customers INNER JOIN
        ///    (Orders INNER JOIN
        ///    ([Order Details] INNER JOIN
        ///    (Products INNER JOIN Categories 
        ///    ON Categories.CategoryID = Products.CategoryID)
        ///    ON Products.ProductID = [Order Details].ProductID)
        ///    ON Orders.OrderID = [Order Details].OrderID)
        ///    ON Customers.CustomerID = Orders.C [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SalesByCountry {
            get {
                return ResourceManager.GetString("SalesByCountry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT DISTINCT 
        ///    ROUND( Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS [Sales],
        ///    Employees.FirstName + &apos; &apos; + Employees.LastName AS [Employee]
        ///FROM 
        ///    (Employees INNER JOIN
        ///    (Customers INNER JOIN
        ///    (Orders INNER JOIN
        ///    ([Order Details] INNER JOIN
        ///    (Products INNER JOIN Categories 
        ///    ON Categories.CategoryID = Products.CategoryID)
        ///    ON Products.ProductID = [Order Details].ProductID)
        ///    ON Orders.OrderID = [Order Details].OrderID)
        ///    ON C [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SalesByEmployee {
            get {
                return ResourceManager.GetString("SalesByEmployee", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT DISTINCT 
        ///    ROUND(Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS [Sales]
        ///FROM 
        ///    [Order Details].
        /// </summary>
        internal static string TotalSales {
            get {
                return ResourceManager.GetString("TotalSales", resourceCulture);
            }
        }
    }
}
