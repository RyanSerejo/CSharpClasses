using System;

class Base{
    public Base(){
    Console.WriteLine("Construtor da classe base");
    }
}

class Derivada1:Base{
    public Derivada1(){
    Console.WriteLine("Construtor da classe derivada 1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
    Console.WriteLine("Construtor da classe derivada 2");
    }
}

class Aula37{
    static void Main(){
    Derivada2 drv2 = new Derivada2();
        
    }
}