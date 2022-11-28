using System;
using System.Collections.Generic;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Armazenar alunos e notas em uma tabela. No final saber se o aluno foi aprovado ou não

            List<dynamic> alunos = new List<dynamic>();
            Console.WriteLine("************ Sistema Registro de Notas ******************");
        menu:
            Console.WriteLine("Digite uma opção:\n 1 - cadastrar notas\n 2 - Exibir aprovados \n 3 -sair");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int repeat = 1;
                    while (repeat != 0)
                    {

                        Console.WriteLine("Informe o nome do aluno:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe a matrícula do aluno:");
                        string matricula = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno (0 a 10):");
                        double nota= double.Parse (Console.ReadLine());
                        alunos.Add(new
                        {
                            nome = nome,
                            matricula = matricula,
                            nota =nota
                        });
                        Console.WriteLine("Deseja inserir novo aluno:\n 0 - Não \n 1 - Sim");
                         repeat = int.Parse(Console.ReadLine());
                    }
                    goto menu;

                    break;
                case 2:
                    foreach (var aluno in alunos)
                    {
                        if(aluno.nota>7.00){
                        Console.WriteLine($" O aluno {aluno.nome} teve a nota {aluno.nota} e foi APROVADO.");

                        }else{
                            Console.WriteLine($" O aluno {aluno.nome} teve a nota {aluno.nota} e foi REPROVADO.");
                        }
                    }
                    goto menu;
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opção inválida! Vamos tentar novamente.");
                    goto menu;

            }
           



        }
    }
}
