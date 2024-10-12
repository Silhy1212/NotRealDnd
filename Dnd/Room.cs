namespace Dnd
{
    public class Room
    {
        private Enemy _enemy;
        private string Treasure;

        public Room()
        {
            _enemy = null;
        }
        public Room(Enemy enemy)
        {
            _enemy = enemy;
        }
        public Enemy GetEnemy()
        {
            return _enemy;
        }
        public bool HasEnemy() 
        {
            return _enemy != null;
        }
        public Room(string treasure)
        {
            Treasure = treasure;
        }

        public static class RoomFactory
        {
            public static Room CreateHub()
            {
                return new Room();
            }
            public static Room CreateEnemyRoom()
            {
                Enemy enemy = Enemy.Factory.CreateOger();
                return new Room(enemy);
            }
            public static Room CreateBossRoom()
            {
                Enemy enemy = Enemy.Factory.CreateRichman();
                return new Room(enemy);
            }

            public static Room CreateTreasureRoom()
            {
                string treasure = "Ahoj toto je poklad";
                return new Room(treasure);
            }
        }
    }
}