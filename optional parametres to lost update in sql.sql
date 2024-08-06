-----------optional parametres and merge staments-------
CREATE TABLE Employeespart2 (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10, 2)
);


INSERT INTO Employeespart2 (FirstName, LastName, DepartmentID, Salary)
VALUES 
('John', 'Doe', 1, 60000),
('Jane', 'Smith', 2, 80000),
('Alice', 'Johnson', 1, 55000),
('Bob', 'Brown', 3, 45000),
('Charlie', 'Davis', 2, 70000)


CREATE PROCEDURE GetEmployees
    @DepartmentID INT = NULL,  
    @Salary DECIMAL(10, 2) = 0 
AS
BEGIN
    
    SELECT EmployeeID, FirstName, LastName, DepartmentID, Salary
    FROM Employeespart2
    WHERE (DepartmentID = @DepartmentID OR @DepartmentID IS NULL)
      AND (Salary >= @Salary);
END
GO

EXEC GetEmployees;


CREATE TABLE SourceEmployees (
    EmployeeID INT,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10, 2)
);

INSERT INTO SourceEmployees (EmployeeID, FirstName, LastName, DepartmentID, Salary)
VALUES 
(1, 'John', 'Doe', 1, 65000),       
(2, 'Jane', 'Smith', 2, 85000),      
(6, 'Dave', 'Wilson', 3, 50000);     

-- Apply the MERGE statement
MERGE INTO Employeespart2 AS Target
USING SourceEmployees AS Source
ON Target.EmployeeID = Source.EmployeeID
WHEN MATCHED THEN
    UPDATE SET 
        Target.FirstName = Source.FirstName,
        Target.LastName = Source.LastName,
        Target.DepartmentID = Source.DepartmentID,
        Target.Salary = Source.Salary
WHEN NOT MATCHED BY TARGET THEN
    INSERT (EmployeeID, FirstName, LastName, DepartmentID, Salary)
    VALUES (Source.EmployeeID, Source.FirstName, Source.LastName, Source.DepartmentID, Source.Salary)
WHEN NOT MATCHED BY SOURCE THEN
    DELETE;

-------dirty reads in sql server--------
CREATE TABLE Mobile (
    MobileID INT PRIMARY KEY IDENTITY(1,1),
    Brand NVARCHAR(50),
    Model NVARCHAR(50),
    Price DECIMAL(10, 2)
);

INSERT INTO Mobile (Brand, Model, Price)
VALUES 
('Apple', 'iPhone 12', 999.99),
('Samsung', 'Galaxy S21', 799.99),
('Google', 'Pixel 5', 699.99);


BEGIN TRANSACTION;

UPDATE Mobile
SET Price = 899.99
WHERE Model = 'Galaxy S21';


SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

BEGIN TRANSACTION;

SELECT * FROM Mobile WHERE Model = 'Galaxy S21';

COMMIT TRANSACTION;



