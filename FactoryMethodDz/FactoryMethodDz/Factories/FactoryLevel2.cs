namespace FactoryMethodDz.Factories;

public class FactoryLevel2 : Factory
{
    public override Level CreateLevel()
    {
        return new Level2();
    }
}