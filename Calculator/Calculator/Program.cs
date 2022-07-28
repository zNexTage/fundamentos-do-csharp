using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }            
        }     
        
        static void ShowOptions()
        {
            Console.Clear();

            Console.WriteLine("O que voce deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------------");
        }

        static void Menu()
        {
            short option;

            do
            {
                ShowOptions();
                Console.WriteLine("Seleciona uma opção: ");
                option = short.Parse(Console.ReadLine());

                if (option == 5)
                {
                    Console.WriteLine("Tchau!");
                    System.Environment.Exit(0);
                    return;
                }

            } while (option > 5 || option <= 0);

            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float firstValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float secondValue = Convert.ToSingle(Console.ReadLine());

            OperationFactory operationFactory = new OperationFactory();

            IOperation operation = operationFactory.Create(option);

            float result = operation.Calculate(firstValue, secondValue);

            Console.WriteLine($"O resultado da operação é: {result}");            

            Console.ReadKey();
        }
    }
}

