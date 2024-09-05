using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Collections;


namespace CapaDatos
{
    public class UsuarioDAO
    {
        SqlConnection objConexion = new SqlConnection(Conexion.cadena);
        public Usuario searchUser(string nickname, string password)
        {
            Usuario user = new Usuario();

            using (objConexion)
            {
                try
                {
                   
                    SqlCommand cmd = new SqlCommand("sp_searchUser", objConexion);
                    cmd.Parameters.AddWithValue("nickname", nickname);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new Usuario()
                            {
                                idUsuario = Convert.ToInt32(reader["idUsuario"]),
                                documento = reader["documento"].ToString(),
                                apodo = reader["apodo"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                correo = reader["correo"].ToString(),
                                clave = reader["contraseña"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"]),
                                objRol = new Rol() { idRol = Convert.ToInt32(reader["idRol"]), descripcion = reader["descripcion"].ToString() }
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    user = new Usuario();
                }
            }
            return user;
        }//Termina metodo buscar Usuario Login

        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (objConexion)
            {
                try
                {
                    //string consulta = "select idUsuario, documento, apodo, nombre, correo, contraseña, estado from Usuario";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select u.idUsuario, u.documento, u.apodo, u.nombre, u.correo, u.contraseña, u.estado, r.idRol, r.descripcion from Usuario u");
                    sb.AppendLine("inner join Rol r on r.idRol = u.idRol");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(reader["idUsuario"]),
                                documento = reader["documento"].ToString(),
                                apodo = reader["apodo"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                correo = reader["correo"].ToString(),
                                clave = reader["contraseña"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"]),
                                objRol = new Rol() { idRol = Convert.ToInt32(reader["idRol"]), descripcion = reader["descripcion"].ToString() }

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }//Termina metodo listar Usuarios

        public int obtenerIdMax()
        {
            int id = 0;

            using (objConexion)
            {
                try
                {
                    string consulta = "select  max(idUsuario) as IdResultado from Usuario";

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
                    string msg = ex.Message;
                    id = 0;

                }
            }

            id++;

            return id;
        }//Termina metodo obtenerId


        public int registrar(Usuario obj, out string mensaje)
        {

            int usuarioGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (objConexion)
                {



                    SqlCommand cmd = new SqlCommand("sp_registrarUsuario", objConexion);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("apodo", obj.apodo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("clave", obj.clave);
                    cmd.Parameters.AddWithValue("idRol", obj.objRol.idRol);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();
                    cmd.ExecuteNonQuery();

                    usuarioGenerado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
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


        public bool editar(Usuario obj, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (objConexion)
                {



                    SqlCommand cmd = new SqlCommand("sp_EditarUsuario", objConexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.idUsuario);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("apodo", obj.apodo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("clave", obj.clave);
                    cmd.Parameters.AddWithValue("idRol", obj.objRol.idRol);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();


                }



            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
                throw;
            }

            return respuesta;
        }//Termina metodo Editar

        public bool eliminar(Usuario obj, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (objConexion)
                {



                    SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", objConexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.idUsuario);
                    cmd.Parameters.Add("idRespuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["idRespuesta"].Value);
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


    }//Termina Clase
}
