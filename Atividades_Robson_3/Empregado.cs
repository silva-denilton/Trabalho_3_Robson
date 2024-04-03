using Atividade_Robson_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Robson_3
{
    public abstract class Empregado
    {
        public string Nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }

        public abstract double Vencimento();

    }
}