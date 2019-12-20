using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    class Afrekenen_Service
    {
        Afrekenen_DAO afrekenen_db = new Afrekenen_DAO();

        public List<Afrekenen> GetOrders()
        {
            try
            {
                List<Afrekenen> lijstMetOrders = afrekenen_db.DB_Get_All_Orders();
                return lijstMetOrders;
            }
            catch (Exception)
            {
                throw new Exception("Kan geen contact maken met de database");
            }

        }
    }
}
