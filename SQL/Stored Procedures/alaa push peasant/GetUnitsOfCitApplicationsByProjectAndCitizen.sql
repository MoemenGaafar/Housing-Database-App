USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[GetUnitsOfCitApplicationsByProjectAndCitizen]    Script Date: 5/13/2020 6:20:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetUnitsOfCitApplicationsByProjectAndCitizen] 
	-- Add the parameters for the stored procedure here
	@Project int, 
	@Citizen int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UnitID from CitApplication where CitizenID = @Citizen and ProjectID = @Project and AStatus = 'D'
END
