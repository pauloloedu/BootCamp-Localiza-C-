using System;

namespace Bazinga
{
    class Program
    {
        static void Main(string[] args)
        {

            int t;
            bool elemento1 = false, elemento2 = false;
            bool converte = Int32.TryParse(Console.ReadLine(), out t);
            string v1, v2;
            String [] listaopcaoes = new string[5]{"pedra", "papel", "tesoura", "lagarto", "Spock"};    
            
            if (converte == false || t <= 0 || t > 100) return;

            for (int i = 1; i <= t; i++)
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0]; //Esolha de Sheldon
                v2 = valores[1]; //Escolha de Raj

                foreach (var elemento in listaopcaoes)
                {
                    if(elemento == v1) elemento1 = true;                
                    
                    if(elemento == v2) elemento2 = true;
                }

                if (elemento1 == false || elemento2 == false) return;

                if ((v1 == "tesoura" && v2 == "papel") || (v1 == "tesoura" && v2 == "lagarto") //complete a solução
                    || (v1 == "papel" && v2 == "pedra") || (v1 == "papel" && v2 == "Spock")
                    || (v1 == "pedra" && v2 == "lagarto") || (v1 == "pedra" && v2 == "tesoura")
                    || (v1 == "lagarto" && v2 == "Spock") || (v1 == "lagarto" && v2 == "papel")
                    || (v1 == "Spock" && v2 == "tesoura") || (v1 == "Spock" && v2 == "pedra"))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);

                else if ((v1 == "pedra" && v2 == "pedra") || (v1 == "papel" && v2 == "papel") //complete a solução
                    || (v1 == "tesoura" && v2 == "tesoura") || (v1 == "lagarto" && v2 == "lagarto")
                    || (v1 == "Spock" && v2 == "Spock"))
                    Console.WriteLine("Caso #{0}: De novo!", i);
                
                else Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }
        Console.ReadLine();
        }
    }
}
