using System;
using System.Reflection;
using System.IO;

namespace lab12
{
    class Reflector
    {
        private Type type = null;

        public void Task1(string className)
        {
            type = Type.GetType(className);
            if (type == null)
            {
                throw new NullReferenceException("Incorrect className: class does not exits");
            }

            var members = type.GetMembers();
            try
            {
                using (StreamWriter sw = new StreamWriter("D:/" + className + "Info.txt", false, System.Text.Encoding.Default))
                {
                    foreach (var i in members)
                    {
                        sw.WriteLine(i);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.WriteLine("Task1:\n " + className + " info saved to: D:/" + className + "Info.txt");
        }

        public void Task2(string className)
        {
            type = Type.GetType(className);
            if (type == null)
            {
                throw new NullReferenceException("Incorrect className: class does not exits");
            }

            var members = type.GetMethods();
            Console.WriteLine("\nTask2:");
            foreach (var i in members)
            {
                Console.WriteLine(" " + i);
            }
        }

        public void Task3(string className)
        {
            type = Type.GetType(className);
            if (type == null)
            {
                throw new NullReferenceException("Incorrect className: class does not exits");
            }

            var members = type.GetFields();
            Console.WriteLine("\nTask3:");
            foreach (var i in members)
            {
                Console.WriteLine(" " + i);
            }
        }

        public void Task4(string className)
        {
            type = Type.GetType(className);
            if (type == null)
            {
                throw new NullReferenceException("Incorrect className: class does not exits");
            }

            var members = type.GetInterfaces();
            Console.WriteLine("\nTask4:");
            foreach (var i in members)
            {
                Console.WriteLine(" " + i);
            }
        }

        public void Task5(string className)
        {
            type = Type.GetType(className);
            if (type == null)
            {
                throw new NullReferenceException("Incorrect className: class does not exits");
            }

            var members = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("\nTask5:");
            foreach (var i in members)
            {
                if (i.ReturnType == typeof(int))
                {
                    Console.WriteLine(" " + i);
                }
            }
        }

        public void Task6(string className, string methodName)
        {
            type = Type.GetType(className);
            if (type == null)
            {
                throw new NullReferenceException("Incorrect className: class does not exits");
            }

            int[] arr = new int[2];
            try
            {
                using (StreamReader sr = new StreamReader("D:/test.txt", System.Text.Encoding.Default))
                {
                    arr[0] = Convert.ToInt32(sr.ReadLine());
                    arr[1] = Convert.ToInt32(sr.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.WriteLine("\nTask6:");
            var members = type.GetMethods();
            foreach (var i in members)
            {
                if (i.Name == methodName)
                {
                    Console.WriteLine(" Method " + methodName + " returns: " + i.Invoke(new TestClass(), new object[2] { arr[0], arr[1] }));
                }
            }

        }
    }
}
