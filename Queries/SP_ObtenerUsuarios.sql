USE [SEGUIMIENTO_EGRESADOS]
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerUsuarios]    Script Date: 7/8/2022 3:35:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_ObtenerUsuarios]
AS
BEGIN
	SELECT * FROM USUARIOS;
END

