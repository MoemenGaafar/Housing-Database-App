USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Project]    Script Date: 5/16/2020 6:03:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[Insert_Project]
	-- Add the parameters for the stored procedure here 
	@City varchar(50),
	@MEmployeeID int,
	@PEmployeeID int,
	@PricePRoom int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

    -- Insert statements for procedure here
	INSERT INTO Project(City, MEmployeeID, PEmployeeID, PricePRoom)
	Values(@City,@MEmployeeID,@PEmployeeID,@PricePRoom)

	Update Employee 
	Set NoCurrentProj = NoCurrentProj + 1
	Where NationalID = @MEmployeeID or NationalID = @PEmployeeID
END
