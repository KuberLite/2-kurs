using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_hard_ {
    class Triangle {
        private struct Point {
            public int X;
            public int Y;
        }
        static public int ObjectCounter;
        static readonly int Equilateral = 0;
        static readonly int Isosceles   = 1;
        static readonly int Right       = 2;
        static readonly int Versatile   = 3;

        private Point[] PArr = new Point[3];
        private double[] SArr = new double[3];
        public readonly int TType;

        static Triangle() {
            ObjectCounter = 0;
        }

        public Triangle() {
            ObjectCounter++;
            Random randNum = new Random();
            for (int i = 0; i < 2; i++) {
                PArr[i].X = randNum.Next(1, 10);
                PArr[i].Y = randNum.Next(1, 10);
            }
            this.setLength();
            TType = this.getType();
        }
        public Triangle(Random randNum) {
            ObjectCounter++;
            for (int i = 0; i < 2; i++) {
                PArr[i].X = randNum.Next(1, 10);
                PArr[i].Y = randNum.Next(1, 10);
            }
            this.setLength();
            TType = this.getType();
        }
        public Triangle(Random randNum, int minRandValue, int maxRandValue) {
            ObjectCounter++;
            for (int i = 0; i < 2; i++) {
                PArr[i].X = randNum.Next(minRandValue, maxRandValue);
                PArr[i].Y = randNum.Next(minRandValue, maxRandValue);
            }
            this.setLength();
            TType = this.getType();
        }

        private void setLength() {
            SArr[0] = Convert.ToDouble(Math.Round(Math.Sqrt(Math.Pow((PArr[1].X - PArr[0].X), 2) + Math.Pow((PArr[1].Y - PArr[0].Y), 2)), 2));
            SArr[1] = Convert.ToDouble(Math.Round(Math.Sqrt(Math.Pow((PArr[1].X - PArr[2].X), 2) + Math.Pow((PArr[1].Y - PArr[2].Y), 2)), 2));
            SArr[2] = Convert.ToDouble(Math.Round(Math.Sqrt(Math.Pow((PArr[2].X - PArr[0].X), 2) + Math.Pow((PArr[2].Y - PArr[0].Y), 2)), 2));
        }

        public double Perimeter() {
            return SArr[0] + SArr[1] + SArr[2];
        }

        private int getType() {
            if (SArr[0] == SArr[1] && SArr[0] == SArr[2] && SArr[1] == SArr[2]) return Equilateral;
            if (SArr[0] == SArr[1] || SArr[0] == SArr[2] || SArr[1] == SArr[2]) return Isosceles;
            if (SArr[0] == Math.Sqrt(Math.Pow(SArr[1], 2) + Math.Pow(SArr[2], 2)) || SArr[1] == Math.Sqrt(Math.Pow(SArr[0], 2) + Math.Pow(SArr[2], 2)) || SArr[2] == Math.Sqrt(Math.Pow(SArr[0], 2) + Math.Pow(SArr[1], 2))) return Right;
            return Versatile;
        }

        private string getTypeString() {
            switch (TType) {
                case 0:
                    return "Equilateral";
                case 1:
                    return "Isosceles";
                case 2:
                    return "Right";
                case 3:
                    return "Versatile";
            }
            return "Unexpected Error";
        }

        public override string ToString() {
            string str = "Triangle " + this.GetHashCode() + "\n A(" + PArr[0].X + ", " + PArr[0].Y + "); B(" + PArr[1].X + ", " + PArr[1].Y + "); C(" + PArr[2].X + ", " + PArr[2].Y + ");\n";
            str += " AB = " + SArr[0] + "; BC = " + SArr[1] + "; AC = " + SArr[2] + ";\n Triangle perimeter = " + this.Perimeter() + '\n';
            str += " Triangle type is: " + this.getTypeString() + "\n";
            return str;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}
