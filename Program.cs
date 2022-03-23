//Player class
public class Player{
    public int hp = 100;


//wanted to somehow use an array of weapons to make it easier if more items would be added to game, but unsure how to use it practicly, I mean
//the issue Im unsure not how to pick value from an array, but how to implement it in code
    public String[]  weapon = new String[] {"sword", "knife"}; 
          

    public string name;

}

//Monster class
public class Monster{
    public int HP;
    public string name = "monster";
    public int damage;

    public Boolean alive = true;
}


class main{

    static void Main(string[] args){
        //intro
        Player player1 = new Player();
        Console.WriteLine("Welcome summoner, are you ready to join a quest?");
        Console.WriteLine("We need you to kill all of the monsters that runed away from the area 69");
        Console.WriteLine("If you agree");
        Console.WriteLine("Enter your name");
        Console.WriteLine("If you disagree");
        Console.WriteLine("well, you still have no choice;)");
        Console.Write("Your name: ");
        player1.name = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Welcome " + player1.name + " to the Area 69");
        Console.WriteLine("Quick move through how things works");
        Console.WriteLine();

        //TODO tutorial how things works



        //create monsters
        Monster spider = new Monster();
        spider.damage = new Random().Next(1, 8);
        spider.HP = 40;
        spider.name = "spider";
        spider.alive = true;



        //TODO fighting part
        Console.WriteLine("Suddenly a spider has jumped on you, ");
         //game state
        Console.WriteLine("The player has " + player1.hp + " health");
        Console.WriteLine("The spider has " + spider.HP + " health");

            while(spider.HP >= 0){
                //spider attack
                Console.WriteLine("Type \"k\" to attack with knife or \"s\" to attack with sword, or \"block\" to block enemy attack");
                Console.Write("Your weapon or defence: ");
                string action = Console.ReadLine();
                
                if(action == "k"){
                    int knife = new Random().Next(1, 11);
                    spider.HP -= knife;
                    Console.Write("You done " + knife + " damage to spider. ");
                    player1.hp -= spider.damage;
                    Console.Write(" Spider done " + spider.damage + " damage to you.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The spider has " + spider.HP + " health");

                }
                else if(action == "s"){
                    int knife = new Random().Next(7, 25);
                    spider.HP -= knife;
                    int knife2 = new Random().Next(7, 25);
                    spider.HP -= knife2;
                    Console.Write("You done " + knife + "and with second attack " + knife2 + " damage to spider. ");
                    player1.hp -= spider.damage;
                    Console.Write(" Spider done " + spider.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The spider has " + spider.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                }
                

            }
                Console.WriteLine("You killed the spider, now next monster is waiting for you");
                

        //TODO loosing part


        //TODO wining part 
    }


  
    
}

