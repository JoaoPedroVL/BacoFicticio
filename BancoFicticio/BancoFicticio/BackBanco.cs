using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFicticio
{
    internal class BackBanco
    {
        public string Nome { get ; set; }
        public int NumConta {  get;  private set; }
        public double Valor { get; private set; }




        //Construtor
        public BackBanco(string nome, int numconta)
        {
            Nome = nome;
            NumConta = numconta;
            Valor = 0;
        }


        public void deposito(double valor)
        {
            Valor += valor;
        }

        public void saque(double valor)
        {
            Valor = Valor - valor - 5;
        }

        public override string ToString()
        {
            return $"Conta {NumConta}, Titular: {Nome}, Saldo: R${Valor}.00"; 
        }

    }
}
