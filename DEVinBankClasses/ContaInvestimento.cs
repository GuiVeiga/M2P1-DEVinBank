using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBankClasses
{
    public class ContaInvestimento : Conta
    {
        public ContaInvestimento(string nome, string cPF, string endereco, decimal rendaMensal, int agencia) : base(nome, cPF, endereco, rendaMensal, agencia)
        {
        }
        public void InvestimentoLCI(decimal valor, int meses)
        {
            decimal valorInvestido = (valor * 8) / 100;
            decimal investimentoTotal = valorInvestido * meses;

            Console.WriteLine($"Valor investido: R$ {String.Format("{0:0.00}", valor)}");
            Console.WriteLine("Tipo de Investimento: LCI - 8% ao ano.");
            Console.WriteLine($"Investimento total em {meses} meses: R$ {String.Format("{0:0.00}", investimentoTotal)}");
        }

        public void InvestimentoLCA(decimal valor, int meses)
        {
            decimal valorInvestido = (valor * 9) / 100;
            decimal investimentoTotal = valorInvestido * meses;

            Console.WriteLine($"Valor investido: R$ {String.Format("{0:0.00}", valor)}");
            Console.WriteLine("Tipo de Investimento: LCA - 9% ao ano.");
            Console.WriteLine($"Investimento total em {meses} meses: R$ {String.Format("{0:0.00}", investimentoTotal)}");
        }

        public void InvestimentoCDB(decimal valor, int meses)
        {
            decimal valorInvestido = (valor * 10) / 100;
            decimal investimentoTotal = valorInvestido * meses;

            Console.WriteLine($"Valor investido: R$ {String.Format("{0:0.00}", valor)}");
            Console.WriteLine("Tipo de Investimento: CDB - 10% ao ano.");
            Console.WriteLine($"Investimento total em {meses} meses: R$ {String.Format("{0:0.00}", investimentoTotal)}");
        }
    }
}
