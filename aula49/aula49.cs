using System;
class Mat{//quando os membros da classe são declarados estáticos, podem ser usados desta maneira;
    public static double pi = 3.14;
    public static int dobro(int n){
        return n*2;
    }
}
class Aula49{
    static void Main(){
        double vpi = Mat.pi;//aqui
        int num = 10;

        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(num));//aqui
    }
}