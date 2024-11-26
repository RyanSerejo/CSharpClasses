using System;
class Aula16{
    static void Main(){
        int time = 0;
        char choice;
        string vehicle;

        start: //here is a declaration of a label
        Console.Clear();

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

        Console.WriteLine("Would you like to estimate again?'s/n'");
        choice = char.Parse(Console.ReadLine());

        if(choice == 's' || choice == 'S'){
            goto start;
        }else{
            Console.Clear();
            Console.WriteLine("The End.");
        }

    }
}