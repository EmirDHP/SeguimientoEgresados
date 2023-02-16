using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models
{
    public class Perfiles
    {
        [Key]
        [DisplayName("IdPerfil")]
        public int IdPerfil { get; set; }

        [DisplayName("Perfil")]
        public string Perfil { get; set; }
    }
}