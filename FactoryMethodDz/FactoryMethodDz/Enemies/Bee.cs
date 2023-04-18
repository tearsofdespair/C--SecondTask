namespace FactoryMethodDz;

public class Bee : Enemy
{
    public override string Name { get; protected set; } = "Bee";
    public override int Power { get; protected set; } = 10;
    public override float Speed { get; protected set; } = 50;
}