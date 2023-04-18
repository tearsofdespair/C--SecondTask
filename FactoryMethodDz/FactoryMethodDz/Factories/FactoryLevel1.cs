namespace FactoryMethodDz.Factories;

public class FactoryLevel1 : Factory
{
    public override Level CreateLevel()
    {
        return new Level1();
    }
}