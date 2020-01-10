using System.Timers;
using System;

namespace ChapooUI
{
    partial class KeukenOverzicht
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
            this.listView1_KeukenOverzicht = new System.Windows.Forms.ListView();
            this.Order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tafel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weknemer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Gereed1 = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.listView2_keukenOverzicht = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ViewOrder2 = new System.Windows.Forms.Button();
            this.listView3_keukenoverzicht = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView4_keukenoverzicht = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView5_keukenoverzicht = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView6_keukenoverzicht = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView7_keukenoverzicht = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView8_keukenoverzicht = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ViewOrder3 = new System.Windows.Forms.Button();
            this.btn_ViewOrder4 = new System.Windows.Forms.Button();
            this.btn_ViewOrder5 = new System.Windows.Forms.Button();
            this.btn_ViewOrder6 = new System.Windows.Forms.Button();
            this.btn_ViewOrder7 = new System.Windows.Forms.Button();
            this.btn_ViewOrder8 = new System.Windows.Forms.Button();
            this.listView9_keukenoverzicht = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView10_keukenoverzicht = new System.Windows.Forms.ListView();
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ViewOrdewr10 = new System.Windows.Forms.Button();
            this.btn_ViewOrder9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PNL_keukenoverzicht = new System.Windows.Forms.Panel();
            this.pnl_OrderItems = new System.Windows.Forms.Panel();
            this.lbl_OrderItems = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Order_Overzicht_Terug = new System.Windows.Forms.Button();
            this.listView_OrderItems = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_homekeuken = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_close1 = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_terug = new System.Windows.Forms.Button();
            this.Tijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PNL_keukenoverzicht.SuspendLayout();
            this.pnl_OrderItems.SuspendLayout();
            this.pnl_homekeuken.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1_KeukenOverzicht
            // 
            this.listView1_KeukenOverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Order,
            this.Tafel,
            this.Weknemer});
            this.listView1_KeukenOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.listView1_KeukenOverzicht.HideSelection = false;
            this.listView1_KeukenOverzicht.Location = new System.Drawing.Point(46, 108);
            this.listView1_KeukenOverzicht.Name = "listView1_KeukenOverzicht";
            this.listView1_KeukenOverzicht.Size = new System.Drawing.Size(363, 171);
            this.listView1_KeukenOverzicht.TabIndex = 0;
            this.listView1_KeukenOverzicht.UseCompatibleStateImageBehavior = false;
            this.listView1_KeukenOverzicht.View = System.Windows.Forms.View.Details;
            // 
            // Order
            // 
            this.Order.Text = "OrderID";
            this.Order.Width = 50;
            // 
            // Tafel
            // 
            this.Tafel.Text = "Tafel";
            this.Tafel.Width = 50;
            // 
            // Weknemer
            // 
            this.Weknemer.Text = "Werknemer";
            this.Weknemer.Width = 80;
            // 
            // btn_Gereed1
            // 
            this.btn_Gereed1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Gereed1.Location = new System.Drawing.Point(46, 285);
            this.btn_Gereed1.Name = "btn_Gereed1";
            this.btn_Gereed1.Size = new System.Drawing.Size(363, 77);
            this.btn_Gereed1.TabIndex = 1;
            this.btn_Gereed1.Text = "Bekijk order";
            this.btn_Gereed1.UseVisualStyleBackColor = false;
            this.btn_Gereed1.Click += new System.EventHandler(this.btn_Gereed1_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Close.Location = new System.Drawing.Point(1529, 32);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(51, 43);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // listView2_keukenOverzicht
            // 
            this.listView2_keukenOverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2_keukenOverzicht.HideSelection = false;
            this.listView2_keukenOverzicht.Location = new System.Drawing.Point(439, 108);
            this.listView2_keukenOverzicht.Name = "listView2_keukenOverzicht";
            this.listView2_keukenOverzicht.Size = new System.Drawing.Size(359, 171);
            this.listView2_keukenOverzicht.TabIndex = 3;
            this.listView2_keukenOverzicht.UseCompatibleStateImageBehavior = false;
            this.listView2_keukenOverzicht.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tafel";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Werknemer";
            this.columnHeader3.Width = 134;
            // 
            // btn_ViewOrder2
            // 
            this.btn_ViewOrder2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ViewOrder2.Location = new System.Drawing.Point(439, 285);
            this.btn_ViewOrder2.Name = "btn_ViewOrder2";
            this.btn_ViewOrder2.Size = new System.Drawing.Size(359, 77);
            this.btn_ViewOrder2.TabIndex = 4;
            this.btn_ViewOrder2.Text = "Bekijk order";
            this.btn_ViewOrder2.UseVisualStyleBackColor = false;
            this.btn_ViewOrder2.Click += new System.EventHandler(this.btn_ViewOrder2_Click);
            // 
            // listView3_keukenoverzicht
            // 
            this.listView3_keukenoverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView3_keukenoverzicht.HideSelection = false;
            this.listView3_keukenoverzicht.Location = new System.Drawing.Point(825, 108);
            this.listView3_keukenoverzicht.Name = "listView3_keukenoverzicht";
            this.listView3_keukenoverzicht.Size = new System.Drawing.Size(363, 171);
            this.listView3_keukenoverzicht.TabIndex = 5;
            this.listView3_keukenoverzicht.UseCompatibleStateImageBehavior = false;
            this.listView3_keukenoverzicht.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tafel";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Werknemer";
            // 
            // listView4_keukenoverzicht
            // 
            this.listView4_keukenoverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView4_keukenoverzicht.HideSelection = false;
            this.listView4_keukenoverzicht.Location = new System.Drawing.Point(1217, 108);
            this.listView4_keukenoverzicht.Name = "listView4_keukenoverzicht";
            this.listView4_keukenoverzicht.Size = new System.Drawing.Size(363, 171);
            this.listView4_keukenoverzicht.TabIndex = 6;
            this.listView4_keukenoverzicht.UseCompatibleStateImageBehavior = false;
            this.listView4_keukenoverzicht.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Order";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "tafel";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Werknemer";
            // 
            // listView5_keukenoverzicht
            // 
            this.listView5_keukenoverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView5_keukenoverzicht.HideSelection = false;
            this.listView5_keukenoverzicht.Location = new System.Drawing.Point(46, 435);
            this.listView5_keukenoverzicht.Name = "listView5_keukenoverzicht";
            this.listView5_keukenoverzicht.Size = new System.Drawing.Size(359, 165);
            this.listView5_keukenoverzicht.TabIndex = 7;
            this.listView5_keukenoverzicht.UseCompatibleStateImageBehavior = false;
            this.listView5_keukenoverzicht.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Order";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tafel";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Werknemer";
            // 
            // listView6_keukenoverzicht
            // 
            this.listView6_keukenoverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView6_keukenoverzicht.HideSelection = false;
            this.listView6_keukenoverzicht.Location = new System.Drawing.Point(439, 435);
            this.listView6_keukenoverzicht.Name = "listView6_keukenoverzicht";
            this.listView6_keukenoverzicht.Size = new System.Drawing.Size(359, 165);
            this.listView6_keukenoverzicht.TabIndex = 8;
            this.listView6_keukenoverzicht.UseCompatibleStateImageBehavior = false;
            this.listView6_keukenoverzicht.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Order";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tafel";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "werknemer";
            // 
            // listView7_keukenoverzicht
            // 
            this.listView7_keukenoverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.listView7_keukenoverzicht.HideSelection = false;
            this.listView7_keukenoverzicht.Location = new System.Drawing.Point(825, 435);
            this.listView7_keukenoverzicht.Name = "listView7_keukenoverzicht";
            this.listView7_keukenoverzicht.Size = new System.Drawing.Size(363, 165);
            this.listView7_keukenoverzicht.TabIndex = 9;
            this.listView7_keukenoverzicht.UseCompatibleStateImageBehavior = false;
            this.listView7_keukenoverzicht.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Order";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Tafel";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Werknemer";
            // 
            // listView8_keukenoverzicht
            // 
            this.listView8_keukenoverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
            this.listView8_keukenoverzicht.HideSelection = false;
            this.listView8_keukenoverzicht.Location = new System.Drawing.Point(1217, 435);
            this.listView8_keukenoverzicht.Name = "listView8_keukenoverzicht";
            this.listView8_keukenoverzicht.Size = new System.Drawing.Size(363, 165);
            this.listView8_keukenoverzicht.TabIndex = 10;
            this.listView8_keukenoverzicht.UseCompatibleStateImageBehavior = false;
            this.listView8_keukenoverzicht.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Order";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Tafel";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Werknemer";
            // 
            // btn_ViewOrder3
            // 
            this.btn_ViewOrder3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ViewOrder3.Location = new System.Drawing.Point(825, 285);
            this.btn_ViewOrder3.Name = "btn_ViewOrder3";
            this.btn_ViewOrder3.Size = new System.Drawing.Size(363, 77);
            this.btn_ViewOrder3.TabIndex = 11;
            this.btn_ViewOrder3.Text = "Bekijk order";
            this.btn_ViewOrder3.UseVisualStyleBackColor = false;
            this.btn_ViewOrder3.Click += new System.EventHandler(this.btn_ViewOrder3_Click);
            // 
            // btn_ViewOrder4
            // 
            this.btn_ViewOrder4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ViewOrder4.Location = new System.Drawing.Point(1217, 285);
            this.btn_ViewOrder4.Name = "btn_ViewOrder4";
            this.btn_ViewOrder4.Size = new System.Drawing.Size(363, 77);
            this.btn_ViewOrder4.TabIndex = 12;
            this.btn_ViewOrder4.Text = "Bekijk order";
            this.btn_ViewOrder4.UseVisualStyleBackColor = false;
            this.btn_ViewOrder4.Click += new System.EventHandler(this.btn_ViewOrder4_Click);
            // 
            // btn_ViewOrder5
            // 
            this.btn_ViewOrder5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ViewOrder5.Location = new System.Drawing.Point(46, 606);
            this.btn_ViewOrder5.Name = "btn_ViewOrder5";
            this.btn_ViewOrder5.Size = new System.Drawing.Size(359, 77);
            this.btn_ViewOrder5.TabIndex = 13;
            this.btn_ViewOrder5.Text = "Bekijk order";
            this.btn_ViewOrder5.UseVisualStyleBackColor = false;
            this.btn_ViewOrder5.Click += new System.EventHandler(this.btn_ViewOrder5_Click);
            // 
            // btn_ViewOrder6
            // 
            this.btn_ViewOrder6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ViewOrder6.Location = new System.Drawing.Point(439, 608);
            this.btn_ViewOrder6.Name = "btn_ViewOrder6";
            this.btn_ViewOrder6.Size = new System.Drawing.Size(359, 77);
            this.btn_ViewOrder6.TabIndex = 14;
            this.btn_ViewOrder6.Text = "Bekijk order";
            this.btn_ViewOrder6.UseVisualStyleBackColor = false;
            this.btn_ViewOrder6.Click += new System.EventHandler(this.btn_ViewOrder6_Click);
            // 
            // btn_ViewOrder7
            // 
            this.btn_ViewOrder7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ViewOrder7.Location = new System.Drawing.Point(825, 608);
            this.btn_ViewOrder7.Name = "btn_ViewOrder7";
            this.btn_ViewOrder7.Size = new System.Drawing.Size(363, 77);
            this.btn_ViewOrder7.TabIndex = 15;
            this.btn_ViewOrder7.Text = "Bekijk order";
            this.btn_ViewOrder7.UseVisualStyleBackColor = false;
            this.btn_ViewOrder7.Click += new System.EventHandler(this.btn_ViewOrder7_Click);
            // 
            // btn_ViewOrder8
            // 
            this.btn_ViewOrder8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ViewOrder8.Location = new System.Drawing.Point(1217, 608);
            this.btn_ViewOrder8.Name = "btn_ViewOrder8";
            this.btn_ViewOrder8.Size = new System.Drawing.Size(363, 77);
            this.btn_ViewOrder8.TabIndex = 16;
            this.btn_ViewOrder8.Text = "Bekijk order";
            this.btn_ViewOrder8.UseVisualStyleBackColor = false;
            this.btn_ViewOrder8.Click += new System.EventHandler(this.btn_ViewOrder8_Click);
            // 
            // listView9_keukenoverzicht
            // 
            this.listView9_keukenoverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.listView9_keukenoverzicht.HideSelection = false;
            this.listView9_keukenoverzicht.Location = new System.Drawing.Point(50, 754);
            this.listView9_keukenoverzicht.Name = "listView9_keukenoverzicht";
            this.listView9_keukenoverzicht.Size = new System.Drawing.Size(359, 194);
            this.listView9_keukenoverzicht.TabIndex = 17;
            this.listView9_keukenoverzicht.UseCompatibleStateImageBehavior = false;
            this.listView9_keukenoverzicht.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Order";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Tafel";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Werknemer";
            // 
            // listView10_keukenoverzicht
            // 
            this.listView10_keukenoverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27});
            this.listView10_keukenoverzicht.HideSelection = false;
            this.listView10_keukenoverzicht.Location = new System.Drawing.Point(439, 754);
            this.listView10_keukenoverzicht.Name = "listView10_keukenoverzicht";
            this.listView10_keukenoverzicht.Size = new System.Drawing.Size(359, 197);
            this.listView10_keukenoverzicht.TabIndex = 18;
            this.listView10_keukenoverzicht.UseCompatibleStateImageBehavior = false;
            this.listView10_keukenoverzicht.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Order";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Tafel";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Werknemer";
            // 
            // btn_ViewOrdewr10
            // 
            this.btn_ViewOrdewr10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ViewOrdewr10.Location = new System.Drawing.Point(439, 957);
            this.btn_ViewOrdewr10.Name = "btn_ViewOrdewr10";
            this.btn_ViewOrdewr10.Size = new System.Drawing.Size(359, 77);
            this.btn_ViewOrdewr10.TabIndex = 19;
            this.btn_ViewOrdewr10.Text = "Bekijk order";
            this.btn_ViewOrdewr10.UseVisualStyleBackColor = false;
            this.btn_ViewOrdewr10.Click += new System.EventHandler(this.btn_ViewOrdewr10_Click);
            // 
            // btn_ViewOrder9
            // 
            this.btn_ViewOrder9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ViewOrder9.Location = new System.Drawing.Point(50, 954);
            this.btn_ViewOrder9.Name = "btn_ViewOrder9";
            this.btn_ViewOrder9.Size = new System.Drawing.Size(359, 77);
            this.btn_ViewOrder9.TabIndex = 20;
            this.btn_ViewOrder9.Text = "Bekijk order";
            this.btn_ViewOrder9.UseVisualStyleBackColor = false;
            this.btn_ViewOrder9.Click += new System.EventHandler(this.btn_ViewOrder9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 42);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tafel 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(539, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 42);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tafel 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(925, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 42);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tafel 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1329, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 42);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tafel 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(146, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 42);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tafel 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(539, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 42);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tafel 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(925, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 42);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tafel 7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1329, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 42);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tafel 8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(146, 699);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 42);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tafel 9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(527, 699);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 42);
            this.label10.TabIndex = 30;
            this.label10.Text = "Tafel 10";
            // 
            // PNL_keukenoverzicht
            // 
            this.PNL_keukenoverzicht.Controls.Add(this.pnl_OrderItems);
            this.PNL_keukenoverzicht.Controls.Add(this.pnl_homekeuken);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_terug);
            this.PNL_keukenoverzicht.Controls.Add(this.label1);
            this.PNL_keukenoverzicht.Controls.Add(this.label10);
            this.PNL_keukenoverzicht.Controls.Add(this.listView1_KeukenOverzicht);
            this.PNL_keukenoverzicht.Controls.Add(this.label9);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_Gereed1);
            this.PNL_keukenoverzicht.Controls.Add(this.label8);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_Close);
            this.PNL_keukenoverzicht.Controls.Add(this.label7);
            this.PNL_keukenoverzicht.Controls.Add(this.listView2_keukenOverzicht);
            this.PNL_keukenoverzicht.Controls.Add(this.label6);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_ViewOrder2);
            this.PNL_keukenoverzicht.Controls.Add(this.label5);
            this.PNL_keukenoverzicht.Controls.Add(this.listView3_keukenoverzicht);
            this.PNL_keukenoverzicht.Controls.Add(this.label4);
            this.PNL_keukenoverzicht.Controls.Add(this.listView4_keukenoverzicht);
            this.PNL_keukenoverzicht.Controls.Add(this.label3);
            this.PNL_keukenoverzicht.Controls.Add(this.listView5_keukenoverzicht);
            this.PNL_keukenoverzicht.Controls.Add(this.label2);
            this.PNL_keukenoverzicht.Controls.Add(this.listView6_keukenoverzicht);
            this.PNL_keukenoverzicht.Controls.Add(this.listView7_keukenoverzicht);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_ViewOrder9);
            this.PNL_keukenoverzicht.Controls.Add(this.listView8_keukenoverzicht);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_ViewOrdewr10);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_ViewOrder3);
            this.PNL_keukenoverzicht.Controls.Add(this.listView10_keukenoverzicht);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_ViewOrder4);
            this.PNL_keukenoverzicht.Controls.Add(this.listView9_keukenoverzicht);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_ViewOrder5);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_ViewOrder8);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_ViewOrder6);
            this.PNL_keukenoverzicht.Controls.Add(this.btn_ViewOrder7);
            this.PNL_keukenoverzicht.Location = new System.Drawing.Point(2, 2);
            this.PNL_keukenoverzicht.Name = "PNL_keukenoverzicht";
            this.PNL_keukenoverzicht.Size = new System.Drawing.Size(1998, 1618);
            this.PNL_keukenoverzicht.TabIndex = 31;
            // 
            // pnl_OrderItems
            // 
            this.pnl_OrderItems.Controls.Add(this.lbl_OrderItems);
            this.pnl_OrderItems.Controls.Add(this.button3);
            this.pnl_OrderItems.Controls.Add(this.Order_Overzicht_Terug);
            this.pnl_OrderItems.Controls.Add(this.listView_OrderItems);
            this.pnl_OrderItems.Controls.Add(this.flowLayoutPanel1);
            this.pnl_OrderItems.Location = new System.Drawing.Point(330, 164);
            this.pnl_OrderItems.Name = "pnl_OrderItems";
            this.pnl_OrderItems.Size = new System.Drawing.Size(1140, 765);
            this.pnl_OrderItems.TabIndex = 32;
            // 
            // lbl_OrderItems
            // 
            this.lbl_OrderItems.AutoSize = true;
            this.lbl_OrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderItems.ForeColor = System.Drawing.Color.White;
            this.lbl_OrderItems.Location = new System.Drawing.Point(492, 31);
            this.lbl_OrderItems.Name = "lbl_OrderItems";
            this.lbl_OrderItems.Size = new System.Drawing.Size(139, 42);
            this.lbl_OrderItems.TabIndex = 4;
            this.lbl_OrderItems.Text = "label12";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.Location = new System.Drawing.Point(748, 637);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 91);
            this.button3.TabIndex = 3;
            this.button3.Text = "Gereed melden";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Order_Overzicht_Terug
            // 
            this.Order_Overzicht_Terug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Order_Overzicht_Terug.ForeColor = System.Drawing.Color.White;
            this.Order_Overzicht_Terug.Location = new System.Drawing.Point(87, 637);
            this.Order_Overzicht_Terug.Name = "Order_Overzicht_Terug";
            this.Order_Overzicht_Terug.Size = new System.Drawing.Size(309, 91);
            this.Order_Overzicht_Terug.TabIndex = 2;
            this.Order_Overzicht_Terug.Text = "Terug";
            this.Order_Overzicht_Terug.UseVisualStyleBackColor = false;
            this.Order_Overzicht_Terug.Click += new System.EventHandler(this.Order_Overzicht_Terug_Click_1);
            // 
            // listView_OrderItems
            // 
            this.listView_OrderItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tijd,
            this.MenuItem,
            this.Status});
            this.listView_OrderItems.HideSelection = false;
            this.listView_OrderItems.Location = new System.Drawing.Point(82, 95);
            this.listView_OrderItems.Name = "listView_OrderItems";
            this.listView_OrderItems.Size = new System.Drawing.Size(975, 523);
            this.listView_OrderItems.TabIndex = 1;
            this.listView_OrderItems.UseCompatibleStateImageBehavior = false;
            this.listView_OrderItems.View = System.Windows.Forms.View.Details;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(920, 593);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnl_homekeuken
            // 
            this.pnl_homekeuken.Controls.Add(this.button1);
            this.pnl_homekeuken.Controls.Add(this.btn_close1);
            this.pnl_homekeuken.Controls.Add(this.btn_orders);
            this.pnl_homekeuken.Controls.Add(this.label11);
            this.pnl_homekeuken.Location = new System.Drawing.Point(4, 4);
            this.pnl_homekeuken.Name = "pnl_homekeuken";
            this.pnl_homekeuken.Size = new System.Drawing.Size(1878, 1228);
            this.pnl_homekeuken.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(734, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 121);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voorraad";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_close1
            // 
            this.btn_close1.BackColor = System.Drawing.Color.DarkRed;
            this.btn_close1.Location = new System.Drawing.Point(1493, 57);
            this.btn_close1.Name = "btn_close1";
            this.btn_close1.Size = new System.Drawing.Size(51, 43);
            this.btn_close1.TabIndex = 32;
            this.btn_close1.Text = "X";
            this.btn_close1.UseVisualStyleBackColor = false;
            this.btn_close1.Click += new System.EventHandler(this.btn_close1_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_orders.ForeColor = System.Drawing.Color.White;
            this.btn_orders.Location = new System.Drawing.Point(734, 363);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(385, 121);
            this.btn_orders.TabIndex = 1;
            this.btn_orders.Text = "Orders";
            this.btn_orders.UseVisualStyleBackColor = false;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(785, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 55);
            this.label11.TabIndex = 0;
            this.label11.Text = "Direct naar:";
            // 
            // btn_terug
            // 
            this.btn_terug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_terug.ForeColor = System.Drawing.Color.White;
            this.btn_terug.Location = new System.Drawing.Point(4, 4);
            this.btn_terug.Name = "btn_terug";
            this.btn_terug.Size = new System.Drawing.Size(144, 71);
            this.btn_terug.TabIndex = 31;
            this.btn_terug.Text = "Terug";
            this.btn_terug.UseVisualStyleBackColor = false;
            this.btn_terug.Click += new System.EventHandler(this.btn_terug_Click);
            // 
            // Tijd
            // 
            this.Tijd.Text = "Tijd";
            this.Tijd.Width = 262;
            // 
            // MenuItem
            // 
            this.MenuItem.Text = "MenuItem";
            this.MenuItem.Width = 272;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 218;
            // 
            // KeukenOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.PNL_keukenoverzicht);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeukenOverzicht";
            this.Text = "KeukenOverzicht";
            this.Load += new System.EventHandler(this.KeukenOverzicht_Load);
            this.PNL_keukenoverzicht.ResumeLayout(false);
            this.PNL_keukenoverzicht.PerformLayout();
            this.pnl_OrderItems.ResumeLayout(false);
            this.pnl_OrderItems.PerformLayout();
            this.pnl_homekeuken.ResumeLayout(false);
            this.pnl_homekeuken.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1_KeukenOverzicht;
        private System.Windows.Forms.Button btn_Gereed1;
        private System.Windows.Forms.ColumnHeader Order;
        private System.Windows.Forms.ColumnHeader Tafel;
        private System.Windows.Forms.ColumnHeader Weknemer;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ListView listView2_keukenOverzicht;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_ViewOrder2;
        private System.Windows.Forms.ListView listView3_keukenoverzicht;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listView4_keukenoverzicht;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView listView5_keukenoverzicht;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView listView6_keukenoverzicht;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView listView7_keukenoverzicht;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ListView listView8_keukenoverzicht;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.Button btn_ViewOrder3;
        private System.Windows.Forms.Button btn_ViewOrder4;
        private System.Windows.Forms.Button btn_ViewOrder5;
        private System.Windows.Forms.Button btn_ViewOrder6;
        private System.Windows.Forms.Button btn_ViewOrder7;
        private System.Windows.Forms.Button btn_ViewOrder8;
        private System.Windows.Forms.ListView listView9_keukenoverzicht;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ListView listView10_keukenoverzicht;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.Button btn_ViewOrdewr10;
        private System.Windows.Forms.Button btn_ViewOrder9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel PNL_keukenoverzicht;
        private System.Windows.Forms.Panel pnl_homekeuken;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_terug;
        private System.Windows.Forms.Button btn_close1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel pnl_OrderItems;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Order_Overzicht_Terug;
        private System.Windows.Forms.ListView listView_OrderItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_OrderItems;
        private System.Windows.Forms.ColumnHeader Tijd;
        private System.Windows.Forms.ColumnHeader MenuItem;
        private System.Windows.Forms.ColumnHeader Status;
    }
}