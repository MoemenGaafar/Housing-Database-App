Use Monkey 
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
CREATE PROCEDURE SelectCitAppByMEMPID
	-- Add the parameters for the stored procedure here
	@NationalID int,
	@AStatus char(1),
	@ProjectID int
AS
IF (@AStatus = 'L' AND @ProjectID = -1)
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", UnitID As "Unit Number", Name As "Company",
	FirstName + ' ' + LastName As "Citizen Name", Citizen.NationalID as "Citizen ID", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status" 
    FROM  Company, CitApplication, Citizen, Project
	WHERE MEmployeeID = @NationalID AND CitizenID = NationalID AND CID = CompanyID AND ProjectID = Project.ID
	ORDER BY ProjectID, UnitID
END
ELSE IF (@AStatus = 'L')
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", UnitID As "Unit Number", Name As "Company",
	FirstName + ' ' + LastName As "Citizen Name", Citizen.NationalID as "Citizen ID", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status" 
    FROM  Company, CitApplication, Citizen, Project
	WHERE MEmployeeID = @NationalID AND CitizenID = NationalID AND CID = CompanyID AND ProjectID = Project.ID
	AND ProjectID = @ProjectID
	ORDER BY ProjectID, UnitID
END
ELSE IF (@ProjectID = -1)
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", UnitID As "Unit Number", Name As "Company",
	FirstName + ' ' + LastName As "Citizen Name", Citizen.NationalID as "Citizen ID", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status" 
    FROM  Company, CitApplication, Citizen, Project
	WHERE MEmployeeID = @NationalID AND CitizenID = NationalID AND CID = CompanyID AND ProjectID = Project.ID
	AND AStatus = @AStatus
	ORDER BY ProjectID, UnitID
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", UnitID As "Unit Number", Name As "Company",
	FirstName + ' ' + LastName As "Citizen Name", Citizen.NationalID as "Citizen ID", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status" 
    FROM  Company, CitApplication, Citizen, Project
	WHERE MEmployeeID = @NationalID AND CitizenID = NationalID AND CID = CompanyID AND ProjectID = Project.ID
	AND ProjectID = @ProjectID AND AStatus = @AStatus
	ORDER BY ProjectID, UnitID
END
