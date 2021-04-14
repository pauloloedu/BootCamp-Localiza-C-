using System;

namespace ComunicacaoEmPirilandia
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            bool converte;
            Int64 enumero;
            int cont = 0;
            int cont2 = 0;

            n = Console.ReadLine();
            converte = Int64.TryParse(n, out enumero);

            if (converte == false || enumero <= 0 || enumero >= 9999999999) return;

            else
            {
                char[] vetor1 = new char[n.Length];
                char[] vetor2 = new char[n.Length];

                foreach (char a in n)
                {
                    vetor1[cont] = a;
                    cont += 1;
                }

                for (int i = n.Length -1; i >= 0; i--)
                {
                    vetor2[cont2] = vetor1[i];
                    cont2 += 1;
                }

                foreach (char b in vetor2)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
