using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models
{
    public class PreguntasEstablecidas
    {
        [Key]
        public int IdPreguntaEstablecida { get; set; }

        [Required]
        [DisplayName("Pregunta")]
        public string Pregunta { get; set; }

        [Required]
        [DisplayName("Tipo de pregunta")]
        public string TipoPregunta { get; set; }
    }
}