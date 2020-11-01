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
    public class TblCustomerDAO : ITblCustomerDAO
    {
        static Db db = new Db();

        // creates query parameters list from TblCustomer object
        object[] TakeCustomer (TblCustomer Cus)
        {
            return new object[]
            {
                "@CustomerID", Cus.CustomerID,
                "@Name", Cus.Name,
                "@DOB", Cus.DOB,
                "@Address", Cus.Address,
                "@Phone", Cus.Phone,
                "@Money", Cus.SpentMoney,
                "@Point", Cus.Point,
                "@RankID", Cus.RankID,
            };
        }

        // creates query parameters CustomerID from TblCustomer object
        object[] TakeCustomerID(int CustomerID)
        {
            return new object[]
            {
                "@CustomerID", CustomerID
            };
        }

        // creates a TblCustomer object based on DataReader
        static Func<IDataReader, TblCustomer> Make = reader =>
        new TblCustomer
        {
            CustomerID = int.Parse(reader["customerID"].ToString()),
            Name = reader["name"].ToString(),
            DOB = DateTime.Parse(reader["DOB"].ToString()),
            Address = reader["address"].ToString(),
            Phone = reader["phone"].ToString(),
            SpentMoney = long.Parse(reader["spentMoney"].ToString()),
            Point = int.Parse(reader["point"].ToString()),
            RankID = int.Parse(reader["rankID"].ToString())
        };

        public bool AddCustomer(TblCustomer Customer)
        {
            string StoreProc = "spAddCustomer";
            return db.Insert(StoreProc, TakeCustomer(Customer)) > 0;
        }

        public bool DeleteCustomer(int CustomerID)
        {
            string StoreProc = "spDeleteCustomer";
            return db.Delete(StoreProc, TakeCustomerID(CustomerID)) > 0;
        }

        public List<TblCustomer> GetListCustomers()
        {
            string StoreProc = "spGetListCustomers";
            return (List<TblCustomer>)db.Read(StoreProc, Make);
        }

        public TblCustomer SearchCustomerByPhone(string PhoneNumber)
        {
            string StoreProc = "spSearchCustomerByPhone";
            object[] parms = { "@Phone", PhoneNumber };
            return db.Read(StoreProc, Make, parms).FirstOrDefault();
        }

        public List<TblCustomer> SearchCustomersByName(string CustomerName)
        {
            string StoreProc = "spSearchCustomerByName";
            object[] parms = { "@Name", CustomerName };
            return (List<TblCustomer>)db.Read(StoreProc, Make, parms);
        }

        public bool UpdateCustomer(TblCustomer Customer)
        {
            string StoreProc = "spUpdateCustomer";
            return db.Update(StoreProc, TakeCustomer(Customer)) > 0;
        }
    }
}
