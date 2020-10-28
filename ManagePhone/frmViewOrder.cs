using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone {
    public partial class frmViewOrder : Form {
        public frmViewOrder() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmViewOrderDetails viewOrderDetails = new frmViewOrderDetails();
            this.Hide();
            viewOrderDetails.ShowDialog();
            //this.Close();
        }
    }
}
