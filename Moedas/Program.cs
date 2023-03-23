using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            exibirMoeda();
            //convert();

        }

        static void exibirMoeda()
        {
            Console.Clear();

            decimal valor = 10536.25m;
            Console.WriteLine(valor);
            Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));
            // Formatador númerico. Padrão, exibe a info como um número.
            Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR")));
            // Formatador de moeda (currency) de acordo com a cultura informada.
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            // Formatação na potência de 10.
            Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("en-US")));
            // Especificador de precisão. Permite números negativos.
            Console.WriteLine(valor.ToString("F4", CultureInfo.CreateSpecificCulture("en-US")));
            // Formatação de porcentagem.
            Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("en-US")));

        }

        static void convert()
        {
            Console.Clear();

            decimal valor = 10311.43m;
            // Arredendo o valor.
            Console.WriteLine(Math.Round(valor));
            // Arredonda pra cima.
            Console.WriteLine(Math.Ceiling(valor));
            // Arredonda pra baixo.
            Console.WriteLine(Math.Floor(valor));

        }
    }
}