using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //GuidExample();
            //Interpolation();
            //CompararTexto();
            StartsEndWith();
        }

        // GUID
        static void GuidExample()
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id);
        }

        // Interpolação de Strings.
        static void Interpolation()
        {
            var price = 10.2;
            var texto = "O preço do produto é " + price + " apenas na promoção.";
            var texto1 = string.Format("O preço do produto é {0} apenas na promoção.", price);
            var texto2 = $"O preço do produto é {price} apenas na promoção.";
            var texto3 = $"O preço do produto é {price} \napenas na promoção.";
            var texto4 = $@"O preço do produto é {price}
apenas na promoção.";

            Console.WriteLine(texto);
            Console.WriteLine(texto1);
            Console.WriteLine(texto2);
            Console.WriteLine(texto3);
            Console.WriteLine(texto4);
         
        }

        // Comparando Strings.
        static void CompararTexto()
        {
            var texto = "Testando";

            // 0 = True / 1 = False
            Console.WriteLine(texto.CompareTo("Testando"));

            // Verifica se a string contém determinado texto.
            Console.WriteLine(texto.Contains("Test"));

            // Ignore o case sensitive, por exemplo, se o texto de comparação está em letras minuscúlas.
            Console.WriteLine(texto.Contains("test", StringComparison.OrdinalIgnoreCase));

            // Comparação inválida, vai dar erro. Comparação com objeto inválido.
            Console.WriteLine(texto.Contains(null));

        }

        static void StartsEndWith()
        {
            var texto = "Este texto é um teste.";

            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texto"));
        }
    }
}

