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
    public class AddCustomerPresenter : Presenter<IAddCustomerView>
    {
        //Constructor
        public AddCustomerPresenter(IAddCustomerView view) : base(view)
        {
        }

        //perform add customer
        public void AddCustomer()
        {
            string CusName = View.CustomerName;
            DateTime CusDOB = View.DOB;
            string CusPhone = View.Phone;
            string CusAddress = View.Address;

            CustomerModel customer = new CustomerModel()
            {
                Name = CusName,
                DOB = CusDOB,
                Phone = CusPhone,
                Address = CusAddress
            };

            bool addedSuccessfully = Model.AddCustomer(customer);

            if (addedSuccessfully)
            {
                MessageBox.Show("Customer Added!", "Notify");
            }
            else
            {
                MessageBox.Show("Add Failed!", "Error");
            }
        }
    }
}
