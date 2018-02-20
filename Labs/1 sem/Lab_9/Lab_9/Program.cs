using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9 {
    class Programmer {
        ProgramLanguage[] PL;
        public event EventHandler<ProgramLanguage> pl = null;
        public Action action = null;

        public Programmer() {
            PL = new ProgramLanguage[10];
            for (int i = 0; i < PL.Length; i++) {
                PL[i] = new ProgramLanguage();
            }
        }

        public void Rename(int index, string str) {
            if (pl == null)
                return;

            action = () => PL[index].name = str; // замыкание
            pl(this, PL[index]); // событие
        }

        public void AddProperties(int index, string[] str) {
            if (pl == null)
                return;

            action = () => PL[index].properties = str; // замыкание
            pl(this, PL[index]); // событие
        }

        public override string ToString() {
            string str = "";
            for (int i = 0; i < PL.Length; i++) {
                str += i + ". " + PL[i].name;
                for (int j = 0; j < PL[i].propertiesCount; j++) {
                    str += "\n > " + PL[i].properties[j];
                }
                str += "\n";
            }

            return str;
        }
    }

    class ProgramLanguage : EventArgs {
        public string name { get; set; }
        public int propertiesCount { get; private set; }
        private string[] Properties = null;
        public string[] properties {
            get {
                return Properties;
            }
            set {
                if (100 <= propertiesCount + value.Length) {
                    throw new IndexOutOfRangeException("cannot add new item");
                }
                foreach (var i in value) {
                    Properties[propertiesCount++] = i;
                }
            }
        }
        private static int objCount = -1;

        public ProgramLanguage() {
            objCount++;
            name = "С";
            propertiesCount = 0;
            for (int i = 0; i < objCount; i++) {
                name += "+";
            }
            Properties = new string[100];
            properties = new string[] { "C based language" };
        }
    }

    class SomeClass {
        public static string SplitWordsByComma(string str) {
            char[] arr = str.ToCharArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == ' ') {
                    count++;
                }
            }
            char[] narr = new char[arr.Length + count + 1];
            for (int i = 0, j = 0; i < arr.Length; i++, j++) {
                if (arr[i] == ' ') {
                    narr[j] = ',';
                    j++;
                }
                narr[j] = arr[i];
            }

            str = new string(narr);
            Console.WriteLine("Output: " + str);
            return str;
        }

        public static string DeleteDots(string str) {
            char[] arr = str.ToCharArray();
            int length = arr.Length;

            for (int i = 0; i < length; i++) {
                if (arr[i] == '.') {
                    for (int j = i; j < arr.Length - 1; j++) {
                        arr[j] = arr[j + 1];
                    }
                    length--;
                }
            }

            char[] narr = new char[length];
            for (int i = 0; i < length; i++) {
                narr[i] = arr[i];
            }

            str = new string(narr);
            Console.WriteLine("Output: " + str);
            return str;
        }

        public static string ToUpperCase(string str) {
            Console.WriteLine("Output: " + str.ToUpper());
            return str.ToUpper();
        }

        public static string DeleteColons(string str) {
            char[] arr = str.ToCharArray();
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] == ':')
                {
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    length--;
                }
            }

            char[] narr = new char[length];
            for (int i = 0; i < length; i++)
            {
                narr[i] = arr[i];
            }

            str = new string(narr);
            Console.WriteLine("Output: " + str);
            return str;
        }

        public static string DeleteSemicolons(string str) {
            char[] arr = str.ToCharArray();
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] == ';')
                {
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    length--;
                }
            }

            char[] narr = new char[length];
            for (int i = 0; i < length; i++)
            {
                narr[i] = arr[i];
            }

            str = new string(narr);
            Console.WriteLine("Output: " + str);
            return str;
        }
    }

    class Program {
        static void Main(string[] args) {
            Programmer programmer = new Programmer();
            programmer.pl += delegate (object sender, ProgramLanguage pl) {
                Programmer d = (Programmer)sender;
                d.action(); // вызов замыкания
                string str = new string('-', 40);
                str += "\n";
                str += pl.name;
                for (int j = 0; j < pl.propertiesCount; j++) {
                    str += "\n > " + pl.properties[j];
                }
                Console.WriteLine("\n" + str);
            };

            int z = 0, buffer1 = 0, buffer2 = 0;
            string[] buffer;
            string TestString = "";

            Func<string, string> f = null;

            do {
                Console.Clear();
                Console.Write("1. Rename\n2. Add properties\n3. Task2\n0. Exit\n");
                Console.Write(">/");
                try {
                    z = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) {
                    Console.WriteLine("\nError: FormatException");
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
                Console.Clear();
                switch (z) {
                    default:
                        Console.Write("Error: wrong number\n");
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.WriteLine(programmer.ToString());
                        try {
                            Console.Write("Enter index: ");
                            buffer1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter number of properties: ");
                        }
                        catch (FormatException) {
                            Console.WriteLine("\nError: FormatException");
                            Console.Write("\nPress any key to continue...");
                            Console.ReadKey();
                        }
                        buffer = new string[1];
                        Console.Write(" >Enter new name: ");
                        buffer[0] = Console.ReadLine();
                        programmer.Rename(buffer1, buffer[0]);
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine(programmer.ToString());
                        try {
                            Console.Write("Enter index: ");
                            buffer1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter number of properties: ");
                            buffer2 = Convert.ToInt32(Console.ReadLine());
                            if (buffer2 <= 0)
                                throw new FormatException("must be positive");
                        }
                        catch (FormatException) {
                            Console.WriteLine("\nError: FormatException");
                            Console.Write("\nPress any key to continue...");
                            Console.ReadKey();
                        }
                        buffer = new string[buffer2];
                        for (int i = 0; i < buffer2; i++) {
                            Console.Write(" >Enter property " + i + ": ");
                            buffer[i] = Console.ReadLine();
                        }
                        programmer.AddProperties(buffer1, buffer);
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Enter string: ");
                        TestString = Console.ReadLine();

                        f = SomeClass.ToUpperCase;
                        TestString = f(TestString);
                        f = SomeClass.DeleteDots;
                        TestString = f(TestString);
                        f = SomeClass.DeleteColons;
                        TestString = f(TestString);
                        f = SomeClass.DeleteSemicolons;
                        TestString = f(TestString);
                        f = SomeClass.SplitWordsByComma;
                        TestString = f(TestString);

                        Console.WriteLine("\nResult: " + TestString);
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                }
            } while (z != 0);
        }
    }
}
