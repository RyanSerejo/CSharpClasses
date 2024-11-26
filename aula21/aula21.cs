using System;

class Aula21{
    static void Main(){
        string pass = "123";
        string userpass;
        int tries = 0;
        
        do{
            Console.Clear();
            Console.WriteLine("Put your password:");
            userpass = Console.ReadLine();
            tries++;
        }while(userpass != pass);

        Console.WriteLine("Welcome taranana");
    }
}