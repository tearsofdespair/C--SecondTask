namespace FactoryMethodDz.ClassHelper;

public class RandomHelper
{
    private static Random _rnd = new Random();

    public static int GetRandom(int min, int max)
    {
        return _rnd.Next(min, max);
    }

    public static Enemy GetrandomEnemy()
    {
        int x = _rnd.Next(0, 3);
        switch (x)
        {
            case 0:
                return new Bear();
                break;
            case 1:
                return new Bee();
                break;
            case 2:
                return new Wolf();
                break;
        }

        throw new Exception("hueta");
    }
}