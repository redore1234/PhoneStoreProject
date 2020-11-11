CREATE DATABASE PhoneStore
USE PhoneStore

CREATE TABLE tblRole(
    roleID INT IDENTITY(1,1) PRIMARY KEY,
    roleName NVARCHAR(30) NOT NULL,
)

CREATE TABLE tblStatus(
    statusID INT IDENTITY(1,1) PRIMARY KEY,
    statusName NVARCHAR(30) NOT NULL,
)

CREATE TABLE tblEmployee(
    employeeID VARCHAR(30) PRIMARY KEY,
    password VARCHAR(64) NOT NULL,
    name NVARCHAR(50) NOT NULL,
    DOB DATE NOT NULL,
    address NVARCHAR(100),
    phone VARCHAR(10),
    roleID INT FOREIGN KEY REFERENCES tblRole(roleID),
    statusID INT DEFAULT 1 FOREIGN KEY REFERENCES tblStatus(statusID)
)

CREATE TABLE tblCustomer(
    customerID INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    DOB DATE NOT NULL,
    address NVARCHAR(100),
    phone VARCHAR(10)
)

CREATE TABLE tblProducts(
    productID INT IDENTITY(1,1) PRIMARY KEY,
    productName NVARCHAR(50) NOT NULL,
    brand VARCHAR(20) NOT NULL,
    description NVARCHAR(200) NOT NULL,
    launchDate DATE NOT NULL,
    price BIGINT DEFAULT 0 NOT NULL,
    image VARCHAR(200) NOT NULL,
    quantity INT DEFAULT 0 NOT NULL,
    statusID INT DEFAULT 1 FOREIGN KEY REFERENCES tblStatus(statusID)
)

CREATE TABLE tblOrders(
    orderID VARCHAR(100) DEFAULT NEWID() PRIMARY KEY,
    customerID INT FOREIGN KEY REFERENCES tblCustomer(customerID) NOT NULL,
    orderDate DATETIME DEFAULT GETDATE() NOT NULL,
    employeeID VARCHAR(30) FOREIGN KEY REFERENCES tblEmployee(employeeID),
    totalPrice BIGINT NOT NULL,
	statusID INT DEFAULT 1 FOREIGN KEY REFERENCES tblStatus(statusID)
)

CREATE TABLE tblOrderDetail(
    orderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    orderID VARCHAR(100) FOREIGN KEY REFERENCES tblOrders(orderID),
    productID INT FOREIGN KEY REFERENCES tblProducts(productID),
    quantity INT DEFAULT 1 NOT NULL,
    itemPrice BIGINT NOT NULL,
	statusID INT DEFAULT 1 FOREIGN KEY REFERENCES tblStatus(statusID)
)

DROP TABLE tblOrderDetail
DROP TABLE tblOrders
DROP TABLE tblEmployee
DROP TABLE tblRole
DROP TABLE tblStatus
DROP TABLE tblCustomer
DROP TABLE tblProducts
