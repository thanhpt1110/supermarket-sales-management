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
CREATE TABLE Shelf (
    ShelfID INT PRIMARY KEY ,
    ShelfFloor INT,
    ProductTypeID INT,
    LayerQuantity INT,
    LayerCapacity INT,
    Status NVARCHAR(max),
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

GO

INSERT INTO Employee (EmployeeName, Birthday, PhoneNumber, IdCardNumber, Gender)
VALUES
    ('Tuan Thanh', '15-05-1990', '0123456789', 'ID123456', 'Male'),
    ('Thanh Dong', '20-09-1985', '0987654321', 'ID789012', 'Female'),
    ('Phuc Binh', '10-02-1995', '0765432109', 'ID456789', 'Male'),
    ('Quoc Dung', '22-07-1988', '0345678901', 'ID987654', 'Female'),
    ('Robert White', '18-11-1992', '0890123456', 'ID654321', 'Male'),
    ('Emily Brown', '03-06-1993', '0567890123', 'ID321098', 'Female'),
    ('David Miller', '27-03-1987', '0456789012', 'ID789123', 'Male'),
    ('Sophie Turner', '15-09-1991', '0678901234', 'ID234567', 'Female'),
    ('Michael Clark', '08-12-1989', '0234567890', 'ID567890', 'Male'),
    ('Emma Wilson', '30-04-1994', '0789012345', 'ID012345', 'Female');


INSERT INTO Account (EmployeeID, Username, Password, Role)
VALUES
    (1, 'admin', '123', 'Admin'),
    (2, 'employee', '123', 'Employee'),
    (3, 'manager', '123', 'Manager'),
    (4, 'admin1', '123', 'Employee'),
    (5, 'robert_white', 'keypass456', 'Admin'),
    (6, 'emily_brown', 'secure789', 'Employee'),
    (7, 'david_miller', 'admin123', 'Manager'),
    (8, 'sophie_turner', 'pass456', 'Employee'),
    (9, 'michael_clark', 'admin789', 'Admin'),
    (10, 'emma_wilson', 'secure123', 'Manager');

INSERT INTO ProductType (ProductTypeName, Description, MinTemperature, MaxTemperature)
VALUES
    ('Groceries', 'Basic food items', 5, 25),
    ('Electronics', 'Electronic gadgets', 0, 40),
    ('Clothing', 'Apparel and accessories', 10, 30),
    ('Appliances', 'Home appliances', 5, 35),
    ('Books', 'Reading materials', 15, 25),
    ('Toys', 'Children''s toys', 0, 30),
    ('Furniture', 'Home furniture', 10, 25),
    ('Beauty', 'Cosmetics and beauty products', 5, 30),
    ('Sports', 'Sports equipment', 5, 35),
    ('Stationery', 'Office and school supplies', 10, 25);

INSERT INTO Product (ProductTypeID, ProductName, UnitPrice, WholeSaleUnit, RetailUnit, UnitConversion, ProductCapacity)
VALUES
    (1, 'Rice', 20000, 'Kg', 'Pack', 5, 5),
    (2, 'Smartphone', 6800000, 'Piece', 'Piece', 1, 2),
    (3, 'T-Shirt', 150000, 'Piece', 'Piece', 1, 2),
    (4, 'Refrigerator', 20000000, 'Piece', 'Piece', 1, 5),
    (5, 'Book', 30000, 'Piece', 'Piece', 1, 2),
    (6, 'Toy Car', 50000, 'Piece', 'Piece', 1, 2),
    (7, 'Sofa', 3000000, 'Piece', 'Piece', 1, 10),
    (8, 'Lipstick', 500000, 'Piece', 'Piece', 1, 2),
    (9, 'Tennis Racket', 250000, 'Piece', 'Piece', 1, 2),
    (10, 'Notebook', 20000, 'Piece', 'Piece', 1, 1);

INSERT INTO Shelf (ShelfID, ShelfFloor, ProductTypeID, LayerQuantity, LayerCapacity, Status)
VALUES
    (101, 1, 1, 5, 20, 'Active'),
    (201, 2, 2, 3, 15, 'Inactive'),
    (301, 3, 3, 4, 25, 'Active'),
    (202, 2, 4, 2, 10, 'Active'),
    (302, 3, 5, 3, 15, 'Inactive'),
    (102, 1, 6, 1, 5, 'Active'),
    (303, 3, 7, 2, 10, 'Active'),
    (203, 2, 8, 3, 15, 'Inactive'),
    (103, 1, 9, 4, 20, 'Active'),
    (204, 2, 10, 2, 10, 'Active');

INSERT INTO ShelfDetail (ShelfID, ProductID, ProductQuantity)
VALUES
    (101, 1, 20),
    (201, 2, 10),
    (301, 3, 30),
    (202, 4, 3),
    (302, 5, 20),
    (102, 6, 2),
    (303, 7, 1),
    (203, 8, 5),
    (103, 9, 10),
    (204, 10, 20);

INSERT INTO InventoryDetail (ProductID, ProductQuantity)
VALUES
    (1, 100),
    (2, 20),
    (3, 50),
    (4, 8),
    (5, 30),
    (6, 5),
    (7, 25),
    (8, 15),
    (9, 20),
    (10, 100);

INSERT INTO Customer (CustomerName, Birthday, PhoneNumber, Gender)
VALUES
    ('Alice Johnson', '12-07-1988', '0123456780', 'Female'),
    ('Bob Smith', '25-04-1992', '0987654322', 'Male'),
    ('Eva Davis', '30-11-1995', '0765432101', 'Female'),
    ('Tom Brown', '02-09-1987', '0345678902', 'Male'),
    ('Olivia Wilson', '18-12-1993', '0890123453', 'Female'),
    ('Jack Taylor', '07-05-1991', '0567890124', 'Male'),
    ('Sophia Miller', '15-03-1989', '0456789015', 'Female'),
    ('Daniel Clark', '29-08-1994', '0678901236', 'Male'),
    ('Grace Turner', '23-01-1985', '0234567897', 'Female'),
    ('Benjamin White', '10-06-1990', '0789012348', 'Male');

INSERT INTO CustomerInvoice (CustomerID, EmployeeID, DatePayment, TotalAmount)
VALUES
    (1, 1, '04-01-2024', 200000),
    (2, 2, '05-01-2024', 13600000),
    (3, 3, '06-01-2024', 450000),
    (4, 4, '07-01-2024', 200000000),
    (5, 5, '08-01-2024', 2700000),
    (6, 6, '09-01-2024', 50000),
    (7, 7, '10-01-2024', 12000000),
    (8, 8, '11-01-2024', 7500000),
    (9, 9, '12-01-2024', 5000000),
    (10, 10, '13-01-2024', 1600000);

INSERT INTO CustomerInvoiceDetail (CustomerInvoiceID, ProductID, ProductQuantity)
VALUES
    (1, 1, 10),
    (2, 2, 1),
    (3, 3, 2),
    (4, 4, 2),
    (5, 5, 8),
    (6, 6, 1),
    (7, 7, 1),
    (8, 8, 2),
    (9, 9, 10),
    (10, 10, 4);

-- Insert data into SupplierInvoice table
INSERT INTO SupplierInvoice (EmployeeID, DatePayment, SupplierName, TotalAmount)
VALUES 
    (1, '23-01-2024', 'Supplier A', 300000),
    (2, '24-01-2024', 'Supplier B', 54400000),
    (3, '25-01-2024', 'Supplier C', 375000),
    (4, '26-01-2024', 'Supplier D', 100000000),
    (5, '27-01-2024', 'Supplier E', 540000),
    (6, '28-01-2024', 'Supplier F', 600000),
    (7, '29-01-2024', 'Supplier G', 12000000),
    (8, '30-01-2024', 'Supplier H', 5000000),
    (9, '31-01-2024', 'Supplier I', 500000),
    (10, '01-02-2024', 'Supplier J', 120000);


-- Insert data into SupplierInvoiceDetail table
INSERT INTO SupplierInvoiceDetail (SupplierInvoiceID, ProductID, ProductQuantity)
VALUES 
    (1, 1, 15),
    (2, 2, 8),
    (3, 3, 25),
    (4, 4, 5),
    (5, 5, 18),
    (6, 6, 12),
    (7, 7, 4),
    (8, 8, 10),
    (9, 9, 2),
    (10, 10, 6);

