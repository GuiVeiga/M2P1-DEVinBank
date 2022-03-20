using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBankClasses
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string nome, string cPF, string endereco, decimal rendaMensal, int agencia) : base(nome, cPF, endereco, rendaMensal, agencia)
        {
        }

        public void SimularRendimento(int meses)
        {
            var tr = 0.5M + 0.0436M;
            var rendimentoDoMes = (Saldo * tr) / 100;
            var simularRendimento = rendimentoDoMes * meses;

            Console.WriteLine($"Redimento por mes: R$ {String.Format("{0:0.00}", rendimentoDoMes)}");
            Console.WriteLine($"Redimento em {meses} meses: R$ {String.Format("{0:0.00}", simularRendimento)}");
        }
    }
}
