USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[GetDoneCitApplicationsByCitizen]    Script Date: 5/11/2020 6:12:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetDoneCitApplicationsByCitizen] 
	-- Add the parameters for the stored procedure here
	@Citizen int
AS
BEGIN
    
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	

	SELECT CitApplication.ProjectID, UnitID, PricePRoom * NoRooms as UnitPrice, PaymentEndDate, (PricePRoom * NoRooms) - (Select Coalesce(Sum(Amount), 0) from CitTransaction where CitizenID = @Citizen and ProjectID = CitApplication.ProjectID and UnitID = CitApplication.UnitID ) as RemainingPayment 
	from CitApplication, Unit, Project 
	where CitizenID = @Citizen and Unit.ProjectID = CitApplication.ProjectID and Unit.ID = UnitID and AStatus = 'D' and Project.ID = CitApplication.ProjectID
END
