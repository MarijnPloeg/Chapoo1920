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
    public class Tafel_DAO : Base
    {
        public List<Tafel> DB_Get_All_Tafels()
        {
            string query = "SELECT Tafel_ID, Status, Aantal_Personen FROM [Tafel]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Tafel> ReadTables(DataTable dataTable)
        {
            List<Tafel> tafels = new List<Tafel>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel()
                {
                    Tafel_ID = (int)dr["Tafel_ID"],
                    Tafel_Status = (Tafel_Status)dr["Status"],
                    Aantal_Personen = (int)dr["Aantal_Personen"]
                };
                tafels.Add(tafel);
            }
            return tafels;
        }
    }
}
