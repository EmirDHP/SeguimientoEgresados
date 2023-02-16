using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models
{
    public class RecoveryViewModel
    {
        [EmailAddress]
        [Required]
        public string email { get; set; }
    }
}