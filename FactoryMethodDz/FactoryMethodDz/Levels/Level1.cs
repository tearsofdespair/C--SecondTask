namespace FactoryMethodDz;

public class Level1 : Level
{
    public override List<Enemy> Enemies { get; protected set; }
    public override int NumberOfLevel { get; protected set; } = 1;
}