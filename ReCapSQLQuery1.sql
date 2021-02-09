  
CREATE TABLE Colors(
	Id int PRIMARY KEY IDENTITY(1,1),
	[ColorName] nvarchar(50),
)

CREATE TABLE Brands(
	Id int PRIMARY KEY IDENTITY(1,1),
	[ColorName] nvarchar(50),
)

CREATE TABLE Cars(
	Id int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	DailyPrice decimal,
	ModelYear nvarchar(4),
	Description nvarchar(50),
	FOREIGN KEY (ColorId) REFERENCES Colors(Id),
	FOREIGN KEY (BrandId) REFERENCES Brands(Id)
)

