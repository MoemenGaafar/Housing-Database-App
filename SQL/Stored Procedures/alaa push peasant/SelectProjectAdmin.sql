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
Create PROCEDURE SelectProjectAdmin 
	-- Add the parameters for the stored procedure here
	@PStatus char(1),
	@City varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF (@PStatus = 'A' AND @City = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT ID As "Project ID", City, PricePRoom As "Room Price", P.FirstName + ' ' +P.LastName As "Projects Employee", M.FirstName + ' ' +M.LastName As "Manager",
	 CASE WHEN PStatus = 'P' THEN 'Posted' WHEN PStatus = 'S' THEN 'Started' WHEN PStatus = 'L' THEN 'Launched' ELSE 'All units sold' END As "Project Status",
	 Name As "Company", StartingDate As "Starting Date", LaunchingDate As "Launching Date"
     FROM Employee as P, Employee as M, Project LEFT OUTER JOIN Company ON CID = CompanyID WHERE P.NationalID = PEmployeeID and M.NationalID = MEmployeeID
END
ELSE IF (@PStatus = 'A')
BEGIN
	SET NOCOUNT ON;
	SELECT ID As "Project ID", City, PricePRoom As "Room Price", P.FirstName + ' ' +P.LastName As "Projects Employee", M.FirstName + ' ' +M.LastName As "Manager", 
	 CASE WHEN PStatus = 'P' THEN 'Posted' WHEN PStatus = 'S' THEN 'Started' WHEN PStatus = 'L' THEN 'Launched' ELSE 'All units sold' END As "Project Status",
	 Name As "Company", StartingDate As "Starting Date", LaunchingDate As "Launching Date"
     FROM Employee as P, Employee as M, Project LEFT OUTER JOIN Company ON CID = CompanyID WHERE P.NationalID = PEmployeeID and M.NationalID = MEmployeeID
	 AND City = @City
END
ELSE IF (@City = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT ID As "Project ID", City, PricePRoom As "Room Price",  P.FirstName + ' ' +P.LastName As "Projects Employee", M.FirstName + ' ' +M.LastName As "Manager", 
	 CASE WHEN PStatus = 'P' THEN 'Posted' WHEN PStatus = 'S' THEN 'Started' WHEN PStatus = 'L' THEN 'Launched' ELSE 'All units sold' END As "Project Status",
	 Name As "Company", StartingDate As "Starting Date", LaunchingDate As "Launching Date"
     FROM Employee as P, Employee as M, Project LEFT OUTER JOIN Company ON CID = CompanyID WHERE P.NationalID = PEmployeeID and M.NationalID = MEmployeeID AND PStatus = @PStatus
END
ELSE
BEGIN
	SET NOCOUNT ON;
  	SELECT ID As "Project ID", City, PricePRoom As "Room Price", P.FirstName + ' ' +P.LastName As "Projects Employee", M.FirstName + ' ' +M.LastName As "Manager", 
	 CASE WHEN PStatus = 'P' THEN 'Posted' WHEN PStatus = 'S' THEN 'Started' WHEN PStatus = 'L' THEN 'Launched' ELSE 'All units sold' END As "Project Status",
	 Name As "Company", StartingDate As "Starting Date", LaunchingDate As "Launching Date"
     FROM Employee as P, Employee as M, Project LEFT OUTER JOIN Company ON CID = CompanyID WHERE P.NationalID = PEmployeeID and M.NationalID = MEmployeeID AND PStatus = @PStatus AND City = @City
END
END
