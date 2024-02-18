using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reporte
    {

        private ReporteDAO objDAO = new ReporteDAO();

        public List<ReporteCompra> obtenerCompras(string fechaInicio, string fechaFinal)
        {
            return objDAO.Compra(fechaInicio, fechaFinal);
        }

        public List<ReporteVenta> obtenerVentas(string fechaInicio, string fechaFinal)
        {
            return objDAO.Venta(fechaInicio, fechaFinal);
        }

        public List<ReporteVenta> ventaUsuario(string fecha, int id)
        {
            return objDAO.VentaUsuario(fecha, id);
        }
    }
}
