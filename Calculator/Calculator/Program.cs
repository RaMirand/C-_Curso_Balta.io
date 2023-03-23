// See https://aka.ms/new-console-template for more information
// Limpa o console antes de rodar o código.

//Limpa o console ao iniciar a aplicação. Não quero que limpe a cada operação para manter o histórico.
Console.Clear();
Menu();

static void Menu()
{
    Console.WriteLine("Qual operação desejada?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair do Aplicativo");

    Console.WriteLine("------------");
    Console.WriteLine("Selecione uma opção: ");
    short operacao = short.Parse(Console.ReadLine());

    switch (operacao)
    {
        case 1: Sum(); break;
        case 2: Subtract(); break;
        case 3: Multiply(); break;
        case 4: Divided(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Sum()
    {
    // Realiza o procedimento de soma da calculadora.
    // Solicita o primeiro valor da operação.
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    // Solicita o segundo valor da operação.
    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    // Mostra o resultado para o usuário.
    float resultado = valor1 + valor2;
    Console.WriteLine("");
    Console.WriteLine($"O resultado da soma é {resultado}");
    Console.WriteLine("-------------");
    
    Menu();
}

static void Subtract()
{
    // Realiza o procedimento de subtração da calculadora.
    // Solicita o primeiro valor da operação.
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    // Solicita o segundo valor da operação.
    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 - valor2;
    Console.WriteLine("");
    Console.WriteLine($"O resultado da subtração é {resultado}");
    Console.WriteLine("-------------");

    Menu();
}

static void Multiply()
{
    // Realiza o procedimento de subtração da calculadora.
    // Solicita o primeiro valor da operação.
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    // Solicita o segundo valor da operação.
    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 * valor2;
    Console.WriteLine("");
    Console.WriteLine($"O resultado da multiplicação é {resultado}");
    Console.WriteLine("-------------");

    Menu();
}

static void Divided()
{
    // Realiza o procedimento de subtração da calculadora.
    // Solicita o primeiro valor da operação.
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    // Solicita o segundo valor da operação.
    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 / valor2;
    Console.WriteLine("");
    Console.WriteLine($"O resultado da divisão é {resultado}");
    Console.WriteLine("-------------");

    Menu();
}
