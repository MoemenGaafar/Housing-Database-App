USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[LaunchProject]    Script Date: 5/16/2020 4:48:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[LaunchProject]
	@PID int
AS
BEGIN
    UPDATE Project
	SET PStatus = 'L', LaunchingDate = Convert(date, getdate())  
	WHERE ID = @PID
	Update Employee Set NoCompleteProj = NoCompleteProj + 1, NoCurrentProj = NoCurrentProj - 1
	Where NationalID = (Select PEmployeeID From Project Where ID = @PID)
	Update Company Set NoCompleteProj = NoCompleteProj + 1, NoCurrentProj = NoCurrentProj - 1
	Where CID = (Select CompanyID From Project Where ID = @PID)
END
