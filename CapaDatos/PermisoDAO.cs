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
    public class PermisoDAO
    {

        public List<Permiso> listar(int idUsuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select p.idRol, p.vista from Permiso p");
                    sb.AppendLine("inner join Rol r on r.idRol = p.idRol");
                    sb.AppendLine("inner join Usuario u on u.idRol = r.idRol");
                    sb.AppendLine("where u.idUsuario = @idUsuario;");


                    SqlCommand cmd = new SqlCommand(sb.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                objRol = new Rol() { idRol = Convert.ToInt32(reader["idRol"]) },
                                vista = reader["vista"].ToString()

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                    throw;
                }
            }
            return lista;
        }//termina Listar Permisos

    }//Termina Clase acceso a datos Permisos
}
