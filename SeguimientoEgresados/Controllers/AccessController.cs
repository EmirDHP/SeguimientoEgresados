using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SeguimientoEgresados.Controllers
{
    public class AccessController : Controller
    {
        string urlDomain = "http://201.174.6.168/SeguimientoEgresados/";

        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult StartRecovery()
        {
            Models.RecoveryViewModel model = new Models.RecoveryViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult StartRecovery(Models.RecoveryViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                string token = GetSha256(Guid.NewGuid().ToString());

                using (Models.SEGUIMIENTO_EGRESADOSEntities db = new Models.SEGUIMIENTO_EGRESADOSEntities())
                {
                    var oUser = db.USUARIOS.Where(d => d.CorreoElectronico == model.email).FirstOrDefault();
                    if (oUser != null)
                    {
                        oUser.token_recovery = token;
                        db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        //enviar mail
                        SendEmail(oUser.CorreoElectronico, token);
                    }
                }

                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpGet]
        public ActionResult Recovery(string token)
        {
            Models.RecoveryPasswordViewModel model = new Models.RecoveryPasswordViewModel();
            model.token = token;
            using (Models.SEGUIMIENTO_EGRESADOSEntities db = new Models.SEGUIMIENTO_EGRESADOSEntities())
            {
                if (model.token == null || model.token.Trim().Equals(""))
                {
                    //ViewBag.Error = "Tu token ha expirado";
                    return View("Index");
                }
                var oUser = db.USUARIOS.Where(d => d.token_recovery == model.token).FirstOrDefault();
                if (oUser == null)
                {
                    ViewBag.Error = "¡Tu token ha expirado!";
                    return View("Index");
                }
            }
            //model.token = token;
            return View(model);
        }

        [HttpPost]
        public ActionResult Recovery(Models.RecoveryPasswordViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                using (Models.SEGUIMIENTO_EGRESADOSEntities db = new Models.SEGUIMIENTO_EGRESADOSEntities())
                {
                    var oUser = db.USUARIOS.Where(d => d.token_recovery == model.token).FirstOrDefault();

                    if (oUser != null)
                    {
                        oUser.Contraseña = model.Password;
                        oUser.token_recovery = null;
                        db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            ViewBag.Message = "¡Contraseña modificada con éxito!";
            return View("Index");
        }

        #region HELPERS
        private string GetSha256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private void SendEmail(string EmailDestino, string token)
        {
            string EmailOrigen = "direccionti@uttn.mx";
            string Contraseña = "C4rr3r4t1";
            string url = urlDomain + "/Access/Recovery/?token=" + token;
            MailMessage oMailMessage = new MailMessage(EmailOrigen, EmailDestino, "Recuperación de contraseña",
                "<p>Correo para recuperación de contraseña</p><br>" +
                "<a href='" + url + "'>Click para crear tu nueva contraseña</a>");

            oMailMessage.IsBodyHtml = true;

            SmtpClient oSmtpClient = new SmtpClient("smtp.office365.com");
            oSmtpClient.EnableSsl = true;
            oSmtpClient.UseDefaultCredentials = false;
            oSmtpClient.Port = 587;
            oSmtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, Contraseña);

            oSmtpClient.Send(oMailMessage);

            oSmtpClient.Dispose();
        }

        #endregion
    }
}