using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IAddPhone
    {
        string Name { get; }
        string Brand { get; }
        //IList<BrandModel> Brands { set; }
        string ReleaseYear { get; }
        long Price { get; }
        int Quantity { get; }
        string Description { get; }
        string Image { get; set; }
    }
}
