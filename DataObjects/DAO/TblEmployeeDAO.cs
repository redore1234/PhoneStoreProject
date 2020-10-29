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
    public class TblEmployeeDAO : ITblEmployeeDAO
    {

        static Db db = new Db();

        // creates query parameters list from TblEmployee object
        object[] Take(TblEmployee Emp)
        {
            return new object[]
            {
                "@EmpID", Emp.EmployeeID,
                "@Pass", Emp.Password,
                "@Name", Emp.Name,
                "@DOB", Emp.DOB,
                "@Phone", Emp.Phone,
                "@RoleID", Emp.RoleID,
                "@StatusID", Emp.StatusID
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
            RoleID = reader["roleID"].ToString(),
            StatusID = reader["statusID"].ToString(),
        };

        public bool AddEmployee(TblEmployee Employee)
        {
            string StoreProc = "spAddEmployee";
            return db.Insert(StoreProc, Take(Employee)) > 0;
        }

        public TblEmployee CheckLogin(string username, string password)
        {
            string StoreProc = "spCheckLogin";
            object[] parms = { "@EmpID", username, "@Pass", password};
            return (TblEmployee)db.Read(StoreProc, Make, parms);
        }

        public bool DeleteEmployee(int EmployeeID)
        {
            throw new NotImplementedException();
        }

        public List<TblEmployee> GetListEmployees()
        {
            throw new NotImplementedException();
        }

        public List<TblEmployee> SearchEmployeesByName(string EmployeeName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(TblEmployee Employee)
        {
            throw new NotImplementedException();
        }
    }
}
