USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllCitizenBankTransactions]    Script Date: 5/12/2020 7:56:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SelectAllCitizenBankTransactions] 
	-- Add the parameters for the stored procedure here
	@Name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@Name = 'All')
	begin 
	SELECT TID As "Transaction ID", EmployeeID, CitizenID, ProjectID, BankName, UnitID, Amount From CitTransaction 
	end 
	else 
	begin
	SELECT TID As "Transaction ID", EmployeeID, CitizenID, ProjectID, BankName, UnitID, Amount From CitTransaction Where BankName = @Name 
	end
END
