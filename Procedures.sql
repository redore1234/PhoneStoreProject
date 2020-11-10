USE PhoneStore
GO

-- TBLEMPLOYEE --

--CheckLogin--
CREATE PROC spCheckLogin(@EmpID VARCHAR(30), @Pass VARCHAR(64))
AS
	BEGIN
		SELECT employeeID, password, name, DOB, address, phone, roleID, statusID
		FROM dbo.tblEmployee
		WHERE employeeID=@EmpID AND password=@Pass AND statusID = 1
	END
GO

EXEC dbo.spCheckLogin @EmpID = 'admin', -- varchar(30)
    @Pass = 'admin' -- varchar(64)
GO 

--Add Employee--
CREATE PROC spAddEmployee(@EmpID VARCHAR(30), @Pass VARCHAR(64), @Name VARCHAR(50), 
					@DOB DATE, @Address VARCHAR(100), @Phone VARCHAR(10), @RoleID INT)
AS
	BEGIN
		INSERT dbo.tblEmployee(employeeID , password , name , DOB , address , phone , roleID , statusID)
		VALUES (@EmpID, @Pass, @Name, @DOB, @Address, @Phone, @RoleID, 1)
	END
GO

EXEC dbo.spAddEmployee @EmpID = 'tindd', -- varchar(30)
    @Pass = '234', -- varchar(64)
    @Name = 'DongTin', -- varchar(50)
    @DOB = '2000-10-20', -- date
    @Address = '234TQD', -- varchar(100)
    @Phone = '234', -- varchar(10)
    @RoleID = '1' -- varchar(10)
GO 

--Delete Employee--
CREATE PROC spDeleteEmployee(@EmpID VARCHAR(30))
AS
	BEGIN
		UPDATE dbo.tblEmployee
		SET statusID = 2
		WHERE employeeID = @EmpID
	END
GO


EXEC dbo.spDeleteEmployee @EmpID = 'tindd' -- varchar(30)
GO 

--Update Employee With Update Password--
CREATE PROC spUpdateEmployeeWithPass(@EmpID VARCHAR(30), @Pass VARCHAR(64), @Name VARCHAR(50), 
					@DOB DATE, @Address VARCHAR(100), @Phone VARCHAR(10), @RoleID VARCHAR(10))
AS
	BEGIN
		UPDATE dbo.tblEmployee
		SET password=@Pass, name=@Name, phone=@Phone, roleID=@RoleID, DOB=@DOB, address=@Address
		WHERE employeeID=@EmpID
	END
GO

--Update Employee Without Update Password--
CREATE PROC spUpdateEmployeeWithoutPass(@EmpID VARCHAR(30), @Name VARCHAR(50), 
					@DOB DATE, @Address VARCHAR(100), @Phone VARCHAR(10), @RoleID VARCHAR(10))
AS
	BEGIN
		UPDATE dbo.tblEmployee
		SET name=@Name, phone=@Phone, roleID=@RoleID, DOB=@DOB, address=@Address
		WHERE employeeID=@EmpID
	END
GO

--Get List Employee--
CREATE PROC spGetListEmployees
AS
	BEGIN
		SELECT employeeID, password, name, DOB, address, phone, roleID, statusID
		FROM dbo.tblEmployee
		WHERE statusID=1
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
		WHERE name LIKE '%' + @Name + '%' AND statusID=1
	END
GO 

EXEC dbo.spSearchEmployeesByName @Name = 'h' -- varchar(100)
GO 



-- TBLCUSTOMER --

--Add Customer--
CREATE PROC spAddCustomer(@Name VARCHAR(50), @DOB DATE, @Address VARCHAR(100), 
						@Phone VARCHAR(10))
AS 
	BEGIN 
		INSERT dbo.tblCustomer
		        ( name, DOB, address, phone
		        )
		VALUES  ( @Name, @DOB, @Address, @Phone
		        )
		;SELECT SCOPE_IDENTITY();
	END 
GO 

EXEC dbo.spAddCustomer @Name = 'longpt', -- varchar(50)
    @DOB = '2000-10-31 ', -- date
    @Address = '123PXL', -- varchar(100)
    @Phone = '0808' -- varchar(10)
GO	

--Update Customer--
CREATE PROC spUpdateCustomer(@CustomerID INT, @Name VARCHAR(50), @DOB DATE, @Address VARCHAR(100), 
						@Phone VARCHAR(10))
AS 
	BEGIN
		UPDATE dbo.tblCustomer
		SET name=@Name, DOB=@DOB, address=@Address, phone=@Phone
		WHERE customerID=@CustomerID
	END
GO 

EXEC dbo.spUpdateCustomer @CustomerID = 5, -- int
    @Name = 'longpt', -- varchar(50)
    @DOB = '2000-10-31 ', -- date
    @Address = '123PXL', -- varchar(100)
    @Phone = '0808' -- varchar(10)
GO 

--Get List Customer--
CREATE PROC  spGetListCustomers 
AS 
	BEGIN
		SELECT customerID, name, DOB, address, phone, spentMoney
		FROM dbo.tblCustomer 
	END 
GO 

EXEC dbo.spGetListCustomers
GO 

--Search Customers By Phone Or Name
CREATE PROC spSearchCustomers(@Name VARCHAR(50), @Phone VARCHAR(10))
AS
	BEGIN
		SELECT customerID, name, DOB, address, phone, spentMoney
		FROM dbo.tblCustomer
		WHERE name LIKE '%' + @Name + '%' OR phone LIKE '%' + @Phone + '%'
	END
GO

--Get List Customer By Phone--
CREATE PROC spSearchCustomerByPhone(@Phone VARCHAR(10))
AS 
	BEGIN
		SELECT customerID, name, DOB, address, phone, spentMoney
		FROM dbo.tblCustomer
		WHERE phone LIKE '%' + @Phone + '%'
	END 
GO 

--TBLPRODUCTS 

-- Add New Product --
CREATE PROC spAddProduct(@ProductName NVARCHAR(50), @Brand VARCHAR(20), @Description VARCHAR(200),
 @LaunchDate DATE, @Price BIGINT, @Image VARCHAR(200), @Quantity INT)
AS 
	BEGIN
		INSERT tblProducts(productName, brand, description, launchDate, price, image, quantity, statusId)
		VALUES (@ProductName, @Brand, @Description, @LaunchDate, @Price, @Image, @Quantity, 1)
	END
GO

--Get List Products--
CREATE PROC  spGetListProducts 
AS 
	BEGIN
		SELECT productID, productName, brand, description, launchDate, price, image, quantity, statusID
		FROM dbo.tblProducts 
		WHERE statusID = 1
	END 
GO

EXEC dbo.spGetListProducts
GO 

--Search Product Name
CREATE PROC spSearchProducts(@ProductName NVARCHAR(50))
AS
	BEGIN
		SELECT productID, productName, brand, description, launchDate, price, image, quantity, statusID
		FROM dbo.tblProducts 
		WHERE productName LIKE '%' + @ProductName + '%' AND statusID=1
	END
GO

EXEC dbo.spSearchProducts a
GO 

-- Update A Product --
CREATE PROC spUpdateProduct(@ProductID INT, @ProductName NVARCHAR(50), @Brand VARCHAR(20), @Description VARCHAR(200),
 @LaunchDate DATE, @Price BIGINT, @Image VARCHAR(200), @Quantity INT)
 AS
	BEGIN
		UPDATE dbo.tblProducts
		SET productName=@ProductName, brand=@Brand, description=@Description, launchDate=@LaunchDate, price=@Price, image=@Image, quantity=@Quantity
		WHERE productID=@ProductID
	END
 GO

--Delete Product
CREATE PROC spDeleteProduct(@ProductID INT)
AS 
	BEGIN 
		UPDATE dbo.tblProducts
		SET statusID=2
		WHERE productID=@ProductID
	END
GO

EXEC dbo.spDeleteProduct @ProductID = 1 -- int
GO

--Get Product by ID
CREATE PROC spGetProduct(@ProductID INT)
AS 
	BEGIN 
		SELECT productID, productName, brand, description, launchDate, price, image, quantity, statusID
		FROM dbo.tblProducts 
		WHERE productID=@ProductID
	END
GO

EXEC dbo.spGetProduct @ProductID = 5 -- int
GO


-- TBLROLE --
-- Get RoleName By RoleID
CREATE PROCEDURE spGetRole(@RoleID INT)
AS
	BEGIN
		SELECT roleName
		FROM tblRole 
		WHERE roleID=@RoleID
	END
GO