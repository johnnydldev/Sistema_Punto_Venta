using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public  class CN_Usuario
    {
        private UsuarioDAO objUsuarioDAO = new UsuarioDAO();

        public Usuario searchUser(string nickname, string password)
        {
            return objUsuarioDAO.searchUser(nickname, password);
        }
        public List<Usuario> listar()
        {
            return objUsuarioDAO.listar();
        }//Termina Metodo Listar

        public int obtenerId()
        {
            return objUsuarioDAO.obtenerIdMax();
        }

        public int registrar(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.nombre == "")
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
            if (obj.apodo == "")
            {
                mensaje += "El apodo no puede estar vacio.\n";
            }
            if (obj.clave == "")
            {
                mensaje += "La clave no puede estar vacia.\n";
            }
            

            if(mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objUsuarioDAO.registrar(obj, out mensaje);
            }  
            
        }

        public bool editar(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.nombre == "")
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
            if (obj.apodo == "")
            {
                mensaje += "El apodo no puede estar vacio.\n";
            }
            if (obj.clave == "")
            {
                mensaje += "La clave no puede estar vacia.\n";
            }


            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objUsuarioDAO.editar(obj, out mensaje);
            }
            
        }

        public bool eliminar(Usuario obj, out string mensaje)
        {
            return objUsuarioDAO.eliminar(obj, out mensaje);
        }




    }//Termina Clase
}
