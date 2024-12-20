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
        carros.Add("HRV");


        // carros2.AddRange(carros);//adicionou os itens da lista carros para a lista carros2
        
        // carros.Clear();//Limpa a lista
        
        // carros.Remove("Argo");//remove da lista o elemento que for passado no argumento
        
        // carros.RemoveAt(2);//remove da lista o elemento que a posição está sendo passada    
        
        // carros.Reverse();//inverte a ordem dos elementos na lista
        
        carros.Sort();//Ordena os elementos da lista

        int tam = carros.Count;
        Console.WriteLine("Quantidade de carros: {0}", tam);
        carros.Capacity = 20;
        int cap = carros.Capacity;
        Console.WriteLine("Quantidade de carros: {0}", cap);


        if(carros.Contains("Gol")){
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2, 2);//copiou de "carros" para "carros2" a partir da posição "2" da nova lista, mas lembre que para onde estamos copiando tem que ser uma lista[].

        carros.Insert(1,"Cruze");//insere na posição indicada o segundo argumento;

        foreach(string c in carros){
            Console.WriteLine("Carros: {0}", c);
        }

        string ca = "HRV";
        int pos = carros.IndexOf(ca);

        int lastOne = carros.LastIndexOf("HRV");
        Console.WriteLine("O carro {0} está na posição {1}.", ca, pos);
        Console.WriteLine("Último HRV está na posição {0}.", lastOne);

    }
}