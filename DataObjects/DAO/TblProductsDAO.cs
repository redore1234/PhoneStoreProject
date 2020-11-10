using BusinessObjects;
using DataObjects.AdoNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.DAO
{
    public class TblProductsDAO : ITblProductsDAO
    {
        static Db db = new Db();
        // creates query parameters list from TblProducts object
        object[] TakeProduct(TblProducts pro)
        {
            return new object[]
            {
                "@ProductName", pro.ProductName,
                "@Brand", pro.Brand,
                "@Description", pro.Description,
                "@LaunchDate", pro.LaunchDate,
                "@Price", pro.Price,
                "@Image", pro.Image,
                "@Quantity", pro.Quantity
            };
        }

        // creates a TblProducts object based on DataReader
        static Func<IDataReader, TblProducts> Make = reader =>
        new TblProducts
        {
            ProductID = int.Parse(reader["productID"].ToString()),
            ProductName = reader["productName"].ToString(),
            Brand = reader["brand"].ToString(),
            Description = reader["description"].ToString(),
            LaunchDate = DateTime.Parse(reader["launchDate"].ToString()),
            Price = long.Parse(reader["price"].ToString()),
            Image = reader["image"].ToString(),
            Quantity = int.Parse(reader["quantity"].ToString())
        };

        public bool AddProduct(TblProducts Product)
        {
            string StoreProc = "spAddProduct";
            return db.Update(StoreProc, TakeProduct(Product)) > 0;
        }

        public bool DeleteProduct(int ProductID)
        {
            string StoreProc = "spDeleteProduct";
            object[] parms = { "@ProductID", ProductID };
            return db.Delete(StoreProc, parms) > 0;
        }

        public TblProducts GetProduct(int ProductID)
        {
            string StoreProc = "spGetProduct";
            object[] parms = { "@ProductID", ProductID };
            return db.Read(StoreProc, Make, parms).FirstOrDefault();
        }

        public List<TblProducts> GetListProducts()
        {
            string StoreProc = "spGetListProducts";
            return db.Read(StoreProc, Make).ToList();
        }

        public List<TblProducts> SearchProducts(string ProductName)
        {
            string StoreProc = "spSearchProducts";
            object[] parms = { "@ProductName", "%" + ProductName + "%"};
            return db.Read(StoreProc, Make, parms).ToList();
        }

        public List<TblProducts> SearchProductsNameOrBrand(string ProductName, string Brand)
        {
            string StoreProc = "spSearchProductsByNameOrBrand";
            object[] parms =
            {
                "@ProductName", "%" + ProductName + "%",
                "@Brand", "%" + Brand + "%"
            };
            return db.Read(StoreProc, Make, parms).ToList();
        }

        public bool UpdateProduct(TblProducts Product)
        {
            string StoreProc = "spUpdateProduct";
            object[] parms =
            {
                "@ProductID", Product.ProductID,
                "@ProductName", Product.ProductName,
                "@Brand", Product.Brand,
                "@Description", Product.Description,
                "@LaunchDate", Product.LaunchDate,
                "@Price", Product.Price,
                "@Image", Product.Image,
                "@Quantity", Product.Quantity
            };
            return db.Update(StoreProc, parms) > 0;
        }

        public void UpdateQuantity(int ProductID, int NewQuantity)
        {
            string StoreProc = "spUpdateQuantity";
            object[] parms = { "@ProductID", ProductID, "@Quantity", NewQuantity };
            db.Update(StoreProc, parms);
        }
    }
}
