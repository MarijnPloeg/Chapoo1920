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
    public class Menu_Categorie_DAO : Base
    {
        public List<Menu_Categorie> DB_Get_All_MenuCategorie()
        {
            string query = "SELECT Betaal_ID, Order_ID, Betaal_Methode, TotaalPrijs, Fooi FROM Betaalwijze";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu_Categorie> ReadTables(DataTable dataTable)
        {
            List<Menu_Categorie> menu_Categories = new List<Menu_Categorie>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menu_Categorie menu_Categorie = new Menu_Categorie()
                {
                    Categorie_ID = (int)dr["Categorie_ID"],
                    BTW = (int)dr["BTW"],
                    Menukaart_ID = (int)dr["MenuKaart_ID"],
                    Naam = (string)dr["Naam"].ToString()
                };
                menu_Categories.Add(menu_Categorie);
            }
            return menu_Categories;
        }
    }
}
