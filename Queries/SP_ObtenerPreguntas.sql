USE [SEGUIMIENTO_EGRESADOS]
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerPreguntas]    Script Date: 7/1/2022 3:34:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerPreguntas]
AS
BEGIN
	SELECT * FROM PREGUNTAS;
END
