using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Auxiliar : Funcionario
    {
        public Auxiliar(string Nome, String CPF) : base(2000, Nome, CPF) { }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.10; 
        }
    }
}
