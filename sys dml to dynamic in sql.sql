--Sys DM SQL referencing entities--

CREATE TABLE SampleTable (
    Id INT,
    Name VARCHAR(50)
);


CREATE VIEW SampleView AS
SELECT Id, Name FROM SampleTable;

SELECT 
    referencing_schema_name,
    referencing_entity_name,
    referencing_id,
    referencing_class_desc
FROM 
    sys.dm_sql_referencing_entities ('dbo.SampleTable', 'OBJECT');


DROP VIEW SampleView;
DROP TABLE SampleTable;

--sp depends in sql server
CREATE TABLE SampleTable (
    Id INT,
    Name VARCHAR(50)
);


CREATE VIEW SampleView AS
SELECT Id, Name FROM SampleTable;


EXEC sp_depends 'dbo.SampleTable';


DROP VIEW SampleView;
DROP TABLE SampleTable;


--guid in sql server

CREATE TABLE SampleTable (
    Id UNIQUEIDENTIFIER DEFAULT NEWID(),
    Name VARCHAR(50)
);


INSERT INTO SampleTable (Name) VALUES ('John Doe');
INSERT INTO SampleTable (Name) VALUES ('Jane Smith');


SELECT * FROM SampleTable;


DROP TABLE SampleTable;

--how to check guid in sql server
DECLARE @SampleTable TABLE (Value VARCHAR(50));
INSERT INTO @SampleTable (Value) VALUES 
('6F9619FF-8B86-D011-B42D-00C04FC964FF'),
('invalid-guid'),
('123e4567-e89b-12d3-a456-426614174000');

-- Checking if the value is a valid GUID
SELECT 
    Value, 
    CASE 
        WHEN TRY_CONVERT(UNIQUEIDENTIFIER, Value) IS NOT NULL THEN 'Valid GUID'
        ELSE 'Invalid GUID'
    END AS GUID_Check
FROM 
    @SampleTable;

--dynamic in sql server

DECLARE @TableName NVARCHAR(128) = 'SampleTable';
DECLARE @SQL NVARCHAR(MAX);


SET @SQL = 'SELECT * FROM ' + QUOTENAME(@TableName);


EXEC sp_executesql @SQL;

