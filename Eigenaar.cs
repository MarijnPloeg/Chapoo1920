using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;
using ChapooLogic;
using ChapooDAL;

namespace ChapooUI
{
    public partial class Eigenaar : Form
    {
        public Eigenaar()
        {
            InitializeComponent();
        }

        private void showPanel(string panelName)
        {
            if (panelName == "Hoofdmenu")
            {
                pnl_Hoofdmenu.Show();

                pnl_Voorraad.Hide();
                pnl_Werknemers.Hide();
            }
            else if (panelName == "Voorraad")
            {
                pnl_Voorraad.Show();

                pnl_Hoofdmenu.Hide();
                pnl_Werknemers.Hide();

                Menu_Items_Service menuItem_Service = new Menu_Items_Service();
                List<Menu_Item> menuItems = menuItem_Service.Get_Menu_Item();

                lv_Voorraad.Items.Clear();

                foreach(Menu_Item mI in menuItems)
                {
                    ListViewItem li = new ListViewItem(mI.Naam);
                    li.SubItems.Add(mI.Voorraad.ToString());
                    lv_Voorraad.Items.Add(li);
                }
            }
            else if(panelName == "Werknemers")
            {
                pnl_Werknemers.Show();

                pnl_Hoofdmenu.Hide();
                pnl_Voorraad.Hide();

                Werknemer_Service werknemer_Service = new Werknemer_Service();
                List<Werknemer> werknemers = werknemer_Service.Get_Werknemers();

                foreach(Werknemer w in werknemers)
                {
                    ListViewItem li = new ListViewItem(w.Naam);
                    li.SubItems.Add(w.Functie.ToString());
                    lv_Werknemers.Items.Add(li);
                }
            }
        }

        private void Eigenaar_Load(object sender, EventArgs e)
        {
            showPanel("Hoofdmenu");
        }

        private void btn_Eigenaar_Voorraad_Click(object sender, EventArgs e)
        {
            showPanel("Voorraad");
        }

        private void btn_Eigenaar_Werknemers_Click(object sender, EventArgs e)
        {
            showPanel("Werknemers");
        }

        private void btn_LogUit_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Close();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            showPanel("Hoofdmenu");
        }

        private void btn_Terug2_Click(object sender, EventArgs e)
        {
            showPanel("Hoofdmenu");
        }
    }
}
