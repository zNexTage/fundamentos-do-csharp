using System;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            

            bool isValidOption = false;

            do
            {
                Console.Clear();

                DrawScreen();

                short option = WriteOptions();

                isValidOption = HandleMenuOptions(option);
            } while (!isValidOption);            

            Console.ReadKey();
        }

        public static void DrawRow(int totalDash)
        {
            Console.Write("+");

            for (int i = 0; i < totalDash; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawColumn(int totalSpaces)
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i < totalSpaces; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static short WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=============");

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");

            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Opção: ");

            var option = short.Parse(Console.ReadLine());

            return option;
        }

        public static bool HandleMenuOptions(short option)
        {
            switch (option)
            {
                case (short)EOption.EDITOR:
                    {
                        Editor.Show();

                        return true;
                    }
                case (short)EOption.VIEW:
                    {
                        Console.WriteLine("View");

                        return true;
                    }
                case (short)EOption.EXIT:
                    {
                        Console.Clear();
                        Environment.Exit(0);

                        return true;
                    }
                default:
                    {
                        return false;
                    }

            }
        }

        public static void DrawScreen()
        {
            DrawRow(30);

            DrawColumn(30);

            DrawRow(30);
        }
    }
}
