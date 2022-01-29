using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta2 = new ContaCorrente();

            Cliente cliente = new Cliente();
            cliente.nome = "Maycon Douglas";

            

            conta2.Saldo = 20;
            Console.WriteLine(conta2.Saldo);

            conta2.Titular = cliente;


            Console.WriteLine(conta2.Titular);
            Console.WriteLine(conta2.Titular.nome);

            

                       



            Console.ReadLine();
        }
    }
}
