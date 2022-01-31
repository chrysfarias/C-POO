using System;
//using _05_ByteBank;

namespace _06_ByteBank 
{
    public class ContaCorrente
    {
      
        public int agencia;
        public int numero;
        private double _saldo = 490;

        public Cliente Titular { get; set; }







        public double Saldo 
        {
            get

            {
                return _saldo;
            }


            set 
            {
                if (value <0 )
                {
                    return;
                }

                _saldo = value;
            }
        
        
        }



        



        public void Sacar(double valor) //verificar se o saldo é menor que o valor
        {
            if (this._saldo < valor)
            {
                Console.WriteLine("Operação nao realizada por falta de Saldo");
            }

            this._saldo -= valor;

        }


        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;


        }

       

    }   

}
