using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private NegocioDAO objDAO = new NegocioDAO();


        public Negocio obtenerDatos()
        {
            return objDAO.obtenerDatos();
        }//Termina Metodo Listar

       

        public bool guardarDatos(Negocio obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.nombre == "")
            {
                mensaje += "El nombre no puede estar vacio.\n";
            }
            if (obj.rfc == "")
            {
                mensaje += "El RFC no puede estar vacio.\n";
            }
            if (obj.direccion == "")
            {
                mensaje += "La dirección no puede estar vacia.\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objDAO.guardarDatos(obj, out mensaje);
            }

        }//Termina método guardar

        public byte[] obtenerLogo(out bool resultado)
        {
            return objDAO.cargarLogo(out resultado);
        }//Termina Metodo Listar

        public bool actualizarLogo(byte[] imagen, out string mensaje)
        {
            return objDAO.actualizarLogo(imagen, out mensaje);
        }//Termina Metodo Listar




    }//Termina clase
}
