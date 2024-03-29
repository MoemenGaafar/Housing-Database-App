USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[ClaimCitApplication]    Script Date: 5/15/2020 7:51:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[ClaimCitApplication] 
	-- Add the parameters for the stored procedure here
	@Citizen int, 
	@Project int, 
	@Unit int
AS
BEGIN
declare @IsThere int
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

	Select @Isthere = count(*) from CitApplication where CitizenID = @Citizen and UnitID = @Unit and ProjectID = @Project 

    if(@IsThere = 0)
	begin 
	Insert into CitApplication 
	values (@Project, @Unit, @Citizen, 'D')
	end

	else 
	begin 
	Update CitApplication
	Set AStatus = 'D'
	Where CitizenID = @Citizen and ProjectID = @Project and UnitID = @Unit 
	end 

	Update Unit
	Set UStatus = 1, PaymentEndDate = DATEADD(year, 5, GETDATE()) 
	Where ProjectID = @Project and ID = @Unit

	Update CitApplication 
	Set AStatus = 'R'
	Where CitizenID != @Citizen and ProjectID = @Project and UnitID = @Unit

END
