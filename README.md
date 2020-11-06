# Changelog

1. **[31/10/2020 10:40] Pham Thanh Long - @redore1234**
 	1. Models in Presentation: Add BrandModel, CustomerModel, EmployeeModel, OrderModel, OrderDetailModel, ProductModel
 	1. Change rankID, roleID, statusID, brandID string --> int in BusinessLayer
 
1. **[31/10/2020 10:51] Pham Thanh Long - @redore1234**
 	1. Fix the error in TblEmployeeDAO in Data Layer

1. **[31/10/2020 11:00] Le Bao Long - @longlb88**
 	1. Add Presenter.cs and IView.cs
	1. Add inheritance IView to View interfaces
 	
1. **[31/10/2020 12:06] Pham Thanh Long - @redore1234**
 	1. Add TblCustomerDAO 
	1. Add StoreProcedure in file SQL: PhamThanhLong.sql
	
1. **[31/10/2020 12:55] Dam Dong Tin - @dtin**
	1. Do Login function

1. **[31/10/2020 21:08] Pham Minh Tan**
	1. Add TblRankDAO

1. **[31/10/2020 21:10] Dam Dong Tin - @dtin**
	1. Update show MessageBox when account try to login is invalid
	1. Add and Update some Store procedure for tblRole and tblRank
	1. Modified application to use Store Procedure to process SQL query

1. **[1/11/2020 18:33] Pham Thanh Long - @redore1234**
	1. Change in Data Layer:
		1. ITblEmployeeDAO(int EmpID) --> ITblEmployeeDAO(string EmpID)
		1. DeleteEmployee(int EmpID) --> DeleteEmployee(string EmpID)
	1. Change in Service Layer:
		1. DeleteEmployee(int EmpID) --> DeleteEmployee(string EmpID)
	1. Change in Views in Presentation Layer:
		1. bool IsManager --> int IsManager in IAddEmployeeView
		1. Add string EmpID in IEmployeesView
		1. bool IsManager --> int IsManager in IUpdateEmployeeView
	1. Add in Presenters in Presentation Layer: AddEmployeePresenter, UpdateEmployeePresenter, ViewEmployeePresenter
	
1. **[1/11/2020 23:04] Le Bao Long - @longlb88**
	1. Implement Add, Update, Delete and Load List customers
	1. Change in Data Layer:
		1. Change numbers of argument for AddCustomer and UpdateCustomer in TblCustomerDAO
		1. Remove ;SELECT SCOPE_IDENTITY(); from CreateCommand method in Insert function in Db.cs
	1. Edit spAddCustomer, spUpdateCustomer in Procedure.sql
	1. Edit default value for some fields in Customer table in PhoneStore.sql

1. **[2/11/2020 8:20] Pham Thanh Long - @redore1234**
	1. Edit default value for field statusID in Products table in PhoneStore.sql

1. **[2/11/2020 13:33] Pham Thanh Long - @redore1234**
	1. Edit store procedured spDeleteEmployee Procedures.sql
	1. Edit something in CustomerModel and UpdateCustomerPresenter in Presentation Layer

1. **[2/11/2020 21:45] Pham Thanh Long - @redore1234**
	1. Edit store procedured spGetListEmployees Procedures.sql
	1. Implement Delete and Load List employees to datagridview in Presentation Layer
	
1. **[3/11/2020 15:27] Dam Dong Tin - @dtin**
	1. Add 2 new store procedures for update employee function
	1. Do Update Employee function in Presentation Layer

1. **[3/11/2020 15:50] Pham Thanh Long - @redore1234**
	1. Do Delete Employee function in Presentation Layer
	
1. **[4/11/2020 20:50] Pham Thanh Long - @redore1234**
	1. Do Search Employee by Name in Presentation Layer
	1. Edit store procedured spSearchEmployeesByName, spSearchCustomerByPhone, spSearchCustomerByName (add statusId=1) in Procedures.sql

1. **[4/11/2020 22:30] Dam Dong Tin - @dtin**
	1. Do Add Employee function in Presentation Layer
	1. Modified store procedure to fit with current Add Employee function

1. **[5/11/2020 14:30] Le Bao Long - @longlb88**
	1. Do Search Customer by Name and Phone
	1. Delete spSearchCustomerByPhone and spSearchCustomersByName
	1. Delete all methods that use to search customers seperately by phone or name

1. **[5/11/2020 14:50] Pham Thanh Long - @redore1234**
	1. Edit Search Employee by Name in Presentation Layer	
	1. Add Pictures

1. **[5/11/2020 15:17] Dam Dong Tin - @dtin**
	1. Fix bug close form Add Employee unexpected
	1. Fix date format in Add Employee form 

1. **[6/11/2020 10:09] Pham Thanh Long - @redore1234**
	1. Add Search Customer by Phone in Presentation Layer
	1. Add Pictures and gather all Pictures in Image folder
	1. Add new frmOrder, edit frmManger

. **[6/11/2020 11:35] Le Bao Long - @longlb88**
	1. Add add order icon
	1. Edit icons, make them in same style