namespace ChapooUI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Gebruikersnaam = new System.Windows.Forms.TextBox();
            this.txt_Wachtwoord = new System.Windows.Forms.TextBox();
            this.btn_Afsluiten = new System.Windows.Forms.Button();
            this.lbl_VerkeerdWW = new System.Windows.Forms.Label();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.pic_ToonWachtwoord = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_WachtwoordVergeten = new System.Windows.Forms.Label();
            this.pnl_WachtwoordVergeten = new System.Windows.Forms.Panel();
            this.lbl_Terug = new System.Windows.Forms.Label();
            this.btn_Verstuur = new System.Windows.Forms.Button();
            this.txt_EmailInvullen = new System.Windows.Forms.TextBox();
            this.lbl_Email_Text = new System.Windows.Forms.Label();
            this.lbl_WWVergeten_Text = new System.Windows.Forms.Label();
            this.pic_WWVergeten = new Chapoo1819.RoundedPictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ToonWachtwoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_WachtwoordVergeten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WWVergeten)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Login.Font = new System.Drawing.Font("Consolas", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(558, 628);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(809, 155);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Gebruikersnaam
            // 
            this.txt_Gebruikersnaam.Font = new System.Drawing.Font("Consolas", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gebruikersnaam.ForeColor = System.Drawing.Color.Silver;
            this.txt_Gebruikersnaam.Location = new System.Drawing.Point(558, 400);
            this.txt_Gebruikersnaam.Multiline = true;
            this.txt_Gebruikersnaam.Name = "txt_Gebruikersnaam";
            this.txt_Gebruikersnaam.Size = new System.Drawing.Size(809, 84);
            this.txt_Gebruikersnaam.TabIndex = 1;
            this.txt_Gebruikersnaam.Text = "Gebruikersnaam";
            this.txt_Gebruikersnaam.Enter += new System.EventHandler(this.txt_Gebruikersnaam_Enter);
            this.txt_Gebruikersnaam.Leave += new System.EventHandler(this.txt_Gebruikersnaam_Leave);
            // 
            // txt_Wachtwoord
            // 
            this.txt_Wachtwoord.Font = new System.Drawing.Font("Consolas", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Wachtwoord.ForeColor = System.Drawing.Color.Silver;
            this.txt_Wachtwoord.Location = new System.Drawing.Point(558, 514);
            this.txt_Wachtwoord.Multiline = true;
            this.txt_Wachtwoord.Name = "txt_Wachtwoord";
            this.txt_Wachtwoord.Size = new System.Drawing.Size(809, 86);
            this.txt_Wachtwoord.TabIndex = 2;
            this.txt_Wachtwoord.Text = "Wachtwoord";
            this.txt_Wachtwoord.Enter += new System.EventHandler(this.txt_Wachtwoord_Enter);
            this.txt_Wachtwoord.Leave += new System.EventHandler(this.txt_Wachtwoord_Leave);
            // 
            // btn_Afsluiten
            // 
            this.btn_Afsluiten.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Afsluiten.Location = new System.Drawing.Point(1801, 0);
            this.btn_Afsluiten.Name = "btn_Afsluiten";
            this.btn_Afsluiten.Size = new System.Drawing.Size(93, 63);
            this.btn_Afsluiten.TabIndex = 5;
            this.btn_Afsluiten.Text = "X";
            this.btn_Afsluiten.UseVisualStyleBackColor = false;
            this.btn_Afsluiten.Click += new System.EventHandler(this.btn_Afsluiten_Click);
            // 
            // lbl_VerkeerdWW
            // 
            this.lbl_VerkeerdWW.AutoSize = true;
            this.lbl_VerkeerdWW.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VerkeerdWW.ForeColor = System.Drawing.Color.Red;
            this.lbl_VerkeerdWW.Location = new System.Drawing.Point(966, 520);
            this.lbl_VerkeerdWW.Name = "lbl_VerkeerdWW";
            this.lbl_VerkeerdWW.Size = new System.Drawing.Size(0, 32);
            this.lbl_VerkeerdWW.TabIndex = 6;
            this.lbl_VerkeerdWW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.pic_ToonWachtwoord);
            this.pnl_Login.Controls.Add(this.pictureBox1);
            this.pnl_Login.Controls.Add(this.lbl_WachtwoordVergeten);
            this.pnl_Login.Controls.Add(this.txt_Gebruikersnaam);
            this.pnl_Login.Controls.Add(this.txt_Wachtwoord);
            this.pnl_Login.Controls.Add(this.btn_Afsluiten);
            this.pnl_Login.Controls.Add(this.btn_Login);
            this.pnl_Login.Location = new System.Drawing.Point(3, 2);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1891, 1010);
            this.pnl_Login.TabIndex = 7;
            // 
            // pic_ToonWachtwoord
            // 
            this.pic_ToonWachtwoord.BackColor = System.Drawing.Color.White;
            this.pic_ToonWachtwoord.Image = global::Chapoo1819.Properties.Resources.Oog;
            this.pic_ToonWachtwoord.Location = new System.Drawing.Point(1271, 514);
            this.pic_ToonWachtwoord.Name = "pic_ToonWachtwoord";
            this.pic_ToonWachtwoord.Size = new System.Drawing.Size(96, 86);
            this.pic_ToonWachtwoord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ToonWachtwoord.TabIndex = 8;
            this.pic_ToonWachtwoord.TabStop = false;
            this.pic_ToonWachtwoord.Click += new System.EventHandler(this.pic_ToonWachtwoord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chapoo1819.Properties.Resources.Chapoo_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(706, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_WachtwoordVergeten
            // 
            this.lbl_WachtwoordVergeten.AutoSize = true;
            this.lbl_WachtwoordVergeten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WachtwoordVergeten.ForeColor = System.Drawing.Color.White;
            this.lbl_WachtwoordVergeten.Location = new System.Drawing.Point(791, 804);
            this.lbl_WachtwoordVergeten.Name = "lbl_WachtwoordVergeten";
            this.lbl_WachtwoordVergeten.Size = new System.Drawing.Size(333, 33);
            this.lbl_WachtwoordVergeten.TabIndex = 6;
            this.lbl_WachtwoordVergeten.Text = "Wachtwoord vergeten?";
            this.lbl_WachtwoordVergeten.Click += new System.EventHandler(this.lbl_WachtwoordVergeten_Click);
            this.lbl_WachtwoordVergeten.MouseEnter += new System.EventHandler(this.lbl_WachtwoordVergeten_MouseEnter);
            this.lbl_WachtwoordVergeten.MouseLeave += new System.EventHandler(this.lbl_WachtwoordVergeten_MouseLeave);
            // 
            // pnl_WachtwoordVergeten
            // 
            this.pnl_WachtwoordVergeten.Controls.Add(this.lbl_Terug);
            this.pnl_WachtwoordVergeten.Controls.Add(this.btn_Verstuur);
            this.pnl_WachtwoordVergeten.Controls.Add(this.txt_EmailInvullen);
            this.pnl_WachtwoordVergeten.Controls.Add(this.lbl_Email_Text);
            this.pnl_WachtwoordVergeten.Controls.Add(this.lbl_WWVergeten_Text);
            this.pnl_WachtwoordVergeten.Controls.Add(this.pic_WWVergeten);
            this.pnl_WachtwoordVergeten.Location = new System.Drawing.Point(0, 5);
            this.pnl_WachtwoordVergeten.Name = "pnl_WachtwoordVergeten";
            this.pnl_WachtwoordVergeten.Size = new System.Drawing.Size(1894, 1010);
            this.pnl_WachtwoordVergeten.TabIndex = 8;
            // 
            // lbl_Terug
            // 
            this.lbl_Terug.AutoSize = true;
            this.lbl_Terug.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Terug.ForeColor = System.Drawing.Color.White;
            this.lbl_Terug.Location = new System.Drawing.Point(924, 823);
            this.lbl_Terug.Name = "lbl_Terug";
            this.lbl_Terug.Size = new System.Drawing.Size(120, 53);
            this.lbl_Terug.TabIndex = 5;
            this.lbl_Terug.Text = "Terug";
            this.lbl_Terug.Click += new System.EventHandler(this.lbl_Terug_Click);
            this.lbl_Terug.MouseEnter += new System.EventHandler(this.lbl_Terug_MouseEnter);
            this.lbl_Terug.MouseLeave += new System.EventHandler(this.lbl_Terug_MouseLeave);
            // 
            // btn_Verstuur
            // 
            this.btn_Verstuur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(84)))), ((int)(((byte)(63)))));
            this.btn_Verstuur.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verstuur.ForeColor = System.Drawing.Color.White;
            this.btn_Verstuur.Location = new System.Drawing.Point(830, 678);
            this.btn_Verstuur.Name = "btn_Verstuur";
            this.btn_Verstuur.Size = new System.Drawing.Size(297, 105);
            this.btn_Verstuur.TabIndex = 4;
            this.btn_Verstuur.Text = "Verstuur";
            this.btn_Verstuur.UseVisualStyleBackColor = false;
            // 
            // txt_EmailInvullen
            // 
            this.txt_EmailInvullen.BackColor = System.Drawing.SystemColors.Window;
            this.txt_EmailInvullen.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailInvullen.ForeColor = System.Drawing.Color.Gray;
            this.txt_EmailInvullen.Location = new System.Drawing.Point(619, 572);
            this.txt_EmailInvullen.Multiline = true;
            this.txt_EmailInvullen.Name = "txt_EmailInvullen";
            this.txt_EmailInvullen.Size = new System.Drawing.Size(720, 76);
            this.txt_EmailInvullen.TabIndex = 3;
            this.txt_EmailInvullen.Text = "Vul hier je email adres in";
            this.txt_EmailInvullen.Enter += new System.EventHandler(this.txt_EmailInvullen_Enter);
            this.txt_EmailInvullen.Leave += new System.EventHandler(this.txt_EmailInvullen_Leave);
            // 
            // lbl_Email_Text
            // 
            this.lbl_Email_Text.AutoSize = true;
            this.lbl_Email_Text.Font = new System.Drawing.Font("Calibri Light", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_Text.ForeColor = System.Drawing.Color.White;
            this.lbl_Email_Text.Location = new System.Drawing.Point(611, 507);
            this.lbl_Email_Text.Name = "lbl_Email_Text";
            this.lbl_Email_Text.Size = new System.Drawing.Size(728, 45);
            this.lbl_Email_Text.TabIndex = 2;
            this.lbl_Email_Text.Text = "Vul je email in en we sturen je een herstelsleutel";
            // 
            // lbl_WWVergeten_Text
            // 
            this.lbl_WWVergeten_Text.AutoSize = true;
            this.lbl_WWVergeten_Text.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WWVergeten_Text.ForeColor = System.Drawing.Color.White;
            this.lbl_WWVergeten_Text.Location = new System.Drawing.Point(741, 439);
            this.lbl_WWVergeten_Text.Name = "lbl_WWVergeten_Text";
            this.lbl_WWVergeten_Text.Size = new System.Drawing.Size(439, 53);
            this.lbl_WWVergeten_Text.TabIndex = 1;
            this.lbl_WWVergeten_Text.Text = "Wachtwoord vergeten?";
            // 
            // pic_WWVergeten
            // 
            this.pic_WWVergeten.BackColor = System.Drawing.Color.DarkGray;
            this.pic_WWVergeten.Image = global::Chapoo1819.Properties.Resources.Doggo;
            this.pic_WWVergeten.Location = new System.Drawing.Point(768, 36);
            this.pic_WWVergeten.Name = "pic_WWVergeten";
            this.pic_WWVergeten.Size = new System.Drawing.Size(400, 400);
            this.pic_WWVergeten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_WWVergeten.TabIndex = 0;
            this.pic_WWVergeten.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.lbl_VerkeerdWW);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.pnl_WachtwoordVergeten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ToonWachtwoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_WachtwoordVergeten.ResumeLayout(false);
            this.pnl_WachtwoordVergeten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WWVergeten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Wachtwoord;
        private System.Windows.Forms.Button btn_Afsluiten;
        private System.Windows.Forms.Label lbl_VerkeerdWW;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Label lbl_WachtwoordVergeten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnl_WachtwoordVergeten;
        private Chapoo1819.RoundedPictureBox pic_WWVergeten;
        private System.Windows.Forms.Label lbl_Email_Text;
        private System.Windows.Forms.Label lbl_WWVergeten_Text;
        private System.Windows.Forms.TextBox txt_EmailInvullen;
        private System.Windows.Forms.Label lbl_Terug;
        private System.Windows.Forms.Button btn_Verstuur;
        private System.Windows.Forms.PictureBox pic_ToonWachtwoord;
        public System.Windows.Forms.TextBox txt_Gebruikersnaam;
    }
}