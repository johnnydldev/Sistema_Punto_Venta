using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {

        private CompraDAO objDAO = new CompraDAO();

        public List<Compra> listar()
        {

            return objDAO.listar();
        }//Termina Metodo Listar
        public int obtenerCorrelativo()
        {

            return objDAO.obtenerCorrelativo();
        }//Termina Metodo 



        public bool registrarCompra(Compra obj, DataTable dtCompra, out string mensaje)
        {
           
                return objDAO.registrarCompra(obj, dtCompra, out mensaje);
        }

        public Compra obtenerCompra(string numero)
        {
            Compra obj = objDAO.obtenerCompra(numero);

            if (obj.idCompra != 0)
            {
                List<Detalle_Compra> objDTCompra = objDAO.obtenerDTCompra(obj.idCompra);

                obj.objDetalleCompra = objDTCompra;
            }
            return obj;
        }


      
    }//termina clase
}
