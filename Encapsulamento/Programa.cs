using System;
using System.Globalization;

namespace Encapsulamento {
    class Programa {
        public static void Main(String[] args) {

            Console.Write("Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Deseja realizar um deposito inicial? S/N");
            char resposta = char.Parse(Console.ReadLine());

            ContaBancaria conta;

            if (resposta == 's' || resposta == 'S') {
                Console.WriteLine("Qual valor deseja depositar?");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            } else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write ("Informe valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Informe valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
