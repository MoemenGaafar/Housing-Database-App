Use Monkey 
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
CREATE PROCEDURE ChangeComApplicationStatus
	-- Add the parameters for the stored procedure here
	@ProjectID int,
	@CompanyName varchar(50),
	@NewStatus char(1)
AS
BEGIN
	UPDATE ComApplication 
	SET AStatus = @NewStatus
	WHERE ProjectID = @ProjectID AND CompanyID in (SELECT CID From Company Where Name = @CompanyName)
END
GO
