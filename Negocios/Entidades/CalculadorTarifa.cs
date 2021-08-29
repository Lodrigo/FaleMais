using Negocios.Excecoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.Entidades
{
    public class CalculadorTarifa
    {
        const double porcentagemTarifa = 10;

        public double calcular(ChamadaSimulada chamadaSimulada)
        {
            double tarifaMinuto = this.obterTarifaMinuto(chamadaSimulada);
            int minutosGratis = 0;
            double minutosPagos = 0;

            if(chamadaSimulada.Plano != null)
            {
                minutosGratis = (int)chamadaSimulada.Plano;
            }

            minutosPagos = chamadaSimulada.Minutos - minutosGratis;

            return this.calcularTotal(minutosPagos, tarifaMinuto);/*TabelaTarifas.RegistrosTarifas();*/
        }

        public CalculadorTarifa()
        {

        }

        private double obterTarifaMinuto(ChamadaSimulada chamadaSimulada)
        {
            foreach (var item in TabelaTarifas.RegistrosTarifas)
            {
                if(item.Origen == chamadaSimulada.Origem && item.Destino == chamadaSimulada.Destino)
                {
                    return item.Valor;
                }
            }

            throw new OrigemDestinoChamadaInvalidos();
        }

        private double calcularTotal(double minutosPagos, double tarifaMinuto)
        {
            if(minutosPagos < 0)
            {
                return 0.00;
            }

            double acrescimoMinuto = tarifaMinuto * porcentagemTarifa / 100;

            double valorMinuto = tarifaMinuto + acrescimoMinuto;

            return valorMinuto * minutosPagos;
        }
    }
}
