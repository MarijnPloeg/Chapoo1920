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
    public class Werknemer_Service
    {
        Werknemer_DAO werknemer_db = new Werknemer_DAO();
        public List<Werknemer> Get_Werknemers()
        {
            try
            {
                List<Werknemer> werknemers = werknemer_db.DB_Get_All_Werknemers();
                return werknemers;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                throw new Exception(exception.Message);
            }

        }
    }
}
