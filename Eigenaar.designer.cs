namespace ChapooUI
{
    partial class Eigenaar
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.pnl_Hoofdmenu = new System.Windows.Forms.Panel();
            this.btn_LogUit = new System.Windows.Forms.Button();
            this.btn_Eigenaar_Werknemers = new System.Windows.Forms.Button();
            this.btn_Eigenaar_Voorraad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Voorraad = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_Voorraad = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoeveelheid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Werknemers = new System.Windows.Forms.Panel();
            this.lv_Werknemers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Terug = new System.Windows.Forms.Button();
            this.btn_Terug2 = new System.Windows.Forms.Button();
            this.pnl_Hoofdmenu.SuspendLayout();
            this.pnl_Voorraad.SuspendLayout();
            this.pnl_Werknemers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Hoofdmenu
            // 
            this.pnl_Hoofdmenu.Controls.Add(this.btn_LogUit);
            this.pnl_Hoofdmenu.Controls.Add(this.btn_Eigenaar_Werknemers);
            this.pnl_Hoofdmenu.Controls.Add(this.btn_Eigenaar_Voorraad);
            this.pnl_Hoofdmenu.Controls.Add(this.label1);
            this.pnl_Hoofdmenu.Location = new System.Drawing.Point(24, 23);
            this.pnl_Hoofdmenu.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_Hoofdmenu.Name = "pnl_Hoofdmenu";
            this.pnl_Hoofdmenu.Size = new System.Drawing.Size(1552, 819);
            this.pnl_Hoofdmenu.TabIndex = 0;
            // 
            // btn_LogUit
            // 
            this.btn_LogUit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_LogUit.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogUit.ForeColor = System.Drawing.Color.White;
            this.btn_LogUit.Location = new System.Drawing.Point(680, 583);
            this.btn_LogUit.Name = "btn_LogUit";
            this.btn_LogUit.Size = new System.Drawing.Size(253, 103);
            this.btn_LogUit.TabIndex = 3;
            this.btn_LogUit.Text = "Log Uit";
            this.btn_LogUit.UseVisualStyleBackColor = false;
            this.btn_LogUit.Click += new System.EventHandler(this.btn_LogUit_Click);
            // 
            // btn_Eigenaar_Werknemers
            // 
            this.btn_Eigenaar_Werknemers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Eigenaar_Werknemers.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eigenaar_Werknemers.ForeColor = System.Drawing.Color.White;
            this.btn_Eigenaar_Werknemers.Location = new System.Drawing.Point(284, 356);
            this.btn_Eigenaar_Werknemers.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Eigenaar_Werknemers.Name = "btn_Eigenaar_Werknemers";
            this.btn_Eigenaar_Werknemers.Size = new System.Drawing.Size(500, 150);
            this.btn_Eigenaar_Werknemers.TabIndex = 2;
            this.btn_Eigenaar_Werknemers.Text = "Werknemers";
            this.btn_Eigenaar_Werknemers.UseVisualStyleBackColor = false;
            this.btn_Eigenaar_Werknemers.Click += new System.EventHandler(this.btn_Eigenaar_Werknemers_Click);
            // 
            // btn_Eigenaar_Voorraad
            // 
            this.btn_Eigenaar_Voorraad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Eigenaar_Voorraad.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eigenaar_Voorraad.ForeColor = System.Drawing.Color.White;
            this.btn_Eigenaar_Voorraad.Location = new System.Drawing.Point(284, 160);
            this.btn_Eigenaar_Voorraad.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Eigenaar_Voorraad.Name = "btn_Eigenaar_Voorraad";
            this.btn_Eigenaar_Voorraad.Size = new System.Drawing.Size(500, 150);
            this.btn_Eigenaar_Voorraad.TabIndex = 1;
            this.btn_Eigenaar_Voorraad.Text = "Voorraad";
            this.btn_Eigenaar_Voorraad.UseVisualStyleBackColor = false;
            this.btn_Eigenaar_Voorraad.Click += new System.EventHandler(this.btn_Eigenaar_Voorraad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // pnl_Voorraad
            // 
            this.pnl_Voorraad.Controls.Add(this.btn_Terug);
            this.pnl_Voorraad.Controls.Add(this.label2);
            this.pnl_Voorraad.Controls.Add(this.lv_Voorraad);
            this.pnl_Voorraad.Location = new System.Drawing.Point(24, 23);
            this.pnl_Voorraad.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_Voorraad.Name = "pnl_Voorraad";
            this.pnl_Voorraad.Size = new System.Drawing.Size(1552, 819);
            this.pnl_Voorraad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Voorraad";
            // 
            // lv_Voorraad
            // 
            this.lv_Voorraad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Hoeveelheid});
            this.lv_Voorraad.HideSelection = false;
            this.lv_Voorraad.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lv_Voorraad.Location = new System.Drawing.Point(98, 94);
            this.lv_Voorraad.Margin = new System.Windows.Forms.Padding(6);
            this.lv_Voorraad.Name = "lv_Voorraad";
            this.lv_Voorraad.Size = new System.Drawing.Size(1354, 619);
            this.lv_Voorraad.TabIndex = 1;
            this.lv_Voorraad.UseCompatibleStateImageBehavior = false;
            this.lv_Voorraad.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 500;
            // 
            // Hoeveelheid
            // 
            this.Hoeveelheid.Text = "Hoeveelheid";
            this.Hoeveelheid.Width = 150;
            // 
            // pnl_Werknemers
            // 
            this.pnl_Werknemers.Controls.Add(this.btn_Terug2);
            this.pnl_Werknemers.Controls.Add(this.lv_Werknemers);
            this.pnl_Werknemers.Controls.Add(this.label3);
            this.pnl_Werknemers.Location = new System.Drawing.Point(24, 23);
            this.pnl_Werknemers.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_Werknemers.Name = "pnl_Werknemers";
            this.pnl_Werknemers.Size = new System.Drawing.Size(1552, 819);
            this.pnl_Werknemers.TabIndex = 2;
            // 
            // lv_Werknemers
            // 
            this.lv_Werknemers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_Werknemers.HideSelection = false;
            this.lv_Werknemers.Location = new System.Drawing.Point(98, 94);
            this.lv_Werknemers.Margin = new System.Windows.Forms.Padding(6);
            this.lv_Werknemers.Name = "lv_Werknemers";
            this.lv_Werknemers.Size = new System.Drawing.Size(1354, 619);
            this.lv_Werknemers.TabIndex = 1;
            this.lv_Werknemers.UseCompatibleStateImageBehavior = false;
            this.lv_Werknemers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naam";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Functie";
            this.columnHeader2.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "werknemers";
            // 
            // btn_Terug
            // 
            this.btn_Terug.BackColor = System.Drawing.Color.Brown;
            this.btn_Terug.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Terug.ForeColor = System.Drawing.Color.White;
            this.btn_Terug.Location = new System.Drawing.Point(1370, 0);
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Size = new System.Drawing.Size(179, 61);
            this.btn_Terug.TabIndex = 2;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = false;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // btn_Terug2
            // 
            this.btn_Terug2.BackColor = System.Drawing.Color.Brown;
            this.btn_Terug2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Terug2.ForeColor = System.Drawing.Color.White;
            this.btn_Terug2.Location = new System.Drawing.Point(1370, 3);
            this.btn_Terug2.Name = "btn_Terug2";
            this.btn_Terug2.Size = new System.Drawing.Size(179, 61);
            this.btn_Terug2.TabIndex = 3;
            this.btn_Terug2.Text = "Terug";
            this.btn_Terug2.UseVisualStyleBackColor = false;
            this.btn_Terug2.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // Eigenaar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.pnl_Werknemers);
            this.Controls.Add(this.pnl_Voorraad);
            this.Controls.Add(this.pnl_Hoofdmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Eigenaar";
            this.Text = "Eigenaar";
            this.Load += new System.EventHandler(this.Eigenaar_Load);
            this.pnl_Hoofdmenu.ResumeLayout(false);
            this.pnl_Hoofdmenu.PerformLayout();
            this.pnl_Voorraad.ResumeLayout(false);
            this.pnl_Voorraad.PerformLayout();
            this.pnl_Werknemers.ResumeLayout(false);
            this.pnl_Werknemers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Hoofdmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Eigenaar_Werknemers;
        private System.Windows.Forms.Button btn_Eigenaar_Voorraad;
        private System.Windows.Forms.Panel pnl_Voorraad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Werknemers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_Voorraad;
        private System.Windows.Forms.ListView lv_Werknemers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Hoeveelheid;
        private System.Windows.Forms.Button btn_LogUit;
        private System.Windows.Forms.Button btn_Terug;
        private System.Windows.Forms.Button btn_Terug2;
    }
}