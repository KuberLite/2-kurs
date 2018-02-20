using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{

    class Year
    {
        public string Name { get; set; }
        public List<string> season { get; set; }
        public Year()
        {
            season = new List<string>();
        }
    }

    class Triangle
    {
        public string name { get; set; }
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public int per;
        public int x;
        public int y;
        public int z;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int len;
            string enterSeason;

            string[] mounth = { "June", "July", "May", "December", "January", "October", "September", "August", "February", "April", "March", "November" };

            int caseSwitch = 0;

            do
            {
                Console.Clear();
                Console.Write("1. Months by length\n2. Months by season\n3. Conclusion by alphabet\n4. Mounth with 'u' and <= 4\n5. Triangle\n0. Exit\n");
                Console.Write(">>");
                caseSwitch = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (caseSwitch)
                {
                    default:
                        Console.Write("\nWrong number!");
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 1:
                        List<string> selectedMounth = new List<string>();

                        Console.Write("{ ");
                        foreach (string str in mounth)
                        {
                            Console.Write(str + " ");
                        }
                        Console.Write("}");

                        Console.Write("\nEnter the length of the month(3-9):");

                        len = Convert.ToInt32(Console.ReadLine());

                        IEnumerable<string> lengthMounth = mounth.Where(lm => lm.Length == len);
                        try
                        {
                            foreach (string s in lengthMounth)
                                Console.WriteLine(s);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\n" + ex.Message);
                        }
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Enter the season of the year: ");
                        enterSeason = Console.ReadLine();
                        List<Year> year = new List<Year>
                        {
                            new Year {Name="June", season= new List<string> {"Summer"}},
                            new Year {Name="July", season = new List<string> {"Summer"}},
                            new Year {Name="August", season = new List<string> {"Summer"}},
                            new Year {Name="December", season = new List<string> {"Winter"}},
                            new Year {Name="January", season = new List<string> {"Winter"}},
                            new Year {Name="February", season = new List<string> {"Winter"}}
                        };

                        var selectMounth = from smounth in year
                                           from mounthSeason in smounth.season
                                           where mounthSeason == enterSeason
                                           select smounth;
                        foreach (Year years in selectMounth)
                            Console.WriteLine(years.Name);
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        IEnumerable<string> sortedByName = mounth.OrderBy(i => i);
                        foreach (string str in sortedByName)
                            Console.WriteLine(" " + str);
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        var sortedByU = from smounth in mounth
                                        where smounth.Contains('u')
                                        where smounth.Length <= 4
                                        select smounth;
                        foreach (string str in sortedByU)
                            Console.WriteLine(str);
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 5:
                        List<Triangle> triangle = new List<Triangle>
                        {
                            new Triangle {name = "Triangle 1", side1 = 3, side2 = 4, side3 = 6 },
                            new Triangle {name = "Triangle 2", side1 = 3, side2 = 5, side3 = 7 },
                            new Triangle {name = "Triangle 3", side1 = 13, side2 = 12, side3 = 5 },
                            new Triangle {name = "Triangle 4", side1 = 4, side2 = 3, side3 = 4 },
                            new Triangle {name = "Triangle 5", side1 = 3, side2 = 4, side3 = 5 },
                            new Triangle {name = "Triangle 6", side1 = 11, side2 = 5, side3 = 11 },
                            new Triangle {name = "Triangle 7", side1 = 10, side2 = 12, side3 = 5 },
                            new Triangle {name = "Triangle 8", side1 = 6, side2 = 8, side3 = 10 },
                            new Triangle {name = "Triangle 9", side1 = 15, side2 = 15, side3 = 15 },
                            new Triangle {name = "Triangle 10", side1 =14, side2 = 14, side3 = 10 }
                        };

                        foreach (Triangle triangles in triangle)
                        {
                            Console.WriteLine("Name: " + triangles.name + "\nSide#1: " + triangles.side1 + "\nSide#2: " + triangles.side2 + "\nSide#3: " + triangles.side3);
                        }

                        Console.WriteLine("\n\nEquilateral triangle: ");
                        var selectEquilateralTriangle = from striangle in triangle
                                                        where striangle.side1 == striangle.side2 && striangle.side2 == striangle.side3 && striangle.side3 == striangle.side1
                                                        select striangle;
                        int count = 0;
                        foreach (Triangle triangles in selectEquilateralTriangle)
                        {
                            Console.WriteLine("Name: " + triangles.name);
                            count++;
                        }
                        Console.WriteLine("Quantity: " + count);
                        count = 0;

                        Console.WriteLine("\nRight triangle: ");
                        var selectRightTriangle = from striangle in triangle
                                                  where striangle.side1 == Math.Sqrt(Math.Pow(striangle.side2, 2) + Math.Pow(striangle.side3, 2)) || striangle.side2 == Math.Sqrt(Math.Pow(striangle.side1, 2) + Math.Pow(striangle.side3, 2)) || striangle.side3 == Math.Sqrt(Math.Pow(striangle.side1, 2) + Math.Pow(striangle.side2, 2))
                                                  select striangle;
                        foreach (Triangle triangles in selectRightTriangle)
                        {
                            Console.WriteLine("Name: " + triangles.name);
                            count++;
                        }
                        Console.WriteLine("Quantity: " + count);
                        count = 0;

                        Console.WriteLine("\nIsosceles triangle: ");
                        var selectIsoscelesTriangle = from striangle in triangle
                                                      where striangle.side1 == striangle.side2 || striangle.side1 == striangle.side3 || striangle.side2 == striangle.side3
                                                      select striangle;
                        foreach (Triangle triangles in selectIsoscelesTriangle)
                        {
                            Console.WriteLine("Name: " + triangles.name);
                            count++;
                        }
                        Console.WriteLine("Quantity: " + count);
                        count = 0;

                        Console.WriteLine("\nVersatile triangle: ");
                        var selectVersatileTriangle = from striangle in triangle
                                                      where striangle.side1 != striangle.side2 && striangle.side1 != striangle.side3 && striangle.side2 != striangle.side3 && striangle.side1 != Math.Sqrt(Math.Pow(striangle.side2, 2) + Math.Pow(striangle.side3, 2)) && striangle.side2 != Math.Sqrt(Math.Pow(striangle.side1, 2) + Math.Pow(striangle.side3, 2)) && striangle.side3 != Math.Sqrt(Math.Pow(striangle.side1, 2) + Math.Pow(striangle.side2, 2))
                                                      select striangle;
                        foreach (Triangle triangles in selectVersatileTriangle)
                        {
                            Console.WriteLine("Name: " + triangles.name);
                            count++;
                        }
                        Console.WriteLine("Quantity: " + count);
                        count = 0;

                        Console.WriteLine("\n-----------Actions-------------");
                        Console.WriteLine("Min perimeter:");
                        var selectPerimeter = from striangle in triangle
                                              where striangle.side1 + striangle.side2 + striangle.side3 < 12
                                              select striangle;
                        foreach (Triangle triangles in selectPerimeter)
                        {
                            Console.WriteLine("Name: " + triangles.name);
                        }

                        int n, m;
                        Console.Write("Enter the range of sides: ");
                        Console.Write("\nn>>");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("m>>");
                        m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Range: [" + n + ", " + m + "]");

                        Console.WriteLine("The lengths of sides in the range from n to m:");
                        var selectRange = from striangle in triangle
                                          where (striangle.side1 > n && striangle.side1 < m) || (striangle.side2 > n && striangle.side2 < m) || (striangle.side3 > n && striangle.side3 < m)
                                          select striangle;
                        foreach (Triangle triangles in selectRange)
                        {
                            Console.WriteLine("Name: " + triangles.name + "\nSide#1: " + triangles.side1 + "\nSide#2: " + triangles.side2 + "\nSide#3: " + triangles.side3);
                        }

                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 0:
                        break;
                }
            } while (caseSwitch != 0);
        }
    }
}
