using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Robson_3
{
    internal class Horista : Empregado
    {
        public double horastrabalhadas, total;

        public double precoHora{ get; set; }

        public override double Vencimento()
        {
          return precoHora * horastrabalhadas;
        }

        
    }
}