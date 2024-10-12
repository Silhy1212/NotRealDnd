namespace Dnd.ActionInput;

public class ActionInput
{
    private Player Player;
    private Room startRoom;
    private Room bossRoom;
    private Room ezRoom;
    private Room midRoom;
    private Room hardRoom;
    

    public void PlayerInput()
    {
        Console.WriteLine("Co chces byt za roli?");
        Console.WriteLine("1 - Kouzelnik");
        Console.WriteLine("2 - Rytir");
        Console.WriteLine("3 - Gnom");

        int startup = Convert.ToInt32(Console.ReadLine());

            
        if (startup == 1)
        {
            Player = Player.Factory.CreateKouzelnik();
            Console.WriteLine("Uspesne se z vas stal kouzelnik");
        }
        else if (startup == 2)
        {
            Player = Player.Factory.CreateRytir();
            Console.WriteLine("Uspesne se z vas stal rytir");
        }
        else if (startup == 3)
        {
            Player = Player.Factory.CreateGnom();
            Console.WriteLine("Uspesne se z vas stal gnom");
        }
        else
        {
            Console.WriteLine("Tak ses asi kokot kliknul jsi na spatne tlacitko");
        }
        while (startup >3)
        {
            startup = Convert.ToInt32(Console.ReadLine());
            if (startup == 1)
            {
                Player = Player.Factory.CreateKouzelnik();
                Console.WriteLine("Uspesne se z vas stal kouzelnik");
                    
            }
            else if (startup == 2)
            {
                Player = Player.Factory.CreateRytir();
                Console.WriteLine("Uspesne se z vas stal rytir");
            }
            else if (startup == 3)
            {
                Player = Player.Factory.CreateGnom();
                Console.WriteLine("Uspesne se z vas stal gnom");
            }
            else
            {
                Console.WriteLine("Tak ses asi kokot kliknul jsi na spatne tlacitko");
            }
        }
        Console.Clear();
       
    }

    public void RoomsInput()
    {
        startRoom = Room.RoomFactory.CreateHub();
        ezRoom = Room.RoomFactory.CreateEnemyRoom();
        midRoom = Room.RoomFactory.CreateEnemyRoom();
        hardRoom = Room.RoomFactory.CreateEnemyRoom();
        bossRoom = Room.RoomFactory.CreateBossRoom();
    }
    
    public void ActionsInput() 
    {
        
        Console.WriteLine("Co chcete delat dale??");
        Console.WriteLine("1 - Vyhealovat se");
        Console.WriteLine("2 - Zautocit");
        Console.WriteLine("3 - Presunout se do jine mistnosti");
        
        int action = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (action == 1)
        {
            Console.WriteLine("Jaky potion si chcete dat");
            Console.WriteLine("1 - Small = 10");
            Console.WriteLine("2 - Medium = 20");
            Console.WriteLine("3 - Big = 30");
            
            int healchoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (healchoice)
            {
                case 1: Player.Heal(Potions.small);
                    Player.smallpotionCount--; break;
                case 2: Player.Heal(Potions.medium);
                    Player.mediumpotionCount--; break;
                case 3: Player.Heal(Potions.big);
                    Player.bigpotionCount--;break;
            }
            
                
        }
        else if (action == 2)
        {
            
            Player.Attack();
            
               
        }
        else if (action == 3)
        {
            Console.Clear();
            Console.WriteLine("In which room do you want to go?");
            Console.WriteLine("1 - Start room");
            Console.WriteLine("2 - Easy enemy room");
            Console.WriteLine("3 - Intermediate enemy room");
            Console.WriteLine("4 - Hard enemy room");
            Console.WriteLine("5 - Boss room");
            int move = Convert.ToInt32(Console.ReadLine());
            switch (move)
            {
                case 1: Player.Move(startRoom);
                    break;
                case 2: Player.Move(ezRoom);
                    break;
                case 3: Player.Move(midRoom);
                    break;
                case 4: Player.Move(hardRoom);
                    break;
                case 5: Player.Move(bossRoom);
                    break;
            }
            Console.Clear();
                
        }
        else
        {
            Console.WriteLine("Tak si asi totalni dement prosim stiskni sparvne tlacitko");
        }
            
        while (action > 3)
        {
           
            Console.Clear();
            action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                
                Player.Heal(Potions.big);
                Console.WriteLine("You healed");
                
            }
            else if (action == 2)
            {
                    
               
                Player.Attack();
               
               
            }
            else if (action == 3)
            {
              
                
            }
            else
            {
                Console.WriteLine("Tak si asi totalni dement prosim stiskni sparvne tlacitko");
            }
            
        }
        
        
    }
    public Player GetPlayer()
    {
        return Player;
    }
    
}