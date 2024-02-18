using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CategoriaDAO objCategoriaDAO = new CategoriaDAO();


        public List<Categoria> listar()
        {


            return objCategoriaDAO.listar();
        }//Termina Metodo Listar

        public int obtenerIdCategoria()
        {
            return objCategoriaDAO.obtenerIdMaxCategoria();
        }

        public int registrar(Categoria obj, out string mensaje)
        {
            mensaje = string.Empty;

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
                return objCategoriaDAO.registrar(obj, out mensaje);
            }

        }

        public bool editar(Categoria obj, out string mensaje)
        {
            mensaje = string.Empty;

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
                return objCategoriaDAO.editar(obj, out mensaje);
            }

        }

        public bool eliminar(Categoria obj, out string mensaje)
        {
            return objCategoriaDAO.eliminar(obj, out mensaje);
        }



    }
}
