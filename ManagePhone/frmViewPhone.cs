using ManagePhone.Models.Models;
using ManagePhone.Presenters;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagePhone
{
    public partial class frmViewPhone : Form, IPhonesView
    {
        public string Brand => txtBrand.Text.Trim();

        public string Phone => txtSearchName.Text.Trim();

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
        private ViewProductPresenter _viewProductPresenter;

        public frmViewPhone()
        {
            InitializeComponent();
            _viewProductPresenter = new ViewProductPresenter(this);
        }

        private void BindingData(IList<ProductModel> ProductList)
        {
            dgvListPhone.DataSource = ProductList;
        }

        private void btnCancelPhone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            ProductModel ProductModel = (ProductModel)dgvListPhone.CurrentRow.DataBoundItem;

            _viewProductPresenter.UpdateProduct(ProductModel);
            _viewProductPresenter.LoadProducts();
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            ProductModel ProductModel = (ProductModel)dgvListPhone.CurrentRow.DataBoundItem;

            _viewProductPresenter.DeleteProduct(ProductModel);
            _viewProductPresenter.LoadProducts();
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Brand) || !string.IsNullOrEmpty(Phone))
            {
                _viewProductPresenter.SearchProductsByNameOrBrand();
            } else
            {
                _viewProductPresenter.LoadProducts();
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Brand) || !string.IsNullOrEmpty(Phone))
            {
                _viewProductPresenter.SearchProductsByNameOrBrand();
            } else
            {
                _viewProductPresenter.LoadProducts();
            }
        }
    }
}