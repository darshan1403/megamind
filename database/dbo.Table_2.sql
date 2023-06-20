CREATE TABLE tblUserRegistration
(
	[Id] INT Identity(1,1)  PRIMARY KEY,
	[Name] varchar(20) NOT NULL,
	[Email] varchar(40) NOT NULL,
	[Phone] varchar(15) NOT NULL,
	[Address] varchar(100) ,
	[StateId] int FOREIGN KEY REFERENCES tblState(Id),
	[CityId] int FOREIGN KEY REFERENCES tblCity(Id)
)
