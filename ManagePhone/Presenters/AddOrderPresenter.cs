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
    public class AddOrderPresenter : Presenter<IAddOrder>
    {
        public AddOrderPresenter(IAddOrder view) : base(view)
        {
            LoadProduct();
        }

        //load product list
        public void LoadProduct()
        {
            View.ListProduct = Model.LoadProductList();
        }

        public void AddToCart(ProductModel Phone)
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
            View.TotalPrice = TotalPrice;
        }

        public void CheckExistCustomer()
        {
            string Phone = View.CustomerPhone;
            CustomerModel Customer = Model.SearchCustomerByPhone(Phone);
            if (Customer == null)
            {
                (new frmAddCustomer()).ShowDialog();
                View.CustomerID = 0;
            }
            else
            {
                View.CustomerID = Customer.CustomerID;
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

        public void UpdateBuyQuantity(CartItemModel SelectedItem, int NewQuantity)
        {
            List<CartItemModel> Cart = (List<CartItemModel>)View.Cart;
            long TotalPrice = 0;
            foreach (CartItemModel Item in Cart)
            {
                if (Item.ProductID == SelectedItem.ProductID)
                {
                    Item.BuyQuantity = NewQuantity;
                }
                TotalPrice += Item.Price * Item.BuyQuantity;
            }
            View.Cart = Cart;
            View.TotalPrice = TotalPrice;
        }

        public void DeleteFromCart(CartItemModel RemoveItem)
        {
            List<CartItemModel> Cart = (List<CartItemModel>)View.Cart;
            long TotalPrice = 0;
            foreach (CartItemModel Item in Cart)
            {
                if (Item.ProductID == RemoveItem.ProductID)
                {
                    RemoveItem = Item;
                }
            }
            Cart.Remove(RemoveItem);

            if (Cart.Count == 0)
            {
                Cart = null;
            }
            View.Cart = Cart;
            View.TotalPrice = TotalPrice;
        }

        public void Checkout(string empID)
        {
            //get cart
            List<CartItemModel> Cart = (List<CartItemModel>)View.Cart;
            if (Cart != null)
            {
                //check valid quantity (buy less than store)
                bool IsValidQuantity = CheckQuanityOfProducts(Cart);
                if (!IsValidQuantity)
                {
                    return;
                }

                //write order
                int CustomerID = View.CustomerID;
                long TotalPrice = View.TotalPrice;

                OrderModel Order = new OrderModel
                {
                    CustomerID = CustomerID,
                    EmployeeID = empID,
                    TotalPrice = TotalPrice
                };

                bool WriteOrderSuccessfully = Model.AddOrder(Order);
                if (WriteOrderSuccessfully)
                {
                    Order = Model.GetLastestOrder(CustomerID);
                    string OrderID = Order.OrderID;

                    foreach (CartItemModel Item in Cart)
                    {
                        //write order detail
                        int ProductID = Item.ProductID;
                        int Quantity = Item.BuyQuantity;
                        long Price = Item.BuyQuantity * Item.Price;
                        Model.AddOrderDetail(OrderID, ProductID, Quantity, Price);

                        //update quantity in storage
                        ProductModel ProductInStorage = Model.GetProduct(ProductID);
                        int NewQuantity = ProductInStorage.Quantity - Quantity;
                        Model.UpdateProductQuantity(ProductID, NewQuantity);
                    }
                }
                MessageBox.Show("Checkout successfully", "Notice");
                //Delete Cart
                View.Cart = null;
                //update total money of cart
                View.TotalPrice = 0;
                //update list product
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Cart is empty!!", "Notice");
            }
            
        }

        private bool CheckQuanityOfProducts(List<CartItemModel> Cart)
        {
            foreach (CartItemModel Item in Cart)
            {
                int ProductID = Item.ProductID;
                ProductModel ProductInStorage = Model.GetProduct(ProductID);

                if (Item.BuyQuantity > ProductInStorage.Quantity)
                {
                    MessageBox.Show(Item.ProductName + " only has " + ProductInStorage.Quantity + " left!", "Notice");
                    return false;
                }
            }
            return true;
        }
    }
}