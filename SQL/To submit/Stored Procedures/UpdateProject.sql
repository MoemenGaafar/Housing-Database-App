USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[UpdateProject]    Script Date: 5/15/2020 3:10:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[UpdateProject] 
	-- Add the parameters for the stored procedure here
	@Status char(1), 
	@ID int,
	@City varchar(50),
    @MEmployeeID int, 
    @PEmployeeID int,
    @PricePRoom int, 
    @CompanyID int, 
    @StartingDate date,	
    @LaunchingDate date

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	if (@Status = 'L')
	Begin 
	Update Project 
	Set City = @City, MEmployeeID = @MEmployeeID, PEmployeeID = @PEmployeeID, PricePRoom = @PricePRoom, CompanyID = @CompanyID, StartingDate = @StartingDate, LaunchingDate = @LaunchingDate   
	Where ID = @ID
	End 
	else if (@Status = 'S')
	Begin 
	Update Project 
	Set City = @City, MEmployeeID = @MEmployeeID, PEmployeeID = @PEmployeeID, PricePRoom = @PricePRoom, CompanyID = @CompanyID, StartingDate = @StartingDate, LaunchingDate = null   
	Where ID = @ID
	End
	else if (@Status = 'P')
	Begin 
	Update Project 
	Set City = @City, MEmployeeID = @MEmployeeID, PEmployeeID = @PEmployeeID, PricePRoom = @PricePRoom, CompanyID = null, StartingDate = null, LaunchingDate = null   
	Where ID = @ID
	End

END
