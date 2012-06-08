using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ComercioElectronico.Tests
{
    [TestFixture]
    public class CarritoCalcularTotalDeberiaRetornar
    {
        private Carrito _carrito;

        [SetUp]
        public void Preparar()
        {
            _carrito = new Carrito();
        }

        [Test]
        public void CeroCuandoEstaVacio()
        {
            Assert.AreEqual(0, _carrito.CalcularTotal());
        }

        [Test]
        public void OchoCuandoTieneSeisUnidadesQueCuestanDos()
        {
            _carrito.Agregar(new Producto() { Unidad = "UNIDAD", Precio = 2, Cantidad = 6 });
            Assert.AreEqual(8m, _carrito.CalcularTotal());
        }

        [Test]
        public void SieteCuandoTieneTresUnidadesQueCuestanTresPuntoCinco()
        {
            _carrito.Agregar(new Producto() { Unidad = "UNIDAD", Precio = 3.5m, Cantidad = 3 });
            Assert.AreEqual(7m, _carrito.CalcularTotal());
        }

        [Test]
        public void CientoDocePuntoCincoCuandoTieneCincoKilosQueCuestanVeintiCinco()
        {
            _carrito.Agregar(new Producto() { Unidad = "KG", Precio = 25, Cantidad = 5 });
            Assert.AreEqual(112.5m, _carrito.CalcularTotal());
        }

        [Test]
        public void CincoPuntoTrescientosOchentaYDosCuandoTieneDosKilosQueCuestanDosPuntoNoventaYNueve()
        {
            _carrito.Agregar(new Producto() { Unidad = "KG", Precio = 2.99m, Cantidad = 2 });
            Assert.AreEqual(5.382m, _carrito.CalcularTotal());
        }
    }
}
