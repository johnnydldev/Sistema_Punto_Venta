using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Permiso
    {

        
            private PermisoDAO objPermisoDAO = new PermisoDAO();


            public List<Permiso> listar(int idUsuario)
            {

                return objPermisoDAO.listar(idUsuario);

            }//Termina listar CN Permiso
    }
}
