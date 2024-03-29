USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Employee]    Script Date: 5/14/2020 12:58:17 AM ******/
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
	@StartDate date,
	@NoCompleteProj int,
    @NoCurrentProj int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

    -- Insert statements for procedure here
	INSERT INTO Employee
	Values(@NationalID,@Password,@FirstName,@LastName,@Sex,@EType,@StartDate,@NoCompleteProj, @NoCurrentProj)
END
