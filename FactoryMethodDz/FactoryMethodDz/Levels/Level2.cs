namespace FactoryMethodDz;

public class Level2 : Level
{
    public override List<Enemy> Enemies { get; protected set; }
    public override int NumberOfLevel { get; protected set; } = 2;
}