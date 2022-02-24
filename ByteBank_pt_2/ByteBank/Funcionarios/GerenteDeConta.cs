using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Autenticavel
    {
        public GerenteDeConta(string Nome, string CPF) : base(4000, Nome,CPF) { }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
             Salario *= 0.5;
        }

    }
}
