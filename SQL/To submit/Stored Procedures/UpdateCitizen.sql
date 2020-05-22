Use Monkey 
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
CREATE PROCEDURE UpdateCitizen
 
	-- Add the parameters for the stored procedure here
	@OldID int, 
	@NationalID	int, 
	@Password varchar(50),
	@FirstName	varchar(50),
	@LastName varchar(50),
	@BirthDate date,
	@Salary	int,
	@Sex char(1),
	@CurentCity varchar(50), 
	@OwnsCurrent bit,
	@CurrentAccommPrice int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT Off;

    -- Insert statements for procedure here
	Update Citizen 
	Set NationalID = @NationalID, Password = @Password, FirstName = @FirstName, LastName = @LastName, Birthdate = @Birthdate, Salary = @Salary, Sex = @Sex, CurentCity = @CurentCity, OwnsCurrent = @OwnsCurrent, CurrentAccommPrice = @CurrentAccommPrice
	Where NationalID = @OldID
END
GO
