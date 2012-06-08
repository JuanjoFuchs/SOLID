using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            var resultado = Negocio.Seguridad.Login(emailValido, passwordValido);

            Assert.AreEqual(idValido, resultado);
        }
    }
}
