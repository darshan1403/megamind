CREATE PROCEDURE getSingleRecord
	@Id int
AS
	SELECT tb1.Id,tb1.Name,tb1.Email,tb1.Phone as Phone_No,tb1.Address,tb2.CityName as City,tb3.State from tblUserRegistration as tb1 join tblCity as tb2 on tb1.CityId = tb2.Id join tblState as tb3 on tb1.StateId = tb3.Id  where tb1.Id = @Id