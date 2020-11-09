using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Models.Models
{
    public class CartItemModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
        public int BuyQuantity { get; set; }
    }
}
