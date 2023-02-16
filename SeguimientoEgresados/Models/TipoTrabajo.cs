using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models
{
    public class TipoTrabajo
    {
        [Key]
        public int IdTipo_trabajo { get; set; }

        public string Tipo_Trabajo { get; set; }
    }
}