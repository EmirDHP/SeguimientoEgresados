//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeguimientoEgresados.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class PUBLICACIONE
    {
        public int IdPublicacion { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        [DisplayName("Seleccionar una imagen:")]
        public string Imagen { get; set; }
        public HttpPostedFileBase ImagenFile { get; set; }
        public DateTime FechaPublicaciones { get; set; }
        public PUBLICACIONE()
        {
            FechaPublicaciones = DateTime.Now;
        }

        public string NombreEmpresa { get; set; }

        public int Tipo_Trabajo { get; set; }
        [ForeignKey("IdTipo_trabajo")]
        public TipoTrabajo TipoTrabajo { get; set; }
    }
}
