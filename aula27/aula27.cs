using System;

class Aula27{
    static void Main(){
        sum(9, 88, 28);
    }

    static void sum(params int[]Arr){
        int res = 0;
        if(Arr.Length < 1){
            Console.WriteLine("Não foram inseridos números para realizar a soma.");
        } else if(Arr.Length < 2){
            Console.WriteLine("Apenas {0} é insuficiente para realizar a soma.", Arr[0]);
        } else {
            for(int i=0; i<Arr.Length; i++){
                res+=Arr[i];
            }
        }
        Console.WriteLine("O valor da soma dos números inseridos é: {0}",res);
    }
}