USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[AddAdmin]    Script Date: 5/13/2020 2:50:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[AddAdmin] 
	-- Add the parameters for the stored procedure here
	@Username varchar(50), 
	@Password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
    -- Insert statements for procedure here
	Insert into Administrator
	values (@Username, @Password)
END
