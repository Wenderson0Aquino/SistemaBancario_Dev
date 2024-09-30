using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente bruno = new Cliente(1, "Bruno Manzoli");
            Agencia centro = new Agencia("0555");
            ContaBancaria contaBruno = new ContaBancaria("1.852-4", 1000);
            CartaoDeCredito cartaoBruno = new CartaoDeCredito("123.321.123.543", Convert.ToDateTime("10/05/2030"), bruno);

            Console.WriteLine(contaBruno.Depositar(500));
            Console.WriteLine(contaBruno.Sacar(1501));
            Console.WriteLine(contaBruno.ConsultarSaldo());
            Console.WriteLine(contaBruno.ImprimirExtrato());

            cartaoBruno.MostrarDadosCartao();

            Console.ReadKey();
        }
    }
}
