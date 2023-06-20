CREATE PROCEDURE DeleteFromDatabase
	@Id int 
AS
	Delete from tblUserRegistration where Id = @Id