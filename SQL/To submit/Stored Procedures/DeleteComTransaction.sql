USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[DeleteComTransaction]    Script Date: 5/12/2020 7:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[DeleteComTransaction] 
	-- Add the parameters for the stored procedure here
	@TID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	Delete from ComTransaction where TID = @TID
END
