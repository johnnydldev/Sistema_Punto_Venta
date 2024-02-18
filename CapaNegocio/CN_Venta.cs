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
    public class CN_Venta
    {
        private VentaDAO objDAO = new VentaDAO();

        public List<Venta> listar()
        {

            return objDAO.listar();
        }//Termina Metodo Listar
        public int obtenerCorrelativo()
        {
            return objDAO.obtenerCorrelativo();
        }//Termina Metodo 

        public bool restarStock(int idProducto, int cantidad)
        {
            return objDAO.restarStock(idProducto, cantidad);
        }
        public bool sumarStock(int idProducto, int cantidad)
        {
            return objDAO.sumarStock(idProducto, cantidad);
        }


        public bool registrarVenta(Venta obj, DataTable dtVenta, out string mensaje)
        {
            return objDAO.registrarVenta(obj, dtVenta, out mensaje);
        }

        public Venta obtenerVenta(string numero)
        {
            Venta obj = objDAO.obtenerVenta(numero);

            if (obj.idVenta != 0)
            {
                List<Detalle_Venta> objDTVenta = objDAO.obtenerDTVenta(obj.idVenta);

                obj.objDetalleVenta = objDTVenta;
            }
            return obj;
        }

    }
}
