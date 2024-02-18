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
    public class VentaDAO
    {
        public List<Venta> listar()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string consulta = "select idUsuario, documento, apodo, nombre, correo, contraseña, estado from Usuario";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select idVenta, tipoDocumento, numeroDocumento, montoTotal, convert(char(10), fechaRegistro, 103)[fechaRegistro] from Venta order by idVenta desc;");
                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Venta()
                            {
                                idVenta = Convert.ToInt32(reader["idVenta"]),
                                tipoDocumento = reader["tipoDocumento"].ToString(),
                                numeroDocumento = reader["numeroDocumento"].ToString(),
                                montoTotal = Convert.ToDecimal(reader["montoTotal"].ToString()),
                                fechaRegistro = reader["fechaRegistro"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Venta>();
                }
            }
            return lista;
        }//Termina metodoo listar Venta
        public int obtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string consulta = "select idUsuario, documento, apodo, nombre, correo, contraseña, estado from Usuario";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select count(*) + 1 from Venta");

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

        public bool registrarVenta(Venta obj, DataTable dtVenta, out string mensaje)
        {
            bool respuestaGenerado = false;
            mensaje = string.Empty;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {

                try
                {


                    SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", objConexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.objUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("tipoDocumento", obj.tipoDocumento);
                    cmd.Parameters.AddWithValue("numeroDocumento", obj.numeroDocumento);
                    cmd.Parameters.AddWithValue("documentoCliente", obj.documentoCliente);
                    cmd.Parameters.AddWithValue("nombreCliente", obj.nombreCliente);
                    cmd.Parameters.AddWithValue("montoPago", obj.montoPago);
                    cmd.Parameters.AddWithValue("montoCambio", obj.montoCambio);
                    cmd.Parameters.AddWithValue("montoTotal", obj.montoTotal);
                    cmd.Parameters.AddWithValue("detalleVenta", dtVenta);
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

        public bool restarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {

                try
                {


                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("update Producto set stock = stock - @cantidad where idProducto = @idProducto");
                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }//termina Restar Stock

        public bool sumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {

                try
                {


                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("update Producto set stock = stock + @cantidad where idProducto = @idProducto");
                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }//termina sumar Stock

        public Venta obtenerVenta(string numero)
        {
            Venta objVenta = new Venta();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {

                try
                {


                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select v.idVenta, u.nombre,v.documentoCliente, v.nombreCliente, v.tipoDocumento, v.numeroDocumento,v.montoPago, v.montoCambio, v.montoTotal,convert(char(10), v.fechaRegistro, 103)[fechaRegistro] from Venta v");
                    sb.AppendLine("inner join Usuario u on u.idUsuario = v.idUsuario   where v.numeroDocumento = @numero");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objVenta = new Venta()
                            {
                                idVenta = Convert.ToInt32(reader["idVenta"]),
                                objUsuario = new Usuario() { nombre = reader["nombre"].ToString() },
                                documentoCliente = reader["documentoCliente"].ToString(),
                                nombreCliente = reader["nombreCliente"].ToString(),
                                tipoDocumento = reader["tipoDocumento"].ToString(),
                                numeroDocumento = reader["numeroDocumento"].ToString(),
                                montoPago = Convert.ToDecimal(reader["montoPago"].ToString()),
                                montoCambio = Convert.ToDecimal(reader["montoCambio"].ToString()),
                                montoTotal = Convert.ToDecimal(reader["montoTotal"].ToString()),
                                fechaRegistro = reader["fechaRegistro"].ToString(),

                            };
                        }
                    }


                }
                catch (Exception ex)
                {
                    objVenta = new Venta();
                }
            }
            return objVenta;

        }//Termina Obtener Venta


        public List<Detalle_Venta> obtenerDTVenta(int idVenta)
        {
            List<Detalle_Venta> lista = new List<Detalle_Venta>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    objConexion.Open();

                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("select p.nombre, dv.precioVenta, dv.cantidad, dv.subTotal from Detalle_Venta dv");
                    sb.AppendLine("inner join Producto p on p.idProducto = dv.idProducto where dv.idVenta = @idVenta");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    cmd.CommandType = CommandType.Text;


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Detalle_Venta()
                            {
                                objProducto = new Producto() { nombre = reader["nombre"].ToString() },
                                precioVenta = Convert.ToDecimal(reader["precioVenta"].ToString()),
                                cantidad = Convert.ToInt32(reader["cantidad"].ToString()),
                                subTotal = Convert.ToDecimal(reader["subTotal"].ToString()),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Detalle_Venta>();
                }
            }
            return lista;
        }//Termina método listar detalle


        public List<Venta> listarVentaUsuario(string fecha, int idUsuario)
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string consulta = "select idUsuario, documento, apodo, nombre, correo, contraseña, estado from Usuario";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select SUM(montoTotal)[TotalVenta] from Venta v  where CONVERT(date, v.fechaRegistro) = @fecha and v.idUsuario = @idUsuario");
                    sb.AppendLine("select nombre from Usuario where idUsuario = @idUsuario");
                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@fecha",fecha);
                    cmd.Parameters.AddWithValue("@idUsuario",idUsuario);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Venta()
                            {
                                objUsuario = new Usuario() { nombre = reader["nombre"].ToString() },
                                montoTotal = Convert.ToDecimal(reader["TotalVenta"].ToString()),
                                fechaRegistro = fecha
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Venta>();
                }
            }
            return lista;
        }//Termina metodo listar Venta

    }//termina clase
}
