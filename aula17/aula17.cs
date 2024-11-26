using System;

class Aula17{
    static void Main(){
        //The different ways to declare a array;
        //To remember that index position starts in 0;

        int[] myArray = new int[5];
        myArray[2] = 222;// declaring position per position;
        Console.WriteLine(myArray[2]);

        string[] myArray2 = new string[5]{"111", "222", "333", "444", "555"}; //Declaring position right after the array;
        Console.WriteLine(myArray2[2]);


        int[] myArray3 = {1, 2, 3, 4, 5};// Declaring without mention the lenght of the array, the lenght will be the same amount of declared elements;
         Console.WriteLine(myArray3[2]);
    }
}