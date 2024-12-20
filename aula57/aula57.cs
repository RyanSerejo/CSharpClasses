using System;
using System.Collections.Generic;
class Aula57{
    static void Main(){
        List<string>carros= new List<string>();
        string[] carros2= new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        // carros2.AddRange(carros);//adicionou os itens da lista carros para a lista carros2
        // carros.Clear();//Limpa a lista

        if(carros.Contains("Gol")){
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2, 2);//copiou de "carros" para "carros2" a partir da posição "2" da nova lista, mas lembre que para onde estamos copiando tem que ser uma lista[].

        foreach(string c in carros2){
            Console.WriteLine("Carros: {0}", c);
        }

        string ca = "HRV";
        int pos = carros.IndexOf(ca);
        Console.WriteLine("O carro {0} está na posição {1}.", ca, pos);
    }
}