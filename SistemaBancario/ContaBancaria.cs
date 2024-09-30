using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class ContaBancaria
    {
        private string Numero { get; set; }
        private double Saldo { get; set; }
        private double Limite { get; set; }
        private string Historico { get; set; }

        //QUANDO PRIVADO (PRIVATE), NÃO É POSSÍVEL ENXERGAR OS ATRIBUTOS EM OUTRAS CLASSES.

        public ContaBancaria(string numero, double limite)
        {
            Numero = numero;
            Limite = limite;
            Saldo = 0;
            Historico = "";
        }

        //void: PARA RETORNAR NADA.

        public String Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Historico += "(-) " + valor.ToString("C2") + DateTime.Now.ToShortDateString();
                return "Retire seu Dinheiro!"; //O RETURN SEMPRE TEM QUE SER O ULTIMO!
            }
            else if (Limite + Saldo >= valor)
            {
                Limite = Limite - (valor - Saldo);
                Saldo = 0;
                Historico += "(-) " + valor.ToString("C2") + " -- " + DateTime.Now.ToShortDateString();
                return "Retire seu Dinheiro!";
            }
            else
            {
                return "Saldo Insulficiente!";
            }
        }

        public string ConsultarSaldo()
        {
            return "Saldo Atual: R$ " + Saldo.ToString("C2") + "\nLimite: " + Limite.ToString("C2");
        }

        public string Depositar(double valor)
        {
            Saldo = Saldo + valor;
            Historico += "(+) " + valor.ToString("C2") + " -- " + DateTime.Now.ToShortDateString();
            return "Retire o seu Comprovante!";
        }

        public string ImprimirExtrato()
        {
            return Historico;
        }

        ~ContaBancaria() 
        {

        }
    }
}
