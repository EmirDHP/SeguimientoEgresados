using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models
{
    public class Publicaciones
    {
        [Key]
        [DisplayName("ID")]
        public int IdPublicacion { get; set; }

        [Required]
        [DisplayName("Titulo")]
        public string Titulo { get; set; }

        [Required]
        [DisplayName("Descripcion")]
        public string Descripcion { get; set; }

        [Required]
        [DisplayName("Imagen")]
        public string Imagen { get; set; }

        //[NotMapped]
        //public HttpPostedFileBase ImagenFile { get; set; }

        
        [DisplayName("Fecha")]
        public DateTime FechaPublicaciones { get; set; }

        public string NombreEmpresa { get; set; }

        public string Tipo_Trabajo { get; set; }
    }
}