using System;
/*
Parece que o objetivo da criação dessa Estrutura de Dados é Performance, ou seja, se usado dentro das regras de uso, um STRUCT fica na MEMÓRIA STACK enquanto as CLASSES ficam na MEMÓRIA HEAP (mais lenta).

As LIMITAÇÕES para que a STRUCT seja funcional dentro do seu conceito são as seguintes:

- Devem representar dados do tipo primitivo como INT, DOUBLE, FLOAT etc;
- Que os dados não passem de 16 bytes (dados bem pequenos);
- Que o dado seja IMUTÁVEL;
- Que não necessite de uma operação BOXING/UNBOXING frequentemente;
- Não pode trabalhar com HERANÇA;
- Não podem implemntar INTERFACES;
- Não pode receber uma declaração de FINALIZER;
- Não pode receber atributos (propriedades) sem que seja iniciados, ou seja, sem que as propriedades recebam valor;
- Não pode receber um CONSTRUTOR VAZIO

*/
struct Carro{
    private string marca, modelo, cor;
    public Carro(string marca, string modelo, string cor){
    this.marca = marca;
    this.modelo = modelo;
    this.cor = cor;
    }
    public void info(){
        Console.WriteLine("Marca: {0}.", this.marca);
        Console.WriteLine("Modelo: {0}.", this.modelo);
        Console.WriteLine("Cor: {0}.\n", this.cor);
    }
}
class Aula44{
    static void Main(){
        Carro c1 = new Carro("Honda", "HRV", "Prata");
        c1.info();
    }
}
