using System;

class Aula04{
    //Variable scope, where the variable is visible and usable
    static int num1 = 10; //global variable

    static void Main(){
        int num2 = 2;
        Console.WriteLine(num1 + num2);
    }
}
