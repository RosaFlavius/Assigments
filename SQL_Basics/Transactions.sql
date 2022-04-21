USE [SQL_Fundamentals];

BEGIN TRY
	BEGIN TRANSACTION

	UPDATE dbo.Customers
	SET Username = 'ROSA.FLAVIUS'
	WHERE FirstName LIKE 'Flavius'

	UPDATE dbo.Products
	SET Price = 128
	WHERE _Name LIKE 'Hex Dumbbells'

	UPDATE dbo.OrderProducts
	SET OrderId = 5
	WHERE ProductId = 1

	DELETE FROM dbo.Customers 
	WHERE FirstName = 'Norbert'

	DELETE FROM dbo.OrderProducts
	WHERE ProductId = 11

	COMMIT TRANSACTION
END TRY

BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH