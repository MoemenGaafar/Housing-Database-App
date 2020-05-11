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
CREATE PROCEDURE GetAllCompanies
	
AS
BEGIN
	SET NOCOUNT ON;
	Select CID As "Company ID", Name AS "Company", NoCompleteProj As "Number of Completed Projects", Rating, AvgProjectCost As "Average Project Cost"
	From Company
	ORDER BY CID
END
GO
