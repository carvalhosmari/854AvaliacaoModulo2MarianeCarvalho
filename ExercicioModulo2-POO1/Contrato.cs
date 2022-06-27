using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioModulo2_POO1
{
    public class Contrato
    {
        public Guid IdContrato { get { return Guid.NewGuid(); } private set { } }
        public string Contratante { get; set; }
        public decimal ValorContrato { get; set; }
        public int PrazoContrato { get; set; }
        

        public virtual decimal CalculaPrestacao()
        {
            return ValorContrato / PrazoContrato;            
        }

        public virtual void ExibirInfo()
        {
            Console.Clear();

            Console.WriteLine($@"
===== DETALHES DO CONTRATO =====

Contratante: {Contratante}
Valor: R$ {ValorContrato:F2}
Prazo: {PrazoContrato} mês(es)
Valor da prestação: R$ {CalculaPrestacao():F2}");
        }

    }
}
