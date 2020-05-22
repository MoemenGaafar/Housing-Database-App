use Monkey 
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

CREATE PROCEDURE SelectComAppByCompanyID
	-- Add the parameters for the stored procedure here
	@CID int,
	@AStatus char(1),
	@ProjectID int
AS
IF (@AStatus = 'L' AND @ProjectID = -1)
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", FirstName+' '+LastName As "Manager", BiddingPrice As "Bidding Price", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status"
    FROM ComApplication, Employee, Project
	WHERE  @CID = ComApplication.CompanyID And ProjectID = Project.ID AND MEmployeeID = NationalID
	ORDER BY ProjectID, BiddingPrice
END
ELSE IF (@AStatus = 'L')
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", FirstName+' '+LastName As "Manager", BiddingPrice As "Bidding Price", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status"
    FROM ComApplication, Employee, Project
	WHERE  @CID = ComApplication.CompanyID And ProjectID = Project.ID AND MEmployeeID = NationalID
	AND ProjectID = @ProjectID
	ORDER BY BiddingPrice
END
ELSE IF (@ProjectID = -1)
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", FirstName+' '+LastName As "Manager", BiddingPrice As "Bidding Price", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status"
    FROM ComApplication, Employee, Project
	WHERE  @CID = ComApplication.CompanyID And ProjectID = Project.ID AND MEmployeeID = NationalID AND AStatus = @AStatus
	ORDER BY ProjectID, BiddingPrice 
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", FirstName+' '+LastName As "Manager", BiddingPrice As "Bidding Price", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status"
    FROM ComApplication, Employee, Project
	WHERE  @CID = ComApplication.CompanyID And ProjectID = Project.ID AND MEmployeeID = NationalID AND AStatus = @AStatus AND @ProjectID = ProjectID
	ORDER BY ProjectID, BiddingPrice  
END
