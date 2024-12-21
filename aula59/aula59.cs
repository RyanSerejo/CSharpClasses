using System;
using System.Collections.Generic;
class Aula59{
    static void Main(){
        // string[] vs ={"Carro", "Moto", "Navio", "Avião"};
        Queue<string>veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");

        string v= "Aviao";
        if (veiculos.Contains(v)){
            Console.WriteLine("Veículo "+ v + " encontrado");
        }else{
            Console.WriteLine("Veículo "+ v + " não está na fila");
        }

        // veiculos.Clear();
        // Console.WriteLine("Primeiro veiculo "+ veiculos.Dequeue());//dequeue retorna o primeiro elemento da lsita e o remove da lista;
        Console.WriteLine("Primeiro veículo: "+ veiculos.Peek());//Peek, use quando precisar apenas do retorno do primeiro elemento sem removê-lo;
        while(veiculos.Count > 0){
            Console.WriteLine(veiculos.Dequeue());
        }
        Console.WriteLine("Tamanho da fila: " +veiculos.Count);
    }
}