INSERT INTO Employee (EmployeeName, Birthday, PhoneNumber, IdCardNumber, Gender)
VALUES
    ('Tuan Thanh', '1990-05-15', '0123456789', 'ID123456', 'Male'),
    ('Thanh Dong', '1985-09-20', '0987654321', 'ID789012', 'Female'),
    ('Phuc Binh', '1995-02-10', '0765432109', 'ID456789', 'Male'),
    ('Quoc Dung', '1988-07-22', '0345678901', 'ID987654', 'Female'),
    ('Robert White', '1992-11-18', '0890123456', 'ID654321', 'Male'),
    ('Emily Brown', '1993-06-03', '0567890123', 'ID321098', 'Female'),
    ('David Miller', '1987-03-27', '0456789012', 'ID789123', 'Male'),
    ('Sophie Turner', '1991-09-15', '0678901234', 'ID234567', 'Female'),
    ('Michael Clark', '1989-12-08', '0234567890', 'ID567890', 'Male'),
    ('Emma Wilson', '1994-04-30', '0789012345', 'ID012345', 'Female');

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
    (1, 'Rice', 20000, 'Kg', 'Pack', 5, 200),
    (2, 'Smartphone', 6800000, 'Piece', 'Piece', 1, 200),
    (3, 'T-Shirt', 150000, 'Piece', 'Piece', 1, 100),
    (4, 'Refrigerator', 20000000, 'Piece', 'Piece', 1, 20),
    (5, 'Book', 30000, 'Piece', 'Piece', 1, 500),
    (6, 'Toy Car', 50000, 'Piece', 'Piece', 1, 1000),
    (7, 'Sofa', 3000000, 'Piece', 'Piece', 1, 20),
    (8, 'Lipstick', 500000, 'Piece', 'Piece', 1, 200),
    (9, 'Tennis Racket', 250000, 'Piece', 'Piece', 1, 50),
    (10, 'Notebook', 20000, 'Piece', 'Piece', 1, 1000);

INSERT INTO Shelf (ShelfID, ShelfFloor, ProductTypeID, LayerQuantity, LayerCapacity, Status)
VALUES
    (101, 1, 1, 5, 20, 'Active'),
    (102, 2, 2, 3, 15, 'Inactive'),
    (103, 3, 3, 4, 25, 'Active'),
    (104, 2, 4, 2, 10, 'Active'),
    (105, 3, 5, 3, 15, 'Inactive'),
    (106, 1, 6, 1, 5, 'Active'),
    (107, 3, 7, 2, 10, 'Active'),
    (108, 2, 8, 3, 15, 'Inactive'),
    (109, 1, 9, 4, 20, 'Active'),
    (110, 2, 10, 2, 10, 'Active');

INSERT INTO ShelfDetail (ShelfID, ProductID, ProductQuantity)
VALUES
    (101, 1, 50),
    (102, 2, 10),
    (103, 3, 30),
    (104, 4, 5),
    (105, 5, 20),
    (106, 6, 2),
    (107, 7, 15),
    (108, 8, 8),
    (109, 9, 10),
    (110, 10, 50);

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
    ('Alice Johnson', '1988-07-12', '0123456780', 'Female'),
    ('Bob Smith', '1992-04-25', '0987654322', 'Male'),
    ('Eva Davis', '1995-11-30', '0765432101', 'Female'),
    ('Tom Brown', '1987-09-02', '0345678902', 'Male'),
    ('Olivia Wilson', '1993-12-18', '0890123453', 'Female'),
    ('Jack Taylor', '1991-05-07', '0567890124', 'Male'),
    ('Sophia Miller', '1989-03-15', '0456789015', 'Female'),
    ('Daniel Clark', '1994-08-29', '0678901236', 'Male'),
    ('Grace Turner', '1985-01-23', '0234567897', 'Female'),
    ('Benjamin White', '1990-06-10', '0789012348', 'Male');

INSERT INTO CustomerInvoice (CustomerID, EmployeeID, DatePayment, TotalAmount)
VALUES
    (1, 1, '2024-01-13', 200000),
    (2, 2, '2024-01-14', 6800000), 
    (3, 3, '2024-01-15', 30000), 
    (4, 4, '2024-01-16', 40000000), 
    (5, 5, '2024-01-17', 150000), 
    (6, 6, '2024-01-18', 50000),   
    (7, 7, '2024-01-19', 3000000), 
    (8, 8, '2024-01-20', 1000000), 
    (9, 9, '2024-01-21', 2500000),  
    (10, 10, '2024-01-22', 80000); 

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
    (1, '2024-01-23', 'Supplier A', 300000),
    (2, '2024-01-24', 'Supplier B', 54400000),
    (3, '2024-01-25', 'Supplier C', 375000),
    (4, '2024-01-26', 'Supplier D', 100000000),
    (5, '2024-01-27', 'Supplier E', 540000),
    (6, '2024-01-28', 'Supplier F', 600000),
    (7, '2024-01-29', 'Supplier G', 12000000),
    (8, '2024-01-30', 'Supplier H', 5000000),
    (9, '2024-01-31', 'Supplier I', 500000),
    (10, '2024-02-01', 'Supplier J', 120000);

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
