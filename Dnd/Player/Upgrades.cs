namespace Dnd;

public class Upgrades
{
    public Random RandomNumber { get; } = new Random(DateTime.Now.Millisecond);
    public Enum Weapons;
    public Enum Potions;
   
    
    
    public void Upgrade(Player Player)
    {
      
       
        int randomNumber = RandomNumber.Next(1, 101);

        if (randomNumber >=1 && randomNumber <= 61)
        {
            Console.WriteLine("Ziskal jsi maly potion");
            
            Player.smallpotionCount += 1;
            
        }
        else if (randomNumber >= 61 && randomNumber <= 91)
        {
            Console.WriteLine("Ziskal jsi medium potion");
            Player.mediumpotionCount += 1;
        }
        else if (randomNumber >= 91 && randomNumber <= 101)
        {
           Console.WriteLine("Ziskal jsi large potion"); 
           Player.bigpotionCount += 1;
        }
        int randomPotion = RandomNumber.Next(1, 101);
        if (randomNumber >=1 && randomNumber <= 41)
        {
            Console.WriteLine("Nasel jsi knife");
            Console.WriteLine("Chces si ho vzit?");
            Console.WriteLine("=======================================");
            Console.WriteLine("1 - Ano");
            Console.WriteLine("2 - Ne");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                Player.attackDamage = 7;
                Console.WriteLine($"Tvůj attack damage je nyní {Player.attackDamage}");            }
            else if (action == 2)
            {
                Player.attackDamage = Player.attackDamage;
            }
            
        }
        else if (randomNumber >= 41 && randomNumber <= 71)
        {
            Console.WriteLine("Nasel jsi dagger");
            Console.WriteLine("Chces si ho vzit?");
            Console.WriteLine("=======================================");
            Console.WriteLine("1 - Ano");
            Console.WriteLine("2 - Ne");
            Console.WriteLine("=======================================");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                Player.attackDamage = 10;
                Console.WriteLine($"Tvůj attack damage je nyní {Player.attackDamage}");
            }
            else if (action == 2)
            {
                Player.attackDamage = Player.attackDamage;
            }
        }
        else if (randomNumber >= 71 && randomNumber <= 91)
        {
            Console.WriteLine("Nasel jsi sword");
            Console.WriteLine("Chces si ho vzit?");
            Console.WriteLine("=======================================");
            Console.WriteLine("1 - Ano");
            Console.WriteLine("2 - Ne");
            Console.WriteLine("=======================================");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                Player.attackDamage = 15;
                Console.WriteLine($"Tvůj attack damage je nyní {Player.attackDamage}");            }
            else if (action == 2)
            {
                Player.attackDamage = Player.attackDamage;
            }
        }
        else if (randomNumber >= 91 && randomNumber <= 101)
        {
            Console.WriteLine("Nasel jsi necrosword");
            Console.WriteLine("Chces si ho vzit?");
            Console.WriteLine("=======================================");
            Console.WriteLine("1 - Ano");
            Console.WriteLine("2 - Ne");
            Console.WriteLine("=======================================");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                Player.attackDamage = 30;
                Console.WriteLine($"Tvůj attack damage je nyní {Player.attackDamage}");            }
            else if (action == 2)
            {
                Player.attackDamage = Player.attackDamage;
            }
        }
    }
    
}