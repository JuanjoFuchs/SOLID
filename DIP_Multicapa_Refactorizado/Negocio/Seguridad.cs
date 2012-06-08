using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Seguridad
    {
        private readonly IRepositorioUsuarios _repositorioUsuarios;

        public Seguridad(IRepositorioUsuarios repositorioUsuarios)
        {
            _repositorioUsuarios = repositorioUsuarios;
        }

        public int Login(string email, string password)
        {
            return _repositorioUsuarios.TraerPorEmailYPassword(email, password);
        }
    }
}
