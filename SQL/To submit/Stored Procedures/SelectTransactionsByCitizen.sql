USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactionsByCitizen]    Script Date: 5/11/2020 2:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SelectTransactionsByCitizen] 
	-- Add the parameters for the stored procedure here
	@Citizen int, 
	@Bank varchar(50), 
	@Unit int, 
	@Project int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@Bank = '' and @Project = 0 and @Unit = 0)
	begin 
	Select TID as TransactionID, BankName, ProjectID, UnitID, Amount 
	From CitTransaction 
	Where CitizenID = @Citizen
	end
	else if (@Bank = '' and @Project != 0 and @Unit = 0)
	begin 
	Select TID as TransactionID, BankName, ProjectID, UnitID, Amount 
	From CitTransaction 
	Where CitizenID = @Citizen and ProjectID = @Project
	end 
	else if (@Bank = '' and @Project != 0 and @Unit != 0)
	begin 
	Select TID as TransactionID, BankName, ProjectID, UnitID, Amount 
	From CitTransaction 
	Where CitizenID = @Citizen and ProjectID = @Project and UnitID = @Unit
	end 
	else if (@Bank != '' and @Project = 0 and @Unit = 0)
	begin 
	Select TID as TransactionID, BankName, ProjectID, UnitID, Amount 
	From CitTransaction 
	Where CitizenID = @Citizen and BankName = @Bank
	end 
	else if (@Bank != '' and @Project != 0 and @Unit = 0)
	begin 
	Select TID as TransactionID, BankName, ProjectID, UnitID, Amount 
	From CitTransaction 
	Where CitizenID = @Citizen and BankName = @Bank and ProjectID = @Project
	end 
	else if (@Bank != '' and @Project != 0 and @Unit != 0)
	begin 
	Select TID as TransactionID, BankName, ProjectID, UnitID, Amount 
	From CitTransaction 
	Where CitizenID = @Citizen and BankName = @Bank and ProjectID = @Project and UnitID = @Unit
	end
END
