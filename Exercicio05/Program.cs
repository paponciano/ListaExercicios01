using System;

namespace Exercicio05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu valor de hora:");
            double valorHora = Convert.ToDouble(Console.ReadLine());
            Console
                .WriteLine("Digite a quantidade de horas trabalhadas no mês:");
            int quantidadeHoras = Convert.ToInt32(Console.ReadLine());
            double salarioBruto = valorHora * quantidadeHoras;
            double descontoSindicato = salarioBruto * 0.03;
            double descontoINSS = salarioBruto * 0.11;
            double fgts = salarioBruto * 0.08;
            double descontoIR = 0;
            double percentualDescontoIR = 0;

            if (salarioBruto > 2000 && salarioBruto <= 5000)
                percentualDescontoIR = 0.05;
            else if (salarioBruto <= 7500)
                percentualDescontoIR = 0.1;
            else if (salarioBruto > 7500) percentualDescontoIR = 0.2;

            if (percentualDescontoIR != 0)
                descontoIR = salarioBruto * percentualDescontoIR;

            double salarioLiquido = salarioBruto - descontoSindicato - descontoINSS - descontoIR;

            Console.WriteLine($"Salário Bruto: ({valorHora} * {quantidadeHoras}): R$ {string.Format("{0:0.00}", salarioBruto)}\n" +
            $"(-) SINDICATO (3%) : {string.Format("{0:0.00}", descontoSindicato)}\n" +
            $"(-) INSS (11%) : {string.Format("{0:0.00}", descontoINSS)}\n" +
            $"(-) IR ({percentualDescontoIR * 100}%) : {string.Format("{0:0.00}", descontoIR)}\n" +
            $"FGTS (8%) : {string.Format("{0:0.00}", fgts)}\n" +
            $"Salário Liquido : {string.Format("{0:0.00}", salarioLiquido)}");
        }
    }
}
