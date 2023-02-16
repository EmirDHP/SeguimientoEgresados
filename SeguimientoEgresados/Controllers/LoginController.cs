using SeguimientoEgresados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguimientoEgresados.Controllers
{
    public class LoginController: Controller
    {
        // GET: Login
        //muesttra la pagina de login/index
        public ActionResult Index()
        {
            return View();
        }
        //controla el envio de los datos de la pagina de login/index
        [HttpPost]
        public ActionResult Index(Usuarios user)
        {
            // si los datos estan presentes
            if (user.Matricula != null && user.Matricula != string.Empty)
            {
                DBConnection db = new DBConnection(); //instancia para obtener los datos de archivos
                List<Usuarios> ListaUsuarios = db.ObtenerUsuarios(); //llena lista usuarios
                //determina si el usuario existe en la bd
                Usuarios usuario = ListaUsuarios.FirstOrDefault(x => x.Matricula == user.Matricula);
                if (usuario != null)
                {
                    if (user.Contraseña == usuario.Contraseña)
                    {
                        Session["Usuario"] = usuario; //Almacena el usuario actual
                        Session["Nombre"] = usuario.Nombres;
                        Session["ApellidoPaterno"] = usuario.ApellidoPaterno;
                        Session["ApellidoMaterno"] = usuario.ApellidoMaterno;
                        Session["Matricula"] = usuario.Matricula;
                        Session["Correo"] = usuario.CorreoElectronico;
                        Session["IdPerfil"] = usuario.IdPerfil;
                        return RedirectToAction("Index", "Home"); //Envia a la pagina de inicio 
                    }
                    else
                        ViewBag.message = "La contraseña es incorrecta.";
                }
                else
                    ViewBag.Message = "¡El usuario no existe!";
            }
            else
            {
                ViewBag.message = "El usuario es obligatorio.";
            }

            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Recovery()
        {
            return View();
        }
    }
}