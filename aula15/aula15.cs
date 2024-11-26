using System;
class Aula15{
    static void Main(){
        int time = 0;
        char choice;
        string vehicle;

        Console.WriteLine("A travel from konoha to Soul Society");
        Console.WriteLine("Type your vehicle:\t'a'-Buggati,\t'b'-ferrari,\tc-'Lanborginni'.");
        choice=char.Parse(Console.ReadLine());

        switch(choice){
            case 'a':
                vehicle="Buggati";
                time=666;
                break;
            case 'b':
                vehicle="ferrari";
                time=444;
                break;
            case 'c':
                vehicle="Lanborginni";
                time=777;
                break;
            default:
                time=-1;
                vehicle="tururu";
                break;
        }

        if (time < 0){
            Console.WriteLine("Invalid car bro");
        } else {
            Console.WriteLine("Y'll take {0} minutes to this trip, nice {1} bro", time, vehicle);
        }

    }
}