using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace ChapooUI
{
    public partial class KeukenOverzicht : Form
    {
        public KeukenOverzicht()
        {
            InitializeComponent();
        }

        private void KeukenOverzicht_Load(object sender, EventArgs e)
        {
            pnl_OrderItems.Hide();
            PNL_keukenoverzicht.Show();
            Order_Service order_Service = new Order_Service();
            List<Order> order_List = order_Service.Get_Orders();
            //Link tables tot orders If statement per tafel, Miss even aanpassen om cleaner te maken 
            foreach (Order items in order_List)
            {
                //                DisplayOrder(items);
                //ListView lv = (ListView)this.Controls.Find("listView" + items.Tafel_ID + "_KeukenOverzicht");
                if (items.Tafel_ID == 1)
                {
                    listView1_KeukenOverzicht.Items.Clear();
                    listView1_KeukenOverzicht.View = View.Details;
                    ListViewItem li = new ListViewItem(items.Order_ID.ToString());
                    li.SubItems.Add(items.Tafel_ID.ToString());
                    li.SubItems.Add(items.Werknemer_ID.ToString());
                    listView1_KeukenOverzicht.Items.Add(li);
                }
                else if (items.Tafel_ID == 2)
                {
                    listView2_keukenOverzicht.Items.Clear();
                    listView2_keukenOverzicht.View = View.Details;
                    ListViewItem li = new ListViewItem(items.Order_ID.ToString());
                    li.SubItems.Add(items.Tafel_ID.ToString());
                    li.SubItems.Add(items.Werknemer_ID.ToString());
                    listView2_keukenOverzicht.Items.Add(li);
                }

                else if (items.Tafel_ID == 3)
                {
                    listView3_keukenoverzicht.Items.Clear();
                    listView3_keukenoverzicht.View = View.Details;
                    ListViewItem li = new ListViewItem(items.Order_ID.ToString());
                    li.SubItems.Add(items.Tafel_ID.ToString());
                    li.SubItems.Add(items.Werknemer_ID.ToString());
                    listView3_keukenoverzicht.Items.Add(li);
                }
          
               else if (items.Tafel_ID == 4)
                {
                    listView4_keukenoverzicht.Items.Clear();
                    listView4_keukenoverzicht.View = View.Details;
                    ListViewItem li = new ListViewItem(items.Order_ID.ToString());
                    li.SubItems.Add(items.Tafel_ID.ToString());
                    li.SubItems.Add(items.Werknemer_ID.ToString());

                    listView4_keukenoverzicht.Items.Add(li);
                }
          
               else if (items.Tafel_ID == 5)
                {
                    listView5_keukenoverzicht.Items.Clear();
                    listView5_keukenoverzicht.View = View.Details;
                    ListViewItem li = new ListViewItem(items.Order_ID.ToString());
                    li.SubItems.Add(items.Tafel_ID.ToString());
                    li.SubItems.Add(items.Werknemer_ID.ToString());
                    listView5_keukenoverzicht.Items.Add(li);

                }
           
               else if (items.Tafel_ID == 6)
                {
                    listView6_keukenoverzicht.Items.Clear();
                    listView6_keukenoverzicht.View = View.Details;
                    ListViewItem li = new ListViewItem(items.Order_ID.ToString());
                    li.SubItems.Add(items.Tafel_ID.ToString());
                    li.SubItems.Add(items.Werknemer_ID.ToString());
                    listView6_keukenoverzicht.Items.Add(li);
                }
        
                else if (items.Tafel_ID == 7)
                {
                    listView7_keukenoverzicht.Items.Clear();
                    listView7_keukenoverzicht.View = View.Details;
                    ListViewItem li = new ListViewItem(items.Order_ID.ToString());
                    li.SubItems.Add(items.Tafel_ID.ToString());
                    li.SubItems.Add(items.Werknemer_ID.ToString());
                    listView7_keukenoverzicht.Items.Add(li);
                }

                else if (items.Tafel_ID == 8)
                {
                    listView8_keukenoverzicht.Items.Clear();
                    listView8_keukenoverzicht.View = View.Details;
                    ListViewItem li = new ListViewItem(items.Order_ID.ToString());
                    li.SubItems.Add(items.Tafel_ID.ToString());
                    li.SubItems.Add(items.Werknemer_ID.ToString());
                    listView8_keukenoverzicht.Items.Add(li);
                }
         
                else if (items.Tafel_ID == 9)
                {
                    listView9_keukenoverzicht.Items.Clear();
                    listView9_keukenoverzicht.View = View.Details;
                    ListViewItem li = new ListViewItem(items.Order_ID.ToString());
                    li.SubItems.Add(items.Tafel_ID.ToString());
                    li.SubItems.Add(items.Werknemer_ID.ToString());
                    listView9_keukenoverzicht.Items.Add(li);
                }
         
                else  
                {
                    listView10_keukenoverzicht.Items.Clear();
                    listView10_keukenoverzicht.View = View.Details;
                    ListViewItem li = new ListViewItem(items.Order_ID.ToString());
                    li.SubItems.Add(items.Tafel_ID.ToString());
                    li.SubItems.Add(items.Werknemer_ID.ToString());
                    listView10_keukenoverzicht.Items.Add(li);
                }
            }
        }

        private void btn_Gereed1_Click(object sender, EventArgs e)
        {
            pnl_OrderItems.Show();
            pnl_homekeuken.Hide();
            lbl_OrderItems.Text = "Tafel 1";

           
        }

       private void Update(object sender, EventArgs e)
        {
           
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            pnl_homekeuken.Hide();
            PNL_keukenoverzicht.Show();
        }

        private void btn_terug_Click(object sender, EventArgs e)
        {
            pnl_homekeuken.Show();
        }

        private void btn_close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Order_Overzicht_Terug_Click_1(object sender, EventArgs e)
        {
            pnl_OrderItems.Hide();
            PNL_keukenoverzicht.Show();
        }

        private void btn_ViewOrder2_Click(object sender, EventArgs e)
        {
            pnl_OrderItems.Show();
            pnl_homekeuken.Hide();
            lbl_OrderItems.Text = "Tafel 2";

        }

        private void btn_ViewOrder3_Click(object sender, EventArgs e)
        {
            pnl_OrderItems.Show();
            pnl_homekeuken.Hide();
            lbl_OrderItems.Text = "Tafel 3";
        }

        private void btn_ViewOrder4_Click(object sender, EventArgs e)
        {
            pnl_OrderItems.Show();
            pnl_homekeuken.Hide();
            lbl_OrderItems.Text = "Tafel 4";

        }

        private void btn_ViewOrder5_Click(object sender, EventArgs e)
        {
            pnl_OrderItems.Show();
            pnl_homekeuken.Hide();
            lbl_OrderItems.Text = "Tafel 5";
        }

        private void btn_ViewOrder6_Click(object sender, EventArgs e)
        {
            pnl_OrderItems.Show();
            pnl_homekeuken.Hide();
            lbl_OrderItems.Text = "Tafel 6";
            Order_Items_Service order_Item_Service = new Order_Items_Service();
            List<Order_Item> order_Item_List = order_Item_Service.Get_Order_Items();
            Order_Item order_Items = new Order_Item();
            Order_Service order_Service = new Order_Service();
            List<Order> order_List = order_Service.Get_Orders();



            foreach (Order items in order_List)
            {

                foreach (Order_Item orderitems in order_Item_List)
                {

                    if (items.Tafel_ID == 7)
                    {
                        listView_OrderItems.Items.Clear();
                        listView_OrderItems.View = View.Details;
                        ListViewItem li = new ListViewItem(orderitems.Tijd.ToString());
                        li.SubItems.Add(orderitems.Menu_Item_ID.ToString());
                        li.SubItems.Add(orderitems.status.ToString());
                        listView_OrderItems.Items.Add(li);

                    }
                }
            }


        }

        private void btn_ViewOrder7_Click(object sender, EventArgs e)
        {
            pnl_OrderItems.Show();
            pnl_homekeuken.Hide();
            lbl_OrderItems.Text = "Tafel 7";
            Order_Items_Service order_Item_Service = new Order_Items_Service();
            List<Order_Item> order_Item_List = order_Item_Service.Get_Order_Items();
            Order_Item order_Items = new Order_Item();
            Order_Service order_Service = new Order_Service();
            List<Order> order_List = order_Service.Get_Orders();

            foreach (Order items in order_List)
            {

                foreach (Order_Item orderitems in order_Item_List)
                {
                    if(items.Tafel_ID == 7)
                    {
                        listView_OrderItems.View = View.Details;
                        ListViewItem li = new ListViewItem(orderitems.Tijd.ToString());
                        li.SubItems.Add(orderitems.Menu_Item_ID.ToString());
                        li.SubItems.Add(orderitems.status.ToString());
                        listView_OrderItems.Items.Add(li);
                    }
                }
            }
        }

        private void btn_ViewOrder8_Click(object sender, EventArgs e)
        {
            pnl_OrderItems.Show();
            pnl_homekeuken.Hide();
            lbl_OrderItems.Text = "Tafel 8";
        }

        private void btn_ViewOrder9_Click(object sender, EventArgs e)
        {
            pnl_OrderItems.Show();
            pnl_homekeuken.Hide();
            lbl_OrderItems.Text = "Tafel 9";
        }

        private void btn_ViewOrdewr10_Click(object sender, EventArgs e)
        {
            pnl_OrderItems.Show();
            pnl_homekeuken.Hide();
            lbl_OrderItems.Text = "Tafel 10";
        }
    }
}
