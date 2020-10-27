CREATE DATABASE PhoneStore
USE PhoneStore

CREATE TABLE tblRole(
    roleID VARCHAR(10) PRIMARY KEY,
    roleName NVARCHAR(30) NOT NULL,
)

CREATE TABLE tblStatus(
    statusID VARCHAR(10) PRIMARY KEY,
    status NVARCHAR(30) NOT NULL,
)

CREATE TABLE tblRank(
    rankID VARCHAR(10) PRIMARY KEY,
    rank NVARCHAR(30) NOT NULL, 
)

CREATE TABLE tblBrand(
    brandID VARCHAR(10) PRIMARY KEY,
    brandName NVARCHAR(50) NOT NULL
)

CREATE TABLE tblEmployee(
    employeeID VARCHAR(30) PRIMARY KEY,
    password VARCHAR(64) NOT NULL,
    name NVARCHAR(50) NOT NULL,
    DOB DATE NOT NULL,
    address NVARCHAR(100),
    phone VARCHAR(10),
    roleID VARCHAR(10) FOREIGN KEY REFERENCES tblRole(roleID),
    statusID VARCHAR(10) FOREIGN KEY REFERENCES tblStatus(statusID)
)

CREATE TABLE tblCustomer(
    customerID int IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    DOB DATE NOT NULL,
    address NVARCHAR(100),
    phone VARCHAR(10),
    spentMoney BIGINT DEFAULT 0 NOT NULL, 
    point INT DEFAULT 0 NOT NULL,
    rankID VARCHAR(10) FOREIGN KEY REFERENCES tblRank(rankID),
    statusID VARCHAR(10) FOREIGN KEY REFERENCES tblStatus(statusID)
)

CREATE TABLE tblProducts(
    productID INT IDENTITY(1,1) PRIMARY KEY,
    prodcutName NVARCHAR(50) NOT NULL,
    brandID VARCHAR(10) FOREIGN KEY REFERENCES tblBrand(brandID),
    description NVARCHAR(200) NOT NULL,
    launchDate DATE NOT NULL,
    price BIGINT DEFAULT 0 NOT NULL,
    image VARCHAR(200) NOT NULL,
    quantity INT DEFAULT 0 NOT NULL,
    statusID VARCHAR(10) FOREIGN KEY REFERENCES tblStatus(statusID)
)

CREATE TABLE tblOrders(
    orderID VARCHAR(100) DEFAULT NEWID() PRIMARY KEY,
    customerID INT FOREIGN KEY REFERENCES tblCustomer(customerID) NOT NULL,
    orderDate DATETIME DEFAULT GETDATE() NOT NULL,
    employeeID VARCHAR(30) FOREIGN KEY REFERENCES tblEmployee(employeeID),
    totalPrice BIGINT NOT NULL,
)

CREATE TABLE tblOrderDetail(
    orderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    orderID VARCHAR(100) FOREIGN KEY REFERENCES tblOrders(orderID),
    productID INT FOREIGN KEY REFERENCES tblProducts(productID),
    quantity INT DEFAULT 1 NOT NULL,
    itemPrice BIGINT NOT NULL,
)

DROP TABLE tblEmployee
DROP TABLE tblRole
DROP TABLE tblStatus
DROP TABLE tblRank
DROP TABLE tblBrand
DROP TABLE tblCustomer
DROP TABLE tblProducts