using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.ViewModel
{
    public class ViewModelPublicaciones
    {
        [DisplayName("ID")]
        public int IdPublicacion { get; set; }

        [DisplayName("Título")]
        public string Titulo { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        [DisplayName("Fecha")]
        public DateTime FechaPublicaciones { get; set; }

        public string NombreEmpresa { get; set; }

        public string Tipo_Trabajo { get; set; }
    }
}