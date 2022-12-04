using System;
using System.Globalization;
namespace Licao_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4) Fazer um programa que leia o número de um funcionário, seu número de horas\n" +
                             "trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.\n" +
                             "Aseguir, mostre o número e o salário do funcionário, com duas casas decimais.");
            Console.WriteLine();

            int nf = 25;
            double hs = 100;
            double ph = 5.50;
            double sl = hs * ph;
            Console.WriteLine("Numero do fucionario e " + nf);
            Console.WriteLine("Salario e " + sl.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
            Console.WriteLine();
            int nf2 = 1;
            double hs2 = 200;
            double ph2 = 20.50;
            double sl2 = hs2 * ph2;
            Console.WriteLine("Numero do fucionario e " + nf2);
            Console.WriteLine("Salario e " + sl2.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
            Console.WriteLine();
            int nf3 = 6;
            double hs3 = 145;
            double ph3 = 15.55;
            double sl3 = hs3 * ph3;
            Console.WriteLine("Numero do fucionario e " + nf3);
            Console.WriteLine("Salario e " + sl3.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        }
    }
}
