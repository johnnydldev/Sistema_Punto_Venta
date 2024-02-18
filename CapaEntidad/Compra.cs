using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int idCompra { get; set; }

        public Usuario objUsuario { get; set; }

        public Proveedor objProveedor { get; set; }

        public List<Detalle_Compra> objDetalleCompra { get; set; }

        public string tipoDocumento { get; set; }

        public string numDocumento { get; set; }

        public decimal montoTotal { get; set; }

        public string fechaRegistro { get; set; }

    }
}
