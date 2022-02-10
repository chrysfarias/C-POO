using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Autenticavel
    {
       
        public Diretor(string Nome, string CPF) : base(5000, Nome, CPF) { }

       
        public override double GetBonificacao()
        {

            return Salario * 0.5;
        }

        public override void ObterAumentoSalario()
        {
            Salario += Salario * 0.15;
           
        }
    }
}
