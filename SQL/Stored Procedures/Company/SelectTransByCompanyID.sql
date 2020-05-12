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
CREATE PROCEDURE SelectTransByCompanyID
	@CID int,
	@BankName varchar(50)
AS
IF (@BankName = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT TID As "Transaction ID", BankName As "Bank", Amount, FirstName+' '+LastName As "Responsible Employee"
	From ComTransaction, Employee
	Where CompanyID = @CID AND EmployeeID = NationalID
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT TID As "Transaction ID", BankName As "Bank", Amount, FirstName+' '+LastName As "Responsible Employee"
	From ComTransaction, Employee
	Where CompanyID = @CID AND EmployeeID = NationalID AND @BankName = BankName
END
GO
