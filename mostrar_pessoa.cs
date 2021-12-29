using System;
using System.Collections.Generic;
using System.Text;
using Pessoas;

class program{
    static void Main(string[] args)
    {
        Aluno[] Alunos = new Aluno[5];
        var indice = 0; 
        string opcao = menuOpcao();

        while (opcao != "4")
        {
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informe o nome do aluno");
                    Aluno aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Informe a nota do aluno");
                    aluno.Nota = decimal.Parse(Console.ReadLine());
                    Alunos[indice] = aluno;
                    indice++;
                    break;

                case "2":
                foreach(var i in Alunos){
                    
                    if(!string.IsNullOrEmpty(i.Nome)){
                        Console.WriteLine($"ALUNO: {i.Nome} - NOTA: {i.Nota}");
                    }
                }

                    break;

                case "3":
                    decimal notaTotal = 0;
                    int alunosTotais = 0;

                    for(int i = 0; i < Alunos.Length; i++){
                        if(!string.IsNullOrEmpty(Alunos[i].Nome)){
                            notaTotal += Alunos[i].Nota;
                            alunosTotais++;
                    }
                        
                    }

                    var mediaGeral = notaTotal/alunosTotais;
                    Console.WriteLine($"Media Geral: {mediaGeral}");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
          opcao = menuOpcao();
        }
    }

    private static string menuOpcao()
    {   
        Console.WriteLine();
        Console.WriteLine("Informe as opção desejada");
        Console.WriteLine("1 - Inserir novo aluno");
        Console.WriteLine("2 - Listar alunos");
        Console.WriteLine("3 - Calcular média geral");
        Console.WriteLine("4 - Encerrar");
        Console.WriteLine();

        string opcao = Console.ReadLine();
        Console.WriteLine();
        return opcao;
    }
}
