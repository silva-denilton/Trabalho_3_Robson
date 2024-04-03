using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Robson_3
{
    internal class Assalariado : Empregado
    {
        public double salario;
        public override double Vencimento()
        {
            return salario;
        }
    }
}