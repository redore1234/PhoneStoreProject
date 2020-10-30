using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface ICheckoutView : IView
    {
        long Price { get; set; }
        float Tax { get; set; }
        long Total { get; set; }
        long Cash { get; }
        long Charge { get; set; }
    }
}
