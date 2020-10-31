USE PhoneStore
GO

					-- TBLEMPLOYEE --

			--CheckLogin--
CREATE PROC spCheckLogin(@EmpID VARCHAR(30), @Pass VARCHAR(64))
AS
	BEGIN
		SELECT employeeID, password, name, DOB, address, phone, roleID, statusID
		FROM dbo.tblEmployee
		WHERE employeeID=@EmpID AND password=@Pass
	END
GO

EXEC dbo.spCheckLogin @EmpID = 'admin', -- varchar(30)
    @Pass = 'admin' -- varchar(64)
GO 

			--Add Employee--
CREATE PROC spAddEmployee(@EmpID VARCHAR(30), @Pass VARCHAR(64), @Name VARCHAR(50), 
					@DOB DATE, @Address VARCHAR(100), @Phone VARCHAR(10), @RoleID VARCHAR(10), @StatusID VARCHAR(10))
AS
	BEGIN
		INSERT dbo.tblEmployee
		        ( employeeID , password , name , DOB , address , phone , roleID , statusID
		        )
		VALUES  ( @EmpID, @Pass, @Name, @DOB, @Address, @Phone, @RoleID, @StatusID
		        )
	END
GO

EXEC dbo.spAddEmployee @EmpID = 'tindd', -- varchar(30)
    @Pass = '234', -- varchar(64)
    @Name = 'DongTin', -- varchar(50)
    @DOB = '2000-10-20', -- date
    @Address = '234TQD', -- varchar(100)
    @Phone = '234', -- varchar(10)
    @RoleID = '1', -- varchar(10)
    @StatusID = '1' -- varchar(10)
GO 

			--Delete Employee--
CREATE PROC spDeleteEmployee(@EmpID VARCHAR(30), @StatusID INT)
AS
	BEGIN
		UPDATE dbo.tblEmployee
		SET statusID = @StatusID
		WHERE employeeID = @EmpID
	END
GO

EXEC dbo.spDeleteEmployee @EmpID = 'tindd', -- varchar(30)
    @StatusID = 2 -- int
GO 

			--Update Employee--
CREATE PROC spUpdateEmployee(@EmpID VARCHAR(30), @Pass VARCHAR(64), @Name VARCHAR(50), 
					@DOB DATE, @Address VARCHAR(100), @Phone VARCHAR(10), @RoleID VARCHAR(10), @StatusID VARCHAR(10))
AS
	BEGIN
		UPDATE dbo.tblEmployee
		SET password=@Pass, name=@Name, phone=@Phone, roleID=@RoleID, statusID=@StatusID
		WHERE employeeID=@EmpID
	END
GO

EXEC dbo.spUpdateEmployee @EmpID = 'tindd', -- varchar(30)
    @Pass = '234', -- varchar(64)
    @Name = 'DongTin', -- varchar(50)
    @DOB = '2000-10-20', -- date
    @Address = '234TQD', -- varchar(100)
    @Phone = '234', -- varchar(10)
    @RoleID = '2', -- varchar(10)
    @StatusID = '1' -- varchar(10)
GO

			--Get List Employee--
CREATE PROC spGetListEmployees
AS
	BEGIN
		SELECT employeeID, password, name, DOB, address, phone, roleID, statusID
		FROM dbo.tblEmployee
	END
GO

EXEC dbo.spGetListEmployees 
GO

			--Search Employee by Name--
CREATE PROC spSearchEmployeesByName(@Name VARCHAR(100))
AS
	BEGIN
		SELECT employeeID, password, name, DOB, address, phone, roleID, statusID
		FROM dbo.tblEmployee
		WHERE name LIKE '%' + @Name + '%'
	END
GO 

EXEC dbo.spSearchEmployeesByName @Name = 'h' -- varchar(100)
GO 



					-- TBL CUSTOMER --

		--Add Customer--
CREATE PROC spAddCustomer(@Name VARCHAR(50), @DOB DATE, @Address VARCHAR(100), 
						@Phone VARCHAR(10), @Money INT, @Point INT, @RankID  INT, @StatusID INT)
AS 
	BEGIN 
		INSERT dbo.tblCustomer
		        ( name, DOB, address, phone, 
					spentMoney, point, rankID, statusID
		        )
		VALUES  ( @Name, @DOB, @Address, @Phone, @Money, 
					@Point, @RankID, @StatusID
		        )
	END 
GO 

EXEC dbo.spAddCustomer @Name = 'longpt', -- varchar(50)
    @DOB = '2000-10-31 ', -- date
    @Address = '123PXL', -- varchar(100)
    @Phone = '0808', -- varchar(10)
    @Money = 0, -- int
    @Point = 0, -- int
    @RankID = 1, -- int
    @StatusID = 1 -- int
GO	

		--Update Customer--
CREATE PROC spUpdateCustomer(@CustomerID INT, @Name VARCHAR(50), @DOB DATE, @Address VARCHAR(100), 
						@Phone VARCHAR(10), @Money INT, @Point INT, @RankID  INT, @StatusID INT)
AS 
	BEGIN
		UPDATE dbo.tblCustomer
		SET name=@Name, DOB=@DOB, address=@Address, phone=@Phone, 
					spentMoney=@Money, point=@Point, rankID=@RankID, statusID=@StatusID
		WHERE customerID=@CustomerID
	END
GO 

EXEC dbo.spUpdateCustomer @CustomerID = 3, -- int
    @Name = 'longpt', -- varchar(50)
    @DOB = '2000-10-31 ', -- date
    @Address = '123PXL', -- varchar(100)
    @Phone = '0808', -- varchar(10)
    @Money = 50000, -- int
    @Point = 50, -- int
    @RankID = 2, -- int
    @StatusID = 1 -- int
GO 

		--Delete Customer--
CREATE PROC spDeleteCustomer(@CustomerID INT, @StatusID INT)
AS 
	BEGIN 
		UPDATE dbo.tblCustomer
		SET statusID=@StatusID
		WHERE customerID=@CustomerID
	END
GO 

EXEC dbo.spDeleteCustomer @CustomerID = 2, -- int
    @StatusID = 2 -- int
GO

		--Get List Customer--
CREATE PROC  spGetListCustomers 
AS 
	BEGIN
		SELECT customerID, name, DOB, address, phone, spentMoney, point, rankID, statusID
		FROM dbo.tblCustomer 
	END 
GO 

EXEC dbo.spGetListCustomers
GO 

		--Get List Customer By Phone--
CREATE PROC spSearchCustomerByPhone(@Phone VARCHAR(10))
AS 
	BEGIN
		SELECT customerID, name, DOB, address, phone, spentMoney, point, rankID, statusID
		FROM dbo.tblCustomer
		WHERE phone LIKE '%' + @Phone + '%'
	END
GO 

EXEC dbo.spSearchCustomerByPhone @Phone = '9' -- varchar(10)
GO

		--Get List Customer By Phone--
CREATE PROC spSearchCustomersByName(@Name VARCHAR(50))
AS 
	BEGIN
		SELECT customerID, name, DOB, address, phone, spentMoney, point, rankID, statusID
		FROM dbo.tblCustomer
		WHERE name LIKE '%' + @Name + '%'
	END	
GO

EXEC dbo.spSearchCustomersByName @Name = 'e' -- varchar(50)
GO 