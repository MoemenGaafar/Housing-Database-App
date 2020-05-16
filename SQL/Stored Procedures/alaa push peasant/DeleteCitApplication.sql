USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCitApplication]    Script Date: 5/13/2020 11:58:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[DeleteCitApplication] 
	-- Add the parameters for the stored procedure here
	@Citizen int, 
	@Project int,
	@Unit int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
    -- Insert statements for procedure here
	Delete from CitApplication Where CitizenID = @Citizen and ProjectID = @Project and UnitID = @Unit 
END
