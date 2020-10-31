using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Presenters
{
    public class ViewCustomerPresenter : Presenter<ICustomersView>
    {
        //constructor
        public ViewCustomerPresenter(ICustomersView view) : base(view)
        {
        }

        //Delete a customer
        public void DeleteCustomer()
        {
            int CusID = View.CustomerID;

            bool result = Model.DeleteCustomer(CusID);
        }

    }
}
