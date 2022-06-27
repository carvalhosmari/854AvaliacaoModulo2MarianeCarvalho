using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioModulo2_POO1
{
    internal class Validacoes
    {
        public static string InputNulo()
        {
            var inputValido = false;
            var inputUsuario = "";

            while (!inputValido)
            {
                inputUsuario = Console.ReadLine();

                if (string.IsNullOrEmpty(inputUsuario))
                {
                    Console.WriteLine("Preenchimento obrigatório! Complete com a informação solicitada..");
                }
                else
                {
                    inputValido = true;
                }
            }

            return inputUsuario;
        }

        public static int SeletorMenu()
        {
            var inputValido = false;
            var seletorMenu = 0;

            while (!inputValido)
            {
                inputValido = (int.TryParse(Console.ReadLine(), out seletorMenu) && seletorMenu > 0 && seletorMenu <= 3);

                if (inputValido)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida! Digite 1, 2 ou 3.");
                }
            }

            return seletorMenu;
        }

        public static DateTime ValidaData()
        {
            var inputValido = false;
            var inputData = DateTime.MinValue;

            while (!inputValido)
            {
                inputValido = (DateTime.TryParse(InputNulo(), out inputData) && inputData < DateTime.Now);

                if (inputValido)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite uma data válida (dd/mm/aaaa)");
                }
            }

            return inputData;
        }

        public static decimal ValidaValor()
        {
            var inputValido = false;
            var inputUsuario = 0m;

            while (!inputValido)
            {
                inputValido = (decimal.TryParse(Console.ReadLine(), out inputUsuario) && inputUsuario > 0);

                if (inputValido)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor incorreto! Digite um valor valido..");
                }
            }

            return inputUsuario;
        }

        // Validador de prazo: contratos de parcelamento mínimo = 1x e no máximo 48x;
        public static int ValidaPrazo()
        {
            var inputValido = false;
            var inputPrazo = 0;

            while (!inputValido)
            {
                inputValido = (int.TryParse(Console.ReadLine(), out inputPrazo) && inputPrazo > 0 && inputPrazo <= 48);

                if (inputValido)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida! O contrato deve ter prazo mínimo de 1 e máximo de 48.");
                }
            }

            return inputPrazo;
        }

        public static string ValidaCPF()
        {

            var inputValido = false;
            var inputUsuario = "";

            while (!inputValido)
            {
                inputUsuario = Console.ReadLine();

                if (string.IsNullOrEmpty(inputUsuario))
                {
                    Console.WriteLine("Preenchimento obrigatório! Complete com a informação solicitada..");
                }
                else if (inputUsuario.Length < 11 || inputUsuario.Length > 11)
                {
                    Console.WriteLine("Formato inválido! CPF deve conter 11 dígitos, sem traço ou pontos..\nDigite novamente!");
                }
                else
                {
                    inputValido = true;
                }
            }

            return inputUsuario;
        }

        public static string ValidaCNPJ()
        {

            var inputValido = false;
            var inputUsuario = "";

            while (!inputValido)
            {
                inputUsuario = Console.ReadLine();

                if (string.IsNullOrEmpty(inputUsuario))
                {
                    Console.WriteLine("Preenchimento obrigatório! Complete com a informação solicitada..");
                }
                else if (inputUsuario.Length < 14 || inputUsuario.Length > 14)
                {
                    Console.WriteLine("Formato inválido! CNPJ deve conter 14 dígitos, sem traço ou pontos..\nDigite novamente!");
                }
                else
                {
                    inputValido = true;
                }
            }

            return inputUsuario;
        }

        public static string ValidaIE()
        {

            var inputValido = false;
            var inputUsuario = "";

            while (!inputValido)
            {
                inputUsuario = Console.ReadLine();

                if (string.IsNullOrEmpty(inputUsuario))
                {
                    Console.WriteLine("Preenchimento obrigatório! Complete com a informação solicitada..");
                }
                else if (inputUsuario.Length < 9 || inputUsuario.Length > 9)
                {
                    Console.WriteLine("Formato inválido! A Inscrição Estadual deve conter 9 dígitos, sem traço ou pontos..\nDigite novamente!");
                }
                else
                {
                    inputValido = true;
                }
            }

            return inputUsuario;
        }
    }
}
