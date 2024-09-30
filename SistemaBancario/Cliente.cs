using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class Cliente
    {
        private int Codigo { get; set; }
        private string Nome { get; set; }
        
        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;   
        }

        ~Cliente()
        {

        }
    }
}