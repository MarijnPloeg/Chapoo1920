namespace Chapoo1819
{
    partial class AfrekenenUI
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
            this.ContantButton = new System.Windows.Forms.Button();
            this.PinButton = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.listViewOrderGeld = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ContantButton
            // 
            this.ContantButton.Location = new System.Drawing.Point(35, 232);
            this.ContantButton.Name = "ContantButton";
            this.ContantButton.Size = new System.Drawing.Size(282, 79);
            this.ContantButton.TabIndex = 0;
            this.ContantButton.Text = "Contant";
            this.ContantButton.UseVisualStyleBackColor = true;
            // 
            // PinButton
            // 
            this.PinButton.Location = new System.Drawing.Point(318, 232);
            this.PinButton.Name = "PinButton";
            this.PinButton.Size = new System.Drawing.Size(282, 79);
            this.PinButton.TabIndex = 1;
            this.PinButton.Text = "Pin";
            this.PinButton.UseVisualStyleBackColor = true;
            // 
            // listViewOrders
            // 
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(35, 12);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(565, 158);
            this.listViewOrders.TabIndex = 2;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            // 
            // listViewOrderGeld
            // 
            this.listViewOrderGeld.HideSelection = false;
            this.listViewOrderGeld.Location = new System.Drawing.Point(35, 167);
            this.listViewOrderGeld.Name = "listViewOrderGeld";
            this.listViewOrderGeld.Size = new System.Drawing.Size(565, 59);
            this.listViewOrderGeld.TabIndex = 3;
            this.listViewOrderGeld.UseCompatibleStateImageBehavior = false;
            // 
            // AfrekenenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 323);
            this.Controls.Add(this.listViewOrderGeld);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.PinButton);
            this.Controls.Add(this.ContantButton);
            this.Name = "AfrekenenUI";
            this.Text = "AfrekenenUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ContantButton;
        private System.Windows.Forms.Button PinButton;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ListView listViewOrderGeld;
    }
}