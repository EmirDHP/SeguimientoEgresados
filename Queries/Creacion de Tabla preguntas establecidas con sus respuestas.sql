SELECT * FROM PREGUNTAS_ESTABLECIDAS;
SELECT * FROM PREGUNTAS;

SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_DG_1';
SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_10';
SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_1';

ALTER TABLE PREGUNTAS_ESTABLECIDAS ALTER COLUMN Pregunta VARCHAR(250);

INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('',''),
('','');
-- PREG_DG_1
SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_DG_1';
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES ('Soltero (inlcluye divorciado y viudo)','PREG_DG_1')
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES ('Casado o union libre','PREG_DG_1')

-- PREG_DG_2
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('TSU','PREG_DG_2'),
('Liencencia Profesional en alguna UT','PREG_DG_2'),
('Liencencia Profesional en el extranjero','PREG_DG_2'),
('Ongenieria en alguna UT','PREG_DG_2'),
('Ingeniería (otra universidad)','PREG_DG_2'),
('Posgrado','PREG_DG_2');

-- PREG_DG_3
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('No estidio actualmente','PREG_DG_3'),
('Una Universidad Tecnológica (distinta a donde estudiaste TSU)','PREG_DG_3'),
('No estidio actualmente','PREG_DG_3'),
('Universidad pública','PREG_DG_3'),
('Universidad privada','PREG_DG_3'),
('Universidad Politecnica','PREG_DG_3'),
('UNAD: Universidad Abierta y a Distancia','PREG_DG_3'),
('Universidad en el extranjero','PREG_DG_3');

-- PREG_SL_1
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Ya estabas trabajando y continuaste haciéndolo','PREG_SL_1'),
('Te contrataron donde hiciste la estadia','PREG_SL_1'),
('Menos de 3 meses','PREG_SL_1'),
('De 3 a 6 meses','PREG_SL_1'),
('Más de 6 meses a un año','PREG_SL_1'),
('Más de año','PREG_SL_1'),
('No has empezado a trabajar','PREG_SL_1');
 
 -- PREG_SINO_SL3_SL14_SL22
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Si','PREG_SINO_SL3_SL14_SL22'),
('No','PREG_SINO_SL3_SL14_SL22');

 -- PREG_SL_4
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Relación con la empresa en la que realizaste en la estadía','PREG_SL_4'),
('Bolsa de trabajo de la UT','PREG_SL_4'),
('Creaste tu propio negocio con apoyo de la incubadora de empresas de la UT','PREG_SL_4'),
('Relación con la empresa en la que realizaste en la estadía','PREG_SL_4'),
('Invitación de una empresa o institución','PREG_SL_4'),
('Relaciones hechas en empleos anteriores','PREG_SL_4'),
('Creaste tu propio negocio con tus medios propios','PREG_SL_4'),
('Te integraste a un negocio familiar','PREG_SL_4'),
('Buscaste por tu cuenta en periodicos, internet y/o agencias de empleo','PREG_SL_4');

-- PREG_SL_5
SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_5';
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Nada','PREG_SL_5'),
('Casi nada','PREG_SL_5'),
('En algun medida','PREG_SL_5'),
('Bastante','PREG_SL_5'),
('En gran medida','PREG_SL_5');

-- PREG_SL_7
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Público','PREG_SL_7'),
('Privado','PREG_SL_7');

-- PREG_SL_8
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Agricultura, ganaderia, silvicultura o pesca','PREG_SL_8'),
('Industria extractiva (minería, petrolera)','PREG_SL_8'),
('Industria de la construcción','PREG_SL_8'),
('Industria de transformación, manufactura','PREG_SL_8'),
('Industria automotriz, aeronáutica','PREG_SL_8'),
('Tecnologías de la información y comunicación','PREG_SL_8'),
('Comercio','PREG_SL_8'),
('Servicios (bancarios, turismo, transporte, etc.)','PREG_SL_8'),
('Salud','PREG_SL_8'),
('Educación','PREG_SL_8'),
('Servicios del estado (oficina de gobierno, aduanas, limpia, seguridad y vigilancia, agua, alcantarillado, alumbrado, etc.)','PREG_SL_8');

-- PREG_SL_9
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Microempresa (de 1 a 10 empelados)','PREG_SL_9'),
('Pequeña (de 21 a 50 empleados)','PREG_SL_9'),
('Mediana (entre 21 a 50 empleados)','PREG_SL_9'),
('Grande (más de 100 empleados)','PREG_SL_9');

-- PREG_SL_10
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Totalmente','PREG_SL_10'),
('Mucho','PREG_SL_10'),
('Medianamente','PREG_SL_10'),
('Poco','PREG_SL_10'),
('Nada','PREG_SL_10');

-- PREG_SL_11
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Contrato por tiempo determinado','PREG_SL_11'),
('Contrato por tiempo indeterminado','PREG_SL_11'),
('Trabajador independiente','PREG_SL_11'),
('Por obra o proyecto terminado','PREG_SL_11'),
('Propietario o copropietario del negocio','PREG_SL_11'),
('Trabajo sin contrato','PREG_SL_11');

-- PREG_SL_12
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Hasta 10 horas','PREG_SL_12'),
('11 a 20 horas','PREG_SL_12'),
('21 a 30 horas','PREG_SL_12'),
('Más de 40 horas','PREG_SL_12');

-- PREG_SL_13
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Hasta dos salarios mínimos (menos de $4,802)','PREG_SL_13'),
('Más de dos, hasta cuatro salarios mínimos ($4,803 a $9,604)','PREG_SL_13'),
('Más de cuatro, hasta seis salarios mínimos ($9,605 a $14,407)','PREG_SL_13'),
('Más de seis, hasta ocho salarios mínimos ($14,408 a $19,209)','PREG_SL_13'),
('Más de ocho, hasta diez salarios mínimos ($19,210 a $24,012)','PREG_SL_13'),
('Más de diez salarios mínimos (más de $24,012)','PREG_SL_13');

-- PREG_SL_15
SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_15';
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Ninguna','PREG_SL_15'),
('Dos o Tres','PREG_SL_15'),
('Cuatro o cinco','PREG_SL_15'),
('Entre seis y diez','PREG_SL_15'),
('Más de diez','PREG_SL_15');

-- PREG_SL_16
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Ha mejorado','PREG_SL_16'),
('Sin cambio','PREG_SL_16'),
('Cuatro o cinco','PREG_SL_16'),
('Ha empeorado','PREG_SL_16');

-- PREG_SL_17
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Casi nunca','PREG_SL_17'),
('Ocasionalmente','PREG_SL_17'),
('Frecuentemente','PREG_SL_17');

-- PREG_SL_17_18_19_20
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Nada','PREG_SL_17_18_19_20'),
('Poco','PREG_SL_17_18_19_20'),
('Más o menos','PREG_SL_17_18_19_20'),
('Mucho','PREG_SL_17_18_19_20');

-- PREG_SL_20
INSERT INTO PREGUNTAS_ESTABLECIDAS(Pregunta, TipoPregunta)
VALUES 
('Superior a lo que esperabas','PREG_SL_20'),
('Tal y como lo esperabas','PREG_SL_20'),
('Inferior a lo que esperabas','PREG_SL_20');
SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_20';