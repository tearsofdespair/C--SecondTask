namespace FactoryMethodDz.Factories;

public class FactoryLevel5 : Factory
{
    public override Level CreateLevel()
        {
            return new Level5();
        }
}