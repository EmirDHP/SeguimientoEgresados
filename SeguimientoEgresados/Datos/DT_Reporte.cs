using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;

using SeguimientoEgresados.Models;

namespace SeguimientoEgresados.Datos
{
    public class DT_Reporte
    {

        public List<Reporte> Reporte_TrabajasActualmente(string area)
        {
            List<Reporte> objLista = new List<Reporte>();

            //using (SqlConnection oconexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog = SEGUIMIENTO_EGRESADOS; Integrated Security = True;"))
            //using (SqlConnection oconexion = new SqlConnection("Data Source=DESKTOP-VR4M00D;Initial Catalog=SEGUIMIENTO_EGRESADOS;Integrated Security=True;"))
            using (SqlConnection oconexion = new SqlConnection("Data Source=201.174.6.168;Initial Catalog=SEGUIMIENTO_EGRESADOS;User ID=sa;Password=TicUtt2017;"))
            {
                string query = "SP_Reporte_TrabajasActualmente";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.Parameters.AddWithValue("area", area);
                cmd.CommandType = CommandType.StoredProcedure;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new Reporte()
                        {
                            pregunta = dr["pregunta"].ToString(),
                            cantidad = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }
            }
            return objLista;
        }


        public List<Reporte> Reporte_IngresoMensual(string area)
        {
            List<Reporte> objLista = new List<Reporte>();

            //using (SqlConnection oconexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog = SEGUIMIENTO_EGRESADOS; Integrated Security = True;"))
            //using (SqlConnection oconexion = new SqlConnection("Data Source=DESKTOP-VR4M00D;Initial Catalog=SEGUIMIENTO_EGRESADOS;Integrated Security=True;"))
            using (SqlConnection oconexion = new SqlConnection("Data Source=201.174.6.168;Initial Catalog=SEGUIMIENTO_EGRESADOS;User ID=sa;Password=TicUtt2017;"))
            {
                string query = "SP_Reporte_IngresoMensual";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.Parameters.AddWithValue("area", area);
                cmd.CommandType = CommandType.StoredProcedure;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new Reporte()
                        {
                            pregunta = dr["pregunta"].ToString(),
                            cantidad = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }
            }
            return objLista;
        }


        public List<Reporte> Reporte_MedioObtuvoTrabajo(string area)
        {
            List<Reporte> objLista = new List<Reporte>();

            //using (SqlConnection oconexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog = SEGUIMIENTO_EGRESADOS; Integrated Security = True;"))
            //using (SqlConnection oconexion = new SqlConnection("Data Source=DESKTOP-VR4M00D;Initial Catalog=SEGUIMIENTO_EGRESADOS;Integrated Security=True;"))
            using (SqlConnection oconexion = new SqlConnection("Data Source=201.174.6.168;Initial Catalog=SEGUIMIENTO_EGRESADOS;User ID=sa;Password=TicUtt2017;"))

            {
                string query = "SP_Reporte_MedioObtuvoTrabajo";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.Parameters.AddWithValue("area", area);
                cmd.CommandType = CommandType.StoredProcedure;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new Reporte()
                        {
                            pregunta = dr["pregunta"].ToString(),
                            cantidad = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }
            }
            return objLista;
        }


        public List<Reporte> Reporte_RamaEmpresa(string area)
        {
            List<Reporte> objLista = new List<Reporte>();

            //using (SqlConnection oconexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog = SEGUIMIENTO_EGRESADOS; Integrated Security = True;"))
            //using (SqlConnection oconexion = new SqlConnection("Data Source=DESKTOP-VR4M00D;Initial Catalog=SEGUIMIENTO_EGRESADOS;Integrated Security=True;"))
            using (SqlConnection oconexion = new SqlConnection("Data Source=201.174.6.168;Initial Catalog=SEGUIMIENTO_EGRESADOS;User ID=sa;Password=TicUtt2017;"))
            {
                string query = "SP_Reporte_RamaEmpresa";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.Parameters.AddWithValue("area", area);
                cmd.CommandType = CommandType.StoredProcedure;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new Reporte()
                        {
                            pregunta = dr["pregunta"].ToString(),
                            cantidad = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }
            }
            return objLista;
        }

        public List<Reporte> Reporte_ExpectativasFormacion(string area)
        {
            List<Reporte> objLista = new List<Reporte>();

            //using (SqlConnection oconexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog = SEGUIMIENTO_EGRESADOS; Integrated Security = True;"))
            //using (SqlConnection oconexion = new SqlConnection("Data Source=DESKTOP-VR4M00D;Initial Catalog=SEGUIMIENTO_EGRESADOS;Integrated Security=True;"))
            using (SqlConnection oconexion = new SqlConnection("Data Source=201.174.6.168;Initial Catalog=SEGUIMIENTO_EGRESADOS;User ID=sa;Password=TicUtt2017;"))
            {
                string query = "SP_Reporte_ExpectativasFormacion";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.Parameters.AddWithValue("area", area);
                cmd.CommandType = CommandType.StoredProcedure;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new Reporte()
                        {
                            pregunta = dr["pregunta"].ToString(),
                            cantidad = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }
            }
            return objLista;
        }


        public List<Reporte> Reporte_RecomiendasUTTN(string area)
        {
            List<Reporte> objLista = new List<Reporte>();

            //using (SqlConnection oconexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog = SEGUIMIENTO_EGRESADOS; Integrated Security = True;"))
            //using (SqlConnection oconexion = new SqlConnection("Data Source=DESKTOP-VR4M00D;Initial Catalog=SEGUIMIENTO_EGRESADOS;Integrated Security=True;"))
            using (SqlConnection oconexion = new SqlConnection("Data Source=201.174.6.168;Initial Catalog=SEGUIMIENTO_EGRESADOS;User ID=sa;Password=TicUtt2017;"))

            {
                string query = "SP_Reporte_RecomiendasUTTN";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.Parameters.AddWithValue("area", area);
                cmd.CommandType = CommandType.StoredProcedure;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new Reporte()
                        {
                            pregunta = dr["pregunta"].ToString(),
                            cantidad = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }
            }
            return objLista;
        }

    }
}