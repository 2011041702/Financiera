using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financiera.Dominio;
using Financiera.Infraestructura;

namespace Financiera.Prueba
{
    [TestClass]
    public class PruebasIntegralesCliente
    {
        [TestMethod]
        public void AgregarCliente()
        {
            var lo_cliente = Cliente.Agregar(1, "Christian Poma", DateTime.Parse("22/08/1992"));
            using (var lo_contexto = new FinancieraContexto())
            {                
                lo_contexto.Clientes.Add(lo_cliente);
                lo_contexto.SaveChanges();                
            }
            Assert.IsTrue(lo_cliente.CodigoCliente == 1);
        }
    }
}
