using System;

class Aula10{
    enum weekdays{Sunday,Monday,Tuesday, Wednesday, Thursday, Fryday, Saturday};// foi criado um enumerador, e passado os métodos que ele recebeu. Cada item está num índice.
    static void Main(){
        weekdays wk = weekdays.Monday; 
        
        weekdays wk1 = (weekdays)2;

        int wk2 = (int)weekdays.Fryday;

        Console.Write("{0}, {1}, {2}",wk,wk1,wk2);
    }
}