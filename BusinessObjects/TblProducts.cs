using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class TblProducts : BusinessObject
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string BrandID { get; set; }
        public string Description { get; set; }
        public DateTime LaunchDate { get; set; }
        public long Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }

        // ** Enterprise Design Pattern: Foreign Key Mapping. TblBrand, TblStatus are the parents
        public TblBrand TblBrand { get; set; }
    }
}
