using System;


class Veiculo{// Classe base
    private int rodas; 
    
    public int velMax;
    private bool ligado;
    
    public Veiculo(int rodas){
        this.rodas = rodas;
    }
    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }

    public string getLigado(){
        return ligado?"sim":"não";

    }
     public int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas){
     if(rodas<0){
        this.rodas = 1;
     }else if(rodas > 40){
        this.rodas = 40;
     } else {
        this.rodas = rodas;
     }
    }
   

    
}

class Carro:Veiculo{//Classe derivada, lembre-se: (classeFilha):(classePai)
    public string nome, cor;

    public Carro(string nome, string cor):base(4){//aqui está iniciando o construtor que recebe um argumento da classe base;
        desligar(); 
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class CombatCar:Carro{
    public int municao;
    public CombatCar():base("Carro de combate","Verde"){
        municao = 100;
        setRodas(6);
    }

}

class Aula34 {
    static void Main(){
        Carro c1 = new Carro("GT 01", "Azul");
        c1.ligar();
        CombatCar cc1 = new CombatCar();

        Console.WriteLine("O nome do veiculo é {0}.", c1.nome);
        Console.WriteLine("A cor do veiculo é {0}.", c1.cor);
        Console.WriteLine("O veículo tem {0} rodas.", c1.getRodas());
        Console.WriteLine("A vel.Max. do veiculo é {0}kmh.", c1.velMax);
        Console.WriteLine("O veiculo está ligado? {0}.\n", c1.getLigado());
        
        Console.WriteLine("O nome do veiculo é {0}.", cc1.nome);
        Console.WriteLine("A cor do veiculo é {0}.", cc1.cor);
        Console.WriteLine("O veículo tem {0} rodas.", cc1.getRodas());
        Console.WriteLine("A vel.Max. do veiculo é {0}kmh.", cc1.velMax);
        Console.WriteLine("O veiculo está ligado? {0}.", cc1.getLigado());
        Console.WriteLine("O veiculo tem {0} de municao.\n", cc1.municao);



    }
}