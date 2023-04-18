using FactoryMethodDz.Factories;

namespace FactoryMethodDz;

public class Interface
{
    public static void Start()
    {
        Factory factory;
        string a = "";
        int x = -1;
        while (true)
        {
            Console.WriteLine("Введите число от 1 до 5 чтобы выбрать уровень сложности, или введите \'exit\' чтобы выйти");
            try
            {
                a = Console.ReadLine();
                x = int.Parse(a);
            }
            catch (Exception e)
            {
                if(a == "exit")
                    break;
                continue;
            }

            factory = null;
            if (x > 0)
            {
                switch (x)
                {
                    case 1:
                        factory = new FactoryLevel1();
                        break;
                    case 2:
                        factory = new FactoryLevel2();
                        break;
                    case 3:
                        factory = new FactoryLevel3();
                        break;
                    case 4:
                        factory = new FactoryLevel4();
                        break;
                    case 5:
                        factory = new FactoryLevel5();
                        break;
                    default:
                        factory = null;
                        break;
                }
            }
            
            
            factory?.CreateLevel().ToConsole();
        }
    }
}