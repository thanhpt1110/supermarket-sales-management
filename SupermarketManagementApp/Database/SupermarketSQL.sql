CREATE DATABASE SUPERMARKET_MANAGEMENT
GO
USE SUPERMARKET_MANAGEMENT
GO
SET DATEFORMAT DMY;
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY IDENTITY ,
    EmployeeName NVARCHAR(max),
    Birthday DATETIME,
    PhoneNumber VARCHAR(20) UNIQUE,
    IdCardNumber VARCHAR(20) UNIQUE,
	Gender NVARCHAR(10)
);

CREATE TABLE Account (
    AccountID INT PRIMARY KEY IDENTITY ,
    EmployeeID INT,
    Username NVARCHAR(max),
    Password NVARCHAR(max),
    Role VARCHAR(20),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

CREATE TABLE Shelf (
    ShelfID INT PRIMARY KEY IDENTITY ,
    ShelfFloor INT,
    ShelfType NVARCHAR(max),
    LayerQuantity INT,
    LayerCapacity INT,
    Status NVARCHAR(max)
);



CREATE TABLE ProductType (
    ProductTypeID INT PRIMARY KEY IDENTITY ,
    ProductTypeName NVARCHAR(max),
    Description NVARCHAR(max),
	MinTemperature INT,
	MaxTemperature INT,
);
CREATE TABLE Product (
    ProductID BIGINT PRIMARY KEY IDENTITY ,
	ProductTypeID INT,
    ProductName NVARCHAR(255),
    UnitPrice FLOAT,
    WholeSaleUnit NVARCHAR(max),
    RetailUnit NVARCHAR(max),
    UnitConversion INT,
    ProductCapacity INT,
	FOREIGN KEY (ProductTypeID) REFERENCES ProductType(ProductTypeID)
);
CREATE TABLE ShelfDetail (
    ShelfDetailID INT PRIMARY KEY IDENTITY ,
    ShelfID INT,
    ProductID BIGINT,
    ProductQuantity INT,
    FOREIGN KEY (ShelfID) REFERENCES Shelf(ShelfID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE InventoryDetail (
	InventoryDetailID BIGINT PRIMARY KEY IDENTITY ,
    ProductID BIGINT,
    ProductQuantity INT,
	FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY IDENTITY ,
    CustomerName NVARCHAR(max),
    Birthday DATETIME,
    PhoneNumber VARCHAR(20) UNIQUE,
    Gender NVARCHAR(10)
);

CREATE TABLE CustomerInvoice (
    CustomerInvoiceID BIGINT PRIMARY KEY IDENTITY ,
    CustomerID INT,
    EmployeeID INT,
    DatePayment DATETIME,
    TotalAmount FLOAT,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

CREATE TABLE CustomerInvoiceDetail (
    CustomerInvoiceDetailID BIGINT PRIMARY KEY IDENTITY ,
    CustomerInvoiceID BIGINT,
    ProductID BIGINT,
    ProductQuantity INT,
    FOREIGN KEY (CustomerInvoiceID) REFERENCES CustomerInvoice(CustomerInvoiceID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE SupplierInvoice (
    SupplierInvoiceID BIGINT PRIMARY KEY IDENTITY ,
    EmployeeID INT,
    DatePayment DATETIME,
    SupplierName NVARCHAR(max),
    TotalAmount FLOAT,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);
CREATE TABLE SupplierInvoiceDetail (
    SuppliernvoiceDetailID BIGINT PRIMARY KEY IDENTITY ,
    SupplierInvoiceID BIGINT,
    ProductID BIGINT,
    ProductQuantity INT,
    FOREIGN KEY (SupplierInvoiceID) REFERENCES SupplierInvoice(SupplierInvoiceID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);
INSERT INTO Employee ( EmployeeName, Birthday, PhoneNumber, IdCardNumber, Gender)
VALUES ( 'Admin Employee', '01-01-1995', '123456789', 'ID123', 'Male');

INSERT INTO Account ( EmployeeID, Username, Password, Role)
VALUES (1, 'admin', '1234', 'Admin');

-- Thêm nhân viên với vai trò 'nhanVien'
INSERT INTO Employee (EmployeeName, Birthday, PhoneNumber, IdCardNumber, Gender)
VALUES ( 'NhanVien Employee', '01-01-1995', '987654321', 'ID456', 'Male');

INSERT INTO Account (EmployeeID, Username, Password, Role)
VALUES (2, 'nhanvien', '1234', 'Employee');
SELECT * FROM Account
INSERT INTO Customer(CustomerName, Birthday, PhoneNumber, Gender)
VALUES ( N'Khách hàng 1', '01-01-1995', '987654321', 'Male');
SELECT * FROM SupplierInvoice 
SELECT * FROM SupplierInvoiceDetail WHERE SupplierInvoiceDetail.SupplierInvoiceID = 11
SELECT * FROM InventoryDetail
SELECT * FROM Product