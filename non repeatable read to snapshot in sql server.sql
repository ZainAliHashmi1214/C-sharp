--non repeatable read in sql server----

CREATE TABLE Bike (
    CarID INT PRIMARY KEY,
    Make VARCHAR(50),
    Model VARCHAR(50),
    Year INT,
    Price DECIMAL(10, 2)
);

INSERT INTO Bike (CarID, Make, Model, Year, Price) VALUES (1, 'Toyota', 'Camry', 2020, 24000.00);
INSERT INTO Bike (CarID, Make, Model, Year, Price) VALUES (2, 'Honda', 'Civic', 2019, 22000.00);
INSERT INTO Bike (CarID, Make, Model, Year, Price) VALUES (3, 'Ford', 'Mustang', 2021, 30000.00);
INSERT INTO Bike(CarID, Make, Model, Year, Price) VALUES (4, 'Chevrolet', 'Malibu', 2018, 18000.00);
INSERT INTO Bike (CarID, Make, Model, Year, Price) VALUES (5, 'BMW', '3 Series', 2022, 35000.00);

BEGIN TRANSACTION;

SELECT * FROM Bike WHERE CarID = 1;



SELECT * FROM Bike WHERE CarID = 1;

COMMIT TRANSACTION;

--Phantom read example----

BEGIN TRANSACTION;

SELECT * FROM Bike WHERE Price > 20000;

--serilizable in sql server----
-- Transaction 1
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN TRANSACTION;

SELECT * FROM Bike WHERE Price > 20000;

 INSERT INTO Bike (CarID, Make, Model, Year, Price) VALUES (6, 'Audi', 'A4', 2023, 32000.00);

COMMIT TRANSACTION;


 INSERT INTO Bike (CarID, Make, Model, Year, Price) VALUES (6, 'Audi', 'A4', 2023, 32000.00);

SELECT * FROM Bike WHERE Price > 20000;

COMMIT TRANSACTION;

-----snapshot in sql server------
-- Enable snapshot isolation for the database (run once)
ALTER DATABASE YourDatabaseName
SET ALLOW_SNAPSHOT_ISOLATION ON;

-- Transaction 1
SET TRANSACTION ISOLATION LEVEL SNAPSHOT;
BEGIN TRANSACTION;

SELECT * FROM Bike WHERE Price > 20000;

SELECT * FROM Bike WHERE Price > 20000;

COMMIT TRANSACTION;

