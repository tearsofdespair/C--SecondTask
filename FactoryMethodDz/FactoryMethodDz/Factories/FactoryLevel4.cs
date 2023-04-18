namespace FactoryMethodDz.Factories;

public class FactoryLevel4 : Factory
{
    public override Level CreateLevel()
        {
            return new Level4();
        }
}