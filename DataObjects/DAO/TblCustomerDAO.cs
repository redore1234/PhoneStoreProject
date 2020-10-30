using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.DAO
{
    public class TblCustomerDAO : ITblCustomerDAO
    {
        public bool AddCustomer(TblCustomer Customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int CustomerID)
        {
            throw new NotImplementedException();
        }

        public List<TblCustomer> GetListCustomers()
        {
            throw new NotImplementedException();
        }

        public TblCustomer SearchCustomerByPhone(string PhoneNumber)
        {
            throw new NotImplementedException();
        }

        public List<TblCustomer> SearchCustomersByName(string CustomerName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(TblCustomer Customer)
        {
            throw new NotImplementedException();
        }
    }
}
