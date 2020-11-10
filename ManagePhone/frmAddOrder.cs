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
        private string EmpID;
        public int CustomerID { get; set; }
        public string CustomerPhone => txtCustomerPhone.Text;
        public string PhoneName => txtProductName.Text;

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

        public long TotalPrice 
        { 
            get => long.Parse(lbTotalPrice.Text.Replace("Total (VND): ", ""));
            set => lbTotalPrice.Text = "Total (VND): " + value.ToString(); 
        }

        //the presenter
        AddOrderPresenter _addOrderPresenter;
        public frmAddOrder()
        {
            InitializeComponent();
            _addOrderPresenter = new AddOrderPresenter(this);
        }

        public frmAddOrder(string EmpID) : this()
        {
            this.EmpID = EmpID;
        }

        private void LoadProduct(List<ProductModel> ListProduct)
        {
            dgvSearchProduct.DataSource = null;
            dgvSearchProduct.DataSource = ListProduct;
            dgvSearchProduct.Update();
        }

        private void LoadCart(List<CartItemModel> Cart)
        {
            dgvCart.DataSource = null;
            if (Cart != null) 
            {
                dgvCart.DataSource = Cart;
                txtBuyQuantity.DataBindings.Clear();
                txtBuyQuantity.DataBindings.Add("Text", Cart, "BuyQuantity");

                txtBuyQuantity.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                txtBuyQuantity.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            
            dgvCart.Update();
        }

        private void ClearBinding()
        {
            txtBuyQuantity.DataBindings.Clear();
            txtBuyQuantity.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            _addOrderPresenter.CheckExistCustomer();
            if (CustomerID != 0)
            {
                pbSuccess.Image = ManagePhone.Properties.Resources.tick;
                txtProductName.Enabled = true;
                pbAddToCart.Enabled = true;
                btnCheckOut.Enabled = true;
            }
            else
            {
                pbSuccess.Image = null;
                txtProductName.Enabled = false;
                pbAddToCart.Enabled = false;
                btnCheckOut.Enabled = false;
            }
        }

        private void pbAddToCart_Click(object sender, EventArgs e)
        {
            ProductModel Phone = (ProductModel) dgvSearchProduct.CurrentRow.DataBoundItem;
            ClearBinding();
            _addOrderPresenter.AddToCart(Phone);
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            _addOrderPresenter.SearchProduct();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CartItemModel SelectedItem = (CartItemModel)dgvCart.CurrentRow.DataBoundItem;
            int NewQuantity = int.Parse(txtBuyQuantity.Text);
            ClearBinding();
            _addOrderPresenter.UpdateBuyQuantity(SelectedItem , NewQuantity);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CartItemModel SelectedItem = (CartItemModel)dgvCart.CurrentRow.DataBoundItem;
            ClearBinding();
            _addOrderPresenter.DeleteFromCart(SelectedItem);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            ClearBinding();
            _addOrderPresenter.Checkout(EmpID);
        }
    }
}
