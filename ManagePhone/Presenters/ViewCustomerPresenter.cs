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
    public class ViewCustomerPresenter : Presenter<ICustomersView>
    {
        //constructor
        public ViewCustomerPresenter(ICustomersView view) : base(view)
        {
            LoadCustomers();
        }

        //Delete a customer
        public void DeleteCustomer()
        {
            int CusID = View.CustomerID;

            bool DeletedSuccessfully = Model.DeleteCustomer(CusID);
            if (DeletedSuccessfully)
            {
                MessageBox.Show("Customer Deleted!", "Notify");
            }
        }

        //Load customer list
        public void LoadCustomers()
        {
            View.CustomerList = Model.LoadCustomerList();
        }
    }
}
