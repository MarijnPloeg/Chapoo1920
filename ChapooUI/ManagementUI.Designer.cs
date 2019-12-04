namespace Chapoo1819
{
    partial class ManagementUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeMenu = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.pnl_Stock = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangeMenu);
            this.panel1.Controls.Add(this.btnRevenue);
            this.panel1.Controls.Add(this.btnEmployeeManagement);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnTakeOrder);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 751);
            this.panel1.TabIndex = 0;
            // 
            // btnChangeMenu
            // 
            this.btnChangeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMenu.Location = new System.Drawing.Point(11, 640);
            this.btnChangeMenu.Name = "btnChangeMenu";
            this.btnChangeMenu.Size = new System.Drawing.Size(558, 94);
            this.btnChangeMenu.TabIndex = 4;
            this.btnChangeMenu.Text = "Change menu";
            this.btnChangeMenu.UseVisualStyleBackColor = true;
            // 
            // btnRevenue
            // 
            this.btnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.Location = new System.Drawing.Point(11, 524);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(558, 94);
            this.btnRevenue.TabIndex = 3;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManagement.Location = new System.Drawing.Point(11, 410);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(558, 94);
            this.btnEmployeeManagement.TabIndex = 2;
            this.btnEmployeeManagement.Text = "Employee management";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(11, 298);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(558, 94);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeOrder.Location = new System.Drawing.Point(11, 187);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(558, 94);
            this.btnTakeOrder.TabIndex = 0;
            this.btnTakeOrder.Text = "Take order / change existing order";
            this.btnTakeOrder.UseVisualStyleBackColor = true;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // pnl_Stock
            // 
            this.pnl_Stock.Location = new System.Drawing.Point(1, 1);
            this.pnl_Stock.Name = "pnl_Stock";
            this.pnl_Stock.Size = new System.Drawing.Size(579, 751);
            this.pnl_Stock.TabIndex = 1;
            // 
            // ManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Stock);
            this.Name = "ManagementUI";
            this.Text = "BeheerUI";
            this.Load += new System.EventHandler(this.ManagementUI_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangeMenu;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Panel pnl_Stock;
    }
}