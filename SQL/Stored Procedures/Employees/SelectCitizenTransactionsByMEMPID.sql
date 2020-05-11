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
Use Monkey
go
CREATE PROCEDURE SelectCitizenTransactionsByMEMPID
	-- Add the parameters for the stored procedure here
	@MID int,
	@BankName varchar(50),
	@CitizenID int
AS
IF (@BankName = 'All' AND @CitizenID = -1)
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT TID As "Transaction ID", BankName As "Bank", Citizen.FirstName+' '+Citizen.LastName As "Citizen", Amount, Employee.FirstName+' '+Employee.LastName As "Responsible Employee"
	From CitTransaction, Citizen, Employee, Project, HousingEmployee
	Where @MID = Project.MEmployeeID AND Project.ID = PID AND PID = CitTransaction.ProjectID AND CitTransaction.EmployeeID = Employee.NationalID AND CitTransaction.CitizenID = Citizen.NationalID
END
ELSE IF (@BankName = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT TID As "Transaction ID", BankName As "Bank", Citizen.FirstName+' '+Citizen.LastName As "Citizen", Amount, Employee.FirstName+' '+Employee.LastName As "Responsible Employee"
	From CitTransaction, Citizen, Employee, Project, HousingEmployee
	Where @MID = Project.MEmployeeID AND Project.ID = PID AND PID = CitTransaction.ProjectID AND CitTransaction.EmployeeID = Employee.NationalID AND CitTransaction.CitizenID = Citizen.NationalID 
	AND @CitizenID = Citizen.NationalID
END
ELSE IF (@CitizenID = -1)
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT TID As "Transaction ID", BankName As "Bank", Citizen.FirstName+' '+Citizen.LastName As "Citizen", Amount, Employee.FirstName+' '+Employee.LastName As "Responsible Employee"
	From CitTransaction, Citizen, Employee, Project, HousingEmployee
	Where @MID = Project.MEmployeeID AND Project.ID = PID AND PID = CitTransaction.ProjectID AND CitTransaction.EmployeeID = Employee.NationalID AND CitTransaction.CitizenID = Citizen.NationalID
	AND BankName = @BankName
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT TID As "Transaction ID", BankName As "Bank", Citizen.FirstName+' '+Citizen.LastName As "Citizen", Amount, Employee.FirstName+' '+Employee.LastName As "Responsible Employee"
	From CitTransaction, Citizen, Employee, Project, HousingEmployee
	Where @MID = Project.MEmployeeID AND Project.ID = PID AND PID = CitTransaction.ProjectID AND CitTransaction.EmployeeID = Employee.NationalID AND CitTransaction.CitizenID = Citizen.NationalID
	AND BankName = @BankName AND @CitizenID = Citizen.NationalID
END
GO
