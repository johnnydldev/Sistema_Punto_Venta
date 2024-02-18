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
    public class ReporteDAO
    {

        public List<ReporteCompra> Compra(string fechaInicio, string fechaFinal)
        {
            List<ReporteCompra> lista = new List<ReporteCompra>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("sp_ReporteCompra", objConexion);
                    cmd.Parameters.AddWithValue("fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("fechaFinal", fechaFinal);
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ReporteCompra()
                            {
                                fechaRegistro = reader["fechaRegistro"].ToString(),
                                tipoDocumento = reader["tipoDocumento"].ToString(),
                                numeroDocumento = reader["numeroDocumento"].ToString(),
                                montoTotal = reader["montoTotal"].ToString(),
                                nombreUsuario = reader["nombreUsuario"].ToString(),
                                documentoProveedor = reader["documentoProveedor"].ToString(),
                                razonSocial = reader["razonSocial"].ToString(),
                                codProducto = reader["codProducto"].ToString(),
                                nombreProducto = reader["nombreProducto"].ToString(),
                                categoria = reader["categoria"].ToString(),
                                precioCompra = reader["precioCompra"].ToString(),
                                precioVenta = reader["precioVenta"].ToString(),
                                cantidad = reader["cantidad"].ToString(),
                                subTotal = reader["subTotal"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteCompra>();
                }
            }
            return lista;
        }//Termina metodoo listar

        public List<ReporteVenta> Venta(string fechaInicio, string fechaFinal)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_ReporteVenta", objConexion);
                    cmd.Parameters.AddWithValue("fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("fechaFinal", fechaFinal);
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                fechaRegistro = reader["fechaRegistro"].ToString(),
                                tipoDocumento = reader["tipoDocumento"].ToString(),
                                numeroDocumento = reader["numeroDocumento"].ToString(),
                                montoTotal = reader["montoTotal"].ToString(),
                                nombreUsuario = reader["nombreUsuario"].ToString(),
                                documentoCliente = reader["documentoCliente"].ToString(),
                                nombreCliente = reader["nombreCliente"].ToString(),
                                codProducto = reader["codigoProducto"].ToString(),
                                nombreProducto = reader["nombreProducto"].ToString(),
                                categoria = reader["categoria"].ToString(),
                                precioVenta = reader["precioVenta"].ToString(),
                                cantidad = reader["cantidad"].ToString(),
                                subTotal = reader["subTotal"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVenta>();
                }
            }
            return lista;
        }//Termina metodoo listar

        public List<ReporteVenta> VentaUsuario(string fecha, int id)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_VentaUsuario", objConexion);
                    cmd.Parameters.AddWithValue("fecha", fecha);
                    cmd.Parameters.AddWithValue("idUsuario", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                montoTotal = reader["TotalVenta"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVenta>();
                }
            }
            return lista;
        }//Termina metodoo listar


    }//termina clase
}
