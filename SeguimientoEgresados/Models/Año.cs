using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models
{
    public class Año
    {
        [Key]
        [DisplayName("IdAño")]
        public int IdAño { get; set; }

        [DisplayName("Año")]
        public string Años { get; set; }
    }
}