using SeguimientoEgresados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguimientoEgresados.Controllers
{
    public class HomeController : Controller
    {
        DBConnection db = new DBConnection();
        List<Usuarios> ListaUsuarios = new List<Usuarios>();
        List<Perfiles> ListaPerfiles = new List<Perfiles>();

        public HomeController()
        {
            ListaUsuarios = db.ObtenerUsuarios();
            ListaPerfiles = db.ObtenerPerfil();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrarse()
        {
            ViewBag.Perfil = ListaPerfiles;
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Registrarse(Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                db.SetUsuarios(usuarios, 1);
                TempData["EditSuccess"] = "La cuenta ha sido creada exitosamente.";
                return RedirectToAction("Index");
            }
            return View(usuarios);
        }

        public ActionResult Restringido()
        {
            return View();
        }

    }
}