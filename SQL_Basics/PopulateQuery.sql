USE [SQL_Fundamentals];

INSERT INTO dbo.Products(Id, _Name, Brand, _Description, Price, Categories, Size, Gender, TypeOfEquipment, SupplementType ) VALUES
(1, 'Creatine Monohydrate', 'MyProtein', 'Good supplement.', 169.55, 'Supplements' , NULL, NULL, NULL, 'Creatine'),
(2, 'Creatine Ethyl Ester', 'GymBeam', 'Good supplement.', 172, 'Supplements' , NULL, NULL, NULL, 'Creatine'),
(3, 'Vitamin A', 'MyProtein', 'For muscle growth', 142.14, 'Supplements' , NULL, NULL, NULL, 'Vitamins'),
(4, 'Hex Dumbbells', 'MyProtein', 'Two identical bells at the end of dumbbells.', 120, 'Equipment' , NULL, NULL, 'Dumbbells', NULL),
(5, 'Cast Iron Kettlebells', 'GymBeam', 'Lifters who want to do two-handed movements like swings and goblet squats.', 99.99, 'Equipment' , NULL, NULL, 'Kettlebells', NULL),
(6, 'Powerlifting Belt', 'GymBeam', 'For heavy lifting.', 135.99, 'Equipment' , NULL, NULL, 'Weight Lifting Belts and Gym Gloves', NULL),
(7, 'T-shirt', 'GymShark', 'Cotton', 100, 'Clothes' , 'L', 'Men', NULL, NULL),
(8, 'Sport Bra', 'GymShark', 'Cool', 121, 'Clothes' , 'S', 'Woman', NULL, NULL),
(9, 'Sleeveless T-Shirts', 'MyProtein', 'For Runners', 180.99, 'Clothes' , 'XS', 'Kids', NULL, NULL),
(10, 'Hoodie', 'GymBeam', 'For Runners', 233.75, 'Clothes' , 'M', 'Men', NULL, NULL)
;



INSERT INTO dbo.Customers(Id, FirstName, LastName, Username, _Password) VALUES
(1,'Radu', 'Rusu', 'rusu.radu', 'password1'),
(2,'Ermin', 'Roman', 'roman.ermin', 'password2'),
(3,'Ovidiu', 'Bogosel', 'bogosel.ovidiu', 'password3'),
(4,'Flavius', 'Rosa', 'rosa.flavius', 'password4'),
(5,'David', 'Filimon', 'filimon.david', 'password5'),
(6,'Norbert', 'Bora', 'bora.norbert', 'password6'),
(7,'Alexandru', 'Bija', 'bija.alexandru', 'password7'),
(8,'Cezara', 'Pop', 'pop.cezara', 'password8'),
(9,'Chris', 'Carpineanu', 'carpineanu.chris', 'password9'),
(10,'Victor', 'Macinic', 'macinic.victor', 'password10')
;


INSERT INTO dbo.Orders(Id, TotalPrice) VALUES
(1, NULL),
(2, NULL),
(3, NULL),
(4, NULL),
(5, NULL),
(6, NULL),
(7, NULL),
(8, NULL),
(9, NULL),
(10, NULL)
;



INSERT INTO dbo.OrderProducts(Id, ProductId, OrderId) VALUES

(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 1, 2),
(5, 3, 2),
(6, 7, 2),
(7, 1, 3),
(8, 5, 4),
(9, 6, 4),
(10, 3, 5),
(11, 4, 5),
(12, 1, 6),
(13, 2, 6),
(14, 4, 7),
(15, 5, 7),
(16, 7, 7),
(17, 10, 8),
(18, 9, 8),
(19, 3, 9),
(20, 1, 10),
(21, 2, 10),
(22, 3, 10)
;
