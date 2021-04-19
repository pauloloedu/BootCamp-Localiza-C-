using System;

namespace CrescimentoPopulacional
{
    class Program
    {
        static void Main(string[] args)
        {

            int t;
            int pa, pb;
            double cpa, cpb, g1, g2;
            int anos;
            bool converte, paconvert, pbconvert, g1convert, g2convert;

            converte = Int32.TryParse(Console.ReadLine(), out t);

            if (converte == false || t <= 0 || t > 3000) return;

            for (int i = 0; i < t; i++)
            {
                anos = 1;
                string[] valores = Console.ReadLine().Split(' ');

                try
                {
                    paconvert = Int32.TryParse(valores[0], out pa);
                    pbconvert = Int32.TryParse(valores[1], out pb);
                    g1convert = double.TryParse(valores[2], out g1);
                    g2convert = double.TryParse(valores[3], out g2);

                    if (paconvert == false ||
                        pbconvert == false ||
                        g1convert == false ||
                        g2convert == false ||
                        pa < 100 ||
                        pa >= 1000000 ||
                        pb < pa ||
                        pb > 1000000 ||
                        g1 < 0.1 ||
                        g1 > 10.0 ||
                        g2 < 0.0 ||
                        g2 > 10.0 ||
                        g2 > g1) return;
                }
                catch
                {
                    return;
                }

                cpa = (pa * (g1 / 100));
                cpb = (pb * (g2 / 100));

                pa = (int)cpa + pa;
                pb = (int)cpb + pb;

                while (pa <= pb)
                {
                    anos += 1;

                    cpa = (pa * (g1 / 100));
                    cpb = (pb * (g2 / 100));

                    pa = (int)cpa + pa;
                    pb = (int)cpb + pb;

                    if (anos > 100)
                    {
                        //complete a condicional
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

                if (anos <= 100)
                {
                    if (anos == 1)
                    {
                        Console.WriteLine("Mais de 1");
                    }
                    //complete a condicional
                    Console.WriteLine("{0} anos.", anos);
                }
            }
            Console.ReadLine();
        }
    }
}