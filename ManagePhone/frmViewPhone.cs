using ManagePhone.Models.Models;
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
    public partial class frmViewPhone : Form, IPhonesView
    {
        public string Brand { get; set; }

        public string Phone
        {
            get { return txtSearchPhone.Text.Trim(); }
        }

        public IList<ProductModel> ProductList
        {
            set
            {
                var ProductList = value;
                BindingData(ProductList);
            }
        }

        public ProductModel CurProductModel;

        //the presenter
        ViewProductPresenter _viewProductPresenter;

        public frmViewPhone() {
            InitializeComponent();
            _viewProductPresenter = new ViewProductPresenter(this);
        }

        private void BindingData(IList<ProductModel> ProductList)
        {
            dgvListPhone.DataSource = ProductList;
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

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            ProductModel ProductModel = (ProductModel)dgvListPhone.CurrentRow.DataBoundItem;

            _viewProductPresenter.DeleteProduct(ProductModel);
            _viewProductPresenter.LoadProducts();
        }
    }
}
