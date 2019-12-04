using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooLogic
{
    public class KitchenBar_Service
    {
        Order_DAO order_db = new Order_DAO();

        public List<Order> Db_Get_OpenKitchenOrders()
        {
            return order_db.Db_Get_OpenKitchenOrders();
        }
    }
}
