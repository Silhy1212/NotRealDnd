namespace Dnd
{
    public class Enemy
    {
        public string Name;
        public int attackDamage;
        public int HP;
        private int maxHP;
        private float critRate;
        private int critChance;

        public Enemy(string name, int attackDamage, int hp, int maxHp, float critRate, int critChance)
        {
            this.Name = name;
            this.attackDamage = attackDamage;
            HP = hp;
            maxHP = maxHp;
            this.critRate = critRate;
            this.critChance = critChance;
        }
        

        public static class Factory
        {
            public static Enemy CreateOger()
            {
                return new Enemy("Oger", 5, 50, 100, 100, 5);
            }

            public static Enemy CreateRichman()
            {
                return new Enemy("Richman", 5, 100, 100, 100, 5);
            }
        }
    }
}