using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }


        public double GetBonificacao()
        {

            Salario += Salario * 0.15;
            return Salario;

        }
    }
}

