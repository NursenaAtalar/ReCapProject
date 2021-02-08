CREATE TABLE Cars(
	CarID int PRIMARY KEY IDENTITY(1,1),
	BrandID int,
	ColorID int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID)
)

CREATE TABLE Colors(
	ColorID int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),
)

CREATE TABLE Brands(
	BrandID int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)


INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','1','2008','200','Second Hand'),
	('1','2','2014','275','New'),
	('2','3','2013','270','New'),
	('3','1','2000','100','Second Hand');

INSERT INTO Colors(ColorName)
VALUES
	('Black'),
	('DarkBlue'),
	('white');


INSERT INTO Brands(BrandName)
VALUES
	('Audi'),
	('BMW'),
	('Hyundai');
