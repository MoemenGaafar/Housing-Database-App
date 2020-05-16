USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[ChangeProjectStatus]    Script Date: 5/15/2020 6:57:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[ChangeProjectStatus] 
	-- Add the parameters for the stored procedure here
	@Project int, 
	@NewStatus char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	Update Project Set PStatus = @NewStatus Where ID = @Project 
	if (@NewStatus = 'P')
	Begin 
	Update Project Set CompanyID = null, StartingDate = null, LaunchingDate = null Where ID = @Project 
	END
	if (@NewStatus = 'L' or @NewStatus = 'F')
	Begin 
	Update Project Set LaunchingDate = GetDate(), StartingDate = GetDate() Where ID = @Project 
	END
END
