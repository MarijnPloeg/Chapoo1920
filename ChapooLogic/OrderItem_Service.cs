using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace ChapooLogic
{
    public class OrderItem_Service
    {
        OrderItem_DAO orderitem_db = new OrderItem_DAO();

        /// Changes the status of an orderitem
        public void EditOrderItemStatus(bool newStatus, int orderitemID)
        {
            try
            {
                orderitem_db.Db_Edit_OrderItemStatus(newStatus, orderitemID);
            }
            catch (Exception e)
            {
                StreamWriter writer = new StreamWriter("errorLog");
                writer.Write(e);
                writer.Close();

                MessageBox.Show("Editing the status of an orderitem failed.", "Updating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
