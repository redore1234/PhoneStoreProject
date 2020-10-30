using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface ILoginView : IView
    {
        string EmpID { get; }
        string Password { get; }
    }
}
