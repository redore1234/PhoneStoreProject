using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IUpdatePhoneView : IView
    {
        string PhoneName { get; set; }
        string Brand { get; set; }
        DateTime LaunchDate { get; set; }
        long Price { get; set; }
        int Quantity { get; set; }
        string Description { get; set; }
        string Image { get; set; }
    }
}
