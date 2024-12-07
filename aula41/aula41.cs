using System;
class Carro{
    private int velMax;
    public int vm{
        get {
            return velMax;
        }
        set{
            if(vm < 0){
                velMax = 0;
            } else if(vm > 200){
                velMax = 200;
            }else{
                velMax = value;
            }
        }
    }
    public Carro(){
        vm = 120;
    }
}
class Aula41{
    static void Main(){
        Carro c1 = new Carro();

        c1.vm=154;
        Console.WriteLine("Velocidade: {0} kmh.",c1.vm);
    }
}