use storeDB;

SELECT * FROM People;
SELECT * FROM Products;

INSERT INTO Orders
VALUES	
(1, '2022-08-30', 3),
(2, '2012-03-14', 7),
(1, '2018-04-25', 5),
(10, '2017-09-20', 4),
(4, '2016-03-23', 2),
(3, '2017-04-30', 1),
(2, '2021-07-18', 8),
(5, '2020-09-21', 6);

INSERT INTO People
VALUES
(N'male', N'Sergey', N'Zakutko', N'sergeyzakutko2000@gmail.com', N'123123', NULL),
(N'male', N'Andrey', N'Zakutko', N'andreyzakutko@gmail.com', N'213123', NULL),
(N'male', N'Eduard', N'Barabash', N'eduardbarabash@gmail.com', N'77777777', NULL),
(N'male', N'Ivan', N'Ivanko', N'ivanivanov@gmail.com', N'9234234', NULL),
(N'male', N'Andrey', N'Andreyko', N'abdreyabdreyko@gmail.com', N'90825234', NULL),
(N'male', N'Anton', N'Antonko', N'antonantonko@gmail.com', N'2147816234', NULL),
(N'male', N'Yuriy', N'Yuiriyko', N'yuriyyuriyko@gmail.com', N'09235123', NULL),
(N'male', N'Eduard', N'Eduardko', N'eduardeduardko@gmail.com', N'25872345', NULL),
(N'male', N'Semen', N'Semenko', N'semensemenko@gmail.com', N'8237521387', NULL),
(N'male', N'Petro', N'Petrenko', N'petropetrenko@gmail.com', N'123123', NULL);

INSERT INTO Products
VALUES
('Iphone XR', 16000),
('Iphone XS', 14000),
('Iphone X', 11000),
('Iphone 11', 22000),
('Iphone 12', 25000),
('Iphone 12 Pro Max', 34000),
('Iphone 13', 27000),
('Iphone 13 Pro', 36000),
('Iphone 13 Pro Max', 40000),
('Iphone 8', 8000),
('Iphone 13 Mini', 26000);

