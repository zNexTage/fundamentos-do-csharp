using System;
using System.Threading;

namespace ErrorHandler
{
    internal class Program
    {
        public class TheException : Exception
        {
            public DateTime WhenOccurred { get; set; }
            public string Message { get; }

            public TheException(DateTime whenOccurred)
            {
                WhenOccurred = whenOccurred;
                this.Message = "O sistema vai explodir em alguns minutos...";
            }
        }

        static void Main(string[] args)
        {
            //IndexError();
            try
            {
                Register(null);
            }
            catch(ArgumentNullException err)
            {
                Console.WriteLine("Falha ao cadastrar o texto");
                Console.WriteLine(err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            try
            {
                ThrowTheException();
            }
            catch (TheException err)
            {
                Console.WriteLine(err.Message);
                Console.WriteLine(err.WhenOccurred);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            finally
            {
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("O sistema vai explodir em: ");
                for(int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(300);
                }

                Environment.Exit(0);
            }


            Console.ReadKey();
        }

        static void IndexError()
        {
            try
            {
                var arr = new int[3];

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                Console.WriteLine("Erro inesperado");
            }
        }

        static void Register(string text)
        {

            if (String.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Precisa informar o valor de text");
            }

            Console.WriteLine("Cadastro feito");
        }
    
        static void ThrowTheException()
        {
            throw new TheException(DateTime.Now);
        }
    }
}
