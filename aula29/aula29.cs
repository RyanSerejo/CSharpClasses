using System;

public class Player{
        public int energy;
        public bool alive;
        public string nome;
        public Player(string n) {
            energy = 100;
            alive = true;
            nome = n;
        }

        ~Player(){
            Console.WriteLine("Player {0} foi destruído",nome);
        }
    }

public class Aula29{
    static void Main(){
        string nome1, nome2;
        Console.WriteLine("Digite o nome do Player 1.");
        nome1 = Console.ReadLine();

        Console.WriteLine("Digite o nome do Player 2.");
        nome2 = Console.ReadLine();

        Player P1 = new Player(nome1);
        Player P2 = new Player(nome2);

        Console.WriteLine("O nome do jogador 1 é: {0}", P1.nome);
        Console.WriteLine("O nome do jogador 2 é: {0}", P2.nome);
    }
}