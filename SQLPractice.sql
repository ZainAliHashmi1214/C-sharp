--To find last generated identity column
CREATE TABLE CompEmployees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100)
);


INSERT INTO CompEmployees (FirstName, LastName, Email) 
VALUES ('Zain', 'Ali', 'Zain.Ali@example.com');

SELECT SCOPE_IDENTITY() AS LastGeneratedIdentity;

--Applying unique key constraints
ALTER TABLE ComEmployees
ADD CONSTRAINT UQ_Email UNIQUE (Email);


CREATE TABLE Employee (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100)
);
select * from Employee

ALTER TABLE Employee
ADD CONSTRAINT UQ_Email UNIQUE (Email);


--Select Statements in Sql server
SELECT EmployeeID, FirstName, Email FROM Employee;


CREATE TABLE EmployeesSelect (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Department NVARCHAR(50),
    Salary DECIMAL(10, 2)
);


INSERT INTO EmployeesSelect (FirstName, LastName, Department, Salary) 
VALUES ('Zain', 'Hashmi', 'HR', 60000),
       ('Ali', 'Hashmi', 'HR', 65000),
       ('Taqi', 'Hashmi', 'IT', 80000),
       ('Farman', 'Hashmi', 'IT', 75000);


SELECT Department, AVG(Salary) AS AverageSalary
FROM EmployeesSelect
GROUP BY Department;

--joins statement in sql server

CREATE TABLE JoinDepartments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName NVARCHAR(50)
);


INSERT INTO JoinDepartments (DepartmentID, DepartmentName) 
VALUES (1, 'HR'),
       (2, 'IT');


CREATE TABLE JoinEmployees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Salary DECIMAL(10, 2),
    DepartmentID INT
);

INSERT INTO JoinEmployees (FirstName, LastName, Salary, DepartmentID) 
VALUES ('Zain', 'Hashmi', 60000, 1),
       ('Ali', 'Hashmi', 65000, 1),
       ('Taqi', 'Hashmi', 80000, 2),
       ('Farman', 'Hashmi', 75000, 2);


SELECT D.DepartmentName, AVG(E.Salary) AS AverageSalary
FROM joinEmployees E
JOIN joinDepartments D ON E.DepartmentID = D.DepartmentID
GROUP BY D.DepartmentName;

--Advanced joins in sql server
SELECT E.EmployeeID, E.FirstName, E.LastName, D.DepartmentName, E.Salary
FROM joinEmployees E
LEFT JOIN joinDepartments D ON E.DepartmentID = D.DepartmentID;
--For right join just replace left key word with right
--For full join just replace left key word with full

--Self join in sql server
-- Create the selfJoinTable
CREATE TABLE selfJoinTable (
    ID INT PRIMARY KEY,
    Name NVARCHAR(50),
    ManagerID INT  
);

INSERT INTO selfJoinTable (ID, Name, ManagerID)
VALUES (1,'Zain',NULL),
       (2,'ALi',1),
	   (3,'Hashmi',1),
 ( 4,'Hashmi',2);

 
SELECT e.Name AS Employee, m.Name AS Manager
FROM selfJoinTable e
LEFT JOIN selfJoinTable m ON e.ManagerID = m.ID;










