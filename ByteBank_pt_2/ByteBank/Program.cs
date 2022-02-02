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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario bruno = new Funcionario();
            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "20098789";
            roberta.Salario = 5000;

            bruno.CPF = "20098787";
            bruno.Nome = "Bruno Da Silva Pinhiro";
            bruno.Salario = 3000;

            gerenciador.Registrar(bruno);
           
            gerenciador.Registrar(roberta);

            Console.WriteLine(bruno.Salario);
            Console.WriteLine(bruno.GetBonificacao());
            Console.WriteLine(roberta.Salario);
            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            
            






            Console.ReadLine();
        }
    }
}
