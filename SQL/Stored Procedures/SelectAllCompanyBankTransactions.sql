USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllCompanyBankTransactions]    Script Date: 5/9/2020 2:56:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
use Monkey
go
Create PROCEDURE [dbo].[SelectAllCompanyBankTransactions] 
	-- Add the parameters for the stored procedure here
	@Name varchar(50)
AS
IF (@Name = 'All')
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TID, EmployeeID, Name, Amount From ComTransaction, Company Where CID = CompanyID
END
ELSE
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TID, EmployeeID, Name, Amount From ComTransaction, Company Where BankName = @Name and CID = CompanyID
END
