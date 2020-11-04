using BusinessObjects;
using DataObjects.AdoNet;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.DAO
{
    public class TblEmployeeDAO : ITblEmployeeDAO
    {

        static Db db = new Db();

        // creates query parameters list from TblEmployee object
        object[] TakeEmployee(TblEmployee Emp)
        {
            return new object[]
            {
                "@EmpID", Emp.EmployeeID,
                "@Pass", Emp.Password,
                "@Name", Emp.Name,
                "@DOB", Emp.DOB,
                "@Address", Emp.Address,
                "@Phone", Emp.Phone,
                "@RoleID", Emp.RoleID
            };
        }

        // creates a TblEmployee object based on DataReader
        static Func<IDataReader, TblEmployee> Make = reader =>
        new TblEmployee
        {
            EmployeeID = reader["employeeID"].ToString(),
            Password = reader["password"].ToString(),
            Name = reader["name"].ToString(),
            DOB = DateTime.Parse(reader["DOB"].ToString()),
            Address = reader["address"].ToString(),
            Phone = reader["phone"].ToString(),
            RoleID = int.Parse(reader["roleID"].ToString())
        };

        public TblEmployee CheckLogin(string username, string password)
        {
            string StoreProc = "spCheckLogin";
            object[] parms = { "@EmpID", username, "@Pass", password };
            return db.Read(StoreProc, Make, parms).FirstOrDefault();
        }

        public bool AddEmployee(TblEmployee Employee)
        {
            string StoreProc = "spAddEmployee";
            return db.Insert(StoreProc, TakeEmployee(Employee)) > 0;
        }

        public bool DeleteEmployee(string EmployeeID)
        {
            string StoreProc = "spDeleteEmployee";
            object[] parms = { "@EmpID", EmployeeID };
            return db.Delete(StoreProc, parms) > 0;
        }

        public List<TblEmployee> GetListEmployees()
        {
            string StoreProc = "spGetListEmployees";
            return db.Read(StoreProc, Make).ToList();
        }

        public List<TblEmployee> SearchEmployeesByName(string EmployeeName)
        {
            string StoreProc = "spSearchEmployeesByName";
            object[] parms = { "@Name", EmployeeName };
            return db.Read(StoreProc, Make, parms).ToList();
        }

        public bool UpdateEmployeeWithoutPassword(TblEmployee Employee)
        {
            string StoreProc = "spUpdateEmployeeWithoutPass";
            object[] parms = new object[]
            {
                "@EmpID", Employee.EmployeeID,
                "@Name", Employee.Name,
                "@DOB", Employee.DOB,
                "@Address", Employee.Address,
                "@Phone", Employee.Phone,
                "@RoleID", Employee.RoleID
            };
            return db.Update(StoreProc, parms) > 0;
        }

        public bool UpdateEmployeeWithPassword(TblEmployee Employee)
        {
            string StoreProc = "spUpdateEmployeeWithPass";
            return db.Update(StoreProc, TakeEmployee(Employee)) > 0;
        }
    }
}
