USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllUnitsByProject]    Script Date: 5/15/2020 8:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SelectAllUnitsByProject]
	-- Add the parameters for the stored procedure here
	@PID int,
	@UStatus bit
AS
IF (@UStatus is NULL)
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT ProjectID As "Project ID", Unit.ID As "Unit Number", Name As "Company", NoRooms As "Number of Rooms", NoRooms * PricePRoom as Price, Case when UStatus = 0 then 'Not Sold' when UStatus = 1 then 'Sold' End as "Status" , 
	PaymentEndDate As "Payment Deadline"
    FROM Unit, Project, Company
	WHERE ProjectID = @PID And Project.ID = @PID AND Project.CompanyID = CID
	ORDER BY ProjectID, Unit.ID
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT ProjectID As "Project ID", Unit.ID As "Unit Number", Name As "Company", NoRooms As "Number of Rooms", NoRooms * PricePRoom as Price, Case when UStatus = 0 then 'Not Sold' when UStatus = 1 then 'Sold' End as "Status", 
	PaymentEndDate As "Payment Deadline"
    FROM Unit, Project, Company
	WHERE ProjectID = @PID And Project.ID = @PID AND Project.CompanyID = CID AND UStatus = @UStatus
	ORDER BY ProjectID, Unit.ID
END
