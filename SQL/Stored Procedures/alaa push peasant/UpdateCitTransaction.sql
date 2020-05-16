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
CREATE PROCEDURE EditCitTransaction  
	-- Add the parameters for the stored procedure here
	@TID bigint, 
	@BankName varchar(50), 
	@EmployeeID int, 
	@CitizenID int, 
	@ProjectID int, 
	@UnitID int, 
	@Amount int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update CitTransaction 
	Set Bankname = @BankName, EmployeeID = @EmployeeID, CitizenID = @CitizenID, ProjectID = @ProjectID, UnitID = @UnitID, Amount = @Amount
	Where TID = @TID
END
GO
