CREATE PROCEDURE UpdateDatabase
	@Id int,
	@Name varchar (20) ,
	@Email varchar(40),
	@Phone varchar(15),
	@Address varchar(100) = '',
	@State varchar(20) ,
	@City varchar(20)
AS
declare		@CityId as INT,
		@StateId as INT;
select @CityId = [Id] from tblCity where CityName = @City;
select @StateId = [Id] from tblState where State = @State;
	update tblUserRegistration set Name = @Name, Email = @Email, Phone = @Phone,Address = @Address, StateId = @StateId ,CityId = @CityId where Id = @Id