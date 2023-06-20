CREATE TABLE [tblCity]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[StateId] INT NOT NULL Foreign Key REFERENCES tblState(Id),
	[CityName] varchar(20) NOT NULL
)
