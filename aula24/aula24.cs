using System;

class Aula24{
    static void Main(){
        int value1, value2;
        value1=int.Parse(Console.ReadLine());//int.Parse é uma  das formas de converter para int
        value2=Convert.ToInt32(Console.ReadLine());//Convert.ToInt32 é uma  das formas de converter para int
        Console.WriteLine("A soma dos valores {0} e {1} é {2}",value1, value2,sum(value1, value2));
    }

    static int sum(int n1, int n2){//foi criado um método externo ao bloco principal da classe; 
    //Esse método tem que ser do mesmo tipo do principal nesse caso, static; 
    //tem que ser definido o tipo do retorno, se não tiver use void; 
    //Declare os tipos de valores que espera receber nos parâmetros, pode ser de tipos diferentes ex : sum(int n1, string user1...)
        return n1+n2;//se tiver retorno use return para fazê-lo;
    }
}