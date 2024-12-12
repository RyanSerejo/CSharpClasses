using System;
class Calc{
    public int fat(int n){//recursividade: sempre que tratarmos de uma função chamando ela mesma se trata de recursividade
        int res;
        if(n<=1){
            res = 1;
        }else{
            res = n * fat(n-1);
        }
        return res;
    }
}
class Aula48{
    static void Main(){
        Calc calc = new Calc();

        var res = calc.fat(8);
        Console.WriteLine(res);
    }
}