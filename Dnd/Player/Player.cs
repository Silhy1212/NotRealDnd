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
        
        
        

        public Player(Room currentRoom, int attackDamage, int hp, int maxHp, float critRate, int critChance)
        {
            this.currentRoom = currentRoom;
            this.attackDamage = attackDamage;
            HP = hp;
            maxHP = maxHp;
            this.critRate = critRate;
            this.critChance = critChance;
        }

        public void Move(Room nextRoom)
        {
            currentRoom = nextRoom;
            
        }

        public void Attack()
        {
            if (currentRoom.HasEnemy()) 
            {
                Enemy enemy = currentRoom.GetEnemy();
                Upgrades upgrade = new Upgrades();

                if (enemy != null)
                {
                    enemy.HP -= attackDamage;
                    Console.WriteLine($"You attacked {enemy.Name} for {attackDamage} damage!");

                    if (enemy.HP <= 0)
                    {
                        enemy.HP = 0;
                        Console.WriteLine($"{enemy.Name} has been defeated!");
                        upgrade.Upgrade();
                        
                    }
                    else
                    {
                        Console.WriteLine($"{enemy.Name} has {enemy.HP} HP remaining.");
                    }
                    
                    this.HP -= enemy.attackDamage;
                    Console.WriteLine();
                    Console.WriteLine($"{enemy.Name} attacked you.");
                    Console.WriteLine($"You now have {this.HP} HP remaining.");
                    if (this.HP <= 0)
                    {
                        Console.WriteLine("Game Over!");
                    }

                }
            }
            else
            {
                Console.WriteLine("There is no enemy in this room to attack.");
            }
        }

        public void Heal(Enum Potions )
        {
            
            if (HP< maxHP)
            {
                switch (Potions)
                {
                    case Dnd.Potions.small:
                        if (smallpotionCount <=0)
                        {
                            Console.WriteLine("You can't heal more small potions.");
                        }
                        else
                        {
                            HP += 10; 
                            if (HP> maxHP)
                            {
                                HP = maxHP; 
                            }
                            Console.WriteLine($"Hp after healing {this.HP} ");
                        }

                        
                        break;
                    case Dnd.Potions.medium:
                        if (mediumpotionCount <= 0)
                        {
                            Console.WriteLine("You can't heal more medium potions.");
                        }
                        else
                        {
                            HP += 20;
                            if (HP> maxHP)
                            {
                                HP = maxHP; 
                            }
                            Console.WriteLine($"Hp after healing {this.HP} ");
                        }
                        break;
                    case Dnd.Potions.big:
                        if (bigpotionCount <= 0)
                        {
                            Console.WriteLine("You can't heal more big potions.");
                        }
                        else
                        {
                            HP += 30; 
                            if (HP> maxHP)
                            {
                                HP = maxHP; 
                            }
                            Console.WriteLine($"Hp after healing {this.HP} ");
                        }
                        break;
                }
               
            }
            else
            {
                Console.WriteLine("You already have full HP, so you dont have to heal anymore.");
            }

            
       
        }
        public static class Factory
        {
            public static Player CreateGnom()
            {
                return new Player(Room.RoomFactory.CreateHub(), 5, 20, 30, 10, 6);
            }

            public static Player CreateKouzelnik()
            {
                return new Player(Room.RoomFactory.CreateHub(), 5, 20, 30, 10, 6);
            }
            public static Player CreateRytir()
            {
                return new Player(Room.RoomFactory.CreateHub(), 5,20, 30, 10, 6);
            }
            
        }
        
    }
}