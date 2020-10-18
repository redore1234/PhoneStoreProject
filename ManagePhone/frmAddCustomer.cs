using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone.GUI {
    public partial class frmAddCustomer : Form {
        public frmAddCustomer() {
            InitializeComponent();
            this.dtCustomerDOB.Format = DateTimePickerFormat.Custom;
            dtCustomerDOB.CustomFormat = "dd-MM-yyyy";
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
