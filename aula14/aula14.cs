using System;

class Aula14{
       static void Main(){
        
        int n1, n2, n3, n4, media;
        string result;

        Console.WriteLine("Put the first grade:(1 to 10)");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Put the second grade: (1 to 10)");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Put the third grade: (1 to 10)");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Put the fourth grade: (1 to 10)");
        n4 = int.Parse(Console.ReadLine());
        
        media = (n1+n2+n3+n4)/4;


        if(media < 6){
            if(media >= 4 && media < 6){
                result = "On recovery";
            } else {
                result = "failed";
            }
        } else {
            if(media > 8 && media <= 10){
                result = "Great job";
            } else{
                result = "approved";
            }
        }
/*
        if(media < 4){
            result = "failed";
        } else if(media < 6){
            result = "On recovery";
        } else if(media >=6 & media <=10){
            result = "approved";
        } else {
            result = "put a invalid grade";
        }

*/
        

        Console.Write("Your media is {0}, and you was {1}",media, result);
    }
}