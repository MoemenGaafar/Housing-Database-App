USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Admin]    Script Date: 5/12/2020 10:22:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[Insert_Admin] 
	-- Add the parameters for the stored procedure here
	@Name varchar(50), 
	@Password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	Insert into Administrator
	values(@Name, @Password)
END
