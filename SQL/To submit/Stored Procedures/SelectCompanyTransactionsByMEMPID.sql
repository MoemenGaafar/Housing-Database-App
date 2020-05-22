Use Monkey 
go
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

CREATE PROCEDURE SelectCompanyTransactionsByMEMPID
	-- Add the parameters for the stored procedure here
	@MID int,
	@BankName varchar(50),
	@CompanyID int
AS
IF (@BankName = 'All' AND @CompanyID = -1)
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT TID As "Transaction ID", BankName As "Bank", Name As "Company", Amount, Employee.FirstName+' '+Employee.LastName As "Responsible Employee"
	From ComTransaction, Company, Project, Employee
	Where @MID = MEmployeeID AND PEmployeeID = ComTransaction.EmployeeID AND ComTransaction.CompanyID = CID AND PEmployeeID = Employee.NationalID
END
ELSE IF (@BankName = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT TID As "Transaction ID", BankName As "Bank", Name As "Company", Amount, Employee.FirstName+' '+Employee.LastName As "Responsible Employee"
	From ComTransaction, Company, Project, Employee
	Where @MID = MEmployeeID AND PEmployeeID = ComTransaction.EmployeeID AND ComTransaction.CompanyID = CID AND PEmployeeID = Employee.NationalID
	AND CID = @CompanyID
END
ELSE IF (@CompanyID = -1)
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT TID As "Transaction ID", BankName As "Bank", Name As "Company", Amount, Employee.FirstName+' '+Employee.LastName As "Responsible Employee"
	From ComTransaction, Company, Project, Employee
	Where @MID = MEmployeeID AND PEmployeeID = ComTransaction.EmployeeID AND ComTransaction.CompanyID = CID AND PEmployeeID = Employee.NationalID
	AND @BankName = BankName
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT TID As "Transaction ID", BankName As "Bank", Name As "Company", Amount, Employee.FirstName+' '+Employee.LastName As "Responsible Employee"
	From ComTransaction, Company, Project, Employee
	Where @MID = MEmployeeID AND PEmployeeID = ComTransaction.EmployeeID AND ComTransaction.CompanyID = CID AND PEmployeeID = Employee.NationalID
	AND CID = @CompanyID AND @BankName = BankName
END
GO
