using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface ITblBrandDAO
    {
        //Get List of all Brands
        List<TblBrand> GetListBrands();

        //Get BrandName by BrandID
        string GetBrandByBrandID(int BrandID);
    }
}
