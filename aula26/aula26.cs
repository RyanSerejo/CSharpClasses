using System;
class Aula26{
    static void Main(){
        int divid, divis, quoc, rest;
        divid = 10;
        divis = 4;
        quoc = divide(divid, divis, out rest);
        Console.WriteLine("{0}/{1} tem quociente {2} e resto {3}", divid, divis, quoc, rest);
    }

    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente = dividendo/divisor;
        resto = dividendo%divisor;
        return quociente;
    }
}