namespace FactoryMethodDz;

public class Bear : Enemy
{
    public override string Name { get; protected set; } = "Bear";
    public override int Power { get; protected set; } = 50;
    public override float Speed { get; protected set; } = 5;
}