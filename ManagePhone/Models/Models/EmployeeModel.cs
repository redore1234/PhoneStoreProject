using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Models
{
    public class EmployeeModel
    {
        public string EmployeeID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string RoleID { get; set; }
        public string StatusID { get; set; }
    }
}
