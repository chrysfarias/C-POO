using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public string Senha { get; set; }

        public static int TotalDeFuncionarios { get; private set; }


        public Funcionario(double Salario, string Nome, string CPF)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Salario = Salario;
            TotalDeFuncionarios++;
        }

        public bool Autenticar(string senha) 
        {
            return this.Senha == senha; 
        }


        public abstract void ObterAumentoSalario();
        public abstract double GetBonificacao();
        
    }
}

