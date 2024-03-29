USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[SelectUnitsByProject]    Script Date: 5/15/2020 8:02:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SelectUnitsByProject] 
	-- Add the parameters for the stored procedure here
	@PID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ProjectID, Unit.ID as UnitID, City as Location, NoRooms as RoomNumber, NoRooms * PricePRoom as Price From Unit, Project Where UStatus = 0 and ProjectID = @PID and Project.ID = ProjectID
END
