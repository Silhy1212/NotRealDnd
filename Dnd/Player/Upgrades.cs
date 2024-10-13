namespace Dnd;

public class Upgrades
{
    public Random RandomNumber { get; } = new Random(DateTime.Now.Millisecond);
    public Enum Weapons;
    public Enum Potions;
    public Player Player { get; set; }
    
    
    public void Upgrade()
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
            Console.WriteLine("Ziskal jsi knife");
            Player.attackDamage = 7;
        }
        else if (randomNumber >= 41 && randomNumber <= 71)
        {
            Console.WriteLine("Ziskal jsi dagger");
            Player.attackDamage = 10;
        }
        else if (randomNumber >= 71 && randomNumber <= 91)
        {
            Console.WriteLine("Ziskal jsi sword");
            Player.attackDamage = 15;
        }
        else if (randomNumber >= 91 && randomNumber <= 101)
        {
            Console.WriteLine("Ziskal jsi necrosword");
            Player.attackDamage = 30;
        }
    }
    
}