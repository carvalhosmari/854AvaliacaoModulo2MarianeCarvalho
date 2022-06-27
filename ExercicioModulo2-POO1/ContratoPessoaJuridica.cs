using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioModulo2_POO1
{
    internal class ContratoPessoaJuridica : Contrato
    {
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }

        public override decimal CalculaPrestacao()
        {
            return base.CalculaPrestacao() + 3;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"CNPJ: {Cnpj}");
            Console.WriteLine($"Inscrição Estadual: {InscricaoEstadual}");
        }
    }
}
