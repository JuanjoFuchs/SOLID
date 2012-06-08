using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Seguridad
    {
        public static int Login(string email, string password)
        {
            return AccesoDatos.Seguridad.Login(email, password);
        }
    }
}
