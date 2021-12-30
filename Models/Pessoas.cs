namespace C_Sharp.Models
{
    public class Pessoas
    {  

        public struct Pessoa{
        public string? Nome { get; set;}
        public int Idade {get; set;}
        public string Profissao { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Olá meu nome é {Nome} tenho {Idade} anos e sou {Profissao}");
        }
        
    }
    }
}