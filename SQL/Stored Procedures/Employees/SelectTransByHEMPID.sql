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
CREATE PROCEDURE SelectTransByHEMPID
	-- Add the parameters for the stored procedure here
	@NationalID int,
	@BankName varchar(50),
	@CitizenName varchar(50)
AS
IF (@BankName = 'All' AND @CitizenName = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT TID As "Transaction ID", BankName As "Bank", FirstName+' '+LastName As "Citizen", Amount 
	From CitTransaction, Citizen
	Where CitizenID = Citizen.NationalID AND EmployeeID = @NationalID
END
ELSE IF (@BankName = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT TID As "Transaction ID", BankName As "Bank", FirstName+' '+LastName As "Citizen", Amount 
	From CitTransaction, Citizen
	Where CitizenID = Citizen.NationalID AND EmployeeID = @NationalID AND @CitizenName = (FirstName+' '+LastName)
END
ELSE IF (@CitizenName = 'All')
BEGIN
	SET NOCOUNT ON;
	SELECT TID As "Transaction ID", BankName As "Bank", FirstName+' '+LastName As "Citizen", Amount 
	From CitTransaction, Citizen
	Where CitizenID = Citizen.NationalID AND EmployeeID = @NationalID AND BankName = @BankName
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT TID As "Transaction ID", BankName As "Bank", FirstName+' '+LastName As "Citizen", Amount 
	From CitTransaction, Citizen
	Where CitizenID = Citizen.NationalID AND EmployeeID = @NationalID AND BankName = @BankName AND @CitizenName = (FirstName+' '+LastName)
END
GO
