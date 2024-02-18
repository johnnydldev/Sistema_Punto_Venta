using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta.Herramientas
{
    public class ER_Metodos
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }//Termna método validar email

        public bool validarPrecio(string precio){

            if (string.IsNullOrWhiteSpace(precio))
                return false;

            bool respuesta = false;

            string patron = @"[0-9]+(\.){0,1}[0-9]{0,5}$";
          

            try
            {
                if (Regex.IsMatch(precio, patron))
                {
                    respuesta = true;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return respuesta;
            }

            return respuesta;

        }//Termina Validación de precio 

        public bool validarSoloLetras(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena))
                return false;

            bool respuesta = false;

            string patron = @"\s*[a-zA-Z]+$";
            try
            {
                if (Regex.IsMatch(cadena, patron) == true)
                {
                    respuesta = true;
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return respuesta;
            }

            return respuesta;
        }//termina validar texto


        public bool validarDocumento(string documento)
        {

            if (string.IsNullOrWhiteSpace(documento))
                return false;

            bool respuesta = false;

            string patron = @"[0-9]{8}$";


            try
            {
                if (Regex.IsMatch(documento, patron))
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return respuesta;
            }

            return respuesta;

        }//Termina Validación de documento

        public bool validarTelefono(string documento)
        {

            if (string.IsNullOrWhiteSpace(documento))
                return false;

            bool respuesta = false;

            string patron = @"[0-9]{10}$";


            try
            {
                if (Regex.IsMatch(documento, patron))
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return respuesta;
            }

            return respuesta;

        }//Termina Validación de telefono


        public bool validarCodigoProducto(string documento)
        {

            if (string.IsNullOrWhiteSpace(documento))
                return false;

            bool respuesta = false;

            string patron = @"[0-9]{8,13}$";


            try
            {
                if (Regex.IsMatch(documento, patron))
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return respuesta;
            }

            return respuesta;

        }//Termina Validación de codigo

        public bool validarNumeros(string documento)
        {

            if (string.IsNullOrWhiteSpace(documento))
                return false;

            bool respuesta = false;

            string patron = @"[0-9]+$";


            try
            {
                if (Regex.IsMatch(documento, patron))
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return respuesta;
            }

            return respuesta;

        }//Termina Validación de numeros

    }//Termina clase
}
