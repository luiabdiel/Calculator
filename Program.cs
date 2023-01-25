using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] arg)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------------");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());


            Console.WriteLine("");

            float result = v1 + v2;
            Console.WriteLine($"Resultado da soma: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 - v2;
            Console.WriteLine($"Resultado da subtração: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 / v2;
            Console.WriteLine($"Resultado da divisão é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 * v2;
            Console.WriteLine($"Resultado da multiplicação é: {result}");
            Console.ReadKey();
            Menu();
        }
    }
}