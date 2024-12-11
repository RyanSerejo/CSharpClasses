using System;
class Calc{
    public int soma(params int[]n){//params está pegando os parâmetros para colocar no vetor
        int s = 0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
    public double soma(params double[]n){//Apenas uma sobrecarga pro método retornar a soma de valores double
        double s = 0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
}
class Aula47{
    static void Main(){
        Calc calc = new Calc();

        var res = calc.soma(3.3, 4.4, 5.5, 7.7);
        Console.WriteLine(res);
    }
}