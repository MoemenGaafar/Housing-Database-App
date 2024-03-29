USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmployees]    Script Date: 5/16/2020 6:04:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetAllEmployees]
AS
BEGIN
	SET NOCOUNT ON;
	Select NationalID As "National ID", Password, FirstName+' '+LastName AS "Name", CASE WHEN Sex = 'M' THEN 'Male' ELSE 'Female' END As Sex, 
	CASE WHEN EType = 'M' THEN 'Manager' WHEN EType = 'P' THEN 'Projects' ELSE 'Housing' END As "Position",
	StartDate As "Start Date", NoCompleteProj As "Number of Completed Projects", NoCurrentProj As "Number of Current Projects"
	From Employee
	ORDER BY EType
END
