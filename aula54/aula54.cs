using System;
namespace Calc1{//Os name espace servem para organização, assim podemos ter classes de mesmo nome, pois "vem" de namespaces diferentes
    class Area{
    public static float Quad(float bas, float alt){
        if(bas==0 || alt == 0){
            throw new Exception("Base ou altura não podem ser iguais a 0");
        }
        return bas * alt;
    }
}
}

namespace Calc2{
    class Area{
    public static float Quad(float bas, float alt){
        if(bas==0 || alt == 0){
            throw new Exception("Base ou altura não podem ser iguais a 0");
        }
        return bas * alt;
    }
}
}

class Aula53{
    static void Main(){
        float n1, n2, area;
        n1=200f;
        n2=59f;
        try{
            area = Calc1.Area.Quad(n1, n2);
            Console.WriteLine("Area do quad = {0}", area);
        }
        catch (System.Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
            Console.WriteLine("Erro: {0}", e.GetType());

        }finally{
            Console.WriteLine("Fim do processo");
        }
    }
}