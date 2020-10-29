using ActionService;
using AutoMapper;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Models
{
    public class Model : IModel
    {
        static Service service = new Service();

        static Model()
        {
            Mapper.CreateMap<TblEmployee, EmployeeModel>();
        }

        #region Login / Logout
        public bool Login(string username, string password)
        {
            return true;
        }

        public void Logout()
        {

        }
        #endregion
    }
}
