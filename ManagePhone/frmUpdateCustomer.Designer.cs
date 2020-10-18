namespace ManagePhone {
    partial class frmUpdateCustomer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCustomerMoney = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCustomerPoint = new System.Windows.Forms.TextBox();
            this.cbCustomerRank = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.69511F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.30489F));
            this.tableLayoutPanel3.Controls.Add(this.txtCustomerName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label22, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtCustomerPhone, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCustomerAddress, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtCustomerMoney, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label26, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.cbCustomerRank, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label25, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtCustomerPoint, 1, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(70, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(817, 461);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCustomerName.Location = new System.Drawing.Point(155, 23);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(659, 30);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(146, 24);
            this.label23.TabIndex = 0;
            this.label23.Text = "Name:";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 254);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "Money:";
            // 
            // txtCustomerMoney
            // 
            this.txtCustomerMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerMoney.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCustomerMoney.Location = new System.Drawing.Point(155, 251);
            this.txtCustomerMoney.Name = "txtCustomerMoney";
            this.txtCustomerMoney.Size = new System.Drawing.Size(659, 30);
            this.txtCustomerMoney.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "Address:";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 24);
            this.label22.TabIndex = 0;
            this.label22.Text = "Phone:";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCustomerAddress.Location = new System.Drawing.Point(155, 175);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(659, 30);
            this.txtCustomerAddress.TabIndex = 1;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerPhone.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCustomerPhone.Location = new System.Drawing.Point(155, 99);
            this.txtCustomerPhone.Mask = "(9999) 000-000";
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(659, 30);
            this.txtCustomerPhone.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 408);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(146, 24);
            this.label25.TabIndex = 0;
            this.label25.Text = "Point:";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 330);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(146, 24);
            this.label26.TabIndex = 0;
            this.label26.Text = "Rank:";
            // 
            // txtCustomerPoint
            // 
            this.txtCustomerPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerPoint.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCustomerPoint.Location = new System.Drawing.Point(155, 405);
            this.txtCustomerPoint.Name = "txtCustomerPoint";
            this.txtCustomerPoint.Size = new System.Drawing.Size(659, 30);
            this.txtCustomerPoint.TabIndex = 1;
            // 
            // cbCustomerRank
            // 
            this.cbCustomerRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCustomerRank.Font = new System.Drawing.Font("Arial", 12F);
            this.cbCustomerRank.FormattingEnabled = true;
            this.cbCustomerRank.Location = new System.Drawing.Point(155, 326);
            this.cbCustomerRank.Name = "cbCustomerRank";
            this.cbCustomerRank.Size = new System.Drawing.Size(659, 31);
            this.cbCustomerRank.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnUpdateCustomer);
            this.panel4.Location = new System.Drawing.Point(604, 491);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 55);
            this.panel4.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(178, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(32, 16);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(93, 29);
            this.btnUpdateCustomer.TabIndex = 3;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 558);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "frmUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Customer";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCustomerMoney;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.MaskedTextBox txtCustomerPhone;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtCustomerPoint;
        private System.Windows.Forms.ComboBox cbCustomerRank;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateCustomer;
    }
}