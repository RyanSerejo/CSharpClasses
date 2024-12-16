using System;
class Area{
    public static float Quad(float bas, float alt){
        if(bas==0 || alt == 0){
            throw new Exception("Base ou altura não podem ser iguais a 0");
        }
        return bas * alt;
    }
}
class Aula52{
    static void Main(){
        float n1, n2, res;
        res= n1 = n2 = 0;
        
        n1=200f;
        n2=0;
        try{
            res = Area.Quad(n1, n2);
            Console.WriteLine("{0}/{1}={2}", n1, n2, res);
        }
        catch (System.Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
            Console.WriteLine("Erro: {0}", e.GetType());

        }
    }
}