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
CREATE PROCEDURE SelectProjectByID
   @PID int
	
AS
BEGIN
	SET NOCOUNT ON;
	Select City As "City", MEmployeeID As "Manager ID", PEmployeeID As "Projects Employee ID", StartingDate As "Starting Date",
	LaunchingDate As "Launching Date", Name As "Company Name", PricePRoom As "Room Price",
	CASE WHEN PStatus = 'P' THEN 'Posted' WHEN PStatus = 'S' THEN 'Started' WHEN PStatus = 'L' THEN 'Launched' ELSE 'All units sold' END As "Project Status"
	From Project LEFT OUTER JOIN Company ON CompanyID = CID where ID = @PID
END
GO
