USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[CreateCitApplication]    Script Date: 5/11/2020 12:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[CreateCitApplication] 
	-- Add the parameters for the stored procedure here
@Project int, 
@Unit int, 
@Citizen int
AS
BEGIN
declare @exists int
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
Select @exists = Count(*) from CitApplication Where ProjectID = @Project and UnitID = @Unit and CitizenID = @Citizen

if(@exists = 0)
Begin 
insert into CitApplication
values
(@Project, @Unit, @Citizen, 'W')
End 

END
