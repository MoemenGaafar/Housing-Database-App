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
CREATE PROCEDURE GetAllEmployees
AS
BEGIN
	SET NOCOUNT ON;
	Select NationalID As "National ID", FirstName+' '+LastName AS "Name", CASE WHEN Sex = 'M' THEN 'Male' ELSE 'Female' END As Sex, 
	CASE WHEN EType = 'M' THEN 'Manager' WHEN EType = 'P' THEN 'Projects' ELSE 'Housing' END As "Position",
	StartDate As "Start Date", NoCompleteProj As "Number of Completed Projects", NoCurrentProj As "Number of Current Projects"
	From Employee
	ORDER BY EType
END
GO
