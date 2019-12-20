using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;


namespace ChapooDAL
{
    public class Menu_Items_Dao : Base
    {
        public List<Menu_Item> DB_Get_All_MenuItems()
        {
            string query = "SELECT Menu_ID, Naam, Prijs, Voorraad, Catagorie_ID FROM [Menu_Items]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu_Item> ReadTables(DataTable dataTable)
        {
            List<Menu_Item> menu_items = new List<Menu_Item>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Menu_Item menu_Item = new Menu_Item()
                {
                    Menu_ID = (int)dr["Menu_ID"],
                    Naam = (string)dr["Naam"],
                    Prijs = (double)dr["Prijs"],
                    Voorraad = (int)dr["Voorraad"],
                    Categorie_ID = (int)dr["Catagorie_ID"]
                };
                menu_items.Add(menu_Item);
            }
            return menu_items;
        }

        //public void ZoekMenuItems(string sql)
        //{
        //    OleDbCommand cmd;
        //    OleDbDataAdapter adapter;
        //    DataTable dt = new DataTable();

        //    string query = $"SELECT * FROM [Menu_Items] WHERE Naam LIKE '{0}%'" + sql;
        //    cmd = new OleDbCommand(sql);
        //    cmd = new OleDbCommand(sql);
        //    try
        //    {

        //        adapter = new OleDbDataAdapter(cmd);
        //        adapter.Fill(dt);

        //        foreach (DataRow row in dt.Rows)
        //        {
        //            vul_Listview(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
        //        }
        //        dt.Rows.Clear();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

    }
}
