using ChapooDAL;
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
using Chapoo1819;

namespace ChapooUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            showPanel("Login");
        }

        private void showPanel(string panelName)
        {
            if (panelName == "Login")
            {
                pnl_Login.Show();
                pnl_WachtwoordVergeten.Hide();
            }

            else if (panelName == "WachtwoordVergeten")
            {
                pnl_Login.Hide();
                pnl_WachtwoordVergeten.Show();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Werknemer_DAO db_login = new Werknemer_DAO();
            int functie = db_login.GetWerknemerFunctie(txt_Gebruikersnaam.Text);

            if (db_login.TryLogin(txt_Gebruikersnaam.Text, txt_Wachtwoord.Text))
            {
                if (functie == 0)
                {
                    MessageBox.Show("Functie barman niet geimplementeerd");
                    this.Hide();
                }
                else if (functie == 1)
                {
                    Bediening bediening_Form = new Bediening();
                    bediening_Form.Show();
                    this.Hide();

                }
                else if (functie == 2)
                {
                    KeukenOverzicht keuken_Form = new KeukenOverzicht();
                    keuken_Form.Show();
                    this.Hide();

                }
                else if (functie == 3)
                {
                    Eigenaar eigenaar_Form = new Eigenaar();
                    eigenaar_Form.Show();
                    this.Hide();
                }
                
            }
            else
            {
                lbl_VerkeerdWW.Text = "Verkeerde wachtwoord/gebuikersnaam!";
            }
        }

        private void txt_Gebruikersnaam_Enter(object sender, EventArgs e)
        {
            if (txt_Gebruikersnaam.Text == "Gebruikersnaam")
            {
                txt_Gebruikersnaam.Text = "";

                txt_Gebruikersnaam.ForeColor = Color.Black;
            }
        }

        private void txt_Gebruikersnaam_Leave(object sender, EventArgs e)
        {
            if (txt_Gebruikersnaam.Text == "")
            {
                txt_Gebruikersnaam.Text = "Gebruikersnaam";

                txt_Gebruikersnaam.ForeColor = Color.Silver;
            }
        }

        private void txt_Wachtwoord_Enter(object sender, EventArgs e)
        {
            txt_Wachtwoord.PasswordChar = '*';

            if (txt_Wachtwoord.Text == "Wachtwoord")
            {
                txt_Wachtwoord.Text = "";

                txt_Wachtwoord.ForeColor = Color.Black;
            }
        }

        private void txt_Wachtwoord_Leave(object sender, EventArgs e)
        {
            txt_Wachtwoord.PasswordChar = '\0';

            if (txt_Wachtwoord.Text == "")
            {
                txt_Wachtwoord.Text = "Wachtwoord";

                txt_Wachtwoord.ForeColor = Color.Silver;
            }
        }

        private void btn_Afsluiten_Click(object sender, EventArgs e)
        {
            CloseLoginForm();
        }

        private void lbl_WachtwoordVergeten_MouseEnter(object sender, EventArgs e)
        {
            lbl_WachtwoordVergeten.Font = new Font(lbl_WachtwoordVergeten.Font.Name, lbl_WachtwoordVergeten.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lbl_WachtwoordVergeten_MouseLeave(object sender, EventArgs e)
        {
            lbl_WachtwoordVergeten.Font = new Font(lbl_WachtwoordVergeten.Font.Name, lbl_WachtwoordVergeten.Font.SizeInPoints, FontStyle.Regular);
        }

        private void lbl_WachtwoordVergeten_Click(object sender, EventArgs e)
        {
            showPanel("WachtwoordVergeten");
        }

        private void txt_EmailInvullen_Enter(object sender, EventArgs e)
        {
            if (txt_EmailInvullen.Text == "Vul hier je email adres in")
            {
                txt_EmailInvullen.Text = "";

                txt_EmailInvullen.ForeColor = Color.Black;
            }
        }

        private void txt_EmailInvullen_Leave(object sender, EventArgs e)
        {
            if (txt_EmailInvullen.Text == "")
            {
                txt_EmailInvullen.Text = "Vul hier je email adres in";

                txt_EmailInvullen.ForeColor = Color.Silver;
            }
        }

        private void lbl_Terug_MouseEnter(object sender, EventArgs e)
        {
            lbl_Terug.Font = new Font(lbl_Terug.Font.Name, lbl_Terug.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lbl_Terug_MouseLeave(object sender, EventArgs e)
        {
            lbl_Terug.Font = new Font(lbl_Terug.Font.Name, lbl_Terug.Font.SizeInPoints, FontStyle.Regular);
        }

        private void lbl_Terug_Click(object sender, EventArgs e)
        {
            showPanel("Login");
        }

        private void CloseLoginForm()
        {
            this.Close();
        }

        private void pic_ToonWachtwoord_Click(object sender, EventArgs e)
        {
            if (txt_Wachtwoord.UseSystemPasswordChar)
            {
                txt_Wachtwoord.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Wachtwoord.UseSystemPasswordChar = true;
            }
        }
    }
}
