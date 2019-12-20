using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using ChapooDAL;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChapooLogic
{
    public class Menu_Items_Service
    {
        Menu_Items_Dao menu_items_db = new Menu_Items_Dao();
        public List<Menu_Item> Get_Menu_Item()
        {
            try
            {
                List<Menu_Item> menu_items = menu_items_db.DB_Get_All_MenuItems();
                return menu_items;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                throw new Exception(exception.Message);
            }
        }
    }
}
