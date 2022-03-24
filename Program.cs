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

        Monster worm = new Monster();
        worm.damage = new Random().Next(2, 12);
        worm.HP = 80;
        worm.name = "worm";
        worm.alive = true;

        Monster slime = new Monster();
        slime.damage = new Random().Next(15, 30);
        slime.HP = 150;
        slime.name = "slime";
        slime.alive = true;

        Monster skeleton = new Monster();
        skeleton.damage = new Random().Next(41, 69);
        skeleton.HP = 250;
        skeleton.name = "skeleton";
        skeleton.alive = true;

        Monster succubus = new Monster();
        succubus.damage = new Random().Next(69, 169);
        succubus.HP = 420;
        succubus.name = "succubus";
        succubus.alive = true;




        //TODO fighting part
        Console.WriteLine("Suddenly a spider has jumped on you, ");
         //game state
        Console.WriteLine("The player has " + player1.hp + " health");
        Console.WriteLine("The spider has " + spider.HP + " health");


        //fight vs spider
            while(spider.HP >= 0){
                //spider attack
                Console.WriteLine("Type \"k\" to attack with knife or \"s\" to attack with sword, or \"b\" to block enemy attack");
                Console.Write("Your weapon or defence: ");
                string action = Console.ReadLine();
                
                if(action == "k"){
                 int knife = new Random().Next(1, 11);
                    spider.HP -= knife;
                    int knife2 = new Random().Next(1, 11);
                    spider.HP -= knife2;
                    Console.Write("You done " + knife + " damage and with second attack " + knife2 + " damage to spider. ");
                    player1.hp -= spider.damage;
                    Console.WriteLine(" Spider done " + spider.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The spider has " + spider.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                else if(action == "s"){
                    int sword = new Random().Next(5, 25);
                    spider.HP -= sword;
                    Console.Write("You done " + sword + " damage to spider. ");
                    player1.hp -= spider.damage;
                    Console.WriteLine(" Spider done " + spider.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The spider has " + spider.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                    else if(action == "b"){
                    int block = new Random().Next(1, 5);
                    if(player1.hp < 100){
                        player1.hp += block;
                    }
                    else{
                        Console.WriteLine("You can't heal more hp");
                    }
                    
                    Console.WriteLine("You have blocked " + spider.damage + " damage from spider and healed " + block + " HP.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The spider has " + spider.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");


                    
                }
                
                    if(player1.hp <= 0){
                    Console.WriteLine("uffff you died, good luck next time");
                    }
            }
                Console.WriteLine("You killed the spider, now next monster is waiting for you");
                

        //fight vs worm
        while(worm.HP >= 0){
                //worm attack
                Console.WriteLine("Type \"k\" to attack with knife or \"s\" to attack with sword, or \"b\" to block enemy attack");
                Console.Write("Your weapon or defence: ");
                string action = Console.ReadLine();
                
                if(action == "k"){
                 int knife = new Random().Next(1, 11);
                    worm.HP -= knife;
                    int knife2 = new Random().Next(1, 11);
                    worm.HP -= knife2;
                    Console.Write("You done " + knife + " damage and with second attack " + knife2 + " damage to worm. ");
                    player1.hp -= worm.damage;
                    Console.WriteLine(" worm done " + worm.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The worm has " + worm.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                else if(action == "s"){
                    int sword = new Random().Next(5, 25);
                    worm.HP -= sword;
                    Console.Write("You done " + sword + " damage to worm. ");
                    player1.hp -= worm.damage;
                    Console.WriteLine(" worm done " + worm.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The worm has " + worm.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                    else if(action == "b"){
                    int block = new Random().Next(1, 5);
                    if(player1.hp < 100){
                        player1.hp += block;
                    }
                    else{
                        Console.WriteLine("You can't heal more hp");
                    }
                    
                    Console.WriteLine("You have blocked " + worm.damage + " damage from worm and healed " + block + " HP.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The worm has " + worm.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                

            }
                    if(player1.hp <= 0){
                    Console.WriteLine("uffff you died, good luck next time");
                    }
                Console.WriteLine("You killed the worm, now next monster is waiting for you");
  

        //fight vs slime
            while(slime.HP >= 0){
                while(player1.hp <= 0){
                    Environment.Exit(0);
                }
                //slime attack
                Console.WriteLine("Type \"k\" to attack with knife or \"s\" to attack with sword, or \"b\" to block enemy attack");
                Console.Write("Your weapon or defence: ");
                string action = Console.ReadLine();
                
                if(action == "k"){
                 int knife = new Random().Next(1, 11);
                    slime.HP -= knife;
                    int knife2 = new Random().Next(1, 11);
                    slime.HP -= knife2;
                    Console.Write("You done " + knife + " damage and with second attack " + knife2 + " damage to slime. ");
                    player1.hp -= slime.damage;
                    Console.WriteLine(" slime done " + slime.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The slime has " + slime.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                else if(action == "s"){
                    int sword = new Random().Next(5, 25);
                    slime.HP -= sword;
                    Console.Write("You done " + sword + " damage to slime. ");
                    player1.hp -= slime.damage;
                    Console.WriteLine(" slime done " + slime.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The slime has " + slime.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                    else if(action == "b"){
                    int block = new Random().Next(1, 5);
                    if(player1.hp < 100){
                        player1.hp += block;
                    }
                    else{
                        Console.WriteLine("You can't heal more hp");
                    }
                    
                    Console.WriteLine("You have blocked " + slime.damage + " damage from slime and healed " + block + " HP.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The slime has " + slime.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                

            }
            
                Console.WriteLine("You killed the slime, now next monster is waiting for you");
           

          //fight vs skeleton
            while(skeleton.HP >= 0){
                 while(player1.hp <= 0){
                    Environment.Exit(0);
                }
                //skeleton attack
                Console.WriteLine("Type \"k\" to attack with knife or \"s\" to attack with sword, or \"b\" to block enemy attack");
                Console.Write("Your weapon or defence: ");
                string action = Console.ReadLine();
                
                if(action == "k"){
                 int knife = new Random().Next(1, 11);
                    skeleton.HP -= knife;
                    int knife2 = new Random().Next(1, 11);
                    skeleton.HP -= knife2;
                    Console.Write("You done " + knife + " damage and with second attack " + knife2 + " damage to skeleton. ");
                    player1.hp -= skeleton.damage;
                    Console.WriteLine(" skeleton done " + skeleton.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The skeleton has " + skeleton.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                else if(action == "s"){
                    int sword = new Random().Next(5, 25);
                    skeleton.HP -= sword;
                    Console.Write("You done " + sword + " damage to skeleton. ");
                    player1.hp -= skeleton.damage;
                    Console.WriteLine(" skeleton done " + skeleton.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The skeleton has " + skeleton.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                    else if(action == "b"){
                    int block = new Random().Next(1, 5);
                    if(player1.hp < 100){
                        player1.hp += block;
                    }
                    else{
                        Console.WriteLine("You can't heal more hp");
                    }
                    
                    Console.WriteLine("You have blocked " + skeleton.damage + " damage from skeleton and healed " + block + " HP.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The skeleton has " + skeleton.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                

            }
                Console.WriteLine("You killed the skeleton, now next monster is waiting for you");
                

          //fight vs succubus
            while(succubus.HP >= 0){
                 while(player1.hp <= 0){
                    Environment.Exit(0);
                }
                //succubus attack
                Console.WriteLine("Type \"k\" to attack with knife or \"s\" to attack with sword, or \"b\" to block enemy attack");
                Console.Write("Your weapon or defence: ");
                string action = Console.ReadLine();
                
                if(action == "k"){
                 int knife = new Random().Next(1, 11);
                    succubus.HP -= knife;
                    int knife2 = new Random().Next(1, 11);
                    succubus.HP -= knife2;
                    Console.Write("You done " + knife + " damage and with second attack " + knife2 + " damage to succubus. ");
                    player1.hp -= succubus.damage;
                    Console.WriteLine(" succubus done " + succubus.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The succubus has " + succubus.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                else if(action == "s"){
                    int sword = new Random().Next(5, 25);
                    succubus.HP -= sword;
                    Console.Write("You done " + sword + " damage to succubus. ");
                    player1.hp -= succubus.damage;
                    Console.WriteLine(" succubus done " + succubus.damage + " damage to you.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The succubus has " + succubus.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                    else if(action == "b"){
                    int block = new Random().Next(1, 5);
                    if(player1.hp < 100){
                        player1.hp += block;
                    }
                    else{
                        Console.WriteLine("You can't heal more hp");
                    }
                    
                    Console.WriteLine("You have blocked " + succubus.damage + " damage from succubus and healed " + block + " HP.");
                    Console.WriteLine("The player has " + player1.hp + " health");
                    Console.WriteLine("The succubus has " + succubus.HP + " health");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                

            }
           
  
        //TODO loosing part

        
        //TODO wining part 
        if(succubus.HP <= 0){
            Console.WriteLine("Conrgatulations for killing all of the monsters in area");
            Console.WriteLine("Victory");
        }

           
    }

  
    
}

