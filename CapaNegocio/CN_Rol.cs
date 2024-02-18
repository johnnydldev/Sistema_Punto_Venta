using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private RolDAO objRolDAO = new RolDAO();


        public List<Rol> listar()
        {

            return objRolDAO.listar();
        }
    }
}
