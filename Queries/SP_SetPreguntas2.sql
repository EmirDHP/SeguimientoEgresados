USE [SEGUIMIENTO_EGRESADOS]
GO
/****** Object:  StoredProcedure [dbo].[SP_SetPreguntas2]    Script Date: 7/22/2022 5:30:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_SetPreguntas2]
	@idpregunta int = null,
	@op int=0
AS
BEGIN
	IF @op=3
        DELETE FROM PREGUNTAS WHERE (IdPregunta=@idpregunta)
END

