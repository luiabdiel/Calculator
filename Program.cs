using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] arg)
        {
            // Sum();
            // Subtraction();
            Division();
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
        }

        static void Division()
        {
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 / v2;
            Console.WriteLine($"Resultado da divisão é: {result}");
            Console.ReadKey();
        }
    }
}