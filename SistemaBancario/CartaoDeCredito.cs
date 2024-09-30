using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class CartaoDeCredito
    {
        private string Numero { get; set; }
        private DateTime Validade { get; set; }
        private Cliente Cliente { get; set; } //AQUI CHAMA O ATRIBUTO CLIENTE DO TIPO CLIENTE(CLASSE CRIADA POR MIM) AONDE NA CLASSE PROGRAM CHAMA O OBJETO QUE PERTENCE A CLASSE CLIENTE.

        public CartaoDeCredito(string numero, DateTime validade, Cliente cliente)
        {
            Numero = numero;
            Validade = validade;
            Cliente = cliente;
        }

        public void MostrarDadosCartao()
        {
            Console.WriteLine(Numero + Validade + Cliente);
        }

        ~CartaoDeCredito()
        {

        }
    }
}
