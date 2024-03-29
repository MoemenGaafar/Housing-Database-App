USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[SelectCitizenBankTransactions]    Script Date: 5/12/2020 7:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SelectCitizenBankTransactions] 
	-- Add the parameters for the stored procedure here
	@Name varchar(50), 
	@CID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@Name = 'All')
	begin 
	SELECT TID As "Transaction ID", EmployeeID, CitizenID, ProjectID, UnitID, BankName, Amount From CitTransaction Where CitizenID = @CID
	end 
	else
	begin
	SELECT TID As "Transaction ID", EmployeeID, CitizenID, ProjectID, UnitID, Amount From CitTransaction Where BankName = @Name and CitizenID = @CID
	end 
END
