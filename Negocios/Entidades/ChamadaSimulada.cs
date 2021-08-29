using Negocios.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.Entidades
{
    public class ChamadaSimulada
    {
        public CodigoCidades Origem { get; }
        public CodigoCidades Destino { get; }
        public int Minutos { get; }
        public Planos? Plano { get; }

        public ChamadaSimulada(CodigoCidades origem, CodigoCidades destino, int minutos, Planos? plano)
        {
            Origem = origem;
            Destino = destino;
            Minutos = minutos;
            Plano = plano;
        }
    }
}
