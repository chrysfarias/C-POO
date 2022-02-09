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
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Diretor chrystian = new Diretor("Chrystian Pinheiro","09878787656");

            Designer angela = new Designer("Angela Assis","98787654333");

            GerenteDeConta carlos = new GerenteDeConta("Carlos Guina","87656789000");

            Auxiliar marcela = new Auxiliar("Marcela Vitória","98787789876");


            

            Console.WriteLine($"Diretor: {chrystian.Nome}.\nSalario base: {chrystian.Salario}.\n" +
            $"bonificação: {chrystian.GetBonificacao()}.");

            gerenciadorBonificacao.Registrar(chrystian);
            gerenciadorBonificacao.Registrar(angela);
            gerenciadorBonificacao.Registrar(carlos);
            gerenciadorBonificacao.Registrar(marcela);

            Console.WriteLine("Total de bonificações do mês: "
            + gerenciadorBonificacao.GetTotalBonificacao());



















            Console.ReadLine();
        }
    }
}
