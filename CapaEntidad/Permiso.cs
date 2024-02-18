using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int idPermiso { get; set; }
        public Rol objRol { get; set; }
        public string vista { get; set; }

        public string fechaRegistro { get; set; }


    }
}
