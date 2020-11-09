using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface ITblCustomerDAO
    {

        //Search customers by name
        List<TblCustomer> SearchCustomers(string CustomerName, string Phone);

        //Get all customers
        List<TblCustomer> GetListCustomers();

        //Add a new customer
        bool AddCustomer(TblCustomer Customer);

        //Update a customer
        bool UpdateCustomer(TblCustomer Customer);

        //search customer by phone number
        TblCustomer SearchCustomerByPhone(string phone);
    }
}
