using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var water = new Water(150);
            var sea = new Sea(150);
            var lake = new Lake(150);
            var continent = new Continent();
            var state = new State();
            Console.WriteLine("Object 'Lake', method 'SomeMethod()': " + lake.SomeMethod() + "\nObject 'Lake' inherited to 'Sea', method 'SomeMethod()': " + ((Sea)lake).SomeMethod());

            Water a = new Sea(150);
            Water b = new Lake(150);

            Console.Write("\n" + water.GetVolume() + "\n" + a.GetVolume() + "\n" + b.GetVolume() + "\n\n");

            Print look = new Print();   

            Console.WriteLine(look.Prints(water));
            Console.WriteLine(look.Prints(continent));
            Console.WriteLine(look.Prints(b));
        }
    }

    class Water 
    {
        protected double volume;
        public Water() { 
        }
        public Water(double volume) { 
            this.volume = volume;
        }

        public virtual double GetVolume()
        {
            return volume;
        }

        public override string ToString()
        {
            return "class Water";
        }
    }

    class Sea : Water
    {
        public Sea() : base(300)
        {
        }

        public Sea(double Place) : base(Place)
        {

        }

        public override double GetVolume()
        {
            return volume / 2;
        }

        public string SomeMethod()
        {
            return "SomeString for Sea";
        }

        public override string ToString()
        {
            return "class Sea";
        }
    }

    class Lake : Sea
    {
        public Lake() : base(300) {
        }

        public Lake(double Place) : base(Place) {
        }

        public override double GetVolume()
        {
            return volume * 2;
        }

        new public int SomeMethod()
        {
            return 1;
        }

        public override string ToString()
        {
            return "class Lake";
        }
    }

    abstract class Land
    {
        abstract public string ToThink();

        public override string ToString()
        {
            return "class Land";
        }
    }

    class Continent : Land
    {
        public override string ToThink()
        {
            return "mem";
        }

        public override string ToString()
        {
            return "class Continent";
        }
    }

    sealed class State : Continent
    {
        public override string ToThink()
        {
            return "Poland forever";
        }

        public override string ToString()
        {
            return "Many" + this.ToThink() + "', definitely about nothing";
        }
    }
}