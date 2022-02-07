using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string Nome, string CPF) 
        {
            this.Nome = Nome;
            this.CPF = CPF;
            TotalDeFuncionarios++;
        }

        public Funcionario()
        {
        }
        public virtual double GetBonificacao()
        {


            return Salario * 0.15;
            

        }
    }
}

