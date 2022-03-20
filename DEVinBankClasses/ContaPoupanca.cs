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
    }
}
