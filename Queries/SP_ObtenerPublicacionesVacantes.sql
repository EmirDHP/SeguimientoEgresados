USE [SEGUIMIENTO_EGRESADOS]
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerPublicacionesVacantes]    Script Date: 7/22/2022 3:44:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_ObtenerPublicacionesVacantes]

AS
BEGIN
SELECT 
PUBLICACIONES.IdPublicacion, PUBLICACIONES.Titulo, PUBLICACIONES.Descripcion, PUBLICACIONES.Imagen, PUBLICACIONES.FechaPublicaciones, PUBLICACIONES.NombreEmpresa, TIPO_TRABAJO.Tipo_Trabajo
FROM PUBLICACIONES
INNER JOIN TIPO_TRABAJO ON PUBLICACIONES.Tipo_Trabajo = TIPO_TRABAJO.IdTipo_trabajo;

END
