-- GRAFICAS CONSULTA  --

SELECT * FROM PREGUNTAS;
SELECT * FROM PREGUNTAS_ESTABLECIDAS;

-- Usuarios cantidad --
ALTER PROC SP_RespuestaCantidad
AS 
BEGIN
SELECT COUNT(IdPregunta) [cantidad] FROM PREGUNTAS;
END
exec SP_RespuestaCantidad

-- Respuestas cantidad
ALTER PROC SP_UsuariosCantidad
AS 
BEGIN
SELECT COUNT(IdUsuario) [cantidad2] FROM USUARIOS;
END
exec SP_UsuariosCantidad
--

SELECT COUNT (u.IdUsuario) AS USUARIOS, COUNT (p.IdPregunta) AS PREGUNTAS
FROM USUARIOS u  CROSS JOIN PREGUNTAS p;

SELECT COUNT(IdUsuario) as cantidad
FROM USUARIOS
UNION
SELECT COUNT(IdPregunta) 
FROM PREGUNTAS;

SELECT COUNT(IdUsuario), COUNT(IdPregunta) FROM USUARIOS,  PREGUNTAS

-- ¿Trabajas actualmente?  --
CREATE PROC SP_Reporte_TrabajasActualmente
AS 
BEGIN
SELECT pe.Pregunta[pregunta], COUNT(*) [cantidad] FROM PREGUNTAS p
INNER JOIN PREGUNTAS_ESTABLECIDAS pe on p.SL_PREG3 = pe.IdPreguntaEstablecida
GROUP BY pe.Pregunta
ORDER BY  COUNT(*) DESC;
END
exec SP_Reporte_TrabajasActualmente

-- Ingreso mensual aproximado en tu empleo actual o el último que desempeñaste  --
CREATE PROC SP_Reporte_IngresoMensual
AS 
BEGIN
SELECT pe.Pregunta[pregunta], COUNT(*) [cantidad] FROM PREGUNTAS p
INNER JOIN PREGUNTAS_ESTABLECIDAS pe on p.SL_PREG13 = pe.IdPreguntaEstablecida
GROUP BY pe.Pregunta
ORDER BY  COUNT(*) DESC;
END
exec SP_Reporte_IngresoMensual

-- ¿Por qué medio obtuviste tu trabajo actual o el último que desempeñaste? --
CREATE PROC SP_Reporte_MedioObtuvoTrabajo
AS 
BEGIN
SELECT pe.Pregunta[pregunta], COUNT(*) [cantidad] FROM PREGUNTAS p
INNER JOIN PREGUNTAS_ESTABLECIDAS pe on p.SL_PREG4 = pe.IdPreguntaEstablecida
GROUP BY pe.Pregunta
ORDER BY  COUNT(*) DESC;
END	
exec SP_Reporte_MedioObtuvoTrabajo

-- Rama de actividad económica de la empresa en la que trabajas actualmente o tuviste tu último empleo --
CREATE PROC SP_Reporte_RamaEmpresa
AS 
BEGIN
SELECT pe.Pregunta[pregunta], COUNT(*) [cantidad] FROM PREGUNTAS p
INNER JOIN PREGUNTAS_ESTABLECIDAS pe on p.SL_PREG8 = pe.IdPreguntaEstablecida
GROUP BY pe.Pregunta
ORDER BY  COUNT(*) DESC;
END
exec SP_Reporte_RamaEmpresa

-- La formación que recibiste en la Universidad Tecnológica ¿Qué tanto, cubrió tus expectativas? --
CREATE PROC SP_Reporte_ExpectativasFormacion
AS 
BEGIN
SELECT pe.Pregunta[pregunta], COUNT(*) [cantidad] FROM PREGUNTAS p
INNER JOIN PREGUNTAS_ESTABLECIDAS pe on p.SL_PREG21 = pe.IdPreguntaEstablecida
GROUP BY pe.Pregunta
ORDER BY  COUNT(*) DESC;
END
exec SP_Reporte_ExpectativasFormacion

-- ¿Aconsejarías a un familiar o amigo estudiar en la UTTN? --
CREATE PROC SP_Reporte_RecomiendasUTTN
AS 
BEGIN
SELECT pe.Pregunta[pregunta], COUNT(*) [cantidad] FROM PREGUNTAS p
INNER JOIN PREGUNTAS_ESTABLECIDAS pe on p.SL_PREG22 = pe.IdPreguntaEstablecida
GROUP BY pe.Pregunta
ORDER BY  COUNT(*) DESC;
END
exec SP_Reporte_RecomiendasUTTN