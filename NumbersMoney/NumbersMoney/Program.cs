using System;
using System.Globalization;

namespace NumbersMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MoneyTipes();

            //FormatMoney();

            MathMethods();

            Console.ReadKey();
        }

        static void FormatMoney()
        {
            decimal value = 10.25m;

            //Console.WriteLine(value.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR"))); //Formato de número
            //Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //Formato de dinheiro
            Console.WriteLine(value.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR"))); //Formato de calculadora

        }

        static void MathMethods()
        {
            var value = 1054.24;
            //Console.WriteLine(Math.Round(10.54)); //Arredonda 
            //Console.WriteLine(Math.Ceiling(value)); //Arredonda pra cima
            Console.WriteLine(Math.Floor(value)); //Arredonda pra baixo
        }

        static void MoneyTipes()
        {
            // Tipos para moeda: float e decimal
            decimal value = 10.25m;

            Console.WriteLine(value);            
        }
    }
}
