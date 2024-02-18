using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {

        private ProveedorDAO objDAO = new ProveedorDAO();


        public List<Proveedor> listar()
        {


            return objDAO.listar();
        }//Termina Metodo Listar

        public int obtenerId()
        {
            return objDAO.obtenerIdMax();
        }

        public int registrar(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.razonSocial == "")
            {
                mensaje += "El nombre no puede estar vacio.\n";
            }
            if (obj.documento == "")
            {
                mensaje += "El documento no puede estar vacio.\n";
            }
            if (obj.correo == "")
            {
                mensaje += "El correo no puede estar vacio.\n";
            }
            if (obj.telefono == "")
            {
                mensaje += "El correo no puede estar vacio.\n";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objDAO.registrar(obj, out mensaje);
            }

        }

        public bool editar(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.razonSocial == "")
            {
                mensaje += "El nombre no puede estar vacio.\n";
            }
            if (obj.documento == "")
            {
                mensaje += "El documento no puede estar vacio.\n";
            }
            if (obj.correo == "")
            {
                mensaje += "El correo no puede estar vacio.\n";
            }
            if (obj.telefono == "")
            {
                mensaje += "El correo no puede estar vacio.\n";
            }



            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objDAO.editar(obj, out mensaje);
            }

        }

        public bool eliminar(Proveedor obj, out string mensaje)
        {
            return objDAO.eliminar(obj, out mensaje);
        }
    }
}
