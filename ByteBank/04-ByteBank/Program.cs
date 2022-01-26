using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

             ContaCorrente  contaBruno   = new ContaCorrente();  // instanciei o objeto
             
             ContaCorrente  contaGabriela = new ContaCorrente();

            Console.WriteLine(contaBruno.saldo);

            contaBruno.Transferir(50,contaGabriela);

            Console.WriteLine(contaBruno.saldo);
            Console.WriteLine(contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
