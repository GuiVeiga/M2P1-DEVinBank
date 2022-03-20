using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBankClasses
{
    public class MenuPrincipal
    {
        public static void AtivarMenuPrincipal()
        {
            bool encerrarAplicacao = false;

            while (!encerrarAplicacao)
            {
                ExibirMenuPrincipal();
                int entrada;

                while (!int.TryParse(Console.ReadLine(), out entrada) || entrada < 1 || entrada > 4)
                {
                    Console.Write("Entrada inválida. Entre com um valor entre 1 a 4: ");
                }

                switch (entrada)
                {
                    case 1:
                        Console.Clear();
                        MenuContaCorrente.AtivarMenuCC();
                        break;
                    case 2:
                        Console.Clear();
                        MenuContaPoupanca.AtivarMenuCP();
                        break;
                    case 3:
                        Console.Clear();
                        MenuContaInvestimento.AtivarMenuCI();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\nEncerrando Aplicação, volte sempre!\n");
                        encerrarAplicacao = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public static void ExibirMenuPrincipal()
        {
            ExibirDataAtual();
            Console.WriteLine("-------------------- Menu Principal --------------------");
            Console.WriteLine("Bem vindo ao Sistema bancário do DEVinBank!");
            Console.WriteLine("Escolha uma das opcoes abaixo: \n");

            Console.WriteLine("[1] - Conta Corrente");
            Console.WriteLine("[2] - Conta Poupança");
            Console.WriteLine("[3] - Conta Investimento");
            Console.WriteLine("[4] - Sair");

            Console.WriteLine("-------------------- DEVinBank --------------------");
            Console.Write("\nValor inserido: ");
        }

        public static void ExibirDataAtual()
        {
            Console.WriteLine($"Data Atual do Sistema: {DateTime.Now.ToString()}");
        }
    }
}
