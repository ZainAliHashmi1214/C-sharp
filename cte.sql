CREATE TABLE updateablecte (
    EmployeeID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Salary DECIMAL(18, 2)
);

INSERT INTO updateablecte (EmployeeID, FirstName, LastName, Salary)
VALUES
(1, 'Zain', 'ALi', 60000),
(2, 'Kaif', 'Hashmi', 75000),
(3, 'Taqi', 'Turkey', 80000);

WITH CTE_UpdateSalary AS (
    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        Salary
    FROM 
        updateablecte
    WHERE 
        Salary < 70000
)
UPDATE CTE_UpdateSalary
SET Salary = Salary * 1.10;


SELECT * FROM updateablecte;


ALTER TABLE updateablecte
ADD ManagerID INT NULL;


UPDATE updateablecte
SET ManagerID = NULL
WHERE EmployeeID = 1;

UPDATE updateablecte
SET ManagerID = 1
WHERE EmployeeID = 2;

UPDATE updateablecte
SET ManagerID = 2
WHERE EmployeeID = 3;

select * from updateablecte


WITH EmployeeHierarchy AS (    
    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        Salary,
        ManagerID,
        1 AS Level
    FROM 
        updateablecte
    WHERE 
        ManagerID IS NULL

    UNION ALL

 
    SELECT 
        e.EmployeeID,
        e.FirstName,
        e.LastName,
        e.Salary,
        e.ManagerID,
        eh.Level + 1 AS Level
    FROM 
        updateablecte e
    INNER JOIN 
        EmployeeHierarchy eh ON e.ManagerID = eh.EmployeeID
)
SELECT 
    EmployeeID,
    FirstName,
    LastName,
    Salary,
    ManagerID,
    Level
FROM 
    EmployeeHierarchy
ORDER BY 
    Level, ManagerID;

