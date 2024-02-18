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
   public  class ClienteDAO
    {
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string consulta = "select idUsuario, documento, apodo, nombre, correo, contraseña, estado from Usuario";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select idCliente, documento, nombre, correo, telefono, estado from Cliente");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cliente()

                            {
                                idCliente = Convert.ToInt32(reader["idCliente"]),
                                documento = reader["documento"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                correo = reader["correo"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"])

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cliente>();
                }
            }
            return lista;
        }//Termina metodoo listar Usuarios

        public int obtenerIdMax()
        {
            int id = 0;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "select  max(idCliente) as IdResultado from Cliente";

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


        public int registrar(Cliente obj, out string mensaje)
        {

            int usuarioGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("sp_RegistrarCliente", objConexion);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
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


        public bool editar(Cliente obj, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("sp_EditarCliente", objConexion);
                    cmd.Parameters.AddWithValue("idCliente", obj.idCliente);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
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

        public bool eliminar(Cliente obj, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("delete from Cliente where idCliente = @id", objConexion);
                    cmd.Parameters.AddWithValue("@id", obj.idCliente);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;

                }



            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;

            }

            return respuesta;
        }//Termina metodo Eliminar


    }//Termina clase
}
