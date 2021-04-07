using System;
using System.Globalization;

namespace ExercicioEncapsulamento
{
    class ContaBancaria
    {
        public int Conta { get; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string nome) 
        {
            Conta = conta;
            Nome = nome;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.00;
        }


        public override string ToString()
        {
            return "\nDados da conta atualizados:\n" +
                    "Conta " + Conta.ToString()
                   + ", Titular: " + Nome +
                   ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }

    }
}
