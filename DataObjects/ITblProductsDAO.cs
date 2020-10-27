﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataObjects
{
    public interface ITblProductsDAO
    {
        //Add a new product
        bool AddProduct(TblProducts Product);

        //Update a product
        bool UpdateProduct(TblProducts Product);

        //Delete a product
        bool DeleteProduct(int ProductID);

        //Get a single product using ProductID
        TblProducts GetProduct(int ProductID);

        //Get list all of products
        List<TblProducts> GetListProducts();

        //Search by name for all products
        List<TblProducts> SearchProducts(string ProductName);
    }
}