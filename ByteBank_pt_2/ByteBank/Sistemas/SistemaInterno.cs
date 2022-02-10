﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    internal class SistemaInterno
    {
        public bool logar(Funcionario funcionario,string senha) 
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;

            }

            else 
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }


        }
    }
}
