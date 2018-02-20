using System;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector reflector = new Reflector();

            try
            {
                reflector.Task1("lab12.TestClass");
                reflector.Task2("lab12.TestClass");
                reflector.Task3("lab12.TestClass");
                reflector.Task4("lab12.TestClass");
                reflector.Task5("lab12.TestClass");
                reflector.Task6("lab12.TestClass", "Sum");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
