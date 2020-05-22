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
CREATE PROCEDURE AddDependent 
	-- Add the parameters for the stored procedure here
	@Name varchar(50), 
	@Citizen int, 
	@Birth date, 
	@Salary int, 
	@Relationship char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT Off;

    -- Insert statements for procedure here
	insert into Dependents
	values(@name, @Citizen, @Birth, @Salary, @Relationship)
END
GO
