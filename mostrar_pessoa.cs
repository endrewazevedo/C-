using System;
using System.Collections.Generic;
using System.Text;
using Pessoas;

class program{
    static void Main(string[] args){
    Pessoa teste = new Pessoa();
    teste.Nome = "Maycon";
    teste.Idade = 22;
    teste.Profissao = "Estagiário";
    Console.WriteLine(teste.Nome);
    Console.WriteLine(teste.Idade);
    Console.WriteLine(teste.Profissao);
}
}
