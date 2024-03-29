USE [SEGUIMIENTO_EGRESADOS]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPreguntasUsuario]    Script Date: 7/22/2022 3:43:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ObtenerPreguntasUsuario]

@matricula nvarchar(max)

AS
BEGIN

SELECT PREGUNTAS.*
FROM PREGUNTAS
INNER JOIN USUARIOS ON USUARIOS.Matricula = PREGUNTAS.IP_Matricula
WHERE PREGUNTAS.IP_Matricula = @matricula;

END
