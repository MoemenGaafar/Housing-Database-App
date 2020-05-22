Use Monkey 
go
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SelectPostedProjects
    @CID int,
	@MinRoomPrice int,
	@City varchar(50)
AS
IF (@MinRoomPrice = 0 AND @City = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT ID As "Project ID", City, PricePRoom As "Room Price",  FirstName + ' ' +LastName As "Manager"
	FROM Project, Employee
	WHERE MEmployeeID = NationalID AND PStatus = 'P' AND ID not in (SELECT ProjectID FROM ComApplication WHERE CompanyID = @CID)
END
ELSE IF (@MinRoomPrice = 0)
BEGIN
	SET NOCOUNT ON;
	SELECT ID As "Project ID", City, PricePRoom As "Room Price",  FirstName + ' ' +LastName As "Manager"
	FROM Project, Employee
	WHERE MEmployeeID = NationalID AND PStatus = 'P' AND City = @City AND ID not in (SELECT ProjectID FROM ComApplication WHERE CompanyID = @CID)
END
ELSE IF (@City = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT ID As "Project ID", City, PricePRoom As "Room Price",  FirstName + ' ' +LastName As "Manager"
	FROM Project, Employee
	WHERE MEmployeeID = NationalID AND PStatus = 'P' AND PricePRoom >= @MinRoomPrice AND ID not in (SELECT ProjectID FROM ComApplication WHERE CompanyID = @CID)
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT ID As "Project ID", City, PricePRoom As "Room Price",  FirstName + ' ' +LastName As "Manager"
	FROM Project, Employee
	WHERE MEmployeeID = NationalID AND PStatus = 'P' AND PricePRoom >= @MinRoomPrice AND City = @City AND ID not in (SELECT ProjectID FROM ComApplication WHERE CompanyID = @CID)
END
GO
