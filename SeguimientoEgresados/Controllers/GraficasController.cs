using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SeguimientoEgresados.Datos;
using SeguimientoEgresados.Models;
using SeguimientoEgresados.Models.ViewModels;

namespace SeguimientoEgresados.Controllers
{
    [CustomAuthorize(Users = "1")]
    public class GraficasController : Controller
    {
        DBConnection db = new DBConnection();
        List<CantidadUsuarioRespuesta> ListaCantidadUsuarios = new List<CantidadUsuarioRespuesta>();
        List<CantidadUsuarioRespuesta> ListaCantidadRespuestas = new List<CantidadUsuarioRespuesta>();
        List<Area> ListaAreas= new List<Area>();

        public GraficasController()
        {
            ListaCantidadUsuarios = db.ObtenerCantidadUsuarios();
            ListaAreas= db.ObtenerAreas();
        }


        // GET: Graficas
        public ActionResult Graficas(string IdArea)
        {
            //var param = IdArea == null ? "4" : IdArea;
            //ViewBag.usuarios = ListaCantidadUsuarios;
            ViewBag.areas = ListaAreas;
            //DT_Reporte objDT_Reporte = new DT_Reporte();
            //List<Reporte> objLista = objDT_Reporte.Reporte_RamaEmpresa(param);

            GraficaVM graficaVM = new GraficaVM()
            {
                Area = ViewBag.Areas,
                //reporte = objLista,
                AreaModelo = new Area()
            };

            return View(graficaVM);
        }

        [HttpGet]
        public JsonResult ReporteTrabajasActualmente(string IdArea)
        {
            DT_Reporte objDT_Reporte = new DT_Reporte();

            List<Reporte> objLista = objDT_Reporte.Reporte_TrabajasActualmente(IdArea);

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ReportesIngresoMensual(string IdArea)
        {
            DT_Reporte objDT_Reporte = new DT_Reporte();

            List<Reporte> objLista = objDT_Reporte.Reporte_IngresoMensual(IdArea);

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ReportesMedioObtuvoTrabajo(string IdArea)
        {
            DT_Reporte objDT_Reporte = new DT_Reporte();

            List<Reporte> objLista = objDT_Reporte.Reporte_MedioObtuvoTrabajo(IdArea);

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ReportesRamaEmpresa(string IdArea)
        {
            DT_Reporte objDT_Reporte = new DT_Reporte();

            List<Reporte> objLista = objDT_Reporte.Reporte_RamaEmpresa(IdArea);

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }

        //[HttpGet]
        //public ActionResult ReportesRamaEmpresaView(string IdArea)
        //{
        //    DT_Reporte objDT_Reporte = new DT_Reporte();

        //    List<Reporte> objLista = objDT_Reporte.Reporte_RamaEmpresa(IdArea);

        //    return View("Graficas" ,objLista);
        //}

        //[HttpPost]
        //public JsonResult ReportesRamaEmpresa2(string area)
        //{
        //    DT_Reporte objDT_Reporte = new DT_Reporte();

        //    List<Reporte> objLista = objDT_Reporte.Reporte_RamaEmpresa(area);

        //    return Json(objLista, JsonRequestBehavior.AllowGet);
        //}

        [HttpGet]
        public JsonResult ReportesExpectativasFormacion(string IdArea)
        {
            DT_Reporte objDT_Reporte = new DT_Reporte();

            List<Reporte> objLista = objDT_Reporte.Reporte_ExpectativasFormacion(IdArea);

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ReportesRecomiendasUTTN(string IdArea)
        {
            DT_Reporte objDT_Reporte = new DT_Reporte();

            List<Reporte> objLista = objDT_Reporte.Reporte_RecomiendasUTTN(IdArea);

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }

        // GET: Graficas
        public ActionResult Index()
        {
            return View();
        }

    }
}
