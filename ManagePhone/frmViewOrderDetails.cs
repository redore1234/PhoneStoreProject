using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone
{
    public partial class frmViewOrderDetails : Form
    {
        public frmViewOrderDetails()
        {
            InitializeComponent();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmViewOrder()).ShowDialog();
            this.Close();
        }
    }
}
