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
    public class Menu_Items_Dao : Base
    {
        public List<Menu_Items> DB_Get_All_MenuItems()
        {
            string query = "SELECT Menu_ID, Naam, Prijs, Voorraad, Catogorie_ID FROM Menu_Items";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu_Items> ReadTables(DataTable dataTable)
        {
            List<Menu_Items> menu_items = new List<Menu_Items>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menu_Items menu_Item = new Menu_Items()
                {
                    Menu_ID = (int)dr["Menu_ID"],
                    Naam = (string)dr["Naam"].ToString(),
                    Prijs = (int)dr["Prijs"],
                    Voorraad = (int)dr["Voorraad"],
                    Categorie_ID = (int)dr["Categorie_ID"]

                };
                menu_items.Add(menu_Item);
            }
            return menu_items;
        }
    }
}
