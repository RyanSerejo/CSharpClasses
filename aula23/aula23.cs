using System;

class Aula23{
    static void Main(){

        int[] vet1 = new int[5];
        int[] vet2 = new int[5]{1,2,3,4,5};
        int[] vet3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};


        //Use o Random para gerar números aleátorios.
        //Chame o .Next no elemento para executar.
        //Abaixo está gerando números aleatórios e atribuindo para as posições do vetor indicado;
        Random random = new Random();
        for(int i=0; i<vet1.Length; i++){
            vet1[i] = random.Next(50);//3 formas de declarar o alcance dos números;Vazio, valor máximo e mínimo e máximo;
        }
        Console.WriteLine("Elementos do vet1");
        foreach(int n in vet1){
            Console.WriteLine(n);
        }

        //public static int BinarySearch(array, valor); Retorna a posição do elemento procurado; Se retornar valor negativo o número não foi encontrado.
    
        Console.WriteLine("\nBinarySearch");
        int procurado=3;
        int position=Array.BinarySearch(vet2, procurado);
        Console.WriteLine("Valor {0} está na posição {1}", procurado, position);
        Console.WriteLine("__________________________________________________\n");
        
        //public static void Copy(Ar_origem, Ar_destino, qtd_elementos); Copia os valores do array de origem para o destino, de acordo com a quantidade definida
        Console.WriteLine("Copy");
        Array.Copy(vet1, vet2, vet1.Length);
        foreach (int n in vet2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("__________________________________________________\n");
        
        //public void CopyTo(Ar_destino, a_partir_desta_position); Copia os valores do array a partir da posição que indicamos;
        Console.WriteLine("CopyTo");
        vet1.CopyTo(vet3,0);
        foreach(int n in vet3){
            Console.WriteLine(n);
        }
        Console.WriteLine("__________________________________________________\n");

        //public long GetLongLength(dimensão); Retorna o número de elementos do array.
        Console.WriteLine("GetLongLength");
        long qtdElementosVet = vet1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdElementosVet);
        Console.WriteLine("__________________________________________________\n");


        //public int GetLowerBound(dimensão);//retorna o menor índice do array;Lembrar das dimensões em matrizes;
        Console.WriteLine("GetLowerBound");
        int menorIndVet = vet1.GetLowerBound(0);
        int menorIndMat = matriz.GetLowerBound(1);
        Console.WriteLine("Menor índice do vet1 {0}", menorIndVet);
        Console.WriteLine("Menor índice do vet3 {0}", menorIndMat);
        Console.WriteLine("__________________________________________________\n");

        //public int GetUpperBound(dimensão);//retorna o maior índice do array;Lembrar das dimensões em matrizes;
        Console.WriteLine("GetUpperBound");
        int maiorIndVet = vet1.GetUpperBound(0);
        int maiorIndMat = matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vet1 {0}", maiorIndVet);
        Console.WriteLine("Maior índice do vet3 {0}", maiorIndMat);//vai retornar 4 pois se refere ao número do indice
        Console.WriteLine("__________________________________________________\n");

        //public Object GetValue(long indice);retorna um object do indice indicado;
        Console.WriteLine("GetValue");
        int value0 = Convert.ToInt32(vet1.GetValue(3));
        int value1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vet1 é: {0}", value0);
        Console.WriteLine("Valor da posição 1,3 da matriz é: {0}", value1);
        Console.WriteLine("__________________________________________________\n");

        //public static int IndexOf(array, valor); Procura o valor indicado no array e retorna o primeiro índice que foi encontrado;
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vet1,3);
        Console.WriteLine("Indice do primeiro valor 3, é {0}", indice1);
        Console.WriteLine("__________________________________________________\n");

        //public static int LastIndexOf(array, valor); Procura o valor indicado no array e retorna o último índice que foi encontrado;
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vet1, 3);
        Console.WriteLine("Indice do ultimo valor 3, é {0}", indice2);
        Console.WriteLine("__________________________________________________\n");

        //public static void Reverse(array); Inverte a posição dos indices no array;
        Console.WriteLine("Reverse");
        Array.Reverse(vet1);
        foreach(int n in vet1){
            Console.WriteLine(n);
        }
        Console.WriteLine("__________________________________________________\n");

        //public void SetValue(Object valor, long position); use para atribuir valores a determinados indices 
        Console.WriteLine("\nSetValue");
        vet2.SetValue(99, 0);//atribuindo valor a somente uma posição;
        for(int i=0; i < vet2.Length; i++){
            vet2.SetValue(0, i);
        }//atribuindo valores a todos os índices;
        Console.WriteLine("Vet2");
        foreach(int n in vet2){
            Console.WriteLine(n);
        }

        //public static void Sort(Array); Ordena os valores do array
        Console.WriteLine("Sort(Array)");
        Array.Sort(vet1);
        Array.Sort(vet2);
        Array.Sort(vet2);
        Console.WriteLine("\nVet1");
        foreach(int n in vet1){
            Console.WriteLine(n);
        }

        Console.WriteLine("\nVet3");
        foreach(int n in vet2){
            Console.WriteLine(n);
        }

        Console.WriteLine("\nVet3");
        foreach(int n in vet3){
            Console.WriteLine(n);
        }

    }
}