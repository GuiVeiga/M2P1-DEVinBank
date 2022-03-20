using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBankClasses
{
    public class ContaCorrente : Conta
    {
        public decimal ChequeEspecial { get; private set; }

        public ContaCorrente(string nome, string cPF, string endereco, decimal rendaMensal, int agencia) : base(nome, cPF, endereco, rendaMensal, agencia)
        {
        }

        public void GetChequeEspecial()
        {
            ChequeEspecial = (RendaMensal * 10) / 100;
        }

        public void ExibirChequeEspecial()
        {
            Console.WriteLine($"Cheque Especial disponivel: R$ {ChequeEspecial}");
        }

        public void SacarContaCorrente(decimal valor)
        {
            Saldo -= valor;
        }

        public void SacarContaCorrenteChequeEspecial(decimal valor)
        {
            Saldo -= valor;
            ChequeEspecial -= valor;
        }

        public void TransferenciaContaCorrente(ContaCorrente conta1, ContaCorrente conta2, decimal valor)
        {
            conta1.SacarContaCorrente(valor);
            conta2.Depositar(valor);
        }

        public void TransferenciaContaCorrenteChequeEspecial(ContaCorrente conta1, ContaCorrente conta2, decimal valor)
        {
            conta1.SacarContaCorrenteChequeEspecial(valor);
            conta2.Depositar(valor);
        }
    }
}
