-- coding asingment 0

CREATE SCHEMA CodeChall;
GO

DROP TABLE IF EXISTS Code0.Orders;
DROP TABLE IF EXISTS Code0.Products;
DROP TABLE IF EXISTS Code0.Customers;

CREATE TABLE CodeChall.Customers (
	ID INT
		NOT NULL,
	FirstName NVARCHAR(50)
		NOT NULL,
	LastName NVARCHAR(50)
		NOT NULL,
	CardNumber NVARCHAR(20)
		NOT NULL,
	CONSTRAINT Custom_PK PRIMARY KEY (ID)
);

CREATE TABLE CodeChall.Products (
	ID INT
		NOT NULL,
	[Name] NVARCHAR(100)
		NOT NULL,
	Price MONEY
		NOT NULL,
	CONSTRAINT prod_PK PRIMARY KEY (ID),
	CONSTRAINT PosPrice CHECK (Price >= 0)
);

CREATE TABLE CodeChall.Orders (
	ID INT
		NOT NULL,
	ProductID INT
		NOT NULL,
	CustomerID INT
		NOT NULL,
	CONSTRAINT ord_PK PRIMARY KEY (ID),
	CONSTRAINT OrdProd_fk FOREIGN KEY (ProductID) REFERENCES CodeChall.Orders (ID),
	CONSTRAINT Ordcust_fk FOREIGN KEY (CustomerID) REFERENCES CodeChall.Customers (ID)
);

-- just to keep the table definition sperate from the insertions
-- I know this isn't neccissary 
GO

INSERT INTO CodeChall.Products (ID, [Name], Price) VALUES 
	(1, 'Thing1', 1.99),
	(2, 'Thing2', 5.99),
	(3, 'Thing3', 100.00)
;

INSERT INTO CodeChall.Customers (ID, FirstName, LastName, CardNumber) VALUES 
	(1, 'First', 'Person', '1234-5678-9101-1213'),
	(2, 'Second', 'Someone', '9876-5432-1012-2435'),
	(3, 'Third', 'Whom', '5346-6577-3452-6345')
;

INSERT INTO CodeChall.Orders(ID, ProductID, CustomerID) VALUES 
	(1,2,3),
	(2,2,1),
	(3,1,2)
;



INSERT INTO CodeChall.Products (ID, [Name], Price) VALUES 
	(4, 'iPhone', 200);

	
INSERT INTO CodeChall.Customers (ID, FirstName, LastName, CardNumber) VALUES 
	(4, 'Tina', 'Smith', '2345-7654-2346-3454');

INSERT INTO CodeChall.Orders(ID, ProductID, CustomerID) VALUES 
	(4,4,4);

SELECT * FROM CodeChall.Orders;

SELECT o.ID as OrderID, o.CustomerID, p.Name as ProductName
FROM CodeChall.Orders as o INNER JOIN CodeChall.Products as p ON o.ProductID = p.ID
WHERE o.CustomerID = 4;



SELECT 
	(Select Price FROM CodeChall.Products WHERE [Name] = 'iPhone') 
	* count(o.ID)
	as TotalRevenue
FROM CodeChall.Orders as o INNER JOIN CodeChall.Products as p ON o.ProductID = p.ID
WHERE o.ProductID = 4;


UPDATE CodeChall.Products
SET Price = 250
WHERE [Name] = 'iPhone';