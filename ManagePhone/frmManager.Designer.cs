namespace ManagePhone {
    partial class frmManager {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbViewPhone = new System.Windows.Forms.PictureBox();
            this.pbAddPhone = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbViewEmployee = new System.Windows.Forms.PictureBox();
            this.pbAddEmployee = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pbAddOrder = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbViewOrder = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbViewCustomer = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPhone)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEmployee)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewOrder)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewCustomer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 32000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(621, 9);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 31);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.pbViewPhone);
            this.panel8.Controls.Add(this.pbAddPhone);
            this.panel8.Location = new System.Drawing.Point(355, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(342, 253);
            this.panel8.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(138, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone";
            // 
            // pbViewPhone
            // 
            this.pbViewPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewPhone.Image = ((System.Drawing.Image)(resources.GetObject("pbViewPhone.Image")));
            this.pbViewPhone.Location = new System.Drawing.Point(221, 98);
            this.pbViewPhone.Name = "pbViewPhone";
            this.pbViewPhone.Size = new System.Drawing.Size(98, 91);
            this.pbViewPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbViewPhone.TabIndex = 23;
            this.pbViewPhone.TabStop = false;
            this.toolTip1.SetToolTip(this.pbViewPhone, "View Phones");
            this.pbViewPhone.Click += new System.EventHandler(this.pbViewPhone_Click);
            // 
            // pbAddPhone
            // 
            this.pbAddPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddPhone.Image = ((System.Drawing.Image)(resources.GetObject("pbAddPhone.Image")));
            this.pbAddPhone.Location = new System.Drawing.Point(33, 94);
            this.pbAddPhone.Name = "pbAddPhone";
            this.pbAddPhone.Size = new System.Drawing.Size(100, 99);
            this.pbAddPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddPhone.TabIndex = 22;
            this.pbAddPhone.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAddPhone, "Add Phone");
            this.pbAddPhone.Click += new System.EventHandler(this.pbAddPhone_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.pbViewEmployee);
            this.panel7.Controls.Add(this.pbAddEmployee);
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(342, 253);
            this.panel7.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(100, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
            // 
            // pbViewEmployee
            // 
            this.pbViewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("pbViewEmployee.Image")));
            this.pbViewEmployee.Location = new System.Drawing.Point(207, 94);
            this.pbViewEmployee.Name = "pbViewEmployee";
            this.pbViewEmployee.Size = new System.Drawing.Size(108, 119);
            this.pbViewEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbViewEmployee.TabIndex = 22;
            this.pbViewEmployee.TabStop = false;
            this.toolTip1.SetToolTip(this.pbViewEmployee, "View Employees");
            this.pbViewEmployee.Click += new System.EventHandler(this.pbViewEmployee_Click);
            // 
            // pbAddEmployee
            // 
            this.pbAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("pbAddEmployee.Image")));
            this.pbAddEmployee.Location = new System.Drawing.Point(25, 108);
            this.pbAddEmployee.Name = "pbAddEmployee";
            this.pbAddEmployee.Size = new System.Drawing.Size(78, 77);
            this.pbAddEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddEmployee.TabIndex = 21;
            this.pbAddEmployee.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAddEmployee, "Add Employee");
            this.pbAddEmployee.Click += new System.EventHandler(this.pbAddEmployee_Click);
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.Controls.Add(this.pbAddOrder);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.pbViewOrder);
            this.panel10.Location = new System.Drawing.Point(355, 266);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(342, 254);
            this.panel10.TabIndex = 27;
            // 
            // pbAddOrder
            // 
            this.pbAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddOrder.Image = global::ManagePhone.Properties.Resources.addordericon;
            this.pbAddOrder.Location = new System.Drawing.Point(39, 110);
            this.pbAddOrder.Name = "pbAddOrder";
            this.pbAddOrder.Size = new System.Drawing.Size(89, 89);
            this.pbAddOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddOrder.TabIndex = 25;
            this.pbAddOrder.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAddOrder, "Add Order");
            this.pbAddOrder.Click += new System.EventHandler(this.pbAddOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(133, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Order";
            // 
            // pbViewOrder
            // 
            this.pbViewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewOrder.Image = global::ManagePhone.Properties.Resources.vieworder;
            this.pbViewOrder.Location = new System.Drawing.Point(229, 110);
            this.pbViewOrder.Name = "pbViewOrder";
            this.pbViewOrder.Size = new System.Drawing.Size(91, 89);
            this.pbViewOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbViewOrder.TabIndex = 24;
            this.pbViewOrder.TabStop = false;
            this.toolTip1.SetToolTip(this.pbViewOrder, "View Orders");
            this.pbViewOrder.Click += new System.EventHandler(this.pbViewOrder_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.pbViewCustomer);
            this.panel9.Location = new System.Drawing.Point(5, 266);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(342, 254);
            this.panel9.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(98, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer";
            // 
            // pbViewCustomer
            // 
            this.pbViewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbViewCustomer.Image")));
            this.pbViewCustomer.Location = new System.Drawing.Point(113, 110);
            this.pbViewCustomer.Name = "pbViewCustomer";
            this.pbViewCustomer.Size = new System.Drawing.Size(102, 89);
            this.pbViewCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbViewCustomer.TabIndex = 23;
            this.pbViewCustomer.TabStop = false;
            this.toolTip1.SetToolTip(this.pbViewCustomer, "View Customers");
            this.pbViewCustomer.Click += new System.EventHandler(this.pbViewCustomer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel10, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 525);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // frmManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(727, 584);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPhone)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEmployee)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewOrder)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewCustomer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbViewPhone;
        private System.Windows.Forms.PictureBox pbAddPhone;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbViewEmployee;
        private System.Windows.Forms.PictureBox pbAddEmployee;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbViewCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbAddOrder;
        private System.Windows.Forms.PictureBox pbViewOrder;
    }
}