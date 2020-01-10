using Chapoo1819;
using ChapooDAL;
using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class Bediening : Form
    {
        public Bediening()
        {
            InitializeComponent();
        }

        private void Bediening_Load(object sender, EventArgs e)
        {
            pnl_StatusOverzicht.Show();
            pnl_TafelNAV.Show();

            pnl_OrderBevestiging.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OpenOrders.Hide();


            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_ID == 1)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Tafel1.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Tafel1.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Tafel1.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 2)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Tafel2.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Tafel2.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Tafel2.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 3)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Tafel3.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Tafel3.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Tafel3.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 4)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Tafel4.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Tafel4.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Tafel4.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 5)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Tafel5.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Tafel5.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Tafel5.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 6)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Tafel6.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Tafel6.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Tafel6.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 7)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Tafel7.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Tafel7.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Tafel7.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 8)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Tafel8.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Tafel8.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Tafel8.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
            }
        }

        private void txt_ZoekMenuItems_TextChanged(object sender, EventArgs e)
        {
            Menu_Items_Service items_Service = new Menu_Items_Service();
            List<Menu_Item> item_List = items_Service.Zoek_Menu_Item(txt_ZoekMenuItems.Text);

            item_List.Where(c => c.Naam.StartsWith(txt_ZoekMenuItems.Text));
            listView_MenuItems.Items.Clear();

            foreach (Menu_Item item in item_List)
            {
                ListViewItem list = new ListViewItem(item.Naam);
                list.SubItems.Add(item.Voorraad.ToString());
                list.SubItems.Add(item.Prijs.ToString());
                listView_MenuItems.Items.Add(list);
            }
        }

        private void PopulateListview()
        {
            Menu_Items_Service items_Service = new Menu_Items_Service();
            List<Menu_Item> item_List = items_Service.Get_Menu_Item();

            foreach (Menu_Item item in item_List)
            {
                ListViewItem list = new ListViewItem(item.Naam);
                list.SubItems.Add(item.Menu_Item_ID.ToString());
                list.SubItems.Add(item.Voorraad.ToString());
                list.SubItems.Add(item.Prijs.ToString());
                listView_MenuItems.Items.Add(list);
            }
        }

        private void PopulateListViewORDERS(Order order_ID, Tafel tafel_ID)
        {
            Order_Items_Service order_Items_Service = new Order_Items_Service();
            List<Order_Item> order_items = order_Items_Service.DB_Get_Order_Items_By_Tafel(tafel_ID.Tafel_ID, order_ID.Order_ID);

            listView_OrderOverzicht.Clear();

            foreach (Order_Item order in order_items)
            {
                ListViewItem list = new ListViewItem(order.Order_Item_ID.ToString());
                list.SubItems.Add(order.Order_ID.ToString());
                list.SubItems.Add(order.Menu_Item_ID.ToString());
                list.SubItems.Add(order.status.ToString());
                list.SubItems.Add(order.Hoeveelheid.ToString());
                list.SubItems.Add(order.Tijd.ToString());
                list.SubItems.Add(order.Opmerking);
                listView_MenuItems.Items.Add(list);
            }
        }

        private void lbl_TafelOverzicht_Click(object sender, EventArgs e)
        {
            pnl_TafelOverzicht.Show();
            pnl_TafelNAV.Show();

            pnl_StatusOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Verander Tafel_NAV
            lbl_TafelOverzicht.ForeColor = Color.White;
            lbl_TafelOverzicht.Font = new Font("Calibri", 14, FontStyle.Bold);

            lbl_StatusOverzicht.ForeColor = Color.Gainsboro;
            lbl_StatusOverzicht.Font = new Font("Calibri", 13, FontStyle.Regular);

            //Zet kleuren van tafels
            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_ID == 1)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Taf1.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Taf1.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Taf1.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 2)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Taf2.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Taf2.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Taf2.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 3)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Taf3.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Taf3.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Taf3.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 4)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Taf4.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Taf4.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Taf4.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 5)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Taf5.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Taf5.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Taf5.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 6)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Taf6.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Taf6.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Taf6.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 7)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Taf7.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Taf7.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Taf7.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 8)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Taf8.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Taf8.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Taf8.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 9)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Taf9.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Taf9.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Taf9.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
                else if (tafel.Tafel_ID == 10)
                {
                    if (tafel.Tafel_Status == Tafel_Status.Open)
                    {
                        btn_Taf10.BackColor = Color.FromArgb(25, 211, 118);
                    }
                    else if (tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                    {
                        btn_Taf10.BackColor = Color.FromArgb(86, 84, 255);
                    }
                    else
                    {
                        btn_Taf10.BackColor = Color.FromArgb(236, 84, 63);
                    }
                }
            }
        }

        private void CatagorieBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CatagorieBOX.Text == "Diner")
            {
                Menu_Items_Service items_Service = new Menu_Items_Service();
                List<Menu_Item> item_List = items_Service.GetDiners();

                listView_MenuItems.Items.Clear();
                listView_MenuItems.View = View.Details;

                foreach (Menu_Item item in item_List)
                {
                    ListViewItem list = new ListViewItem(item.Naam);
                    list.SubItems.Add(item.Prijs.ToString());
                    listView_MenuItems.Items.Add(list);
                }
            }
            else if (CatagorieBOX.Text == "Lunch")
            {
                Menu_Items_Service items_Service = new Menu_Items_Service();
                List<Menu_Item> item_List = items_Service.GetLunch();

                listView_MenuItems.Items.Clear();
                listView_MenuItems.View = View.Details;

                foreach (Menu_Item item in item_List)
                {
                    ListViewItem list = new ListViewItem(item.Naam);
                    list.SubItems.Add(item.Prijs.ToString());
                    listView_MenuItems.Items.Add(list);
                }
            }
            else if (CatagorieBOX.Text == "Dranken")
            {
                Menu_Items_Service items_Service = new Menu_Items_Service();
                List<Menu_Item> item_List = items_Service.GetDrinks();

                listView_MenuItems.Items.Clear();
                listView_MenuItems.View = View.Details;

                foreach (Menu_Item item in item_List)
                {
                    ListViewItem list = new ListViewItem(item.Naam);
                    list.SubItems.Add(item.Prijs.ToString());
                    listView_MenuItems.Items.Add(list);
                }
            }
            else
            {
                PopulateListview();
            }
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            pnl_StatusOverzicht.Show();
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Status overzicht";
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();
        }

        private void btn_VoegToe_Click(object sender, EventArgs e)
        {
            pnl_OrderBevestiging.Show();
        }

        private void lbl_StatusOverzicht_Click(object sender, EventArgs e)
        {
            //Toon goede panels
            pnl_StatusOverzicht.Show();
            pnl_TafelNAV.Show();

            pnl_TafelOverzicht.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Verander Tafel_NAV
            lbl_StatusOverzicht.ForeColor = Color.White;
            lbl_StatusOverzicht.Font = new Font("Calibri", 14, FontStyle.Bold);

            lbl_TafelOverzicht.ForeColor = Color.Gainsboro;
            lbl_TafelOverzicht.Font = new Font("Calibri", 13, FontStyle.Regular);
            lbl_TafelOverzicht.Text = "Status Overzicht";

        }
        //
        //Status buttons
        //
        private void btn_StatTafel1_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 1";

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (btn_Tafel1.BackColor == Color.FromArgb(25, 211, 118))
                {
                    pnl_BestellingOpnemen.Show();
                    PopulateListview();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                    PopulateListview();
                }
            }
        }

        private void btn_StatTafel2_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_OrderBevestiging.Hide();
            pnl_OpenOrders.Hide();
            pnl_TafelOverzicht.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 2";

            Tafel tafel_ID = new Tafel();
            tafel_ID.Tafel_ID = 2;

            Order_Service order_Service = new Order_Service();
            Order order = order_Service.DB_Get_Order_By_Tafel(tafel_ID.Tafel_ID);

            Order_Items_Service order_Items_Service = new Order_Items_Service();
            List<Order_Item> order_Items = order_Items_Service.DB_Get_Order_Items_By_Tafel(tafel_ID.Tafel_ID, order.Order_ID);

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            //Get correct orders
            pnl_OpenOrders.Show();
            listView_OrderOverzicht.Clear();

            foreach (Order_Item item in order_Items)
            {
                ListViewItem list = new ListViewItem(item.Menu_Item_ID.ToString());
                list.SubItems.Add(item.status.ToString());
                list.SubItems.Add(item.Hoeveelheid.ToString());
                list.SubItems.Add(item.Tijd.ToString());
                list.SubItems.Add(item.Opmerking);
                listView_OrderOverzicht.Items.Add(list);
            }

            //foreach (Tafel tafel in tafels)
            //{
            //    if (tafel.Tafel_Status == Tafel_Status.Bezet)
            //    {

            //    }
            //    else
            //    {
            //        pnl_BestellingOpnemen.Show();
            //    }
            //}
        }

        private void btn_StatTafel3_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            pnl_BestellingOpnemen.Show();
            lbl_StatusOverzicht.Text = "Tafel 3";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_StatTafel4_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            pnl_BestellingOpnemen.Show();
            lbl_StatusOverzicht.Text = "Tafel 4";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_StatTafel5_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            pnl_BestellingOpnemen.Show();
            lbl_StatusOverzicht.Text = "Tafel 5";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_StatTafel6_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            pnl_BestellingOpnemen.Show();
            lbl_StatusOverzicht.Text = "Tafel 6";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_StatTafel7_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            pnl_BestellingOpnemen.Show();
            lbl_StatusOverzicht.Text = "Tafel 7";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        //
        // Tafel buttons
        //
        private void btn_Taf1_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 1";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_Taf2_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 2";


            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (btn_Taf2.BackColor == Color.FromArgb(25, 211, 118))
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                    PopulateListview();
                }
            }
        }

        private void btn_Taf3_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 3";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_Taf4_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 4";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_Taf5_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 5";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_Taf6_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 6";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_Taf7_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 7";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_Taf8_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 8";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_Taf9_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 9";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }

        private void btn_Taf10_Click(object sender, EventArgs e)
        {
            //Verberg alle andere panels
            pnl_StatusOverzicht.Hide();
            pnl_TafelOverzicht.Hide();
            pnl_OpenOrders.Hide();
            pnl_BestellingOpnemen.Hide();
            pnl_OrderBevestiging.Hide();

            //Toon bestelling panel en verander tafel
            pnl_TafelNAV.Show();
            lbl_StatusOverzicht.Text = "Tafel 10";
            PopulateListview();

            tafel_Service tafel_Status = new tafel_Service();
            List<Tafel> tafels = tafel_Status.Get_Tafels();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Bezet)
                {
                    pnl_OpenOrders.Show();
                }
                else
                {
                    pnl_BestellingOpnemen.Show();
                }
            }
        }
        //
        //Legenda
        //
        private void btn_Vrij_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alle groene tafels zijn vrij!");
        }

        private void btn_Gereserveerd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alle blauwe tafels zijn gereserveerd!");
        }

        private void btn_Bezet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alle rode tafels zijn bezet!");
        }

        private void txt_Opmerking_Enter(object sender, EventArgs e)
        {
            if (txt_Opmerking.Text == "Opmerking (500 letters max)")
            {
                txt_Opmerking.Text = "";

                txt_Opmerking.ForeColor = Color.Black;
            }
        }

        private void txt_Opmerking_Leave(object sender, EventArgs e)
        {
            if (txt_Opmerking.Text == "")
            {
                txt_Opmerking.Text = "Opmerking (500 letters max)";

                txt_Opmerking.ForeColor = Color.DarkGray;
            }
        }

        private void btn_Back_DEF_Click(object sender, EventArgs e)
        {
            pnl_OrderBevestiging.Hide();
        }

        private void btn_VoegToe_DEF_Click(object sender, EventArgs e)
        {
            lbl_Productnaam.Text = listView_MenuItems.SelectedItems[0].SubItems[1].Text;
            //Order
            Order_Service order_Service = new Order_Service();
            List<Order> orders = new List<Order>();

            //Order items
            Order_Items_Service order_Items_Service = new Order_Items_Service();
            List<Order_Item> order_items = new List<Order_Item>();

            //Werknemer
            Werknemer werknemer = new Werknemer();
            werknemer.Werknemer_ID = 2;

            //Tafel info
            tafel_Service tafel_Service = new tafel_Service();
            List<Tafel> tafels = tafel_Service.Get_Tafels();

            //Order Items info
            Order_Item order_Item = new Order_Item();

            foreach (Tafel tafel in tafels)
            {
                if (tafel.Tafel_Status == Tafel_Status.Open || tafel.Tafel_Status == Tafel_Status.Gereserveerd)
                {
                    orders = order_Service.New_Order(tafel, werknemer);
                    foreach (Order order in orders)
                    {
                        order_Item.Order_ID = order.Order_ID;
                    }
                    
                    order_Item.Menu_Item_ID = int.Parse(listView_MenuItems.SelectedItems[0].SubItems[1].Text);
                    order_Item.status = Order_Status.Besteld;
                    order_Item.Hoeveelheid = int.Parse(txt_Hoeveelheid.Text);
                    order_Item.Tijd = DateTime.Now;
                    order_Item.Opmerking = txt_Opmerking.Text;
                }
                //else if (tafel.Tafel_Status == Tafel_Status.Bezet)
                //{
                //    orders = order_Service.Get_Orders();
                //    order_Item.Menu_Item_ID = int.Parse(listView_MenuItems.SelectedItems[0].SubItems[1].Text);
                //    order_Item.status = Order_Status.Besteld;
                //    order_Item.Hoeveelheid = int.Parse(txt_Hoeveelheid.Text);
                //    order_Item.Tijd = DateTime.Now;
                //    order_Item.Opmerking = txt_Opmerking.Text;

                //    foreach (Order order in orders)
                //    {

                //    }
                //    orders = order_Items_Service.Add_To_Order();
                //}
            }

        }
    }
}


