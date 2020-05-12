USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Employee]    Script Date: 5/12/2020 11:28:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Insert_Employee]
	-- Add the parameters for the stored procedure here
	@NationalID	int, 
	@Password varchar(50),
	@FirstName	varchar(50),
	@LastName varchar(50),
	@Sex char(1), 
	@EType char(1),
	@StartDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

    -- Insert statements for procedure here
	INSERT INTO Employee
	Values(@NationalID,@Password,@FirstName,@LastName,@Sex,@EType,@StartDate,0, 0)
END
