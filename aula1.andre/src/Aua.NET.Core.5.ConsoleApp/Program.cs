using System;

namespace Aua.NET.Core._5.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Digite um número e pressione enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número e pressione enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma opção na lista: ");
            Console.WriteLine($"{Environment.NewLine}a - Somar");
            Console.WriteLine(String.Concat("\t", "s - Subtrair"));
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Sua opção: ");
            var option = Console.ReadLine();

            switch (option)
            {

                case "a":
                    {

                        Console.WriteLine("Seu Resultado: " + num1 + " + " + num2 + " = " + (num1 + num2));

                    }
                    break;

                case "s":
                    {

                        Console.WriteLine("Seu Resultado: " + num1 + " - " + num2 + " = " + (num1 - num2));

                    }

                    break;

                case "m":
                    {

                        Console.WriteLine("Seu Resultado: " + num1 + " * " + num2 + " = " + (num1 * num2));

                    }
                    break;

                case "d":
                    {

                        Console.WriteLine("Seu Resultado: " + num1 + " / " + num2 + " = " + (num1 / num2));

                    }
                    break;

            }

            Console.Write("Pressione qualquer tecla para fechar o aplicativo do console da Calculadora ...");
            Console.ReadKey();

        }
    }
}
