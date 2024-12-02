using System;

static public class Player{ //classe static não pode ser istanciada por um objeto, logo nao pode ter construtores
    static public int energy; // todos os membros da classe precisam ser static caso a classe tbm seja
    static public bool alive;
    static public string name;
    static public void Start(string n){
        energy = 100;
        alive = true;
        name = n;
    }
    static public void info(){
        Console.WriteLine("\nNome jogador.:{0}", name);
        Console.WriteLine("Energia jogador:{0}", energy);
        Console.WriteLine("Estado jogador.:{0}\n", alive);
    }
}
class Enemy{
    static public bool alert; //quando é criado atributos statics, significa que todos os objetos da classe apontam pro mesmo atributo. 
    public string name;       
    public Enemy(string n){
        alert=false;
        name=n;
    }
    public void info(){
        Console.WriteLine(name);
        Console.WriteLine(alert);
        Console.WriteLine("------------------------------");
    }
}
class Aula31{
    static void Main(){
    
    Player.Start("Bruno");
    Player.info();
    
    Enemy i1= new Enemy("Doido"); // objetos da classe Inimigo
    Enemy i2= new Enemy("Maluco");
    Enemy i3= new Enemy("Pirado");

    Enemy.alert=true; // quando define o atributo "alert", ela vai valer para toda a classe
                         // no programa feito todos os inimigos receberam o alerta TRUE e não separados
    i1.info();
    i2.info();
    i3.info();
    }
}