using System;

class Aula12{
       static void Main(){
        
        int n1, n2, n3, n4, media;
        string result = "failed";

        Console.WriteLine("Put the first grade:(1 to 10)");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Put the second grade: (1 to 10)");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Put the third grade: (1 to 10)");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Put the fourth grade: (1 to 10)");
        n4 = int.Parse(Console.ReadLine());
        
        media = (n1+n2+n3+n4)/4;

        if(media >= 6){
            result = "approved";
        }

        Console.Write("Your media is {0}, and you was {1}",media, result);
    }
}