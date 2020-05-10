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
use Monkey 
go
CREATE PROCEDURE SelectProjectByHEMPID
	-- Add the parameters for the stored procedure here
	@NationalID int,
	@PStatus char(1),
	@City varchar(50)
AS
IF (@PStatus = 'A' AND @City = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT ID As "Project ID", City, PricePRoom As "Room Price",  FirstName + ' ' +LastName As "Manager", Name As "Company",
	       StartingDate As "Starting Date", LaunchingDate As "Launching Date"
     FROM Project, HousingEmployee, Employee, Company
	 WHERE NationalID = MEmployeeID AND CID = CompanyID AND EID = @NationalID AND PID = Project.ID
END
ELSE IF (@PStatus = 'A')
BEGIN
	SET NOCOUNT ON;
	SELECT ID As "Project ID", City, PricePRoom As "Room Price",  FirstName + ' ' +LastName As "Manager", Name As "Company",
	       StartingDate As "Starting Date", LaunchingDate As "Launching Date"
     FROM Project, HousingEmployee, Employee, Company WHERE NationalID = MEmployeeID AND CID = CompanyID
	 AND City = @City AND EID = @NationalID AND PID = Project.ID
END
ELSE IF (@City = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT ID As "Project ID", City, PricePRoom As "Room Price",  FirstName + ' ' +LastName As "Manager", Name As "Company",
	       StartingDate As "Starting Date", LaunchingDate As "Launching Date"
     FROM Project, HousingEmployee, Employee, Company WHERE NationalID = MEmployeeID AND CID = CompanyID  
	 AND PStatus = @PStatus AND EID = @NationalID AND PID = Project.ID
END
ELSE
BEGIN
	SET NOCOUNT ON;
    SELECT ID As "Project ID", City, PricePRoom As "Room Price",  FirstName + ' ' +LastName As "Manager", Name As "Company",
	       StartingDate As "Starting Date", LaunchingDate As "Launching Date"
     FROM Project, HousingEmployee, Employee, Company WHERE NationalID = MEmployeeID AND CID = CompanyID
	 AND PStatus = @PStatus AND City = @City AND EID = @NationalID AND PID = Project.ID
END
