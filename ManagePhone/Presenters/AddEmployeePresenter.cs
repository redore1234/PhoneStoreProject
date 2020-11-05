using ManagePhone.Models.Models;
using ManagePhone.Views;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManagePhone.Presenters
{
    public class AddEmployeePresenter : Presenter<IAddEmployeeView>
    {
        //Constructor
        public AddEmployeePresenter(IAddEmployeeView view) : base(view)
        {
        }

        //Add new employee
        public bool AddEmployee()
        {
            bool IsAddSuccess = false;

            //Get data from user input
            string EmployeeID = View.Username;
            string Password = View.Password;
            string EmployeeName = View.EmployeeName;
            string Address = View.Address;
            DateTime DOB = View.DOB;
            string Phone = View.Phone;
            bool IsManager = View.IsManager;

            EmployeeModel employee = new EmployeeModel()
            {
                EmployeeID = EmployeeID,
                Password = Password,
                Name = EmployeeName,
                Address = Address,
                DOB = DOB,
                Phone = Phone,
                RoleID = (IsManager == true ? 1 : 2)
            };

            try
            {
                IsAddSuccess = Model.AddEmployee(employee);
                if (IsAddSuccess)
                {
                    MessageBox.Show("Added employee " + EmployeeID + " successful!", "Notice");
                }
                else
                {
                    MessageBox.Show("Failed to add employee", "Error");
                }
            }
            catch (SqlException ex) //Catch exception user already in database
            {
                if (ex.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("This username is already existed!\nTry to use different username", "Error");
                    return IsAddSuccess;
                }
            }

            return IsAddSuccess;
        }
    }
}