using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Launch("Windows 8.1");
            Console.WriteLine(computer.OS.Name);

            computer.OS = OS.GetInstance("Windows 10");
            Console.WriteLine(computer.OS.Name);

            Console.ReadKey();
        }
    }
}
