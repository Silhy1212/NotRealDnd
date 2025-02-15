﻿namespace Dnd
{
    public class Enemy
    {
        public string Name;
        public int attackDamage;
        public int HP;
        public int maxHP;
        private float critRate;
        private int critChance;
        public Boolean Isliving = true;

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
                return new Enemy("Oger", 5, 15, 20, 100, 1);
            }
            
            public static Enemy CreateKnight()
            {
                return new Enemy("Rytíř", 7, 30, 20, 100, 7);
            }
            public static Enemy CreateArcher()
            {
                return new Enemy("Lučištník", 5, 20, 20, 100, 15);
            }
            

            public static Enemy CreateDragon()
            {
                return new Enemy("Drak", 10, 100, 100, 100, 25);
            }
        }
    }
}