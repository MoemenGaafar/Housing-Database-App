USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[SelectUnitsByProjectAndPrice]    Script Date: 5/12/2020 6:05:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SelectUnitsByProjectAndPrice] 
	-- Add the parameters for the stored procedure here
	@PID int, 
	@Price int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ProjectID, Unit.ID as UnitID, City as Location, NoRooms as RoomNumber, NoRooms * PricePRoom as Price From Unit, Project Where UStatus = 0 and Project.ID = ProjectID and NoRooms * PricePRoom <= @Price and ProjectID = @PID
END
