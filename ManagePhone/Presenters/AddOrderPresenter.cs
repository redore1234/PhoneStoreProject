using ManagePhone.GUI;
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
    public class AddOrderPresenter : Presenter<IAddOrderView>
    {
        public AddOrderPresenter(IAddOrderView view) : base(view)
        {
            LoadProduct();
        }

        //load product list
        public void LoadProduct()
        {
            View.ListProduct = Model.LoadProductList();
        }

        public long AddToCart(ProductModel Phone)
        {
            List<CartItemModel> Cart = (List<CartItemModel>)View.Cart;
            if (Cart == null)
            {
                Cart = new List<CartItemModel>();
            }

            bool IsInCart = false;
            //check if phone already in cart
            foreach (CartItemModel Item in Cart)
            {
                if (Item.ProductID == Phone.ProductID)
                {
                    IsInCart = true;
                    Item.BuyQuantity += 1;
                }
            }

            if (!IsInCart)
            {
                //if phone not in cart
                CartItemModel NewItem = new CartItemModel
                {
                    ProductID = Phone.ProductID,
                    ProductName = Phone.ProductName,
                    Price = Phone.Price,
                    BuyQuantity = 1
                };
                Cart.Add(NewItem);
            }
            View.Cart = Cart;

            //return total price of cart
            long TotalPrice = 0;
            foreach (CartItemModel Item in Cart)
            {
                TotalPrice += Item.Price * Item.BuyQuantity;
            }
            return TotalPrice;
        }

        public void CheckExistCustomer()
        {
            string Phone = View.CustomerPhone;
            CustomerModel Customer = Model.SearchCustomerByPhone(Phone);
            if (Customer == null)
            {
                (new frmAddCustomer()).ShowDialog();
            }
            else
            {
                View.Customer = Customer;
            }
        }

        public void SearchProduct()
        {
            string Name = View.ProductName;
            if (Name.Length != 0)
            {
                View.ListProduct = Model.SearchProducts(Name);
            }
            else
            {
                LoadProduct();
            }
        }
    }
}
