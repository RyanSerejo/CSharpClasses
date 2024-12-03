using System;

class Player{
    //se vai usar o private, é bom certificar que tem getters e setters para usar os valores;
        private int energy;
        private string name;
        public Player(string name){
            this.name = name;
            energy = 100;
        }

        public int getEnergy(){
            return energy;
        }
        public string getName(){
            return name;
        }

        public void setEnergy(int e){
            energy+=e;
            if(energy < 0){
                energy = 0;
            }else if(energy > 100){
                energy = 100;
            }
        }
        
    }
class Aula33 {
    static void Main(){
        Player P1 = new Player("Ricarrdo");
    

        

        Console.WriteLine("O nome do P1 é {0}",P1.getName());
        Console.WriteLine("A energia do P1 é {0}",P1.getEnergy());

    }
}