using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Tafel_Service
    {
        Tafel_DAO tafel_db = new Tafel_DAO();
        public List<Tafel> Get_Tafels()
        {
            try
            {
                List<Tafel> tafels = tafel_db.DB_Get_All_Tafels();
                return tafels;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                throw new Exception(exception.Message);
            }
        }
    }
}
