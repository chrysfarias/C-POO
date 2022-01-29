using System;
//using _05_ByteBank;

namespace _06_ByteBank 
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 490;


        public void SetSaldo(double saldo) 
        {
            if (saldo < 0)
            {
                return;
            }

            this.saldo = saldo;
                                 
        }

        public double GetSaldo()
        {
            return this.saldo;
        
        }



        public void Sacar(double valor) //verificar se o saldo é menor que o valor
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("Operação nao realizada por falta de Saldo");
            }

            this.saldo -= valor;

        }


        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;


        }

       

    }   

}
