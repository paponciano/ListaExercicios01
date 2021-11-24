using System;

namespace Exercicio03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor de produto: ");
            double valor01 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite agora o segundo valor de produto: ");
            double valor02 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor de produto: ");
            double valor03 = Convert.ToDouble(Console.ReadLine());

            if (valor01 < valor02 && valor01 < valor03)
            {
                Console.WriteLine("O Produto 01 deve ser comprado");
            }
            else if (valor02 < valor03)
            {
                Console.WriteLine("O Produto 02 deve ser comprado");
            }
            else
            {
                Console.WriteLine("O Produto 03 deve ser comprado");
            }
        }
    }
}