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
CREATE PROCEDURE ChangeComApplicationStatusByCompanyID
	-- Add the parameters for the stored procedure here
	@PID int,
	@CID varchar(50),
	@NewStatus char(1)
AS
BEGIN
	UPDATE ComApplication 
	SET AStatus = @NewStatus
	WHERE ProjectID = @PID AND CompanyID = @CID
END
IF (@NewStatus = 'D')
BEGIN
    UPDATE Project
	SET CompanyID = @CID, PStatus = 'S', StartingDate = Convert(date, getdate())  
	WHERE Project.ID = @PID
END
IF (@NewStatus = 'D')
BEGIN
   UPDATE ComApplication
   SET AStatus = 'R'
   WHERE  ProjectID = @PID AND CompanyID != @CID
END
GO
