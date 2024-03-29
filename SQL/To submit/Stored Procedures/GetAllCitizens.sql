USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[GetAllCitizens]    Script Date: 5/15/2020 11:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetAllCitizens] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.


    -- Insert statements for procedure here
	SELECT NationalID, Password, FirstName as "First Name", LastName as "Last Name", BirthDate, Salary, Case when Sex = 'F' then 'Female' when Sex = 'M' then 'Male' end as Sex, CurentCity as 'Current City', OwnsCurrent, CurrentAccommPrice as 'Current Accommodation Price'
    from Citizen 
END
