Use Monkey 
go
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
CREATE PROCEDURE SelectProjectByEmployeeMEMPID
    @MID int,
	@EID int,
	@Etype char(1)
AS
IF (@Etype = 'H')
BEGIN
	SET NOCOUNT ON;
	SELECT PID As "ID", CASE WHEN PStatus = 'P' THEN 'Posted' WHEN PStatus = 'S' THEN 'Started' WHEN PStatus = 'L' THEN 'Launched' ELSE 'All units sold' END As "Project Status"
	FROM HousingEmployee, Project WHERE EID = @EID AND PID = ID AND MEmployeeID = @MID
END
ELSE IF(@Etype = 'P')
BEGIN
	SET NOCOUNT ON;
	SELECT ID, CASE WHEN PStatus = 'P' THEN 'Posted' WHEN PStatus = 'S' THEN 'Started' WHEN PStatus = 'L' THEN 'Launched' ELSE 'All units sold' END As "Project Status"
	FROM Project WHERE PEmployeeID = @EID AND MEmployeeID = @MID
END
ELSE
BEGIN
	SET NOCOUNT ON;
	SELECT ID, CASE WHEN PStatus = 'P' THEN 'Posted' WHEN PStatus = 'S' THEN 'Started' WHEN PStatus = 'L' THEN 'Launched' ELSE 'All units sold' END As "Project Status"
	FROM Project WHERE MEmployeeID = @EID AND MEmployeeID = @MID
END
GO
