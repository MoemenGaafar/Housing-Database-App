USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[AssignCompany]    Script Date: 5/16/2020 4:50:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[AssignCompany]  
	-- Add the parameters for the stored procedure here
	@Project int, 
	@Company int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	Update Project 
	Set CompanyID = @Company, StartingDate = GetDate() 
	Where ID = @Project 
	Update Company Set NoCurrentProj = NoCurrentProj + 1
	Where CID = @Company
END
