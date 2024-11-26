using System;

class Aula17{
    static void Main(){
/*
       int[,] myArray= new int[3, 3];

       myArray[0,0]=00;
       myArray[0,1]=11; 
       myArray[0,2]=22;
       myArray[1,0]=33; 
       myArray[1,1]=44; 
       myArray[1,2]=55;
       myArray[2,0]=66; 
       myArray[2,1]=77; 
       myArray[2,2]=88; 
*/

int[,] myArray = new int[3,3]{{00,11,22},{33,44,55},{66,77,88}};

        Console.WriteLine(myArray[1,1]);
    }
}