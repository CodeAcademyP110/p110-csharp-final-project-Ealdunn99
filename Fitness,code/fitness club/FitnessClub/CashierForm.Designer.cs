namespace FitnessClub
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPanelLabel = new System.Windows.Forms.Label();
            this.pnlOrderItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.txtCusLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtCusLastName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblPanelLabel);
            this.panel1.Controls.Add(this.pnlOrderItems);
            this.panel1.Controls.Add(this.btnFinishOrder);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtItemPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbItems);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCategories);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 479);
            this.panel1.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.Location = new System.Drawing.Point(264, 44);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(231, 31);
            this.txtCustomerName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(259, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Customer Name";
            // 
            // lblPanelLabel
            // 
            this.lblPanelLabel.AutoSize = true;
            this.lblPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelLabel.ForeColor = System.Drawing.Color.White;
            this.lblPanelLabel.Location = new System.Drawing.Point(172, 281);
            this.lblPanelLabel.Name = "lblPanelLabel";
            this.lblPanelLabel.Size = new System.Drawing.Size(135, 25);
            this.lblPanelLabel.TabIndex = 20;
            this.lblPanelLabel.Text = "Order details";
            this.lblPanelLabel.Visible = false;
            // 
            // pnlOrderItems
            // 
            this.pnlOrderItems.BackColor = System.Drawing.Color.LightGray;
            this.pnlOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderItems.Location = new System.Drawing.Point(9, 309);
            this.pnlOrderItems.Name = "pnlOrderItems";
            this.pnlOrderItems.Size = new System.Drawing.Size(486, 145);
            this.pnlOrderItems.TabIndex = 18;
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFinishOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinishOrder.Location = new System.Drawing.Point(264, 210);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(231, 68);
            this.btnFinishOrder.TabIndex = 17;
            this.btnFinishOrder.Text = "Finish Order";
            this.btnFinishOrder.UseVisualStyleBackColor = false;
            this.btnFinishOrder.Click += new System.EventHandler(this.BtnFinishOrder_Click_1);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddItem.Location = new System.Drawing.Point(9, 210);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(239, 68);
            this.btnAddItem.TabIndex = 16;
            this.btnAddItem.Text = "Add Item to Order";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click_1);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.Location = new System.Drawing.Point(198, 166);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(169, 31);
            this.txtTotalPrice.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(174, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Price";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemPrice.ForeColor = System.Drawing.Color.Black;
            this.txtItemPrice.Location = new System.Drawing.Point(9, 166);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.ReadOnly = true;
            this.txtItemPrice.Size = new System.Drawing.Size(183, 31);
            this.txtItemPrice.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // cmbItems
            // 
            this.cmbItems.BackColor = System.Drawing.Color.DimGray;
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItems.ForeColor = System.Drawing.Color.White;
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(17, 104);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(231, 33);
            this.cmbItems.TabIndex = 8;
            this.cmbItems.SelectedIndexChanged += new System.EventHandler(this.CmbItems_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select item";
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.Color.DimGray;
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategories.ForeColor = System.Drawing.Color.White;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(17, 42);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(231, 33);
            this.cmbCategories.TabIndex = 6;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.CmbCategories_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select category";
            // 
            // txtWelcome
            // 
            this.txtWelcome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWelcome.Location = new System.Drawing.Point(0, 0);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(507, 70);
            this.txtWelcome.TabIndex = 3;
            this.txtWelcome.Text = "Cashier";
            this.txtWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCusLastName
            // 
            this.txtCusLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusLastName.ForeColor = System.Drawing.Color.Black;
            this.txtCusLastName.Location = new System.Drawing.Point(264, 104);
            this.txtCusLastName.Name = "txtCusLastName";
            this.txtCusLastName.Size = new System.Drawing.Size(231, 31);
            this.txtCusLastName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(259, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cus. Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(373, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 31);
            this.textBox1.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(368, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Customer Id";
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(507, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            this.Load += new System.EventHandler(this.CashierForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPanelLabel;
        private System.Windows.Forms.FlowLayoutPanel pnlOrderItems;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.TextBox txtCusLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}