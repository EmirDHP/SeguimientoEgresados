using SeguimientoEgresados.Models;
using SeguimientoEgresados.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguimientoEgresados.Controllers
{
    [CustomAuthorize(Users = "1,2")]
    public class PublicacionesUsuariosController : Controller
    {

        DBConnection db = new DBConnection();
        List<Publicaciones> ListaPublicaciones = new List<Publicaciones>();
        List<ViewModelPublicaciones> ViewModelListaPublicaciones = new List<ViewModelPublicaciones>();

        public PublicacionesUsuariosController()
        {
            ViewModelListaPublicaciones = db.ObtenerPublicaciones();
            ListaPublicaciones = db.ObtenerPublicacionesModel();
        }

        // GET: PublicacionesUsuarios
        public ActionResult Vacantes()
        {
            return View();
        }

        public ActionResult VacantesDisponibles()
        {
            return View(ListaPublicaciones);
        }

        // GET: PublicacionesUsuarios/Details/5
        public ActionResult Detalles(int? id)
        {
            if (id == null)
                return RedirectToAction("VacantesDisponibles");

            Publicaciones cpa = ListaPublicaciones.FirstOrDefault(x => x.IdPublicacion == id);
            if (cpa != null)
                return View(cpa);

            return RedirectToAction("VacantesDisponibles");
        }
    }
}
