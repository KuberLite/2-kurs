using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //одномерный массив строк
            String[] array2 = { "one", "two", "three", "four", "five" };
            foreach (var i in array2)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.WriteLine("Length: " + array2.Length);
            Console.Write("Enter position for delete: ");
            String u = Console.ReadLine();
            int a = int.Parse(u);
            Console.Write("Enter the value: ");
            String val = Console.ReadLine();
            array2[a] = val;
            foreach (var i in array2)
            {
                Console.WriteLine(" " + i);
            }

            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];

            Console.WriteLine("First array: ");
            for (int i = 1; i < 2; i++)
            {
                String arrstr = Console.ReadLine();
                myArr[0][i] = int.Parse(arrstr);
            }
            Console.WriteLine();

            Console.WriteLine("Second array: ");
            for (int i = 1; i < 3; i++)
            {
                String arrstr2 = Console.ReadLine();
                myArr[1][i] = int.Parse(arrstr2);
            }
            Console.WriteLine();

            Console.WriteLine("Third array: ");
            for (int i = 1; i < 4; i++)
            {
                String arrstr3 = Console.ReadLine();
                myArr[2][i] = int.Parse(arrstr3);
            }

            Console.WriteLine("Third arrays: ");
            for (int i = 1; i < 2; i++)
            {
                Console.Write("{0}\t", myArr[0][i]);
            }
            Console.WriteLine();
            for (int i = 1; i < 3; i++)
            {
                Console.Write("{0}\t", myArr[1][i]);
            }
            Console.WriteLine();
            for (int i = 1; i < 4; i++)
            {
                Console.Write("{0}\t", myArr[2][i]);
            }
            Console.WriteLine();

            //неявно типизированные строки
            var typ = "Special text";
            var array3 = new Array[3];

            (int, string, char, string, ulong) five = (18, "I studing", 'c', "Practic", 123456);
            Console.WriteLine("All: " + $" {five}");
            Console.WriteLine("First: " + five.Item1);
            Console.WriteLine("Third: " + five.Item3);
            Console.WriteLine("Fourth: " + five.Item4);

            Console.WriteLine();

            (int, string, char, string, ulong) six = (18, "TOPKEK", 'c', "DSTU", 123476);
            Console.WriteLine("All: " + $" {five}");
            Console.WriteLine("First: " + six.Item1);
            Console.WriteLine("Third: " + six.Item3);
            Console.WriteLine("Fourth: " + six.Item4);

            Console.WriteLine(five.Equals (six));

            int[] arr7 = new int[4] { 1, 2, 3, 4 };
            var myFunc = GetValue(arr7, "Gleb");
            Console.WriteLine("MaxValue:{0}\nMinValue:{1}\nTotal:{2}\nFirstLetter:{3}", myFunc.Item1, myFunc.Item2, myFunc.Item3, myFunc.Item4);
            Console.ReadKey();

        }

        static Tuple<int, int, int, char> GetValue(int[] arr, string str)
        {
            int maxValue = arr.Max<int>();
            int minValue = arr.Min<int>();
            int total = 0;
            foreach (var key2 in arr)
            {
                total = total + key2;
            }
            char firstLetter = str[0];
            return Tuple.Create<int, int, int, char>(maxValue, minValue, total, firstLetter);
        }

    }
}
