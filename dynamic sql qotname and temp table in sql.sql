CREATE TABLE Employees (
    EmployeeID UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100)
);

INSERT INTO Employees (FirstName, LastName, Email)
VALUES 
('Zain', 'Ali', 'zain.smith@example.com'),
('kaif', 'ali', 'ali.johnson@example.com'),
('hussian', 'saud', 'noone.brown@example.com');

--dynamic sql and qoutname in sql server

DECLARE @sql NVARCHAR(MAX);
DECLARE @ColumnName NVARCHAR(128) = 'FirstName'; 
DECLARE @Value NVARCHAR(50) = 'Alice'; 

SET @sql = N'SELECT * FROM Employees WHERE ' + QUOTENAME(@ColumnName) + ' = @Value';
EXEC sp_executesql @sql, N'@Value NVARCHAR(50)', @Value;

--temp tables in sql server
CREATE TABLE #TempEmployees (
    EmployeeID UNIQUEIDENTIFIER,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100)
);


INSERT INTO #TempEmployees (EmployeeID, FirstName, LastName, Email)
EXEC sp_executesql @sql, N'@Value NVARCHAR(50)', @Value;


SELECT * FROM #TempEmployees;


DROP TABLE #TempEmployees;

