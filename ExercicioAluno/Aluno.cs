using System;

namespace ExercicioAluno
{
    public class Aluno
    {
        // Atributos da classe
        public string Nome { get; set; }
        public double NotaPrimeiroTrimestre { get; set; }
        public double NotaSegundoTrimestre { get; set; }
        public double NotaTerceiroTrimestre { get; set; }

        // Construtor da classe
        public Aluno(string nome, double notaPrimeiroTrimestre, double notaSegundoTrimestre, double notaTerceiroTrimestre)
        {
            Nome = nome;
            NotaPrimeiroTrimestre = notaPrimeiroTrimestre;
            NotaSegundoTrimestre = notaSegundoTrimestre;
            NotaTerceiroTrimestre = notaTerceiroTrimestre;
        }

        // Métodos da classe
        public double CalcularMedia()
        {
            return (NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre) / 3;
        }

        public bool EstaAprovado()
        {
            return CalcularMedia() >= 6;
        }

        public string ObterSituacao()
        {
            if (EstaAprovado())
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";
            }
        }

        public double PontosFaltantes()
        {
            return 6 - CalcularMedia();
        }
    }
}
