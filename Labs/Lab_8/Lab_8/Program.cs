using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8
{
    interface ICollectionType<T> where T : IComparable
    {
        void Add(T value);
        void Delete(int index);
        void Print();
    }

    class CollectionType<T> : ICollectionType<T> where T : IComparable
    {
        List<T> list = null;

        public CollectionType()
        {
            list = new List<T>();
        }

        public void Add(T value)
        {
            list.Add(value);
        }

        public void Delete(int index)
        {
            try
            {
                list.RemoveAt(index);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("\nError: ArgumentOutOfRangeException\n");
            }
        }

        public void Print()
        {
            for(int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i].ToString());
            }
        }
    }

    class Program
    {
        public const int count_stack = 12;

        class GetStack 
        {
            public Stack<int> myStack = new Stack<int>();
            public Stack<int> myStack2 = new Stack<int>();

            public int[] arr = new int[count_stack];

            public GetStack()
            {
                Random rand = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < count_stack; i++)
                {
                    myStack.Push(rand.Next(1, 100));
                }
            }

            public static GetStack operator +(int h, GetStack stack)
            {
                stack.myStack.Push(h);
                return stack;
            }
            public static GetStack operator --(GetStack stack)
            {
                stack.myStack.Pop();
                return stack;
            }

            public static bool operator true(GetStack stack)
            {
                if (stack.myStack != null)
                    return true;
                return false;
            }

            public static bool operator false(GetStack stack)
            {
                if (stack.myStack == null)
                    return false;
                return true;
            }

            public static GetStack operator >(GetStack stack, GetStack stack2)
            {
                int count = 0;
                foreach (int value in stack.myStack)
                {
                    stack.arr[count] = value;
                    count++;
                }

                Array.Sort(stack.arr);

                Console.WriteLine("------------After .Sort-------------");

                for (int i = 0; i < count_stack; i++)
                {
                    Console.WriteLine("elem #" + i + ": " + stack.arr[i]);
                }



                foreach (int value in stack.arr)
                {
                    stack2.myStack2.Push(value);
                }

                Console.WriteLine("------------Second Stack-------------");
                count = 0;
                foreach (int value in stack2.myStack2)
                {
                    count++;
                    Console.WriteLine("elem #" + count + ": " + value);
                }
                return stack2;
            }

            public static GetStack operator <(GetStack stack, GetStack stack2)
            {
                return stack;
            }

            public override string ToString()
            {
                string str = "";
                str += "Stack1 = \n";
                foreach (var i in myStack) {
                    str += " " + i + "\n";
                }
                str += "\n Stack2 = \n";
                foreach (var i in myStack2) {
                    str += " " + i + "\n";
                }
                return str;
            }

        }

        static void Main(string[] args)
        {
            CollectionType<task> Task = new CollectionType<task>();

            GetStack forstack = new GetStack();
            GetStack forstack2 = new GetStack();
            GetStack forstack3 = new GetStack();
            try
            {
                forstack = 3 + forstack;

                int count = 0;

                foreach (int value in forstack.myStack)
                {
                    count++;
                    Console.WriteLine("elem #" + count + ": " + value);
                }

                Console.WriteLine("------------After .Pop-------------");

                forstack--;

                count = 0;
                foreach (int value in forstack.myStack)
                {
                    count++;
                    Console.WriteLine("elem #" + count + ": " + value);
                }

                if (true)
                {
                    Console.WriteLine("Stack isn't empty");
                }

                forstack3 = forstack > forstack2;


                //---------------------------------------

                Console.WriteLine("Средний элемент #" + forstack.myStack.CountPoint() + "\nКол-во строк в стеке: " + forstack.myStack.CountPointElem());
                File.WriteAllText("E:\\2 kurs\\ООП\\2-kurs\\Labs\\Lab_8\\Lab_8\\new.txt", forstack2.ToString());

                MakeId.UnderMakeId owner = new MakeId.UnderMakeId();

                owner.UnderMakeID();

            }
            catch
            {

            }
            finally
            {
                Console.WriteLine("This is finally");
            }

        }
    }

    public class MakeId
    {
        public void MakeID()
        {
            Console.WriteLine("MakeId");
        }
        public class UnderMakeId
        {
            public void UnderMakeID()
            {
                int id = 6;
                string name = "Denis";
                string nameoforganization = "BelDen";
                var date = DateTime.Today;

                Console.WriteLine("ID = " + id + "\nName is " + name + "\nName of organization " + nameoforganization + "\nDate: " + date.ToString("D"));
            }
        }
    }

    static class GetElem
    {
        static public int CountPoint(this Stack<int> num)
        {
            int snum;
            snum = num.Count() / 2;
            num.Push(snum);
            return snum;
        }

        static public int CountPointElem(this Stack<int> num)
        {
            return num.Count();
        }
    }
}
