USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[EditAccess]    Script Date: 5/13/2020 12:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[EditAccess] 
	-- Add the parameters for the stored procedure here
	@Entity varchar(50),
	@Pass varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	Update Access Set Pass = @Pass where Entity = @Entity 
END
