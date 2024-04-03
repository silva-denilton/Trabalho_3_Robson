using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Robson_3
{
    internal class Comissionado : Empregado
    {
        public double totalvenda;
        public double totalComissao;


        public override double Vencimento()
        {
            return totalvenda + totalComissao;
        }

    }
}