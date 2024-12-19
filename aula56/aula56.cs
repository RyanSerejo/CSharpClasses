using System;
using System.Collections.Generic;
class Aula56{
    static void Main(){
        LinkedList<string> transp = new LinkedList<string>();//instanciando uma lista duplamente encadeada (duplamente encadeada pois cada elemento está encadeado com o elemento anterior e o sucessor;)
        transp.AddFirst("Carro");//Adiciona o elemento na primeira posição; lembre do conceito de pilha;
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bicicleta");
        
        LinkedListNode<string>no;
        no = transp.FindLast("Navio");//procura na coleção o último elemento digitado
        transp.AddAfter(no, "Patinete");//adiciona na coleção, o elemento digitado, após a referência (referência, valor)
        no = transp.FindLast("Navio");
        transp.AddBefore(no, "Patins");//adiciona na coleção, o elemento digitado, antes da referência (referência, valor)

        // transp.Clear(); //Limpa a coleção
        
        if(transp.Find("Carro")==null){//Find() vai procurar na coleção, se não encontrar retorna nulll;
            Console.WriteLine("Não encontrado");
        }else{
            Console.WriteLine("Elemento encontrado");
        }

        // transp.Remove("Navio");//Vai remover o valor da coleção.
        transp.RemoveFirst();//Remove o primeiro elemento.
        transp.RemoveLast();//Remove o ultimo elemento;

        //no = transp.FindLast("Navio").Next;//escrito dessa forma aponta para o próximo elemento ligado a referência;
        //no = transp.FindLast("Navio").Previous;//escrito dessa forma aponta para o elemento anterior ligado a referência;

        foreach (string t in transp){
            Console.WriteLine("Transporte: {0}", t);
        }
    }
}