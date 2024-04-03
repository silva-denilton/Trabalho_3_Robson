using Atividades_Robson_3;
using System;
using System.Globalization;

namespace Atividade_Robson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf, nome, sobrenome;
            Console.WriteLine("Digite o nome do empregado: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do empregado: ");
            sobrenome = Console.ReadLine(); 
            Console.WriteLine("Digite o cpf do empregado: ");  
            cpf = Console.ReadLine();
            int tipo;

   


            do
            {
                Console.WriteLine("Escolha umas das opções para o empregado: ");
                Console.WriteLine("1 assalariado");
                Console.WriteLine("2 comissionado");
                Console.WriteLine("3 horista");
                Console.WriteLine("0 para finalizar");
                tipo = int.Parse(Console.ReadLine());
                if (tipo == 1)
                {
                    Assalariado _assalariado= new Assalariado();
                    _assalariado.Nome = nome;
                    _assalariado.sobrenome = sobrenome;
                    _assalariado.cpf = cpf;
                    Console.WriteLine("Digite o salario do empregado: ");
                    _assalariado.salario = double.Parse(Console.ReadLine());
                    Console.WriteLine(_assalariado.Vencimento());
                }
                else if (tipo == 2)
                {
                    Comissionado _comissionado = new Comissionado();
                    _comissionado.Nome = nome;
                    _comissionado.sobrenome = sobrenome;
                    _comissionado.cpf = cpf;
                    Console.WriteLine("Digite o total de vendas: ");
                    _comissionado.totalvenda = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a comissão do empregado: ");
                    _comissionado.totalComissao = double.Parse(Console.ReadLine());
                    Console.WriteLine(_comissionado.Vencimento());
                }
                else if (tipo == 3)
                {
                   Horista _horista = new Horista();
                    _horista.Nome = nome;
                    _horista.sobrenome = sobrenome;
                    _horista.cpf = cpf;
                    Console.WriteLine("Digite a quantidade de horas trablhadas: ");
                    _horista.horastrabalhadas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor por hora: ");
                    _horista.precoHora = double.Parse(Console.ReadLine());
                    Console.WriteLine(_horista.Vencimento() );
                    
                }            
                Console.WriteLine();
            } while (tipo == 0);

        }
    }
}