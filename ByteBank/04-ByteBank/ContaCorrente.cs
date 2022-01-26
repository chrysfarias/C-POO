using System;


public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    
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