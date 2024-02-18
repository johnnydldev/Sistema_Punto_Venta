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
    public  class RolDAO
    {

        public List<Rol> listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "select idRol, descripcion from Rol";

                    SqlCommand cmd = new SqlCommand(consulta, objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Rol()
                            {
                                idRol = Convert.ToInt32(reader["idRol"]),
                                descripcion = reader["descripcion"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();

                    throw;
                }
            }
            return lista;
        }//Termino de metodo listar

    }
}
