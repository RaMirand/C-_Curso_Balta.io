using System;

namespace Exceptions
{
    class Program
    {
        static void Main(String[] args)
        {

            var arr = new int[3];

            try
            {
                //for (var index = 0; index < 10; index++)
                //{
                //    // System.IndexOutOfRangeException
                //    Console.WriteLine(arr[index]);
                //}

                Cadastrar("");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista.");
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar texto.");
            }

            catch (MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Exceção customizada");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops! Algo deu errado.");
            }
            
            finally
            {
                Console.WriteLine("Chegou ao fim.");
            }
        }

        static void Cadastrar(string texto)
        {
            if(string.IsNullOrEmpty(texto))
                //throw new ArgumentNullException("O texto não pode ser nulo ou vazio.");
                throw new MinhaException(DateTime.Now);
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}