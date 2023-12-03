using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04_While_Jogo_da_Forca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro que não seja negativo: ");
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.Write("Por favor, insira um número inteiro não negativo válido: ");
            }

            int fatorial = 1;
            int i = 1;

            do
            {
                fatorial *= i;
                i++;
            } while (i <= numero);

            Console.WriteLine($"O fatorial de {numero} é {fatorial}");

            Console.ReadKey();
        }
    }
}
    