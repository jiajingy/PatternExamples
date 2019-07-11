using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //AbstractFactory();

            //Builder();

            FactoryMethod();

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


        static void FactoryMethod()
        {
            List<Document> documents = new List<Document>();

            documents.Add(new Resume());
            documents.Add(new Report());

            foreach(var doc in documents)
            {
                
                Console.WriteLine(doc.GetType().Name + " consists of:");
                foreach(var page in doc.Pages)
                {
                    Console.WriteLine(page.GetType().Name);
                }

                Console.WriteLine("");
            }

        }
    }
}
