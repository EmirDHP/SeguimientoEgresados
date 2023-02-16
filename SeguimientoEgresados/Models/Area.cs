using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models
{
    public class Area
    {
        [Key]
        [DisplayName("IdArea")]
        public int IdArea { get; set; }

        [DisplayName("NombreArea")]
        public string NombreArea { get; set; }
    }
}