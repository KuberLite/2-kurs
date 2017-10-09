using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Triangle {

        private double side1;
        private double side2;
        private double side3;
        private double r;
        private double y;
        private double t;

        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }

        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }

        public double Side3
        {
            get { return side3; }
            set { side3 = value; }
        }


        private struct Coords
        {
            public int X, Y;
        }
        Coords[] triangle;
        public Triangle()
        {
            triangle = new Coords[3];
            Random num = new Random();
            for (int i = 0; i < 3; i++)
            {
                triangle[i].X = num.Next(1, 10);
                triangle[i].Y = num.Next(1, 10);
            }
        }
            public Triangle(Random randNum)
            {
                triangle = new Coords[3];
                for (int i = 0; i < 3; i++)
                {
                    triangle[i].X = randNum.Next(1, 10);
                    triangle[i].Y = randNum.Next(1, 10);
                }
            }

        public int lengthside()
        {
            side1 = Convert.ToDouble(Math.Round(Math.Sqrt(Math.Pow((triangle[1].X - triangle[0].X), 2) + Math.Pow((triangle[1].Y - triangle[0].Y), 2)), 2));
            side2 = Convert.ToDouble(Math.Round(Math.Sqrt(Math.Pow((triangle[2].X - triangle[1].X), 2) + Math.Pow((triangle[2].X - triangle[1].Y), 2)), 2));
            side3 = Convert.ToDouble(Math.Round(Math.Sqrt(Math.Pow((triangle[2].X - triangle[0].X), 2) + Math.Pow((triangle[2].Y - triangle[0].Y), 2)), 2));
            return 0;
        }

        public void PrintAll()
        {
            Console.WriteLine("AB = " + side1 + "\nCB = " + side2 + "\nCA = " + side3);
            Console.WriteLine("A(" + triangle[0].X + ";" + triangle[0].Y + ")" + " " + "B(" + triangle[1].X + ";" + triangle[1].Y + ")" + " " + "C(" + triangle[2].X + ";" + triangle[2].Y + ")");
            Console.WriteLine("Perimeter of triangle is " + (side1 + side2 + side3));
            Console.WriteLine(getType());
        }

        public double Perimeter()
        {
            return (side1 + side2 + side3);
        }

        public void Sort()
        {
            r = Math.Pow(side1, 2) + Math.Pow(side2, 2);
            t = Math.Pow(side2, 2) + Math.Pow(side3, 2);
            y = Math.Pow(side1, 2) + Math.Pow(side3, 2);
        }

        public string getType()
        {
            if (side1 == side2 && side1 == side3 && side2 == side3) return "Equilateral triangle";
            if (side1 == side2 || side1 == side3 || side2 == side3) return "Isosceles triangle";
            if (Math.Pow(side1, 2) == r || Math.Pow(side2, 2) == y || Math.Pow(side3, 2) == r) return "Right triangle";
            return "Versatile triangle";
        }
    }
}
