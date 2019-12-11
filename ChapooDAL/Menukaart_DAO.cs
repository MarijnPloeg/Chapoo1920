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
    public class Menukaart_DAO : Base
    {
        public List<Menukaart> DB_Get_All_Menukaart()
        {
            string query = "SELECT Menukaart_ID, Naam, Tijd FROM Menu_Kaart";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menukaart> ReadTables(DataTable dataTable)
        {
            List<Menukaart> menukaarten = new List<Menukaart>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menukaart menukaart = new Menukaart()
                {
                    Menukaart_ID = (int)dr["Menukaart_ID"],
                    Naam = (string)dr["Naam"].ToString(),
                    Tijd = (DateTime)dr["Tijd"]

                };
                menu_items.Add(menu_Item);
            }
            return menu_items;
        }
    }
}
