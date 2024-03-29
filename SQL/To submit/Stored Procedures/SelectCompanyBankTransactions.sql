USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[SelectCompanyBankTransactions]    Script Date: 5/12/2020 7:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SelectCompanyBankTransactions] 
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
	SELECT TID As "Transaction ID", EmployeeID, BankName, Name, Amount From ComTransaction, Company Where CID = @CID and CompanyID = @CID
	end
	else
	begin
	SELECT TID As "Transaction ID", EmployeeID, BankName, Name, Amount From ComTransaction, Company Where BankName = @Name and CID = @CID and CompanyID = @CID
	end 
END
