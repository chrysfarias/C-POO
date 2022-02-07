using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario 
    {
        public Diretor(string Nome, string CPF) : base(Nome, CPF) { }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
