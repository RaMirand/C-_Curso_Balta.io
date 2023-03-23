using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Abrir Arquivo;");
            Console.WriteLine("2 - Criar Novo Arquivo;");
            Console.WriteLine("0 - Sair;");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: EditFile(); break;
                default: Menu(); break;
            }
        }

        static void OpenFile() 
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void EditFile() 
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC P/ SAIR)");
            Console.WriteLine("-------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            SaveFile(text);
           
        }


        static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("Defina o caminho em que o arquivo de texto será salvo.");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Menu();
        }
    }
}

