using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IPhonesView : IView
    {
        string Brand { get; set; }
        //IList<BrandModel> Brands { set; }
        string PhoneName { get; set; }
        //IList<PhoneModel> Phones { set; }
    }
}
