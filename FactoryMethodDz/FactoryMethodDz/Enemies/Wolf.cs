namespace FactoryMethodDz;

public class Wolf : Enemy
{
    public override string Name { get; protected set; } = "Wolf";
    public override int Power { get; protected set; } = 30;
    public override float Speed { get; protected set; } = 18;

}