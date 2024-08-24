------Grouping id function in sql server------
CREATE TABLE Sales (
    Region VARCHAR(50),
    Product VARCHAR(50),
    SalesAmount DECIMAL(10, 2)
);

INSERT INTO Sales (Region, Product, SalesAmount) VALUES
('North', 'Laptop', 1500.00),
('North', 'Tablet', 800.00),
('South', 'Laptop', 1200.00),
('South', 'Tablet', 600.00),
('West', 'Laptop', 1800.00),
('West', 'Tablet', 1000.00);

SELECT
    Region,
    Product,
    SUM(SalesAmount) AS TotalSales,
    GROUPING_ID(Region, Product) AS GroupingLevel
FROM
    Sales
GROUP BY
    GROUPING SETS (
        (Region, Product),
        (Region),
        (Product),
        ()
    )
ORDER BY
    GroupingLevel,
    Region,
    Product;

--------row number in sql server-------
SELECT
    ROW_NUMBER() OVER (ORDER BY Region, Product) AS RowNum,
    Region,
    Product,
    SUM(SalesAmount) AS TotalSales,
    GROUPING_ID(Region, Product) AS GroupingLevel
FROM
    Sales
GROUP BY
    GROUPING SETS (
        (Region, Product),
        (Region),
        (Product),
        ()
    )
ORDER BY
    GroupingLevel,
    Region,
    Product;

--------rank and dense rank in sql server------------
SELECT
    ROW_NUMBER() OVER (ORDER BY Region, Product) AS RowNum,
    RANK() OVER (ORDER BY Region, Product) AS RankNum,
    DENSE_RANK() OVER (ORDER BY Region, Product) AS DenseRankNum,
    Region,
    Product,
    SUM(SalesAmount) AS TotalSales,
    GROUPING_ID(Region, Product) AS GroupingLevel
FROM
    Sales
GROUP BY
    GROUPING SETS (
        (Region, Product),
        (Region),
        (Product),
        ()
    )
ORDER BY
    GroupingLevel,
    Region,
    Product;

----ntile function in sql server--------
SELECT
    NTILE(3) OVER (ORDER BY Region, Product) AS TileNum,
    ROW_NUMBER() OVER (ORDER BY Region, Product) AS RowNum,
    RANK() OVER (ORDER BY Region, Product) AS RankNum,
    DENSE_RANK() OVER (ORDER BY Region, Product) AS DenseRankNum,
    Region,
    Product,
    SUM(SalesAmount) AS TotalSales,
    GROUPING_ID(Region, Product) AS GroupingLevel
FROM
    Sales
GROUP BY
    GROUPING SETS (
        (Region, Product),
        (Region),
        (Product),
        ()
    )
ORDER BY
    TileNum,
    GroupingLevel,
    Region,
    Product;

--------lead & lad function in sql server----------
SELECT
    Region,
    Product,
    SUM(SalesAmount) AS TotalSales,
    LAG(SUM(SalesAmount), 1, 0) OVER (ORDER BY Region, Product) AS PreviousSales,
    LEAD(SUM(SalesAmount), 1, 0) OVER (ORDER BY Region, Product) AS NextSales,
    GROUPING_ID(Region, Product) AS GroupingLevel
FROM
    Sales
GROUP BY
    GROUPING SETS (
        (Region, Product),
        (Region),
        (Product),
        ()
    )
ORDER BY
    GroupingLevel,
    Region,
    Product;

