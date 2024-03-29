USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[ChangeComApplicationStatus]    Script Date: 5/16/2020 4:53:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ChangeComApplicationStatus]
	-- Add the parameters for the stored procedure here
	@ProjectID int,
	@CompanyName varchar(50),
	@NewStatus char(1)
AS
BEGIN
	UPDATE ComApplication 
	SET AStatus = @NewStatus
	WHERE ProjectID = @ProjectID AND CompanyID in (SELECT CID From Company Where Name = @CompanyName)
    
	if (@NewStatus = 'D')
	Begin

	Update Project 
	SET PStatus = 'S', StartingDate = GetDate()
	Where ID = @ProjectID 

	Update Company Set NoCurrentProj = NoCurrentProj + 1
	Where CID = (Select CID From Company Where Name = @CompanyName)

	UPDATE ComApplication 
	SET AStatus = 'R'
	WHERE ProjectID = @ProjectID AND CompanyID not in (SELECT CID From Company Where Name = @CompanyName)

	END

END
