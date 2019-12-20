using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using ChapooDAL;
using System.Windows.Forms;

namespace ChapooLogic
{
    public class Menu_Categorie_Service
    {
        Menu_Categorie_DAO menu_categorie_db = new Menu_Categorie_DAO();
        public List<Menu_Categorie> GetMenu_Categories()
        {
            try
            {
                List<Menu_Categorie> menu_categorien = menu_categorie_db.DB_Get_All_MenuCategorie();
                return menu_categorien;
            }
            catch (Exception)
            {
                MessageBox.Show("Kan geen contact maken met de database");
                throw new Exception("Kan geen contact maken met de database");
            }

        }
    }
}
