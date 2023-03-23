using System;
using System.Text;

namespace Strings_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //StartEndWith();
            //Equals();
            //Indices();
            //MetodosAdicionais();
            //ManipulandoStrings();
            ConstrucaoString();

        }

        static void StartEndWith()
        {

            var texto = "Este texto é um teste";

            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("teste "));
            Console.WriteLine(texto.EndsWith("Este"));

        }

        static void Equals()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("Este texto é um teste."));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));

        }

        static void Indices()
        {

            var texto = "Este texto é um teste";

            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("t"));

        }

        static void MetodosAdicionais()
        {

            var texto = "Este texto é um teste.";

            // Letra minúscula.
            Console.WriteLine(texto.ToLower());
            // Letra maiúscula.
            Console.WriteLine(texto.ToUpper());
            // Insere algum carácter ou string na string.
            Console.WriteLine(texto.Insert(11, "aqui "));
            // Remove um número determinado de caracteres da string (Inicia em, número de caracteres).
            Console.WriteLine(texto.Remove(12, 3));
            // Número de caracteres da strings.
            Console.WriteLine(texto.Length);

        }

        static void ManipulandoStrings()
        {

            // Troca determinada parte da string por outra coisa.
            var texto = "Este texto é um teste.";
            Console.WriteLine(texto.Replace("Este", "O"));

            // Divide a string usando um delimitador, no caso do exemplo o espaço.
            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);

            // Pega os 5 caracteres após o indice 5 da string. 
            var resultado = texto.Substring(5, 5);
            var resultado2 = texto.Substring(5, texto.LastIndexOf("o"));
            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);

            // Remove os espaços do começo e final de uma string.
            var texto2 = " Este texto é um teste. ";
            Console.WriteLine(texto2.Trim());

        }

        static void ConstrucaoString()
        {

            // String builder não é uma string, portanto é necessário usar o .ToString ao final.
            var texto = new StringBuilder();
            texto.Append("Este texto ");
            texto.Append("é um ");
            texto.Append("teste.");

            texto.ToString();
            
            Console.WriteLine(texto);


        }
    }
}
