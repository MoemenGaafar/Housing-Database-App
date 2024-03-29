USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[UnsellUnit]    Script Date: 5/15/2020 7:57:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[UnsellUnit] 
	-- Add the parameters for the stored procedure here
	@ID int, 
	@ProjectID int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	Update Unit Set UStatus = 0, PaymentEndDate = null where ID = @ID and ProjectID = @ProjectID 
	Update CitApplication Set AStatus = 'A' where UnitID = @ID and ProjectID = @ProjectID and AStatus = 'D' 
END
