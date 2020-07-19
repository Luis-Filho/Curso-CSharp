using System.Globalization;

namespace Exercicio1_conta_bancaria
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria (int numero_conta, string nome) : this () {
            NumeroConta = numero_conta;
            Nome = nome;
        }

        public ContaBancaria (int numero_conta, string nome, double saldo) : this (numero_conta, nome)
        {
            Deposito(saldo);
        }

        public void Deposito (double valor)
        {
            Saldo += valor;
        }

        public void Saque (double valor)
        {
            Saldo -= (valor + 5.00);
        }

        public override string ToString()
        {
            return "\n\nDados da conta: \n" +
                   "Conta: " + NumeroConta.ToString() +
                   ", Titular: " + Nome +
                   ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture)+
                   "\n\n";
        }
    }
}
