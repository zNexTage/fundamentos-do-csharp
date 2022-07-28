using System;
using System.IO;
using System.Text;

namespace TextEditor
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

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que voce deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar um novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    {
                        System.Environment.Exit(0);
                        return;
                    }
                case 1:
                    {
                        OpenFile();
                        break;
                    }
                case 2:
                    {
                        EditFile();
                        break;
                    }
            }
        }

        static void OpenFile() {
            Console.Clear();

            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using(StreamReader file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ReadKey();
        }

        static void EditFile()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------");

            StringBuilder text = new StringBuilder();

            do
            {
                text.Append(Console.ReadLine()); 
                text.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            SaveFile(text.ToString());
        }

        static void SaveFile(string text)
        {
            Console.Clear();

            Console.WriteLine("Qual caminho para salvar o arquivo?");
            string path = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo no caminho {path} com sucesso!");
            Console.ReadKey();
        }
    }
}
