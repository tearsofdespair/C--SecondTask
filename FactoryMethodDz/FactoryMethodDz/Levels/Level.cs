using FactoryMethodDz.ClassHelper;

namespace FactoryMethodDz;

public abstract class Level
{
    public abstract List<Enemy> Enemies { get; protected set; }
    public abstract int NumberOfLevel { get; protected set; }

    public Level()
    {
        Enemies = new List<Enemy>();
        GenerateEnemies(RandomHelper.GetRandom(0, 20));
    }

    private void GenerateEnemies(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Enemies.Add(RandomHelper.GetrandomEnemy());
        }
    }
    
    public virtual void ToConsole()
    {
        int wolfs = 0;
        int bears = 0;
        int bees = 0;
        Console.WriteLine($"Level Number {NumberOfLevel}\n");
        foreach (Enemy enemy in Enemies)
        {
            switch (enemy.GetType())
            {
                case var value when value == typeof(Wolf):
                    wolfs++;
                    break;
                case var value when value == typeof(Bear):
                    bears++;
                    break;
                case var value when value == typeof(Bee):
                    bees++;
                    break;
            }
        }
        
        Console.WriteLine($"Wolfs - {wolfs}");
        Console.WriteLine($"Bears - {bears}");
        Console.WriteLine($"Bees - {bees}");
    }
}