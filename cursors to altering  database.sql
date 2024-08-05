
------Cursors in sql server-------------
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName NVARCHAR(100),
    Salary DECIMAL(10, 2)
);

INSERT INTO Employees (EmployeeID, EmployeeName, Salary)
VALUES (1, 'Taqi', 50000),
       (2, 'Ali', 60000),
       (3, 'Kaif', 55000);

select * from Employees

DECLARE @EmployeeID INT;
DECLARE @EmployeeName NVARCHAR(100);
DECLARE @Salary DECIMAL(10, 2);
DECLARE @Bonus DECIMAL(10, 2) = 5000;


DECLARE employee_cursor CURSOR FOR
SELECT EmployeeID, EmployeeName, Salary
FROM Employees;


OPEN employee_cursor;


FETCH NEXT FROM employee_cursor INTO @EmployeeID, @EmployeeName, @Salary;

WHILE @@FETCH_STATUS = 0
BEGIN
 
    UPDATE Employees
    SET Salary = @Salary + @Bonus
    WHERE EmployeeID = @EmployeeID;

 
    FETCH NEXT FROM employee_cursor INTO @EmployeeID, @EmployeeName, @Salary;
END;

CLOSE employee_cursor;
DEALLOCATE employee_cursor;


SELECT * FROM Employees;

------Diffrent types of schemas in sql server--------
select * from sysobjects where xtype = 'U'

select distinct xtype from sysobjects 

select * from sys.tables

CREATE TABLE Books (
    BookID INT PRIMARY KEY,
    Title NVARCHAR(100),
    Author NVARCHAR(100)
);

IF NOT EXISTS (SELECT 1 FROM Books WHERE BookID = 1)
BEGIN
    INSERT INTO Books (BookID, Title, Author)
    VALUES (1, 'SQL Server Basics', 'Zain Hashmi');
END

-----Altering Database-----------
CREATE TABLE Employeespart1 (
    EmployeeID INT PRIMARY KEY,
    EmployeeName NVARCHAR(100),
    Salary DECIMAL(10, 2)
);

ALTER TABLE Employeespart1
ADD Department NVARCHAR(100);



