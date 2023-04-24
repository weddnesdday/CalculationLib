using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationLib;

namespace CalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 6;
            double b = 10;

            Console.WriteLine("Деление:" + Calculation.Divine(a, b));
            Console.WriteLine("Сложение:" + Calculation.Plus(a, b));
            Console.WriteLine("Разность:" + Calculation.Minus(a, b));
            Console.WriteLine("Умножение:" + Calculation.Multiply(a, b));

        }
    }
}
