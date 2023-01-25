using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float secondValue = float.Parse(Console.ReadLine());


            Console.WriteLine("");

            float result = firstValue + secondValue;
            Console.WriteLine($"Resultado: {result}");
        }
    }
}