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

CREATE PROCEDURE SelectComAppByMEMPID
	-- Add the parameters for the stored procedure here
	@NationalID int,
	@AStatus char(1),
	@ProjectID int
AS
IF (@AStatus = 'L' AND @ProjectID = -1)
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", Name As "Company", BiddingPrice As "Bidding Price", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status" 
    FROM Company, ComApplication
	WHERE  CID = CompanyID 
	AND ProjectID in (SELECT ID from Project where MEmployeeID = @NationalID)
	ORDER BY ProjectID, BiddingPrice
END
ELSE IF (@AStatus = 'L')
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", Name As "Company", BiddingPrice As "Bidding Price", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status" 
    FROM Company, ComApplication
	WHERE  CID = ComApplication.CompanyID 
	AND ProjectID = @ProjectID
	ORDER BY BiddingPrice
END
ELSE IF (@ProjectID = -1)
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", Name As "Company", BiddingPrice As "Bidding Price", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status" 
    FROM Company, ComApplication
	WHERE  CID = ComApplication.CompanyID 
	AND ProjectID in (SELECT ID from Project where MEmployeeID = @NationalID) AND AStatus = @AStatus
	ORDER BY BiddingPrice
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT ProjectID As "Project ID", Name As "Company", BiddingPrice As "Bidding Price", 
	CASE WHEN AStatus = 'W' THEN 'Waiting' WHEN AStatus = 'A' THEN 'Accepted' WHEN AStatus = 'R' THEN 'Rejected' ELSE 'Done' END As "Application Status" 
    FROM Company, ComApplication
	WHERE  CID = ComApplication.CompanyID 
	AND ProjectID = @ProjectID AND AStatus = @AStatus
	ORDER BY BiddingPrice
END
