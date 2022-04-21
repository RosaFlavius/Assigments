USE [SQL_Fundamentals];

SELECT FirstName
FROM dbo.Customers;

SELECT *
FROM dbo.Customers;

SELECT FirstName, LastName
FROM dbo.Customers
WHERE LastName LIKE 'R___';

SELECT *
FROM dbo.Customers
ORDER BY FirstName;

SELECT *
FROM dbo.Customers
ORDER BY FirstName DESC;

SELECT *
FROM dbo.Products;

SELECT TOP 4 _Name, Price
FROM dbo.Products;

SELECT TOP 4 _Name, Price
FROM dbo.Products
WHERE Price > 120;

SELECT _Name, Brand
FROM dbo.Products
WHERE _Name LIKE '[h]%';

SELECT _Name, Price
FROM dbo.Products
WHERE _Name LIKE '[^hir]%';

SELECT _Name as 'Product Name', Brand as 'Product Brand'
FROM dbo.Products;

SELECT COUNT(Id) as 'Number of products'
FROM dbo.Products
GROUP BY Categories
ORDER BY COUNT(Id) DESC;

SELECT SUM(dbo.Products.Price) as 'Total Price' FROM dbo.Orders
JOIN dbo.OrderProducts ON dbo.Orders.Id = dbo.OrderProducts.OrderId 
JOIN dbo.Products ON dbo.Products.Id = dbo.OrderProducts.ProductId 
GROUP BY dbo.Orders.Id



