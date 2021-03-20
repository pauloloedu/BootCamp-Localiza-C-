using System;

class minhaClasse
{
    static void Main(string[] args)
    {

        double salario, reajuste, novoSalario, percentual;
        bool sucesso = Double.TryParse(Console.ReadLine(), out salario);


            //insira os valores corretos de acordo com o enunciado
            if (salario < 0)
            {
                return;
            }

            else if (salario <= 400.00)
            {
                percentual = 15.00;
                reajuste = salario * (percentual / 100);
                novoSalario = salario + reajuste;

                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                percentual = 12.00;
                reajuste = salario * (percentual / 100);
                novoSalario = salario + reajuste;
                percentual = Convert.ToInt32(((novoSalario - salario) * 100) / salario);
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                percentual = 10.00;
                reajuste = salario * (percentual / 100);
                novoSalario = salario + reajuste;
                percentual = Convert.ToInt32(((novoSalario - salario) * 100) / salario);
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                percentual = 7.00;
                reajuste = salario * (percentual / 100);
                novoSalario = salario + reajuste;
                percentual = Convert.ToInt32(((novoSalario - salario) * 100) / salario);
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else
            {
                //complete o codigo
                percentual = 4.00;
                reajuste = salario * (percentual / 100);
                novoSalario = salario + reajuste;
                percentual = Convert.ToInt32(((novoSalario - salario) * 100) / salario);
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
    }

}