using System;

class Aula03{
    static void Main() {
        byte n1 = 10; //tipo de inteiro de 8 bites; 0 e 255, não tem sinal pois começa de 0
        int num = -10; //pode ter sinal
        char letra = '8'; //charactere, pode ser um número, usa aspas simples e armazena um caractere.
        float valor = 5.3f; //usado para pontos flutuantes, valores reais. (O f no final é necessário para ficar no padrão float)
        string name = "Ryan"; //group of characters

        var aux = valor; //type var inherits the type of atributed value.
        
        Console.WriteLine(aux);
    }
}