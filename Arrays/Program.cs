using System;

namespace DotNetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista();
            //PercorreArray();
            PercorrerArray2();
        }

        static void Lista()
        {
            Console.Clear();

            var meuArray = new int[5];
            meuArray[0] = 12;

            Console.WriteLine(meuArray[0]);
        }

        static void PercorreArray()
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };

            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }
        }

        static void PercorrerArray2()
        {
            Console.Clear();

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 2579, Nome = "André" };

            funcionarios[1] = new Funcionario() { Id = 1509, Nome = "Ricardo" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
                Console.WriteLine("");
            }
        }

        public struct Funcionario
        {
            public int Id { get; set; }

            public string Nome { get; set; }
        }
    }
}