using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financiera.Dominio;

namespace Financiera.Prueba
{
    [TestClass]
    public class PruebasUnitariasCliente
    {
        [TestMethod]
        public void ClienteCreadoSatisfactoriamente()
        {
            var lo_cliente = Cliente.Agregar(1, "Christian Roger", DateTime.Parse("17-12-1990"));
            Assert.IsNotNull(lo_cliente);
            Assert.IsTrue(lo_cliente.CodigoCliente == 1);
        }
    }
}
