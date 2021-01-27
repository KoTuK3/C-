create database  RentDB
go

use RentDB
go

create table Users
(
	[Id] int PRIMARY KEY NOT NULL IDENTITY(1,1),
	[Login] nvarchar(MAX) NOT NULL check(Login <> ''),
	[Password] nvarchar(MAX) NOT NULL check(Password <> '')
)
create table Departments
(
	[Id] int PRIMARY KEY NOT NULL IDENTITY(1,1),
	[Name] nvarchar(MAX) NOT NULL check(Name <> ''),
	[Square] int NOT NULL check(Square > 0),
	[Address] nvarchar(MAX) NOT NULL check(Address <> ''),
)
go

create table Rents
(
	[Id] int PRIMARY KEY NOT NULL IDENTITY(1,1),
	[StartDate] date NOT NULL,
	[EndDate] date NOT NULL,

	UserId int,
	FOREIGN KEY (UserId) REFERENCES Users(Id),
	DepartmentId int,
	FOREIGN KEY (DepartmentId) REFERENCES Departments(Id)
)