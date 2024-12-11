using System;
class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }
    public Ovo botar(){//Aqui temos Ovo como sendo o tipo de retorno do método botar, Ovo se tratando de uma classe.
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
    
}
class Ovo{
    private string quemBotou;
    public Ovo(int numOvo, string quemBotou){
        this.quemBotou=quemBotou;
        Console.WriteLine("A galinha {0} botou seu nº {1} ovo.", quemBotou, numOvo);
    }
}
class Aula46{
    static void Main(){
        Galinha g1 = new Galinha("Aceps");
        Galinha g2 = new Galinha("Comkaz");
        Galinha g3 = new Galinha("gakwel");
        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();
        g2.botar();

        g3.botar();

    }
}