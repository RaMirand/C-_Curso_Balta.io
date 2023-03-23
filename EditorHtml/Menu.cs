using System;

namespace EditorHtml
{

    public static class Menu
    {

        public static void Show()
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {

            DrawHorizontal();
            DrawVertical();
            DrawHorizontal();
            WriteOptions();

        }

        public static void DrawHorizontal()
        {
            Console.Write("+");
            for (int i = 0; i <= 35; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawVertical()
        {
            for (int l = 0; l <= 10; l++)
            {
                Console.Write("|");
                for (int i = 0; i <= 35; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }

        public static void HandleMenuOption(short option)
        {

            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

    }
}