using System;

namespace ExercicioAluno
{
    public class Program
    {
        // Função para ler um valor double do console
        static double LerDouble()
        {
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Valor inválido. Digite novamente: ");
            }
            return valor;
        }

        public static void Main(string[] args)
        {
            // Leitura do nome do aluno
            Console.WriteLine("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            // Leitura das notas
            Console.WriteLine("Digite a nota do primeiro trimestre: ");
            double notaPrimeiroTrimestre = LerDouble();

            Console.WriteLine("Digite a nota do segundo trimestre: ");
            double notaSegundoTrimestre = LerDouble();

            Console.WriteLine("Digite a nota do terceiro trimestre: ");
            double notaTerceiroTrimestre = LerDouble();

            // Cálculo da média final
            double mediaFinal = (notaPrimeiroTrimestre + notaSegundoTrimestre + notaTerceiroTrimestre) / 3;

            // Verificação de aprovação
            bool aprovado = mediaFinal >= 6;

            // Exibição dos resultados
            Console.WriteLine("Nome do aluno: {0}", nomeAluno);
            Console.WriteLine("Média final: {0}", mediaFinal.ToString("F2"));

            if (aprovado)
            {
                Console.WriteLine("Situação: APROVADO");
            }
            else
            {
                Console.WriteLine("Situação: REPROVADO");
                Console.WriteLine("Pontos faltantes: {0}", (6 - mediaFinal).ToString("F2"));
            }
        }
    }
}
