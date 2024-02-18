using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class NegocioDAO
    {

        public Negocio obtenerDatos()
        {
            Negocio obj = new Negocio();

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena)) {
                    conn.Open();

                    string consulta = "select idNegocio, nombre, rfc, direccion from Negocio where idNegocio = 1";
                    SqlCommand cmd = new SqlCommand(consulta, conn);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            obj = new Negocio()
                            {
                                idNegocio = Convert.ToInt32(lector["idNegocio"].ToString()),
                                nombre = lector["nombre"].ToString(),
                                rfc = lector["rfc"].ToString(),
                                direccion = lector["direccion"].ToString(),
                            };
                        }
                    }

                }
            }
            catch (Exception ex) { 
                obj = new Negocio();
            }

            return obj;

        }//Termina método obtener datos


        public bool guardarDatos(Negocio obj, out string mensaje)
        {

            mensaje = string.Empty;
            bool resultado = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    conn.Open();

                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("update Negocio set nombre = @nombre, rfc = @rfc, direccion = @direccion where idNegocio = 1");

                    SqlCommand cmd = new SqlCommand(consulta.ToString(), conn);
                    cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("@rfc", obj.rfc);
                    cmd.Parameters.AddWithValue("@direccion", obj.direccion);
                    cmd.CommandType = System.Data.CommandType.Text;


                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "Información no actualizada";
                        resultado = false;
                    }


                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                resultado = false;
            }

            return resultado;
        }//termina método guardar


        public byte[] cargarLogo(out bool resultado)
        {
            resultado = true;

            byte[] logo = new byte[0];

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    conn.Open();

                    string consulta = "select logo from Negocio where idNegocio = 1";

                    SqlCommand cmd = new SqlCommand(consulta, conn);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            logo = (byte[]) lector["logo"];
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                resultado = false;
                logo = new byte[0];
            }

            return logo;

        }//termina método cargar logo

        public bool actualizarLogo(byte[] imagen, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    conn.Open();

                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("update Negocio set logo = @imagen where idNegocio = 1");

                    SqlCommand cmd = new SqlCommand(consulta.ToString(), conn);
                    cmd.Parameters.AddWithValue("@imagen", imagen);
                    cmd.CommandType = System.Data.CommandType.Text;


                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "Logo no actualizado, ha ocurrido un error.";
                        resultado = false;
                    }


                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = ex.Message;
            }

            return resultado;

        }//termina método cargar logo

    }//Termina clase
}
