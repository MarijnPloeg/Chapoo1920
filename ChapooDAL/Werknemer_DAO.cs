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
    public class Werknemer_DAO : Base
    {
        public List<Werknemer> DB_Get_All_Werknemers()
        {
            string query = "SELECT Werknemer_ID, Werknemer_Naam, Werknemer_Functie, Werknemer_WW FROM Werknemers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Werknemer> ReadTables(DataTable dataTable)
        {
            List<Werknemer> werknemers = new List<Werknemer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Werknemer werknemer = new Werknemer()
                {
                    Werknemer_ID = (int)dr["Werknemer_ID"],
                    Naam = (string)dr["Werknemer_Naam"],
                    Functie = (Functie)dr["Werknemer_Functie"],
                    Wachtwoord = (string)dr["Werknemer_WW"]
                };
                werknemers.Add(werknemer);
            }
            return werknemers;
        }

        public bool TryLogin(string gebruikersNaam, string wachtwoord)
        {
            string query = "SELECT Werknemer_Naam, Werknemer_WW FROM Werknemers WHERE Werknemer_Naam = @gebruikersNaam AND Werknemer_WW = @wachtwoord";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@gebruikersNaam", SqlDbType.NChar, 50) { Value = gebruikersNaam },
                new SqlParameter("@wachtwoord", SqlDbType.NChar, 50){Value = wachtwoord},
            };

            DataTable dt = ExecuteSelectQuery(query, sqlParameters);
            foreach (DataRow dr in dt.Rows)
            {
                if ((string)dr["Werknemer_Naam"] == "" && (string)dr["Werknemer_WW"] == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
