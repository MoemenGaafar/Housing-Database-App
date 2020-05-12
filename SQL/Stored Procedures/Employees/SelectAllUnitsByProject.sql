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
CREATE PROCEDURE SelectAllUnitsByProject
	-- Add the parameters for the stored procedure here
	@PID int,
	@UStatus bit
AS
IF (@UStatus is NULL)
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT ProjectID As "Project ID", Unit.ID As "Unit Number", Name As "Company", NoRooms As "Number of Rooms", NoRooms * PricePRoom as Price,
	PaymentEndDate As "Payment Deadline"
    FROM HousingEmployee, Unit, Project, Company
	WHERE PID = @PID AND PID = ProjectID And PID = Project.ID AND Project.CompanyID = CID
	ORDER BY ProjectID, Unit.ID
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT ProjectID As "Project ID", Unit.ID As "Unit Number", Name As "Company", NoRooms As "Number of Rooms", NoRooms * PricePRoom as Price,
	PaymentEndDate As "Payment Deadline"
    FROM HousingEmployee, Unit, Project, Company
	WHERE PID = @PID AND PID = ProjectID And PID = Project.ID AND Project.CompanyID = CID AND UStatus = @UStatus
	ORDER BY ProjectID, Unit.ID
END
