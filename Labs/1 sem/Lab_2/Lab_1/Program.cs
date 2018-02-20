using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {

        string SovietUnion(int a) { return "Развалился"; }

        static void Main(string[] args)
        {
            /////ТИПЫ/////

            //примитивный тип (primitive type)
            sbyte pt1 = 8;
            short pt2 = 16;
            int pt3 = 32;
            long pt4 = 64;
            byte pt5 = 8;
            ushort pt6 = 16;
            uint pt7 = 32;
            ulong pt8 = 64;
            char pt9 = 'b';
            bool pt10 = true;
            float pt11 = 32;
            double pt12 = 64;
            decimal pt13 = 128;
            string pt14 = "Hello world!";
            object pt15 = 1;
            
            //неявное приведение
            short itc1 = pt1;
            int itc2 = pt2;
            long itc3 = pt3;
            short itc4 = pt5;
            int itc5 = pt9;

            //явное приведение
            short etc1 = (short)pt6;
            int etc2 = (int)pt7;
            long etc3 = (long)pt8;
            float etc4 = (float)pt12;
            short etc5 = (short)pt9;

            //Упаковка и распаковка значимых типов
            int pack = 25;
            object obj = pack; //boxing
            int unpack = (int)obj; //unboxing

            //неявно типизированная переменная 
            var myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            foreach(var i in myList )
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Nullable
            int? x1 = null;
            Nullable<int> x2 = null;
            Console.WriteLine(x1 == x2);


            /////СТРОКИ/////

            //Строковые литераллы
            String path;
            String path1;

            path = "E:\\2 kurs\\ООП\\2-kurs";
            path1 = "E:\\2 kurs";

            Console.WriteLine(String.Compare(path, path1));

            String line1 = "Hello ";
            String line2 = "Big ";
            String line3 = "World. I'm Denis.";

            //Соединение строк
            String contact = String.Concat(line1, line2, line3);
            Console.WriteLine(contact);
            Console.WriteLine();

            //Выделение подстроки
            String subs = contact.Substring(3, 8);
            Console.WriteLine(subs);
            Console.WriteLine();

            //Копирование строки line3
            String cop = String.Copy(line3);
            Console.WriteLine(cop);
            Console.WriteLine();

            //Разделение строки на слова
            Char delimiter = ' ';
            String[] substrings = contact.Split(delimiter);
            foreach (var substring in substrings)
            {
                Console.WriteLine(substring);
            }
            Console.WriteLine();

            //Вставка подстроки на заданную позицию
            Console.WriteLine(line2.Insert(2, subs));
            Console.WriteLine();

            //Удаление заданной подстроки
            Console.WriteLine(line3.Remove(2, 6));
            Console.WriteLine();

            String line4 = "";
            String line5 = null;
            Console.WriteLine(line4);
            Console.WriteLine(line5);

            //StringBuilder
            StringBuilder sb = new StringBuilder("StringBuilder", 50);
            Console.WriteLine(sb.Append(" AppendFormat"));//Добавление в конец строки
            Console.WriteLine();
            Console.WriteLine(sb.Remove(2, 14));
            Console.WriteLine();
            Console.WriteLine(sb.Insert(2, "GOOD"));
            Console.WriteLine();

            /////МАССИВЫ/////

            //Массив-матрица
            int[,] array = new int[4, 4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = rnd.Next(0, 25);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();            
        }
    }
}
