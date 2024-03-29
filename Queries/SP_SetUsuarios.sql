USE [SEGUIMIENTO_EGRESADOS]
GO
/****** Object:  StoredProcedure [dbo].[SP_SetUsuarios]    Script Date: 7/22/2022 6:16:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_SetUsuarios]
	@idusuario int = null,
	@nombre varchar(200) = null,
	@apellidopaterno varchar(500) = null,
	@apellidomaterno varchar(100) = null,
	@matricula varchar(100) = null,
	@correoelectronico varchar(100) = null,
	@contraseña varchar(100) = null,
	@idperfil int,
	@op int=0
AS
BEGIN
	IF @op=1
		INSERT INTO USUARIOS(Nombres,ApellidoPaterno,ApellidoMaterno,Matricula,CorreoElectronico,Contraseña,IdPerfil)
		VALUES (@nombre, @apellidopaterno, @apellidomaterno, @matricula, @correoelectronico, @contraseña, @idperfil)
	ELSE IF @op=2
		UPDATE USUARIOS SET Nombres=@nombre, ApellidoPaterno=@apellidopaterno, ApellidoMaterno=@apellidomaterno, Matricula=@matricula, 
		CorreoElectronico=@correoelectronico, Contraseña=@contraseña, IdPerfil=@idperfil
		WHERE (IdUsuario=@idusuario)
	ELSE IF @op=3
        DELETE FROM USUARIOS WHERE (IdUsuario=@idusuario)
END