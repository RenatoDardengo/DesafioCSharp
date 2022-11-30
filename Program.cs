using System;
using System.Collections.Generic;


namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        { // EXERCÍCIO USANDO ORIENTAÇÃO A OBJETOS

            List<Aluno> alunos = new List<Aluno>();
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
                        var aluno = new Aluno();
                        Console.WriteLine("Informe o nome do aluno:");
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a matrícula do aluno:");
                        aluno.Matricula = Console.ReadLine();
                        Console.WriteLine("Informe as notas do aluno (0 a 10):");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Digite a {i + 1}ª nota do aluno:");
                            aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                        }
                        alunos.Add(aluno);

                        Console.WriteLine("Deseja inserir novo aluno:\n 0 - Não \n 1 - Sim");
                        repeat = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }

                    goto menu;

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Resultado dos alunos");
                    foreach (var aluno in alunos)
                    {
                        Console.WriteLine("_____________________________");
                        Console.WriteLine($"Nome: {aluno.Nome} - Matrícula: {aluno.Matricula}");
                        int i= 1;
                        foreach(double notas in aluno.Notas){
                            Console.WriteLine($"{i}ª nota: {notas}");
                            i++;
                        }
                        Console.WriteLine($"Situação: {aluno.Situacao()}");

                    }
                    Console.WriteLine("Escolha uma opção:\n 0 - Encerrar \n 1 - Retornar ao Menu");
                    int result = int.Parse(Console.ReadLine());
                    if(result==0){
                        return;
                    }else{

                    goto menu;
                    }

                    
                case 3:
                    return;
                default:
                    Console.WriteLine("Opção inválida! Vamos tentar novamente.");
                    goto menu;

            }












            /* ******EXERCÍCIO FEITO SEM ORIENTAÇÃO A OBJETOS****
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
                        double []notas = new double[3];
                        double soma=0.00;
                        double media =0.00;
                        for(int i=0;i<3;i++){
                            Console.WriteLine($"Digite a {i+1}ª nota do aluno:");
                            notas[i] = double.Parse(Console.ReadLine());
                            soma+=notas[i];

                        }
                        media = soma/notas.Length;
                        alunos.Add(new
                        {
                            nome = nome,
                            matricula = matricula,
                            media =media
                        });
                        Console.WriteLine("Deseja inserir novo aluno:\n 0 - Não \n 1 - Sim");
                         repeat = int.Parse(Console.ReadLine());
                    }
                    
                    goto menu;

                    break;
                case 2:
                    foreach (var aluno in alunos)
                    {
                        if(aluno.media>7.00){
                        Console.WriteLine($" O aluno {aluno.nome} teve a nota {aluno.media} e foi APROVADO.");

                        }else{
                            Console.WriteLine($" O aluno {aluno.nome} teve a nota {aluno.media} e foi REPROVADO.");
                        }
                    }
                    
                    goto menu;
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opção inválida! Vamos tentar novamente.");
                    goto menu;

            }*/




        }
    }
}
