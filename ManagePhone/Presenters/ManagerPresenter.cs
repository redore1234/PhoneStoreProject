using ManagePhone.GUI;
using ManagePhone.Models.Models;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Presenters
{
    public class ManagerPresenter : Presenter<IManagerView>
    {

        //Constructor
        public ManagerPresenter(IManagerView view) : base(view)
        {
        }

        public void ClickAddEmployee()
        {
            frmAddEmployee addEmployee = new frmAddEmployee();
            addEmployee.ShowDialog();
        }

        public void ClickViewEmployee(EmployeeModel employeeModel)
        {
            frmViewEmployee viewEmployee = new frmViewEmployee(employeeModel);
            viewEmployee.ShowDialog();
        }

        public void ClickAddPhone()
        {
            frmAddPhone addPhone = new frmAddPhone();
            addPhone.ShowDialog();
        }

        public void ClickViewPhone()
        {
            frmViewPhone viewPhone = new frmViewPhone();
            viewPhone.ShowDialog();
        }

        public void ClickViewCustomer()
        {
            frmViewCustomer viewCustomer = new frmViewCustomer();
            viewCustomer.ShowDialog();
        }

        public void ClickAddOrder(EmployeeModel curEmployeeModel)
        {
            frmAddOrder addOrder = new frmAddOrder(curEmployeeModel.EmployeeID);
            addOrder.ShowDialog();
        }

        public void ClickViewOrder()
        {
            frmViewOrder viewOrder = new frmViewOrder();
            viewOrder.ShowDialog();
        }
    }
}
