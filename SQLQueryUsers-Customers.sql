CREATE TABLE Users(
Id int PRIMARY KEY IDENTITY(1,1),
FirstName nvarchar(50),
LastName nvarchar(50),
Email nvarchar(50),
Password nvarchar(50)
)

CREATE TABLE Customers(
Id int PRIMARY KEY IDENTITY(1,1),
UserId int ,
CompanyName nvarchar(50),
FOREIGN KEY (UserId) REFERENCES Users(Id)
)
CREATE TABLE Rentals(
Id int PRIMARY KEY IDENTITY(1,1),
CarId int,
CustomerId int,
RentDate datetime,
ReturnDate datetime,
FOREIGN KEY (CarId) REFERENCES Cars(Id),
FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
)
