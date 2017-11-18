
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создать Планету Земля. 
 *Найти все государства на заданном континенте. 
 *Подсчитать количество морей.
 *Вывести острова по алфавиту.*/

namespace Lab6
{
    enum NameState { Canada, USA, Mexico, Cuba, Panama, Jamaica }

    interface IOcean<T>
    { 
        string ToSence();
    }
    class Sea : IOcean<Sea>
    {
        public string ToSence()
        {
            return "Poland forever";
        }
    }
    class Island : IOcean<Island>
    {
        private static int objCount = 0;
        private readonly string name;
        private int count;
        private static Random randNum = new Random();

        public Island()
        {
            objCount++;
            name = "Island" + objCount;
            GenerateIsland();
        }

        public string getName()
        {
            return name;
        }
        public int getCount()
        {
            return count;
        }
        public void GenerateIsland()
        {
            count = randNum.Next(1, 1000);
        }
        public string ToSence()
        {
            return "island eee";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Message add = new Message();    
            Message add2 = new Message();  
            for(int i = 0; i < 50; i++)
            {
                add.Add();
            }

            for(int i = 0; i < 300; i++)
            {
                add2.Add();
            }
            int z = 0;
            int buffer = 0;
            do
            {
                Console.Clear();
                Console.Write("1. Add Element\n2. Delete Element\n3. Print all name of island\n4. How many countries on the continent\n5. Print number of seas\n0. Exit\n");
                Console.Write("#");
                z = Convert.ToInt32(Console.ReadLine());
                switch (z)
                {
                    default:
                        Console.Write("Error: wrong number\n");
                        Console.ReadKey();
                        break;
                    case 1:
                        add.Add();
                        Console.WriteLine("One sea added");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Enter the item you want to delete");
                        buffer = Convert.ToInt32(Console.ReadLine());
                        add.DeleteAt(buffer);
                        Console.WriteLine("Element number" + buffer + "was deleted");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Names of all islands\n");
                        add.PrintNamesIsland();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Countries on the Continent");
                        str = Console.ReadLine();
                        add.PrintStateInContinent(str);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("\nThere is " + add.getNumberOfSeas() + " seas in the world");
                        Console.ReadKey();
                        break;
                    case 0:
                        break;
                }
            } while (z != 0);

        }
    }
}
