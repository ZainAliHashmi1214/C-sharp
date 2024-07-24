CREATE TABLE departments (
    department_id INT PRIMARY KEY,
    department_name VARCHAR(100)
);

CREATE TABLE employees12 (
    employee_id INT PRIMARY KEY,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    department_id INT,
    salary DECIMAL(10, 2),
    FOREIGN KEY (department_id) REFERENCES departments(department_id)
);

INSERT INTO departments (department_id, department_name) VALUES
(1, 'HR'),
(2, 'Sales'),
(3, 'IT');

INSERT INTO employees12 (employee_id, first_name, last_name, department_id, salary) VALUES
(101, 'John', 'Doe', 1, 60000.00),
(102, 'Jane', 'Smith', 2, 75000.00),
(103, 'Alice', 'Johnson', 3, 80000.00),
(104, 'Bob', 'Brown', 2, 72000.00);


create view VwEmployees12
as 
SELECT e.employee_id, e.first_name, e.last_name, d.department_name, e.salary
FROM employees12 e
INNER JOIN departments d ON e.department_id = d.department_id;

select * from VwEmployees12



CREATE VIEW Salary AS
SELECT e.employee_id, e.first_name, e.last_name, d.department_name, e.salary
FROM employees12 e
INNER JOIN departments d ON e.department_id = d.department_id
WHERE e.salary = 60000.00;

select * from Salary



CREATE TABLE manager (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    gender CHAR(1),
    department_id INT
);


INSERT INTO manager (id, name, gender, department_id)
VALUES
(1, 'Zain', 'F', 101),
(2, 'Ali', 'M', 102),
(3, 'hashmi', 'F', 103),
(4, 'ok', 'M', 104),
(5, 'yes', 'F', 105);


CREATE TABLE manager_log (
    log_id INT  PRIMARY KEY,
    manager_id INT,
    old_name VARCHAR(50),
    new_name VARCHAR(50),
    change_time TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);



CREATE TRIGGER after_manager_update
AFTER UPDATE ON manager
FOR EACH ROW
BEGIN
    INSERT INTO manager_log (manager_id, old_name, new_name)
    VALUES (OLD.id, OLD.name, NEW.name);
END 



CREATE TABLE department (
    department_id INT PRIMARY KEY,
    department_name VARCHAR(50)
);


CREATE TABLE employees (
    employee_id INT PRIMARY KEY,
    employee_name VARCHAR(50),
    department_id INT,
    FOREIGN KEY (department_id) REFERENCES departments(department_id)
);

CREATE VIEW employee_department AS
SELECT 
    e.employee_id,
    e.employee_name,
    d.department_name
FROM 
    employees e
JOIN 
    departments d ON e.department_id = d.department_id;

CREATE TRIGGER instead_of_insert_employee_department
ON employee_department
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @dept_id INT;

    
    SELECT @dept_id = department_id 
    FROM department 
    WHERE department_name = (SELECT department_name FROM inserted);

    
    INSERT INTO employees (employee_id, employee_name, department_id)
    SELECT employee_id, employee_name, @dept_id
    FROM inserted;
END;


INSERT INTO employee_department (employee_id, employee_name, department_name)
VALUES (1, 'nothing', 'if');

SELECT * FROM employees;



 

