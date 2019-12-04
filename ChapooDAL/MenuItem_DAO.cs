using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ChapooDAL {
    public class MenuItem_DAO : Base {
        public List<MenuProduct> Db_Get_Drink_MenuItems(string category) {
            List<MenuProduct> menuProducts = new List<MenuProduct>();

            string query = "SELECT m.MenuItem_ID, m.Name, m.Description, m.stock FROM MenuItem m WHERE Category = @Category;";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Category", category);

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            foreach (DataRow dr in dataTable.Rows) {
                MenuProduct product = new MenuProduct();

                product.MenuItemCode = (int)(dr["MenuItem_ID"]);
                product.Name = (String)(dr["Name"]);
                if (dr.IsNull("Description")) {
                    product.Description = " ";
                } else {
                    product.Description = (String)(dr["Description"]);
                }
                product.Stock = (int)(dr["stock"]);

                menuProducts.Add(product);
            }

            return menuProducts;
        }

        public List<MenuProduct> Db_Get_Food_MenuItems() {
            List<MenuProduct> menuProducts = new List<MenuProduct>();

            string query = "SELECT m.MenuItem_ID, m.Name, m.Description, m.stock, m.Category FROM MenuItem m WHERE Category NOT IN ('Alcoholic', 'nonAlcoholic');";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            foreach (DataRow dr in dataTable.Rows) {
                MenuProduct product = new MenuProduct();

                product.MenuItemCode = (int)(dr["MenuItem_ID"]);
                product.Name = (String)(dr["Name"]);
                product.Description = (String)(dr["Description"]);
                product.Stock = (int)(dr["stock"]);
                product.Category = (String)(dr["Category"]);

                menuProducts.Add(product);
            }

            return menuProducts;
        }
    }
}
