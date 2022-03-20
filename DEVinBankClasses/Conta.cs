using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBankClasses
{
    public class Conta
    {
        public Conta(string nome, string cPF, string endereco, decimal rendaMensal, int agencia)
        {
            Nome = nome;
            CPF = cPF;
            Endereco = endereco;
            RendaMensal = rendaMensal;
            Agencia = agencia;
            NumeroDaConta = 100000001;
            Saldo = 0;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponivel: R$ {Saldo}");
        }

        public void Transferencia(Conta conta1, Conta conta2, decimal valor)
        {
            conta1.Sacar(valor);
            conta2.Depositar(valor);

        }

        public void ExibirDadosBancarios()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Renda Mensal: R$ {RendaMensal}");
            Console.WriteLine($"Numero da Conta: {NumeroDaConta}");
            Console.WriteLine($"Agencia: {Agencia}");
        }

        public void AlterarDadosBancarios(string nome, string endereco, decimal rendaMensal, int agencia)
        {
            Nome = nome;
            Endereco = endereco;
            RendaMensal = rendaMensal;
            Agencia = agencia;
        }

        public string Nome { get; protected set; }
        public string CPF { get; protected set; }
        public string Endereco { get; protected set; }
        public decimal RendaMensal { get; protected set; }
        public decimal NumeroDaConta { get; set; }
        public int Agencia { get; protected set; }
        public decimal Saldo { get; protected set; }
    }
}
