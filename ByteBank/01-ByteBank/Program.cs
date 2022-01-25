using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ContaCorrente();  // criando o objeto
            

            ContaCorrente contaDaGabriela = new ContaCorrente(); // new cria o objeto 

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 123;
            contaDaGabriela.saldo = 20.00;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Saldo: "  +contaDaGabriela.saldo);
            Console.WriteLine("Número: " + contaDaGabriela.numero);




            Console.ReadLine();

        }
    }
}
