using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Olá, bem vindo ao nosso app de calculos.");
            System.Console.WriteLine("Digite o primeiro valor");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação desejada: \r\n + = Soma \r\n - = Subtração \r\n x = Multiplicação \r\n % = divisão.");
            string operacao = Console.ReadLine();
            
            System.Console.WriteLine("Digite um segundo valor.");
            float valor2 = float.Parse(Console.ReadLine());

            if(operacao == "+"){
                Console.WriteLine("O resultado da operação é: " + soma(valor1,valor1));
            } else if(operacao == "-") {
                Console.WriteLine("O resultado da operação é: " + subtracao(valor1,valor1));
            } else if(operacao == "x"){
                Console.WriteLine("O resultado da operação é: " + multiple(valor1,valor2));
            } else if(operacao == "%"){
                Console.WriteLine("O resultado da operação é: " + divid(valor1,valor2));
            } else {
                Console.WriteLine("Operação invalida");
            }

            float soma(float x, float y){
                return x + y;
            }

            float subtracao(float x, float y){
                return x - y;
            }

            float multiple(float x, float y){
                return x * y;
            }

            float divid(float x, float y){
                return x / y;
            }
        }
    }
}