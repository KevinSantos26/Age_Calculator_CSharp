using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;



            Console.Write("Digite o ano atual: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque seu ano de nascimento: ");
            b = Convert.ToDouble(Console.ReadLine());

            c = a - b;
            Console.WriteLine("Sua idade é: " + c);

            Console.ReadKey();

        }
    }
}
