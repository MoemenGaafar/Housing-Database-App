USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[SelectCitizenByID]    Script Date: 5/15/2020 11:30:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SelectCitizenByID]
	-- Add the parameters for the stored procedure here
	@NationalID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT NationalID, Password, FirstName as "First Name", LastName as "Last Name", Citizen.BirthDate, Citizen.Salary, Case when Sex = 'F' then 'Female' when Sex = 'M' then 'Male' end as Sex, CurentCity as 'Current City', OwnsCurrent, CurrentAccommPrice as 'Current Accommodation Price'
	FROM Citizen
	WHERE NationalID = @NationalID
END
