using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario bruno = new Funcionario();

            bruno.CPF = "20098787";
            bruno.nome = "Bruno Da Silva Pinhiro";
            bruno.Salario = 3000;

            Console.WriteLine(bruno.Salario);
            Console.WriteLine(bruno.GetBonificacao());
            Console.WriteLine(bruno.Salario);






            Console.ReadLine();
        }
    }
}
