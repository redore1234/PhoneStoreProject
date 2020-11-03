using ManagePhone.Models.Models;
using ManagePhone.Views;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Presenters
{
    public class UpdateEmployeePresenter : Presenter<IUpdateEmployeeView>
    {
        //constructor
        public UpdateEmployeePresenter(IUpdateEmployeeView view) 
            : base(view) {}

        //Load information to View
        public void Display(EmployeeModel Employee)
        {
            View.Username = Employee.EmployeeID;
            View.EmployeeName = Employee.Name;
            View.Address = Employee.Address;
            View.DOB = Employee.DOB;
            View.Phone = Employee.Phone;
            
            //Get role of selected employee
            RoleModel Role = Model.GetRole(Employee.RoleID);
            View.IsManager = (Role.RoleName == "Manager" ? true : false);
        }

        //Update the Employee
        public bool UpdateEmployee()
        {
            bool IsCloseForm = false;
            bool UpdateResult;
            bool IsChangePassword = false;
            string Username = View.Username;
            string NewPassword = View.NewPassword;
            string ConfirmPassword = View.ConfirmPassword;
            string Name = View.EmployeeName;
            string Address = View.Address;
            DateTime DOB = View.DOB;
            string Phone = View.Phone;
            bool IsManager = View.IsManager;
            int RoleID = (IsManager == true ? 1 : 2);

            //Check if Manager is trying to change password an Employee
            if(NewPassword.Length > 0)
            {
                if(ConfirmPassword.Length > 0)
                {
                    if(ConfirmPassword.Equals(NewPassword))
                    {
                        //Password confirm is match with new password
                        IsChangePassword = true;
                    } else
                    {
                        //Password confirm is not match with new password
                        MessageBox.Show("Confirm password not match with New password", "Update Failed!");
                    }
                } else
                {
                    //If confirm password is empty
                    MessageBox.Show("Confirm password can not be empty!", "Update Failed!");
                }
            } 
            //Check if Confirm password is not empty, but New password is empty
            else if(ConfirmPassword.Length > 0)
            {
                MessageBox.Show("New password can not be empty!", "Update Failed!");
            }

            //Case Manager want to change password, update all informations include password
            if(IsChangePassword)
            {
                EmployeeModel employee = new EmployeeModel()
                {
                    EmployeeID = Username,
                    Password = NewPassword,
                    Name = Name,
                    Address = Address,
                    DOB = DOB,
                    Phone = Phone,
                    RoleID = RoleID,
                };
                
                UpdateResult = Model.UpdateEmployeeWithPassword(employee);
            } 
            else //Manager not want to change password, update informations without password
            {
                EmployeeModel employee = new EmployeeModel()
                {
                    EmployeeID = Username,
                    Name = Name,
                    Address = Address,
                    DOB = DOB,
                    Phone = Phone,
                    RoleID = RoleID,
                };

                UpdateResult = Model.UpdateEmployeeWithoutPassword(employee);
            }


            //Show result to user
            if(UpdateResult)
            {
                MessageBox.Show("Employee updated!", "Notice");
                IsCloseForm = true;
            } else
            {
                MessageBox.Show("Update failed", "Error");
            }

            return IsCloseForm;
        }
    }
}
