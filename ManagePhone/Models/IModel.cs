using ManagePhone.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Models
{
    public interface IModel
    {
        public bool AddCustomer(CustomerModel customer);
        public bool UpdateCustomer(CustomerModel customer);
        public bool DeleteCustomer(int cusID);
    }
}
