using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente(); // criando um objeto
            ContaCorrente conta = new ContaCorrente();
            Herdeiro herdeiro = new Herdeiro();

            gabriela.nome = "Gabriela";
            gabriela.cpf = "20092822";
            gabriela.profissao = "Engenheira mecânica";

            conta.titular = gabriela;

            gabriela.filho = herdeiro;

            

            herdeiro.nome = "Antônio Nunes";
            herdeiro.escolaridade = "Ensino médio";
            herdeiro.idade = 17;
            herdeiro.sexo = "Masculino";

           


            //teste

            Console.WriteLine(conta.titular.cpf);
        }
    }
}
