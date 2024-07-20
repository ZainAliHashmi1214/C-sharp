select * from Employees
SELECT LEFT(firstName, 2) AS first_two_characters FROM Employees;

SELECT Right(firstName, 2) AS first_two_characters FROM Employees;

select CHARINDEX ('i','zainhashmi')

select SUBSTRING ('ZainHashmi',5,6)




SELECT SUBSTRING(
    'Zain@gmail.com', 
    CHARINDEX('@', 'Zain@gmail.com') + 1, 
    LEN('Zain@gmail.com') - CHARINDEX('@', 'Zain@gmail.com')
) 

SELECT * FROM emaildomain;

SELECT 
    SUBSTRING(
        email, 
        CHARINDEX('@', email) + 1, 
        LEN(email) - CHARINDEX('@', email)
    ) AS domain,
    COUNT(email) AS Total
FROM emaildomain
GROUP BY 
    SUBSTRING(
        email, 
        CHARINDEX('@', email) + 1, 
        LEN(email) - CHARINDEX('@', email)
    );

select REPLICATE ('zain pro', 3)

SELECT email, REPLICATE('*', 5) AS replicated_string FROM emaildomain;

SELECT email + SPACE(5) AS email_with_spaces FROM emaildomain;

SELECT email, REPLACE(email, 'example', 'sample') AS replaced_email FROM emaildomain;

SELECT email, 
       STUFF(email, CHARINDEX('@', email) + 1, LEN(email), 'domain.com') AS stuffed_email 
FROM emaildomain;

CREATE TABLE datetimeexample (
    id INT PRIMARY KEY IDENTITY(1,1),
    sample_datetime DATETIME NOT NULL
);


INSERT INTO Pakdatetimeexample (sample_datetime) VALUES
('2024-07-09 10:15:30'),
('2023-12-25 08:00:00'),
('2024-01-01 00:00:00'),
('2022-02-14 14:30:00'),
('2023-11-11 11:11:11');

SELECT 
    sample_datetime,
    CURRENT_TIMESTAMP AS current_timestamp,               
    SYSDATETIME() AS sysdatetime,                         
    SYSUTCDATETIME() AS sysutcdatetime,                   
    SYSDATETIMEOFFSET() AS sysdatetimeoffset,             
    GETUTCDATE() AS getutcdate                            
FROM datetime_example;

SELECT 
    '2024-07-09' AS DateString,
    ISDATE('2024-07-09') AS IsDate;  

SELECT 
    '2023/12/25' AS DateString,
    ISDATE('2023/12/25') AS IsDate;  

SELECT 
    '25-12-2023' AS DateString,
    ISDATE('25-12-2023') AS IsDate;  

SELECT 
    '2023-11-11T10:00:00' AS DateString,
    ISDATE('2023-11-11T10:00:00') AS IsDate; 
	
select day(getdate())
select day('01/02/2026')

select day(getdate())
select MOnth('01/02/2026')

select day(getdate())
select Year('01/02/2026')

select datename (day, '2011-10-10 12:34:45.89')

select datename (WEEKDAY, '2011-10-10 12:34:45.89')
select datename (WEEKDAY, '2004-03-18 12:34:45.89')
select datename (WEEKDAY, '2000-01-24 12:34:45.89')

SELECT DATEPART(MONTH, '2024-07-10') AS MonthPart;

select datepart(year, '2000-07-10') as yearpart;

SELECT DATEADD(DAY, 7, '2024-07-10') AS NewDate;


SELECT DATEADD(DAY, -7, '2024-07-10') AS NewDate;

select  dbo.fnCompute('3/18/2004')

create function fnCompute(@DOB DATETIME)
returns nvarchar(50)
as 
begin
DECLARE  @tempdate DATETIME, @years INT, @months INT, @days INT;



SET @tempdate = @DOB


SELECT @years = DATEDIFF(YEAR, @tempdate, GETDATE()) - 
           CASE 
               WHEN (MONTH(@DOB) > MONTH(GETDATE())) 
                    OR (MONTH(@DOB) = MONTH(GETDATE()) AND DAY(@DOB) > DAY(GETDATE()))
               THEN 1 
               ELSE 0 
           END;


SET @tempdate = DATEADD(YEAR, @years, @tempdate);


SELECT @months = DATEDIFF(MONTH, @tempdate, GETDATE()) - 
           CASE 
               WHEN DAY(@tempdate) > DAY(GETDATE())
               THEN 1 
               ELSE 0 
           END;


SET @tempdate = DATEADD(MONTH, @months, @tempdate);


SELECT @days = DATEDIFF(DAY, @tempdate, GETDATE());

declare @Age nvarchar(50)
set @age = cast(@years as nvarchar(4)) + 'Years' +  
cast(@months as nvarchar(4)) + 'Months' + cast(@days as nvarchar(2)) + 'Days old'
return @age
end

CREATE TABLE Persons (
    Id INT PRIMARY KEY IDENTITY(1,1), 
    Name NVARCHAR(100),               
    Sdob DATE                         
);
INSERT INTO Persons (Name, Sdob)
VALUES 
('Zain Ali', '1990-05-15'),
('Zain Hashmi', '1985-08-23'),
('Taqi turkey', '1978-12-04'),
('Farman Collge', '2001-01-19');

select * from Persons

select Id,Name,Sdob,  CAST(Sdob as nvarchar) as ConvertedDOB From Persons 
select Id,Name,Sdob,  Convert(nvarchar, Sdob ) as ConvertedDOB From Persons



SELECT Id, Name, Name + ' - ' + CAST(Id AS NVARCHAR) AS [Name - Id]
FROM Persons;

CREATE TABLE registration (
    id INT PRIMARY KEY,
    email VARCHAR(255) NOT NULL,
    registration_date DATE
);

INSERT INTO registration (id, email, registration_date) VALUES
(4, 'bob.miller@example.com', '2023-07-04'),
(5, 'carol.wilson@example.com', '2023-07-05'),
(6, 'david.brown@example.com', '2023-07-06'),
(7, 'eve.davis@example.com', '2023-07-07'),
(8, 'frank.clark@example.com', '2023-07-08'),
(9, 'grace.hall@example.com', '2023-07-09'),
(10, 'harry.lewis@example.com', '2023-07-10');

select * from registration

select cast(registration_date as date) as newcolum, count(id) as total
from registration
group by cast(registration_date as date)

select floor (rand()* 100)

declare @counter int
set @counter = 1
while (@counter <=  10)
begin 
    print Floor (rand() * 1000)
	set @counter = @counter + 1
end

select round(78.2312, 2)



