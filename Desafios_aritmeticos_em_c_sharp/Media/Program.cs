using System;

namespace Desafios_aritmeticos_em_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, mediaP;
            bool t1, t2;

            t1 = double.TryParse(Console.ReadLine(), out a);
            t2 = double.TryParse(Console.ReadLine(), out b);

            if (t1 == false || t2 == false)
            {
                return;
            }

            else{
            //complete com as variaveis
            mediaP = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);


            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));
            }

            Console.ReadLine();
        }
    }
}
