using System;


class Veiculo{//classe base
    public int velAtual;
    private int velMax;
    protected bool ligado;
    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public int getVelMax(){
        return velMax;
    }
    public bool getLigado(){
        return ligado;
    }
}

class Carro:Veiculo{//Classe derivada
    public string nome;
    public Carro(string nome, int vm):base(vm){
        this.nome = nome;
        ligado = true; //o elemento protected está sendo acessado pela classe derivada(filho)
    }
}

class Aula36{
    static void Main(){
        Carro carro = new Carro("GTM", 150);

        Console.WriteLine("Nome:....{0}", carro.nome);
        Console.WriteLine("Vel.Max:.{0}", carro.getVelMax());
        Console.WriteLine("Ligado?:.{0}", carro.getLigado());//para acessar os valores privados fora da classe, é necessário criar um método publico para isso.

    }
}