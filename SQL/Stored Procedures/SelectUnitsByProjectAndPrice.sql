-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SelectUnitsByProjectAndPrice 
	-- Add the parameters for the stored procedure here
	@PID int, 
	@Price int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ProjectID, Unit.ID as UnitID, NoRooms as RoomNumber, NoRooms * PricePRoom as Price From Unit, Project Where UStatus = 0 and Project.ID = ProjectID and NoRooms * PricePRoom <= @Price and ProjectID = @PID
END
GO
