using System;
public interface Veiculo{// as interfaces servem para "obrigar" as classes que as usam implementem seus métodos, e estes não são especificados na interface, apenas declarados;
    void ligar();
    void desligar();
    void info();
    string getLigado();
}
public interface Combate{
    void disparar();
}

class Carro:Veiculo, Combate{
    private bool ligado;
    private int municao;
    public Carro(){
        setMunicao(100);
    }
    public void setMunicao(int qtde){
        this.municao = qtde;
    }
    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
    public void info(){}
    public void disparar(){
        Console.WriteLine("O carro disparou {0} balas", municao);
    }
    public string getLigado(){
        if(ligado){
            return "Ligado";
        }else {
            return "Desligado";
        }
    }

}
class Aula43{
    static void Main(){
       Carro c1 = new Carro();
       c1.disparar();
       c1.ligar();
       Console.WriteLine("O carro está: {0}", c1.getLigado());
    }    
}