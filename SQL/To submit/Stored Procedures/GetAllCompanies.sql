USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[GetAllCompanies]    Script Date: 5/16/2020 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetAllCompanies]
	
AS
BEGIN
	SET NOCOUNT ON;
	Select CID As "Company ID", Password, Name AS "Company", NoCompleteProj As "Number of Completed Projects", NoCurrentProj as "Number of Current Projects", Rating, AvgProjectCost As "Average Project Cost"
	From Company
	ORDER BY CID
END
