using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocios.Entidades;
using Negocios.Enum;

namespace Teste
{
    [TestClass]
    public class CalculoTarifaTestes
    {
        [TestMethod]
        public void CalculaTarifaPlano30MinutosMenorQuePlano()
        {
            ChamadaSimulada chamadaSimulada = new ChamadaSimulada(CodigoCidades.Codigo011, CodigoCidades.Codigo016, 20, (Planos) 30);
            double valor = new CalculadorTarifa().calcular(chamadaSimulada);
            Assert.AreEqual<double>(0.00, valor);
        }

        [TestMethod]
        public void CalculaTarifaPlano60MinutosMenorQuePlano()
        {
            ChamadaSimulada chamadaSimulada = new ChamadaSimulada(CodigoCidades.Codigo016, CodigoCidades.Codigo011, 50, (Planos)60);
            double valor = new CalculadorTarifa().calcular(chamadaSimulada);
            Assert.AreEqual<double>(0.00, valor);
        }

        [TestMethod]
        public void CalculaTarifaPlano120MinutosMaiorQuePlano()
        {
            ChamadaSimulada chamadaSimulada = new ChamadaSimulada(CodigoCidades.Codigo017, CodigoCidades.Codigo011, 123, (Planos)120);
            double valor = new CalculadorTarifa().calcular(chamadaSimulada);
            Assert.AreEqual<double>(8.91, valor);
        }
    }
}
