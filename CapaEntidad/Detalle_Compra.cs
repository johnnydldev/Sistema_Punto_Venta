using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Compra
    {
        public int idDetalleCompra { get; set; }
        
        public Compra objCompra { get; set; }

        public Proveedor objProveedor { get; set; }

        public Producto objProducto { get; set; }

        public decimal precioCompra { get; set; }   

        public decimal precioVenta { get; set; }

        public int cantidad { get; set; }

        public decimal subTotal { get; set; }

        public string fechaRegistro { get; set; }



    }
}
