using System;

public class Player{
        public int energy;
        public bool alive;
        public string nome;
        public Player(){
            energy = 100;
            alive = true;
            nome = "Player";
        }
        public Player(string n) {
            energy = 100;
            alive = true;
            nome = n;
        }

        public Player(string n, int e){
            energy = e;
            alive = true;
            nome = n;
        }
         public Player(string n, int e, bool a){
            energy = e;
            alive = a;
            nome = n;
        }

        public void Info(){
            Console.WriteLine("Nome do Player: {0}.", nome);
            Console.WriteLine("Energia do Player: {0}.", energy);
            Console.WriteLine("Estado do Player: {0}.\n", alive);

        }

       
    }

public class Aula30{
    static void Main(){
        
        Player P1 = new Player();
        Player P2 = new Player("Jota");
        Player P3 = new Player("Marcos", 80);
        Player P4 = new Player("Bob", 0, false);

        P1.Info();
        P2.Info();
        P3.Info();
        P4.Info();

    }
}