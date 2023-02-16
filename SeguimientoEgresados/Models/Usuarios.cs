using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models
{
    public class Usuarios
    {
        [Key]
        [DisplayName("ID")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el nombre")]
        [DisplayName("Nombre(s)")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el apellido paterno")]
        [DisplayName("Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el apellido materno")]
        [DisplayName("Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessage = "Por favor ingrese la matricula")]
        [DisplayName("Matricula")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el correo electronico")]
        [DisplayName("Correo Electronico")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "Por favor ingrese la contraseña")]
        [DisplayName("Contraseña")]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el perfil")]
        [DisplayName("IdPerfil")]
        public int IdPerfil { get; set; }
        [ForeignKey("IdPerfil")]
        public Perfiles Perfil{ get; set; }
    }
}