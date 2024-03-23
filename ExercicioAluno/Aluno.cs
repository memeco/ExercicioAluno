using System;

namespace ExercicioAluno
{
    public class Aluno
    {
        // Atributos da classe
        private string _nome { get; set; }
        private double _notaPrimeiroTrimestre { get; set; }
        private double _notaSegundoTrimestre { get; set; }
        private double _notaTerceiroTrimestre { get; set; }

        // Construtor da classe
        public Aluno(string nome, double notaPrimeiroTrimestre, double notaSegundoTrimestre, double notaTerceiroTrimestre)
        {
            _nome = nome;
            _notaPrimeiroTrimestre = notaPrimeiroTrimestre;
            _notaSegundoTrimestre = notaSegundoTrimestre;
            _notaTerceiroTrimestre = notaTerceiroTrimestre;
        }

        // Métodos da classe
        public double CalcularMedia()
        {
            return (_notaPrimeiroTrimestre + _notaSegundoTrimestre + _notaTerceiroTrimestre) / 3;
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

        public string ObterMediaFinal()
        {
            return CalcularMedia().ToString("F2");
        }

        // Novo método para acessar a variável privada _nome (já existente)
        public string ObterNome()
        {
            return _nome;
        }

        // Novos métodos para acessar as notas
        public double ObterNotaPrimeiroTrimestre()
        {
            return _notaPrimeiroTrimestre;
        }

        public double ObterNotaSegundoTrimestre()
        {
            return _notaSegundoTrimestre;
        }

        public double ObterNotaTerceiroTrimestre()
        {
            return _notaTerceiroTrimestre;
        }
    }
}
