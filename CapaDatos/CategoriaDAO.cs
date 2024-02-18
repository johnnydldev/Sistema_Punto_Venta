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
    public class CategoriaDAO
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string consulta = "select idUsuario, documento, apodo, nombre, correo, contraseña, estado from Usuario";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select idCategoria, descripcion, estado from Categoria");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                idCategoria = Convert.ToInt32(reader["idCategoria"]),
                                descripcion = reader["descripcion"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"])

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Categoria>();
                }
            }
            return lista;
        }//Termina metodoo listar Usuarios

        public int obtenerIdMaxCategoria()
        {
            int id = 0;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "select  max(idCategoria) as IdResultado from Categoria";

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


        public int registrar(Categoria obj, out string mensaje)
        {

            int categoriaGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("sp_RegistrarCategoria", objConexion);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();
                    cmd.ExecuteNonQuery();

                    categoriaGenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();


                }



            }
            catch (Exception ex)
            {
                categoriaGenerado = 0;
                mensaje = ex.Message;
               
            }

            return categoriaGenerado;
        }//Termina metodo Registrar


        public bool editar(Categoria obj, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("sp_EditarCategoria", objConexion);
                    cmd.Parameters.AddWithValue("idCategoria", obj.idCategoria);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
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

        public bool eliminar(Categoria obj, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("sp_EliminarCategoria", objConexion);
                    cmd.Parameters.AddWithValue("idCategoria", obj.idCategoria);
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
