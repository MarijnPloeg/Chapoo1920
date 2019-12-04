using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ChapooDAL
{
    public abstract class Base
    {
        private SqlDataAdapter adapter;
        private SqlConnection conn;

        public Base()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["chapoo1920f01"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        protected SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        private void CloseConnection()
        {
            conn.Close();
        }
    }
}
