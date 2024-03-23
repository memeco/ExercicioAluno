using System;

namespace ExercicioAluno
{
    public class Program
    {
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

            // Criação de um novo aluno
            Aluno aluno = new Aluno(nomeAluno, notaPrimeiroTrimestre, notaSegundoTrimestre, notaTerceiroTrimestre);

            // Exibição dos dados do aluno
            Console.WriteLine("Nome: {0}", aluno.ObterNome());
            Console.WriteLine("Nota do Primeiro Trimestre: {0}", aluno.ObterNotaPrimeiroTrimestre().ToString("F2"));
            Console.WriteLine("Nota do Segundo Trimestre: {0}", aluno.ObterNotaSegundoTrimestre().ToString("F2"));
            Console.WriteLine("Nota do Terceiro Trimestre: {0}", aluno.ObterNotaTerceiroTrimestre().ToString("F2"));
            Console.WriteLine("Média Final: {0}", aluno.ObterMediaFinal());
            Console.WriteLine("Situação: {0}", aluno.ObterSituacao());
        }

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
    }
}
