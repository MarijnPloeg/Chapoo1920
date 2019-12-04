using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel

namespace ChapooDAL
{
    public class Betaalwijze_DAO : Base
    {
        public List<Betaalwijze> DB_Get_All_Betaalwijze()
        {
            string query = "SELECT Betaal_ID, Order_ID, Betaal_Methode, TotaalPrijs, Fooi FROM Betaalwijze";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Betaalwijze> ReadTables(DataTable dataTable)
        {
            List<Betaalwijze> betaalwijzes = new List<Betaalwijze>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Betaalwijze  betaalwijze = new Betaalwijze()
                {
                    Betaal_ID = (int)dr["Betaal_ID"],
                    Order_ID = (int)dr["Order_ID"],
                    BetaalMethode = (BetaalMethode)dr["Betaal_Methode"],
                    TotaalPrijs = (int)dr["Prijs"],
                    Fooi = (int)dr["Fooi"]
                };
                betaalwijzes.Add(betaalwijze);
            }
            return betaalwijzes;
        }
    }
}
