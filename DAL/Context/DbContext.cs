using DAL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Context
{
    public class BaseballContext : IDisposable
    {
        private MySqlConnection cn;
        public BaseballContext()
        {
            
        }

        public MySqlConnection GetConnection(string database)
        {
            string connectionString = "";
            if (database == "Test")
            {
                connectionString = "Server=10.3.10.10;Database=operationsdb;Uid=root;Pwd=orinet05;Convert Zero Datetime=true;";
                
            }
            if (database == "Production")
            {
                connectionString = "Server=10.3.10.1;Database=operationsdb;Uid=readonly;Pwd=wasabionasmallplate;Convert Zero Datetime=true;";

            }
            this.cn = new MySqlConnection(connectionString);
            try
            {
                cn.Open();
            }
            catch (MySqlException ex)
            {

                var exception = ex;
                cn.Close();
            }
            
            return cn;
        }

        public void Dispose()
        {
            this.cn.Dispose();
        }
    }
}
