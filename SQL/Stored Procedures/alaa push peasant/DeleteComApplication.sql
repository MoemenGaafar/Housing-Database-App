USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[DeleteComApplication]    Script Date: 5/13/2020 11:44:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[DeleteComApplication] 
	-- Add the parameters for the stored procedure here
	@Company varchar(50), 
	@Project int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	Delete from ComApplication 
	where ProjectId = @Project and CompanyID = (Select CID from Company where Name = @Company)
END
