USE [SEGUIMIENTO_EGRESADOS]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerUsuarios2]    Script Date: 7/22/2022 3:44:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ObtenerUsuarios2]
@idusuario varchar(30)

AS
BEGIN
	select * from USUARIOS where Matricula = @idusuario
END
