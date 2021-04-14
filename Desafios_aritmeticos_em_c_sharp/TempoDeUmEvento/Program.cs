using System;

namespace TempoDeUmEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio,
                horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino;

            bool converteDiaInicio, converteDiaTermino, converteHoraMomentoInicio,
                 converteHoraMomentoTermino, converteMinutoMomentoInicio, converteSegundoMomentoInicio,
                 converteMinutoMomentoTermino, converteSegundoMomentoTermino;

            try
            {
                string[] dadosInicio = Console.ReadLine().Split(" ");
                converteDiaInicio = Int32.TryParse(dadosInicio[1], out diaInicio);

                string[] dadosMomentoInicio = Console.ReadLine().Split(" : ");
                converteHoraMomentoInicio = Int32.TryParse(dadosMomentoInicio[0], out horaMomentoInicio);
                converteMinutoMomentoInicio = Int32.TryParse(dadosMomentoInicio[1], out minutoMomentoInicio);
                converteSegundoMomentoInicio = Int32.TryParse(dadosMomentoInicio[2], out segundoMomentoInicio);

                string[] dadosTermino = Console.ReadLine().Split(" ");
                converteDiaTermino = Int32.TryParse(dadosTermino[1], out diaTermino);

                string[] dadosMomentoTermino = Console.ReadLine().Split(" : ");
                converteHoraMomentoTermino = Int32.TryParse(dadosMomentoTermino[0], out horaMomentoTermino);
                converteMinutoMomentoTermino = Int32.TryParse(dadosMomentoTermino[1], out minutoMomentoTermino);
                converteSegundoMomentoTermino = Int32.TryParse(dadosMomentoTermino[2], out segundoMomentoTermino);
            }
            catch
            {
                return;
            }

            if (converteDiaInicio == false ||
                converteDiaTermino == false ||
                converteHoraMomentoInicio == false ||
                converteHoraMomentoTermino == false ||
                converteMinutoMomentoInicio == false ||
                converteSegundoMomentoInicio == false ||
                converteMinutoMomentoTermino == false ||
                converteSegundoMomentoTermino == false) return;

            var inicio = (diaInicio - 1) * 86400 + horaMomentoInicio * 3600 + minutoMomentoInicio * 60 + segundoMomentoInicio;
            
            var fim = (diaTermino - 1) * 86400 + horaMomentoTermino * 3600 + minutoMomentoTermino * 60 + segundoMomentoTermino;
            
            var duracao = fim - inicio;

            int W = duracao / 86400;
            int resto = duracao % 86400;

            int X = resto / 3600;
            resto = resto % 3600;

            int Y = resto / 60;

            int Z = resto % 60;

            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", X);
            Console.WriteLine("{0} minuto(s)", Y);
            Console.WriteLine("{0} segundo(s)", Z);

            Console.ReadLine();
        }
    }
}
