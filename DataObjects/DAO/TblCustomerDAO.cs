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

        // creates a TblCustomer object based on DataReader
        static Func<IDataReader, TblCustomer> Make = reader =>
        new TblCustomer
        {
            CustomerID = int.Parse(reader["customerID"].ToString()),
            Name = reader["name"].ToString(),
            DOB = DateTime.Parse(reader["DOB"].ToString()),
            Address = reader["address"].ToString(),
            Phone = reader["phone"].ToString()
        };

        public bool AddCustomer(TblCustomer Customer)
        {
            string StoreProc = "spAddCustomer";
            object[] parms =
            {
                "@Name", Customer.Name,
                "@DOB", Customer.DOB,
                "@Address", Customer.Address,
                "@Phone", Customer.Phone
            };
            return db.Insert(StoreProc, parms) > 0;
        }

        public List<TblCustomer> GetListCustomers()
        {
            string StoreProc = "spGetListCustomers";
            return (List<TblCustomer>)db.Read(StoreProc, Make).ToList();
        }

        public TblCustomer SearchCustomerByPhone(string Phone)
        {
            string StoreProc = "spSearchCustomerByPhone";
            object[] parms = { "@Phone", Phone };
            return db.Read(StoreProc, Make, parms).FirstOrDefault();
        }

        public List<TblCustomer> SearchCustomers(string CustomerName, string Phone)
        {
            string StoreProc = "spSearchCustomers";
            object[] parms = { "@Name", CustomerName, "@Phone", Phone };
            return (List<TblCustomer>)db.Read(StoreProc, Make, parms).ToList();
        }

        public bool UpdateCustomer(TblCustomer Customer)
        {
            string StoreProc = "spUpdateCustomer";
            object[] parms =
                { "@CustomerID", Customer.CustomerID,
                "@Name", Customer.Name,
                "@DOB", Customer.DOB,
                "@Address", Customer.Address,
                "@Phone", Customer.Phone };
            return db.Update(StoreProc, parms) > 0;
        }
    }
}
