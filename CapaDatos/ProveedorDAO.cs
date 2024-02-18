using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProveedorDAO
    {

        public List<Proveedor> listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string consulta = "select idUsuario, documento, apodo, nombre, correo, contraseña, estado from Usuario";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select idProveedor, documento, razonSocial, correo, telefono, estado from Proveedor");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Proveedor()

                            {
                                idProveedor = Convert.ToInt32(reader["idProveedor"]),
                                documento = reader["documento"].ToString(),
                                razonSocial = reader["razonSocial"].ToString(),
                                correo = reader["correo"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"])

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Proveedor>();
                }
            }

            return lista;

        }//Termina metodoo listar Proveedores

        public int obtenerIdMax()
        {
            int id = 0;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "select  max(idProveedor) as IdResultado from Proveedor";

                    SqlCommand cmd = new SqlCommand(consulta, objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["IdResultado"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    id = 0;

                }
            }

            id++;

            return id;
        }//Termina metodo obtenerId


        public int registrar(Proveedor obj, out string mensaje)
        {

            int usuarioGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("sp_RegistrarProveedor", objConexion);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("razonSocial", obj.razonSocial);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();
                    cmd.ExecuteNonQuery();

                    usuarioGenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();


                }



            }
            catch (Exception ex)
            {
                usuarioGenerado = 0;
                mensaje = ex.Message;
            }

            return usuarioGenerado;
        }//Termina metodo Registrar


        public bool editar(Proveedor obj, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("sp_EditarProveedor", objConexion);
                    cmd.Parameters.AddWithValue("idProveedor", obj.idProveedor);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("razonSocial", obj.razonSocial);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();


                }



            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }//Termina metodo Editar

        public bool eliminar(Proveedor obj, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("sp_EliminarProveedor", objConexion);
                    cmd.Parameters.AddWithValue("idProveedor", obj.idProveedor);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }



            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;

            }

            return respuesta;
        }//Termina metodo Eliminar
    }
}
