using System;

namespace aulapc_TREINO
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            double elo;
            double Escudo , Vida;
          

            Console.WriteLine("▲Nome do seu Heroi▲");
            Nome = Console.ReadLine();
            
            //Saude//
            Console.WriteLine("Digite a Vida do heroi: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Vida = double.Parse(Console.ReadLine());
            Console.ResetColor();
            
            //Escudo//
            Console.WriteLine("Digite a Força do escudo: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Escudo = double.Parse(Console.ReadLine());
            Console.ResetColor();
            
            //Status//
            Console.WriteLine($" Status do seu heroi é \n Saude Constante:      {Vida}");
            Console.WriteLine($" Armadura Temporaria : {Escudo}");
            Console.WriteLine($" Boas vindas ao heroi : {Nome}");
            Console.Write("\n"); 
            
            //Registro Geral//
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Heroi Criado com Sucesso\n");
            Console.ResetColor();
            elo = double.Parse(Console.ReadLine());

            elo = Escudo + Vida;

        }
    }
}
