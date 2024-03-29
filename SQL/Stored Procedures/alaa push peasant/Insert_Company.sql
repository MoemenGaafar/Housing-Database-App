USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Company]    Script Date: 5/14/2020 12:55:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Alter PROCEDURE [dbo].[Insert_Company]
	-- Add the parameters for the stored procedure here
	@Password varchar(50),  
	@Name varchar(50), 
	@NoCompleteProj int, 
    @NoCurrentProj int,
	@Rating tinyint, 
    @AvgProjectCost int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

    -- Insert statements for procedure here
	INSERT INTO Company
	Values(@Password, @Name, @NoCompleteProj, @NoCurrentProj, @Rating, @AvgProjectCost)
END
