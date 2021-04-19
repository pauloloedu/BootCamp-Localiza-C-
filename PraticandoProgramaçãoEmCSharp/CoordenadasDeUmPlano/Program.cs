using System;

namespace CoordenadasDeUmPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] vetorEixos = new string[2]; 
            
            vetorEixos = Console.ReadLine().Split(" ");

            bool convertX = Double.TryParse(vetorEixos[0], out double eixoX);
            bool convertY = Double.TryParse(vetorEixos[1], out double eixoY);

            if(convertX == false || convertY == false) return;


            if(eixoX == 0.0 && eixoY == 0.0) Console.WriteLine("Origem");     

            else if((eixoX > 0.0 || eixoX < 0.0) && eixoY == 0.0) Console.WriteLine("Eixo X");

            else if(eixoX == 0.0 && (eixoY > 0.0 || eixoY < 0.0)) Console.WriteLine("Eixo Y");

            else if(eixoX > 0.0 && eixoY > 0.0) Console.WriteLine("Q1");

            else if(eixoX < 0.0 && eixoY > 0.0) Console.WriteLine("Q2");

            else if(eixoX < 0.0 && eixoY < 0.0) Console.WriteLine("Q3");

            else Console.WriteLine("Q4");


            Console.ReadLine();

        }
    }
}
