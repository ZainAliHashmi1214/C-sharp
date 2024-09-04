
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Department NVARCHAR(50)
);


INSERT INTO Employees (EmployeeID, FirstName, LastName, Department)
VALUES 
(1, 'John', 'Doe', 'Sales'),
(2, 'Jane', 'Smith', 'HR'),
(3, 'Sam', 'Brown', 'IT'),
(4, 'Lisa', 'Johnson', 'Sales');

-------dynamic sql
-- Using EXEC 
DECLARE @TableName NVARCHAR(128) = 'Employees';
DECLARE @SQL NVARCHAR(MAX) = 'SELECT * FROM ' + QUOTENAME(@TableName);
EXEC(@SQL);

-- Using sp_executesql 
DECLARE @SQL NVARCHAR(MAX) = 'SELECT * FROM Employees WHERE Department = @Dept';
DECLARE @Dept NVARCHAR(50) = 'Sales';
EXEC sp_executesql @SQL, N'@Dept NVARCHAR(50)', @Dept = @Dept;

-- stored procdure approaches
CREATE PROCEDURE GetEmployeesByDepartment
    @Department NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Employees WHERE Department = @Department;
END;


EXEC GetEmployeesByDepartment @Department = 'Sales';




