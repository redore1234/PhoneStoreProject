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
        //Search a customer by phone
        TblCustomer SearchCustomerByPhone(string PhoneNumber);

        //Search customers by name
        List<TblCustomer> SearchCustomersByName(string CustomerName);

        //Get all customers
        List<TblCustomer> GetListCustomers();

        //Add a new customer
        bool AddCustomer(TblCustomer Customer);

        //Update a customer
        bool UpdateCustomer(TblCustomer Customer);

        //Delete a customer
        bool DeleteCustomer(int CustomerID);
    }
}
