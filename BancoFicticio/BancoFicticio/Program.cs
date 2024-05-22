using BancoFicticio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        double valor;

        Console.Write("Entre com sua conta: ");
        int conta = int.Parse(Console.ReadLine());

        Console.Write("Entre com seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Havera deposito inicial (S/N)? ");
        string deposito = Console.ReadLine();

        //construtor
        BackBanco bb = new BackBanco(nome, conta);



        //logica de deposito inicial
        if (deposito == "s")
        {
            Console.Write("Entre com o valor de deposito inicial: ");
            valor = double.Parse(Console.ReadLine());
            bb.deposito(valor);
        }

        //mostrar dados da conta
        Console.WriteLine("Dados da conta:");
        Console.WriteLine(bb.ToString());

        Console.Write("Entre com valor para deposito: ");
        valor = double.Parse(Console.ReadLine());
        bb.deposito(valor);

        Console.WriteLine("Dadis da conta atualizados: ");
        Console.WriteLine(bb.ToString());

        Console.Write("Entre com um valor para saque: ");
        valor = double.Parse(Console.ReadLine());
        bb.saque(valor);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(bb.ToString());





    }
}