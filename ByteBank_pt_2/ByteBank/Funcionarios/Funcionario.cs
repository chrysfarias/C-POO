﻿using System;
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
      

        public static int TotalDeFuncionarios { get; private set; }


        public Funcionario(double Salario, string Nome, string CPF)
        {
            this.Nome = Nome;
            this.CPF = CPF; 
            this.Salario = Salario;
            TotalDeFuncionarios++;
        }

       

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
        
    }
}

