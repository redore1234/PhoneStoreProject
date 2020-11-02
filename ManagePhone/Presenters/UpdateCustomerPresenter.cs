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
    public class UpdateCustomerPresenter : Presenter<IUpdateCustomerView>
    {
        //Constructor
        public UpdateCustomerPresenter(IUpdateCustomerView view) : base(view)
        {
        }

        //Update a customer
        public void UpdateCustomer()
        {
            int CusID = View.CustomerID;
            string CusName = View.CustomerName;
            DateTime CusDOB = View.DOB;
            string CusPhone = View.Phone;
            string CusAddress = View.Address;

            CustomerModel customer = new CustomerModel()
            {
                CustomerID = CusID,
                Name = CusName,
                DOB = CusDOB,
                Phone = CusPhone,
                Address = CusAddress
            };

            bool UpdateSucessfully = Model.UpdateCustomer(customer);
            if (UpdateSucessfully)
            {
                MessageBox.Show("Customer Updated!", "Notify");
            } 
            else
            {
                MessageBox.Show("Update Failed", "Error");
            }
        }
    }
}
