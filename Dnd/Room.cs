namespace Dnd
{
    public class Room
    {
        private Enemy _enemy;
        private static Random _random = new Random(); // Static Random for consistent use

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

        public static class RoomFactory
        {
           
            public static Room CreateRandomRoom1()
            {
                Enemy randomEnemy = CreateRandomEnemy();
                return new Room(randomEnemy);
            }
            public static Room CreateRandomRoom2()
            {
                Enemy randomEnemy = CreateRandomEnemy();
                return new Room(randomEnemy);
            }
            public static Room CreateRandomRoom3()
            {
                Enemy randomEnemy = CreateRandomEnemy();
                return new Room(randomEnemy);
            }
            public static Room CreateRandomRoom4()
            {
                Enemy randomEnemy = CreateRandomEnemy();
                return new Room(randomEnemy);
            }

            public static Room CreateHub()
            {
                return new Room();
            }

            private static Enemy CreateRandomEnemy()
            {
                int enemyType = _random.Next(4); 

                switch (enemyType)
                {
                    case 0:
                        return Enemy.Factory.CreateOger();
                    case 1:
                        return Enemy.Factory.CreateKnight();
                    case 2:
                        return Enemy.Factory.CreateArcher();
                    case 3:
                        return Enemy.Factory.CreateDragon();
                    default:
                        return null; 
                }
            }
        }
    }
}