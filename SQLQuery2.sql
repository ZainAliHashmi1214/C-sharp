CREATE TABLE Customers (
    id INT PRIMARY KEY,
    name VARCHAR(100),
    dob DATE,
    age INT
);

INSERT INTO Customers (id, name, dob, age) VALUES (1, 'John Doe', '1990-01-15', 34);
INSERT INTO Customers (id, name, dob, age) VALUES (2, 'Jane Smith', '1985-05-23', 39);
INSERT INTO Customers (id, name, dob, age) VALUES (3, 'Sam Brown', '2000-11-10', 23);

select * from Customers


CREATE FUNCTION fn_GetEmployeeByAge (@age INT)
RETURNS TABLE
AS
RETURN 
(
    SELECT id, name, dob, age
    FROM Customers 
    WHERE age = @age
);

select * from fn_GetEmployeeByAge('age') where age  > 25



CREATE TABLE Customer (
    id INT PRIMARY KEY,
    name VARCHAR(100),
    dob DATE,
    age INT
);


INSERT INTO Customer (id, name, dob, age) VALUES (1, 'Zain Ali', '1990-01-15', 34);
INSERT INTO Customer (id, name, dob, age) VALUES (2, 'Taqi Bro', '1985-05-23', 39);
INSERT INTO Customer (id, name, dob, age) VALUES (3, 'Saud Bhai', '2000-11-10', 23);


CREATE FUNCTION fn_GetEmployeeByAge (@age INT)
RETURNS TABLE
AS
RETURN 
(
    SELECT id, name, dob, age
    FROM Customer 
    WHERE age = @age
);

SELECT * FROM fn_GetEmployeeByAge(23);

CREATE FUNCTION fn_GetEmployeeDetailsByAge (@age INT)
RETURNS @EmployeeDetails TABLE
(
    id INT,
    name VARCHAR(100),
    dob DATE,
    age INT,
    ageCategory VARCHAR(20)
)
AS
BEGIN
    INSERT INTO @EmployeeDetails (id, name, dob, age, ageCategory)
    SELECT id, name, dob, age,
        CASE 
            WHEN age < 30 THEN 'Young'
            WHEN age BETWEEN 30 AND 50 THEN 'Middle-aged'
            ELSE 'Senior'
        END
    FROM Customers
    WHERE age = @age;

    RETURN;
END;

SELECT * FROM fn_GetEmployeeDetailsByAge(34);

