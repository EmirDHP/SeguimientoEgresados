USE [SEGUIMIENTO_EGRESADOS]
GO
/****** Object:  StoredProcedure [dbo].[SP_SetPublicaciones]    Script Date: 7/22/2022 3:45:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_SetPublicaciones]
	@idpublicacion int = null,
	@titulo varchar(200) = null,
	@descripcion varchar(500) = null,
	@imagen varchar(100) = null,
	@fechapublicaciones DATETIME = null,
	@op int=0
AS
BEGIN
	IF @op=1
		INSERT INTO PUBLICACIONES (Titulo, Descripcion, Imagen)
		VALUES (@titulo, @descripcion, @imagen)
	ELSE IF @op=2
		UPDATE PUBLICACIONES SET Titulo=@titulo, Descripcion=@descripcion, Imagen=@imagen
		WHERE (IdPublicacion=@idpublicacion)
	ELSE IF @op=3
        DELETE FROM PUBLICACIONES WHERE (IdPublicacion=@idpublicacion)
END