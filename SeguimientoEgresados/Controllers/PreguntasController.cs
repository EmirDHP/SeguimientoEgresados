using SeguimientoEgresados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguimientoEgresados.Controllers
{
    public class PreguntasController : Controller
    {
        DBConnection db = new DBConnection();
        List<Preguntas> ListaPreguntas = new List<Preguntas>();
        List<ViewModel_Preguntas> ListaPreguntasViewModel = new List<ViewModel_Preguntas>();
        List<PreguntasEstablecidas> ListaRespPrest1 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest2 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest3 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest4 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest5 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest6 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest7 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest8 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest9 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest10 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest11 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest12 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest13 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest14 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest15 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest16 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest17 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest18 = new List<PreguntasEstablecidas>();
        List<PreguntasEstablecidas> ListaRespPrest19 = new List<PreguntasEstablecidas>();

        List<Area> ListaArea = new List<Area>();
        List<Año> ListaAñoInicio = new List<Año>();
        List<Año> ListaAñoFin = new List<Año>();

        List<Usuarios> ListaUsuarios2 = new List<Usuarios>();

        public PreguntasController()
        {
            ListaPreguntas = db.ObtenerPreguntas();
            ListaPreguntasViewModel = db.ObtenerPreguntas_ViewModel();
            ListaRespPrest1 = db.Obtener_PREG_SL_17_18_19_20();
            ListaRespPrest2 = db.Obtener_PREG_DG_1();
            ListaRespPrest3 = db.Obtener_PREG_DG_2();
            ListaRespPrest4 = db.Obtener_PREG_DG_3();
            ListaRespPrest5 = db.Obtener_PREG_SINO_SL3_SL14_SL22();
            ListaRespPrest6 = db.Obtener_PREG_SL_4();
            ListaRespPrest7 = db.Obtener_PREG_SL_5();
            ListaRespPrest8 = db.Obtener_PREG_SL_7();
            ListaRespPrest9 = db.Obtener_PREG_SL_8();
            ListaRespPrest10 = db.Obtener_PREG_SL_9();
            ListaRespPrest11 = db.Obtener_PREG_SL_10();
            ListaRespPrest12 = db.Obtener_PREG_SL_11();
            ListaRespPrest13 = db.Obtener_PREG_SL_12();
            ListaRespPrest14 = db.Obtener_PREG_SL_13();
            ListaRespPrest15 = db.Obtener_PREG_SL_15();
            ListaRespPrest16 = db.Obtener_PREG_SL_16();
            ListaRespPrest17 = db.Obtener_PREG_SL_17();
            ListaRespPrest18 = db.Obtener_PREG_SL_20();
            ListaRespPrest19 = db.Obtener_PREG_SL_1();

            ListaArea = db.Obtener_Area();
            ListaAñoInicio = db.Obtener_AñoInicio();
            ListaAñoFin = db.Obtener_AñoFin();
                
            ListaUsuarios2 = db.ObtenerUsuarios2();

        }

        [CustomAuthorize(Users = "1")]
        // GET: Preguntas
        public ActionResult TotalRespuestas()
        {
            return View(ListaPreguntasViewModel);
        }

        [CustomAuthorize(Users = "1")]
        // GET: Preguntas
        public ActionResult Index()
        {
            return View(ListaPreguntasViewModel);
        }

        [CustomAuthorize(Users = "1")]
        // GET: Preguntas/Details/5
        public ActionResult Detalles(int? id)
        {
            if (id == null)
                return RedirectToAction("VacantesDisponibles");

            ViewModel_Preguntas cpa = ListaPreguntasViewModel.FirstOrDefault(x => x.IdPregunta == id);
            if (cpa != null)
                return View(cpa);

            return RedirectToAction("VacantesDisponibles");
        }


        [CustomAuthorize(Users = "2")]
        // GET: Preguntas/Create
        public ActionResult Create()
        {
            ViewBag.Preg20_1 = ListaRespPrest1;
            ViewBag.Preg20_2 = ListaRespPrest1;

            ViewBag.Preg1 = ListaRespPrest2;
            ViewBag.Preg2 = ListaRespPrest3;
            ViewBag.Preg3 = ListaRespPrest4;
            ViewBag.Preg4 = ListaRespPrest5;

            ViewBag.Preg5 = ListaRespPrest6;
            ViewBag.Preg6 = ListaRespPrest7;
            ViewBag.Preg7 = ListaRespPrest8;
            ViewBag.Preg8 = ListaRespPrest9;
            ViewBag.Preg9 = ListaRespPrest10;
            ViewBag.Preg10 = ListaRespPrest11;
            ViewBag.Preg11 = ListaRespPrest12;
            ViewBag.Preg12 = ListaRespPrest13;
            ViewBag.Preg13 = ListaRespPrest14;
            ViewBag.Preg14 = ListaRespPrest15;
            ViewBag.Preg15 = ListaRespPrest16;
            ViewBag.Preg16 = ListaRespPrest17;
            ViewBag.Preg17 = ListaRespPrest18;
            ViewBag.Preg18 = ListaRespPrest19;

            ViewBag.AñoInicioLista = ListaAñoInicio;
            ViewBag.AñofinLista = ListaAñoFin;
            ViewBag.AreaLista = ListaArea;

            ViewBag.Nombre = ListaUsuarios2[0].Nombres;
            ViewBag.Paterno = ListaUsuarios2[0].ApellidoPaterno;
            ViewBag.Materno = ListaUsuarios2[0].ApellidoMaterno;
            ViewBag.Matricula = ListaUsuarios2[0].Matricula;
            ViewBag.CorreoElectronico = ListaUsuarios2[0].CorreoElectronico;

            return View();
        }

        // POST: Preguntas/Create
        [HttpPost]
        public ActionResult Create(Preguntas preguntas)
        {
            if (ModelState.IsValid)
            {
                db.SetPreguntas(preguntas, 1);
                TempData["success"] = "¡la encuesta ha sido contestado con éxito!.";
                //return RedirectToAction("index", "preguntas");
                return RedirectToAction("Index", "UsuarioPreguntas");

            }
            return View(preguntas);
        }


        // GET: TI/Edit/5
        public ActionResult Editar(int? id)
        {
            if (id == null) // Si el id es nulo regresa al index
                return RedirectToAction("Index");

            // Busca el usuario en la lista y lo recupera por su id
            Preguntas preguntas = ListaPreguntas.FirstOrDefault(x => x.IdPregunta == id);

            ViewBag.Preg20_1 = ListaRespPrest1;
            ViewBag.Preg20_2 = ListaRespPrest1;

            ViewBag.Preg1 = ListaRespPrest2;
            ViewBag.Preg2 = ListaRespPrest3;
            ViewBag.Preg3 = ListaRespPrest4;
            ViewBag.Preg4 = ListaRespPrest5;

            ViewBag.Preg5 = ListaRespPrest6;
            ViewBag.Preg6 = ListaRespPrest7;
            ViewBag.Preg7 = ListaRespPrest8;
            ViewBag.Preg8 = ListaRespPrest9;
            ViewBag.Preg9 = ListaRespPrest10;
            ViewBag.Preg10 = ListaRespPrest11;
            ViewBag.Preg11 = ListaRespPrest12;
            ViewBag.Preg12 = ListaRespPrest13;
            ViewBag.Preg13 = ListaRespPrest14;
            ViewBag.Preg14 = ListaRespPrest15;
            ViewBag.Preg15 = ListaRespPrest16;
            ViewBag.Preg16 = ListaRespPrest17;
            ViewBag.Preg17 = ListaRespPrest18;
            ViewBag.Preg18 = ListaRespPrest19;

            ViewBag.AñoInicioLista = ListaAñoInicio;
            ViewBag.AñofinLista = ListaAñoFin;
            ViewBag.AreaLista = ListaArea;

            ViewBag.Nombre = ListaUsuarios2[0].Nombres;
            ViewBag.Paterno = ListaUsuarios2[0].ApellidoPaterno;
            ViewBag.Materno = ListaUsuarios2[0].ApellidoMaterno;
            ViewBag.Matricula = ListaUsuarios2[0].Matricula;
            ViewBag.CorreoElectronico = ListaUsuarios2[0].CorreoElectronico;

            if (preguntas != null)
                return View(preguntas);
            // Si no encuentra al usuario regresa al index
            return RedirectToAction("Index");
        }

        // POST: TI/Edit/5
        [HttpPost]
        public ActionResult Editar(Preguntas preguntas)
        {
            ViewBag.Preg20_1 = ListaRespPrest1;
            ViewBag.Preg20_2 = ListaRespPrest1;
            ViewBag.Preg1 = ListaRespPrest2;
            ViewBag.Preg2 = ListaRespPrest3;
            ViewBag.Preg3 = ListaRespPrest4;
            ViewBag.Preg4 = ListaRespPrest5;
            ViewBag.Preg5 = ListaRespPrest6;
            ViewBag.Preg6 = ListaRespPrest7;
            ViewBag.Preg7 = ListaRespPrest8;
            ViewBag.Preg8 = ListaRespPrest9;
            ViewBag.Preg9 = ListaRespPrest10;
            ViewBag.Preg10 = ListaRespPrest11;
            ViewBag.Preg11 = ListaRespPrest12;
            ViewBag.Preg12 = ListaRespPrest13;
            ViewBag.Preg13 = ListaRespPrest14;
            ViewBag.Preg14 = ListaRespPrest15;
            ViewBag.Preg15 = ListaRespPrest16;
            ViewBag.Preg16 = ListaRespPrest17;
            ViewBag.Preg17 = ListaRespPrest18;
            ViewBag.Preg18 = ListaRespPrest19;

            ViewBag.AñoInicioLista = ListaAñoInicio;
            ViewBag.AñofinLista = ListaAñoFin;
            ViewBag.AreaLista = ListaArea;

            ViewBag.Nombre = ListaUsuarios2[0].Nombres;
            ViewBag.Paterno = ListaUsuarios2[0].ApellidoPaterno;
            ViewBag.Materno = ListaUsuarios2[0].ApellidoMaterno;
            ViewBag.Matricula = ListaUsuarios2[0].Matricula;
            ViewBag.CorreoElectronico = ListaUsuarios2[0].CorreoElectronico;

            if (ModelState.IsValid)
            {
                db.SetPreguntas(preguntas, 2);
                TempData["EditSuccess"] = "La encuesta ha sido editado.";
                return RedirectToAction("Index");
            }
            // Si los datos no son correctos regresa al formulario de Edit
            return View(preguntas);
        }


        // GET: Preguntas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Preguntas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        [CustomAuthorize(Users = "1")]
        // GET: Preguntas/Delete/5
        public ActionResult Eliminar(int? id)
        {
            if (id == null) // Si el id es nulo regresa al index
                return RedirectToAction("Index");

            Preguntas preguntas = ListaPreguntas.FirstOrDefault(x => x.IdPregunta == id);
            if (preguntas != null)
                return View(preguntas);   // Muestra la vista detalles y envia el Perfil

            // Si no encuentra el Perfil regresa al index
            return RedirectToAction("Index");
        }

        // POST: Preguntas/Delete/5
        [HttpPost]
        public ActionResult Eliminar(int? id, Preguntas preguntas)
        {
            if (id == null) // Si el id es nulo regresa al index
                return RedirectToAction("Index");

            preguntas.IdPregunta = (int)id;
            db.SetPreguntas2(preguntas, 3);

            TempData["DeleteSuccess"] = "¡La publicación a sido elimando con éxito!.";
            // Si no encuentra el usuario regresa al index
            return RedirectToAction("Index");
        }
    }
}
