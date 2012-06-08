using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos.SQL;
using NUnit.Framework;

namespace Negocio.Tests
{
    [TestFixture]
    public class LoginDeberia
    {
        [Test]
        public void RetornarIdDeUsuarioParaUsuarioValido()
        {
            int idValido = 1;
            string emailValido = "juanjo@gmail.com";
            string passwordValido = "password";

            var repositorioFalso = new RepositorioUsuariosFalso();
            repositorioFalso.IdValido = idValido;
            repositorioFalso.EmailValido = emailValido; 
            repositorioFalso.PasswordValido = passwordValido;

            var resultado = new Negocio.Seguridad(repositorioFalso).Login(emailValido, passwordValido);

            Assert.AreEqual(idValido, resultado);
        }
    }

    public class RepositorioUsuariosFalso : IRepositorioUsuarios
    {
        public int IdValido;
        public string EmailValido;
        public string PasswordValido;

        public int TraerPorEmailYPassword(string email, string password)
        {
            if (email == EmailValido && password == PasswordValido)
            {
                return IdValido;
            }
            return 0;
        }
    }
}
