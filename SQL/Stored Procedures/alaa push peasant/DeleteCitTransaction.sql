USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCitTransaction]    Script Date: 5/12/2020 7:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[DeleteCitTransaction] 
	-- Add the parameters for the stored procedure here
	@TID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	Delete from CitTransaction where TID = @TID
END
