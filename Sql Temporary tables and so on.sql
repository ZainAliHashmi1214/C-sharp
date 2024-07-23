
CREATE TABLE #LocalTemp (
    ID INT,
    Name VARCHAR(50)
);

INSERT INTO #LocalTemp (ID, Name)
VALUES (1, 'Alice'), (2, 'Bob');

SELECT * FROM #LocalTemp;

DROP TABLE #LocalTemp;


CREATE TABLE ##GlobalTemp (
    ID INT,
    Name VARCHAR(50)
);

INSERT INTO ##GlobalTemp (ID, Name)
VALUES (3, 'Charlie'), (4, 'David');

SELECT * FROM ##GlobalTemp;

DROP TABLE ##GlobalTemp;

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT
);


CREATE UNIQUE INDEX idx_EmployeeID ON Employees(EmployeeID);


CREATE TABLE Orders (
    OrderID INT,
    OrderDate DATE,
    CustomerID INT,
    Amount DECIMAL(10, 2)
);


CREATE CLUSTERED INDEX idx_OrderID ON Orders(OrderID);


INSERT INTO Orders (OrderID, OrderDate, CustomerID, Amount)
VALUES (1, '2023-01-01', 101, 150.00),
       (2, '2023-01-02', 102, 200.00),
       (3, '2023-01-03', 103, 250.00);

SELECT * FROM Orders;


DROP INDEX idx_OrderID ON Orders;


CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    CategoryID INT,
    Price DECIMAL(10, 2)
);


CREATE NONCLUSTERED INDEX idx_ProductName ON Products(ProductName);


INSERT INTO Products (ProductID, ProductName, CategoryID, Price)
VALUES (1, 'Laptop', 1, 1200.00),
       (2, 'Smartphone', 2, 800.00),
       (3, 'Tablet', 1, 300.00);


SELECT ProductID, ProductName, Price
FROM Products
WHERE ProductName = 'Laptop';


DROP INDEX idx_ProductName ON Products;

CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Salary DECIMAL(10, 2),
    Gender CHAR(1),
    City VARCHAR(50)
);


INSERT INTO Customer (FirstName, LastName, Salary, Gender, City)
VALUES 
    ('Zain', 'ALi', 50000.00, 'M', 'New York'),
    ('Hashmi', 'Taqi', 60000.00, 'F', 'Los Angeles'),
    ('Some', 'one', 55000.00, 'M', 'Chicago'),
    ('kaif', 'hahsmi', 70000.00, 'F', 'Houston'),
    ('saud', 'farman', 65000.00, 'M', 'Phoenix');


SELECT * FROM Customer;

