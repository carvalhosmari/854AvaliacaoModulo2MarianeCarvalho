using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioModulo2_POO1
{
    public class ContratoPessoaFisica : Contrato
    {
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; private set; }
        
        public int CalculaIdade()
        {
            if (DataNascimento.DayOfYear <= DateTime.Now.DayOfYear)
            {
                return DateTime.Now.Year - DataNascimento.Year;
            }
            else
            {
                return DateTime.Now.Year - DataNascimento.Year - 1;
            }
        }
        public override decimal CalculaPrestacao()
        {
            var valorAdicional = 0;

            if (CalculaIdade() <= 30)
            {
                valorAdicional = 1;
            }
            else if (CalculaIdade() <= 40)
            {
                valorAdicional = 2;
            }
            else if (CalculaIdade() <= 50)
            {
                valorAdicional = 3;
            }
            else
            {
                valorAdicional = 4;
            }

            return base.CalculaPrestacao() + valorAdicional;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Idade: {CalculaIdade()} anos");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"ID do contrato: {IdContrato}");
        }
    }
}
