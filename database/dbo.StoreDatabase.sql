CREATE PROCEDURE StoreDatabase
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
	Insert Into tblUserRegistration (Name,Email,Phone,Address,StateId,CityId) values (@Name,@Email,@Phone,@Address,@StateId,@CityId)