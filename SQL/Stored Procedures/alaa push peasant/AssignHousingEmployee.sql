USE [Monkey]
GO
/****** Object:  StoredProcedure [dbo].[AssignHousingEmployee]    Script Date: 5/16/2020 4:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[AssignHousingEmployee]
	-- Add the parameters for the stored procedure here
	@PID int,
	@EID int
AS
BEGIN
	INSERT INTO HousingEmployee Values(@EID, @PID)
	Update Employee Set NoCurrentProj = NoCurrentProj + 1 Where NationalID = @EID
END
