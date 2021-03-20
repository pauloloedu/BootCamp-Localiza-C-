using System;

namespace Revisao
{
    class Program
    {
        private const string V = "X";

        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string escolha;

            escolha = ObterOpcaoUsuario();

            while(escolha.ToUpper() != "X")
            {
                switch(escolha)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno:");
                        
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                            
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }    
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    
                    case "2":
                        foreach(var a in alunos)
                        {
                            if (a.Nome != null)
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        foreach(var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                notaTotal = notaTotal + a.Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Console.WriteLine($"Média Geral: {mediaGeral}");

                        break;
                        
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                escolha = ObterOpcaoUsuario();
             
            }

        }
        private static string ObterOpcaoUsuario()
        {
            
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            string opcao = Console.ReadLine();
            return opcao;
        
        }


    }
}
