using System;

namespace Exercicio06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console
                .WriteLine("Digite um número que corresponde ao dia da semana. (1 a 7)");
            int diaDaSemana = Convert.ToInt32(Console.ReadLine());

            switch (diaDaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Dia da semana inválido");
                    break;
            }
        }
    }
}
