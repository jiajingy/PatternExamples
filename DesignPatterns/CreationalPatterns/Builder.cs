using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder
{
    /// <summary>
    /// Separate the construction of a complex object from its representation so that the same construction process can create different representations.
    /// https://www.dofactory.com/net/builder-design-pattern
    /// </summary>
    class Director
    {
        public void Construct(Builder build)
        {
            build.BuildPartA();
            build.BuildPartB();

        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();

        public abstract Product GetResult();
    }


    class ConcreteBuilder1 : Builder
    {

        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.add("PartA");
        }

        public override void BuildPartB()
        {
            _product.add("PartB");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.add("PartX");
        }

        public override void BuildPartB()
        {
            _product.add("PartY");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    class Product
    {
        private List<string> _parts = new List<string>();
        public void add(string part)
        {
            _parts.Add(part);
        }

        public void show()
        {
            Console.WriteLine("\nProduct Parts ------");
            foreach (var part in _parts)
                Console.WriteLine(part);
        }
    }
}
