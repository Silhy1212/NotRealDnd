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
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("VÍTEJTE VE HŘE! VYBERTE SI SVOU ROLI:");
            Console.WriteLine("=======================================");
            Console.WriteLine("1 - Kouzelnik");
            Console.WriteLine("2 - Rytir");
            Console.WriteLine("3 - Gnom");
            Console.WriteLine("=======================================");

            int startup = Convert.ToInt32(Console.ReadLine());

            while (startup < 1 || startup > 3)
            {
                Console.Clear();
                Console.WriteLine("ŠPATNÁ VOLBA! ZKUSTE TO ZNOVU.");
                Console.WriteLine("1 - Kouzelnik");
                Console.WriteLine("2 - Rytir");
                Console.WriteLine("3 - Gnom");
                startup = Convert.ToInt32(Console.ReadLine());
            }

            switch (startup)
            {
                case 1:
                    Player = Player.Factory.CreateKouzelnik();
                    Console.Clear();
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Uspěšně se z vás stal Kouzelník!");
                    Console.WriteLine("=======================================");
                    break;
                case 2:
                    Player = Player.Factory.CreateRytir();
                    Console.Clear();
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Uspěšně se z vás stal Rytíř!");
                    Console.WriteLine("=======================================");
                    break;
                case 3:
                    Player = Player.Factory.CreateGnom();
                    Console.Clear();
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Uspěšně se z vás stal Gnom!");
                    Console.WriteLine("=======================================");
                    break;
            }

            Console.WriteLine("Tiskněte libovolnou klávesu pro pokračování...");
            Console.ReadKey();
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
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("CO CHCETE DĚLAT DÁLE?");
            Console.WriteLine("1 - Vyhealovat se");
            Console.WriteLine("2 - Zautočit");
            Console.WriteLine("3 - Přesunout se do jiné místnosti");
            Console.WriteLine("=======================================");

            int action = Convert.ToInt32(Console.ReadLine());

            while (action < 1 || action > 3)
            {
                Console.Clear();
                Console.WriteLine("Neplatná volba, zkuste to znovu.");
                action = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            switch (action)
            {
                case 1:
                    HandleHealing();
                    break;
                case 2:
                    Player.Attack();
                    break;
                case 3:
                    HandleMovement();
                    break;
            }

            Console.WriteLine("Tiskněte libovolnou klávesu pro pokračování...");
            Console.ReadKey();
            Console.Clear();
        }

        private void HandleHealing()
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("JAKÝ POTION SI CHCETE VZÍT?");
            Console.WriteLine("1 - Small (10 HP)");
            Console.WriteLine("2 - Medium (20 HP)");
            Console.WriteLine("3 - Big (30 HP)");
            Console.WriteLine("=======================================");

            int healChoice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            switch (healChoice)
            {
                case 1:
                    Player.Heal(Potions.small);
                    Player.smallpotionCount--;
                    break;
                case 2:
                    Player.Heal(Potions.medium);
                    Player.mediumpotionCount--;
                    break;
                case 3:
                    Player.Heal(Potions.big);
                    Player.bigpotionCount--;
                    break;
                default:
                    Console.WriteLine("Neplatná volba.");
                    break;
            }
        }

        private void HandleMovement()
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("DO KTERÉ MÍSTNOSTI SE CHCETE PŘESUNOUT?");
            Console.WriteLine("1 - Startovní místnost");
            Console.WriteLine("2 - Lehčí nepřátelská místnost");
            Console.WriteLine("3 - Střední nepřátelská místnost");
            Console.WriteLine("4 - Těžká nepřátelská místnost");
            Console.WriteLine("5 - Boss místnost");
            Console.WriteLine("=======================================");

            int move = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            switch (move)
            {
                case 1:
                    Player.Move(startRoom);
                    Console.WriteLine("Přesunuli jste se do Startovní místnosti.");
                    break;
                case 2:
                    Player.Move(ezRoom);
                    Console.WriteLine("Přesunuli jste se do Lehčí nepřátelské místnosti.");
                    break;
                case 3:
                    Player.Move(midRoom);
                    Console.WriteLine("Přesunuli jste se do Střední nepřátelské místnosti.");
                    break;
                case 4:
                    Player.Move(hardRoom);
                    Console.WriteLine("Přesunuli jste se do Těžké nepřátelské místnosti.");
                    break;
                case 5:
                    Player.Move(bossRoom);
                    Console.WriteLine("Přesunuli jste se do Boss místnosti.");
                    break;
                default:
                    Console.WriteLine("Neplatná volba.");
                    break;
            }
        }
    public Player GetPlayer()
    {
        return Player;
    }
    
}