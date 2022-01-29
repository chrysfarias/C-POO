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

            

            


            conta2.SetSaldo(200);
            Console.WriteLine(conta2.GetSaldo());

            Console.ReadLine();
        }
    }
}
