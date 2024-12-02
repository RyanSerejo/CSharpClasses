using System;

public class Player{
        public int energy = 100;
        public bool alive = true;
    }

public class Aula28{
    static void Main(){
        Player P1= new Player();
        Player P2= new Player();
        Player P3= new Player();
        
        P1.energy = 50;
        P3.alive = false;

        Console.WriteLine("A energia do P1 é: {0}", P1.energy);
        Console.WriteLine("O P2 está vivo? {0}", P3.alive);

    }
}