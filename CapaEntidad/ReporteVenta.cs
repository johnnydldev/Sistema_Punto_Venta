﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteVenta
    {

        public string fechaRegistro { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string montoTotal { get; set; }
        public string nombreUsuario { get; set; }
        public string documentoCliente { get; set; }
        public string nombreCliente { get; set; }
        public string codProducto { get; set; }
        public string nombreProducto { get; set; }
        public string categoria { get; set; }
        public string precioVenta { get; set; }
        public string cantidad { get; set; }
        public string subTotal { get; set; }

    }
}
