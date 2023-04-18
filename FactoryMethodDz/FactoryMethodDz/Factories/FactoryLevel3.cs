namespace FactoryMethodDz.Factories;

public class FactoryLevel3 : Factory
{
    public override Level CreateLevel()
    {
        return new Level3();
    }
}