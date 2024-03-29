USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[GetCitApplicationsByCitizen]    Script Date: 5/11/2020 12:18:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetCitApplicationsByCitizen]
	-- Add the parameters for the stored procedure here
@Citizen int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT CitApplication.ProjectID, UnitID, Case When AStatus = 'R' Then 'Rejected' When AStatus = 'W' Then 'Waiting' End, PricePRoom * NoRooms as UnitPrice 
	from CitApplication, Unit, Project 
	where CitizenID = @Citizen and Unit.ProjectID = CitApplication.ProjectID and Unit.ID = UnitID and Project.ID = CitApplication.ProjectID and (AStatus = 'R' or AStatus = 'W')
END
