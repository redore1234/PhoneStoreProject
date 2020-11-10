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

        //Load customer list
        public void LoadCustomers()
        {
            View.CustomerList = Model.LoadCustomerList();
        }

        public void UpdateCustomer(CustomerModel customer)
        {
            (new frmUpdateCustomer(customer)).ShowDialog();
        }

        public void SearchCustomer()
        {
            string Name = View.CustomerName;
            string Phone = View.Phone;
            View.CustomerList = Model.SearchCustomer(Name, Phone);
        }
    }
}
