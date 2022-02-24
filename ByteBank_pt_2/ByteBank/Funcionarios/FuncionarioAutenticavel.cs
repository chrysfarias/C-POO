using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{

    public abstract class FuncionarioAutenticavel : Funcionario, Autenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double Salario, string Nome, string CPF) : base(Salario, Nome, CPF) { }

        public bool Autenticar(string senha) 
        {
            return Senha == senha;
        }
    }
}
