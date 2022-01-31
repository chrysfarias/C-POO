using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(923201931,2839283);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

        }
    }
}
