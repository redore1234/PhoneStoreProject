using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface ITblEmployeeDAO
    {
        //Check login for employee
        TblEmployee CheckLogin(string username, string password);

        //Search an employee
        List<TblEmployee> SearchEmployeesByName(string EmployeeName);

        //Get List of all Employees
        List<TblEmployee> GetListEmployees();

        //Add a new employee
        bool AddEmployee(TblEmployee Employee);

        //Delete an employee
        bool DeleteEmployee(string EmployeeID);

        //Update an employee without update password
        bool UpdateEmployeeWithoutPassword(TblEmployee Employee);

        //Update an employee with password
        bool UpdateEmployeeWithPassword(TblEmployee Employee);
    }
}
