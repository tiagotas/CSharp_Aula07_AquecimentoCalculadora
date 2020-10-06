using System;

namespace Aula07_AquecimentoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça uma calculadora que receba dois numeros e em seguida peça ao usuário
             * qual operação ele quer realizar: Adição, Subtração, Divisão e Multiplicação.
             * Em seguida, mostre o resultado da operação.
             */
            double primeiro_numero, segundo_numero, resultado = 0;
            int operacao;

            Console.WriteLine("Bem-vindo a Calculatron");
            
            Console.WriteLine("Informe o primero número: ");
            primeiro_numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            segundo_numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecione a operação conforme a lista:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            operacao = Convert.ToInt32(Console.ReadLine());

            if(operacao == 1)
            {
                resultado = primeiro_numero + segundo_numero;
            } else if(operacao == 2)
            {
                resultado = primeiro_numero - segundo_numero;
            } else if(operacao == 3)
            {
                resultado = primeiro_numero / segundo_numero;
            } else if(operacao == 4)
            {
                resultado = primeiro_numero * segundo_numero;
            } else
            {
                Console.WriteLine("Opção inválida");
            }

            Console.WriteLine("O resultado é {0}", resultado);
        }
    }
}
