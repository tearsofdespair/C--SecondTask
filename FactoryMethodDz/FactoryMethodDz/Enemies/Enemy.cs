namespace FactoryMethodDz;

public abstract class Enemy
{
    public abstract string Name { get; protected set; }
    public abstract int Power { get;  protected set; }
    public abstract float Speed { get; protected set; }

    public virtual void ToConsole()
    {
        if (Name != null && Power != null && Speed != null)
            Console.WriteLine($"Name : {Name}\nPower : {Power}\nSpeed : {Speed}\n\n");
        else
            throw new NotImplementedException();
    }
}