using SeguimientoEgresados.Models;
using SeguimientoEgresados.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguimientoEgresados.Controllers
{
    [CustomAuthorize(Users = "1")]
    public class PublicacionesController : Controller
    {
        DBConnection db = new DBConnection();
        PUBLICACIONE pub = new PUBLICACIONE();
        List<Publicaciones> ListaPublicaciones = new List<Publicaciones>();
        List<ViewModelPublicaciones> ViewModelListaPublicaciones = new List<ViewModelPublicaciones>();
        List<PUBLICACIONE> ListaPUBLICACIONES = new List<PUBLICACIONE>();
        List<TipoTrabajo> ListaTipoTrabajo = new List<TipoTrabajo>();

        public PublicacionesController()
        {
            ViewModelListaPublicaciones = db.ObtenerPublicaciones();
            ListaPublicaciones = db.ObtenerPublicacionesModel();
            ListaTipoTrabajo = db.ObtenerTipoTrabajo();
        }

        #region Subir Fotos
        [HttpGet]
        public ActionResult NuevaPublicacion()
        {
            ViewBag.TipoTrabajo = ListaTipoTrabajo;
            return View();
        }

        [HttpPost]
        public ActionResult NuevaPublicacion(PUBLICACIONE imageModel)
        {
            string fileName = Path.GetFileNameWithoutExtension(imageModel.ImagenFile.FileName);
            string extension = Path.GetExtension(imageModel.ImagenFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            imageModel.Imagen = fileName;
            fileName = Path.Combine(Server.MapPath("~/Images/Publicaciones/"), fileName);
            imageModel.ImagenFile.SaveAs(fileName);
            using (DbModels db = new DbModels())
            {
                db.PUBLICACIONES.Add(imageModel);
                db.SaveChanges();
                TempData["success"] = "¡la publicación a sido creado con éxito!.";
                return RedirectToAction("Index", "Publicaciones");
            }
            return View();
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            PUBLICACIONE imagenModel = new PUBLICACIONE();

            using (DbModels db = new DbModels())
            {
                imagenModel = db.PUBLICACIONES.Where(x => x.IdPublicacion == id).FirstOrDefault();
            }
            return View(imagenModel);
        }
        #endregion

        // GET: Publicaciones
        public ActionResult Index()
        {
            return View(ListaPublicaciones);
        }

        // GET: Publicaciones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }    

        // GET: Publicaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) // Si el id es nulo regresa al index
                return RedirectToAction("Index");

            // Busca el usuario en la lista y lo recupera por su id
            Publicaciones publicaciones = ListaPublicaciones.FirstOrDefault(x => x.IdPublicacion == id);

            if (publicaciones != null)
                return View(publicaciones);
            // Si no encuentra al usuario regresa al index
            return RedirectToAction("Index");
        }

        // POST: Publicaciones/Edit/5
        [HttpPost]
        public ActionResult Edit(Publicaciones publicaciones)
        {
            if (ModelState.IsValid)
            {
                db.SetPublicaciones(publicaciones, 2);
                TempData["EditSuccess"] = "¡La publicación a sido editado con éxito!.";
                return RedirectToAction("Index");
            }
            // Si los datos no son correctos regresa al formulario de Edit
            return View(publicaciones);
        }

        // GET: Publicaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) // Si el id es nulo regresa al index
                return RedirectToAction("Index");

            Publicaciones publicaciones = ListaPublicaciones.FirstOrDefault(x => x.IdPublicacion == id);
            if (publicaciones != null)
                return View(publicaciones);   // Muestra la vista detalles y envia el Perfil

            // Si no encuentra el Perfil regresa al index
            return RedirectToAction("Index");
        }

        // POST: Publicaciones/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Publicaciones publicaciones)
        {
            if (id == null) // Si el id es nulo regresa al index
                return RedirectToAction("Index");

            publicaciones.IdPublicacion = (int)id;
            db.SetPublicaciones(publicaciones, 3);

            TempData["DeleteSuccess"] = "¡La publicación a sido elimando con éxito!.";
            // Si no encuentra el usuario regresa al index
            return RedirectToAction("Index");
        }
    }
}
