using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //AbstractFactory();

            Builder();

            Console.ReadKey();
        }



        static void AbstractFactory()
        {
            ContinentFactory africaContinent = new AfricaFactory();
            AnimalWorld animalWorld = new AnimalWorld(africaContinent);
            animalWorld.RunFoodChain();

            ContinentFactory americaContinent = new AmericaFactory();
            animalWorld = new AnimalWorld(americaContinent);
            animalWorld.RunFoodChain();
                
        }

        static void Builder()
        {
            Director director = new Director();
            ConcreteBuilder1 b1 = new ConcreteBuilder1();
            ConcreteBuilder2 b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.show();


            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.show();
                


        }
    }
}
