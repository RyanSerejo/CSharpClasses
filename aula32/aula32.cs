using System;

public class Calculos {
    public int v1, v2;

    public Calculos(int v1, int v2){
        this.v1 = v1;
        this.v2 = v2;
    }

    public int Somar(){
        return v1+v2;
    }
}
class Aula32 {
   static void Main(){
        Calculos c = new Calculos(4,4);
        Console.WriteLine(c.Somar());
   }
}