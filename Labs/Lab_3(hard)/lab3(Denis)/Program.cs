using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_hard_ {
    class Program {
        static void Main(string[] args) {
            Triangle[] arr = new Triangle[10000];
            Random randNum = new Random();

            //static readonly int Equilateral = 0;
            //static readonly int Isosceles = 1;
            //static readonly int Right = 2;
            //static readonly int Versatile = 3;

            int maxE = -1, minE = -1, countE = 0;
            int maxI = -1, minI = -1, countI = 0;
            int maxR = -1, minR = -1, countR = 0;
            int maxV = -1, minV = -1, countV = 0;


            for (int i = 0; i < arr.Length; i++) {
                arr[i] = new Triangle(randNum, 0, 14);
                Console.WriteLine(arr[i].ToString());
                switch (arr[i].TType) {
                    case 0:
                        countE++;
                        if (maxE == -1) {
                            maxE = i;
                            minE = i;
                            break;
                        }
                        if (arr[i].Perimeter() < arr[minE].Perimeter()) {
                            minE = i;
                            break;
                        }
                        if (arr[i].Perimeter() > arr[maxE].Perimeter()) {
                            maxE = i;
                            break;
                        }
                        break;
                    case 1:
                        countI++;
                        if (maxI == -1) {
                            maxI = i;
                            minI = i;
                            break;
                        }
                        if (arr[i].Perimeter() < arr[minI].Perimeter()) {
                            minI = i;
                            break;
                        }
                        if (arr[i].Perimeter() > arr[maxI].Perimeter()) {
                            maxI = i;
                            break;
                        }
                        break;
                    case 2:
                        countR++;
                        if (maxR == -1) {
                            maxR = i;
                            minR = i;
                            break;
                        }
                        if (arr[i].Perimeter() < arr[minR].Perimeter()) {
                            minR = i;
                            break;
                        }
                        if (arr[i].Perimeter() > arr[maxR].Perimeter()) {
                            maxR = i;
                            break;
                        }
                        break;
                    case 3:
                        countV++;
                        if (maxV == -1) {
                            maxV = i;
                            minV = i;
                            break;
                        }
                        if (arr[i].Perimeter() < arr[minV].Perimeter()) {
                            minV = i;
                            break;
                        }
                        if (arr[i].Perimeter() > arr[maxV].Perimeter()) {
                            maxV = i;
                            break;
                        }
                        break;
                }

            }
            Console.Write("-----------------------------------------------------------------------\n");
            Console.Write("Object counter: " + Triangle.ObjectCounter + "\n\n");
            Console.Write("Equilateral triangles counter: " + countE);
            if (minE != -1) {
                Console.Write("\nmin Perimeter: triangle with hash = " + arr[minE].GetHashCode() + ", with P = " + arr[minE].Perimeter());
                Console.Write("\nmax Perimeter: triangle with hash = " + arr[maxE].GetHashCode() + ", with P = " + arr[maxE].Perimeter());
            }
            Console.Write("\n\nIsosceles triangles counter: " + countI);
            if (minI != -1) {
                Console.Write("\nmin Perimeter: triangle with hash = " + arr[minI].GetHashCode() + ", with P = " + arr[minI].Perimeter());
                Console.Write("\nmax Perimeter: triangle with hash = " + arr[maxI].GetHashCode() + ", with P = " + arr[maxI].Perimeter());
            }
            Console.Write("\n\nRight triangles counter: " + countR);
            if (minR != -1) {
                Console.Write("\nmin Perimeter: triangle with hash = " + arr[minR].GetHashCode() + ", with P = " + arr[minR].Perimeter());
                Console.Write("\nmax Perimeter: triangle with hash = " + arr[maxR].GetHashCode() + ", with P = " + arr[maxR].Perimeter());
            }
            Console.Write("\n\nVersatile triangles counter: " + countV);
            if (minV != -1) {
                Console.Write("\nmin Perimeter: triangle with hash = " + arr[minV].GetHashCode() + ", with P = " + arr[minV].Perimeter());
                Console.Write("\nmax Perimeter: triangle with hash = " + arr[maxV].GetHashCode() + ", with P = " + arr[maxV].Perimeter());
            }
            Console.Write("\n\n");

        }
    }
}
