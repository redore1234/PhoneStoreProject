using ManagePhone.Presenters;
using ManagePhone.Views;
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
    public partial class frmCheckout : Form, ICheckoutView
    {
        public long Total 
        { 
            get => long.Parse(txtTotal.Text); 
            set => txtTotal.Text = value.ToString(); 
        }

        public long Cash => long.Parse(txtCash.Text);

        public long Charge 
        { 
            set => txtCharge.Text = value.ToString(); 
        }

        //the presenter
        CheckoutPresenter _checkoutPresenter;
        public frmCheckout() {
            InitializeComponent();
            _checkoutPresenter = new CheckoutPresenter(this);
        }

        public frmCheckout(long Price) : this()
        {
            Total = Price;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            bool IsValidCash = _checkoutPresenter.CalculateCharge();
            if (IsValidCash)
            {
                btnFinish.Enabled = true;
            }
            else
            {
                txtCharge.Text = "";
                btnFinish.Enabled = false;
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Key = e.KeyChar;
            int BackSpace = 8;
            if (Char.IsDigit(Key) || Char.IsControl(Key) || Key == BackSpace)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
