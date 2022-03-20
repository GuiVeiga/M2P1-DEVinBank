using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBankClasses
{
    public class MenuContaInvestimento
    {
        public static void AtivarMenuCI()
        {
            bool voltar = false;

            ContaInvestimento contaInvestimento1 = new ContaInvestimento("Guilherme", "123.456.789-1", "Rua Vasco da Gama, 1898", 4000, 3);
            contaInvestimento1.NumeroDaConta = 100000001;
            contaInvestimento1.Depositar(1000);

            ContaInvestimento contaInvestimento2 = new ContaInvestimento("Gabriela", "098.765.432-1", "Rua Brasilia, 45", 2000, 1);
            contaInvestimento2.NumeroDaConta = 100000002;
            contaInvestimento2.Depositar(500);

            List<ContaInvestimento> listaContaInvestimento = new List<ContaInvestimento>();
            listaContaInvestimento.Add(contaInvestimento1);
            listaContaInvestimento.Add(contaInvestimento2);

            List<string> listaExtrato = new List<string>();

            while (!voltar)
            {
                ExibirMenuCI();
                int entrada;

                while (!int.TryParse(Console.ReadLine(), out entrada) || entrada < 1 || entrada > 9)
                {
                    Console.Write("Entrada inválida. Entre com um valor entre 1 a 9: ");
                }

                switch (entrada)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Entre com o Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Entre com o CPF: ");
                        string cpf = Console.ReadLine();
                        Console.Write("Entre com o Endereco: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Entre com a Renda Mensal: R$ ");
                        decimal rendaMensal = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Insira o Numero da Agencia desejada: 1 - Florianopolis, 2 - Sao Jose, 3 - Biguacu");
                        Console.Write("Entre com a Agencia: ");
                        int agencia = Convert.ToInt32(Console.ReadLine());

                        if (agencia < 1 || agencia > 3)
                        {
                            Console.WriteLine("\n///////////////// ERRO AO ABRIR CONTA /////////////////");
                            Console.WriteLine("Erro: Numero da Agencia invalido.");
                            Console.WriteLine("Escolha a opcao de Criar Conta novamente e entre com um numero de Agencia valido");
                            Console.WriteLine("///////////////// ERRO AO ABRIR CONTA /////////////////\n");
                        }
                        else
                        {
                            ContaInvestimento contaInvestimentoCriada = new ContaInvestimento(nome, cpf, endereco, rendaMensal, agencia);
                            Console.WriteLine("\n///////////////// Conta Investimento Criada /////////////////");
                            contaInvestimentoCriada.NumeroDaConta += listaContaInvestimento.Count;

                            listaContaInvestimento.Add(contaInvestimentoCriada);

                            contaInvestimentoCriada.ExibirDadosBancarios();
                            contaInvestimentoCriada.ExibirSaldo();
                            Console.WriteLine("///////////////// Conta Corrente Criada /////////////////\n");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        contaInvestimento1.ExibirSaldo();
                        Console.Write("Entre com o valor que deseja sacar: R$ ");
                        decimal saque = Convert.ToDecimal(Console.ReadLine());

                        if (contaInvestimento1.Saldo < saque)
                        {
                            Console.WriteLine("\n///////////////// ERRO AO REALIZAR SAQUE /////////////////");
                            Console.WriteLine("O valor do saque excede a quantidade de saldo");
                            Console.WriteLine("Escolha a opcao de Saque novamente e entre com um valor menor ou igual ao saldo");
                            Console.WriteLine("///////////////// ERRO AO REALIZAR SAQUE /////////////////\n");
                        }
                        else
                        {
                            contaInvestimento1.Sacar(saque);
                            Console.WriteLine("\n///////////////// Saque realizado com sucesso /////////////////");
                            contaInvestimento1.ExibirDadosBancarios();
                            Console.WriteLine($"Valor do saque: R$ {saque}");
                            contaInvestimento1.ExibirSaldo();
                            Console.WriteLine("///////////////// Saque realizado com sucesso /////////////////\n");

                            listaExtrato.Add($"{DateTime.Now.ToString()} - Saque realizado no valor de: R$ {saque}");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        contaInvestimento1.ExibirSaldo();
                        Console.Write("Entre com o valor que deseja depositar: R$ ");
                        decimal deposito = Convert.ToDecimal(Console.ReadLine());
                        contaInvestimento1.Depositar(deposito);

                        listaExtrato.Add($"{DateTime.Now.ToString()} - Deposito realizado no valor de: R$ {deposito}");

                        Console.WriteLine("\n///////////////// Deposito realizado com sucesso /////////////////");
                        contaInvestimento1.ExibirDadosBancarios();
                        Console.WriteLine($"Valor do deposito: R$ {deposito}");
                        contaInvestimento1.ExibirSaldo();
                        Console.WriteLine("///////////////// Deposito realizado com sucesso /////////////////\n");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n/////////////////");
                        contaInvestimento1.ExibirSaldo();
                        Console.WriteLine("/////////////////\n");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n///////////////// Extrato /////////////////");
                        foreach (var extrato in listaExtrato)
                        {
                            Console.WriteLine(extrato);
                            Console.WriteLine("--------------------------------------------------");
                        }
                        Console.WriteLine("///////////////// Extrato /////////////////\n");
                        break;

                    case 6:
                        Console.Clear();
                        contaInvestimento1.ExibirDadosBancarios();
                        contaInvestimento1.ExibirSaldo();
                        Console.WriteLine("--------------------------------------------------");
                        contaInvestimento1.ExibirDadosBancarios();
                        contaInvestimento1.ExibirSaldo();

                        Console.WriteLine("\n///////////////// Transferencia /////////////////");
                        Console.WriteLine("Esta Operacao realizara uma transferencia da Conta 1 para a Conta 2.");
                        Console.WriteLine("///////////////// Transferencia /////////////////\n");
                        Console.Write("Entre com o valor desejado da transferencia: R$ ");
                        decimal transferencia = Convert.ToDecimal(Console.ReadLine());

                        if (contaInvestimento1.Saldo < transferencia)
                        {
                            Console.WriteLine("\n///////////////// ERRO AO REALIZAR TRANSFERENCIA /////////////////");
                            Console.WriteLine("O valor da transferencia excede a quantidade de saldo");
                            Console.WriteLine("Escolha a opcao de Transferencia novamente e entre com um valor menor ou igual ao saldo");
                            Console.WriteLine("///////////////// ERRO AO REALIZAR TRANSFERENCIA/////////////////\n");
                        }
                        else
                        {
                            contaInvestimento1.Transferencia(contaInvestimento1, contaInvestimento2, transferencia);
                            Console.WriteLine("\n///////////////// Transferencia Realizada com Sucesso /////////////////");
                            contaInvestimento1.ExibirDadosBancarios();
                            contaInvestimento1.ExibirSaldo();
                            Console.WriteLine("--------------------------------------------------");
                            contaInvestimento2.ExibirDadosBancarios();
                            contaInvestimento2.ExibirSaldo();
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine($"Valor da Transferencia: {transferencia}");
                            Console.WriteLine("///////////////// Transferencia Realizada com Sucesso /////////////////\n");

                            listaExtrato.Add($"{DateTime.Now.ToString()} - Transferencia realizada do CPF Origem: {contaInvestimento1.CPF} para o CPF Destino: {contaInvestimento2.CPF} no valor de: R$ {transferencia}");
                        }
                        break;

                    case 7:
                        Console.Clear();
                        contaInvestimento1.ExibirDadosBancarios();
                        Console.WriteLine("\n///////////////// Alterar Dados Bancarios /////////////////");
                        Console.WriteLine("Esta Operacao ira alterar o Nome,  Endereco, Renda Mensal e Agencia da conta.");
                        Console.WriteLine("Caso tenha alguma informacao que nao deseje alterar, re-digite o seu valor original.");
                        Console.WriteLine("CPF e o Numero da Conta nao podem ser alterados.");
                        Console.WriteLine("///////////////// Alterar Dados Bancarios /////////////////\n");
                        Console.Write("Entre com o Nome: ");
                        string nomeAlterar = Console.ReadLine();
                        Console.Write("Entre com o Endereco: ");
                        string enderecoAlterar = Console.ReadLine();
                        Console.Write("Entre com a Renda Mensal: ");
                        decimal rendaMensalAlterar = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Entre com a Agencia: ");
                        int agenciaAlterar = Convert.ToInt32(Console.ReadLine());

                        if (agenciaAlterar < 1 || agenciaAlterar > 3)
                        {
                            Console.WriteLine("\n///////////////// ERRO AO ALTERAR DADOS BANCARIOS /////////////////");
                            Console.WriteLine("Erro: Numero da Agencia invalido.");
                            Console.WriteLine("Escolha a opcao de Alterar Dados Cadastrais novamente e entre com um numero de Agencia valido");
                            Console.WriteLine("///////////////// ERRO AO ALTERAR DADOS BANCARIOS /////////////////\n");
                        }
                        else
                        {
                            Console.Clear();
                            contaInvestimento1.AlterarDadosBancarios(nomeAlterar, enderecoAlterar, rendaMensalAlterar, agenciaAlterar);
                            Console.WriteLine("\n///////////////// Dados Bancarios Alterados com Sucesso! /////////////////");
                            contaInvestimento1.ExibirDadosBancarios();
                            Console.WriteLine("///////////////// Dados Bancarios Alterados com Sucesso! /////////////////\n");
                        }

                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("\n///////////////// Lista de Contas Correntes /////////////////");
                        foreach (var ci in listaContaInvestimento)
                        {
                            ci.ExibirDadosBancarios();
                            ci.ExibirSaldo();
                            Console.WriteLine("--------------------------------------------------");
                        }
                        Console.WriteLine("///////////////// Lista de Contas Correntes /////////////////\n");
                        break;

                    case 9:
                        Console.Clear();
                        voltar = true;
                        break;

                    default:
                        break;
                }
            }
        }

        public static void ExibirMenuCI()
        {
            MenuPrincipal.ExibirDataAtual();
            Console.WriteLine("-------------------- Conta Investimento --------------------");
            Console.WriteLine("Entre com a operacao desejada: \n");

            Console.WriteLine("[1] - Criar conta");
            Console.WriteLine("[2] - Saque");
            Console.WriteLine("[3] - Deposito");
            Console.WriteLine("[4] - Saldo");
            Console.WriteLine("[5] - Extrato");
            Console.WriteLine("[6] - Transferencia");
            Console.WriteLine("[7] - Alterar Dados Cadastrais");
            Console.WriteLine("[8] - Relatorio Geral");
            Console.WriteLine("[9] - Voltar");

            Console.WriteLine("-------------------- DEVinBank --------------------");
            Console.Write("\nValor inserido: ");
        }
    }
}
