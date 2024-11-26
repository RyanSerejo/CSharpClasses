using System;
class Aula25{
    static void Main(){
        int valor=10;
        dobrar1(ref valor);//Para passar valor por referência é necessário usar o ref tanto na entrada, quanto na declaração do tipo de parãmetro no método abaixo "dobrar";
        Console.WriteLine(valor);
    }

    static void dobrar1(ref int n1){//passando o valor como referência, a variável será afetada pelo método;s
        n1*=2;
    }

    static void dobrar2(int n1){//passando o valor sem referência, é como se fosse feita uma cópia do valor sem afetar a variável para usar esse valor como bem entender;
        n1*=2;
    }
}