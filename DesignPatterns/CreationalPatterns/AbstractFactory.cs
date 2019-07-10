using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{

    /// <summary>
    /// Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
    /// https://www.dofactory.com/net/abstract-factory-design-pattern
    /// </summary>
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();

        public abstract Carnivore CreateCarnivore();
    }


    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }

    class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }


    abstract class Herbivore
    {

    }

    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }


    class Wildebeest : Herbivore
    {

    }

    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }


    class Bison : Herbivore
    {

    }

    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }


    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }

}
