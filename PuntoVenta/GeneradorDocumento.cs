using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class GeneradorDocumento
    {
        Random rnd = new Random();

        private int nDocumento;
        private string cadenaDocumento = "";
        private string final;


        public string generadorDocumento()
        {


            nDocumento = rnd.Next(0, 9);
            cadenaDocumento += nDocumento;

            if (cadenaDocumento.Length < 8)
            {
                generadorDocumento();
            }
            else if (cadenaDocumento.Length == 8) 
            { 
                final = Convert.ToString(cadenaDocumento); 
            }
            else
            {
                final = "";
                cadenaDocumento = string.Empty;
                generadorDocumento();
            }

            return final;

            

        }
    }
}
