using SeguimientoEgresados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguimientoEgresados.Controllers
{
    public class UsuarioController : Controller
    {
        DBConnection db = new DBConnection();
        List<Usuarios> ListaUsuarios = new List<Usuarios>();
        List<Perfiles> ListaPerfiles = new List<Perfiles>();

        public UsuarioController()
        {
            ListaUsuarios = db.ObtenerUsuarios();
            ListaPerfiles = db.ObtenerPerfil();
        }

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Registrarse()
        {
            ViewBag.Perfil = ListaPerfiles;
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Registrarse(Usuarios usuarios)
        {
            ViewBag.Perfil = ListaPerfiles;
            if (ModelState.IsValid)
            {
                db.SetUsuarios(usuarios, 1);
                return RedirectToAction("index", "home");

            }
            return View(usuarios);
        }

        public ActionResult RecuperarCuenta()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult RecuperarCuenta(string CorreoElectronico)
        //{
        //    IRepository repository
        //}


    }
}
