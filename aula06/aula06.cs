using System;

class Aula06{
    static void Main(){
        int n1=10, n2=20, n3=30;
        // \n = use as a "enter"
        // \t = use as a "tab"
        Console.Write("\nn1=\t{0},\nn2=\t{1},\nn3=\t{2}\n", n1, n3, n3);


        double buyValue = 5.50;
        double sellVaule;
        double profit = 0.2;
        string product = "hamburger";

        sellVaule = buyValue + (buyValue*profit);
        //The 0 in the keys indicates index of variables
        //The 15 in the keys indicates 15 of tab
        //The :c and :p indicates format coin and percentage 
        Console.WriteLine("Product....:{0,15}", product);
        Console.WriteLine("Buy.val....:{0,15:c}", buyValue);
        Console.WriteLine("profit.....:{0,15:p}", profit);
        Console.WriteLine("Sell.val...:{0,15:c}", sellVaule);
    }
}