USE [SEGUIMIENTO_EGRESADOS]
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerTipoTrabajo]    Script Date: 7/22/2022 3:45:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_ObtenerTipoTrabajo]

AS
BEGIN
	SELECT * FROM TIPO_TRABAJO;	
END
