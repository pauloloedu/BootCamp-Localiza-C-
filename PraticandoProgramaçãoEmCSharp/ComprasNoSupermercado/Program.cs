using System;
using System.Collections.Generic;

namespace ComprasNoSupermercado
{
    class Program
    {
        static void Main(string[] args)
        {

            bool convertInt = int.TryParse(Console.ReadLine(), out int totalDeCasosDeTeste);

            if (convertInt == false || totalDeCasosDeTeste >= 100) return;

            string[] listaCompras = new string[1000];

            string[] auxiliar = new string[1000];

            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                listaCompras = Console.ReadLine().ToLower().Split(" ");

                foreach (string item in listaCompras)
                {
                    if (!Array.Exists(auxiliar, x => x == item))
                    {
                        auxiliar[i] = item;
                    }
                }

                Array.Sort(auxiliar);

                foreach (string item1 in auxiliar)
                {
                    Console.Write(item1 + " ");
                }

                Array.Clear(auxiliar, 0, auxiliar.Length);
                Array.Clear(listaCompras, 0, auxiliar.Length);

            }

        }
    }
}
