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

            Diretor chrystian = new Diretor("Chrystian Pinheiro","09878787656");
            Designer angela = new Designer("Angela Assis","98787654333");
            GerenteDeConta carlos = new GerenteDeConta("Carlos Guina","87656789000");
            Auxiliar marcela = new Auxiliar("Marcela Vitória","98787789876");


            //prints

            Console.WriteLine($"Diretor: {chrystian.Nome}. salario base: {chrystian.Salario}." +
                $"bonificação:{chrystian.GetBonificacao()}.");

            chrystian.ObterAumentoSalario();

            Console.WriteLine("novo salario:" +chrystian.Salario);
            
           
           

            












            Console.ReadLine();
        }
    }
}
