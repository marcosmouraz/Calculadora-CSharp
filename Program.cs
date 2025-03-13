using System; // Importa a biblioteca System, que contém funcionalidades básicas do C#

namespace Calculator // Define um namespace chamado "Calculator". Namespaces ajudam a organizar o código.
{
    class Program // Declara a classe "Program". Em C#, toda aplicação precisa ter pelo menos uma classe.
    {
        static void Main(string[] args) // Método principal da aplicação. É o ponto de entrada do programa.
        {
            Menu(); // Chama o método "Menu", que exibe as opções da calculadora.
        }

        static void Menu() // Método que exibe o menu de opções para o usuário.
        {
            Console.Clear(); // Limpa o console antes de exibir o menu.

            // Exibe as opções para o usuário escolher
            Console.WriteLine("Olá, escolha as opções!");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------------"); 

            Console.WriteLine("Selecione uma opção:");

            // Captura a escolha do usuário e converte para o tipo "short" (número inteiro pequeno)
            short res = short.Parse(Console.ReadLine());

            // Usa um "switch" para executar a opção escolhida pelo usuário
            switch (res)
            {
                case 1: Soma(); break; // Se o usuário digitar 1, chama o método "Soma".
                case 2: Subtracao(); break; // Se o usuário digitar 2, chama o método "Subtracao".
                case 3: Divisao(); break; // Se o usuário digitar 3, chama o método "Divisao".
                case 4: Multiplicacao(); break; // Se o usuário digitar 4, chama o método "Multiplicacao".
                case 5:
                    Console.WriteLine("Obrigado por utilizar a calculadora!"); // Mensagem de despedida.
                    Console.ReadKey(); // Aguarda o usuário pressionar qualquer tecla antes de sair.
                    System.Environment.Exit(0); // Encerra a execução do programa.
                    break;

                default:
                    Menu(); // Se o usuário digitar uma opção inválida, chama o menu novamente.
                    break;
            }
        }
    }
}

static void Soma() // Método que realiza a operação que o usuario escolher, nesse caso soma.
{
    Console.Clear(); // Limpa a tela do console para manter a interface organizada

    Console.WriteLine("Primeiro valor: "); // Exibe uma mensagem pedindo o primeiro número
    float v1 = float.Parse(Console.ReadLine()); // Lê a entrada do usuário, converte para float e armazena na variável v1

    Console.WriteLine("Segundo valor: "); // Exibe uma mensagem pedindo o segundo número
    float v2 = float.Parse(Console.ReadLine()); // Lê a entrada do usuário, converte para float e armazena na variável v2

    Console.WriteLine(""); // Pula uma linha para organizar melhor a saída

    float resultado = v1 + v2; // Realiza a soma dos dois valores e armazena o resultado na variável "resultado"
    Console.WriteLine($"O resultado da soma é: {resultado}"); // Exibe o resultado da operação na tela

    Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de continuar
    Menu(); // Retorna ao menu principal para permitir novas operações
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 / v2;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    Console.ReadKey();
    Menu();
}
    }
}