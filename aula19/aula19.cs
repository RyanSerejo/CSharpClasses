using System;

class Aula19{
    static void Main(){
        
        int lenght, i;

        Console.WriteLine("Quantas vezes irá fazer a repetição?");
        lenght=int.Parse(Console.ReadLine());
        int[] array = new int[lenght];

        for(i=0;i<lenght;i++){
            Console.WriteLine("Deu certo {0} vezes", i);
            array[i]=i;
            Console.WriteLine("{0}", array[i]);
        }
    }
}