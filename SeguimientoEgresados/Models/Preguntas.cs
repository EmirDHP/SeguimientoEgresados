using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models
{
    public class Preguntas
    {

        [Key]
        [DisplayName("ID")]
        public int IdPregunta { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Nombre(s)")]
        public string IP_Nombres { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Apellido Paterno")]
        public string IP_ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Apellido Materno")]
        public string IP_ApellidoMaterno { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Matrícula")]
        public string IP_Matricula { get; set; }

        [Required(ErrorMessage = "Por favor escriba su correo")]
        [DisplayName("Correo electrónico")]
        public string IP_CorreoElectronicoPersonal { get; set; }

        [Required(ErrorMessage = "Por favor escriba su número de telefono")]
        [DisplayName("Número de teléfono ")]
        public string IP_NumeroTelefono { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("1. Estado civil")]
        //public string DG_EstadoCivil { get; set; }



        // Pregunta 1
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Estado civil")]
        public int DG_EstadoCivil { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta1 { get; set; }

        // Pregunta 2
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Último nivel de escolaridad completo")]
        public int DG_UltimoNivelEscolar { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta2 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("2. Ultimo nivel de escolaridad completo")]
        //public string DG_UltimoNivelEscolar { get; set; }

        // Pregunta 3
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("¿En qué tipo de institución estudias actualmente?")]
        public int DG_InstitucionEstudiasActualmente { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta3 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("3. En qué tipo de institución estudias actualmente")]
        //public string DG_InstitucionEstudiasActualmente { get; set; }

        // Pregunta 4
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Al concluir tus estudios en la UTTN ¿cuánto tiempo tardaste en encontrar tu primer empleo, en empezar a trabajar por tu cuenta o en un negocio familiar o propio?")]
        public int SL_PREG1 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta5 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("1. Al concluir tus estudios en la UT ¿cuánto tiempo tardaste en encontrar tu primer empleo, en empezar a trabajar por tu cuenta o en un negocio familiar o propio?")]
        //public string SL_PREG1 { get; set; }

        // Pregunta 5
        [Required(ErrorMessage = "Por favor escriba la cantidad de empleos que ha tenido")]
        [DisplayName("¿Cuántos trabajos has tenido desde que egresaste de la UTTN?")]
        public string SL_PREG2 { get; set; }

        // Pregunta 6
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("¿Trabajas actualmente?")]
        public int SL_PREG3 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta6 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("3. ¿Trabajas actualmente?")]
        //public string SL_PREG3 { get; set; }


        // Pregunta 7
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("¿Por qué medio obtuviste tu trabajo actual o el último que desempeñaste?")]
        public int SL_PREG4 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta7 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("4. ¿Por qué medio obtuviste tu trabajo actual o el último que desempeñaste?")]
        //public string SL_PREG4 { get; set; }

        // Pregunta 8_1
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("La buena imagen de la UTTN: ")]
        public int SL_PREG5_1 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta8_1 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("La buena imagen de la UT :")]
        //public string SL_PREG5_1 { get; set; }

        // Pregunta 8_2
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("La formación recibida: ")]
        public int SL_PREG5_2 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta8_2 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("La formación recibida:")]
        //public string SL_PREG5_2 { get; set; }


        // Pregunta 8_3
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Pertinencia de la carrera con las necesidades de la empresa: ")]
        public int SL_PREG5_3 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta8_3 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Pertinencia de la carrera con las necesidades de la empresa : ")]
        //public string SL_PREG5_3 { get; set; }


        // Pregunta 8_4
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Recomendaciones o relaciones personales con la empresa: ")]
        public int SL_PREG5_4 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta8_4 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Recomendaciones o relaciones personales con la empresa : ")]
        //public string SL_PREG5_4 { get; set; }

        // Pregunta 8_5
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Habilidades personales para obtener empleo:")]
        public int SL_PREG5_5 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta8_5 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Habilidades personales para obtener empleo:")]
        //public string SL_PREG5_5 { get; set; }

        // Pregunta 9
        [Required(ErrorMessage = "Por favor escriba su respuesta, en caso de no aplicar escribir N/A")]
        [DisplayName("Nombre de la empresa")]
        public string SL_PREG6_1_NombreEmpresa { get; set; }

        // Pregunta 10
        [Required(ErrorMessage = "Por favor escriba su respuesta, en caso de no aplicar escribir N/A")]
        [DisplayName("Municipio")]
        public string SL_PREG6_2_Municipio { get; set; }

        // Pregunta 11
        [Required(ErrorMessage = "Por favor escriba su respuesta, en caso de no aplicar escribir N/A")]
        [DisplayName("Estado")]
        public string SL_PREG6_3_Estado { get; set; }

        // Pregunta 12
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("¿A qué régimen jurídico pertenece la empresa donde trabajas actualmente o donde trabajaste en tu último empleo?")]
        public int SL_PREG7 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta12 { get; set; }
        //[DisplayName("7. ¿A qué régimen jurídico pertenece la empresa donde trabajas actualmente o donde trabajaste en tu último empleo?")]
        //public string SL_PREG7 { get; set; }


        // Pregunta 13
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Rama de actividad económica de la empresa en la que trabajas actualmente o tuviste tu último empleo")]
        public int SL_PREG8 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta13 { get; set; }
        //[DisplayName("8. Rama de actividad económica de la empresa en la que trabajas actualmente o tuviste tu último empleo")]
        //public string SL_PREG8 { get; set; }

        // Pregunta 14
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Tamaño de la empresa donde trabajas actualmente o donde trabajaste por última vez")]
        public int SL_PREG9 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta14 { get; set; }
        //[DisplayName("9. Tamaño de la empresa donde trabajas actualmente o donde trabajaste por última vez")]
        //public string SL_PREG9 { get; set; }

        // Pregunta 15
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("¿En qué medida coincide el trabajo que tienes actualmente o el último que desempeñaste, con la formación que recibiste en la UTTN?")]
        public int SL_PREG10 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta15 { get; set; }
        //[DisplayName("10. ¿En qué medida coincide el trabajo que tienes actualmente o el último que desempeñaste, con la formación que recibiste en la UT?")]
        //public string SL_PREG10 { get; set; }

        // Pregunta 16
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Tipo de contratación que tienes en tu trabajo actual o último que desempeñaste")]
        public int SL_PREG11 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta16 { get; set; }
        //[DisplayName("11. Tipo de contratación que tienes en tu trabajo actual o último que desempeñaste")]
        //public string SL_PREG11 { get; set; }

        // Pregunta 17
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("¿Por cuántas horas a la semana estás contratado o lo estabas en el último empleo que desempeñaste?")]
        public int SL_PREG12 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta17 { get; set; }
        //[DisplayName("12. ¿Por cuantas horas a la semana estás contratado o lo estabas en el último empleo que desempeñaste?")]
        //public string SL_PREG12 { get; set; }

        // Pregunta 18
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Ingreso mensual aproximado en tu empleo actual o el último que desempeñaste")]
        public int SL_PREG13 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta18 { get; set; }
        //[DisplayName("13. Ingreso mensual aproximado en tu empleo actual o el último que desempeñaste")]
        //public string SL_PREG13 { get; set; }

        // Pregunta 19_1
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Seguro social")]
        public int SL_PREG14_1 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_1 { get; set; }
        //[DisplayName("Seguro social?")]
        //public string SL_PREG14_1 { get; set; }

        // Pregunta 19_2
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Goce de días de vacaciones")]
        public int SL_PREG14_2 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_2 { get; set; }
        //[DisplayName("Goce de días de vacaciones")]
        //public string SL_PREG14_2 { get; set; }

        // Pregunta 19_3
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Prima vacacional")]
        public int SL_PREG14_3 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_3 { get; set; }
        //[DisplayName("Prima vacional")]
        //public string SL_PREG14_3 { get; set; }

        // Pregunta 19_4
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Aguinaldo")]
        public int SL_PREG14_4 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_4 { get; set; }
        //[DisplayName("Aguinaldo")]
        //public string SL_PREG14_4 { get; set; }

        // Pregunta 19_5
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Reparto de utilidades")]
        public int SL_PREG14_5 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_5 { get; set; }
        //[DisplayName("Reparto de utilidades")]
        //public string SL_PREG14_5 { get; set; }

        // Pregunta 19_6
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Ropa y herramientas de trabajo")]
        public int SL_PREG14_6 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_6 { get; set; }
        //[DisplayName("Ropa y herramientas de trabajo")]
        //public string SL_PREG14_6 { get; set; }

        // Pregunta 19_7
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Seguro privado de gastos médicos / vida")]
        public int SL_PREG14_7 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_7 { get; set; }
        //[DisplayName("Seguro privado de gastos médicos / vida")]
        //public string SL_PREG14_7 { get; set; }

        // Pregunta 19_8
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Servicios de transporte")]
        public int SL_PREG14_8 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_8 { get; set; }
        //[DisplayName("Servicios de transporte")]
        //public string SL_PREG14_8 { get; set; }

        // Pregunta 19_9
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Servicios de alimentación")]
        public int SL_PREG14_9 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_9 { get; set; }
        //[DisplayName("Servicios de alimentación")]
        //public string SL_PREG14_9 { get; set; }

        // Pregunta 19_10
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Capacitación")]
        public int SL_PREG14_10 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_10 { get; set; }
        //[DisplayName("Capacitación")]
        //public string SL_PREG14_10 { get; set; }

        // Pregunta 19_11
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Ingresos Adicionales (bonos de productividad, vales de despensa, opción de horas extras)")]
        public int SL_PREG14_11 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_11 { get; set; }
        //[DisplayName("Ingresos Adicionales (bonos de productividad, vales de despensa, opción de horas extras)")]
        //public string SL_PREG14_11 { get; set; }

        // Pregunta 19_12
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Servicios deportivos y recreativos")]
        public int SL_PREG14_12 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta19_12 { get; set; }
        //[DisplayName("Servicios deportivos y recreativos")]
        //public string SL_PREG14_12 { get; set; }

        // Pregunta 20
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("¿En el trabajo que desempeñas actualmente o en el último que desempeñaste has tenido o tuviste ascensos?")]
        public int SL_PREG15 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta20 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("15. ¿En el trabajo que desempeñas actualmente o en el último que desempeñaste has tenido o tuviste ascensos?")]
        //public string SL_PREG15 { get; set; }

        // Pregunta 21
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Desde que egresaste a la fecha ¿Cómo consideras que ha cambiado tu situación económica?")]
        public int SL_PREG16 { get; set; }

        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta21 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("16. Desde que egresaste a la fecha ¿Cómo consideras que ha cambiado tu situación económica?")]
        //public string SL_PREG16 { get; set; }

        // Pregunta 22__
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Aplicar conocimientos específicos de la carrera:")]
        public int SL_PREG17_1 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_1 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Aplicar conocimientos específicos de la carrera:")]
        //public string SL_PREG17_1 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Manejo de equipo y herramientas especializadas: ")]
        public int SL_PREG17_2 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_2 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Manejo de equipo y herramientas especializadas: ")]
        //public string SL_PREG17_2 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Manejo de equipo de cómputo: ")]
        public int SL_PREG17_3 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_3 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Manejo de equipo de cómputo: ")]
        //public string SL_PREG17_3 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Dominio de idioma extranjero: ")]
        public int SL_PREG17_4 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_4 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Dominio de idioma extranjero: ")]
        //public string SL_PREG17_4 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Destreza en la comunicación, ya sea oral, escrita o gráfica: ")]
        public int SL_PREG17_5 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_5 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Destreza en la comunicación, ya sea oral, escrita o gráfica: ")]
        //public string SL_PREG17_5 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Identificar, analizar y encontrar soluciones a problemas: ")]
        public int SL_PREG17_6 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_6 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Identificar, analizar y encontrar soluciones a problemas: ")]
        //public string SL_PREG17_6 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Buscar, obtener, procesar y utilizar información: ")]
        public int SL_PREG17_7 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_7 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Buscar, obtener, procesar y utilizar información: ")]
        //public string SL_PREG17_7 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Dirigir a tu grupo de trabajo para el logro de las metas laborales: ")]
        public int SL_PREG17_8 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_8 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Dirigir a tu grupo de trabajo para el logro de las metas laborales: ")]
        //public string SL_PREG17_8 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Colaborar con tus compañeros de trabajo para cumplir metas laborales: ")]
        public int SL_PREG17_9 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_9 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Colaborar con tus compañeros de trabajo para cumplir metas laborales: ")]
        //public string SL_PREG17_9 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Tomar decisiones en busca de mejores resultados en tus actividades laborales: ")]
        public int SL_PREG17_10 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_10 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Tomar decisiones en busca de mejores resultados en tus actividades laborales: ")]
        //public string SL_PREG17_10 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Negociar acuerdo con tus compañeros de trabajo: ")]
        public int SL_PREG17_11 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta22_11 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Negociar acuerdo con tus compañeros de trabajo: ")]
        //public string SL_PREG17_11 { get; set; }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////
        /// </summary>
        // Pregunta 23__
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Aplicar conocimientos específicos de la carrera:")]
        public int SL_PREG18_1 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_1 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Aplicar conocimientos específicos de la carrera:")]
        //public string SL_PREG17_1 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Manejo de equipo y herramientas especializadas: ")]
        public int SL_PREG18_2 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_2 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Manejo de equipo y herramientas especializadas: ")]
        //public string SL_PREG17_2 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Manejo de equipo de cómputo: ")]
        public int SL_PREG18_3 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_3 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Manejo de equipo de cómputo: ")]
        //public string SL_PREG17_3 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Dominio de idioma extranjero: ")]
        public int SL_PREG18_4 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_4 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Dominio de idioma extranjero: ")]
        //public string SL_PREG17_4 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Destreza en la comunicación, ya sea oral, escrita o gráfica: ")]
        public int SL_PREG18_5 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_5 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Destreza en la comunicación, ya sea oral, escrita o gráfica: ")]
        //public string SL_PREG17_5 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Identificar, analizar y encontrar soluciones a problemas: ")]
        public int SL_PREG18_6 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_6 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Identificar, analizar y encontrar soluciones a problemas: ")]
        //public string SL_PREG17_6 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Buscar, obtener, procesar y utilizar información: ")]
        public int SL_PREG18_7 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_7 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Buscar, obtener, procesar y utilizar información: ")]
        //public string SL_PREG17_7 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Dirigir a tu grupo de trabajo para el logro de las metas laborales: ")]
        public int SL_PREG18_8 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_8 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Dirigir a tu grupo de trabajo para el logro de las metas laborales: ")]
        //public string SL_PREG17_8 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Colaborar con tus compañeros de trabajo para cumplir metas laborales: ")]
        public int SL_PREG18_9 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_9 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Colaborar con tus compañeros de trabajo para cumplir metas laborales: ")]
        //public string SL_PREG17_9 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Tomar decisiones en busca de mejores resultados en tus actividades laborales: ")]
        public int SL_PREG18_10 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_10 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Tomar decisiones en busca de mejores resultados en tus actividades laborales: ")]
        //public string SL_PREG17_10 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Negociar acuerdo con tus compañeros de trabajo: ")]
        public int SL_PREG18_11 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta23_11 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Negociar acuerdo con tus compañeros de trabajo: ")]
        //public string SL_PREG17_11 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Aplicar conocimientos específicos de la carrera: ")]
        //public string SL_PREG18_1 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Manejo de equipo y herramientas especializadas: ")]
        //public string SL_PREG18_2 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Manejo de equipo de cómputo: ")]
        //public string SL_PREG18_3 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Dominio de idioma extranjero: ")]
        //public string SL_PREG18_4 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Destreza en la comunicación, ya sea oral, escrita o gráfica: ")]
        //public string SL_PREG18_5 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Identificar, analizar y encontrar soluciones a problemas: ")]
        //public string SL_PREG18_6 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Buscar, obtener, procesar y utilizar información: ")]
        //public string SL_PREG18_7 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Dirigir a tu grupo de trabajo para el logro de las metas laborales: ")]
        //public string SL_PREG18_8 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Colaborar con tus compañeros de trabajo para cumplir metas laborales: ")]
        //public string SL_PREG18_9 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Tomar decisiones en busca de mejores resultados en tus actividades laborales: ")]
        //public string SL_PREG18_10 { get; set; }

        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Negociar acuerdo con tus compañeros de trabajo: ")]
        //public string SL_PREG18_11 { get; set; }


        // Pregunta 24
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Las actividades o funciones asignadas: ")]
        public int SL_PREG19_1 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta24_1 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Las actividades o funciones asignadas: ")]
        //public string SL_PREG19_1 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Oportunidad de aplicar los conocimientos adquiridos en la UT: ")]
        public int SL_PREG19_2 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta24_2 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Oportunidad de aplicar los conocimientos adquiridos en la UT: ")]
        //public string SL_PREG19_2 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("El reconocimiento profesional: ")]
        public int SL_PREG19_3 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta24_3 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("El reconocimiento professional: ")]
        //public string SL_PREG19_3 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Las oportunidades de desarrollo professional: ")]
        public int SL_PREG19_4 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta24_4 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Las oportunidades de desarrollo professional: ")]
        //public string SL_PREG19_4 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Oportunidades de toma de decisiones sobre los procesos:")]
        public int SL_PREG19_5 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta24_5 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Oportunidades de toma de decisiones sobre los procesos:")]
        //public string SL_PREG19_5 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Oportunidad de usar mi creatividad: ")]
        public int SL_PREG19_6 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta24_6 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Oportunidad de usar mi creatividad: ")]
        //public string SL_PREG19_6 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("La remuneración económica: ")]
        public int SL_PREG19_7 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta24_7 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("La Remuneración económica: ")]
        //public string SL_PREG19_7 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("La oportunidad de dirigir grupos de trabajo: ")]
        public int SL_PREG19_8 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta24_8 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("La oportunidad de dirigir grupos de trabajo: ")]
        //public string SL_PREG19_8 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("La oportunidad de trabajar en equipo con tus compañeros: ")]
        public int SL_PREG19_9 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta24_9 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("La oportunidad de trabajar en equipo con tus compañeros: ")]
        //public string SL_PREG19_9 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("La oportunidad de negociar acuerdos: ")]
        public int SL_PREG19_10 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Pregunta24_10 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("La oportunidad de negociar acuerdos: ")]
        //public string SL_PREG19_10 { get; set; }

        /// <summary>
        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Contenidos teóricos: ")]
        public int SL_PREG20_1 { get; set; }

        [ForeignKey("IdPreguntaEstablecida ")]
        public PreguntasEstablecidas Pregunta { get; set; }


        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Prácticas en talleres y laboratorios: ")]
        public int SL_PREG20_2 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_2 { get; set; }
        /// </summary>


        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Prácticas realizadas en las empresas previas a la estadía: ")]
        public int SL_PREG20_3 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_3 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Prácticas realizadas en las empresas previas a la estadía: ")]
        //public string SL_PREG20_3 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Visitas guiadas: ")]
        public int SL_PREG20_4 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_4 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Visitas guiadas: ")]
        //public string SL_PREG20_4 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Estadía: ")]
        public int SL_PREG20_5 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_5 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Estadía: ")]
        //public string SL_PREG20_5 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Equipo de talleres y laboratorios: ")]
        public int SL_PREG20_6 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_6 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Equipo de talleres y laboratorios: ")]
        //public string SL_PREG20_6 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Programa de tutorías: ")]
        public int SL_PREG20_7 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_7 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Programa de tutorías: ")]
        //public string SL_PREG20_7 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Asesorías de tus profesores: ")]
        public int SL_PREG20_8 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_8 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Asesorías de tus profesores: ")]
        //public string SL_PREG20_8 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Enseñanza de idioma extranjero: ")]
        public int SL_PREG20_9 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_9 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Enseñanza de idioma extranjero: ")]
        //public string SL_PREG20_9 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Uso de herramientas informáticas (paquetería básica, navegación en internet, correo electrónico): ")]
        public int SL_PREG20_10 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_10 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Uso de herramientas informáticas (paquetería básica, navegación en internet, correo electrónico): ")]
        //public string SL_PREG20_10 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Formación integral (actividades culturales y deportivas): ")]
        public int SL_PREG20_11 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_11 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Formación integral (actividades culturales y deportivas): ")]
        //public string SL_PREG20_11 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Proceso de enseñanza: ")]
        public int SL_PREG20_12 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_12 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Proceso de enseñanza: ")]
        //public string SL_PREG20_12 { get; set; }

        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Servicios de consulta en biblioteca: ")]
        public int SL_PREG20_13 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg20_13 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("Servicios de consulta en biblioteca: ")]
        //public string SL_PREG20_13 { get; set; }


        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("La formación que recibiste en la UTTN ¿Qué tanto, cubrió tus expectativas?")]
        public int SL_PREG21 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg21 { get; set; }
        //[Required(ErrorMessage = "Please enter marks")]
        //[DisplayName("21. La formación que recibiste en la Universidad Tecnológica ¿Qué tanto, cubrió tus expectativas?")]
        //public string SL_PREG21 { get; set; }

        [Required(ErrorMessage = "Por favor escriba su respuesta")]
        [DisplayName("¿Aconsejarías a un familiar o amigo estudiar en la UTTN?")]
        public int SL_PREG22 { get; set; }
        [ForeignKey("IdPreguntaEstablecida")]
        public PreguntasEstablecidas Preg22 { get; set; }


        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Area")]
        public int Areas { get; set; }
        [ForeignKey("IdArea")]
        public Area area{ get; set; }


        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Año en que comenzó (TSU/ING)")]
        public int AñoInico { get; set; }
        [ForeignKey("IdAño")]
        public Año añoinico1 { get; set; }


        [Required(ErrorMessage = "Please enter marks")]
        [DisplayName("Año en que termino (TSU/ING)")]
        public int AñoFin { get; set; }
        [ForeignKey("IdAño")]
        public Año añofin2 { get; set; }
    }
}