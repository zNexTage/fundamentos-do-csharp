using System;
using System.Text;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManipulateStringBuilder();
        }

        static void GuildClass()
        {
            //var id = Guid.NewGuid();

            var id = new Guid("3de4205c-eee5-4ed6-91fc-5eab5c8730d0");
            Console.WriteLine(id);
        }

        static void StringInterpolation()
        {
            var price = 10.2;
            //var text = "O preço do produto é " + price;
            //var text = string.Format("O preço do produto é {0} na promoção.", price);
            var text = $@"O preço do produto é: {price} 
            na promoção";


            Console.WriteLine(text);
        }
        
        static void CompareString()
        {
            var texto = "Esse texto é um teste";
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
        }

        static void StartsEndsWith()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("Teste"));

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("xpto"));
        }
    
        static void Equals()
        {
            var texto = "Esse texto é um teste";

            Console.WriteLine(texto.Equals("Esse texto é um teste"));
            Console.WriteLine(texto.Equals("esse texto é um teste"));
            Console.WriteLine(texto.Equals("esse texto é um teste", StringComparison.OrdinalIgnoreCase));
        }

        static void StringIndex()
        {
            var texto = "Esse texto é um teste";

            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.IndexOf("um"));

            Console.WriteLine(texto.LastIndexOf("s"));
        }

        static void AditionalMethods()
        {
            var texto = "Esse texto é um teste";

            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Insert(5, "Teste")); //Insere um texto em uma determinada posição
            Console.WriteLine(texto.Remove(5, 5)); //Atráves dos indices informados, é removido os caracteres.
            Console.WriteLine(texto.Length); 
        }

        static void ManipulateString()
        {
            var texto = " Esse texto é um teste ";

            Console.WriteLine(texto.Replace("Esse", "isto"));
            Console.WriteLine(texto.Replace("e", "x"));

            var splited = texto.Split(" ");

            Console.WriteLine(splited[0]);
            Console.WriteLine(splited[1]);
            Console.WriteLine(splited[2]);
            Console.WriteLine(splited[3]);

            var result = texto.Substring(5, 5);
            Console.WriteLine(result);

            Console.WriteLine(texto.Trim());
        }

        static void ManipulateStringBuilder()
        {
            var texto = new StringBuilder();

            texto.Append("Esse texto é um teste");
            texto.Append("é um teste");
            texto.Append("Esse texto");
            texto.Append("alo mundo");

            Console.WriteLine(texto);
        }
    }
}


