using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IAddEmployeeView
    {
        string Username { get; }
        string Password { get; }
        string Name { get; }
        string Address { get; }
        DateTime DOB { get; }
        string Phone { get; }

        bool IsManager { get; }
    }
}
