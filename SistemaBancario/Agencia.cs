using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class Agencia
    {
        private string Numero { get; set; }

        public Agencia (string numero)
        {
            Numero = numero;
        }

        ~Agencia()
        {

        }
    }
}
