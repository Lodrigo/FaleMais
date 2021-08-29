using Negocios.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.Entidades
{
    class TabelaTarifas
    {
        public static readonly List<RegistroTarifa> RegistrosTarifas = new List<RegistroTarifa>()
        {
            new RegistroTarifa
            {
                Origen = CodigoCidades.Codigo011,
                Destino = CodigoCidades.Codigo016,
                Valor = 1.90
            },

            new RegistroTarifa
            {
                Origen = CodigoCidades.Codigo016,
                Destino = CodigoCidades.Codigo011,
                Valor = 2.90
            },

            new RegistroTarifa
            {
                Origen = CodigoCidades.Codigo011,
                Destino = CodigoCidades.Codigo017,
                Valor = 1.70
            },

            new RegistroTarifa
            {
                Origen = CodigoCidades.Codigo017,
                Destino = CodigoCidades.Codigo011,
                Valor = 2.70
            },

            new RegistroTarifa
            {
                Origen = CodigoCidades.Codigo011,
                Destino = CodigoCidades.Codigo018,
                Valor = 0.90
            },

            new RegistroTarifa
            {
                Origen = CodigoCidades.Codigo018,
                Destino = CodigoCidades.Codigo011,
                Valor = 1.90
            }
        };
    }
}
