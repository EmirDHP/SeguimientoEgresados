using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models.ViewModels
{
    public class GraficaVM
    {
        public List<Area> Area { get; set; }
        //public List<Reporte> reporte { get; set; }

        public Area AreaModelo { get; set; }
    }
}