using System;
 
class Aula20{
    static void Main(){
        
        int[] mArray= new int[10];
        int count=0;

        while(count<mArray.Length){
            mArray[count]= count+1;
            Console.WriteLine("Testing {0} time", mArray[count]);
            count++;

        }

    }
}