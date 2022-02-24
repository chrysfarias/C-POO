using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Designer : Funcionario
    {
        public Designer(string Nome, string CPF) : base(3000,Nome,CPF) { }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.11; 
        }
    }
}
