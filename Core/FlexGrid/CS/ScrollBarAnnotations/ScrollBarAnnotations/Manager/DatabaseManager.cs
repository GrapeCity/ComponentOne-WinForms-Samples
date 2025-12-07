// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using System.Data;
using System.Data.OleDb;

namespace ScrollBarAnnotations.Manager
{
    internal static class DatabaseManager
    {
        /// <summary>
        /// Loads all product data from the Access database into the provided <see cref="DataTable"/>.
        /// </summary>
        internal static void LoadProductData(DataTable dt)
        {
            string conn = GetConnectionString();
            OleDbDataAdapter da = new("select * from products", conn);
            da.Fill(dt);
        }

        /// <summary>
        /// Returns the database connection string for the sample Northwind database.
        /// </summary>
        /// <returns>A formatted connection string pointing to the sample MDB file.</returns>
        internal static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
