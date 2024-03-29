USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[DeleteProject]    Script Date: 5/16/2020 4:59:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[DeleteProject]
	-- Add the parameters for the stored procedure here
	@Project int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	Delete from Project where ID = @Project

	Update Employee 
	Set NoCurrentProj = NoCurrentProj - 1
	Where NationalID = (Select MEmployeeID from project where ID = @Project) or NationalID = (Select PEmployeeID from project where ID = @Project)
END
