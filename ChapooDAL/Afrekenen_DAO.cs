using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;

namespace ChapooDAL
{
    public class Afrekenen_DAO : Base
    {
        public List<Afrekenen> DB_Get_All_Orders()
        {
            string query = "SELECT Hoeveelheid, Opmerking, MenuItem_ID  FROM Order_Items";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Afrekenen> ReadTables(DataTable dataTable)
        {
            List<Afrekenen> order_items = new List<Afrekenen>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Afrekenen afrekenen = new Afrekenen()
                {
                    selectie_hoeveelheid = (int)dr["Hoeveelheid"],
                    selectie_Opmerking = (string)dr["Opmerking"],
                    menuItemID = (int)dr["MenuItem_ID"],
                    TotaalPrijs = (int)dr["Prijs"],
                    fooi = (int)dr["Fooi"]
                };
                order_items.Add(afrekenen);
            }
            return order_items;
        }
    }
}
