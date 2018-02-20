using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать класс – Треугольник, заданного тремя точками(Создать класс Point). 
//Методы класса обеспечивают вывод на экран координат, рассчитывают длины сторон и периметр треугольника.
//Создать массив объектов. 
//    a) подсчитать количество треугольников разного типа(равносторонний, равнобедренный, прямоугольный, произвольный).
//    b) определить для каждой группы наибольший и наименьший по периметру объект.

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            Triangle[] mas = new Triangle[100];
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("\nTriangle #" + (i + 1) + ":\n");
                mas[i] = new Triangle(randNum);
                mas[i].lengthside();
                mas[i].Sort();
                mas[i].PrintAll();
            }
            Console.WriteLine("\nType counter:");
            int eq_t = 0;
            int is_t = 0;
            int ri_t = 0;
            int ve_t = 0;
            // "Equilateral triangle";
            // "Isosceles triangle";
            // "Right triangle"
            for (int i = 0; i < mas.Length; i++) {
                if (mas[i].getType() == "Equilateral triangle")
                {
                    eq_t++;
                    continue;
                }
                if (mas[i].getType() == "Isosceles triangle")
                {
                    is_t++;
                    continue;
                }
                if (mas[i].getType() == "Right triangle")
                {
                    ri_t++;
                    continue;
                }
                if (mas[i].getType() == "Versatile triangle")
                {
                    ve_t++;
                    continue;
                }
            }
            Console.Write("Equilateral triangle: " + eq_t + "\nIsosceles triangle: " + is_t + "\nRight triangle: " + ri_t + '\n' + "Versatile triangle: " + ve_t + "\n");

            double max_eq = 0;
            double max_is = 0;
            double max_ri = 0;
            double max_ve = 0;
            double min_eq = mas[0].Perimeter();
            double min_is = mas[0].Perimeter();
            double min_ri = mas[0].Perimeter();
            double min_ve = mas[0].Perimeter();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].getType() == "Equilateral triangle")
                {
                    if (mas[i].Perimeter() > max_eq)
                    {
                        max_eq = mas[i].Perimeter();
                    }
                    if (mas[i].Perimeter() < min_eq)
                    {
                        min_eq = mas[i].Perimeter();
                    }
                }

                if (mas[i].getType() == "Isosceles triangle")
                {
                    if (mas[i].Perimeter() > max_is)
                    {
                        max_is = mas[i].Perimeter();
                    }
                    if (mas[i].Perimeter() < min_is)
                    {
                        min_is = mas[i].Perimeter();
                    }
                }

                if (mas[i].getType() == "Right triangle")
                {
                    if (mas[i].Perimeter() > max_ri)
                    {
                        max_ri = mas[i].Perimeter();
                    }
                    if (mas[i].Perimeter() < min_ri)
                    {
                        min_ri = mas[i].Perimeter();
                    }
                }

                if (mas[i].getType() == "Versatile triangle")
                {
                    if (mas[i].Perimeter() > max_ve)
                    {
                        max_ve = mas[i].Perimeter();
                    }
                    if (mas[i].Perimeter() < min_ve)
                    {
                        min_ve = mas[i].Perimeter();
                    }
                }
            }
            Console.WriteLine("\nMax perimeter equilateral triangle: " + max_eq + "\nMax perimeter isosceles triangle: " + max_is + "\nMax perimeter right triangle: " + max_ri + "\nMax perimeter versatile triangle: " + max_ve);
            Console.WriteLine("\n\nMin perimeter equilateral triangle: " + min_eq + "\nMin perimeter isosceles triangle: " + min_is + "\nMin perimeter right triangle: " + min_ri + "\nMin perimeter versatile triangle: " + min_ve);
        }
    }
}

