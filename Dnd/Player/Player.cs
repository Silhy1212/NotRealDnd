namespace Dnd
{
    public class Player
    {
        
        private Room currentRoom;
        public int attackDamage;
        public int HP;
        private int maxHP;
        private float critRate;
        private int critChance;
        public int smallpotionCount = 1;
        public int bigpotionCount = 1;
        public int mediumpotionCount = 1;
        public string Name;
        public string Weapon = "Pěst";
        
        
        

        public Player(Room currentRoom, int attackDamage, int hp, int maxHp, float critRate, int critChance, string Name)
        {
            this.currentRoom = currentRoom;
            this.attackDamage = attackDamage;
            HP = hp;
            maxHP = maxHp;
            this.critRate = critRate;
            this.critChance = critChance;
            this.Name = Name;
        }

        public void Move(Room nextRoom)
        {
            currentRoom = nextRoom;
            
        }

        public void Attack()
        
{
    int enemylife = 1;
    Console.Clear();
    if (currentRoom.HasEnemy()) 
    {
        Enemy enemy = currentRoom.GetEnemy();
        Upgrades upgrade = new Upgrades();

        if (enemy != null)
        {
            
            if (enemy.Isliving == true)
            {
                enemy.HP -= attackDamage;
                Console.WriteLine($"Zautočili jste na {enemy.Name} za {attackDamage} damage!");
                this.HP -= enemy.attackDamage;
                Console.WriteLine();
                Console.WriteLine($"{enemy.Name} na vás zaútočil.");
                Console.WriteLine($"Zbývá vám {this.HP} HP.");
            }
            
            if (enemy.HP <= 0)
            {
                
                enemy.HP = 0;
                Console.WriteLine($"=======================================");
                Console.WriteLine($"{enemy.Name} byl poražen!");
                if (enemy.Isliving)
                {
                    upgrade.Upgrade(this); 
                }
                enemy.Isliving = false;
                Console.WriteLine("=======================================");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} má ještě {enemy.HP} HP.");
            }

            
            if (this.HP <= 0)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("GAME OVER!");
                Console.WriteLine("=======================================");
            }
        }
    }
    else
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("V této místnosti není žádný nepřítel.");
        Console.WriteLine("=======================================");
    }
}

        public void Stats()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Vaše statistiky:");
            Console.WriteLine($"Role: {this.Name}");
            Console.WriteLine($"Attack damage: {this.attackDamage}");
            Console.WriteLine($"Životy: {this.HP}");
            Console.WriteLine($"Šance na critical strike: {this.critChance}%");
            Console.WriteLine($"=======================================");
            
        }

        public void Inventory()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Váš Inventář:");
            Console.WriteLine($"Zbraň: {this.Weapon}(attack damage: {this.attackDamage})");
            Console.WriteLine($"Počet malých potionů: {this.smallpotionCount}");
            Console.WriteLine($"Počet středně velkých potionů: {this.mediumpotionCount}");
            Console.WriteLine($"Počet velkých potionů: {this.bigpotionCount}");

            Console.WriteLine($"=======================================");
        }        
public void Heal(Enum potionType)
{
    if (HP < maxHP)
    {
        switch (potionType)
        {
            case Dnd.Potions.small:
                if (smallpotionCount <= 0)
                {
                    Console.WriteLine("Nemáte žádné malé potiony.");
                   
                }
                else
                {
                    HP += 10;
                    if (HP > maxHP) HP = maxHP;
                    Console.WriteLine($"Vyléčili jste se na {HP} HP.");
                    this.smallpotionCount--;
                }
                break;
            case Dnd.Potions.medium:
                if (mediumpotionCount <= 0)
                {
                    Console.WriteLine("Nemáte žádné střední potiony.");
                    
                }
                else
                {
                    HP += 20;
                    if (HP > maxHP) HP = maxHP;
                    Console.WriteLine($"Vyléčili jste se na {HP} HP.");
                    this.mediumpotionCount--;
                }
                break;
            case Dnd.Potions.big:
                if (bigpotionCount <= 0)
                {
                    Console.WriteLine("Nemáte žádné velké potiony.");
                    
                }
                else
                {
                    HP += 30;
                    if (HP > maxHP) HP = maxHP;
                    Console.WriteLine($"Vyléčili jste se na {HP} HP.");
                    this.mediumpotionCount--;

                }
                break;
        }
    }
    else
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("Jste již na plném zdraví.");
        Console.WriteLine("=======================================");
    }
}
        public static class Factory
        {
            public static Player CreateGnom()
            {
                return new Player(Room.RoomFactory.CreateHub(), 20, 20, 30, 10, 6, "Gnom");
            }

            public static Player CreateKouzelnik()
            {
                return new Player(Room.RoomFactory.CreateHub(), 20, 20, 30, 10, 6, "Kouzelník");
            }
            public static Player CreateRytir()
            {
                return new Player(Room.RoomFactory.CreateHub(), 5,20, 30, 10, 6, "Rytíř");
            }
            
        }
        
    }
}