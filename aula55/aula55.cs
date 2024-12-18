using System;
using System.Collections.Generic;//Biblioteca que contém os elementos para trabalharmos com dictionarys
class Aula55{
    static void Main(){
        Dictionary <int, string> veiculos = new Dictionary<int, string>();
        veiculos.Add(4, "Carro");//Para adicionar elementos na coleção;
        veiculos.Add(7, "Moto");
        veiculos.Add(70, "Avião");
        veiculos.Add(36, "Navio");
        veiculos.Add(20, "Trem");

        veiculos.Remove(36);//passando a chave no método, podemos remover determinado elemento na coleção;

        // veiculos.Clear() método para limpar um dictionary
        Console.WriteLine("Tamanho do dictionary: {0}", veiculos.Count);//A propriedade Count, conta os elementos na coleção
 
        int chave = 36;// coloque a chave que deseja buscar
        if(veiculos.ContainsKey(chave)){//Método que retorna true se a chave for encontrada na coleção
            Console.WriteLine("A chave {0} está na coleção.", chave);
        }else{
            Console.WriteLine("A chave {0} não está na coleção.", chave);
        }

        string valor = "Carro";// coloque o valor que deseja buscar
        if(veiculos.ContainsValue(valor)){//Método que retorna true se o valor for encontrado na coleção
            Console.WriteLine("O valor {0} está na coleção.", valor);
        }else{
            Console.WriteLine("O valor {0} não está na coleção.", valor);
        }

        //Formas de imprimir os valores da coleção;
        foreach(string v in veiculos.Values){//Forma mais pratica
            Console.WriteLine(v);
        }
        Console.WriteLine("_____________________________________________\n");

        foreach(KeyValuePair<int, string> v in veiculos){
            Console.WriteLine(v.Key);//Dessa forma podemos escolher imprimir a chave ou o valor; Para imprimir o valor use v.Value
        } 

        Console.WriteLine("_____________________________________________\n");

        Dictionary<int, string>.KeyCollection valores = veiculos.Keys;// dessa forma está chamando as chaves, use Value.Collection valores = veiculos.Values; para obter os valores
        foreach(int v in valores){// se for usar os valores o tipo tem que ser string
            Console.WriteLine(v);
        }

    }
}