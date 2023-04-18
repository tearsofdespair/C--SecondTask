namespace FactoryMethodDz;

public class Level5 : Level
{
    public override List<Enemy> Enemies { get; protected set; }
    public override int NumberOfLevel { get; protected set; } = 5;
}