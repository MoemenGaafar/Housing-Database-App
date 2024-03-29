USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[GiveUpCitApplication]    Script Date: 5/15/2020 3:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GiveUpCitApplication] 
	-- Add the parameters for the stored procedure here
	@Citizen int, 
	@Project int, 
	@Unit int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update CitApplication
	Set AStatus = 'R'
	Where CitizenID = @Citizen and ProjectID = @Project and UnitID = @Unit
END
