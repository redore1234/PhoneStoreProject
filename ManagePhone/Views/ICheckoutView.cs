using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface ICheckoutView : IView
    {
        long Total { get; set; }
        long Cash { get; }
        long Charge { set; }
    }
}
