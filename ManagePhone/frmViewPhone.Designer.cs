namespace ManagePhone {
    partial class frmViewPhone {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPhone));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdatePhone = new System.Windows.Forms.Button();
            this.btnDeletePhone = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.dgvListPhone = new System.Windows.Forms.DataGridView();
            this.btnCancelPhone = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnShowImage = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.btnUpdatePhone, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDeletePhone, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnShowImage, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(188, 140);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 45);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // btnUpdatePhone
            // 
            this.btnUpdatePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatePhone.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePhone.Location = new System.Drawing.Point(2, 10);
            this.btnUpdatePhone.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatePhone.Name = "btnUpdatePhone";
            this.btnUpdatePhone.Size = new System.Drawing.Size(132, 24);
            this.btnUpdatePhone.TabIndex = 4;
            this.btnUpdatePhone.Text = "Update";
            this.btnUpdatePhone.UseVisualStyleBackColor = true;
            this.btnUpdatePhone.Click += new System.EventHandler(this.btnUpdatePhone_Click);
            // 
            // btnDeletePhone
            // 
            this.btnDeletePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePhone.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePhone.Location = new System.Drawing.Point(138, 10);
            this.btnDeletePhone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletePhone.Name = "btnDeletePhone";
            this.btnDeletePhone.Size = new System.Drawing.Size(132, 24);
            this.btnDeletePhone.TabIndex = 5;
            this.btnDeletePhone.Text = "Delete";
            this.btnDeletePhone.UseVisualStyleBackColor = true;
            this.btnDeletePhone.Click += new System.EventHandler(this.btnDeletePhone_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68917F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.31084F));
            this.tableLayoutPanel1.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label27, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBrand, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(188, 41);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 81);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(2, 10);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(97, 19);
            this.label28.TabIndex = 7;
            this.label28.Text = "Brand:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearchName.Location = new System.Drawing.Point(103, 47);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(305, 26);
            this.txtSearchName.TabIndex = 10;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(2, 51);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 19);
            this.label27.TabIndex = 9;
            this.label27.Text = "Name:";
            // 
            // txtBrand
            // 
            this.txtBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrand.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBrand.Location = new System.Drawing.Point(103, 7);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(305, 26);
            this.txtBrand.TabIndex = 11;
            this.txtBrand.TextChanged += new System.EventHandler(this.txtBrand_TextChanged);
            // 
            // dgvListPhone
            // 
            this.dgvListPhone.AllowUserToAddRows = false;
            this.dgvListPhone.AllowUserToDeleteRows = false;
            this.dgvListPhone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPhone.Location = new System.Drawing.Point(18, 209);
            this.dgvListPhone.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListPhone.MultiSelect = false;
            this.dgvListPhone.Name = "dgvListPhone";
            this.dgvListPhone.ReadOnly = true;
            this.dgvListPhone.RowHeadersWidth = 51;
            this.dgvListPhone.RowTemplate.Height = 24;
            this.dgvListPhone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListPhone.Size = new System.Drawing.Size(726, 358);
            this.dgvListPhone.TabIndex = 17;
            // 
            // btnCancelPhone
            // 
            this.btnCancelPhone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelPhone.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPhone.Location = new System.Drawing.Point(641, 11);
            this.btnCancelPhone.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelPhone.Name = "btnCancelPhone";
            this.btnCancelPhone.Size = new System.Drawing.Size(108, 32);
            this.btnCancelPhone.TabIndex = 6;
            this.btnCancelPhone.Text = "Cancel";
            this.btnCancelPhone.UseVisualStyleBackColor = true;
            this.btnCancelPhone.Click += new System.EventHandler(this.btnCancelPhone_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 32000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Phone\'s Information";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnShowImage
            // 
            this.btnShowImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowImage.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowImage.Location = new System.Drawing.Point(274, 10);
            this.btnShowImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(132, 24);
            this.btnShowImage.TabIndex = 6;
            this.btnShowImage.Text = "Show Image";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // frmViewPhone
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancelPhone;
            this.ClientSize = new System.Drawing.Size(760, 577);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvListPhone);
            this.Controls.Add(this.btnCancelPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmViewPhone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Phone";
            this.Load += new System.EventHandler(this.frmViewPhone_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dgvListPhone;
        private System.Windows.Forms.Button btnUpdatePhone;
        private System.Windows.Forms.Button btnDeletePhone;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancelPhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Button btnShowImage;
    }
}