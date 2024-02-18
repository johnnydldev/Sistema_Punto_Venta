using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CompraDAO
    {
        public List<Compra> listar()
        {
            List<Compra> lista = new List<Compra>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string consulta = "select idUsuario, documento, apodo, nombre, correo, contraseña, estado from Usuario";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select idCompra, tipoDocumento, numeroDocumento, montoTotal, convert(char(10), fechaRegistro, 103)[fechaRegistro] from Compra order by idCompra desc;");
                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Compra()
                            {
                                idCompra = Convert.ToInt32(reader["idCompra"]),
                                tipoDocumento = reader["tipoDocumento"].ToString(),
                                numDocumento = reader["numeroDocumento"].ToString(),
                                montoTotal = Convert.ToDecimal(reader["montoTotal"].ToString()),
                                fechaRegistro = reader["fechaRegistro"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Compra>();
                }
            }
            return lista;
        }//Termina metodoo listar Compra
        public int obtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string consulta = "select idUsuario, documento, apodo, nombre, correo, contraseña, estado from Usuario";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select count(*) + 1 from Compra");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());


                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;
                }
            }



            return idCorrelativo;
        }//termina metodo

        public bool registrarCompra(Compra obj, DataTable dtCompra, out string mensaje)
        {
            bool respuestaGenerado = false;
            mensaje = string.Empty;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {

                try
                {


                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", objConexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.objUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("idProveedor", obj.objProveedor.idProveedor);
                    cmd.Parameters.AddWithValue("tipoDocumento", obj.tipoDocumento);
                    cmd.Parameters.AddWithValue("numeroDocumento", obj.numDocumento);
                    cmd.Parameters.AddWithValue("montoTotal", obj.montoTotal);
                    cmd.Parameters.AddWithValue("detalleCompra", dtCompra);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    cmd.ExecuteNonQuery();


                    respuestaGenerado = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();


                }
                catch (Exception ex)
                {
                    respuestaGenerado = false;
                    mensaje = ex.Message;
                }
            }
            return respuestaGenerado;
        }//Termina registrar compra

        public Compra obtenerCompra(string numero)
        {
            Compra objCompra = new Compra();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {

                try
                {


                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select c.idCompra, u.nombre,pv.documento, pv.razonSocial, c.tipoDocumento,c.numeroDocumento, c.montoTotal,convert(char(10), c.fechaRegistro, 103)[fechaRegistro] from Compra c");
                    sb.AppendLine("inner join Usuario u on u.idUsuario = c.idUsuario inner join Proveedor pv on pv.idProveedor = c.idProveedor  where c.numeroDocumento = @numero");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objCompra = new Compra()
                            {
                                idCompra = Convert.ToInt32(reader["idCompra"]),
                                objUsuario = new Usuario() { nombre = reader["nombre"].ToString() },
                                objProveedor = new Proveedor() { documento = reader["documento"].ToString(), razonSocial = reader["razonSocial"].ToString() },
                                tipoDocumento = reader["tipoDocumento"].ToString(),
                                numDocumento = reader["numeroDocumento"].ToString(),
                                montoTotal = Convert.ToDecimal(reader["montoTotal"].ToString()),
                                fechaRegistro = reader["fechaRegistro"].ToString(),

                            };
                        }
                    }


                }
                catch (Exception ex)
                {
                    objCompra = new Compra();
                }
            }
                return objCompra;

        }//Termina Obtener Compra


        public List<Detalle_Compra> obtenerDTCompra(int idCompra)
        {
            List<Detalle_Compra> lista = new List<Detalle_Compra>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    objConexion.Open();

                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("select p.nombre, dc.precioCompra,dc.cantidad, dc.montoTotal from Detalle_Compra dc");
                    sb.AppendLine("inner join Producto p on p.idProducto = dc.idProducto where dc.idCompra = @idCompra");
                    
                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);
                    cmd.CommandType = CommandType.Text;

                   
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Detalle_Compra()
                            {
                                objProducto = new Producto() { nombre = reader["nombre"].ToString() },
                                precioCompra = Convert.ToDecimal(reader["precioCompra"].ToString()),
                                cantidad = Convert.ToInt32(reader["cantidad"].ToString()),
                                subTotal = Convert.ToDecimal(reader["montoTotal"].ToString()),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Detalle_Compra>();
                }
            }
            return lista;
        }//Termina método listar detalle





    }//Termina clase
}
