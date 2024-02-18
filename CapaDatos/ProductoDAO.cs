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
    public class ProductoDAO
    {

        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string consulta = "select idUsuario, documento, apodo, nombre, correo, contraseña, estado from Usuario";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select p.idProducto,p.nombre, c.idCategoria, c.descripcion[descripcionCategoria], p.codigo, p.descripcion, p.stock, p.precioCompra, p.precioVenta, p.estado from Producto p");
                    sb.AppendLine("inner join Categoria c on c.idCategoria = p.idCategoria ");
                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto()
                            {
                                idProducto = Convert.ToInt32(reader["idProducto"]),
                                nombre = reader["nombre"].ToString(),
                                objCategoria = new Categoria() {idCategoria = Convert.ToInt32(reader["idCategoria"]), descripcion = reader["descripcionCategoria"].ToString() },
                                descripcion = reader["descripcion"].ToString(),
                                codigo = reader["codigo"].ToString(),
                                stock = Convert.ToInt32( reader["stock"].ToString()),
                                precioCompra = Convert.ToDecimal(reader["precioCompra"].ToString()),
                                precioVenta = Convert.ToDecimal(reader["precioVenta"].ToString()),
                                estado = Convert.ToBoolean(reader["estado"])

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }
            }
            return lista;
        }//Termina metodoo listar Usuarios

        public int obtenerIdMaxProduct()
        {
            int id = 0;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "select  max(idProducto) as IdResultado from Producto";

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


        public int registrar(Producto obj, out string mensaje)
        {

            int ProductoGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("sp_RegistrarProducto", objConexion);
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("idCategoria", obj.objCategoria.idCategoria);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("precioVenta", obj.precioVenta);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();
                    cmd.ExecuteNonQuery();

                    ProductoGenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();


                }



            }
            catch (Exception ex)
            {
                ProductoGenerado = 0;
                mensaje = ex.Message;

            }

            return ProductoGenerado;
        }//Termina metodo Registrar


        public bool editar(Producto obj, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("sp_EditarProducto", objConexion);
                    cmd.Parameters.AddWithValue("idProducto", obj.idProducto);
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("idCategoria", obj.objCategoria.idCategoria);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("precioVenta", obj.precioVenta);
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

        public bool eliminar(Producto obj, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_EliminarProducto", objConexion);
                    cmd.Parameters.AddWithValue("idProducto", obj.idProducto);
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
