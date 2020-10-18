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
    public partial class frmViewPhone : Form {
        public frmViewPhone() {
            InitializeComponent();
        }

        private void btnCancelPhone_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnUpdatePhone_Click(object sender, EventArgs e) {
            frmUpdatePhone updatePhone = new frmUpdatePhone();
            this.Hide();
            updatePhone.ShowDialog();
            this.Show();
        }
    }
}
