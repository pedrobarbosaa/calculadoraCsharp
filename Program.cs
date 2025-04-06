using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("=== Calculadora ===");
            Console.WriteLine("=== Escolha um operação ===");
            Console.WriteLine("1 - somar");
            Console.WriteLine("2 - subtrair");
            Console.WriteLine("3 - multiplicar");
            Console.WriteLine("4 - dividir");
            Console.WriteLine("0 - sair");

            string opcao = Console.ReadLine();

            if (opcao == "0")
            {
                continuar = false;
                Console.WriteLine("Encerrando...");
                break;
            }

            Console.WriteLine("Digite o primeiro Número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo Número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch(opcao){
                case "1": 
                    resultado = Somar(numero1, numero2);
                    break;
                case "2":
                    resultado = Subtrair(numero1, numero2);
                    break;
                case "3":
                    resultado = Multiplicar(numero1, numero2);
                    break;
                case "4":
                    resultado = Dividir(numero1, numero2);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    continue;
            }

            Console.WriteLine("Resultado da operação: " + resultado);
            continue;
        }

        static double Somar(double a, double b) => a + b;
        static double Subtrair(double a, double b) => a - b;
        static double Multiplicar(double a, double b) => a * b;
        static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: divisão por zero");
                return 0;
            }
            return a / b;
        }; 
    }
}