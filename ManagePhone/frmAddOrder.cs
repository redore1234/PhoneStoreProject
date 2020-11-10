using ManagePhone.GUI;
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

namespace ManagePhone
{
    public partial class frmAddOrder : Form, IAddOrderView
    {
        public CustomerModel Customer { get; set; }
        public string CustomerPhone => txtCustomerPhone.Text;
        public string ProductName => txtProductName.Text;

        public IList<ProductModel> ListProduct 
        { 
            set 
            {
                LoadProduct((List<ProductModel>) value);
            } 
        }

        public IList<CartItemModel> Cart
        {
            get
            {
                return (List<CartItemModel>) dgvCart.DataSource;
            }
            set
            {
                LoadCart((List<CartItemModel>)value);
            }
        }

        //the presenter
        AddOrderPresenter _addOrderPresenter;
        public frmAddOrder()
        {
            InitializeComponent();
            _addOrderPresenter = new AddOrderPresenter(this);
        }

        private void LoadProduct(List<ProductModel> ListProduct)
        {
            dgvSearchProduct.DataSource = ListProduct;
        }

        private void LoadCart(List<CartItemModel> Cart)
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = Cart;
            dgvCart.Update();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            _addOrderPresenter.CheckExistCustomer();
            if (Customer != null)
            {
                pbSuccess.Image = ManagePhone.Properties.Resources.tick;
                txtProductName.Enabled = true;
            }
        }

        private void pbAddToCart_Click(object sender, EventArgs e)
        {
            ProductModel Phone = (ProductModel) dgvSearchProduct.CurrentRow.DataBoundItem;
            long TotalPrice = _addOrderPresenter.AddToCart(Phone);
            lbTotalPrice.Text = "Total: " + TotalPrice.ToString() + " VND";
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            _addOrderPresenter.SearchProduct();
        }
    }
}
