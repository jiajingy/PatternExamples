using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype
{

    /// <summary>
    /// Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.
    /// https://www.dofactory.com/net/prototype-design-pattern
    /// </summary>
    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;


        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;

        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}",
                _red, _green, _blue);

            return this.MemberwiseClone() as ColorPrototype;
        }

    }


    class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }

}
