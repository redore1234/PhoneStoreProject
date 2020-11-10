using ManagePhone.Models.Models;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone.Presenters
{
    public class ViewProductPresenter : Presenter<IPhonesView>
    {
        //constructor
        public ViewProductPresenter(IPhonesView view) : base(view)
        {
            LoadProducts();
        }

        //Delete the product
        public void DeleteProduct(ProductModel SelectedProduct)
        {
            int ProID = SelectedProduct.ProductID;

            bool result = Model.DeleteProduct(ProID);

            if (result)
            {
                MessageBox.Show("Product Deleted!", "Notify");
            }
            else
            {
                MessageBox.Show("Delete Product Fail!", "Notify");
            }
        }

        public void UpdateProduct(ProductModel Model)
        {
            frmUpdatePhone frmUpdatePhone = new frmUpdatePhone(Model);
            frmUpdatePhone.ShowDialog();
            LoadProducts();
        }

        public void SearchProduct(string ProductName)
        {
            View.ProductList = Model.SearchProducts(ProductName);
        }

        public void LoadProducts()
        {
            View.ProductList = Model.LoadProductList();
        }

        public void SearchProductsByNameOrBrand()
        {
            string ProductName = View.Phone;
            string Brand = View.Brand;
            View.ProductList = Model.SearchProductsByNameOrBrand(ProductName, Brand);
        }
    }
}
