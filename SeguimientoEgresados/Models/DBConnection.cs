using System;
using SeguimientoEgresados.ViewModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SeguimientoEgresados.Models
{
    public class DBConnection
    {
        //static string connString = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog = SEGUIMIENTO_EGRESADOS; Integrated Security = True;";
        //static string connString = "Data Source=DESKTOP-VR4M00D;Initial Catalog=SEGUIMIENTO_EGRESADOS;Integrated Security=True;";
        static string connString = "Data Source=201.174.6.168;Initial Catalog=SEGUIMIENTO_EGRESADOS;User ID=sa;Password=TicUtt2017";

        SqlConnection conn = new SqlConnection(connString);

        public List<ViewModelPublicaciones> ObtenerPublicaciones()
        {
            List<ViewModelPublicaciones> lista = new List<ViewModelPublicaciones>();
            try
            {
                string sql = "SP_ObtenerPublicaciones";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ViewModelPublicaciones publicaciones;
                while (dr.Read())
                {
                    publicaciones = new ViewModelPublicaciones();
                    publicaciones.IdPublicacion = dr.GetInt32(0);
                    publicaciones.Titulo = dr.GetString(1);
                    publicaciones.Descripcion = dr.GetString(2);
                    publicaciones.Imagen = dr.GetString(3);
                    publicaciones.FechaPublicaciones = dr.GetDateTime(4);
                    lista.Add(publicaciones);
                    publicaciones = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<Publicaciones> ObtenerPublicacionesModel()
        {
           List<Publicaciones> lista = new List<Publicaciones>();
            try
            {
                string sql = "SP_ObtenerPublicacionesVacantes";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Publicaciones publicaciones;
                while (dr.Read())
                {
                    publicaciones = new Publicaciones();
                    publicaciones.IdPublicacion = dr.GetInt32(0);
                    publicaciones.Titulo = dr.GetString(1);
                    publicaciones.Descripcion = dr.GetString(2);
                    publicaciones.Imagen = dr.GetString(3);
                    publicaciones.FechaPublicaciones = dr.GetDateTime(4);
                    publicaciones.NombreEmpresa = dr.GetString(5);
                    publicaciones.Tipo_Trabajo = dr.GetString(6);
                    lista.Add(publicaciones);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                lista = new List<Publicaciones>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<TipoTrabajo> ObtenerTipoTrabajo()
        {
            List<TipoTrabajo> lista = new List<TipoTrabajo>();
            try
            {
                string sql = "SELECT * FROM TIPO_TRABAJO;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                TipoTrabajo tipoTrabajo;
                while (dr.Read())
                {
                    tipoTrabajo = new TipoTrabajo();
                    tipoTrabajo.IdTipo_trabajo = dr.GetInt32(0);
                    tipoTrabajo.Tipo_Trabajo = dr.GetString(1);
                    lista.Add(tipoTrabajo);
                    tipoTrabajo = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                lista = new List<TipoTrabajo>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public int SetPublicaciones(Publicaciones publicaciones, int opcion)
        {
            int res = 0;
            try
            {
                string sql = "SP_SetPublicaciones";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpublicacion", publicaciones.IdPublicacion);
                cmd.Parameters.AddWithValue("@titulo", publicaciones.Titulo);
                cmd.Parameters.AddWithValue("@descripcion", publicaciones.Descripcion);
                cmd.Parameters.AddWithValue("@imagen", publicaciones.Imagen);
                cmd.Parameters.AddWithValue("@op", opcion);
                conn.Open();
                cmd.ExecuteNonQuery();
                res = 1;
            }
            catch(Exception ex)
            {
                res = 0;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        public int SetPreguntas2(Preguntas preguntas, int opcion)
        {
            int res = 0;
            try
            {
                string sql = "SP_SetPreguntas2";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpregunta", preguntas.IdPregunta);
                cmd.Parameters.AddWithValue("@op", opcion);
                conn.Open();
                cmd.ExecuteNonQuery();
                res = 1;
            }
            catch (Exception ex)
            {
                res = 0;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        public int SetPreguntas(Preguntas preguntas, int opcion)
        {
           int res = 0;
            try
            {
                string sql = "SP_SetPreguntas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpregunta", preguntas.IdPregunta);
                cmd.Parameters.AddWithValue("@ip_nombres", preguntas.IP_Nombres);
                cmd.Parameters.AddWithValue("@ip_apellidopaterno", preguntas.IP_ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ip_apellidomaterno", preguntas.IP_ApellidoMaterno);
                cmd.Parameters.AddWithValue("@ip_matricula", preguntas.IP_Matricula);
                cmd.Parameters.AddWithValue("@ip_correoelectronicopersonal", preguntas.IP_CorreoElectronicoPersonal);
                cmd.Parameters.AddWithValue("@ip_numerotelefono", preguntas.IP_NumeroTelefono);
                cmd.Parameters.AddWithValue("@dg_estadocivil", preguntas.DG_EstadoCivil);
                cmd.Parameters.AddWithValue("@dg_ultimonivelescolar", preguntas.DG_UltimoNivelEscolar);
                cmd.Parameters.AddWithValue("@dg_institucionestudiasactualmente", preguntas.DG_InstitucionEstudiasActualmente);
                cmd.Parameters.AddWithValue("@sl_preg1", preguntas.SL_PREG1);
                cmd.Parameters.AddWithValue("@sl_preg2", preguntas.SL_PREG2);
                cmd.Parameters.AddWithValue("@sl_preg3", preguntas.SL_PREG3);
                cmd.Parameters.AddWithValue("@sl_preg4", preguntas.SL_PREG4);
                cmd.Parameters.AddWithValue("@sl_preg5_1", preguntas.SL_PREG5_1);
                cmd.Parameters.AddWithValue("@sl_preg5_2", preguntas.SL_PREG5_2);
                cmd.Parameters.AddWithValue("@sl_preg5_3", preguntas.SL_PREG5_3);
                cmd.Parameters.AddWithValue("@sl_preg5_4", preguntas.SL_PREG5_4);
                cmd.Parameters.AddWithValue("@sl_preg5_5", preguntas.SL_PREG5_5);
                cmd.Parameters.AddWithValue("@sl_preg6_1_nombreempresa", preguntas.SL_PREG6_1_NombreEmpresa);
                cmd.Parameters.AddWithValue("@sl_preg6_2_municipio", preguntas.SL_PREG6_2_Municipio);
                cmd.Parameters.AddWithValue("@sl_preg6_3_estado", preguntas.SL_PREG6_3_Estado);
                cmd.Parameters.AddWithValue("@sl_preg7", preguntas.SL_PREG7);
                cmd.Parameters.AddWithValue("@sl_preg8", preguntas.SL_PREG8);
                cmd.Parameters.AddWithValue("@sl_preg9", preguntas.SL_PREG9);
                cmd.Parameters.AddWithValue("@sl_preg10", preguntas.SL_PREG10);
                cmd.Parameters.AddWithValue("@sl_preg11", preguntas.SL_PREG11);
                cmd.Parameters.AddWithValue("@sl_preg12", preguntas.SL_PREG12);
                cmd.Parameters.AddWithValue("@sl_preg13", preguntas.SL_PREG13);
                cmd.Parameters.AddWithValue("@sl_preg14_1", preguntas.SL_PREG14_1);
                cmd.Parameters.AddWithValue("@sl_preg14_2", preguntas.SL_PREG14_2);
                cmd.Parameters.AddWithValue("@sl_preg14_3", preguntas.SL_PREG14_3);
                cmd.Parameters.AddWithValue("@sl_preg14_4", preguntas.SL_PREG14_4);
                cmd.Parameters.AddWithValue("@sl_preg14_5", preguntas.SL_PREG14_5);
                cmd.Parameters.AddWithValue("@sl_preg14_6", preguntas.SL_PREG14_6);
                cmd.Parameters.AddWithValue("@sl_preg14_7", preguntas.SL_PREG14_7);
                cmd.Parameters.AddWithValue("@sl_preg14_8", preguntas.SL_PREG14_8);
                cmd.Parameters.AddWithValue("@sl_preg14_9", preguntas.SL_PREG14_9);
                cmd.Parameters.AddWithValue("@sl_preg14_10", preguntas.SL_PREG14_10);
                cmd.Parameters.AddWithValue("@sl_preg14_11", preguntas.SL_PREG14_11);
                cmd.Parameters.AddWithValue("@sl_preg14_12", preguntas.SL_PREG14_12);
                cmd.Parameters.AddWithValue("@sl_preg15", preguntas.SL_PREG15);
                cmd.Parameters.AddWithValue("@sl_preg16", preguntas.SL_PREG16);
                cmd.Parameters.AddWithValue("@sl_preg17_1", preguntas.SL_PREG17_1);
                cmd.Parameters.AddWithValue("@sl_preg17_2", preguntas.SL_PREG17_2);
                cmd.Parameters.AddWithValue("@sl_preg17_3", preguntas.SL_PREG17_3);
                cmd.Parameters.AddWithValue("@sl_preg17_4", preguntas.SL_PREG17_4);
                cmd.Parameters.AddWithValue("@sl_preg17_5", preguntas.SL_PREG17_5);
                cmd.Parameters.AddWithValue("@sl_preg17_6", preguntas.SL_PREG17_6);
                cmd.Parameters.AddWithValue("@sl_preg17_7", preguntas.SL_PREG17_7);
                cmd.Parameters.AddWithValue("@sl_preg17_8", preguntas.SL_PREG17_8);
                cmd.Parameters.AddWithValue("@sl_preg17_9", preguntas.SL_PREG17_9);
                cmd.Parameters.AddWithValue("@sl_preg17_10", preguntas.SL_PREG17_10);
                cmd.Parameters.AddWithValue("@sl_preg17_11", preguntas.SL_PREG17_11);
                cmd.Parameters.AddWithValue("@sl_preg18_1", preguntas.SL_PREG18_1);
                cmd.Parameters.AddWithValue("@sl_preg18_2", preguntas.SL_PREG18_2);
                cmd.Parameters.AddWithValue("@sl_preg18_3", preguntas.SL_PREG18_3);
                cmd.Parameters.AddWithValue("@sl_preg18_4", preguntas.SL_PREG18_4);
                cmd.Parameters.AddWithValue("@sl_preg18_5", preguntas.SL_PREG18_5);
                cmd.Parameters.AddWithValue("@sl_preg18_6", preguntas.SL_PREG18_6);
                cmd.Parameters.AddWithValue("@sl_preg18_7", preguntas.SL_PREG18_7);
                cmd.Parameters.AddWithValue("@sl_preg18_8", preguntas.SL_PREG18_8);
                cmd.Parameters.AddWithValue("@sl_preg18_9", preguntas.SL_PREG18_9);
                cmd.Parameters.AddWithValue("@sl_preg18_10", preguntas.SL_PREG18_10);
                cmd.Parameters.AddWithValue("@sl_preg18_11", preguntas.SL_PREG18_11);
                cmd.Parameters.AddWithValue("@sl_preg19_1", preguntas.SL_PREG19_1);
                cmd.Parameters.AddWithValue("@sl_preg19_2", preguntas.SL_PREG19_2);
                cmd.Parameters.AddWithValue("@sl_preg19_3", preguntas.SL_PREG19_3);
                cmd.Parameters.AddWithValue("@sl_preg19_4", preguntas.SL_PREG19_4);
                cmd.Parameters.AddWithValue("@sl_preg19_5", preguntas.SL_PREG19_5);
                cmd.Parameters.AddWithValue("@sl_preg19_6", preguntas.SL_PREG19_6);
                cmd.Parameters.AddWithValue("@sl_preg19_7", preguntas.SL_PREG19_7);
                cmd.Parameters.AddWithValue("@sl_preg19_8", preguntas.SL_PREG19_8);
                cmd.Parameters.AddWithValue("@sl_preg19_9", preguntas.SL_PREG19_9);
                cmd.Parameters.AddWithValue("@sl_preg19_10", preguntas.SL_PREG19_10);
                cmd.Parameters.AddWithValue("@sl_preg20_1", preguntas.SL_PREG20_1);
                cmd.Parameters.AddWithValue("@sl_preg20_2", preguntas.SL_PREG20_2);
                cmd.Parameters.AddWithValue("@sl_preg20_3", preguntas.SL_PREG20_3);
                cmd.Parameters.AddWithValue("@sl_preg20_4", preguntas.SL_PREG20_4);
                cmd.Parameters.AddWithValue("@sl_preg20_5", preguntas.SL_PREG20_5);
                cmd.Parameters.AddWithValue("@sl_preg20_6", preguntas.SL_PREG20_6);
                cmd.Parameters.AddWithValue("@sl_preg20_7", preguntas.SL_PREG20_7);
                cmd.Parameters.AddWithValue("@sl_preg20_8", preguntas.SL_PREG20_8);
                cmd.Parameters.AddWithValue("@sl_preg20_9", preguntas.SL_PREG20_9);
                cmd.Parameters.AddWithValue("@sl_preg20_10", preguntas.SL_PREG20_10);
                cmd.Parameters.AddWithValue("@sl_preg20_11", preguntas.SL_PREG20_11);
                cmd.Parameters.AddWithValue("@sl_preg20_12", preguntas.SL_PREG20_12);
                cmd.Parameters.AddWithValue("@sl_preg20_13", preguntas.SL_PREG20_13);
                cmd.Parameters.AddWithValue("@sl_preg21", preguntas.SL_PREG21);
                cmd.Parameters.AddWithValue("@sl_preg22", preguntas.SL_PREG22);
                cmd.Parameters.AddWithValue("@area", preguntas.Areas);
                cmd.Parameters.AddWithValue("@añoinicio", preguntas.AñoInico);
                cmd.Parameters.AddWithValue("@añofin", preguntas.AñoFin);
                cmd.Parameters.AddWithValue("@op", opcion);
                conn.Open();
                cmd.ExecuteNonQuery();
                res = 1;
            }
            catch (Exception ex)
            {
                res = 0;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        public List<CantidadUsuarioRespuesta> ObtenerCantidadUsuarios()
        {
            List<CantidadUsuarioRespuesta> lista = new List<CantidadUsuarioRespuesta>();
            try
            {
                string sql = "SP_UsuariosCantidad";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                CantidadUsuarioRespuesta cantidad;
                while (dr.Read())
                {
                    cantidad = new CantidadUsuarioRespuesta();
                    cantidad.cantidad = dr.GetInt32(0);
                    lista.Add(cantidad);
                    cantidad = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<Preguntas> ObtenerPreguntas()
        {
            List<Preguntas> lista = new List<Preguntas>();
            try
            {
                string sql = "SP_ObtenerPreguntas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Preguntas preguntas;
                while (dr.Read())
                {
                    preguntas = new Preguntas();
                    preguntas.IdPregunta = dr.GetInt32(0);
                    preguntas.IP_Nombres = dr.GetString(1);
                    preguntas.IP_ApellidoPaterno = dr.GetString(2);
                    preguntas.IP_ApellidoMaterno = dr.GetString(3);
                    preguntas.IP_Matricula = dr.GetString(4);
                    preguntas.IP_CorreoElectronicoPersonal = dr.GetString(5);
                    preguntas.IP_NumeroTelefono = dr.GetString(6);
                    preguntas.DG_EstadoCivil = dr.GetInt32(7);
                    preguntas.DG_UltimoNivelEscolar = dr.GetInt32(8);
                    preguntas.DG_InstitucionEstudiasActualmente = dr.GetInt32(9);
                    preguntas.SL_PREG1 = dr.GetInt32(10);
                    preguntas.SL_PREG2 = dr.GetString(11);
                    preguntas.SL_PREG3 = dr.GetInt32(12);
                    preguntas.SL_PREG4 = dr.GetInt32(13);
                    preguntas.SL_PREG5_1 = dr.GetInt32(14);
                    preguntas.SL_PREG5_2 = dr.GetInt32(15);
                    preguntas.SL_PREG5_3 = dr.GetInt32(16);
                    preguntas.SL_PREG5_4 = dr.GetInt32(17);
                    preguntas.SL_PREG5_5 = dr.GetInt32(18);
                    preguntas.SL_PREG6_1_NombreEmpresa = dr.GetString(19);
                    preguntas.SL_PREG6_2_Municipio = dr.GetString(20);
                    preguntas.SL_PREG6_3_Estado = dr.GetString(21);
                    preguntas.SL_PREG7 = dr.GetInt32(22);
                    preguntas.SL_PREG8 = dr.GetInt32(23);
                    preguntas.SL_PREG9 = dr.GetInt32(24);
                    preguntas.SL_PREG10 = dr.GetInt32(25);
                    preguntas.SL_PREG11 = dr.GetInt32(26);
                    preguntas.SL_PREG12 = dr.GetInt32(27);
                    preguntas.SL_PREG13 = dr.GetInt32(28);
                    preguntas.SL_PREG14_1 = dr.GetInt32(29);
                    preguntas.SL_PREG14_2 = dr.GetInt32(30);
                    preguntas.SL_PREG14_3 = dr.GetInt32(31);
                    preguntas.SL_PREG14_4 = dr.GetInt32(32);
                    preguntas.SL_PREG14_5 = dr.GetInt32(33);
                    preguntas.SL_PREG14_6 = dr.GetInt32(34);
                    preguntas.SL_PREG14_7 = dr.GetInt32(35);
                    preguntas.SL_PREG14_8 = dr.GetInt32(36);
                    preguntas.SL_PREG14_9 = dr.GetInt32(37);
                    preguntas.SL_PREG14_10 = dr.GetInt32(38);
                    preguntas.SL_PREG14_11 = dr.GetInt32(39);
                    preguntas.SL_PREG14_12 = dr.GetInt32(40);
                    preguntas.SL_PREG15 = dr.GetInt32(41);
                    preguntas.SL_PREG16 = dr.GetInt32(42);
                    preguntas.SL_PREG17_1 = dr.GetInt32(43);
                    preguntas.SL_PREG17_2 = dr.GetInt32(44);
                    preguntas.SL_PREG17_3 = dr.GetInt32(45);
                    preguntas.SL_PREG17_4 = dr.GetInt32(46);
                    preguntas.SL_PREG17_5 = dr.GetInt32(47);
                    preguntas.SL_PREG17_6 = dr.GetInt32(48);
                    preguntas.SL_PREG17_7 = dr.GetInt32(49);
                    preguntas.SL_PREG17_8 = dr.GetInt32(50);
                    preguntas.SL_PREG17_9 = dr.GetInt32(51);
                    preguntas.SL_PREG17_10 = dr.GetInt32(52);
                    preguntas.SL_PREG17_11 = dr.GetInt32(53);
                    preguntas.SL_PREG18_1 = dr.GetInt32(54);
                    preguntas.SL_PREG18_2 = dr.GetInt32(55);
                    preguntas.SL_PREG18_3 = dr.GetInt32(56);
                    preguntas.SL_PREG18_4 = dr.GetInt32(57);
                    preguntas.SL_PREG18_5 = dr.GetInt32(58);
                    preguntas.SL_PREG18_6 = dr.GetInt32(59);
                    preguntas.SL_PREG18_7 = dr.GetInt32(60);
                    preguntas.SL_PREG18_8 = dr.GetInt32(61);
                    preguntas.SL_PREG18_9 = dr.GetInt32(62);
                    preguntas.SL_PREG18_10 = dr.GetInt32(63);
                    preguntas.SL_PREG18_11 = dr.GetInt32(64);
                    preguntas.SL_PREG19_1 = dr.GetInt32(65);
                    preguntas.SL_PREG19_2 = dr.GetInt32(66);
                    preguntas.SL_PREG19_3 = dr.GetInt32(67);
                    preguntas.SL_PREG19_4 = dr.GetInt32(68);
                    preguntas.SL_PREG19_5 = dr.GetInt32(69);
                    preguntas.SL_PREG19_6 = dr.GetInt32(70);
                    preguntas.SL_PREG19_7 = dr.GetInt32(71);
                    preguntas.SL_PREG19_8 = dr.GetInt32(72);
                    preguntas.SL_PREG19_9 = dr.GetInt32(73);
                    preguntas.SL_PREG19_10 = dr.GetInt32(74);
                    preguntas.SL_PREG20_1 = dr.GetInt32(75);
                    preguntas.SL_PREG20_2 = dr.GetInt32(76);
                    preguntas.SL_PREG20_3 = dr.GetInt32(77);
                    preguntas.SL_PREG20_4 = dr.GetInt32(78);
                    preguntas.SL_PREG20_5 = dr.GetInt32(79);
                    preguntas.SL_PREG20_6 = dr.GetInt32(80);
                    preguntas.SL_PREG20_7 = dr.GetInt32(81);
                    preguntas.SL_PREG20_8 = dr.GetInt32(82);
                    preguntas.SL_PREG20_9 = dr.GetInt32(83);
                    preguntas.SL_PREG20_10 = dr.GetInt32(84);
                    preguntas.SL_PREG20_11 = dr.GetInt32(85);
                    preguntas.SL_PREG20_12 = dr.GetInt32(86);
                    preguntas.SL_PREG20_13 = dr.GetInt32(87);
                    preguntas.SL_PREG21 = dr.GetInt32(88);
                    preguntas.SL_PREG22 = dr.GetInt32(89);
                    preguntas.Areas = dr.GetInt32(90);
                    preguntas.AñoInico = dr.GetInt32(91);
                    preguntas.AñoFin = dr.GetInt32(92);
                    lista.Add(preguntas);
                    preguntas = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<ViewModel_Preguntas> ObtenerPreguntas_ViewModel()
        {
            List<ViewModel_Preguntas> lista = new List<ViewModel_Preguntas>();
            try
            {
                string sql = "SP_ObtenerPreguntasViewModel2";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ViewModel_Preguntas preguntas;
                while (dr.Read())
                {
                    preguntas = new ViewModel_Preguntas();
                    preguntas.IdPregunta = dr.GetInt32(0);
                    preguntas.IP_Nombres = dr.GetString(1);
                    preguntas.IP_ApellidoPaterno = dr.GetString(2);
                    preguntas.IP_ApellidoMaterno = dr.GetString(3);
                    preguntas.IP_Matricula = dr.GetString(4);
                    preguntas.IP_CorreoElectronicoPersonal = dr.GetString(5);
                    preguntas.IP_NumeroTelefono = dr.GetString(6);
                    preguntas.DG_EstadoCivil = dr.GetString(7);
                    preguntas.DG_UltimoNivelEscolar = dr.GetString(8);
                    preguntas.DG_InstitucionEstudiasActualmente = dr.GetString(9);
                    preguntas.SL_PREG1 = dr.GetString(10);
                    preguntas.SL_PREG2 = dr.GetString(11);
                    preguntas.SL_PREG3 = dr.GetString(12);
                    preguntas.SL_PREG4 = dr.GetString(13);
                    preguntas.SL_PREG5_1 = dr.GetString(14);
                    preguntas.SL_PREG5_2 = dr.GetString(15);
                    preguntas.SL_PREG5_3 = dr.GetString(16);
                    preguntas.SL_PREG5_4 = dr.GetString(17);
                    preguntas.SL_PREG5_5 = dr.GetString(18);
                    preguntas.SL_PREG6_1_NombreEmpresa = dr.GetString(19);
                    preguntas.SL_PREG6_2_Municipio = dr.GetString(20);
                    preguntas.SL_PREG6_3_Estado = dr.GetString(21);
                    preguntas.SL_PREG7 = dr.GetString(22);
                    preguntas.SL_PREG8 = dr.GetString(23);
                    preguntas.SL_PREG9 = dr.GetString(24);
                    preguntas.SL_PREG10 = dr.GetString(25);
                    preguntas.SL_PREG11 = dr.GetString(26);
                    preguntas.SL_PREG12 = dr.GetString(27);
                    preguntas.SL_PREG13 = dr.GetString(28);
                    preguntas.SL_PREG14_1 = dr.GetString(29);
                    preguntas.SL_PREG14_2 = dr.GetString(30);
                    preguntas.SL_PREG14_3 = dr.GetString(31);
                    preguntas.SL_PREG14_4 = dr.GetString(32);
                    preguntas.SL_PREG14_5 = dr.GetString(33);
                    preguntas.SL_PREG14_6 = dr.GetString(34);
                    preguntas.SL_PREG14_7 = dr.GetString(35);
                    preguntas.SL_PREG14_8 = dr.GetString(36);
                    preguntas.SL_PREG14_9 = dr.GetString(37);
                    preguntas.SL_PREG14_10 = dr.GetString(38);
                    preguntas.SL_PREG14_11 = dr.GetString(39);
                    preguntas.SL_PREG14_12 = dr.GetString(40);
                    preguntas.SL_PREG15 = dr.GetString(41);
                    preguntas.SL_PREG16 = dr.GetString(42);
                    preguntas.SL_PREG17_1 = dr.GetString(43);
                    preguntas.SL_PREG17_2 = dr.GetString(44);
                    preguntas.SL_PREG17_3 = dr.GetString(45);
                    preguntas.SL_PREG17_4 = dr.GetString(46);
                    preguntas.SL_PREG17_5 = dr.GetString(47);
                    preguntas.SL_PREG17_6 = dr.GetString(48);
                    preguntas.SL_PREG17_7 = dr.GetString(49);
                    preguntas.SL_PREG17_8 = dr.GetString(50);
                    preguntas.SL_PREG17_9 = dr.GetString(51);
                    preguntas.SL_PREG17_10 = dr.GetString(52);
                    preguntas.SL_PREG17_11 = dr.GetString(53);
                    preguntas.SL_PREG18_1 = dr.GetString(54);
                    preguntas.SL_PREG18_2 = dr.GetString(55);
                    preguntas.SL_PREG18_3 = dr.GetString(56);
                    preguntas.SL_PREG18_4 = dr.GetString(57);
                    preguntas.SL_PREG18_5 = dr.GetString(58);
                    preguntas.SL_PREG18_6 = dr.GetString(59);
                    preguntas.SL_PREG18_7 = dr.GetString(60);
                    preguntas.SL_PREG18_8 = dr.GetString(61);
                    preguntas.SL_PREG18_9 = dr.GetString(62);
                    preguntas.SL_PREG18_10 = dr.GetString(63);
                    preguntas.SL_PREG18_11 = dr.GetString(64);
                    preguntas.SL_PREG19_1 = dr.GetString(65);
                    preguntas.SL_PREG19_2 = dr.GetString(66);
                    preguntas.SL_PREG19_3 = dr.GetString(67);
                    preguntas.SL_PREG19_4 = dr.GetString(68);
                    preguntas.SL_PREG19_5 = dr.GetString(69);
                    preguntas.SL_PREG19_6 = dr.GetString(70);
                    preguntas.SL_PREG19_7 = dr.GetString(71);
                    preguntas.SL_PREG19_8 = dr.GetString(72);
                    preguntas.SL_PREG19_9 = dr.GetString(73);
                    preguntas.SL_PREG19_10 = dr.GetString(74);
                    preguntas.SL_PREG20_1 = dr.GetString(75);
                    preguntas.SL_PREG20_2 = dr.GetString(76);
                    preguntas.SL_PREG20_3 = dr.GetString(77);
                    preguntas.SL_PREG20_4 = dr.GetString(78);
                    preguntas.SL_PREG20_5 = dr.GetString(79);
                    preguntas.SL_PREG20_6 = dr.GetString(80);
                    preguntas.SL_PREG20_7 = dr.GetString(81);
                    preguntas.SL_PREG20_8 = dr.GetString(82);
                    preguntas.SL_PREG20_9 = dr.GetString(83);
                    preguntas.SL_PREG20_10 = dr.GetString(84);
                    preguntas.SL_PREG20_11 = dr.GetString(85);
                    preguntas.SL_PREG20_12 = dr.GetString(86);
                    preguntas.SL_PREG20_13 = dr.GetString(87);
                    preguntas.SL_PREG21 = dr.GetString(88);
                    preguntas.SL_PREG22 = dr.GetString(89);
                    preguntas.Areas = dr.GetString(90);
                    preguntas.AñoInico = dr.GetString(91);
                    preguntas.AñoFin = dr.GetString(92);
                    lista.Add(preguntas);
                    preguntas = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<Preguntas> ObtenerPreguntas(string Matricula)
        {
            List<Preguntas> lista = new List<Preguntas>();
            try
            {
                string sql = "SP_ObtenerPreguntas @ip_matricula = "+Matricula;
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Preguntas preguntas;
                while (dr.Read())
                {
                    preguntas = new Preguntas();
                    preguntas.IdPregunta = dr.GetInt32(0);
                    preguntas.IP_Nombres = dr.GetString(1);
                    preguntas.IP_ApellidoPaterno = dr.GetString(2);
                    preguntas.IP_ApellidoMaterno = dr.GetString(3);
                    preguntas.IP_Matricula = dr.GetString(4);
                    preguntas.IP_CorreoElectronicoPersonal = dr.GetString(5);
                    preguntas.IP_NumeroTelefono = dr.GetString(6);
                    preguntas.DG_EstadoCivil = dr.GetInt32(7);
                    preguntas.DG_UltimoNivelEscolar = dr.GetInt32(8);
                    preguntas.DG_InstitucionEstudiasActualmente = dr.GetInt32(9);
                    preguntas.SL_PREG1 = dr.GetInt32(10);
                    preguntas.SL_PREG2 = dr.GetString(11);
                    preguntas.SL_PREG3 = dr.GetInt32(12);
                    preguntas.SL_PREG4 = dr.GetInt32(13);
                    preguntas.SL_PREG5_1 = dr.GetInt32(14);
                    preguntas.SL_PREG5_2 = dr.GetInt32(15);
                    preguntas.SL_PREG5_3 = dr.GetInt32(16);
                    preguntas.SL_PREG5_4 = dr.GetInt32(17);
                    preguntas.SL_PREG5_5 = dr.GetInt32(18);
                    preguntas.SL_PREG6_1_NombreEmpresa = dr.GetString(19);
                    preguntas.SL_PREG6_2_Municipio = dr.GetString(20);
                    preguntas.SL_PREG6_3_Estado = dr.GetString(21);
                    preguntas.SL_PREG7 = dr.GetInt32(22);
                    preguntas.SL_PREG8 = dr.GetInt32(23);
                    preguntas.SL_PREG9 = dr.GetInt32(24);
                    preguntas.SL_PREG10 = dr.GetInt32(25);
                    preguntas.SL_PREG11 = dr.GetInt32(26);
                    preguntas.SL_PREG12 = dr.GetInt32(27);
                    preguntas.SL_PREG13 = dr.GetInt32(28);
                    preguntas.SL_PREG14_1 = dr.GetInt32(29);
                    preguntas.SL_PREG14_2 = dr.GetInt32(30);
                    preguntas.SL_PREG14_3 = dr.GetInt32(31);
                    preguntas.SL_PREG14_4 = dr.GetInt32(32);
                    preguntas.SL_PREG14_5 = dr.GetInt32(33);
                    preguntas.SL_PREG14_6 = dr.GetInt32(34);
                    preguntas.SL_PREG14_7 = dr.GetInt32(35);
                    preguntas.SL_PREG14_8 = dr.GetInt32(36);
                    preguntas.SL_PREG14_9 = dr.GetInt32(37);
                    preguntas.SL_PREG14_10 = dr.GetInt32(38);
                    preguntas.SL_PREG14_11 = dr.GetInt32(39);
                    preguntas.SL_PREG14_12 = dr.GetInt32(40);
                    preguntas.SL_PREG15 = dr.GetInt32(41);
                    preguntas.SL_PREG16 = dr.GetInt32(42);
                    preguntas.SL_PREG17_1 = dr.GetInt32(43);
                    preguntas.SL_PREG17_2 = dr.GetInt32(44);
                    preguntas.SL_PREG17_3 = dr.GetInt32(45);
                    preguntas.SL_PREG17_4 = dr.GetInt32(46);
                    preguntas.SL_PREG17_5 = dr.GetInt32(47);
                    preguntas.SL_PREG17_6 = dr.GetInt32(48);
                    preguntas.SL_PREG17_7 = dr.GetInt32(49);
                    preguntas.SL_PREG17_8 = dr.GetInt32(50);
                    preguntas.SL_PREG17_9 = dr.GetInt32(51);
                    preguntas.SL_PREG17_10 = dr.GetInt32(52);
                    preguntas.SL_PREG17_11 = dr.GetInt32(53);
                    preguntas.SL_PREG18_1 = dr.GetInt32(54);
                    preguntas.SL_PREG18_2 = dr.GetInt32(55);
                    preguntas.SL_PREG18_3 = dr.GetInt32(56);
                    preguntas.SL_PREG18_4 = dr.GetInt32(57);
                    preguntas.SL_PREG18_5 = dr.GetInt32(58);
                    preguntas.SL_PREG18_6 = dr.GetInt32(59);
                    preguntas.SL_PREG18_7 = dr.GetInt32(60);
                    preguntas.SL_PREG18_8 = dr.GetInt32(61);
                    preguntas.SL_PREG18_9 = dr.GetInt32(62);
                    preguntas.SL_PREG18_10 = dr.GetInt32(63);
                    preguntas.SL_PREG18_11 = dr.GetInt32(64);
                    preguntas.SL_PREG19_1 = dr.GetInt32(65);
                    preguntas.SL_PREG19_2 = dr.GetInt32(66);
                    preguntas.SL_PREG19_3 = dr.GetInt32(67);
                    preguntas.SL_PREG19_4 = dr.GetInt32(68);
                    preguntas.SL_PREG19_5 = dr.GetInt32(69);
                    preguntas.SL_PREG19_6 = dr.GetInt32(70);
                    preguntas.SL_PREG19_7 = dr.GetInt32(71);
                    preguntas.SL_PREG19_8 = dr.GetInt32(72);
                    preguntas.SL_PREG19_9 = dr.GetInt32(73);
                    preguntas.SL_PREG19_10 = dr.GetInt32(74);
                    preguntas.SL_PREG20_1 = dr.GetInt32(75);
                    preguntas.SL_PREG20_2 = dr.GetInt32(76);
                    preguntas.SL_PREG20_3 = dr.GetInt32(77);
                    preguntas.SL_PREG20_4 = dr.GetInt32(78);
                    preguntas.SL_PREG20_5 = dr.GetInt32(79);
                    preguntas.SL_PREG20_6 = dr.GetInt32(80);
                    preguntas.SL_PREG20_7 = dr.GetInt32(81);
                    preguntas.SL_PREG20_8 = dr.GetInt32(82);
                    preguntas.SL_PREG20_9 = dr.GetInt32(83);
                    preguntas.SL_PREG20_10 = dr.GetInt32(84);
                    preguntas.SL_PREG20_11 = dr.GetInt32(85);
                    preguntas.SL_PREG20_12 = dr.GetInt32(86);
                    preguntas.SL_PREG20_13 = dr.GetInt32(87);
                    preguntas.SL_PREG21 = dr.GetInt32(88);
                    preguntas.SL_PREG22 = dr.GetInt32(89);
                    lista.Add(preguntas);
                    preguntas = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return lista;
        }


        // SELECTS RESPUESTAS ESTABLECIDAS
        public List<PreguntasEstablecidas> Obtener_PREG_SL_17_18_19_20()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_17_18_19_20';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_DG_1()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_DG_1';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_DG_2()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_DG_2';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_DG_3()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_DG_3';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_1()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_1';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SINO_SL3_SL14_SL22()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SINO_SL3_SL14_SL22';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_4()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_4';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_5()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_5';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_7()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_7';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_8()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_8';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_9()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_9';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_10()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_10';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_11()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_11';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_12()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_12';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_13()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_13';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_15()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_15';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_16()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_16';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_17()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_17';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<PreguntasEstablecidas> Obtener_PREG_SL_20()
        {
            List<PreguntasEstablecidas> lista = new List<PreguntasEstablecidas>();
            try
            {
                string sql = "SELECT * FROM PREGUNTAS_ESTABLECIDAS WHERE  TipoPregunta = 'PREG_SL_20';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PreguntasEstablecidas rp;
                while (dr.Read())
                {
                    rp = new PreguntasEstablecidas();
                    rp.IdPreguntaEstablecida = dr.GetInt32(0);
                    rp.Pregunta = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<PreguntasEstablecidas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<Año> Obtener_AñoInicio ()
        {
            List <Año> lista = new List<Año>();
            try
            {
                string sql = "SELECT * FROM AÑO WHERE Estado = 'Inicio';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Año rp;
                while (dr.Read())
                {
                    rp = new Año();
                    rp.IdAño = dr.GetInt32(0);
                    rp.Años = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<Año>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<Año> Obtener_AñoFin()
        {
            List<Año> lista = new List<Año>();
            try
            {
                string sql = "SELECT * FROM AÑO WHERE Estado = 'Fin';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Año rp;
                while (dr.Read())
                {
                    rp = new Año();
                    rp.IdAño = dr.GetInt32(0);
                    rp.Años = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<Año>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<Area> Obtener_Area()
        {
            List<Area> lista = new List<Area>();
            try
            {
                string sql = "SELECT * FROM AREA;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Area rp;
                while (dr.Read())
                {
                    rp = new Area();
                    rp.IdArea = dr.GetInt32(0);
                    rp.NombreArea = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<Area>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }
        public List<Perfiles> ObtenerPerfil()
        {
            List<Perfiles> lista = new List<Perfiles>();
            try
            {
                string sql = "SELECT * FROM PERFIL WHERE IdPerfil = 2;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Perfiles rp;
                while (dr.Read())
                {
                    rp = new Perfiles();
                    rp.IdPerfil = dr.GetInt32(0);
                    rp.Perfil= dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<Perfiles>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public int SetUsuarios(Usuarios usuarios, int opcion)
        {
            int res = 0;
            try
            {
                string sql = "SP_SetUsuarios";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", usuarios.IdUsuario);
                cmd.Parameters.AddWithValue("@nombre", usuarios.Nombres);
                cmd.Parameters.AddWithValue("@apellidopaterno", usuarios.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@apellidomaterno", usuarios.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@matricula", usuarios.Matricula);
                cmd.Parameters.AddWithValue("@correoelectronico", usuarios.CorreoElectronico);
                cmd.Parameters.AddWithValue("@contraseña", usuarios.Contraseña);
                cmd.Parameters.AddWithValue("@idperfil", usuarios.IdPerfil);
                cmd.Parameters.AddWithValue("@op", opcion);
                conn.Open();
                cmd.ExecuteNonQuery();
                res = 1;
            }
            catch (Exception ex)
            {
                res = 0;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        public List<Usuarios> ObtenerUsuarios()
        {
            List<Usuarios> lista = new List<Usuarios>();
            try
            {

                SqlCommand cmd = new SqlCommand("SP_ObtenerUsuarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Usuarios usuario;
                while (dr.Read())
                {
                    usuario = new Usuarios();
                    usuario.IdUsuario = dr.GetInt32(0);
                    usuario.Nombres = dr.GetString(1);
                    usuario.ApellidoPaterno = dr.GetString(2);
                    usuario.ApellidoMaterno = dr.GetString(3);
                    usuario.Matricula = dr.GetString(4);
                    usuario.CorreoElectronico = dr.GetString(5);
                    usuario.Contraseña = dr.GetString(6);
                    usuario.IdPerfil = dr.GetInt32(7);
                    lista.Add(usuario);
                    usuario = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<Usuarios>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<Usuarios> ObtenerUsuarios2()
        {
            List<Usuarios> lista = new List<Usuarios>();
            try
            {
                string correo = (string)System.Web.HttpContext.Current.Session["Matricula"];
                SqlCommand cmd = new SqlCommand("ObtenerUsuarios2", conn);
                cmd.Parameters.AddWithValue("@idusuario", correo);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Usuarios usuario;
                while (dr.Read())
                {
                    usuario = new Usuarios();
                    usuario.IdUsuario = dr.GetInt32(0);
                    usuario.Nombres = dr.GetString(1);
                    usuario.ApellidoPaterno = dr.GetString(2);
                    usuario.ApellidoMaterno = dr.GetString(3);
                    usuario.Matricula = dr.GetString(4);
                    usuario.CorreoElectronico = dr.GetString(5);
                    usuario.Contraseña = dr.GetString(6);
                    usuario.IdPerfil = dr.GetInt32(7);
                    lista.Add(usuario);
                    usuario = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<Usuarios>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<Preguntas> Obtener_PreguntasUsuario(string matricula)
        {
            List<Preguntas> lista = new List<Preguntas>();
            try
            {
                string sql = "ObtenerPreguntasUsuario";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@matricula", matricula);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Preguntas usuario;
                while (dr.Read())
                {
                    usuario = new Preguntas();
                    usuario.IdPregunta = dr.GetInt32(0);
                    usuario.IP_Nombres = dr.GetString(1);
                    usuario.IP_ApellidoPaterno = dr.GetString(2);
                    usuario.IP_ApellidoMaterno = dr.GetString(3);
                    usuario.IP_Matricula = dr.GetString(4);
                    usuario.IP_CorreoElectronicoPersonal = dr.GetString(5);
                    usuario.IP_NumeroTelefono = dr.GetString(6);
                    usuario.DG_EstadoCivil = dr.GetInt32(7);
                    usuario.DG_UltimoNivelEscolar = dr.GetInt32(8);
                    usuario.DG_InstitucionEstudiasActualmente = dr.GetInt32(9);
                    usuario.SL_PREG1 = dr.GetInt32(10);
                    usuario.SL_PREG2 = dr.GetString(11);
                    usuario.SL_PREG3 = dr.GetInt32(12);
                    usuario.SL_PREG4 = dr.GetInt32(13);
                    usuario.SL_PREG5_1 = dr.GetInt32(14);
                    usuario.SL_PREG5_2 = dr.GetInt32(15);
                    usuario.SL_PREG5_3 = dr.GetInt32(16);
                    usuario.SL_PREG5_4 = dr.GetInt32(17);
                    usuario.SL_PREG5_5 = dr.GetInt32(18);
                    usuario.SL_PREG6_1_NombreEmpresa = dr.GetString(19);
                    usuario.SL_PREG6_2_Municipio = dr.GetString(20);
                    usuario.SL_PREG6_3_Estado = dr.GetString(21);
                    usuario.SL_PREG7 = dr.GetInt32(22);
                    usuario.SL_PREG8 = dr.GetInt32(23);
                    usuario.SL_PREG9 = dr.GetInt32(24);
                    usuario.SL_PREG10 = dr.GetInt32(25);
                    usuario.SL_PREG11 = dr.GetInt32(26);
                    usuario.SL_PREG12 = dr.GetInt32(27);
                    usuario.SL_PREG13 = dr.GetInt32(28);
                    usuario.SL_PREG14_1 = dr.GetInt32(29);
                    usuario.SL_PREG14_2 = dr.GetInt32(30);
                    usuario.SL_PREG14_3 = dr.GetInt32(31);
                    usuario.SL_PREG14_4 = dr.GetInt32(32);
                    usuario.SL_PREG14_5 = dr.GetInt32(33);
                    usuario.SL_PREG14_6 = dr.GetInt32(34);
                    usuario.SL_PREG14_7 = dr.GetInt32(35);
                    usuario.SL_PREG14_8 = dr.GetInt32(36);
                    usuario.SL_PREG14_9 = dr.GetInt32(37);
                    usuario.SL_PREG14_10 = dr.GetInt32(38);
                    usuario.SL_PREG14_11 = dr.GetInt32(39);
                    usuario.SL_PREG14_12 = dr.GetInt32(40);
                    usuario.SL_PREG15 = dr.GetInt32(41);
                    usuario.SL_PREG16 = dr.GetInt32(42);
                    usuario.SL_PREG17_1 = dr.GetInt32(43);
                    usuario.SL_PREG17_2 = dr.GetInt32(44);
                    usuario.SL_PREG17_3 = dr.GetInt32(45);
                    usuario.SL_PREG17_4 = dr.GetInt32(46);
                    usuario.SL_PREG17_5 = dr.GetInt32(47);
                    usuario.SL_PREG17_6 = dr.GetInt32(48);
                    usuario.SL_PREG17_7 = dr.GetInt32(49);
                    usuario.SL_PREG17_8 = dr.GetInt32(50);
                    usuario.SL_PREG17_9 = dr.GetInt32(51);
                    usuario.SL_PREG17_10 = dr.GetInt32(52);
                    usuario.SL_PREG17_11 = dr.GetInt32(53);
                    usuario.SL_PREG18_1 = dr.GetInt32(54);
                    usuario.SL_PREG18_2 = dr.GetInt32(55);
                    usuario.SL_PREG18_3 = dr.GetInt32(56);
                    usuario.SL_PREG18_4 = dr.GetInt32(57);
                    usuario.SL_PREG18_5 = dr.GetInt32(58);
                    usuario.SL_PREG18_6 = dr.GetInt32(59);
                    usuario.SL_PREG18_7 = dr.GetInt32(60);
                    usuario.SL_PREG18_8 = dr.GetInt32(61);
                    usuario.SL_PREG18_9 = dr.GetInt32(62);
                    usuario.SL_PREG18_10 = dr.GetInt32(63);
                    usuario.SL_PREG18_11 = dr.GetInt32(64);
                    usuario.SL_PREG19_1 = dr.GetInt32(65);
                    usuario.SL_PREG19_2 = dr.GetInt32(66);
                    usuario.SL_PREG19_3 = dr.GetInt32(67);
                    usuario.SL_PREG19_4 = dr.GetInt32(68);
                    usuario.SL_PREG19_5 = dr.GetInt32(69);
                    usuario.SL_PREG19_6 = dr.GetInt32(70);
                    usuario.SL_PREG19_7 = dr.GetInt32(71);
                    usuario.SL_PREG19_8 = dr.GetInt32(72);
                    usuario.SL_PREG19_9 = dr.GetInt32(73);
                    usuario.SL_PREG19_10 = dr.GetInt32(74);
                    usuario.SL_PREG20_1 = dr.GetInt32(75);
                    usuario.SL_PREG20_2 = dr.GetInt32(76);
                    usuario.SL_PREG20_3 = dr.GetInt32(77);
                    usuario.SL_PREG20_4 = dr.GetInt32(78);
                    usuario.SL_PREG20_5 = dr.GetInt32(79);
                    usuario.SL_PREG20_6 = dr.GetInt32(80);
                    usuario.SL_PREG20_7 = dr.GetInt32(81);
                    usuario.SL_PREG20_8 = dr.GetInt32(82);
                    usuario.SL_PREG20_9 = dr.GetInt32(83);
                    usuario.SL_PREG20_10 = dr.GetInt32(84);
                    usuario.SL_PREG20_11 = dr.GetInt32(85);
                    usuario.SL_PREG20_12 = dr.GetInt32(86);
                    usuario.SL_PREG20_13 = dr.GetInt32(87);
                    usuario.SL_PREG21 = dr.GetInt32(88);
                    usuario.SL_PREG22 = dr.GetInt32(89);
                    lista.Add(usuario);
                    usuario = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<Preguntas>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public List<Area> ObtenerAreas()
        {
            List<Area> lista = new List<Area>();
            try
            {
                string sql = "SELECT * FROM AREA;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Area rp;
                while (dr.Read())
                {
                    rp = new Area();
                    rp.IdArea = dr.GetInt32(0);
                    rp.NombreArea = dr.GetString(1);
                    lista.Add(rp);
                    rp = null;
                }
            }
            catch (Exception ex)
            {
                lista = new List<Area>();
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }


    }
}