namespace Chapoo1819
{
    partial class LoginUI
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
            this.pnl_Checkout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.pnl_Checkout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Checkout
            // 
            this.pnl_Checkout.Controls.Add(this.btnPay);
            this.pnl_Checkout.Controls.Add(this.txtTotalPaid);
            this.pnl_Checkout.Controls.Add(this.txtEmployeeNumber);
            this.pnl_Checkout.Controls.Add(this.txtTable);
            this.pnl_Checkout.Controls.Add(this.txtComment);
            this.pnl_Checkout.Controls.Add(this.txtTotalPrice);
            this.pnl_Checkout.Controls.Add(this.label5);
            this.pnl_Checkout.Controls.Add(this.label4);
            this.pnl_Checkout.Controls.Add(this.label3);
            this.pnl_Checkout.Controls.Add(this.label2);
            this.pnl_Checkout.Controls.Add(this.label1);
            this.pnl_Checkout.Location = new System.Drawing.Point(0, 31);
            this.pnl_Checkout.Name = "pnl_Checkout";
            this.pnl_Checkout.Size = new System.Drawing.Size(870, 445);
            this.pnl_Checkout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total price: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comment (optional): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Table: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee number: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total paid: ";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(184, 48);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPrice.TabIndex = 5;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(184, 78);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(100, 22);
            this.txtComment.TabIndex = 6;
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(184, 108);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(100, 22);
            this.txtTable.TabIndex = 7;
            this.txtTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(184, 136);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeNumber.TabIndex = 8;
            this.txtEmployeeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(184, 165);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPaid.TabIndex = 9;
            this.txtTotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(340, 139);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(152, 48);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "&Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 474);
            this.Controls.Add(this.pnl_Checkout);
            this.Name = "LoginUI";
            this.Text = "Form1";
            this.pnl_Checkout.ResumeLayout(false);
            this.pnl_Checkout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Checkout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnPay;
    }
}

