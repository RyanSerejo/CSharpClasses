using System;


class Veiculo{// Classe base
    public int rodas, velMax;
    private bool ligado;

    public void ligar(){
        ligado = true;
    }

    public void desligar(){
        ligado = false;
    }

    public string getLigado(){
        if(ligado){
            return "sim";
        } else {
            return "não";
        }

    }
}

class Carro:Veiculo{//Classe derivada, lembre-se: (classeFilha):(classePai)
    public string nome, cor;

    public Carro(string nome, string cor){
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula34 {
    static void Main(){
        Carro c1 = new Carro("GT 01", "Azul");
        
        Console.WriteLine("O nome do veiculo é {0}.", c1.nome);
        Console.WriteLine("A cor do veiculo é {0}.", c1.cor);
        Console.WriteLine("O veículo tem {0} rodas.", c1.rodas);
        Console.WriteLine("A vel.Max. do veiculo é {0}kmh.", c1.velMax);
        Console.WriteLine("O veiculo está ligado? {0}.", c1.getLigado());


    }
}