USE [SQL_Fundamentals];

CREATE TABLE [dbo].[Products](
		Id INT NOT NULL PRIMARY KEY,
		_Name NVARCHAR(30) NOT NULL,
		 Brand NVARCHAR(30) NOT NULL,
		_Description NVARCHAR(100),
		Price FLOAT NOT NULL,
		Categories VARCHAR(20) NOT NULL CHECK(Categories IN('Supplements', 'Equipment', 'Clothes')),
		Size VARCHAR(20) CHECK(Size IN('XS', 'S', 'M', 'L', 'XL', 'XXL')),
		Gender VARCHAR(20) CHECK(Gender IN('Men', 'Woman', 'Kids')),
		TypeOfEquipment VARCHAR(40) CHECK(TypeOfEquipment IN('Dumbbells', 'Kettlebells', 'Gym Benches', '"Weight Racks', 'Pull Up and Push Up Bars', 'Weight Lifting Belts and Gym Gloves', 'Weight Plates and Bars')),
		SupplementType VARCHAR(20) CHECK(SupplementType IN('Creatine', 'Proteins', 'Weight Gainers', 'Vitamins', 'Food and snacks')),
);

CREATE TABLE [dbo].[Customers](
		Id INT NOT NULL PRIMARY KEY,
		FirstName NVARCHAR(30) NOT NULL,
		LastName NVARCHAR(30) NOT NULL,
		Username NVARCHAR(30) NOT NULL,
		_Password NVARCHAR(30) NOT NULL,
);

CREATE TABLE [dbo].[Orders](
		Id INT NOT NULL PRIMARY KEY,
		TotalPrice FLOAT,
);

CREATE TABLE [dbo].[OrderProducts](
		Id INT NOT NULL PRIMARY KEY,
		ProductId INT NOT NULL FOREIGN KEY REFERENCES Products(Id),
		OrderId INT NOT NULL FOREIGN KEY REFERENCES Orders(Id),
);






