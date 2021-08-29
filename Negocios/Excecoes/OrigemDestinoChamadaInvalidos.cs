using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.Excecoes
{
    [Serializable]
    public class OrigemDestinoChamadaInvalidos : Exception
    {
        public OrigemDestinoChamadaInvalidos() : base() { }
        public OrigemDestinoChamadaInvalidos(string message) : base(message) { }
        public OrigemDestinoChamadaInvalidos(string message, Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected OrigemDestinoChamadaInvalidos(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
