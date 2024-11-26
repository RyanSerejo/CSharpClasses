using System;

class Aula09{
    static void Main(){
        int num = 24;

        // << dobra o valor, movendo a casa decimal do valor binário em uma, conforme informamos o valor a quantidade de casas muda.
        // >> move a casa decimal do valor binário em uma, ou seja faz com que o valor fique com a metade. conforme informamos o valor a quantidade de casas muda.
        num = num>>2;// está movendo a casa para a direita duas vezes, ou seja dividindo o valor na metade duas vezes
        Console.WriteLine(num);
    }
}