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
            Funcionario bruno = new Funcionario(300,"Bruno pereira","0989829");
            Diretor andre = new Diretor("Andre Rocha", "3287487");
            GerenteDeConta ana = new GerenteDeConta("dfdf","dwfds");
            
           
           

            Console.WriteLine(bruno.Nome);
            Console.WriteLine(andre.Nome);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            Console.WriteLine(bruno.Salario);
            bruno.ObterAumentoSalario();
            

          

            Console.WriteLine(andre.Salario);
            andre.ObterAumentoSalario();
            Console.WriteLine(andre.Salario);
            Console.WriteLine(bruno.Salario);
            












            Console.ReadLine();
        }
    }
}
