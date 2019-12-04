using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Table_Service
    {
        Table_DAO table_db = new Table_DAO();

        public List<Table> GetTables()
        {
            try
            {
                List<Table> tables = new List<Table>();

                for (int i = 1; i <= 10; i++)
                {
                    tables.Add(table_db.Db_Get_Table(i));
                }

                return tables;
            }
            catch (Exception)
            {
                //connection to database failed, adding fake tables
                List<Table> tables = new List<Table>();
                Table a = new Table();
                a.Capacity = 4;
                a.InUse = false;
                a.TableID = 1;

                Table b = new Table();
                b.Capacity = 6;
                b.InUse = false;
                b.TableID = 2;

                tables.Add(a);
                tables.Add(b);

                return tables;
            }
        }
    }
}
