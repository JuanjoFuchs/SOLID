using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocio;

namespace AccesoDatos.SQL
{
    public class RepositorioUsuariosSQL : IRepositorioUsuarios
    {
        public int TraerPorEmailYPassword(string email, string password)
        {
            throw new NotImplementedException("No hay base de datos!!");
        }
    }
}
