using System;
using System.Collections.Generic;
using System.Threading;

namespace ExercicioModulo2_POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contratosPF = new List<ContratoPessoaFisica>();
            var contratosPJ = new List<ContratoPessoaJuridica>();

            ContratoPessoaFisica GeradorContratoPF()
            {
                Console.Clear();

                ContratoPessoaFisica contratoPessoaFisica = new ContratoPessoaFisica();

                Console.WriteLine("Digite o nome do contratante:");
                contratoPessoaFisica.Contratante = Validacoes.InputNulo();

                Console.WriteLine();

                Console.WriteLine("Digite o CPF:");
                contratoPessoaFisica.Cpf = Validacoes.ValidaCPF();

                Console.WriteLine();

                Console.WriteLine("Digite a data de nascimento (dd/mm/aaaa):");
                contratoPessoaFisica.DataNascimento = Validacoes.ValidaData();

                Console.WriteLine();

                Console.WriteLine("Qual o valor do contrato?");
                contratoPessoaFisica.ValorContrato = Validacoes.ValidaValor();

                Console.WriteLine();

                Console.WriteLine("Qual a duração do contrato, em meses?");
                contratoPessoaFisica.PrazoContrato = Validacoes.ValidaPrazo();

                Console.Clear();

                contratoPessoaFisica.ExibirInfo();

                return contratoPessoaFisica;

            }

            ContratoPessoaJuridica GeradorContratoPJ()
            {
                Console.Clear();

                ContratoPessoaJuridica contratoPessoaJuridica = new ContratoPessoaJuridica();

                Console.WriteLine("Digite o nome do contratante:");
                contratoPessoaJuridica.Contratante = Validacoes.InputNulo();

                Console.WriteLine();

                Console.WriteLine("Digite o CNPJ:");
                contratoPessoaJuridica.Cnpj = Validacoes.ValidaCNPJ();

                Console.WriteLine();

                Console.WriteLine("Digite a Inscrição Estadual:");
                contratoPessoaJuridica.InscricaoEstadual = Validacoes.ValidaIE();

                Console.WriteLine();

                Console.WriteLine("Qual o valor do contrato?");
                contratoPessoaJuridica.ValorContrato = Validacoes.ValidaValor();

                Console.WriteLine();

                Console.WriteLine("Qual a duração do contrato, em meses?");
                contratoPessoaJuridica.PrazoContrato = Validacoes.ValidaPrazo();

                Console.Clear();

                contratoPessoaJuridica.ExibirInfo();

                return contratoPessoaJuridica;

            }

            void ExibeContratos()
            {
                Console.Clear();
                Console.WriteLine("===== CONTRATOS CADASTRADOS =====\n");
                Console.WriteLine("Qual o segmento? Digite:\n1 - Pessoa Física\n2 - Pessoa Jurídica\n3 - Voltar ao menu principal");

                var opcaoUsuario = Validacoes.SeletorMenu();

                if (opcaoUsuario == 1)
                {
                    if (contratosPF.Count <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Ainda não há contratos cadastrados.");
                        Console.WriteLine("\nAperte qualquer tecla para retornar ao menu anterior..");
                        Console.ReadKey();
                        ExibeContratos();
                    }
                    else
                    {
                        Console.WriteLine();
                        foreach (var contratos in contratosPF)
                        {
                            Console.WriteLine(contratos.Contratante);
                        }

                        Console.WriteLine("\nAperte qualquer tecla para retornar ao menu anterior..");
                        Console.ReadKey();
                        ExibeContratos();
                    }
                }
                else if (opcaoUsuario == 2)
                {
                    if (contratosPJ.Count <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Ainda não há contratos cadastrados.");
                        Console.WriteLine("\nAperte qualquer tecla para retornar ao menu anterior..");
                        Console.ReadKey();
                        ExibeContratos();
                    }
                    else
                    {
                        Console.WriteLine();
                        foreach (var contratos in contratosPJ)
                        {
                            Console.WriteLine(contratos.Contratante);
                        }

                        Console.WriteLine("\nAperte qualquer tecla para retornar ao menu anterior..");
                        Console.ReadKey();
                        ExibeContratos();
                    }
                }
                else
                {
                    MenuPrincipal();
                }
            }

            void MenuPrincipal()
            {
                Console.Clear();
                Console.WriteLine("========== MSC FINANCEIRA ========== \n");
                Console.WriteLine("O que você gostaria de fazer? Digite:\n1 - Cadastrar novo contrato\n2 - Listar contratos cadastrados\n3 - Sair");

                var opcaoUsuario = Validacoes.SeletorMenu();

                if (opcaoUsuario == 1)
                {
                    CadastraContratos();
                }
                else if (opcaoUsuario == 2)
                {
                    ExibeContratos();
                }
                else
                {
                    Console.WriteLine("\nDigite '0' para encerrar a aplicação.");
                    Environment.Exit(0);
                }
            }

            void CadastraContratos()
            {
                Console.Clear();
                Console.WriteLine("===== CADASTRAR NOVO CONTRATO =====\n");
                Console.WriteLine("Qual o tipo de contrato? Digite:\n1 - Pessoa Física\n2 - Pessoa Jurídica\n3 - Retornar ao menu principal");

                var opcao = Validacoes.SeletorMenu();

                switch (opcao)
                {
                    case 1:
                        contratosPF.Add(GeradorContratoPF());
                        Console.WriteLine("\nContrato cadastrado com sucesso!\nAperte qualquer tecla para retornar ao menu principal..");
                        Console.ReadKey();
                        MenuPrincipal();
                        break;
                    case 2:
                        contratosPJ.Add(GeradorContratoPJ());
                        Console.WriteLine("\nContrato cadastrado com sucesso!\nAperte qualquer tecla para retornar ao menu principal..");
                        Console.ReadKey();
                        MenuPrincipal();
                        break;
                    case 3:
                        MenuPrincipal();
                        break;
                }
            }

            MenuPrincipal();

        }


    }
}
