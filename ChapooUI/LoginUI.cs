using ChapooLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapoo1819
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            ChapooLogic.Transaction_Service transactionService = new ChapooLogic.Transaction_Service();

            // Creates a new transaction
            transactionService.RegisterTransaction(int.Parse(txtTotalPrice.Text), txtComment.Text, int.Parse(txtTable.Text), int.Parse(txtEmployeeNumber.Text), int.Parse(txtTotalPaid.Text), DateTime.Now);
            
            // Notify user of successful transaction
            MessageBox.Show("Transaction completed!");

            // Reset the register
            txtTotalPrice.Clear();
            txtComment.Clear();
            txtTable.Clear();
            txtEmployeeNumber.Clear();
            txtTotalPaid.Clear();
        }
    }
}
