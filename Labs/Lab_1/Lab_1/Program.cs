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
            bool etc4 = (bool)pt15;
            short etc5 = (short)pt9;

            var myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            foreach(var i in myList )
            {
                Console.WriteLine(i);
            }

        }
    }
}
