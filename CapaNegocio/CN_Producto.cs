using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {

        private ProductoDAO objProductoDAO = new ProductoDAO();


        public List<Producto> listar()
        {


            return objProductoDAO.listar();
        }//Termina Metodo Listar

        public int obtenerIdProduct()
        {
            return objProductoDAO.obtenerIdMaxProduct();
        }

        public int registrar(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.codigo == "")
            {
                mensaje += "El código no puede estar vacio.\n";
            }
            if (obj.nombre == "")
            {
                mensaje += "El nombre no puede estar vacio.\n";
            }
            

            if (obj.descripcion == "")
            {
                mensaje += "La descripción no puede estar vacia.\n";
            }



            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objProductoDAO.registrar(obj, out mensaje);
            }

        }

        public bool editar(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.codigo == "")
            {
                mensaje += "El código no puede estar vacio.\n";
            }
            if (obj.nombre == "")
            {
                mensaje += "El nombre no puede estar vacio.\n";
            }

            if (obj.descripcion == "")
            {
                mensaje += "La descripción no puede estar vacia.\n";
            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objProductoDAO.editar(obj, out mensaje);
            }

        }

        public bool eliminar(Producto obj, out string mensaje)
        {
            return objProductoDAO.eliminar(obj, out mensaje);
        }

    }
}
